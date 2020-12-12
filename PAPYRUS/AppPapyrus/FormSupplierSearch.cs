using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class FormSupplierSearch : Form
    {
        private const string DATABASE_NAME = "db_papyrus";

        private SqlConnection CurrentSqlConnection
        {
            get; set;
        }

        private SqlCommand CurrentSqlCommand
        {
            get; set;
        }

        private SqlDataReader CurrentSqlDataReader
        {
            get; set;
        }

        private SqlParameter CurrentSqlParameter
        {
            get; set;
        }

        private ConnectionStringSettings ConfigString
        {
            get;
            set;
        }

        public FormSupplierSearch()
        {
            InitializeComponent();
            CurrentSqlConnection = new SqlConnection();
            ConfigString = ConfigurationManager.ConnectionStrings[DATABASE_NAME];
            if (ConfigString != null)
                CurrentSqlConnection.ConnectionString = ConfigString.ConnectionString;
        }

        private void textBoxSupplierId_TextChanged(object sender, EventArgs e)
        {
            errorProviderFailCode.Clear();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CurrentSqlConnection.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
