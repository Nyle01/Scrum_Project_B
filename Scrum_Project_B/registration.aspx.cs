using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scrum_Project_B
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid= false;
            try
            {
                MailAddress address = new MailAddress(TxtbxEmail.Text);

                if (isValid == (address.Address == TxtbxEmail.Text))
                {
                    args.IsValid = true;
                }
            }
            catch (Exception)
            {
                args.IsValid = false;
                ValidEmailValidator.Text = "Email format is not Valid!";
                
            }


            
        }
    }
}