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
            UpdateHMI();
        }

        private void UpdateHMI()
        {
            if (CurrentConnection.SqlConnect.State == System.Data.ConnectionState.Open)
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            else
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
            labelStatus.Text = $"Connection status : {CurrentConnection.SqlConnect.State}";
        }

        private void CurrentConnection_StatusChanged()
        {
            UpdateHMI();
        }

        private void CurrentConnection_ConnectionFailed(string failedConnection)
        {
            richTextBoxMessage.Text = failedConnection;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (CurrentConnection.ConnectToDatabase(comboBoxServer.Text, comboBoxDataBase.Text))
            {
                richTextBoxMessage.Visible = false;
                richTextBoxMessage.Clear();
            }
            else
            {
                richTextBoxMessage.Visible = true;
                CurrentConnection.SqlConnect.Close();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            CurrentConnection.DisconnectFromDatabase();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentConnection.SqlConnect.State == System.Data.ConnectionState.Open)
            {
                DialogResult dialogResult = MessageBox.Show
                (
                    "Database  connection is still open",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
                if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}