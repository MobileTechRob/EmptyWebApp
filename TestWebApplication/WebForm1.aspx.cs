using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
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

            string errorText = "";

            SqlConnection conn = new SqlConnection("Server = tcp:robsmobilesolutions.database.windows.net,1433; Initial Catalog = TextMessages; Persist Security Info = False; User ID = {rhermann}; Password ={Herm!234}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");            
            SqlCommand sqlCmd = new SqlCommand("", conn);
            

            //"Server = tcp:robsmobilesolutions.database.windows.net,1433; Initial Catalog = TextMessages; Persist Security Info = False; User ID = { your_username }; Password ={ your_password}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;""

            if (emailSupport.SendATextMessage(txtboxFromAddress.Text, txtboxPassword.Text, txtboxCellNumber.Text + "@" + emailDomain, "", txtBoxMsg.Text, ref errorText) == true)
                txtBoxMsg.ForeColor = System.Drawing.Color.Green;
            else
                txtBoxMsg.Text = errorText;
        }

        public async Task<SqlConnection> SendText()
        {
            SqlConnection conn = new SqlConnection("Server = tcp:robsmobilesolutions.database.windows.net,1433; Initial Catalog = TextMessages; Persist Security Info = False; User ID = {rhermann}; Password ={Herm!234}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            await conn.OpenAsync();
            return conn;
        }

        protected void txtBoxMsg_TextChanged(object sender, EventArgs e)
        {            
        }

        protected void txtboxFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}