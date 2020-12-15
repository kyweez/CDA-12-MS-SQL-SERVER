
namespace AppPapyrus
{
    partial class FormSupplierSearch
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
            this.labelSupplierId = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderFailCode = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFailCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSupplierId
            // 
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Location = new System.Drawing.Point(42, 24);
            this.labelSupplierId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(84, 18);
            this.labelSupplierId.TabIndex = 0;
            this.labelSupplierId.Text = "Supplier Id :";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(134, 21);
            this.textBoxSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(172, 24);
            this.textBoxSupplierId.TabIndex = 1;
            this.textBoxSupplierId.TextChanged += new System.EventHandler(this.textBoxSupplierId_TextChanged);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(45, 68);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(112, 32);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "OK";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(194, 68);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 32);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProviderFailCode
            // 
            this.errorProviderFailCode.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFailCode.ContainerControl = this;
            // 
            // FormSupplierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 118);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxSupplierId);
            this.Controls.Add(this.labelSupplierId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSupplierSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier search";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFailCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProviderFailCode;
    }
}