using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace NYSCQY
{
	public class UserManu : UserControl
	{
		private IContainer components = null;
		public NavBarControl navBarControl1;
		public NavBarGroup navBarGroup1;
		public NavBarGroup navBarGroup2;
		public NavBarItem navBarItem1;
		public NavBarItem navBarItem2;
		public NavBarItem navBarItem3;
		public NavBarItem navBarItem4;
		public NavBarItem navBarItem5;
		public NavBarItem navBarItem6;
		public NavBarItem navBarItem7;
		public NavBarItem navBarItem8;
		public NavBarItem navBarItem9;
		public NavBarItem navBarItem10;
		public NavBarItem navBarItem11;
		public NavBarItem navBarItem12;
		public NavBarItem navBarItem13;
		public NavBarItem navBarItem14;
		public NavBarItem navBarItem15;
		public NavBarItem navBarItem16;
		public NavBarItem navBarItem17;
		public NavBarItem navBarItem18;
		public NavBarItem navBarItem19;
		public NavBarItem navBarItem20;
		public NavBarItem navBarItem21;
		public NavBarItem navBarItem22;
		public NavBarItem navBarItem23;
		public NavBarItem navBarItem24;
		public NavBarItem navBarItem25;
		public NavBarItem navBarItem26;
		public NavBarItem navBarItem27;
		public UserManu()
		{
			this.InitializeComponent();
			this.navBarGroup1.Caption = "企业用户查询";
			this.navBarGroup1.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarGroup2.Caption = "服务";
			this.navBarGroup2.Appearance.Font = new Font("宋体", 10.5f);
			for (int i = 0; i < this.navBarControl1.Items.Count; i++)
			{
				this.navBarControl1.Items[i].Appearance.Font = new Font("宋体", 10.5f);
				this.navBarControl1.Items[i].AppearanceHotTracked.Font = new Font("宋体", 10.5f);
				this.navBarControl1.Items[i].AppearancePressed.Font = new Font("宋体", 10.5f);
				this.navBarControl1.Items[i].LinkClicked += new NavBarLinkEventHandler(this.navBarItemLinkClicked);
			}
		}
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr childWindow, IntPtr newParent);
		[DllImport("user32.dll", SetLastError = true)]
		public static extern long LockWindowUpdate(long hwndLock);
		private void OpenFrm(Form frm)
		{
			this.Cursor = Cursors.WaitCursor;
			UserManu.LockWindowUpdate((long)frm.Handle.ToInt32());
			frm.Show();
			UserManu.LockWindowUpdate(0L);
			this.Cursor = Cursors.Default;
		}
		private void navBarItemLinkClicked(object sender, NavBarLinkEventArgs e)
		{
			string a = e.Link.Caption.ToString().Trim();
			this.Cursor = Cursors.WaitCursor;
			if (a == "农药登记查询")
			{
				frmNY frm = new frmNY();
				this.OpenFrm(frm);
			}
			if (a == "生产企业=>农药")
			{
				frmQY2NY frm2 = new frmQY2NY();
				this.OpenFrm(frm2);
			}
			if (a == "作物对象=>农药")
			{
				frmZWFZDX2NY frm3 = new frmZWFZDX2NY();
				this.OpenFrm(frm3);
			}
			if (a == "农药单混剂查询")
			{
				frmNYDHJ frm4 = new frmNYDHJ();
				this.OpenFrm(frm4);
			}
			if (a == "临时转正式")
			{
				frmLS2ZS frm5 = new frmLS2ZS();
				this.OpenFrm(frm5);
			}
			if (a == "农药新命名规则")
			{
				frmNewDJMC frm6 = new frmNewDJMC();
				this.OpenFrm(frm6);
			}
			if (a == "农药有效性查询")
			{
				frmNYUsed frm7 = new frmNYUsed();
				this.OpenFrm(frm7);
			}
			if (a == "过期产品查询")
			{
				frmNYUnused frm8 = new frmNYUnused();
				this.OpenFrm(frm8);
			}
			if (a == "农药标签信息查询")
			{
				frmBQ frm9 = new frmBQ();
				this.OpenFrm(frm9);
			}
			if (a == "禁限用查询")
			{
				frmJXY frm10 = new frmJXY();
				this.OpenFrm(frm10);
			}
			if (a == "农药受理查询")
			{
				frmSLCP frm11 = new frmSLCP();
				this.OpenFrm(frm11);
			}
			if (a == "生产企业查询")
			{
				frmQY frm12 = new frmQY();
				this.OpenFrm(frm12);
			}
			if (a == "农药单位查询")
			{
				frmDW frm13 = new frmDW();
				this.OpenFrm(frm13);
			}
			if (a == "农药=>生产企业")
			{
				frmNY2QY frm14 = new frmNY2QY();
				this.OpenFrm(frm14);
			}
			if (a == "试验单位查询")
			{
				frmSYDW frm15 = new frmSYDW();
				this.OpenFrm(frm15);
			}
			if (a == "有效成分查询")
			{
				frmYXCF frm16 = new frmYXCF();
				this.OpenFrm(frm16);
			}
			if (a == "成分=>作物对象")
			{
				frmYXCF2ZWFZDX frm17 = new frmYXCF2ZWFZDX();
				this.OpenFrm(frm17);
			}
			if (a == "作物=>防治对象")
			{
				frmZW2FZDX frm18 = new frmZW2FZDX();
				this.OpenFrm(frm18);
			}
			if (a == "防治对象=>作物")
			{
				frmFZDX2ZW frm19 = new frmFZDX2ZW();
				this.OpenFrm(frm19);
			}
			if (a == "合理使用准则")
			{
				frmHLSYZZ frm20 = new frmHLSYZZ();
				this.OpenFrm(frm20);
			}
			if (a == "中毒与急救")
			{
				frmZD2JJ frm21 = new frmZD2JJ();
				this.OpenFrm(frm21);
			}
			if (a == "农药类别=>成分")
			{
				frmNYLB2YXCF frm22 = new frmNYLB2YXCF();
				this.OpenFrm(frm22);
			}
			if (a == "有效成分=>剂型")
			{
				frmYXCF2JX frm23 = new frmYXCF2JX();
				this.OpenFrm(frm23);
			}
			if (a == "环境毒性查询")
			{
				frmHJDX frm24 = new frmHJDX();
				this.OpenFrm(frm24);
			}
			if (a == "田间试验查询")
			{
				frmTJSY frm25 = new frmTJSY();
				this.OpenFrm(frm25);
			}
			if (a == "数据升级")
			{
				frmHao frmHao = new frmHao("");
				frmHao.ShowDialog();
			}
			if (a == "汇款信息")
			{
				clsCommon clsCommon = new clsCommon();
				clsCommon.RunProcess(Directory.GetCurrentDirectory() + "\\account.doc");
			}
			this.Cursor = Cursors.Default;
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.navBarControl1 = new NavBarControl();
			this.navBarGroup1 = new NavBarGroup();
			this.navBarItem1 = new NavBarItem();
			this.navBarItem2 = new NavBarItem();
			this.navBarItem3 = new NavBarItem();
			this.navBarItem6 = new NavBarItem();
			this.navBarItem7 = new NavBarItem();
			this.navBarItem8 = new NavBarItem();
			this.navBarItem9 = new NavBarItem();
			this.navBarItem10 = new NavBarItem();
			this.navBarItem11 = new NavBarItem();
			this.navBarItem12 = new NavBarItem();
			this.navBarItem13 = new NavBarItem();
			this.navBarItem14 = new NavBarItem();
			this.navBarItem15 = new NavBarItem();
			this.navBarItem16 = new NavBarItem();
			this.navBarItem17 = new NavBarItem();
			this.navBarItem18 = new NavBarItem();
			this.navBarItem19 = new NavBarItem();
			this.navBarItem20 = new NavBarItem();
			this.navBarItem21 = new NavBarItem();
			this.navBarItem22 = new NavBarItem();
			this.navBarItem23 = new NavBarItem();
			this.navBarItem24 = new NavBarItem();
			this.navBarItem25 = new NavBarItem();
			this.navBarItem26 = new NavBarItem();
			this.navBarItem27 = new NavBarItem();
			this.navBarGroup2 = new NavBarGroup();
			this.navBarItem4 = new NavBarItem();
			this.navBarItem5 = new NavBarItem();
			((ISupportInitialize)this.navBarControl1).BeginInit();
			base.SuspendLayout();
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.Appearance.Background.BackColor = Color.Red;
			this.navBarControl1.Appearance.Background.Font = new Font("宋体", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
			this.navBarControl1.Appearance.Background.Options.UseFont = true;
			this.navBarControl1.BackColor = Color.Black;
			this.navBarControl1.DragDropFlags = NavBarDragDrop.None;
			this.navBarControl1.Font = new Font("宋体", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.navBarControl1.Groups.AddRange(new NavBarGroup[]
			{
				this.navBarGroup1,
				this.navBarGroup2
			});
			this.navBarControl1.Items.AddRange(new NavBarItem[]
			{
				this.navBarItem1,
				this.navBarItem2,
				this.navBarItem3,
				this.navBarItem4,
				this.navBarItem5,
				this.navBarItem6,
				this.navBarItem7,
				this.navBarItem8,
				this.navBarItem9,
				this.navBarItem10,
				this.navBarItem11,
				this.navBarItem12,
				this.navBarItem13,
				this.navBarItem14,
				this.navBarItem15,
				this.navBarItem16,
				this.navBarItem17,
				this.navBarItem18,
				this.navBarItem19,
				this.navBarItem20,
				this.navBarItem21,
				this.navBarItem22,
				this.navBarItem23,
				this.navBarItem24,
				this.navBarItem25,
				this.navBarItem26,
				this.navBarItem27
			});
			this.navBarControl1.Location = new Point(1, 1);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 162;
			this.navBarControl1.Size = new Size(157, 591);
			this.navBarControl1.TabIndex = 5;
			this.navBarControl1.Text = "navBarControl1";
			this.navBarControl1.View = new StandardSkinExplorerBarViewInfoRegistrator("Lilian");
			this.navBarGroup1.Caption = "企业用户查询";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.ItemLinks.AddRange(new NavBarItemLink[]
			{
				new NavBarItemLink(this.navBarItem1),
				new NavBarItemLink(this.navBarItem2),
				new NavBarItemLink(this.navBarItem3),
				new NavBarItemLink(this.navBarItem6),
				new NavBarItemLink(this.navBarItem7),
				new NavBarItemLink(this.navBarItem8),
				new NavBarItemLink(this.navBarItem9),
				new NavBarItemLink(this.navBarItem10),
				new NavBarItemLink(this.navBarItem11),
				new NavBarItemLink(this.navBarItem12),
				new NavBarItemLink(this.navBarItem13),
				new NavBarItemLink(this.navBarItem14),
				new NavBarItemLink(this.navBarItem15),
				new NavBarItemLink(this.navBarItem16),
				new NavBarItemLink(this.navBarItem17),
				new NavBarItemLink(this.navBarItem18),
				new NavBarItemLink(this.navBarItem19),
				new NavBarItemLink(this.navBarItem20),
				new NavBarItemLink(this.navBarItem21),
				new NavBarItemLink(this.navBarItem22),
				new NavBarItemLink(this.navBarItem23),
				new NavBarItemLink(this.navBarItem24),
				new NavBarItemLink(this.navBarItem25),
				new NavBarItemLink(this.navBarItem26),
				new NavBarItemLink(this.navBarItem27)
			});
			this.navBarGroup1.Name = "navBarGroup1";
			this.navBarItem1.Appearance.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.navBarItem1.Appearance.Options.UseFont = true;
			this.navBarItem1.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem1.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem1.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem1.AppearancePressed.Options.UseFont = true;
			this.navBarItem1.CanDrag = false;
			this.navBarItem1.Caption = "农药登记查询";
			this.navBarItem1.Name = "navBarItem1";
			this.navBarItem2.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem2.Appearance.Options.UseFont = true;
			this.navBarItem2.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem2.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem2.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem2.AppearancePressed.Options.UseFont = true;
			this.navBarItem2.CanDrag = false;
			this.navBarItem2.Caption = "生产企业=>农药";
			this.navBarItem2.Name = "navBarItem2";
			this.navBarItem3.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem3.Appearance.Options.UseFont = true;
			this.navBarItem3.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem3.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem3.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem3.AppearancePressed.Options.UseFont = true;
			this.navBarItem3.CanDrag = false;
			this.navBarItem3.Caption = "作物对象=>农药";
			this.navBarItem3.Name = "navBarItem3";
			this.navBarItem6.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem6.Appearance.Options.UseFont = true;
			this.navBarItem6.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem6.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem6.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem6.AppearancePressed.Options.UseFont = true;
			this.navBarItem6.Caption = "农药单混剂查询";
			this.navBarItem6.Name = "navBarItem6";
			this.navBarItem7.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem7.Appearance.Options.UseFont = true;
			this.navBarItem7.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem7.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem7.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem7.AppearancePressed.Options.UseFont = true;
			this.navBarItem7.Caption = "临时转正式";
			this.navBarItem7.Name = "navBarItem7";
			this.navBarItem8.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem8.Appearance.Options.UseFont = true;
			this.navBarItem8.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem8.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem8.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem8.AppearancePressed.Options.UseFont = true;
			this.navBarItem8.Caption = "农药新命名规则";
			this.navBarItem8.Name = "navBarItem8";
			this.navBarItem9.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem9.Appearance.Options.UseFont = true;
			this.navBarItem9.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem9.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem9.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem9.AppearancePressed.Options.UseFont = true;
			this.navBarItem9.Caption = "农药有效性查询";
			this.navBarItem9.Name = "navBarItem9";
			this.navBarItem10.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem10.Appearance.Options.UseFont = true;
			this.navBarItem10.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem10.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem10.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem10.AppearancePressed.Options.UseFont = true;
			this.navBarItem10.Caption = "过期产品查询";
			this.navBarItem10.Name = "navBarItem10";
			this.navBarItem11.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem11.Appearance.Options.UseFont = true;
			this.navBarItem11.AppearanceHotTracked.Font = new Font("宋体", 10.5f);
			this.navBarItem11.AppearanceHotTracked.Options.UseFont = true;
			this.navBarItem11.AppearancePressed.Font = new Font("宋体", 10.5f);
			this.navBarItem11.AppearancePressed.Options.UseFont = true;
			this.navBarItem11.Caption = "农药标签信息查询";
			this.navBarItem11.Name = "navBarItem11";
			this.navBarItem12.Caption = "禁限用查询";
			this.navBarItem12.Name = "navBarItem12";
			this.navBarItem13.Caption = "农药受理查询";
			this.navBarItem13.Name = "navBarItem13";
			this.navBarItem14.Caption = "生产企业查询";
			this.navBarItem14.Name = "navBarItem14";
			this.navBarItem15.Caption = "农药单位查询";
			this.navBarItem15.Name = "navBarItem15";
			this.navBarItem16.Caption = "农药=>生产企业";
			this.navBarItem16.Name = "navBarItem16";
			this.navBarItem17.Caption = "试验单位查询";
			this.navBarItem17.Name = "navBarItem17";
			this.navBarItem18.Caption = "有效成分查询";
			this.navBarItem18.Name = "navBarItem18";
			this.navBarItem19.Caption = "成分=>作物对象";
			this.navBarItem19.Name = "navBarItem19";
			this.navBarItem20.Caption = "作物=>防治对象";
			this.navBarItem20.Name = "navBarItem20";
			this.navBarItem21.Caption = "防治对象=>作物";
			this.navBarItem21.Name = "navBarItem21";
			this.navBarItem22.Caption = "合理使用准则";
			this.navBarItem22.Name = "navBarItem22";
			this.navBarItem23.Caption = "中毒与急救";
			this.navBarItem23.Name = "navBarItem23";
			this.navBarItem24.Caption = "农药类别=>成分";
			this.navBarItem24.Name = "navBarItem24";
			this.navBarItem25.Caption = "有效成分=>剂型";
			this.navBarItem25.Name = "navBarItem25";
			this.navBarItem26.Caption = "环境毒性查询";
			this.navBarItem26.Name = "navBarItem26";
			this.navBarItem27.Caption = "田间试验查询";
			this.navBarItem27.Name = "navBarItem27";
			this.navBarGroup2.Caption = "服务";
			this.navBarGroup2.Expanded = true;
			this.navBarGroup2.ItemLinks.AddRange(new NavBarItemLink[]
			{
				new NavBarItemLink(this.navBarItem4),
				new NavBarItemLink(this.navBarItem5)
			});
			this.navBarGroup2.Name = "navBarGroup2";
			this.navBarItem4.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem4.Appearance.Options.UseFont = true;
			this.navBarItem4.Caption = "数据升级";
			this.navBarItem4.Name = "navBarItem4";
			this.navBarItem5.Appearance.Font = new Font("宋体", 10.5f);
			this.navBarItem5.Appearance.Options.UseFont = true;
			this.navBarItem5.Caption = "汇款信息";
			this.navBarItem5.Name = "navBarItem5";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.navBarControl1);
			base.Name = "UserManu";
			base.Size = new Size(158, 592);
			((ISupportInitialize)this.navBarControl1).EndInit();
			base.ResumeLayout(false);
		}
	}
}
