using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace _10K_5
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        String queryStr;
        protected void Page_Load(object sender, EventArgs e)
        {
            //con.Open();
        }

        protected void RegisterEventMethod(object sender, EventArgs e)
        {
            registerUser();
        }

        private void registerUser()
        {
            String conString = System.Configuration.ConfigurationManager.ConnectionStrings["10KConnectionString"].ToString();

            //String conString = System.Configuration.ConfigurationManager.ConnectionStrings[@"server=DESKTOP-H2497G6\SQLEXPRESS; User=; Password=;Database=10K;"].ToString();
            
            con = new SqlConnection(conString);

            con.Open();

            queryStr = "";

            queryStr = "INSERT INTO Applicants (FName,LName,Email,Area,Ref,UName,Pass)" +
                "VALUES ('" + FName.Text + "','" + LName.Text + "','" + Email.Text + "','" + Area.SelectedItem + "','" + Ref.Text + "','" + UName.Text + "','" + CPass.Text + "')";

                cmd = new SqlCommand(queryStr, con);

            cmd.ExecuteReader();
                            
            con.Close();

            Label1.Visible = true;
            Label1.Text = "Congratulations! Your Application is being processed";
            FName.Text = "";
            LName.Text = "";
            Email.Text = "";
            Ref.Text = "";
            UName.Text = "";
            Pass.Text = "";
            CPass.Text = "";


        }
    }                       
}