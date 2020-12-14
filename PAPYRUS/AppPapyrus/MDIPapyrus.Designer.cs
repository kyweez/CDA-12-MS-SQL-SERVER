
namespace AppPapyrus
{
    partial class MDIPapyrus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPapyrus));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuppliersSearchSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrdersList = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductsDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buttonConnect = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.suppliersMenu,
            this.ordersMenu,
            this.productsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileConnect,
            this.menuFileDisconnect,
            this.toolStripSeparator5,
            this.menuFileExit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // menuFileConnect
            // 
            this.menuFileConnect.Name = "menuFileConnect";
            this.menuFileConnect.Size = new System.Drawing.Size(180, 22);
            this.menuFileConnect.Text = "Connect";
            this.menuFileConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // menuFileDisconnect
            // 
            this.menuFileDisconnect.Enabled = false;
            this.menuFileDisconnect.Name = "menuFileDisconnect";
            this.menuFileDisconnect.Size = new System.Drawing.Size(180, 22);
            this.menuFileDisconnect.Text = "Disconnect";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // suppliersMenu
            // 
            this.suppliersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuppliersSearchSupplier});
            this.suppliersMenu.Enabled = false;
            this.suppliersMenu.Name = "suppliersMenu";
            this.suppliersMenu.Size = new System.Drawing.Size(67, 20);
            this.suppliersMenu.Text = "Suppliers";
            // 
            // menuSuppliersSearchSupplier
            // 
            this.menuSuppliersSearchSupplier.Name = "menuSuppliersSearchSupplier";
            this.menuSuppliersSearchSupplier.Size = new System.Drawing.Size(163, 22);
            this.menuSuppliersSearchSupplier.Text = "Search a supplier";
            // 
            // ordersMenu
            // 
            this.ordersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrdersList});
            this.ordersMenu.Enabled = false;
            this.ordersMenu.Name = "ordersMenu";
            this.ordersMenu.Size = new System.Drawing.Size(54, 20);
            this.ordersMenu.Text = "Orders";
            // 
            // menuOrdersList
            // 
            this.menuOrdersList.Name = "menuOrdersList";
            this.menuOrdersList.Size = new System.Drawing.Size(122, 22);
            this.menuOrdersList.Text = "Order list";
            // 
            // productsMenu
            // 
            this.productsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductsDisplay});
            this.productsMenu.Enabled = false;
            this.productsMenu.Name = "productsMenu";
            this.productsMenu.Size = new System.Drawing.Size(66, 20);
            this.productsMenu.Text = "Products";
            // 
            // menuProductsDisplay
            // 
            this.menuProductsDisplay.Name = "menuProductsDisplay";
            this.menuProductsDisplay.Size = new System.Drawing.Size(162, 22);
            this.menuProductsDisplay.Text = "Display products";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 692);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1180, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatus.Text = "Disconnected";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonConnect});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1180, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // buttonConnect
            // 
            this.buttonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(56, 22);
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // MDIPapyrus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 714);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPapyrus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papyrus";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuFileConnect;
        private System.Windows.Forms.ToolStripMenuItem menuFileDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem suppliersMenu;
        private System.Windows.Forms.ToolStripMenuItem menuSuppliersSearchSupplier;
        private System.Windows.Forms.ToolStripMenuItem ordersMenu;
        private System.Windows.Forms.ToolStripMenuItem menuOrdersList;
        private System.Windows.Forms.ToolStripMenuItem productsMenu;
        private System.Windows.Forms.ToolStripMenuItem menuProductsDisplay;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton buttonConnect;
    }
}



