using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace NYSCQY.YXCF
{
	public class frmJGS : Form
	{
		private string strE1 = "";
		private IContainer components = null;
		private PictureBox pic;
		private Button btnClose;
		private SaveFileDialog saveFileDialog1;
		public frmJGS(string strFileName)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.pic.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\JGS\\" + strFileName + ".bmp");
			this.strE1 = strFileName;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void pic_DoubleClick(object sender, EventArgs e)
		{
			this.saveFileDialog1.Title = "另存为";
			this.saveFileDialog1.FileName = this.strE1;
			this.saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg";
			this.saveFileDialog1.FilterIndex = 1;
			string currentDirectory = Directory.GetCurrentDirectory();
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.pic.Image.Save(this.saveFileDialog1.FileName);
			}
			Directory.SetCurrentDirectory(currentDirectory);
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmJGS));
			this.pic = new PictureBox();
			this.btnClose = new Button();
			this.saveFileDialog1 = new SaveFileDialog();
			((ISupportInitialize)this.pic).BeginInit();
			base.SuspendLayout();
			this.pic.BackColor = Color.Transparent;
			this.pic.Location = new Point(0, 0);
			this.pic.Name = "pic";
			this.pic.Size = new Size(424, 224);
			this.pic.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			this.pic.DoubleClick += new EventHandler(this.pic_DoubleClick);
			this.btnClose.Location = new Point(149, 224);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(422, 256);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.pic);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(430, 290);
			this.MinimumSize = new Size(430, 290);
			base.Name = "frmJGS";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "结构式";
			((ISupportInitialize)this.pic).EndInit();
			base.ResumeLayout(false);
		}
	}
}
