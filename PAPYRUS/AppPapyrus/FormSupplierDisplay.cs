using System;
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
        #endregion

        #region ############### CONSTRUCTORS ###############
        public FormSupplierDisplay()
        {
            InitializeComponent();
            buttonUpdate.Text = "Create";
            buttonDelete.Enabled = false;
            textBoxId.Text = "-1";
        }

        public FormSupplierDisplay(int _id, string _name, string _address, string _zipCode, string _city, string _contactName, byte _satisfaction)
        {
            InitializeComponent();
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
            CancelButton = buttonBack;
        }
        #endregion

        #region ############### METHODS ###############
        private void ClearErrorProvider()
        {
            errorProviderName.Clear();
            errorProviderAddress.Clear();
            errorProviderZipCode.Clear();
            errorProviderCity.Clear();
            errorProviderContactName.Clear();
            errorProviderSatisfaction.Clear();
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

        private void SupplierUpdateTextChanged()
        {
            if (FormHasChanges() && CheckTextBoxInputValidity())
                buttonUpdate.Enabled = true;
            else
                buttonUpdate.Enabled = false;
        }

        private void SupplierCreationTextChanged()
        {
            if (CheckTextBoxInputValidity())
                buttonUpdate.Enabled = true;
            else
                buttonUpdate.Enabled = false;
        }

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
        #endregion

        #region ############### EVENTS ###############
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ClearErrorProvider();

            if (textBoxId.Text.Equals("-1"))
                SupplierCreationTextChanged();
            else
                SupplierUpdateTextChanged();
        }
        #endregion

    }
}