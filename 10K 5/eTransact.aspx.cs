using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MPowerPayments;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace _10K_5
{


    public partial class eTransact : System.Web.UI.Page
    {
        static MPowerSetup setup = new MPowerSetup()
        {
            MasterKey = "57f56f25-18c6-45ff-a14d-a1655a3bbf6d",
            PrivateKey = "live_private_F8898fWIF_MD4chAcZEm18XXmPI",
            PublicKey = "live_public_QD7633Gr9suHZmYW2EAZ0upmVzM",
            Token = "eda3ae0a019e88492830",
            Mode = "live"
        };

        static MPowerStore store = new MPowerStore()
        {
            Name = "The 10KNetwork",
            Tagline = "Awesome Community of Developers",
            PhoneNumber = "030200001",
            PostalAddress = "P. O. Box 10770 Accra North Ghana",
            LogoUrl = "http://www.mylogourl.com/photo.png"
        };
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        ////If you intend to use a simpler approach by redirecting to the MPower checkout page
        ////Please note that the constructor requires a instance of both
        //// MPowerSetup & MPowerStore Classes respectively
        ////MPowerCheckoutInvoice invoice = new MPowerCheckoutInvoice(setup, store);
        ////If you wish to accept payments directly on your serviceetup, store);


        ////Please note that the constructor requires a instance of both
        //// MPowerSetup & MPowerStore Classes respectively
        //MPowerOnsiteInvoice invoice_1 = new MPowerOnsiteInvoice(setup, store);

        protected void eWallet_Click(object sender, EventArgs e)
        {
            MPowerCheckoutInvoice invoice = new MPowerCheckoutInvoice(setup, store);
            store.Name = "The 10KNetwork";



            invoice.AddItem("Gold", 1, 1, 1);
            invoice.SetTotalAmount(1);

            invoice.Create();
            eWallet.Text = invoice.ResponseText;
            string url = "";
            string url1 = "";
            url = invoice.GetInvoiceUrl();
            url1 = invoice.GetReceiptUrl();


            Response.Redirect(url, true);

            if (url1 != "")
            {
                EmailHandler email = new EmailHandler();
                email.Send_Email_With_Given_Parameters("support@adroitbureau.com", "adroit01", "587", "smtp.gmail.com", true, false, "", "ehprimus09@gmail.com", "msg", "Hi there, it's working","Register.aspx");
                Response.Redirect(url1, true);
                Response.Write(String.Format("window.open('{0}','_blank')", ResolveUrl(url1)));
            }






            //if (invoice_1.Create("MPOWER_CUSTOMER_USERNAME_OR_PHONENO"))
            //{
            //    Response.Write(invoice_1.Token);
            //    Response.Write(invoice_1.Status);
            //    Response.Write(invoice_1.ResponseText);
            //}
            //else
            //{
            //    Response.Write(invoice_1.ResponseText);
            //    Response.Write(invoice_1.Status);
            //};


            //if (invoice_1.Charge("OPR_TOKEN", "CUSTOMER_CONFIRM_TOKEN"))
            //{
            //    Response.Write(invoice_1.Status);
            //    Response.Write(invoice_1.ResponseText);
            //    Response.Write(invoice_1.GetReceiptUrl());
            //    Response.Write(invoice_1.GetCustomerInfo("name"));
            //    Response.Write(invoice_1.GetCustomerInfo("email"));
            //    invoice.GetReceiptUrl();
            //    string url_1 = "";
            //    url_1 = invoice_1.GetReceiptUrl();
            //    Response.Redirect(url_1, true);
            //}

            //else
            //{
            //    Response.Write(invoice.Status);
            //    Response.Write(invoice.ResponseText);
            //}

            
        }
       
    }
}


    