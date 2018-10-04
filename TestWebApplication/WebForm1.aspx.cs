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

        protected async void btnSendInformation_Click(object sender, EventArgs e)
        {
            string emailDomain = "";
            string errorText = "";

            UtilityClasses.EmailSupport emailSupport = new EmailSupport();

            Task<SqlConnection> conn = OpenDatabase();

            if (ddlCarrier.SelectedItem.Text == "ATT")
              emailDomain = "txt.att.net";
            else
              emailDomain = "vtext.com";

            bool sent = false;

            sent = emailSupport.SendATextMessage(txtboxFromAddress.Text, txtboxPassword.Text, txtboxCellNumber.Text + "@" + emailDomain, "", txtBoxMsg.Text, ref errorText);

            if (sent == true)
                txtBoxMsg.ForeColor = System.Drawing.Color.Green;
            else                            
                txtBoxMsg.ForeColor = System.Drawing.Color.Black;
            
            SqlConnection connection = await conn;

            string sqlInsert = "INSERT INTO Texts (TextMessage, TextDate) VALUES ('" + txtBoxMsg.Text + "','" + DateTime.Now.ToString() + "')";
            SqlCommand cmd = new SqlCommand(sqlInsert);
            cmd.Connection = connection;

            try
            {
                cmd.ExecuteNonQuery();
                lstboxPreviousTexts.Items.Add(txtBoxMsg.Text.Substring(0, Math.Min(txtBoxMsg.Text.Length, 15)));
            }
            catch (SqlException sqlEx)
            {
               sqlEx.GetHashCode();
            }
        }

        public async Task<SqlConnection> OpenDatabase()
        {            
            SqlConnection conn = new SqlConnection("Server = tcp:robsmobilesolutions.database.windows.net,1433; Initial Catalog = TextMessages; Persist Security Info = False; User ID=rhermann;Password=Herm!234; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
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