using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmGroup : Form
	{
		public class GroupCol
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
		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
		private DataGridView dataGridView2;
		private DataView dvgroup = new DataView();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmGroup));
			this.groupBox1 = new GroupBox();
			this.comboBox1 = new ComboBox();
			this.dataGridView1 = new DataGridView();
			this.button1 = new Button();
			this.button2 = new Button();
			this.dataGridView2 = new DataGridView();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			((ISupportInitialize)this.dataGridView2).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.groupBox1.Location = new Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(183, 55);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "统计方式";
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(7, 21);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new Size(159, 22);
			this.comboBox1.TabIndex = 0;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new Point(3, 80);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new Size(475, 170);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellMouseUp += new DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
			this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
			this.button1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button1.Location = new Point(247, 18);
			this.button1.Name = "button1";
			this.button1.Size = new Size(90, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "执行统计";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.button2.Location = new Point(370, 18);
			this.button2.Name = "button2";
			this.button2.Size = new Size(90, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "取消统计";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new Point(3, 256);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new Size(475, 229);
			this.dataGridView2.TabIndex = 4;
			this.dataGridView2.CellPainting += new DataGridViewCellPaintingEventHandler(this.dataGridView2_CellPainting);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(482, 491);
			base.Controls.Add(this.dataGridView2);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmGroup";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数据统计";
			this.groupBox1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView1).EndInit();
			((ISupportInitialize)this.dataGridView2).EndInit();
			base.ResumeLayout(false);
		}
		public frmGroup(DataGridView dv, string flag)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.dvgroup = (DataView)dv.DataSource;
			this.BindCombox();
			this.comboBox1.SelectedIndex = 0;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.RowHeadersWidth = 55;
			this.dataGridView1.BackgroundColor = this.BackColor;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.RowHeadersWidth = 55;
			this.dataGridView2.BackgroundColor = this.BackColor;
			this.dataGridView2.EnableHeadersVisualStyles = false;
		}
		public frmGroup(GridControl dv, string flag)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.dvgroup = (DataView)dv.DataSource;
			this.BindCombox();
			this.comboBox1.SelectedIndex = 0;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.RowHeadersWidth = 55;
			this.dataGridView1.BackgroundColor = this.BackColor;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.RowHeadersWidth = 55;
			this.dataGridView2.BackgroundColor = this.BackColor;
			this.dataGridView2.EnableHeadersVisualStyles = false;
		}
		private void BindCombox()
		{
			List<frmGroup.GroupCol> list = new List<frmGroup.GroupCol>();
			frmGroup.GroupCol item = new frmGroup.GroupCol
			{
				valueMember = "R13",
				textMember = "按剂型统计"
			};
			list.Add(item);
			item = new frmGroup.GroupCol
			{
				valueMember = "R11",
				textMember = "按毒性统计"
			};
			list.Add(item);
			item = new frmGroup.GroupCol
			{
				valueMember = "R12",
				textMember = "按农药类别统计"
			};
			list.Add(item);
			item = new frmGroup.GroupCol
			{
				valueMember = "F2",
				textMember = "按生产企业统计"
			};
			list.Add(item);
			this.comboBox1.DataSource = list;
			this.comboBox1.DisplayMember = "textMember";
			this.comboBox1.ValueMember = "valueMember";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			DataRow[] array = this.dvgroup.ToTable("group", true, new string[]
			{
				this.comboBox1.SelectedValue.ToString()
			}).Select("", this.comboBox1.SelectedValue.ToString());
			DataTable dataTable = new DataTable("aaa");
			if (this.dvgroup.Count < 15000)
			{
				dataTable.Columns.Add("item", typeof(string));
				dataTable.Columns.Add("count", typeof(int));
				for (int i = 0; i < array.Length; i++)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["item"] = array[i][0].ToString();
					dataRow["count"] = this.getCount(this.comboBox1.SelectedValue.ToString(), array[i][0].ToString());
					dataTable.Rows.Add(dataRow);
				}
				dataTable.DefaultView.Sort = "count";
				this.dataGridView1.DataSource = dataTable;
				this.dataGridView1.ReadOnly = true;
				this.dataGridView1.Columns[0].Width = 310;
				this.dataGridView1.Columns[0].HeaderText = "统计项目";
				this.dataGridView1.Columns[1].Width = 85;
				this.dataGridView1.Columns[1].HeaderText = "统计数量";
				this.dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
			}
			else
			{
				MessageBox.Show(this, "要统计的数据多于15000条,请选择部分数据统计!", "提示");
			}
			this.Cursor = Cursors.Arrow;
		}
		private int getCount(string stritem, string itemmc)
		{
			DataTable dataTable = this.dvgroup.ToTable();
			string filterExpression;
			if (itemmc.Length > 0)
			{
				filterExpression = stritem + "='" + itemmc + "'";
			}
			else
			{
				filterExpression = stritem + " is null";
			}
			DataRow[] array = dataTable.Select(filterExpression, "");
			return array.Length;
		}
		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex < 0 && e.RowIndex >= 0)
			{
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
				Rectangle cellBounds = e.CellBounds;
				cellBounds.Inflate(-2, -2);
				TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134), cellBounds, e.CellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
				e.Handled = true;
			}
		}
		private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (e.ColumnIndex >= 0)
				{
					this.fillDataGridView2(this.dataGridView1[0, e.RowIndex].Value.ToString());
				}
			}
		}
		private void fillDataGridView2(string strkey)
		{
			DataTable dataTable = this.dvgroup.ToTable();
			string filterExpression;
			if (strkey.Length > 0)
			{
				filterExpression = this.comboBox1.SelectedValue.ToString() + "='" + strkey + "'";
			}
			else
			{
				filterExpression = this.comboBox1.SelectedValue.ToString() + " is null";
			}
			DataRow[] array = dataTable.Select(filterExpression, "");
			DataTable dataTable2 = dataTable.Clone();
			for (int i = 0; i < array.Length; i++)
			{
				DataRow dataRow = dataTable2.NewRow();
				for (int j = 0; j < dataTable2.Columns.Count; j++)
				{
					dataRow[j] = array[i][j];
				}
				dataTable2.Rows.Add(dataRow);
			}
			this.dataGridView2.DataSource = dataTable2;
			this.dataGridView2.Columns["R1"].HeaderText = "登记证号";
			this.dataGridView2.Columns["R2"].HeaderText = "登记名称";
			this.dataGridView2.Columns["HL"].HeaderText = "含量";
			this.dataGridView2.Columns["R13"].HeaderText = "剂型";
			this.dataGridView2.Columns["R11"].HeaderText = "毒性";
			this.dataGridView2.Columns["R12"].HeaderText = "农药类别";
			this.dataGridView2.Columns["R80"].HeaderText = "生产批准/许可证号";
			this.dataGridView2.Columns["R90"].HeaderText = "执行标准/企业标准";
			this.dataGridView2.Columns["R80"].Visible = false;
			this.dataGridView2.Columns["R90"].Visible = false;
			this.dataGridView2.Columns["R4"].HeaderText = "有效起始日";
			this.dataGridView2.Columns["R5"].HeaderText = "有效截止日";
			this.dataGridView2.Columns["F2"].HeaderText = "生产企业";
			this.dataGridView2.Columns["F9"].HeaderText = "电话";
			this.dataGridView2.Columns["F14"].HeaderText = "联系人";
		}
		private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex < 0 && e.RowIndex >= 0)
			{
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
				Rectangle cellBounds = e.CellBounds;
				cellBounds.Inflate(-2, -2);
				TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134), cellBounds, e.CellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
				e.Handled = true;
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
