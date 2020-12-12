using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class FormPapyrus : Form
    {
        private const string SERVER = "";
        private const string DATABASE_NAME = "db_papyrus";

        private SqlConnection SqlConnect
        {
            get;
            set;
        }

        private ConnectionStringSettings Config
        {
            get;
            set;
        }

        public FormPapyrus()
        {
            InitializeComponent();
            SqlConnect = new SqlConnection();
            Config = ConfigurationManager.ConnectionStrings[DATABASE_NAME];
            if (Config != null)
            {
                SqlConnect.ConnectionString = Config.ConnectionString;
                textBoxServer.Text = SqlConnect.DataSource;
                textBoxDatabase.Text = SqlConnect.Database;
            }
            SqlConnect.ConnectionString = Config.ConnectionString;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnect.Open();
                labelStatus.Text = $"Connection status : {SqlConnect.State}";
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                richTextBoxMessage.Visible = false;
                richTextBoxMessage.Clear();
            }
            catch (SqlException ex)
            {
                labelStatus.Text = $"Connection status : {SqlConnect.State}";
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                richTextBoxMessage.Visible = true;
                richTextBoxMessage.Text = ex.Message;
                SqlConnect.Close();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            labelStatus.Text = $"Connection status : {SqlConnect.State}";
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            SqlConnect.Close();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InputChanged(object sender, EventArgs e)
        {
            if (SqlConnect.State != ConnectionState.Open && textBoxServer.Text.Length != 0 && textBoxDatabase.Text.Length != 0)
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                SqlConnect.ConnectionString = $"Data Source = {textBoxServer.Text}; Initial Catalog = {textBoxDatabase}; Integrated Security = True";
            }
            else
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
        }

    }
}
