using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class FormSupplierSearch : Form
    {
        #region ############### CONSTANT ###############
        private const string DATABASE_NAME = "db_papyrus";
        #endregion

        #region ############### PROPERTIES ###############
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

        private SqlParameter SqlParameterSupplierId
        {
            get; set;
        }

        private ConnectionStringSettings ConfigString
        {
            get;
            set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public FormSupplierSearch(SqlConnection _sqlConnection)
        {
            InitializeComponent();
            CurrentSqlConnection = _sqlConnection;
            CurrentSqlCommand = new SqlCommand();
            if (ConfigString != null)
                CurrentSqlConnection.ConnectionString = ConfigString.ConnectionString;
        }
        #endregion

        #region ############### EVENTS ###############
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreateSupplier_Click(object sender, EventArgs e)
        {
            FormSupplierDisplay creation = new FormSupplierDisplay(CurrentSqlConnection);
            creation.Show();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentSqlCommand.Connection = CurrentSqlConnection;
                SqlParameterSupplierId = new SqlParameter("@id_supplier", DbType.Int32);
                SqlParameterSupplierId.Value = textBoxSupplierId.Text;
                CurrentSqlCommand.Parameters.Add(SqlParameterSupplierId);
                CurrentSqlCommand.CommandType = CommandType.Text;
                CurrentSqlCommand.CommandText = "SELECT * FROM t_suppliers WHERE id_supplier = @id_supplier";
                CurrentSqlDataReader = CurrentSqlCommand.ExecuteReader();

                if (CurrentSqlDataReader.HasRows)
                {
                    while (CurrentSqlDataReader.Read())
                    {
                        int id = (int)CurrentSqlDataReader["id_supplier"];
                        string name = CurrentSqlDataReader["sup_name"].ToString();
                        string address = CurrentSqlDataReader["sup_address"].ToString();
                        string zipcode = CurrentSqlDataReader["sup_zipcode"].ToString();
                        string city = CurrentSqlDataReader["sup_city"].ToString();
                        string contactName;
                        byte satisfaction;
                        if (!CurrentSqlDataReader.IsDBNull(5))
                            contactName = CurrentSqlDataReader["sup_contact_name"].ToString();
                        else
                            contactName = "";
                        if (!CurrentSqlDataReader.IsDBNull(6))
                            satisfaction = (byte)CurrentSqlDataReader["sup_satisfaction"];
                        else
                            satisfaction = 0;

                        FormSupplierDisplay result = new FormSupplierDisplay(CurrentSqlConnection, id, name, address, zipcode, city, contactName, satisfaction);
                        result.Show();
                    }
                }
                else
                {
                    errorProviderFailCode.SetError(textBoxSupplierId, "This order doesn't exist");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CurrentSqlDataReader.Close();
                CurrentSqlCommand.Parameters.Clear();
            }
        }

        private void textBoxSupplierId_TextChanged(object sender, EventArgs e)
        {
            errorProviderFailCode.Clear();
        }
        #endregion
    }
}