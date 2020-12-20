
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
            this.groupBoxSearchSupplier = new System.Windows.Forms.GroupBox();
            this.groupBoxCreateSupplier = new System.Windows.Forms.GroupBox();
            this.buttonCreateSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFailCode)).BeginInit();
            this.groupBoxSearchSupplier.SuspendLayout();
            this.groupBoxCreateSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSupplierId
            // 
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Location = new System.Drawing.Point(24, 47);
            this.labelSupplierId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(84, 18);
            this.labelSupplierId.TabIndex = 0;
            this.labelSupplierId.Text = "Supplier Id :";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(116, 44);
            this.textBoxSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(172, 24);
            this.textBoxSupplierId.TabIndex = 1;
            this.textBoxSupplierId.TextChanged += new System.EventHandler(this.textBoxSupplierId_TextChanged);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(27, 93);
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
            this.buttonCancel.Location = new System.Drawing.Point(176, 93);
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
            // groupBoxSearchSupplier
            // 
            this.groupBoxSearchSupplier.Controls.Add(this.labelSupplierId);
            this.groupBoxSearchSupplier.Controls.Add(this.buttonCancel);
            this.groupBoxSearchSupplier.Controls.Add(this.textBoxSupplierId);
            this.groupBoxSearchSupplier.Controls.Add(this.buttonValidate);
            this.groupBoxSearchSupplier.Location = new System.Drawing.Point(25, 23);
            this.groupBoxSearchSupplier.Name = "groupBoxSearchSupplier";
            this.groupBoxSearchSupplier.Size = new System.Drawing.Size(318, 151);
            this.groupBoxSearchSupplier.TabIndex = 4;
            this.groupBoxSearchSupplier.TabStop = false;
            this.groupBoxSearchSupplier.Text = "Search supplier";
            // 
            // groupBoxCreateSupplier
            // 
            this.groupBoxCreateSupplier.Controls.Add(this.buttonCreateSupplier);
            this.groupBoxCreateSupplier.Location = new System.Drawing.Point(25, 200);
            this.groupBoxCreateSupplier.Name = "groupBoxCreateSupplier";
            this.groupBoxCreateSupplier.Size = new System.Drawing.Size(318, 102);
            this.groupBoxCreateSupplier.TabIndex = 5;
            this.groupBoxCreateSupplier.TabStop = false;
            this.groupBoxCreateSupplier.Text = "Create supplier";
            // 
            // buttonCreateSupplier
            // 
            this.buttonCreateSupplier.Location = new System.Drawing.Point(80, 42);
            this.buttonCreateSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateSupplier.Name = "buttonCreateSupplier";
            this.buttonCreateSupplier.Size = new System.Drawing.Size(146, 32);
            this.buttonCreateSupplier.TabIndex = 2;
            this.buttonCreateSupplier.Text = "Create supplier";
            this.buttonCreateSupplier.UseVisualStyleBackColor = true;
            this.buttonCreateSupplier.Click += new System.EventHandler(this.buttonCreateSupplier_Click);
            // 
            // FormSupplierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 328);
            this.Controls.Add(this.groupBoxCreateSupplier);
            this.Controls.Add(this.groupBoxSearchSupplier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSupplierSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier search";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFailCode)).EndInit();
            this.groupBoxSearchSupplier.ResumeLayout(false);
            this.groupBoxSearchSupplier.PerformLayout();
            this.groupBoxCreateSupplier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProviderFailCode;
        private System.Windows.Forms.GroupBox groupBoxCreateSupplier;
        private System.Windows.Forms.Button buttonCreateSupplier;
        private System.Windows.Forms.GroupBox groupBoxSearchSupplier;
    }
}