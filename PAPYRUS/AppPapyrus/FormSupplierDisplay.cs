using System;
using System.Windows.Forms;

namespace AppPapyrus
{
    public partial class FormSupplierDisplay : Form
    {
        public FormSupplierDisplay(string _name, string _address, string _zipCode, string _city, string _contactName, byte _satisfaction)
        {
            InitializeComponent();
            textBoxName.Text = _name;
            textBoxAddress.Text = _address;
            textBoxZipCode.Text = _zipCode;
            textBoxCity.Text = _city;
            textBoxContact.Text = _contactName;
            textBoxSatisfaction.Text = _satisfaction.ToString();
            AcceptButton = buttonBack;
            CancelButton = buttonBack;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}