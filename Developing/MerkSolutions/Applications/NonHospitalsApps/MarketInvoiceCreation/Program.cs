using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ApplicationConfiguration;
using CommonUserControls.CommonViewers;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MarketInvoiceCreation
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BonusSkins.Register();
			SkinManager.EnableFormSkins();

			UserLookAndFeel.Default.SetSkinStyle("Office 2010 Black");
			UserLookAndFeel.Default.SkinMaskColor = Color.FromArgb(50, 59, 74);

			DialogResult result = DialogResult.None;
			ApplicationStaticConfiguration.Application = DB_Application.MerkFinance;
			if (ApplicationStaticConfiguration.LoadApplicationConfiguration())
			{
				DBBusinessLogicLibrary.LoadDBItemsList();
				result = Login_UC.ShowLoginScreen();
			}

			switch (result)
			{
				case DialogResult.OK:
					UserLookAndFeel.Default.SetSkinStyle(ApplicationStaticConfiguration.SkinName);
					if (ApplicationStaticConfiguration.SkinColor != null)
						UserLookAndFeel.Default.SkinMaskColor = Color.FromArgb(
							((Color)ApplicationStaticConfiguration.SkinColor).R,
							((Color)ApplicationStaticConfiguration.SkinColor).G,
							((Color)ApplicationStaticConfiguration.SkinColor).B);

					ApplicationStaticConfiguration.SaveLoggingHistory();
					Application.Run(new MainForm());
					break;
				case DialogResult.Cancel:
					Process.GetCurrentProcess().Kill();
					break;
			}
		}
	}
}
