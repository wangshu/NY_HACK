using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY.YXCF
{
	public class frmDX : Form
	{
		private IContainer components = null;
		private Panel panel1;
		private Button btnClose;
		private Label label6;
		private Label label5;
		private Label label4;
		private TextBox txtZYSX;
		private TextBox txtJJZL;
		private TextBox txtZDZZ;
		private Label label1;
		private TextBox txtMRYXSRL;
		private Label label8;
		private TextBox txtGWDX;
		private Label label7;
		private TextBox txtZGDX;
		private Label label3;
		private TextBox txtJXJPLD50;
		private Label label2;
		private TextBox txtJXJKLD50;
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
			this.panel1 = new Panel();
			this.label8 = new Label();
			this.txtGWDX = new TextBox();
			this.label7 = new Label();
			this.txtZGDX = new TextBox();
			this.label3 = new Label();
			this.txtJXJPLD50 = new TextBox();
			this.label2 = new Label();
			this.txtJXJKLD50 = new TextBox();
			this.label1 = new Label();
			this.txtMRYXSRL = new TextBox();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.txtZYSX = new TextBox();
			this.txtJJZL = new TextBox();
			this.txtZDZZ = new TextBox();
			this.btnClose = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtGWDX);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtZGDX);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtJXJPLD50);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtJXJKLD50);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtMRYXSRL);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtZYSX);
			this.panel1.Controls.Add(this.txtJJZL);
			this.panel1.Controls.Add(this.txtZDZZ);
			this.panel1.Location = new Point(6, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(460, 272);
			this.panel1.TabIndex = 0;
			this.label8.AutoSize = true;
			this.label8.Location = new Point(263, 251);
			this.label8.Name = "label8";
			this.label8.Size = new Size(63, 14);
			this.label8.TabIndex = 26;
			this.label8.Text = "国外毒性";
			this.txtGWDX.Location = new Point(326, 246);
			this.txtGWDX.Name = "txtGWDX";
			this.txtGWDX.Size = new Size(125, 23);
			this.txtGWDX.TabIndex = 25;
			this.label7.AutoSize = true;
			this.label7.Location = new Point(45, 251);
			this.label7.Name = "label7";
			this.label7.Size = new Size(63, 14);
			this.label7.TabIndex = 24;
			this.label7.Text = "中国毒性";
			this.txtZGDX.Location = new Point(108, 246);
			this.txtZGDX.Name = "txtZGDX";
			this.txtZGDX.Size = new Size(125, 23);
			this.txtZGDX.TabIndex = 23;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(235, 223);
			this.label3.Name = "label3";
			this.label3.Size = new Size(91, 14);
			this.label3.TabIndex = 22;
			this.label3.Text = "急性经皮LD50";
			this.txtJXJPLD50.Location = new Point(326, 218);
			this.txtJXJPLD50.Name = "txtJXJPLD50";
			this.txtJXJPLD50.Size = new Size(125, 23);
			this.txtJXJPLD50.TabIndex = 21;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(17, 223);
			this.label2.Name = "label2";
			this.label2.Size = new Size(91, 14);
			this.label2.TabIndex = 20;
			this.label2.Text = "急性经口LD50";
			this.txtJXJKLD50.Location = new Point(108, 218);
			this.txtJXJKLD50.Name = "txtJXJKLD50";
			this.txtJXJKLD50.Size = new Size(125, 23);
			this.txtJXJKLD50.TabIndex = 19;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(3, 194);
			this.label1.Name = "label1";
			this.label1.Size = new Size(105, 14);
			this.label1.TabIndex = 18;
			this.label1.Text = "每日允许摄入量";
			this.txtMRYXSRL.Location = new Point(108, 190);
			this.txtMRYXSRL.Name = "txtMRYXSRL";
			this.txtMRYXSRL.Size = new Size(343, 23);
			this.txtMRYXSRL.TabIndex = 17;
			this.label6.AutoSize = true;
			this.label6.Location = new Point(45, 151);
			this.label6.Name = "label6";
			this.label6.Size = new Size(63, 14);
			this.label6.TabIndex = 16;
			this.label6.Text = "注意事项";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(45, 92);
			this.label5.Name = "label5";
			this.label5.Size = new Size(63, 14);
			this.label5.TabIndex = 15;
			this.label5.Text = "急救治疗";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(45, 27);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 14);
			this.label4.TabIndex = 14;
			this.label4.Text = "中毒症状";
			this.txtZYSX.Location = new Point(108, 129);
			this.txtZYSX.Multiline = true;
			this.txtZYSX.Name = "txtZYSX";
			this.txtZYSX.Size = new Size(343, 56);
			this.txtZYSX.TabIndex = 13;
			this.txtJJZL.Location = new Point(108, 68);
			this.txtJJZL.Multiline = true;
			this.txtJJZL.Name = "txtJJZL";
			this.txtJJZL.Size = new Size(343, 56);
			this.txtJJZL.TabIndex = 12;
			this.txtZDZZ.Location = new Point(108, 7);
			this.txtZDZZ.Multiline = true;
			this.txtZDZZ.Name = "txtZDZZ";
			this.txtZDZZ.Size = new Size(343, 56);
			this.txtZDZZ.TabIndex = 11;
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(159, 277);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(474, 310);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.panel1);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.MaximizeBox = false;
			this.MaximumSize = new Size(482, 344);
			this.MinimumSize = new Size(482, 344);
			base.Name = "frmDX";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "毒性";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
		public frmDX(string strDX)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			clsStr clsStr = new clsStr();
			string[] array = clsStr.Seperate(strDX, '|');
			this.txtZDZZ.Text = array[0];
			this.txtJJZL.Text = array[1];
			this.txtZYSX.Text = array[2];
			this.txtMRYXSRL.Text = array[3];
			this.txtJXJKLD50.Text = array[4];
			this.txtJXJPLD50.Text = array[5];
			this.txtZGDX.Text = array[6];
			this.txtGWDX.Text = array[7];
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
