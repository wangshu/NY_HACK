using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY.YXCF
{
	public class frmLHXZ : Form
	{
		private IContainer components = null;
		private Button btnClose;
		private TextBox txt;
		public frmLHXZ(string strLHXZ)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.txt.Text = strLHXZ;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLHXZ));
			this.btnClose = new Button();
			this.txt = new TextBox();
			base.SuspendLayout();
			this.btnClose.Location = new Point(150, 217);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.txt.Location = new Point(0, 0);
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			this.txt.Size = new Size(424, 211);
			this.txt.TabIndex = 13;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(422, 256);
			base.Controls.Add(this.txt);
			base.Controls.Add(this.btnClose);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(430, 290);
			this.MinimumSize = new Size(430, 290);
			base.Name = "frmLHXZ";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "理化性质";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
