using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Octokit;
using Octokit.Internal;
using System.Threading.Tasks;

namespace _10K_5
{
    public partial class assignGit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void GitAssign_Click(object sender, EventArgs e)
        {
            const string token="";
            var github = new GitHubClient(new ProductHeaderValue("10kNetwork"),
                new InMemoryCredentialStore(new Credentials(token)));
            var member = await github.Organization.Team.AddMembership(id: 2078322, login: GitAcc.Text);
        }

    }
}