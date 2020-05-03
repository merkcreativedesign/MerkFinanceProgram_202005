﻿namespace CommonUserControls.SettingsViewers.FinanceDailyTransaction
{
	partial class FinanceDailyTransaction_SearchViewer
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
			this.dtDate = new DevExpress.XtraEditors.DateEdit();
			this.spnAmount = new DevExpress.XtraEditors.SpinEdit();
			this.lkeDailyTransactionType = new DevExpress.XtraEditors.GridLookUpEdit();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.txtDescription = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spnAmount.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lkeDailyTransactionType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtDescription);
			this.layoutControl1.Controls.Add(this.lkeDailyTransactionType);
			this.layoutControl1.Controls.Add(this.spnAmount);
			this.layoutControl1.Controls.Add(this.dtDate);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1057, 121);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.emptySpaceItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1057, 121);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// dtDate
			// 
			this.dtDate.EditValue = null;
			this.dtDate.Location = new System.Drawing.Point(871, 3);
			this.dtDate.MaximumSize = new System.Drawing.Size(120, 0);
			this.dtDate.MinimumSize = new System.Drawing.Size(120, 0);
			this.dtDate.Name = "dtDate";
			this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDate.Size = new System.Drawing.Size(120, 20);
			this.dtDate.StyleController = this.layoutControl1;
			this.dtDate.TabIndex = 26;
			// 
			// spnAmount
			// 
			this.spnAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spnAmount.Location = new System.Drawing.Point(861, 29);
			this.spnAmount.MaximumSize = new System.Drawing.Size(120, 30);
			this.spnAmount.MinimumSize = new System.Drawing.Size(130, 30);
			this.spnAmount.Name = "spnAmount";
			this.spnAmount.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
			this.spnAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.spnAmount.Properties.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
			this.spnAmount.Properties.Appearance.Options.UseBackColor = true;
			this.spnAmount.Properties.Appearance.Options.UseFont = true;
			this.spnAmount.Properties.Appearance.Options.UseForeColor = true;
			this.spnAmount.Properties.Appearance.Options.UseTextOptions = true;
			this.spnAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.spnAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.spnAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spnAmount.Properties.DisplayFormat.FormatString = "d2";
			this.spnAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.spnAmount.Size = new System.Drawing.Size(130, 30);
			this.spnAmount.StyleController = this.layoutControl1;
			this.spnAmount.TabIndex = 30;
			// 
			// lkeDailyTransactionType
			// 
			this.lkeDailyTransactionType.Location = new System.Drawing.Point(691, 65);
			this.lkeDailyTransactionType.MaximumSize = new System.Drawing.Size(300, 0);
			this.lkeDailyTransactionType.MinimumSize = new System.Drawing.Size(300, 0);
			this.lkeDailyTransactionType.Name = "lkeDailyTransactionType";
			this.lkeDailyTransactionType.Properties.Appearance.BackColor = System.Drawing.Color.NavajoWhite;
			this.lkeDailyTransactionType.Properties.Appearance.Options.UseBackColor = true;
			this.lkeDailyTransactionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lkeDailyTransactionType.Properties.View = this.gridView2;
			this.lkeDailyTransactionType.Size = new System.Drawing.Size(300, 20);
			this.lkeDailyTransactionType.StyleController = this.layoutControl1;
			this.lkeDailyTransactionType.TabIndex = 31;
			// 
			// gridView2
			// 
			this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(3, 91);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
			this.txtDescription.Size = new System.Drawing.Size(988, 20);
			this.txtDescription.StyleController = this.layoutControl1;
			this.txtDescription.TabIndex = 32;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.dtDate;
			this.layoutControlItem1.CustomizationFormText = "التاريخ";
			this.layoutControlItem1.Location = new System.Drawing.Point(868, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(189, 26);
			this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
			this.layoutControlItem1.Text = "التاريخ";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(868, 26);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(858, 36);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 62);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(688, 26);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtDescription;
			this.layoutControlItem4.CustomizationFormText = "الملاحظــــات";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 88);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem4.Size = new System.Drawing.Size(1057, 33);
			this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
			this.layoutControlItem4.Text = "الملاحظــــات";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.lkeDailyTransactionType;
			this.layoutControlItem3.CustomizationFormText = "نوع العملية";
			this.layoutControlItem3.Location = new System.Drawing.Point(688, 62);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem3.Size = new System.Drawing.Size(369, 26);
			this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
			this.layoutControlItem3.Text = "نوع العملية";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.spnAmount;
			this.layoutControlItem2.CustomizationFormText = "القيمة";
			this.layoutControlItem2.Location = new System.Drawing.Point(858, 26);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem2.Size = new System.Drawing.Size(199, 36);
			this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
			this.layoutControlItem2.Text = "القيمة";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
			// 
			// FinanceDailyTransaction_SearchViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "FinanceDailyTransaction_SearchViewer";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1057, 121);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spnAmount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lkeDailyTransactionType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.DateEdit dtDate;
		private DevExpress.XtraEditors.SpinEdit spnAmount;
		private DevExpress.XtraEditors.GridLookUpEdit lkeDailyTransactionType;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraEditors.TextEdit txtDescription;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	}
}
