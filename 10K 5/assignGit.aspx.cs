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

namespace _10K_5
{
    public partial class assignGit : System.Web.UI.Page
    {
        public string description
        {
            get { return Repository[RepoList.SelectedItem.ToString()]; }
        }

        private NameValueCollection Teams = new NameValueCollection();
        private NameValueCollection Repository = new NameValueCollection();
        const string token = "10cdce596df42b41124ae9a12c1897dc6acb2fd9";
        const string org ="10KNetwork";
        GitHubClient github = new GitHubClient(new ProductHeaderValue(org),
            new InMemoryCredentialStore(new Credentials(token)));

        protected async void Page_Load(object sender, EventArgs e)
        {
            var teams = await github.Organization.Team.GetAll(org);
            var members = await github.Organization.Member.GetAll(org);
            var Repos = await github.Repository.GetAllForOrg(org);


            //Populate DropMenuList with teams
            List<string> _items = new List<string>();
            foreach (var team in teams)
            {
                _items.Add(team.Name);
                Teams.Add(team.Name, team.Id.ToString());
            }
            TeamList.DataSource =_items;
            TeamList.DataBind();

            
            //Populate DropMenuList with Repositories
            List<string> items = new List<string>();
            foreach (var repository in Repos)
            {
                
                items.Add(repository.Name);
                Repository.Add(repository.Name, repository.Description);
                
            }
            RepoList.DataSource = items;
            RepoList.DataBind();
            
            //Binding description to selected repo
            


            Descriptiontxt.DataBind();


            //Populate MemberList with Repositories
            List<string> itemz = new List<string>();
            MemberList.DataTextField = "Login";
            MemberList.DataSource = members;
            MemberList.DataBind();

            //Creating a User commits display
           


        }

        protected async void GitAssign_Click(object sender, EventArgs e)
        {
            var member = await github.Organization.Team.AddMembership(id:int.Parse(Teams[TeamList.SelectedItem.Text]), login: GitAcc.Text);
            
        }

        protected async void AddCollab_Click(object sender, EventArgs e)
        {
            await github.Repository.Collaborator.Add(org, RepoList.SelectedItem.Text, GitAcc.Text);
            
        }

        
    }
}