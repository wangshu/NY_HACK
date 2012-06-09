using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY.YXCF
{
	public class frmZYTD : Form
	{
		private IContainer components = null;
		private TextBox txt;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmZYTD));
			this.txt = new TextBox();
			this.btnClose = new Button();
			base.SuspendLayout();
			this.txt.Location = new Point(0, 0);
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			this.txt.Size = new Size(424, 211);
			this.txt.TabIndex = 15;
			this.btnClose.Location = new Point(142, 219);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(422, 256);
			base.Controls.Add(this.txt);
			base.Controls.Add(this.btnClose);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(430, 290);
			this.MinimumSize = new Size(430, 290);
			base.Name = "frmZYTD";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "作用特点";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		public frmZYTD(string strZYTD)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.txt.Text = strZYTD;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
