using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace _10K_5
{
    public partial class Member : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        String queryStr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterEventMethod(object sender, EventArgs e)
        {
            registerMem();
        }

        private void registerMem()
        {
            String conString = System.Configuration.ConfigurationManager.ConnectionStrings["10KConnectionString"].ToString();           

            con = new SqlConnection(conString);

            con.Open();

            queryStr = "INSERT INTO Member (Email,Git,UName,Pass)" +
                "VALUES ('" + Email.Text + "','" + Git.Text + "','" + UName.Text + "','" + CPass.Text + "')";

            cmd = new SqlCommand(queryStr, con);

            cmd.ExecuteReader();

            con.Close();

            Label1.Visible = true;
            Label1.Text = "Congratulations! You are now a member of the 10K Network!";
            Email.Text = "";
            Git.Text = "";
            UName.Text = "";
            Pass.Text = "";
        }
    }


}