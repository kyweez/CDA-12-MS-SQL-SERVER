using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Controls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Globalization;

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

        private SqlDataReader CurrentSqlDataReader
        {
            get; set;
        }

        private SqlParameter SupplierIdParameter
        {
            get; set;
        }


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
            newItem.Tag = currentSqlDataReader.GetValue(0);
            newItem.Content = currentSqlDataReader.GetString(1);
            comboBoxSupplierList.Items.Add(newItem.Content);
        }
        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void comboBoxSupplierList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            listViewResults.Items.Clear();
            if (comboBoxSupplierList.SelectedIndex == 0)
                TriggerAllSupplierOrder();
            else
                TriggerSingleSupplierOrder();
        }

        private void TriggerAllSupplierOrder()
        {
            try
            {
                CurrentSqlCommand.CommandType = CommandType.StoredProcedure;
                CurrentSqlCommand.CommandText = "GetAllOrderProcedure";
                CurrentSqlDataReader = CurrentSqlCommand.ExecuteReader();
                DisplayOrders(CurrentSqlDataReader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CurrentSqlDataReader.Close();
            }
        }

        private void TriggerSingleSupplierOrder()
        {
            try
            {
                CurrentSqlCommand.CommandType = CommandType.StoredProcedure;
                CurrentSqlCommand.CommandText = "GetSingleSupplierOrderProcedure";
                SupplierIdParameter = new SqlParameter("@id_supplier", DbType.Int32);
                SupplierIdParameter.Value = comboBoxSupplierList.SelectedIndex;
                CurrentSqlCommand.Parameters.Add(SupplierIdParameter);
                CurrentSqlDataReader = CurrentSqlCommand.ExecuteReader();
                DisplayOrders(CurrentSqlDataReader);
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

        private void DisplayOrders(SqlDataReader _reader)
        {
            if (_reader.HasRows)
            {
                while (_reader.Read())
                {
                    string[] row = new string[]
                    {
                        _reader["id_order"].ToString(),
                        _reader["order_date"].ToString().Substring(0,10),
                        _reader["order_comments"].ToString(),
                        _reader["sup_name"].ToString(),
                    };
                    listViewResults.Items.Add(new ListViewItem(row));
                }
            }
        }
    }
}