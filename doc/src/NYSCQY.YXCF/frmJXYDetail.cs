using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY.YXCF
{
	public class frmJXYDetail : Form
	{
		private IContainer components = null;
		private Panel panel1;
		private Label label6;
		private Label label5;
		private Label label4;
		private TextBox txtXYQK;
		private TextBox txtJYQK;
		private TextBox txtJXYYY;
		private Button btnClose;
		public frmJXYDetail(string strJXY)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			clsStr clsStr = new clsStr();
			string[] array = clsStr.Seperate(strJXY, '|');
			this.txtJXYYY.Text = array[0];
			this.txtJYQK.Text = array[1];
			this.txtXYQK.Text = array[2];
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmJXYDetail));
			this.panel1 = new Panel();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.txtXYQK = new TextBox();
			this.txtJYQK = new TextBox();
			this.txtJXYYY = new TextBox();
			this.btnClose = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtXYQK);
			this.panel1.Controls.Add(this.txtJYQK);
			this.panel1.Controls.Add(this.txtJXYYY);
			this.panel1.Location = new Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(480, 191);
			this.panel1.TabIndex = 0;
			this.label6.AutoSize = true;
			this.label6.Location = new Point(15, 145);
			this.label6.Name = "label6";
			this.label6.Size = new Size(63, 14);
			this.label6.TabIndex = 16;
			this.label6.Text = "限用情况";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(15, 86);
			this.label5.Name = "label5";
			this.label5.Size = new Size(63, 14);
			this.label5.TabIndex = 15;
			this.label5.Text = "禁用情况";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(1, 25);
			this.label4.Name = "label4";
			this.label4.Size = new Size(77, 14);
			this.label4.TabIndex = 14;
			this.label4.Text = "禁限用原因";
			this.txtXYQK.Location = new Point(79, 126);
			this.txtXYQK.Multiline = true;
			this.txtXYQK.Name = "txtXYQK";
			this.txtXYQK.Size = new Size(398, 55);
			this.txtXYQK.TabIndex = 13;
			this.txtJYQK.Location = new Point(79, 66);
			this.txtJYQK.Multiline = true;
			this.txtJYQK.Name = "txtJYQK";
			this.txtJYQK.Size = new Size(398, 55);
			this.txtJYQK.TabIndex = 12;
			this.txtJXYYY.Location = new Point(79, 6);
			this.txtJXYYY.Multiline = true;
			this.txtJXYYY.Name = "txtJXYYY";
			this.txtJXYYY.Size = new Size(398, 55);
			this.txtJXYYY.TabIndex = 11;
			this.btnClose.Location = new Point(181, 191);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(489, 224);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.panel1);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(497, 258);
			this.MinimumSize = new Size(497, 258);
			base.Name = "frmJXYDetail";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "禁限用";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
