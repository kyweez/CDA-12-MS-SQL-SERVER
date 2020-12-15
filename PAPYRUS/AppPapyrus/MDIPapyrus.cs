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

        private void DBConnect_StatusChanged()
        {
            UpdateHMI();
        }

        private void UpdateHMI()
        {
            toolStripStatus.Text = DBConnect.SqlConnect.State.ToString();
            if (DBConnect.SqlConnect.State == System.Data.ConnectionState.Open)
            {
                menuFileConnect.Enabled = false;
                menuFileDisconnect.Enabled = true;
                suppliersMenu.Enabled = true;
                ordersMenu.Enabled = true;
                productsMenu.Enabled = true;
                buttonConnect.Text = "Disconnect";
            }
            else
            {
                menuFileConnect.Enabled = true;
                menuFileDisconnect.Enabled = false;
                suppliersMenu.Enabled = false;
                ordersMenu.Enabled = false;
                productsMenu.Enabled = false;
                buttonConnect.Text = "Connect";
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (DBConnect.SqlConnect.State != System.Data.ConnectionState.Open)
                ConnectionWindow.ShowDialog();
            else
                DBConnect.DisconnectFromDatabase();
        }

        private void menuSuppliersSearchSupplier_Click(object sender, EventArgs e)
        {
            FormSupplierSearch supplierSearch = new FormSupplierSearch(DBConnect.SqlConnect);
            supplierSearch.Show();
        }

        private void menuOrdersList_Click(object sender, EventArgs e)
        {
            FormOrdersList orderList = new FormOrdersList(DBConnect.SqlConnect);
            orderList.Show();
        }
    }
}
