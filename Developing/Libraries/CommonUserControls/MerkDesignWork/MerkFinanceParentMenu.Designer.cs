namespace CommonUserControls.MerkDesignWork
{
	partial class MerkFinanceParentMenu
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.btnDailyTransactions = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
			this.btnCustomers = new DevExpress.XtraNavBar.NavBarItem();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.panelControl1);
			this.layoutControl1.Controls.Add(this.navBarControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(156, 258, 250, 350);
			this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1364, 766);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
			this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnDailyTransactions,
            this.btnCustomers});
			this.navBarControl1.Location = new System.Drawing.Point(1089, 0);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 275;
			this.navBarControl1.Size = new System.Drawing.Size(275, 766);
			this.navBarControl1.TabIndex = 4;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup1.Appearance.Options.UseFont = true;
			this.navBarGroup1.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup1.AppearanceBackground.Options.UseFont = true;
			this.navBarGroup1.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup1.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup1.AppearancePressed.Options.UseFont = true;
			this.navBarGroup1.Caption = "المعاملات المالية والحسابية";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDailyTransactions)});
			this.navBarGroup1.LargeImage = global::CommonUserControls.Properties.Resources.MenuIcon_16_02;
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// btnDailyTransactions
			// 
			this.btnDailyTransactions.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnDailyTransactions.Appearance.Options.UseFont = true;
			this.btnDailyTransactions.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnDailyTransactions.AppearanceDisabled.Options.UseFont = true;
			this.btnDailyTransactions.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnDailyTransactions.AppearanceHotTracked.Options.UseFont = true;
			this.btnDailyTransactions.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnDailyTransactions.AppearancePressed.Options.UseFont = true;
			this.btnDailyTransactions.Caption = "المعاملات اليومية";
			this.btnDailyTransactions.Name = "btnDailyTransactions";
			this.btnDailyTransactions.SmallImage = global::CommonUserControls.Properties.Resources.StopIcon_8;
			this.btnDailyTransactions.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDailyTransactions_LinkClicked);
			// 
			// navBarGroup2
			// 
			this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup2.Appearance.Options.UseFont = true;
			this.navBarGroup2.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup2.AppearanceBackground.Options.UseFont = true;
			this.navBarGroup2.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup2.AppearanceHotTracked.Options.UseFont = true;
			this.navBarGroup2.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.navBarGroup2.AppearancePressed.Options.UseFont = true;
			this.navBarGroup2.Caption = "....";
			this.navBarGroup2.Expanded = true;
			this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCustomers)});
			this.navBarGroup2.LargeImage = global::CommonUserControls.Properties.Resources.MenuIcon_16_02;
			this.navBarGroup2.Name = "navBarGroup2";
			// 
			// btnCustomers
			// 
			this.btnCustomers.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnCustomers.Appearance.Options.UseFont = true;
			this.btnCustomers.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnCustomers.AppearanceDisabled.Options.UseFont = true;
			this.btnCustomers.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnCustomers.AppearanceHotTracked.Options.UseFont = true;
			this.btnCustomers.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnCustomers.AppearancePressed.Options.UseFont = true;
			this.btnCustomers.Caption = "العمــــــــــلاء";
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.SmallImage = global::CommonUserControls.Properties.Resources.StopIcon_8;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleSeparator1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1364, 766);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.navBarControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(1089, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(275, 766);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// panelControl1
			// 
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1087, 766);
			this.panelControl1.TabIndex = 5;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.panelControl1;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem2.Size = new System.Drawing.Size(1087, 766);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// simpleSeparator1
			// 
			this.simpleSeparator1.AllowHotTrack = false;
			this.simpleSeparator1.Location = new System.Drawing.Point(1087, 0);
			this.simpleSeparator1.Name = "simpleSeparator1";
			this.simpleSeparator1.Size = new System.Drawing.Size(2, 766);
			// 
			// MerkFinanceParentMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.Controls.Add(this.layoutControl1);
			this.Name = "MerkFinanceParentMenu";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1364, 766);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraNavBar.NavBarItem btnDailyTransactions;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
		private DevExpress.XtraNavBar.NavBarItem btnCustomers;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
	}
}
