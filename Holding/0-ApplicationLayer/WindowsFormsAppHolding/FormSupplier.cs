using ClassLibraryBusinessLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppHolding
{
    public partial class FormSupplier : Form
    {
        private string ConnectionString
        {
            get; set;
        }

        private Supplier CurrentSupplier
        {
            get; set;
        }

        public FormSupplier(Supplier _currentSupplier)
        {
            InitializeComponent();
            CurrentSupplier = _currentSupplier;
            ConnectionString = _currentSupplier.SqlConectionString;
            LoadTextBox();
        }

        private void LoadTextBox()
        {
            tbId.Text = CurrentSupplier.Id.ToString();
            tbName.Text = CurrentSupplier.Name;
            tbAddress.Text = CurrentSupplier.Address;
            tbZipCode.Text = CurrentSupplier.ZipCode;
            tbCity.Text = CurrentSupplier.City;
            tbContactName.Text = CurrentSupplier.ContactName;
            tbSatisfaction.Text = CurrentSupplier.Satisfaction.ToString();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            CurrentSupplier = new Supplier(
                ConnectionString,
                Int32.Parse(tbId.Text),
                tbContactName.Text,
                tbAddress.Text,
                tbZipCode.Text,
                tbCity.Text,
                tbContactName.Text,
                Byte.Parse(tbSatisfaction.Text)
                );
            CurrentSupplier.Save();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CurrentSupplier.Delete())
                MessageBox.Show("Object deleted from database");
        }
    }
}
