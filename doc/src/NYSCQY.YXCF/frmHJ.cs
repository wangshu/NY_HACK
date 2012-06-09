using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY.YXCF
{
	public class frmHJ : Form
	{
		private IContainer components = null;
		private Panel panel1;
		private Label label1;
		private TextBox txtSTBC;
		private Label label6;
		private Label label5;
		private Label label4;
		private TextBox txtTD;
		private TextBox txtMF;
		private TextBox txtSSSW;
		private Button btnClose;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHJ));
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.txtSTBC = new TextBox();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.txtTD = new TextBox();
			this.txtMF = new TextBox();
			this.txtSSSW = new TextBox();
			this.btnClose = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtSTBC);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtTD);
			this.panel1.Controls.Add(this.txtMF);
			this.panel1.Controls.Add(this.txtSSSW);
			this.panel1.Location = new Point(4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(460, 227);
			this.panel1.TabIndex = 16;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(5, 182);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 18;
			this.label1.Text = "水土保持";
			this.txtSTBC.Location = new Point(69, 167);
			this.txtSTBC.Multiline = true;
			this.txtSTBC.Name = "txtSTBC";
			this.txtSTBC.Size = new Size(387, 44);
			this.txtSTBC.TabIndex = 17;
			this.label6.AutoSize = true;
			this.label6.Location = new Point(33, 132);
			this.label6.Name = "label6";
			this.label6.Size = new Size(35, 14);
			this.label6.TabIndex = 16;
			this.label6.Text = "天敌";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(33, 83);
			this.label5.Name = "label5";
			this.label5.Size = new Size(35, 14);
			this.label5.TabIndex = 15;
			this.label5.Text = "蜜蜂";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(5, 27);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 14);
			this.label4.TabIndex = 14;
			this.label4.Text = "水生生物";
			this.txtTD.Location = new Point(69, 117);
			this.txtTD.Multiline = true;
			this.txtTD.Name = "txtTD";
			this.txtTD.Size = new Size(387, 44);
			this.txtTD.TabIndex = 13;
			this.txtMF.Location = new Point(69, 68);
			this.txtMF.Multiline = true;
			this.txtMF.Name = "txtMF";
			this.txtMF.Size = new Size(387, 44);
			this.txtMF.TabIndex = 12;
			this.txtSSSW.Location = new Point(69, 7);
			this.txtSSSW.Multiline = true;
			this.txtSSSW.Name = "txtSSSW";
			this.txtSSSW.Size = new Size(387, 56);
			this.txtSSSW.TabIndex = 11;
			this.btnClose.Location = new Point(153, 246);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(472, 290);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.btnClose);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(480, 324);
			this.MinimumSize = new Size(480, 324);
			base.Name = "frmHJ";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "环境";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
		public frmHJ(string strHJ)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			clsStr clsStr = new clsStr();
			string[] array = clsStr.Seperate(strHJ, '|');
			this.txtSSSW.Text = array[0];
			this.txtMF.Text = array[1];
			this.txtTD.Text = array[2];
			this.txtSTBC.Text = array[3];
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
