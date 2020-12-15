
namespace AppPapyrus
{
    partial class FormOrdersList
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
            this.comboBoxSupplierList = new System.Windows.Forms.ComboBox();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSupplierList
            // 
            this.comboBoxSupplierList.FormattingEnabled = true;
            this.comboBoxSupplierList.Location = new System.Drawing.Point(189, 28);
            this.comboBoxSupplierList.Name = "comboBoxSupplierList";
            this.comboBoxSupplierList.Size = new System.Drawing.Size(215, 26);
            this.comboBoxSupplierList.TabIndex = 0;
            this.comboBoxSupplierList.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierList_SelectedIndexChanged);
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderId,
            this.columnOrderDate,
            this.columnOrderComments,
            this.columnContactName});
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(35, 191);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(567, 153);
            this.listViewResults.TabIndex = 1;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderId
            // 
            this.columnOrderId.Text = "Id";
            this.columnOrderId.Width = 75;
            // 
            // columnOrderDate
            // 
            this.columnOrderDate.Text = "Date";
            this.columnOrderDate.Width = 71;
            // 
            // columnOrderComments
            // 
            this.columnOrderComments.Text = "Comments";
            this.columnOrderComments.Width = 218;
            // 
            // columnContactName
            // 
            this.columnContactName.Text = "Contact Name";
            this.columnContactName.Width = 160;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(305, 392);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(99, 33);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(32, 31);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(124, 18);
            this.labelSupplier.TabIndex = 3;
            this.labelSupplier.Text = "Select a supplier :";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Location = new System.Drawing.Point(32, 161);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(54, 18);
            this.labelOrders.TabIndex = 4;
            this.labelOrders.Text = "Orders";
            // 
            // FormOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 451);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.comboBoxSupplierList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrdersList";
            this.Text = "Orders list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupplierList;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnOrderId;
        private System.Windows.Forms.ColumnHeader columnOrderDate;
        private System.Windows.Forms.ColumnHeader columnOrderComments;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.ColumnHeader columnContactName;
    }
}