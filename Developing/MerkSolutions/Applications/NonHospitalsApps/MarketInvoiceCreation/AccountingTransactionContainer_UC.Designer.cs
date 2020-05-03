﻿namespace MarketInvoiceCreation
{
	partial class AccountingTransactionContainer_UC
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
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.btnAccountingJournalTransactions = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnAccountingJournalTransactions);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1027, 495);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1027, 495);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// btnAccountingJournalTransactions
			// 
			this.btnAccountingJournalTransactions.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.btnAccountingJournalTransactions.Appearance.ForeColor = System.Drawing.Color.White;
			this.btnAccountingJournalTransactions.Appearance.Options.UseFont = true;
			this.btnAccountingJournalTransactions.Appearance.Options.UseForeColor = true;
			this.btnAccountingJournalTransactions.Appearance.Options.UseTextOptions = true;
			this.btnAccountingJournalTransactions.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.btnAccountingJournalTransactions.Image = global::MarketInvoiceCreation.Properties.Resources.InvoiceInIcon_01;
			this.btnAccountingJournalTransactions.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
			this.btnAccountingJournalTransactions.Location = new System.Drawing.Point(754, 3);
			this.btnAccountingJournalTransactions.MaximumSize = new System.Drawing.Size(270, 50);
			this.btnAccountingJournalTransactions.MinimumSize = new System.Drawing.Size(270, 50);
			this.btnAccountingJournalTransactions.Name = "btnAccountingJournalTransactions";
			this.btnAccountingJournalTransactions.Size = new System.Drawing.Size(270, 50);
			this.btnAccountingJournalTransactions.StyleController = this.layoutControl1;
			this.btnAccountingJournalTransactions.TabIndex = 10;
			this.btnAccountingJournalTransactions.Text = "تسجيـل قيــود اليـوميــــة";
			this.btnAccountingJournalTransactions.Click += new System.EventHandler(this.btnAccountingJournalTransactions_Click);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.btnAccountingJournalTransactions;
			this.layoutControlItem1.Location = new System.Drawing.Point(751, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(276, 495);
			this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(751, 495);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// AccountingTransactionContainer_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "AccountingTransactionContainer_UC";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1027, 495);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.SimpleButton btnAccountingJournalTransactions;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
	}
}
