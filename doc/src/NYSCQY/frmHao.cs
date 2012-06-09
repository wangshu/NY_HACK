using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmHao : Form
	{
		private IContainer components = null;
		private TextBox txtHao;
		private Label label8;
		private Button btnClose;
		private Label label1;
		private LinkLabel linkLabel1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private string strflag = "";
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
			this.txtHao = new TextBox();
			this.label8 = new Label();
			this.btnClose = new Button();
			this.label1 = new Label();
			this.linkLabel1 = new LinkLabel();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			base.SuspendLayout();
			this.txtHao.Font = new Font("仿宋_GB2312", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtHao.Location = new Point(4, 78);
			this.txtHao.Name = "txtHao";
			this.txtHao.Size = new Size(382, 31);
			this.txtHao.TabIndex = 0;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label8.Location = new Point(5, 57);
			this.label8.Name = "label8";
			this.label8.Size = new Size(168, 14);
			this.label8.TabIndex = 16;
			this.label8.Text = "1、复制以下升级校验码：";
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(124, 211);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(104, 29);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(5, 122);
			this.label1.Name = "label1";
			this.label1.Size = new Size(126, 14);
			this.label1.TabIndex = 17;
			this.label1.Text = "2、打开升级网址：";
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.linkLabel1.Location = new Point(121, 122);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(266, 14);
			this.linkLabel1.TabIndex = 18;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Tag = "http://202.127.42.229/down/default.aspx";
			this.linkLabel1.Text = "http://www.icama.cn/down/default.aspx";
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label2.AutoSize = true;
			this.label2.Font = new Font("宋体", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new Size(232, 15);
			this.label2.TabIndex = 19;
			this.label2.Text = "提示：“农药电子查询服务系统”";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("宋体", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label3.ForeColor = Color.Red;
			this.label3.Location = new Point(5, 31);
			this.label3.Name = "label3";
			this.label3.Size = new Size(390, 15);
			this.label3.TabIndex = 20;
			this.label3.Text = "按以下步骤操作！单机版和网络版必须在同一台电脑使用!";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label4.Location = new Point(5, 150);
			this.label4.Name = "label4";
			this.label4.Size = new Size(350, 14);
			this.label4.TabIndex = 21;
			this.label4.Text = "3、输入网络版用户名及密码，粘贴升级校验码，提交。";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label5.Location = new Point(5, 179);
			this.label5.Name = "label5";
			this.label5.Size = new Size(322, 14);
			this.label5.TabIndex = 22;
			this.label5.Text = "4、下载数据升级包，双击安装，升级数据，完毕！";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("宋体", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label6.ForeColor = Color.Red;
			this.label6.Location = new Point(239, 9);
			this.label6.Name = "label6";
			this.label6.Size = new Size(155, 15);
			this.label6.TabIndex = 23;
			this.label6.Text = "网络版 [正式用户] ";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label7.ForeColor = Color.Black;
			this.label7.Location = new Point(254, 230);
			this.label7.Name = "label7";
			this.label7.Size = new Size(137, 12);
			this.label7.TabIndex = 24;
			this.label7.Text = "咨询电话：010-51268119";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(400, 251);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.txtHao);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.MaximizeBox = false;
			this.MaximumSize = new Size(408, 285);
			this.MinimumSize = new Size(408, 285);
			base.Name = "frmHao";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数据升级";
			base.Load += new EventHandler(this.frmHao_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		public frmHao(string flag)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.strflag = flag;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void frmHao_Load(object sender, EventArgs e)
		{
			clsMe clsMe = new clsMe();
			Random random = new Random(DateTime.Now.Millisecond);
			int num = random.Next(10);
			string text = "";
			if (num == 0)
			{
				text = "A";
			}
			if (num == 1)
			{
				text = "B";
			}
			if (num == 2)
			{
				text = "c";
			}
			if (num == 3)
			{
				text = "D";
			}
			if (num == 4)
			{
				text = "f";
			}
			if (num == 5)
			{
				text = "z";
			}
			if (num == 6)
			{
				text = "R";
			}
			if (num == 7)
			{
				text = "v";
			}
			if (num == 8)
			{
				text = "Q";
			}
			if (num == 9)
			{
				text = "L";
			}
			string volumeID = clsMe.GetVolumeID();
			string text2 = "";
			text2 = text2 + text + "QW";
			if (this.strflag == "init")
			{
				text2 += "0";
				this.Text = "数据升级-初次安装";
			}
			else
			{
				text2 += MDIParent.dsP.Tables["V"].Rows[0]["ver"].ToString();
			}
			this.txtHao.Text = clsMe.Encrypt(string.Concat(new string[]
			{
				num.ToString(),
				volumeID.Substring(0, 4),
				text,
				volumeID.Substring(4),
				text2
			}), "P&*GF12)");
		}
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(this.linkLabel1.Tag.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
