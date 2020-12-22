
namespace WindowsFormsAppHolding
{
    partial class FormSupplier
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.tbSatisfaction = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.labelSatisfaction = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(118, 20);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(183, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(183, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(118, 72);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(183, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(118, 98);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(183, 20);
            this.tbZipCode.TabIndex = 3;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(118, 124);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(183, 20);
            this.tbCity.TabIndex = 4;
            // 
            // tbContactName
            // 
            this.tbContactName.Location = new System.Drawing.Point(118, 150);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(183, 20);
            this.tbContactName.TabIndex = 5;
            // 
            // tbSatisfaction
            // 
            this.tbSatisfaction.Location = new System.Drawing.Point(118, 176);
            this.tbSatisfaction.Name = "tbSatisfaction";
            this.tbSatisfaction.Size = new System.Drawing.Size(183, 20);
            this.tbSatisfaction.TabIndex = 6;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(201, 227);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(100, 23);
            this.buttonValidate.TabIndex = 8;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(20, 23);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(20, 75);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(20, 101);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(49, 13);
            this.labelZipCode.TabIndex = 12;
            this.labelZipCode.Text = "Zip code";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(20, 127);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 13;
            this.labelCity.Text = "City";
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(20, 153);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(73, 13);
            this.labelContactName.TabIndex = 14;
            this.labelContactName.Text = "Contact name";
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Location = new System.Drawing.Point(20, 179);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(62, 13);
            this.labelSatisfaction.TabIndex = 15;
            this.labelSatisfaction.Text = "Satisfaction";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(23, 227);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 265);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSatisfaction);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.tbSatisfaction);
            this.Controls.Add(this.tbContactName);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.TextBox tbSatisfaction;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Label labelSatisfaction;
        private System.Windows.Forms.Button buttonDelete;
    }
}

