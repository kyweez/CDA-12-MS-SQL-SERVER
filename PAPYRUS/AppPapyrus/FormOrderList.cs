using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Controls;

namespace AppPapyrus
{
    public partial class FormOrdersList : Form
    {
        private SqlConnection CurrentSqlConnect
        {
            get; set;
        }

        private SqlCommand CurrentSqlCommand
        {
            get; set;
        }

        private SqlDataReader CurrentSqlDataReader;

        public FormOrdersList(SqlConnection _sqlConnection)
        {
            InitializeComponent();
            CurrentSqlConnect = _sqlConnection;
            CurrentSqlCommand = new SqlCommand();
            CreateComboBoxList();
        }

        private void CreateComboBoxList()
        {
            try
            {
                comboBoxSupplierList.Items.Add("All");
                CurrentSqlCommand.Connection = CurrentSqlConnect;
                CurrentSqlCommand.CommandType = CommandType.Text;
                CurrentSqlCommand.CommandText = "SELECT id_supplier, sup_name FROM t_suppliers";
                CurrentSqlDataReader = CurrentSqlCommand.ExecuteReader();
                if (CurrentSqlDataReader.HasRows)
                {
                    while (CurrentSqlDataReader.Read())
                        AddItemInComboBox(CurrentSqlDataReader);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CurrentSqlDataReader?.Close();
            }
        }

        private void AddItemInComboBox(SqlDataReader currentSqlDataReader)
        {
            ComboBoxItem newItem = new ComboBoxItem();
            newItem.Tag = currentSqlDataReader.GetString(0);
            newItem.Content = currentSqlDataReader.GetString(1);
            comboBoxSupplierList.Items.Add(newItem);
        }

        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void comboBoxSupplierList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentSqlCommand.CommandType = CommandType.StoredProcedure;
        }
    }
}
