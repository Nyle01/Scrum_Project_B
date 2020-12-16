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
        public static void WriteDB(User user)
        {
            //// Hash
            string hashedPassword = SecurePasswordHasher.Hash(user.Password);
            string authentificator = GetAuthentificator(user.Firstname, user.Lastname);
        }
        //Verify
        //var result = SecurePasswordHasher.Verify("mypassword", hash);
        public static string GetAuthentificator(string firstname, string lastname)
        {
            string p1;
            string p2;
            p1 = lastname.Substring(0, 3);
            p2 = firstname[0].ToString();

            return $"{p1}{p2}".ToUpper();
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtbxPassw.Text.Equals(TxtbxPasswRep.Text))
            {
                User user = new User(txtbxFirstName.Text, txtbxLastName.Text, TxtbxEmail.Text, TxtbxOrganisation.Text, TxtbxPassw.Text);
                WriteDB(user);
                lblTest.Text = GetAuthentificator(txtbxFirstName.Text, txtbxLastName.Text);
            }
            else
            {
                RequiredFieldValidatorRepeatPassword.Text = "Passwords do NOT match!";
            }
        }

    }

}