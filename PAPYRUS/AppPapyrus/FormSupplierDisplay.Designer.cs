
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
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(191, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 24);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(191, 84);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(243, 24);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Enabled = false;
            this.textBoxZipCode.Location = new System.Drawing.Point(191, 142);
            this.textBoxZipCode.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(78, 24);
            this.textBoxZipCode.TabIndex = 2;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Enabled = false;
            this.textBoxContact.Location = new System.Drawing.Point(191, 200);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(243, 24);
            this.textBoxContact.TabIndex = 3;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Enabled = false;
            this.textBoxCity.Location = new System.Drawing.Point(286, 142);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(148, 24);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxSatisfaction
            // 
            this.textBoxSatisfaction.Enabled = false;
            this.textBoxSatisfaction.Location = new System.Drawing.Point(191, 258);
            this.textBoxSatisfaction.Margin = new System.Windows.Forms.Padding(20);
            this.textBoxSatisfaction.Name = "textBoxSatisfaction";
            this.textBoxSatisfaction.Size = new System.Drawing.Size(46, 24);
            this.textBoxSatisfaction.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 18);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(29, 87);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(20);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 18);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            // 
            // labelZipCodeCity
            // 
            this.labelZipCodeCity.AutoSize = true;
            this.labelZipCodeCity.Location = new System.Drawing.Point(29, 145);
            this.labelZipCodeCity.Margin = new System.Windows.Forms.Padding(20);
            this.labelZipCodeCity.Name = "labelZipCodeCity";
            this.labelZipCodeCity.Size = new System.Drawing.Size(105, 18);
            this.labelZipCodeCity.TabIndex = 8;
            this.labelZipCodeCity.Text = "Zip Code / City";
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(29, 203);
            this.labelContactName.Margin = new System.Windows.Forms.Padding(20);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(101, 18);
            this.labelContactName.TabIndex = 9;
            this.labelContactName.Text = "Contact name";
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Location = new System.Drawing.Point(29, 261);
            this.labelSatisfaction.Margin = new System.Windows.Forms.Padding(20);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(85, 18);
            this.labelSatisfaction.TabIndex = 10;
            this.labelSatisfaction.Text = "Satisfaction";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(322, 311);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 32);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSupplierDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 370);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSupplierDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Display";
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
    }
}