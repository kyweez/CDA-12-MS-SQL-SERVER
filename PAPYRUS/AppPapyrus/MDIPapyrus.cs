using ClassLibrarySQLServerDataAccess;
using System;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class MDIPapyrus : Form
    {
        private ConnectionSqlServer DBConnect
        {
            get; set;
        }

        private FormConnection ConnectionWindow
        {
            get; set;
        }

        public MDIPapyrus()
        {
            InitializeComponent();
            DBConnect = new ConnectionSqlServer();
            DBConnect.StatusChanged += DBConnect_StatusChanged;
            ConnectionWindow = new FormConnection(DBConnect);
        }

        private void DBConnect_StatusChanged(ConnectionSqlServer sender)
        {
            toolStripStatus.Text = sender.SqlConnect.State.ToString();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectionWindow.ShowDialog();
        }
    }
}
