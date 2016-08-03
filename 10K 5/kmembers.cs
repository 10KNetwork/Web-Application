using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Octokit;
using System.Reflection;

namespace _10K_5
{
    public class kmembers
    {
        public User Parent { get; set; }
        public string login;
        public kmembers() { }
        public kmembers(User parent)
        {
            this.Parent = parent;
            this.login = parent.Login;
            commitList = new List<GitHubCommit>();
            
            //foreach (PropertyInfo prop in parent.GetType().GetProperties())
            //    GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(parent, null), null);
        }
        public List<GitHubCommit> commitList;
        public List<string> DescriptionList;
        public void createDescriptionList()
        {
            List<string> Description = new List<string>();
            foreach(var commit in commitList)
            {
                string Commitdescription = commit.Sha[0].ToString();
                Commitdescription += commit.Sha[1].ToString();
                Commitdescription += commit.Sha[2].ToString();
                Commitdescription += commit.Sha[3].ToString();
                Commitdescription += commit.Sha[4].ToString();
                Commitdescription += ": " + commit.Commit.Message;
                Description.Add(Commitdescription);
            }
            DescriptionList = Description;
            
        }
        public override string ToString()
        {
            return login;
        }
    }
}