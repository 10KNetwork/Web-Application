using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace _10K_5.Page_2
{
    public partial class first : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        String queryStr;

        public string FName { get; private set; }
        public string LName { get; private set; }
        public string UName { get; private set; }
        public string Email { get; private set; }
        public string CPass { get; private set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void EnterUser()
        {
            //String conString = System.Configuration.ConfigurationManager.ConnectionStrings["10KConnectionString"].ToString();

           SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-H2497G6\SQLEXPRESS;Initial Catalog=10K;Integrated Security=True");
            
            //con = new SqlConnection(conString);

            con.Open();

            //queryStr = "";
            string strValuef = Page.Request.Form["FName"].ToString();
            FName = strValuef;
            string strValuem = Page.Request.Form["LName"].ToString();
            LName = strValuem;
            string strValuel = Page.Request.Form["UName"].ToString();
            UName = strValuel;
            string strValue = Page.Request.Form["Email"].ToString();
            Email = strValue;
            string strValuep = Page.Request.Form["CPass"].ToString();
            CPass = strValuep;
            

            queryStr = "INSERT INTO Renewal (FName,LName,UName,Email,CPass)" +
                "VALUES ('" + FName + "','" + LName + "','" + UName + "','" + Email + "','" + CPass + "')";

            cmd = new SqlCommand(queryStr, con);

            cmd.ExecuteReader();

            con.Close();
        }

    }
}