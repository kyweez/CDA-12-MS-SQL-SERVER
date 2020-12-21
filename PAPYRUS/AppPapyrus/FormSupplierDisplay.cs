using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class FormSupplierDisplay : Form
    {
        #region ############### CONSTANTS ###############
        private const string NAME = @"^[a-zA-Z0-9\s]{1,50}$";
        private const string ADDRESS = @"^[a-zA-Z0-9\s]{1,100}$";
        private const string ZIPCODE = @"^[0-9]{5}$";
        private const string CITY = @"^[a-zA-Z0-9\s]{1,50}$";
        private const string CONTACT_NAME = @"^[a-zA-Z\s]{1,50}$";
        private const string SATISFACTION = @"^[0-5]{1}$";
        #endregion

        #region ############### PROPERTIES ###############
        private int CurrentId
        {
            get; set;
        }

        private string CurrentName
        {
            get; set;
        }

        private string CurrentAddress
        {
            get; set;
        }

        private string CurrentZipCode
        {
            get; set;
        }

        private string CurrentCity
        {
            get; set;
        }

        private string CurrentContactName
        {
            get; set;
        }

        private byte CurrentSatisfaction
        {
            get; set;
        }

        private SqlConnection CurrentConnection
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

        private SqlParameterCollection SqlParamColl
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTORS ###############
        public FormSupplierDisplay(SqlConnection _sqlConnection)
        {
            InitializeComponent();
            buttonCreateUpdate.Text = "Create";
            buttonDelete.Enabled = false;
            textBoxId.Text = "";
            CurrentConnection = _sqlConnection;
            CurrentSqlCommand = new SqlCommand();
            CancelButton = buttonBack;
        }

        public FormSupplierDisplay(SqlConnection _sqlConnection, int _id, string _name, string _address, string _zipCode, string _city, string _contactName, byte _satisfaction)
        {
            InitializeComponent();
            CurrentConnection = _sqlConnection;
            CurrentSqlCommand = new SqlCommand();

            //Properties
            CurrentId = _id;
            CurrentName = _name;
            CurrentAddress = _address;
            CurrentZipCode = _zipCode;
            CurrentCity = _city;
            CurrentContactName = _contactName;
            CurrentSatisfaction = _satisfaction;

            //TextBox
            textBoxId.Text = CurrentId.ToString();
            textBoxName.Text = CurrentName;
            textBoxAddress.Text = CurrentAddress;
            textBoxZipCode.Text = CurrentZipCode;
            textBoxCity.Text = CurrentCity;
            textBoxContact.Text = CurrentContactName;
            if (CurrentSatisfaction < 1)
                textBoxSatisfaction.Text = "";
            else
                textBoxSatisfaction.Text = CurrentSatisfaction.ToString();
            UpdateHMI();
            CancelButton = buttonBack;
        }
        #endregion

        #region ############### METHODS ###############
        private bool CheckTextBoxInputValidity()
        {
            bool isValidForm = true;
            if (textBoxName.Text.Length == 0 || !Regex.IsMatch(textBoxName.Text, NAME))
            {
                errorProviderName.SetError(textBoxName, "Invalid input");
                isValidForm = false;
            }
            if (textBoxAddress.Text.Length == 0 || !Regex.IsMatch(textBoxAddress.Text, ADDRESS))
            {
                errorProviderAddress.SetError(textBoxAddress, "Invalid input");
                isValidForm = false;
            }
            if (textBoxZipCode.Text.Length == 0 || !Regex.IsMatch(textBoxZipCode.Text, ZIPCODE))
            {
                errorProviderZipCode.SetError(textBoxZipCode, "Invalid input");
                isValidForm = false;
            }
            if (textBoxCity.Text.Length == 0 || !Regex.IsMatch(textBoxCity.Text, CITY))
            {
                errorProviderCity.SetError(textBoxCity, "Invalid input");
                isValidForm = false;
            }
            if (textBoxContact.Text.Length > 0 && !Regex.IsMatch(textBoxContact.Text, CONTACT_NAME))
            {
                errorProviderContactName.SetError(textBoxContact, "Invalid input");
                isValidForm = false;
            }
            if (textBoxSatisfaction.Text.Length > 0 && !Regex.IsMatch(textBoxSatisfaction.Text, SATISFACTION))
            {
                errorProviderSatisfaction.SetError(textBoxSatisfaction, "Invalid input");
                isValidForm = false;
            }
            return isValidForm;
        }

        private void ClearErrorProvider()
        {
            errorProviderName.Clear();
            errorProviderAddress.Clear();
            errorProviderZipCode.Clear();
            errorProviderCity.Clear();
            errorProviderContactName.Clear();
            errorProviderSatisfaction.Clear();
        }

        private void CreateSupplier()
        {
            CurrentSqlCommand = new SqlCommand();
            CurrentSqlCommand.Connection = CurrentConnection;
            SqlParamColl = CurrentSqlCommand.Parameters;

            try
            {
                SqlParameter paramOut = new SqlParameter("@id_supplier", SqlDbType.Int);
                paramOut.Direction = ParameterDirection.Output;

                SqlParamColl.Add(new SqlParameter("@sup_name", SqlDbType.VarChar)).Value = textBoxName.Text;
                SqlParamColl.Add(new SqlParameter("@sup_address", SqlDbType.VarChar)).Value = textBoxAddress.Text;
                SqlParamColl.Add(new SqlParameter("@sup_zipcode", SqlDbType.Char)).Value = textBoxZipCode.Text;
                SqlParamColl.Add(new SqlParameter("@sup_city", SqlDbType.VarChar)).Value = textBoxCity.Text;
                if (textBoxContact.Text.Length == 0)
                    SqlParamColl.Add(new SqlParameter("@sup_contact_name", SqlDbType.VarChar)).Value = DBNull.Value;
                else
                    SqlParamColl.Add(new SqlParameter("@sup_contact_name", SqlDbType.VarChar)).Value = textBoxContact.Text;
                if (textBoxSatisfaction.Text.Length == 0)
                    SqlParamColl.Add(new SqlParameter("@sup_satisfaction", SqlDbType.TinyInt)).Value = DBNull.Value;
                else
                    SqlParamColl.Add(new SqlParameter("@sup_satisfaction", SqlDbType.TinyInt)).Value = Byte.Parse(textBoxSatisfaction.Text);
                SqlParamColl.Add(paramOut);

                CurrentSqlCommand.CommandType = CommandType.StoredProcedure;
                CurrentSqlCommand.CommandText = "AddSupplierProcedure";
                CurrentSqlDataReader = CurrentSqlCommand.ExecuteReader();
                CurrentId = (int)paramOut.Value;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CurrentSqlDataReader.Close();
                SqlParamColl.Clear();
                CurrentSqlCommand = null;
                UpdateHMI();
            }
        }

        private bool FormHasChanges()
        {
            if (CurrentName != textBoxName.Text)
                return true;
            if (CurrentAddress != textBoxAddress.Text)
                return true;
            if (CurrentZipCode != textBoxZipCode.Text)
                return true;
            if (CurrentCity != textBoxCity.Text)
                return true;
            if (CurrentContactName != textBoxContact.Text)
                return true;
            if (CurrentSatisfaction == 0 && textBoxSatisfaction.Text.Length > 0)
                return true;
            else if (CurrentSatisfaction.ToString() != textBoxSatisfaction.Text)
                return true;
            return false;

        }

        private void SupplierCreationTextChanged()
        {
            if (CheckTextBoxInputValidity())
                buttonCreateUpdate.Enabled = true;
            else
                buttonCreateUpdate.Enabled = false;
        }

        private void SupplierUpdateTextChanged()
        {
            if (FormHasChanges() && CheckTextBoxInputValidity())
                buttonCreateUpdate.Enabled = true;
            else
                buttonCreateUpdate.Enabled = false;
        }

        private void UpdateHMI()
        {
            if (CurrentId == 0)
            {
                buttonCreateUpdate.Text = "Create";
                buttonDelete.Enabled = false;
                textBoxId.Text = "";
            }
            else
            {
                buttonCreateUpdate.Text = "Update";
                buttonDelete.Enabled = true;
                textBoxId.Text = CurrentId.ToString();
            }
        }

        private void UpdateSupplier()
        {
            CurrentSqlCommand = new SqlCommand();
            CurrentSqlCommand.Connection = CurrentConnection;
            SqlParamColl = CurrentSqlCommand.Parameters;

            try
            {
                SqlParamColl.Add(new SqlParameter("@sup_name", SqlDbType.VarChar)).Value = textBoxName.Text;
                SqlParamColl.Add(new SqlParameter("@sup_address", SqlDbType.VarChar)).Value = textBoxAddress.Text;
                SqlParamColl.Add(new SqlParameter("@sup_zipcode", SqlDbType.Char)).Value = textBoxZipCode.Text;
                SqlParamColl.Add(new SqlParameter("@sup_city", SqlDbType.VarChar)).Value = textBoxCity.Text;
                if (textBoxContact.Text.Length == 0)
                    SqlParamColl.Add(new SqlParameter("@sup_contact_name", SqlDbType.VarChar)).Value = DBNull.Value;
                else
                    SqlParamColl.Add(new SqlParameter("@sup_contact_name", SqlDbType.VarChar)).Value = textBoxContact.Text;
                if (textBoxSatisfaction.Text.Length == 0)
                    SqlParamColl.Add(new SqlParameter("@sup_satisfaction", SqlDbType.TinyInt)).Value = DBNull.Value;
                else
                    SqlParamColl.Add(new SqlParameter("@sup_satisfaction", SqlDbType.TinyInt)).Value = Byte.Parse(textBoxSatisfaction.Text);
                SqlParamColl.Add(new SqlParameter("@id_supplier", SqlDbType.Int)).Value = CurrentId;

                CurrentSqlCommand.CommandType = CommandType.StoredProcedure;
                CurrentSqlCommand.CommandText = "UpdateSupplierProcedure";
                CurrentSqlDataReader = CurrentSqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CurrentSqlDataReader.Close();
                SqlParamColl.Clear();
                CurrentSqlCommand = null;
                UpdateHMI();
            }
        }
        #endregion

        #region ############### EVENTS ###############
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentSqlCommand = new SqlCommand();
                CurrentSqlCommand.Connection = CurrentConnection;
                SqlParameter idToDelete = new SqlParameter("@id_supplier", DbType.Int32);
                idToDelete.Value = textBoxId.Text;
                CurrentSqlCommand.Parameters.Add(idToDelete);
                CurrentSqlCommand.CommandType = CommandType.Text;
                CurrentSqlCommand.CommandText = "DELETE FROM t_suppliers WHERE id_supplier = @id_supplier";
                if (CurrentSqlCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Delete OK");
                else
                    MessageBox.Show("Something went wrong, deletion canceled");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void buttonCreateUpdate_Click(object sender, EventArgs e)
        {
            if (CurrentId == 0)
                CreateSupplier();
            else
                UpdateSupplier();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ClearErrorProvider();
            if (CurrentId == 0)
                SupplierCreationTextChanged();
            else
                SupplierUpdateTextChanged();
            UpdateHMI();
        }
        #endregion

    }
}