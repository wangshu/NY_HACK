using DevExpress.XtraGrid.Columns;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmView : Form
	{
		private IContainer components = null;
		private ListBox listBox1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private ListBox listBox2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		public static ListBox listbox = new ListBox();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmView));
			this.listBox1 = new ListBox();
			this.groupBox1 = new GroupBox();
			this.groupBox2 = new GroupBox();
			this.listBox2 = new ListBox();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			this.button6 = new Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 14;
			this.listBox1.Location = new Point(6, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(97, 312);
			this.listBox1.TabIndex = 0;
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.groupBox1.Location = new Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(109, 335);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "隐藏字段";
			this.groupBox2.Controls.Add(this.listBox2);
			this.groupBox2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.groupBox2.Location = new Point(187, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(109, 335);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "显示字段";
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 14;
			this.listBox2.Location = new Point(6, 16);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new Size(97, 312);
			this.listBox2.TabIndex = 0;
			this.button1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button1.Location = new Point(118, 38);
			this.button1.Name = "button1";
			this.button1.Size = new Size(63, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "添加->";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button2.Location = new Point(118, 97);
			this.button2.Name = "button2";
			this.button2.Size = new Size(63, 29);
			this.button2.TabIndex = 4;
			this.button2.Text = "<-移除";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button3.Location = new Point(302, 22);
			this.button3.Name = "button3";
			this.button3.Size = new Size(63, 29);
			this.button3.TabIndex = 5;
			this.button3.Text = "确定";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button4.Location = new Point(302, 71);
			this.button4.Name = "button4";
			this.button4.Size = new Size(63, 29);
			this.button4.TabIndex = 6;
			this.button4.Text = "取消";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button5.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button5.Location = new Point(302, 263);
			this.button5.Name = "button5";
			this.button5.Size = new Size(63, 29);
			this.button5.TabIndex = 7;
			this.button5.Text = "上移";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.button6.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button6.Location = new Point(302, 304);
			this.button6.Name = "button6";
			this.button6.Size = new Size(63, 29);
			this.button6.TabIndex = 8;
			this.button6.Text = "下移";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new EventHandler(this.button6_Click);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(369, 347);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.groupBox2);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmView";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数据视图";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
		}
		public frmView(DataGridViewColumnCollection dcl)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					this.listBox2.Items.Add(dcl[i].HeaderText);
				}
				else
				{
					this.listBox1.Items.Add(dcl[i].HeaderText);
				}
			}
			this.listBox2.SelectedIndex = this.listBox2.Items.Count - 1;
			if (this.listBox1.Items.Count > 0)
			{
				this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
			}
		}
		public frmView(GridColumnCollection dcl)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					this.listBox2.Items.Add(dcl[i].Caption);
				}
				else
				{
					this.listBox1.Items.Add(dcl[i].Caption);
				}
			}
			this.listBox2.SelectedIndex = this.listBox2.Items.Count - 1;
			if (this.listBox1.Items.Count > 0)
			{
				this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
			}
		}
		private void button5_Click(object sender, EventArgs e)
		{
			if (this.listBox2.SelectedIndex > 0)
			{
				int selectedIndex = this.listBox2.SelectedIndex;
				string value = this.listBox2.Items[selectedIndex - 1].ToString();
				this.listBox2.Items[selectedIndex - 1] = this.listBox2.SelectedItem.ToString();
				this.listBox2.Items[selectedIndex] = value;
				this.listBox2.SelectedIndex = selectedIndex - 1;
			}
		}
		private void button6_Click(object sender, EventArgs e)
		{
			if (this.listBox2.SelectedIndex < this.listBox2.Items.Count - 1)
			{
				int selectedIndex = this.listBox2.SelectedIndex;
				string value = this.listBox2.Items[selectedIndex + 1].ToString();
				this.listBox2.Items[selectedIndex + 1] = this.listBox2.SelectedItem.ToString();
				this.listBox2.Items[selectedIndex] = value;
				this.listBox2.SelectedIndex = selectedIndex + 1;
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.listBox2.Items.Count > 0)
			{
				int selectedIndex = this.listBox2.SelectedIndex;
				object obj = new object();
				obj = this.listBox2.SelectedItem;
				this.listBox2.Items.Remove(obj);
				this.listBox1.Items.Add(obj);
				if (selectedIndex >= 1)
				{
					this.listBox2.SelectedIndex = selectedIndex - 1;
				}
				else
				{
					if (this.listBox2.Items.Count > 0)
					{
						this.listBox2.SelectedIndex = selectedIndex;
					}
				}
				if (this.listBox1.Items.Count >= 1)
				{
					this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.listBox1.Items.Count > 0)
			{
				int selectedIndex = this.listBox1.SelectedIndex;
				object obj = new object();
				obj = this.listBox1.SelectedItem;
				this.listBox1.Items.Remove(obj);
				this.listBox2.Items.Add(obj);
				if (selectedIndex >= 1)
				{
					this.listBox1.SelectedIndex = selectedIndex - 1;
				}
				else
				{
					if (this.listBox1.Items.Count > 0)
					{
						this.listBox1.SelectedIndex = selectedIndex;
					}
				}
				if (this.listBox2.Items.Count > 0)
				{
					this.listBox2.SelectedIndex = this.listBox2.Items.Count - 1;
				}
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			frmView.listbox = null;
			base.Close();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			frmView.listbox = this.listBox2;
			base.Close();
		}
	}
}
