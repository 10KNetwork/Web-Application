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
       
        Dictionary<string, kmembers> kmemberdictionary = new Dictionary<string, kmembers>();
        private NameValueCollection Teams = new NameValueCollection();
        private NameValueCollection Repository = new NameValueCollection();
        const string token = "MzIyYTg4ZTVjNWMyZjAwZDA5YjVmYzJiNTQ1Y2M3ZjliN2E3NTc0MA==";
        const string org ="10KNetwork";
        GitHubClient github = new GitHubClient(new ProductHeaderValue(org),
            new InMemoryCredentialStore(new Credentials(Encoding.UTF8.GetString(Convert.FromBase64String(token)))));


        protected async void Page_Load(object sender, EventArgs e)
        {
            //RegisterAsyncTask(new PageAsyncTask(LoadData));
            await LoadData();
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
        public async Task LoadData()
        {
            var teamsTask = github.Organization.Team.GetAll(org);
            var membersTask = github.Organization.Member.GetAll(org);
            var ReposTask = github.Repository.GetAllForOrg(org);

            await Task.WhenAll(teamsTask, membersTask, ReposTask);
            var teams = await teamsTask;
            var members = await membersTask;
            var Repos = await ReposTask;

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
            List<GitHubCommit> repoCommitList = new List<GitHubCommit>();

            //populate RepoCommitList
            var tasks = Repos.Select((repository) => processAsync(repository,items,repoCommitList)).ToArray();
            var container = await Task.WhenAll(tasks);
            foreach(var contained in container)
            {
                if(contained !=null)
                    repoCommitList.AddRange(contained);
            }



            foreach (var commit in repoCommitList)
            {
                try
                {
                    kmemberdictionary[commit.Author.Login].commitList.Add(commit);

                }
                catch (KeyNotFoundException) { }
                finally { }

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
            if (!IsPostBack)
            {

                Listl.DataSource = kmemberdictionary[MemberList.Items[0].Text].commitList;
                Listl.DataBind();
            }
            else
            {
                foreach(var mem in kmemberdictionary)
                {
                    mem.Value.createDescriptionList();
                }
            }

        }

        private async Task<IReadOnlyList<GitHubCommit>> processAsync(Octokit.Repository repository,List<string> items,
        List<GitHubCommit> repoCommitList)
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
            return commitlist;
        }
    }

    
}