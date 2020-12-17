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

        private SqlParameter SqlParameterSupplierId
        {
            get; set;
        }

        private ConnectionStringSettings ConfigString
        {
            get;
            set;
        }

        public FormSupplierSearch(SqlConnection _sqlConnection)
        {
            InitializeComponent();
            CurrentSqlConnection = _sqlConnection;
            CurrentSqlCommand = new SqlCommand();
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
                        string name = CurrentSqlDataReader.GetString(1);
                        string address = CurrentSqlDataReader.GetString(2);
                        string zipcode = CurrentSqlDataReader.GetString(3);
                        string city = CurrentSqlDataReader.GetString(4);
                        string contactName;
                        byte satisfaction;
                        if (!CurrentSqlDataReader.IsDBNull(5))
                            contactName = CurrentSqlDataReader.GetString(5);
                        else
                            contactName = "";
                        if (!CurrentSqlDataReader.IsDBNull(6))
                            satisfaction = CurrentSqlDataReader.GetByte(6);
                        else
                            satisfaction = 0;

                        FormSupplierDisplay result = new FormSupplierDisplay(name, address, zipcode, city, contactName, satisfaction);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
