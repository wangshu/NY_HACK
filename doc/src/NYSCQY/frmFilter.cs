using DevExpress.XtraGrid.Columns;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmFilter : Form
	{
		private IContainer components = null;
		private Button btnFilter;
		private TextBox txtKeyWord;
		private CheckBox chkR1;
		private GroupBox grpNY;
		private GroupBox groupBox2;
		private CheckBox chkAll;
		private CheckBox chkR11;
		private CheckBox chkR13;
		private CheckBox chkHL;
		private CheckBox chkR5;
		private CheckBox chkR4;
		private CheckBox chkF2;
		private CheckBox chkR12;
		private CheckBox chkR2;
		private RadioButton radlike;
		private RadioButton radequal;
		private Button btnClose;
		public static string FilterColumn = "";
		private string filtertype = "";
		private GridColumnCollection tempdcl;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmFilter));
			this.btnFilter = new Button();
			this.txtKeyWord = new TextBox();
			this.chkR1 = new CheckBox();
			this.grpNY = new GroupBox();
			this.chkAll = new CheckBox();
			this.chkR11 = new CheckBox();
			this.chkR13 = new CheckBox();
			this.chkHL = new CheckBox();
			this.chkR5 = new CheckBox();
			this.chkR4 = new CheckBox();
			this.chkF2 = new CheckBox();
			this.chkR12 = new CheckBox();
			this.chkR2 = new CheckBox();
			this.groupBox2 = new GroupBox();
			this.radlike = new RadioButton();
			this.radequal = new RadioButton();
			this.btnClose = new Button();
			this.grpNY.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.btnFilter.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnFilter.Location = new Point(209, 8);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new Size(79, 29);
			this.btnFilter.TabIndex = 4;
			this.btnFilter.Text = "过滤";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new EventHandler(this.btnFilter_Click);
			this.txtKeyWord.ImeMode = ImeMode.On;
			this.txtKeyWord.Location = new Point(6, 17);
			this.txtKeyWord.Name = "txtKeyWord";
			this.txtKeyWord.Size = new Size(188, 23);
			this.txtKeyWord.TabIndex = 0;
			this.chkR1.AutoSize = true;
			this.chkR1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR1.Location = new Point(6, 17);
			this.chkR1.Name = "chkR1";
			this.chkR1.Size = new Size(82, 18);
			this.chkR1.TabIndex = 2;
			this.chkR1.Text = "登记证号";
			this.chkR1.UseVisualStyleBackColor = true;
			this.grpNY.Controls.Add(this.chkAll);
			this.grpNY.Controls.Add(this.chkR11);
			this.grpNY.Controls.Add(this.chkR13);
			this.grpNY.Controls.Add(this.chkHL);
			this.grpNY.Controls.Add(this.chkR5);
			this.grpNY.Controls.Add(this.chkR4);
			this.grpNY.Controls.Add(this.chkF2);
			this.grpNY.Controls.Add(this.chkR12);
			this.grpNY.Controls.Add(this.chkR2);
			this.grpNY.Controls.Add(this.chkR1);
			this.grpNY.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.grpNY.Location = new Point(2, 74);
			this.grpNY.Name = "grpNY";
			this.grpNY.Size = new Size(286, 116);
			this.grpNY.TabIndex = 3;
			this.grpNY.TabStop = false;
			this.grpNY.Text = "过滤列";
			this.chkAll.AutoSize = true;
			this.chkAll.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkAll.Location = new Point(6, 89);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new Size(68, 18);
			this.chkAll.TabIndex = 11;
			this.chkAll.Text = "所有列";
			this.chkAll.UseVisualStyleBackColor = true;
			this.chkAll.CheckedChanged += new EventHandler(this.chkAll_CheckedChanged);
			this.chkR11.AutoSize = true;
			this.chkR11.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR11.Location = new Point(186, 65);
			this.chkR11.Name = "chkR11";
			this.chkR11.Size = new Size(54, 18);
			this.chkR11.TabIndex = 10;
			this.chkR11.Text = "毒性";
			this.chkR11.UseVisualStyleBackColor = true;
			this.chkR13.AutoSize = true;
			this.chkR13.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR13.Location = new Point(89, 65);
			this.chkR13.Name = "chkR13";
			this.chkR13.Size = new Size(54, 18);
			this.chkR13.TabIndex = 9;
			this.chkR13.Text = "剂型";
			this.chkR13.UseVisualStyleBackColor = true;
			this.chkHL.AutoSize = true;
			this.chkHL.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkHL.Location = new Point(6, 65);
			this.chkHL.Name = "chkHL";
			this.chkHL.Size = new Size(54, 18);
			this.chkHL.TabIndex = 8;
			this.chkHL.Text = "含量";
			this.chkHL.UseVisualStyleBackColor = true;
			this.chkR5.AutoSize = true;
			this.chkR5.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR5.Location = new Point(186, 41);
			this.chkR5.Name = "chkR5";
			this.chkR5.Size = new Size(96, 18);
			this.chkR5.TabIndex = 7;
			this.chkR5.Text = "有效截止日";
			this.chkR5.UseVisualStyleBackColor = true;
			this.chkR4.AutoSize = true;
			this.chkR4.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR4.Location = new Point(89, 41);
			this.chkR4.Name = "chkR4";
			this.chkR4.Size = new Size(96, 18);
			this.chkR4.TabIndex = 6;
			this.chkR4.Text = "有效起始日";
			this.chkR4.UseVisualStyleBackColor = true;
			this.chkF2.AutoSize = true;
			this.chkF2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkF2.Location = new Point(6, 41);
			this.chkF2.Name = "chkF2";
			this.chkF2.Size = new Size(82, 18);
			this.chkF2.TabIndex = 5;
			this.chkF2.Text = "生产企业";
			this.chkF2.UseVisualStyleBackColor = true;
			this.chkR12.AutoSize = true;
			this.chkR12.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR12.Location = new Point(186, 17);
			this.chkR12.Name = "chkR12";
			this.chkR12.Size = new Size(82, 18);
			this.chkR12.TabIndex = 4;
			this.chkR12.Text = "农药类别";
			this.chkR12.UseVisualStyleBackColor = true;
			this.chkR2.AutoSize = true;
			this.chkR2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.chkR2.Location = new Point(89, 17);
			this.chkR2.Name = "chkR2";
			this.chkR2.Size = new Size(82, 18);
			this.chkR2.TabIndex = 3;
			this.chkR2.Text = "登记名称";
			this.chkR2.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.radlike);
			this.groupBox2.Controls.Add(this.radequal);
			this.groupBox2.Controls.Add(this.txtKeyWord);
			this.groupBox2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.groupBox2.Location = new Point(4, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(200, 65);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "关键字";
			this.radlike.AutoSize = true;
			this.radlike.Checked = true;
			this.radlike.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radlike.Location = new Point(105, 46);
			this.radlike.Name = "radlike";
			this.radlike.Size = new Size(81, 18);
			this.radlike.TabIndex = 3;
			this.radlike.TabStop = true;
			this.radlike.Text = "模糊过滤";
			this.radlike.UseVisualStyleBackColor = true;
			this.radequal.AutoSize = true;
			this.radequal.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radequal.Location = new Point(17, 46);
			this.radequal.Name = "radequal";
			this.radequal.Size = new Size(81, 18);
			this.radequal.TabIndex = 2;
			this.radequal.Text = "精确过滤";
			this.radequal.UseVisualStyleBackColor = true;
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(209, 46);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(79, 29);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AcceptButton = this.btnFilter;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(292, 196);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.grpNY);
			base.Controls.Add(this.btnFilter);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmFilter";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数据过滤";
			base.Load += new EventHandler(this.frmFilter_Load);
			base.Activated += new EventHandler(this.frmFilter_Activated);
			this.grpNY.ResumeLayout(false);
			this.grpNY.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}
		public frmFilter(string FilterType)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.filtertype = FilterType;
			if (!(FilterType == "NY"))
			{
				base.Height -= 120;
				this.grpNY.Visible = false;
			}
		}
		public frmFilter(DataGridViewColumnCollection dcl)
		{
		}
		public frmFilter(GridColumnCollection dcl)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.filtertype = "OTHER";
			this.tempdcl = dcl;
			base.Height -= 120;
			this.grpNY.Visible = false;
		}
		private void btnFilter_Click(object sender, EventArgs e)
		{
			if (this.txtKeyWord.Text.Trim() == "")
			{
				MessageBox.Show(this, "请输入关键字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtKeyWord.Focus();
			}
			else
			{
				string str = this.txtKeyWord.Text.Trim().Replace("%", "[%]");
				string text = "";
				string text2;
				if (this.radequal.Checked)
				{
					text2 = "='" + str + "'";
				}
				else
				{
					text2 = "like '%" + str + "%'";
				}
				if (this.filtertype.ToUpper() == "NY")
				{
					if (this.chkR1.Checked)
					{
						text = text + "R1 " + text2 + " or ";
					}
					if (this.chkR2.Checked)
					{
						text = text + "R2 " + text2 + " or ";
					}
					if (this.chkHL.Checked)
					{
						text = text + "HL " + text2 + " or ";
					}
					if (this.chkR12.Checked)
					{
						text = text + "R12 " + text2 + " or ";
					}
					if (this.chkF2.Checked)
					{
						text = text + "F2 " + text2 + " or ";
					}
					if (this.chkR4.Checked)
					{
						text = text + "R4 " + text2 + " or ";
					}
					if (this.chkR5.Checked)
					{
						text = text + "R5 " + text2 + " or ";
					}
					if (this.chkR13.Checked)
					{
						text = text + "R13 " + text2 + " or ";
					}
					if (this.chkR11.Checked)
					{
						text = text + "R11 " + text2 + " or ";
					}
				}
				else
				{
					text += this.getFilterStr(this.tempdcl, text2);
				}
				if (text.Length <= 0)
				{
					MessageBox.Show(this, "缺少过滤表达试！请选择过滤列过滤！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					string text3 = "or";
					text = text.Trim().TrimEnd(text3.ToCharArray());
					frmFilter.FilterColumn = text;
					base.Close();
				}
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmFilter.FilterColumn = "";
			base.Close();
		}
		private void frmFilter_Load(object sender, EventArgs e)
		{
			this.txtKeyWord.Focus();
		}
		private void chkAll_CheckedChanged(object sender, EventArgs e)
		{
			foreach (Control control in this.grpNY.Controls)
			{
				if (control is CheckBox)
				{
					CheckBox checkBox = (CheckBox)control;
					checkBox.Checked = this.chkAll.Checked;
				}
			}
		}
		private void frmFilter_Activated(object sender, EventArgs e)
		{
			this.txtKeyWord.Focus();
		}
		private string getFilterStr(GridColumnCollection dcl, string strval)
		{
			string text = "";
			for (int i = 0; i < dcl.Count; i++)
			{
				if (dcl[i].Visible)
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						dcl[i].FieldName,
						" ",
						strval,
						" or "
					});
				}
			}
			return text;
		}
	}
}
