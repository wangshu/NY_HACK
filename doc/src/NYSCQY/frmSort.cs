using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmSort : Form
	{
		public class SortCol
		{
			public string valueMember
			{
				get;
				set;
			}
			public string textMember
			{
				get;
				set;
			}
		}
		private IContainer components = null;
		private GroupBox groupBox1;
		private ComboBox comboBox1;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private GroupBox groupBox2;
		private ComboBox comboBox2;
		private GroupBox groupBox3;
		private ComboBox comboBox3;
		private GroupBox groupBox4;
		private ComboBox comboBox4;
		private Button button1;
		private Button button2;
		private Panel panel1;
		private Panel panel2;
		private RadioButton radioButton3;
		private RadioButton radioButton4;
		private Panel panel3;
		private RadioButton radioButton5;
		private RadioButton radioButton6;
		private Panel panel4;
		private RadioButton radioButton7;
		private RadioButton radioButton8;
		private bool fillfinishok = false;
		public static string SortColumn = "";
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSort));
			this.groupBox1 = new GroupBox();
			this.comboBox1 = new ComboBox();
			this.radioButton1 = new RadioButton();
			this.radioButton2 = new RadioButton();
			this.groupBox2 = new GroupBox();
			this.comboBox2 = new ComboBox();
			this.groupBox3 = new GroupBox();
			this.comboBox3 = new ComboBox();
			this.groupBox4 = new GroupBox();
			this.comboBox4 = new ComboBox();
			this.button1 = new Button();
			this.button2 = new Button();
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.radioButton3 = new RadioButton();
			this.radioButton4 = new RadioButton();
			this.panel3 = new Panel();
			this.radioButton5 = new RadioButton();
			this.radioButton6 = new RadioButton();
			this.panel4 = new Panel();
			this.radioButton7 = new RadioButton();
			this.radioButton8 = new RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new Point(6, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(176, 55);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "第一排序字段";
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(6, 20);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new Size(161, 20);
			this.comboBox1.TabIndex = 0;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new Point(2, 7);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new Size(47, 16);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "升序";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(3, 29);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new Size(47, 16);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "降序";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Location = new Point(6, 69);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(176, 55);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "第二排序字段";
			this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new Point(6, 20);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new Size(161, 20);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.SelectedValueChanged += new EventHandler(this.comboBox2_SelectedValueChanged);
			this.groupBox3.Controls.Add(this.comboBox3);
			this.groupBox3.Location = new Point(6, 130);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new Size(176, 55);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "第三排序字段";
			this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox3.Enabled = false;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new Point(6, 20);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new Size(161, 20);
			this.comboBox3.TabIndex = 0;
			this.comboBox3.SelectedValueChanged += new EventHandler(this.comboBox3_SelectedValueChanged);
			this.groupBox4.Controls.Add(this.comboBox4);
			this.groupBox4.Location = new Point(6, 191);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new Size(176, 55);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "第四排序字段";
			this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox4.Enabled = false;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new Point(6, 20);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new Size(161, 20);
			this.comboBox4.TabIndex = 0;
			this.button1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button1.Location = new Point(250, 22);
			this.button1.Name = "button1";
			this.button1.Size = new Size(72, 29);
			this.button1.TabIndex = 13;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button2.Location = new Point(250, 69);
			this.button2.Name = "button2";
			this.button2.Size = new Size(72, 29);
			this.button2.TabIndex = 14;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Location = new Point(188, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(56, 55);
			this.panel1.TabIndex = 15;
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Location = new Point(188, 69);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(56, 55);
			this.panel2.TabIndex = 16;
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new Point(2, 7);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new Size(47, 16);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "升序";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new Point(3, 29);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new Size(47, 16);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "降序";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.panel3.Controls.Add(this.radioButton5);
			this.panel3.Controls.Add(this.radioButton6);
			this.panel3.Location = new Point(188, 130);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(56, 55);
			this.panel3.TabIndex = 17;
			this.radioButton5.AutoSize = true;
			this.radioButton5.Checked = true;
			this.radioButton5.Location = new Point(2, 7);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new Size(47, 16);
			this.radioButton5.TabIndex = 2;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "升序";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new Point(3, 29);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new Size(47, 16);
			this.radioButton6.TabIndex = 3;
			this.radioButton6.Text = "降序";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.panel4.Controls.Add(this.radioButton7);
			this.panel4.Controls.Add(this.radioButton8);
			this.panel4.Location = new Point(188, 191);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(56, 55);
			this.panel4.TabIndex = 18;
			this.radioButton7.AutoSize = true;
			this.radioButton7.Checked = true;
			this.radioButton7.Location = new Point(2, 7);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new Size(47, 16);
			this.radioButton7.TabIndex = 2;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "升序";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new Point(3, 29);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new Size(47, 16);
			this.radioButton8.TabIndex = 3;
			this.radioButton8.Text = "降序";
			this.radioButton8.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(325, 260);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmSort";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数据排序";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			base.ResumeLayout(false);
		}
		public frmSort(DataGridViewColumnCollection dcl)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.BindCombox1(dcl);
			this.BindCombox2(dcl);
			this.BindCombox3(dcl);
			this.BindCombox4(dcl);
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
			this.comboBox3.SelectedIndex = 0;
			this.comboBox4.SelectedIndex = 0;
			this.fillfinishok = true;
		}
		public frmSort(GridColumnCollection dcl)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.BindCombox1(dcl);
			this.BindCombox2(dcl);
			this.BindCombox3(dcl);
			this.BindCombox4(dcl);
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
			this.comboBox3.SelectedIndex = 0;
			this.comboBox4.SelectedIndex = 0;
			this.fillfinishok = true;
		}
		private void BindCombox1(DataGridViewColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item = new frmSort.SortCol
					{
						valueMember = dcl[i].Name,
						textMember = dcl[i].HeaderText
					};
					list.Add(item);
				}
			}
			this.comboBox1.DataSource = list;
			this.comboBox1.DisplayMember = "textMember";
			this.comboBox1.ValueMember = "valueMember";
		}
		private void BindCombox1(GridColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item = new frmSort.SortCol
					{
						valueMember = dcl[i].FieldName,
						textMember = dcl[i].Caption
					};
					list.Add(item);
				}
			}
			this.comboBox1.DataSource = list;
			this.comboBox1.DisplayMember = "textMember";
			this.comboBox1.ValueMember = "valueMember";
		}
		private void BindCombox2(DataGridViewColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			frmSort.SortCol item = new frmSort.SortCol
			{
				valueMember = "0",
				textMember = "无..."
			};
			list.Add(item);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item2 = new frmSort.SortCol
					{
						valueMember = dcl[i].Name,
						textMember = dcl[i].HeaderText
					};
					list.Add(item2);
				}
			}
			this.comboBox2.DataSource = list;
			this.comboBox2.DisplayMember = "textMember";
			this.comboBox2.ValueMember = "valueMember";
		}
		private void BindCombox2(GridColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			frmSort.SortCol item = new frmSort.SortCol
			{
				valueMember = "0",
				textMember = "无..."
			};
			list.Add(item);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item2 = new frmSort.SortCol
					{
						valueMember = dcl[i].FieldName,
						textMember = dcl[i].Caption
					};
					list.Add(item2);
				}
			}
			this.comboBox2.DataSource = list;
			this.comboBox2.DisplayMember = "textMember";
			this.comboBox2.ValueMember = "valueMember";
		}
		private void BindCombox3(DataGridViewColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			frmSort.SortCol item = new frmSort.SortCol
			{
				valueMember = "0",
				textMember = "无..."
			};
			list.Add(item);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item2 = new frmSort.SortCol
					{
						valueMember = dcl[i].Name,
						textMember = dcl[i].HeaderText
					};
					list.Add(item2);
				}
			}
			this.comboBox3.DataSource = list;
			this.comboBox3.DisplayMember = "textMember";
			this.comboBox3.ValueMember = "valueMember";
		}
		private void BindCombox3(GridColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			frmSort.SortCol item = new frmSort.SortCol
			{
				valueMember = "0",
				textMember = "无..."
			};
			list.Add(item);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item2 = new frmSort.SortCol
					{
						valueMember = dcl[i].FieldName,
						textMember = dcl[i].Caption
					};
					list.Add(item2);
				}
			}
			this.comboBox3.DataSource = list;
			this.comboBox3.DisplayMember = "textMember";
			this.comboBox3.ValueMember = "valueMember";
		}
		private void BindCombox4(DataGridViewColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			frmSort.SortCol item = new frmSort.SortCol
			{
				valueMember = "0",
				textMember = "无..."
			};
			list.Add(item);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item2 = new frmSort.SortCol
					{
						valueMember = dcl[i].Name,
						textMember = dcl[i].HeaderText
					};
					list.Add(item2);
				}
			}
			this.comboBox4.DataSource = list;
			this.comboBox4.DisplayMember = "textMember";
			this.comboBox4.ValueMember = "valueMember";
		}
		private void BindCombox4(GridColumnCollection dcl)
		{
			List<frmSort.SortCol> list = new List<frmSort.SortCol>();
			frmSort.SortCol item = new frmSort.SortCol
			{
				valueMember = "0",
				textMember = "无..."
			};
			list.Add(item);
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					frmSort.SortCol item2 = new frmSort.SortCol
					{
						valueMember = dcl[i].FieldName,
						textMember = dcl[i].Caption
					};
					list.Add(item2);
				}
			}
			this.comboBox4.DataSource = list;
			this.comboBox4.DisplayMember = "textMember";
			this.comboBox4.ValueMember = "valueMember";
		}
		private void button2_Click(object sender, EventArgs e)
		{
			frmSort.SortColumn = "";
			base.Close();
		}
		private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.fillfinishok)
			{
				if (this.comboBox2.SelectedValue.ToString() != "0")
				{
					this.comboBox3.Enabled = true;
				}
			}
		}
		private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.fillfinishok)
			{
				if (this.comboBox3.SelectedValue.ToString() != "0")
				{
					this.comboBox4.Enabled = true;
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string text = "";
			text += this.comboBox1.SelectedValue;
			if (this.radioButton2.Checked)
			{
				text += " desc";
			}
			if (this.comboBox2.SelectedValue.ToString() != "0")
			{
				text = text + "," + this.comboBox2.SelectedValue;
				if (this.radioButton4.Checked)
				{
					text += " desc";
				}
			}
			if (this.comboBox3.Enabled && this.comboBox3.SelectedValue.ToString() != "0")
			{
				text = text + "," + this.comboBox3.SelectedValue;
				if (this.radioButton6.Checked)
				{
					text += " desc";
				}
			}
			if (this.comboBox4.Enabled && this.comboBox4.SelectedValue.ToString() != "0")
			{
				text = text + "," + this.comboBox4.SelectedValue;
				if (this.radioButton8.Checked)
				{
					text += " desc";
				}
			}
			frmSort.SortColumn = text;
			base.Close();
		}
	}
}
