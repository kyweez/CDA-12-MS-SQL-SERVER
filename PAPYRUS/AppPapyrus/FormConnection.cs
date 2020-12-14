using ClassLibrarySQLServerDataAccess;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class FormConnection : Form
    {
        private ConnectionSqlServer CurrentConnection
        {
            get; set;
        }

        public FormConnection(ConnectionSqlServer _connection)
        {
            InitializeComponent();
            CurrentConnection = _connection;
            CurrentConnection.ConnectionFailed += CurrentConnection_ConnectionFailed;
            CurrentConnection.StatusChanged += CurrentConnection_StatusChanged;
            foreach (string serverName in CurrentConnection.ServerNameList)
                comboBoxServer.Items.Add(serverName);
            foreach (string dataBaseName in CurrentConnection.DataBaseNameList)
                comboBoxDataBase.Items.Add(dataBaseName);
        }

        private void CurrentConnection_StatusChanged(ConnectionSqlServer sender)
        {
            labelStatus.Text = $"Connection status : {CurrentConnection.SqlConnect.State}";
        }

        private void CurrentConnection_ConnectionFailed(string failedConnection)
        {
            richTextBoxMessage.Text = failedConnection;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (CurrentConnection.ConnectToDatabase(comboBoxServer.Text, comboBoxServer.Text))
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                richTextBoxMessage.Visible = false;
                richTextBoxMessage.Clear();
            }
            else
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                richTextBoxMessage.Visible = true;
                CurrentConnection.SqlConnect.Close();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            labelStatus.Text = $"Connection status : {CurrentConnection.SqlConnect.State}";
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            CurrentConnection.SqlConnect.Close();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
