using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmInit : Form
	{
		private IContainer components = null;
		public ProgressBar progressBar1;
		private PictureBox pictureBox1;
		public PictureBox pictureBox3;
		private PictureBox pictureBox2;
		public PictureBox pictureBox4;
		public PictureBox pictureBox5;
		public PictureBox pictureBox6;
		public PictureBox pictureBox7;
		public frmInit(Form frm)
		{
			this.InitializeComponent();
			this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\mount.png");
			this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\images\\progress.png");
			this.pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\images\\ball.png");
			this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\close_leave.png");
			this.pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\images\\%.png");
			base.Owner = frm;
			this.pictureBox2.Parent = this.pictureBox1;
			this.pictureBox3.Parent = this.pictureBox1;
			this.pictureBox4.Parent = this.pictureBox1;
			this.pictureBox5.Parent = this.pictureBox1;
			this.pictureBox6.Parent = this.pictureBox1;
			this.pictureBox7.Parent = this.pictureBox1;
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "您确定退出农药信息系统！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				Environment.Exit(0);
			}
		}
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\close_enter.png");
		}
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\close_leave.png");
		}
		private void pictureBox3_SizeChanged(object sender, EventArgs e)
		{
			this.pictureBox4.Location = new Point(this.pictureBox3.Width + this.pictureBox3.Location.X - 5, 462);
			Random random = new Random();
			if (this.pictureBox3.Width == 105)
			{
				this.pictureBox5.Visible = true;
				this.pictureBox7.Visible = true;
				this.pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\1.png");
				this.pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\" + random.Next(9).ToString() + ".png");
			}
			if (this.pictureBox3.Width == 205)
			{
				this.pictureBox5.Visible = true;
				this.pictureBox7.Visible = true;
				random = new Random();
				this.pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\3.png");
				this.pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\" + random.Next(9).ToString() + ".png");
			}
			if (this.pictureBox3.Width == 374)
			{
				this.pictureBox5.Visible = true;
				this.pictureBox7.Visible = true;
				random = new Random();
				this.pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\6.png");
				this.pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\" + random.Next(9).ToString() + ".png");
			}
			if (this.pictureBox3.Width == 554)
			{
				this.pictureBox5.Visible = true;
				this.pictureBox7.Visible = true;
				random = new Random();
				this.pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\9.png");
				this.pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\" + random.Next(9).ToString() + ".png");
			}
		}
		private void frmInit_Load(object sender, EventArgs e)
		{
			if (this.pictureBox3.Width == 5)
			{
				this.pictureBox5.Visible = false;
				this.pictureBox7.Visible = true;
				this.pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\1.png");
			}
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmInit));
			this.progressBar1 = new ProgressBar();
			this.pictureBox1 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.pictureBox2 = new PictureBox();
			this.pictureBox4 = new PictureBox();
			this.pictureBox5 = new PictureBox();
			this.pictureBox6 = new PictureBox();
			this.pictureBox7 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			((ISupportInitialize)this.pictureBox7).BeginInit();
			base.SuspendLayout();
			this.progressBar1.Location = new Point(459, 382);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(165, 23);
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Visible = false;
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Dock = DockStyle.Fill;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(1024, 746);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox3.BackColor = Color.Transparent;
			this.pictureBox3.Location = new Point(247, 468);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(5, 17);
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.SizeChanged += new EventHandler(this.pictureBox3_SizeChanged);
			this.pictureBox2.BackColor = Color.Transparent;
			this.pictureBox2.Location = new Point(827, 195);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(40, 40);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseLeave += new EventHandler(this.pictureBox2_MouseLeave);
			this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
			this.pictureBox2.MouseEnter += new EventHandler(this.pictureBox2_MouseEnter);
			this.pictureBox4.BackColor = Color.Transparent;
			this.pictureBox4.Location = new Point(251, 462);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(28, 28);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			this.pictureBox5.BackColor = Color.Transparent;
			this.pictureBox5.Location = new Point(495, 509);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new Size(22, 30);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			this.pictureBox6.BackColor = Color.Transparent;
			this.pictureBox6.Location = new Point(518, 509);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new Size(22, 30);
			this.pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 10;
			this.pictureBox6.TabStop = false;
			this.pictureBox7.BackColor = Color.Transparent;
			this.pictureBox7.Location = new Point(541, 509);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new Size(33, 30);
			this.pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 11;
			this.pictureBox7.TabStop = false;
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoSize = true;
			base.ClientSize = new Size(1024, 746);
			base.Controls.Add(this.pictureBox7);
			base.Controls.Add(this.pictureBox6);
			base.Controls.Add(this.pictureBox5);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.pictureBox1);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmInit";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "加载数据";
			base.Load += new EventHandler(this.frmInit_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox5).EndInit();
			((ISupportInitialize)this.pictureBox6).EndInit();
			((ISupportInitialize)this.pictureBox7).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
