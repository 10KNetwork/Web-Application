using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Octokit;
using Octokit.Internal;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Text;

namespace _10K_5
{
    public partial class assignGit : System.Web.UI.Page
    {
        public string description
        {
            get { return Repository[RepoList.SelectedItem.ToString()]; }
        }
        Dictionary<string, kmembers> kmemberdictionary = new Dictionary<string, kmembers>();
        private NameValueCollection Teams = new NameValueCollection();
        private NameValueCollection Repository = new NameValueCollection();
        const string token = "MzIyYTg4ZTVjNWMyZjAwZDA5YjVmYzJiNTQ1Y2M3ZjliN2E3NTc0MA==";
        const string org ="10KNetwork";
        GitHubClient github = new GitHubClient(new ProductHeaderValue(org),
            new InMemoryCredentialStore(new Credentials(Encoding.UTF8.GetString(Convert.FromBase64String(token)))));


        protected async void Page_Load(object sender, EventArgs e)
        {
            var teams = await github.Organization.Team.GetAll(org);
            var members = await github.Organization.Member.GetAll(org);
            var Repos = await github.Repository.GetAllForOrg(org);


            /// populate kmemberdictionary
            /// using user login ,user object key-pairs
            foreach (var user in members)
            {
                kmemberdictionary.Add(user.Login, new kmembers(user));
            }

            //Populate DropMenuList with teams
            List<string> _items = new List<string>();
            foreach (var team in teams)
            {
                _items.Add(team.Name);
                Teams.Add(team.Name, team.Id.ToString());
            }
            TeamList.DataSource = _items;
            TeamList.DataBind();


            //Populate DropMenuList with Repositories
            //organise repository commits under list of kmembers
            List<string> items = new List<string>();
            List<IReadOnlyList<GitHubCommit>> RepoCommitList = new List<IReadOnlyList<GitHubCommit>>();

            //populate RepoCommitList
            foreach (var repository in Repos)
            {

                items.Add(repository.Name);
                Repository.Add(repository.Name, repository.Description);
                IReadOnlyList<GitHubCommit> commitlist = null;
                try
                {
                    commitlist = await github.Repository.Commit.GetAll(owner: repository.Owner.Login, name: repository.Name);
                }
                catch (ApiException er)
                {
                }
                finally
                {
                    if (commitlist != null)
                    {
                        RepoCommitList.Add(commitlist);
                    }

                }
            }
            foreach (var commitlist in RepoCommitList)
            {
                foreach (var commit in commitlist)
                {
                    try
                    {
                        kmemberdictionary[commit.Author.Login].commitList.Add(commit);

                    }
                    catch (KeyNotFoundException) { }
                    finally { }

                }
            }


            //display through databinding repositories in RepoList
            RepoList.DataSource = items;
            RepoList.DataBind();

            //Binding description text to selected repository description
            Descriptiontxt.DataBind();



            //Populate MemberList with members
            if (!IsPostBack)
            {
               
                MemberList.DataTextField = "Value";
                MemberList.DataValueField = "Key";
                MemberList.DataSource = kmemberdictionary;
                MemberList.DataBind();
            }


            foreach (var member in kmemberdictionary)
            {
                member.Value.createDescriptionList();
            }

            //Creating a User commits display
            if (!IsPostBack) {
                
                Listl.DataSource = kmemberdictionary[MemberList.Items[0].Text].DescriptionList;
                Listl.DataBind();
            }
            



        }

        protected async void GitAssign_Click(object sender, EventArgs e)
        {
            var member = await github.Organization.Team.AddMembership(id:int.Parse(Teams[TeamList.SelectedItem.Text]), login: GitAcc.Text);
            
        }

        protected async void AddCollab_Click(object sender, EventArgs e)
        {
            await github.Repository.Collaborator.Add(org, RepoList.SelectedItem.Text, GitAcc.Text);
            
        }

        protected void Select(object sender, EventArgs e)
        {
            //Creating a User commits display
            Listl.DataSource = kmemberdictionary[MemberList.SelectedValue].DescriptionList;
            Listl.DataBind();
        }
        
    }
}