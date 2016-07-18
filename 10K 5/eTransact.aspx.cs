using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MPowerPayments;

namespace _10K_5
{


    public partial class eTransact : System.Web.UI.Page
    {
        static MPowerSetup setup = new MPowerSetup()
        {
            MasterKey = "7d1c3b69-5372-44ac-b087-0af9960e7f42",
            PrivateKey = "test_private_mOCDCuHUK81hEzLVYGQCgWt_Ym8",
            PublicKey = "test_public_rZTueij37uQ9xoNYs_1qhpD9SWI",
            Token = "07d707c3ddb1038b910e",
            Mode = "test"
        };

        static MPowerStore store = new MPowerStore()
        {
            Name = "10KNetwork Store",
            Tagline = "This is my awesome tagline",
            PhoneNumber = "030200001",
            PostalAddress = "P. O. Box 10770 Accra North Ghana",
            LogoUrl = "http://www.mylogourl.com/photo.png"
        };
        protected void Page_Load(object sender, EventArgs e)
        {

        }
           

        // If you intend to use a simpler approach by redirecting to the MPower checkout page
        // Please note that the constructor requires a instance of both
        // MPowerSetup & MPowerStore Classes respectively
        MPowerCheckoutInvoice invoice = new MPowerCheckoutInvoice(setup, store);
        // If you wish to accept payments directly on your serviceetup, store);
   

        // Please note that the constructor requires a instance of both
        // MPowerSetup & MPowerStore Classes respectively
        MPowerOnsiteInvoice invoice_1 = new MPowerOnsiteInvoice(setup, store);

        protected void eWallet_Click(object sender, EventArgs e)
        {
            MPowerCheckoutInvoice invoice = new MPowerCheckoutInvoice(setup, store);
     store.Name = "freeuapp.com";
      


        invoice.AddItem("Gold", 1, 4.5, 4.5);
        invoice.SetTotalAmount(4.5);

        invoice.Create();
        eWallet.Text = invoice.ResponseText;
        string url = "";
          url  = invoice.GetInvoiceUrl();                     
         //  Response.Redirect(url,true);


        }
    }
}