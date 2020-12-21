
namespace AppPapyrus
{
    partial class FormSupplierDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxSatisfaction = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelZipCodeCity = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.labelSatisfaction = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelIdentifier = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonCreateUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZipCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSatisfaction = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSatisfaction)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(191, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(279, 24);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(191, 84);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(279, 24);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(191, 142);
            this.textBoxZipCode.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxZipCode.MaxLength = 5;
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(78, 24);
            this.textBoxZipCode.TabIndex = 2;
            this.textBoxZipCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(191, 200);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxContact.MaxLength = 50;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(279, 24);
            this.textBoxContact.TabIndex = 4;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(322, 142);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxCity.MaxLength = 50;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(148, 24);
            this.textBoxCity.TabIndex = 3;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxSatisfaction
            // 
            this.textBoxSatisfaction.Location = new System.Drawing.Point(191, 258);
            this.textBoxSatisfaction.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxSatisfaction.MaxLength = 1;
            this.textBoxSatisfaction.Name = "textBoxSatisfaction";
            this.textBoxSatisfaction.Size = new System.Drawing.Size(46, 24);
            this.textBoxSatisfaction.TabIndex = 5;
            this.textBoxSatisfaction.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 18);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(29, 87);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(20);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 18);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // labelZipCodeCity
            // 
            this.labelZipCodeCity.AutoSize = true;
            this.labelZipCodeCity.Location = new System.Drawing.Point(29, 145);
            this.labelZipCodeCity.Margin = new System.Windows.Forms.Padding(20);
            this.labelZipCodeCity.Name = "labelZipCodeCity";
            this.labelZipCodeCity.Size = new System.Drawing.Size(105, 18);
            this.labelZipCodeCity.TabIndex = 12;
            this.labelZipCodeCity.Text = "Zip Code / City";
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(29, 203);
            this.labelContactName.Margin = new System.Windows.Forms.Padding(20);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(101, 18);
            this.labelContactName.TabIndex = 13;
            this.labelContactName.Text = "Contact name";
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Location = new System.Drawing.Point(29, 261);
            this.labelSatisfaction.Margin = new System.Windows.Forms.Padding(20);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(85, 18);
            this.labelSatisfaction.TabIndex = 14;
            this.labelSatisfaction.Text = "Satisfaction";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(358, 322);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 32);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelIdentifier
            // 
            this.labelIdentifier.AutoSize = true;
            this.labelIdentifier.Location = new System.Drawing.Point(300, 261);
            this.labelIdentifier.Margin = new System.Windows.Forms.Padding(20);
            this.labelIdentifier.Name = "labelIdentifier";
            this.labelIdentifier.Size = new System.Drawing.Size(62, 18);
            this.labelIdentifier.TabIndex = 13;
            this.labelIdentifier.Text = "Identifier";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(388, 258);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(46, 24);
            this.textBoxId.TabIndex = 6;
            // 
            // buttonCreateUpdate
            // 
            this.buttonCreateUpdate.Enabled = false;
            this.buttonCreateUpdate.Location = new System.Drawing.Point(32, 322);
            this.buttonCreateUpdate.Margin = new System.Windows.Forms.Padding(20);
            this.buttonCreateUpdate.Name = "buttonCreateUpdate";
            this.buttonCreateUpdate.Size = new System.Drawing.Size(112, 32);
            this.buttonCreateUpdate.TabIndex = 7;
            this.buttonCreateUpdate.Text = "Update";
            this.buttonCreateUpdate.UseVisualStyleBackColor = true;
            this.buttonCreateUpdate.Click += new System.EventHandler(this.buttonCreateUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(191, 322);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderZipCode
            // 
            this.errorProviderZipCode.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderZipCode.ContainerControl = this;
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCity.ContainerControl = this;
            // 
            // errorProviderContactName
            // 
            this.errorProviderContactName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContactName.ContainerControl = this;
            // 
            // errorProviderSatisfaction
            // 
            this.errorProviderSatisfaction.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSatisfaction.ContainerControl = this;
            // 
            // FormSupplierDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 378);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreateUpdate);
            this.Controls.Add(this.labelIdentifier);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelSatisfaction);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelZipCodeCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSatisfaction);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSupplierDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Display";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSatisfaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxSatisfaction;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelZipCodeCity;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Label labelSatisfaction;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelIdentifier;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonCreateUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderZipCode;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
        private System.Windows.Forms.ErrorProvider errorProviderContactName;
        private System.Windows.Forms.ErrorProvider errorProviderSatisfaction;
    }
}