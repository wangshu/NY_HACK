using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraLayout.Localization;
using DevExpress.XtraPrinting.Localization;
using System;
using System.IO;
using System.Windows.Forms;
namespace NYSCQY
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			GridLocalizer.Active = new DxperienceXtraGridLocalizationCHS();
			Localizer.Active = new DxperienceXtraEditorsLocalizationCHS();
			LayoutLocalizer.Active = new DxperienceXtraLayoutLocalizationCHS();
			PreviewLocalizer.Active = new DxperienceXtraPrintingLocalizationCHS();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (File.Exists(Application.StartupPath + "\\P3.xml"))
			{
				Application.Run(new MDIParent());
			}
			else
			{
				Application.Run(new frmHao("init"));
			}
		}
	}
}
