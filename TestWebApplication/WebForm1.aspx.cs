using System;
using UtilityClasses;

namespace TestWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNExtPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void btnSendInformation_Click(object sender, EventArgs e)
        {
            string emailDomain = "";

            UtilityClasses.EmailSupport emailSupport = new EmailSupport();

            if (ddlCarrier.SelectedItem.Text == "ATT")
                emailDomain = "txt.att.net";
            else
                emailDomain = "vtext.com";

            txtBoxMsg.ForeColor = System.Drawing.Color.Black;

            if (emailSupport.SendATextMessage(txtboxFromAddress.Text, txtboxPassword.Text, txtboxCellNumber.Text + "@" + emailDomain, "", txtBoxMsg.Text) == true)
                txtBoxMsg.ForeColor = System.Drawing.Color.Green;
        }

        protected void txtBoxMsg_TextChanged(object sender, EventArgs e)
        {            
        }

        protected void txtboxFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}