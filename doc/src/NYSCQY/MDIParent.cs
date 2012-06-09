using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace NYSCQY
{
	public class MDIParent : Form
	{
		private delegate void delegateInitData(int intValue);
		private delegate void delegateInitPic(int intValue);
		private IContainer components = null;
		private PictureBox pictureBox1;
		private PictureBox picEnter;
		private Label lblDays;
		private Label lblPrompt;
		private PictureBox pictureBox2;
		public static DataSet dsBQ = new DataSet();
		public static DataSet dsP = new DataSet();
		public static DataSet dsAED = new DataSet();
		public static DataSet dsF = new DataSet();
		public static string strKeyWord = "";
		public static string strFilterField = "";
		public static string strAndOr = "and";
		public static Form MDIForm;
		public static int screen_width;
		public static int screen_height;
		private bool bDataEnd = false;
		private bool bInitOK = false;
		private frmInit Init;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent));
			this.pictureBox1 = new PictureBox();
			this.picEnter = new PictureBox();
			this.lblDays = new Label();
			this.lblPrompt = new Label();
			this.pictureBox2 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.picEnter).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Dock = DockStyle.Fill;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(1016, 702);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.picEnter.BackColor = Color.Transparent;
			this.picEnter.Cursor = Cursors.Hand;
			this.picEnter.Location = new Point(589, 298);
			this.picEnter.Name = "picEnter";
			this.picEnter.Size = new Size(199, 100);
			this.picEnter.SizeMode = PictureBoxSizeMode.AutoSize;
			this.picEnter.TabIndex = 1;
			this.picEnter.TabStop = false;
			this.picEnter.MouseLeave += new EventHandler(this.picEnter_MouseLeave);
			this.picEnter.Click += new EventHandler(this.picEnter_Click);
			this.picEnter.MouseEnter += new EventHandler(this.picEnter_MouseEnter);
			this.lblDays.BackColor = Color.Transparent;
			this.lblDays.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.lblDays.Location = new Point(643, 242);
			this.lblDays.Name = "lblDays";
			this.lblDays.Size = new Size(195, 12);
			this.lblDays.TabIndex = 2;
			this.lblDays.Visible = false;
			this.lblPrompt.BackColor = Color.Transparent;
			this.lblPrompt.Location = new Point(425, 505);
			this.lblPrompt.Name = "lblPrompt";
			this.lblPrompt.Size = new Size(308, 20);
			this.lblPrompt.TabIndex = 3;
			this.pictureBox2.BackColor = Color.Transparent;
			this.pictureBox2.Cursor = Cursors.Hand;
			this.pictureBox2.Location = new Point(626, 240);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(16, 16);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1016, 702);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.lblPrompt);
			base.Controls.Add(this.lblDays);
			base.Controls.Add(this.picEnter);
			base.Controls.Add(this.pictureBox1);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new Size(1024, 768);
			this.MinimumSize = new Size(1024, 736);
			base.Name = "MDIParent";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "农药电子查询服务系统--单机版企业用户";
			base.Load += new EventHandler(this.MDIParent_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.picEnter).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		public MDIParent()
		{
			this.InitializeComponent();
			this.picEnter.Parent = this.pictureBox1;
			this.pictureBox2.Parent = this.pictureBox1;
			this.lblDays.Parent = this.pictureBox1;
			this.lblPrompt.Parent = this.pictureBox1;
			this.lblDays.ForeColor = Color.FromArgb(178, 51, 21);
			this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\main.png");
			this.picEnter.Image = Image.FromFile(Application.StartupPath + "\\images\\enter_leave.png");
			this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\!.png");
			if (this.checkVolName() == "0")
			{
				MDIParent.MDIForm = this;
				this.Init = new frmInit(this);
				this.Init.Show();
				Thread thread = new Thread(new ThreadStart(this.initP));
				thread.Start();
				Thread thread2 = new Thread(new ThreadStart(this.initAED));
				thread2.Start();
				Thread thread3 = new Thread(new ThreadStart(this.initF));
				thread3.Start();
				Thread thread4 = new Thread(new ThreadStart(this.initBQ));
				thread4.Start();
				Thread thread5 = new Thread(new ThreadStart(this.CheckUpdate));
				thread5.Start();
				while (!this.bInitOK)
				{
					if (this.Init.progressBar1.Value == this.Init.progressBar1.Maximum)
					{
						Thread.Sleep(120);
						thread.Abort();
						thread2.Abort();
						thread3.Abort();
						thread4.Abort();
						thread5.Abort();
						break;
					}
					Application.DoEvents();
				}
				this.Init.Dispose();
			}
			else
			{
				MessageBox.Show(this, "由于您电脑本次的升级校验码与您上次提供的不一样，无法提供查询服务！\r\n咨询电话：010-51268119！", "错误提示！", MessageBoxButtons.OK);
				File.Delete(Directory.GetCurrentDirectory() + "\\p3.xml");
				this.picEnter.Enabled = false;
			}
		}
		private void SetProgressBar1(int intValue)
		{
			if (this.Init.progressBar1.InvokeRequired)
			{
				MDIParent.delegateInitData method = new MDIParent.delegateInitData(this.SetProgressBar1);
				base.Invoke(method, new object[]
				{
					intValue
				});
			}
			else
			{
				this.Init.progressBar1.Value += intValue;
			}
		}
		private void SetPicWidth(int intValue)
		{
			if (this.Init.pictureBox3.InvokeRequired)
			{
				MDIParent.delegateInitPic method = new MDIParent.delegateInitPic(this.SetPicWidth);
				base.Invoke(method, new object[]
				{
					intValue
				});
			}
			else
			{
				this.Init.pictureBox3.Width += intValue;
			}
		}
		[DllImport("kernel32.dll")]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
		private void initP()
		{
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			string strFromFile = Directory.GetCurrentDirectory() + "\\P.dat";
			string text = Directory.GetCurrentDirectory() + "\\JGS\\P.zip";
			string text2 = Directory.GetCurrentDirectory() + "\\JGS\\P.xml";
			string text3 = text2.Substring(0, 1);
			if (!text3.EndsWith(":\\"))
			{
				text3 += ":\\";
			}
			ulong num;
			ulong num2;
			ulong num3;
			MDIParent.GetDiskFreeSpaceEx(text3, out num, out num2, out num3);
			if (num <= 100000000uL)
			{
				MessageBox.Show(this, "对不起，由于当前盘符［" + text3 + "］剩余空间不足，程序不能继续运行！\r\n您可以清理一下当前盘符，释放一些空间！\r\n或者重装到剩余空间大一点的盘符下！", "错误提示");
				Application.Exit();
			}
			DataSet dataSet = new DataSet();
			clsMe.GetFile(strFromFile, text);
			clsCompression.UnZipFile(text, text2);
			if (MDIParent.dsP.Tables.Count == 0)
			{
				MDIParent.dsP.ReadXmlSchema(text2);
				MDIParent.dsP.ReadXml(text2, XmlReadMode.IgnoreSchema);
			}
			clsMe.PlanData(MDIParent.dsP, "p", "R1|R2|F2|R4|R5|R11|R12|R13|");
			File.Delete(text);
			File.Delete(text2);
			this.SetPicWidth(169);
			this.SetProgressBar1(30);
		}
		private void initAED()
		{
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			string strFromFile = Directory.GetCurrentDirectory() + "\\ActiveElementDetail.dat";
			string text = Directory.GetCurrentDirectory() + "\\JGS\\ActiveElementDetail.zip";
			string text2 = Directory.GetCurrentDirectory() + "\\JGS\\ActiveElementDetail.xml";
			DataSet dataSet = new DataSet();
			clsMe.GetFile(strFromFile, text);
			clsCompression.UnZipFile(text, text2);
			MDIParent.dsAED.ReadXmlSchema(text2);
			MDIParent.dsAED.ReadXml(text2, XmlReadMode.IgnoreSchema);
			clsMe.PlanData(MDIParent.dsAED, "aed", "E2|E3|");
			File.Delete(text);
			File.Delete(text2);
			this.SetPicWidth(100);
			this.SetProgressBar1(5);
		}
		private void initF()
		{
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			string strFromFile = Directory.GetCurrentDirectory() + "\\Firm.dat";
			string text = Directory.GetCurrentDirectory() + "\\JGS\\Firm.zip";
			string text2 = Directory.GetCurrentDirectory() + "\\JGS\\Firm.xml";
			DataSet dataSet = new DataSet();
			clsMe.GetFile(strFromFile, text);
			clsCompression.UnZipFile(text, text2);
			MDIParent.dsF.ReadXmlSchema(text2);
			MDIParent.dsF.ReadXml(text2, XmlReadMode.IgnoreSchema);
			clsMe.PlanData(MDIParent.dsF, "f", "F2|F9|F10|F14|");
			File.Delete(text);
			File.Delete(text2);
			this.SetPicWidth(100);
			this.SetProgressBar1(10);
		}
		private void initBQ()
		{
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			string strFromFile = Directory.GetCurrentDirectory() + "\\bq.dat";
			string text = Directory.GetCurrentDirectory() + "\\JGS\\bq.zip";
			string text2 = Directory.GetCurrentDirectory() + "\\JGS\\bq.xml";
			DataSet dataSet = new DataSet();
			clsMe.GetFile(strFromFile, text);
			clsCompression.UnZipFile(text, text2);
			MDIParent.dsBQ.ReadXmlSchema(text2);
			MDIParent.dsBQ.ReadXml(text2, XmlReadMode.IgnoreSchema);
			clsMe.PlanData(MDIParent.dsBQ, "BQ", "R1|R2|");
			File.Delete(text);
			File.Delete(text2);
			this.SetPicWidth(180);
			this.SetProgressBar1(45);
		}
		private string checkVolName()
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(Application.StartupPath + "\\p3.xml", XmlReadMode.ReadSchema);
			string text = dataSet.Tables["t1"].Rows[0]["c2"].ToString();
			clsMe clsMe = new clsMe();
			text = clsMe.Decrypt(text, "ja7z%$Or29W]", Encoding.Default);
			text = text.Substring(0, text.IndexOf("%"));
			return text.CompareTo(clsMe.GetVolumeID()).ToString();
		}
		private void CheckUpdate()
		{
			try
			{
				this.SetProgressBar1(10);
			}
			catch
			{
				this.SetProgressBar1(10);
			}
		}
		private void MDIParent_Load(object sender, EventArgs e)
		{
			if (this.picEnter.Enabled)
			{
				this.lblDays.Text = "";
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(Application.StartupPath + "\\p3.xml", XmlReadMode.ReadSchema);
				string text = dataSet.Tables["t1"].Rows[0]["c3"].ToString();
				string text2 = dataSet.Tables["t1"].Rows[0]["c2"].ToString();
				clsMe clsMe = new clsMe();
				text = clsMe.Decrypt(text, "ja7z%$Or29W]", Encoding.Default);
				text2 = clsMe.Decrypt(text2, "ja7z%$Or29W]", Encoding.Default);
				text2 = text2.Substring(text2.IndexOf("%") + 1);
				this.lblPrompt.Text = text + "                    " + MDIParent.dsP.Tables["v"].Rows[0]["fxrq"].ToString();
				if (text2.CompareTo(MDIParent.dsP.Tables["v"].Rows[0]["ver"].ToString()) != 0)
				{
					MessageBox.Show(this, "数据文件和配置文件参数设置不一样，暂时无法提供查询服务！\r\n咨询电话：010-51268119！", "提示！", MessageBoxButtons.OK);
					File.Delete(Directory.GetCurrentDirectory() + "\\p3.xml");
					this.picEnter.Enabled = false;
					this.lblDays.Visible = false;
				}
				else
				{
					if (MDIParent.dsP.Tables["v"].Rows[0]["fxrq"].ToString().CompareTo(text) > 0)
					{
						MessageBox.Show(this, "您已过数据服务期限，暂时无法提供查询服务！\r\n咨询电话：010-51268119！", "提示！", MessageBoxButtons.OK);
						this.picEnter.Enabled = false;
						this.lblDays.Visible = false;
						this.lblPrompt.Visible = false;
						frmHao frmHao = new frmHao("");
						MDIParent.SetParent(frmHao.Handle, MDIParent.MDIForm.Handle);
						frmHao.Show();
					}
					else
					{
						DateTime d = Convert.ToDateTime(text);
						DateTime today = DateTime.Today;
						int days = (d - today).Days;
						if (days <= 30)
						{
							this.pictureBox2.Visible = true;
							this.lblDays.Text = "急！最后" + days.ToString() + "天了！赶紧续费！";
						}
						else
						{
							if (days <= 60)
							{
								this.pictureBox2.Visible = true;
								this.lblDays.Text = "剩下" + days.ToString() + "天的时间了！该续费了！";
							}
							else
							{
								if (days <= 90)
								{
									this.pictureBox2.Visible = true;
									this.lblDays.Text = "还可以使用" + days.ToString() + "天！抓紧续费吧！";
								}
							}
						}
					}
				}
				Rectangle rectangle = default(Rectangle);
				rectangle = Screen.GetWorkingArea(this);
				MDIParent.screen_width = rectangle.Width;
				MDIParent.screen_height = rectangle.Height;
			}
			else
			{
				this.lblPrompt.Visible = false;
				this.lblDays.Visible = false;
			}
		}
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr childWindow, IntPtr newParent);
		private void picEnter_Click(object sender, EventArgs e)
		{
			frmNY frmNY = new frmNY();
			frmNY.Show();
		}
		private void picLeft00_Click(object sender, EventArgs e)
		{
			clsCommon clsCommon = new clsCommon();
			clsCommon.RunProcess(((PictureBox)sender).Tag.ToString());
		}
		private void picEnter_MouseEnter(object sender, EventArgs e)
		{
			this.picEnter.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\enter_enter.png");
		}
		private void picEnter_MouseLeave(object sender, EventArgs e)
		{
			this.picEnter.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\enter_leave.png");
		}
	}
}
