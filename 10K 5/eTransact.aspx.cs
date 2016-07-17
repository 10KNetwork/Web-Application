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
            MasterKey = "dd6f2c90-f075-012f-5b69-00155d864600",
            PrivateKey = "test_private_oDLVlm1eNyh0IsetdhdJvcl0ygA",
            PublicKey = "test_public_zzF3ywvX9DE-OSDNhUqKoaTI4wc",
            Token = "ca03737cf942cf644f36",
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
   

        // If you wish to accept payments directly on your service
        // Please note that the constructor requires a instance of both
        // MPowerSetup & MPowerStore Classes respectively
        MPowerOnsiteInvoice invoice_1 = new MPowerOnsiteInvoice(setup, store);
    }
}