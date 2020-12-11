using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scrum_Project_B
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // webers push test
            //mattischnecki push
            // lol ddwed dw


        }
        protected void ValidateUser(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            int userId = 0;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Validate_User"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Connection = con;
                    con.Open();
                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                switch (userId)
                {
                    case -1:
                        dvMessage.Visible = true;
                        lblMessage.Text = "Username and/or password is incorrect.";
                        break;
                    case -2:
                        dvMessage.Visible = true;
                        lblMessage.Text = "Account has not been activated.";
                        break;
                    default:
                        if (!string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                        {
                            FormsAuthentication.SetAuthCookie(username, chkRememberMe.Checked);
                            Response.Redirect(Request.QueryString["ReturnUrl"]);
                        }
                        else
                        {
                            FormsAuthentication.RedirectFromLoginPage(username, chkRememberMe.Checked);
                        }
                        break;
                }
            }
        }
    }
}