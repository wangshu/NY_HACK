using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmYXCF : Form
	{
		private bool formMove = false;
		private Point formPoint;
		private DataTable tblResult = new DataTable();
		private int intRowNum = 0;
		private int intColNum = 0;
		private IContainer components = null;
		private Label label2;
		private Label label1;
		private ComboBox cboNYLB;
		private Label lblCount;
		private Button btnReset;
		private Panel panelcondition;
		private ComboBox cboHXLB;
		private Button btnSearch;
		private Label label4;
		private ComboBox cboFXFF;
		private Label label3;
		private ComboBox cboZYFS;
		private Label label6;
		private TextBox txtCADJH;
		private Label label5;
		private TextBox txtYXCF;
		private Panel paneldata;
		private Panel panelmenu;
		private GridControl gridControl1;
		private GridView gridView1;
		private GridColumn gridColumn1;
		private GridColumn gridColumn2;
		private GridColumn gridColumn3;
		private GridColumn gridColumn4;
		private GridColumn gridColumn5;
		private GridColumn gridColumn6;
		private GridColumn gridColumn7;
		private GridColumn gridColumn8;
		private GridColumn gridColumn9;
		private GridColumn gridColumn10;
		private GridColumn gridColumn11;
		private UserManu userManu1;
		private Panel paneltop_right;
		private Panel paneltop_middle;
		private Panel paneltop_left;
		private Panel paneltitle_right;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Panel paneltitle_middle;
		private Panel paneltitle_left;
		private Panel panelright;
		private PictureBox pictureBox_right;
		private Panel panel_middle;
		private Label label7;
		private PictureBox pictureBox_left;
		private Panel panelwhite;
		private Panel panelbutton;
		private PictureBox pictureBox_sum;
		private PictureBox pictureBox_view;
		private PictureBox pictureBox_sort;
		private PictureBox pictureBox_filter;
		private Panel paneldatasum;
		private Label labeldatacount;
		public frmYXCF()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem18.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			clsStr clsStr = new clsStr();
			this.Cursor = Cursors.WaitCursor;
			string text = "";
			string[] array = clsStr.Seperate(this.txtYXCF.Text.Replace("%", "[%]"), ' ');
			string text2 = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (!(array[i] == ""))
				{
					if (text2 == "")
					{
						text2 = string.Concat(new string[]
						{
							"E2 like '%",
							array[i],
							"%' or E3 like '%",
							array[i],
							"%' or E4 like '%",
							array[i],
							"%' or E5 like '%",
							array[i],
							"%'"
						});
					}
					else
					{
						string text3 = text2;
						text2 = string.Concat(new string[]
						{
							text3,
							" or E2 like '%",
							array[i],
							"%' or E3 like '%",
							array[i],
							"%' or E4 like '%",
							array[i],
							"%' or E5 like '%",
							array[i],
							"%'"
						});
					}
				}
			}
			if (text2 != "")
			{
				if (text == "")
				{
					text = "(" + text2 + ")";
				}
				else
				{
					text = text + " and (" + text2 + ")";
				}
			}
			if (this.txtCADJH.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "E8 like '%" + this.txtCADJH.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and E8 like '%" + this.txtCADJH.Text.Trim() + "%'";
				}
			}
			if (this.cboHXLB.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "E30 = '" + this.cboHXLB.Text.Trim() + "'";
				}
				else
				{
					text = text + " and E30 = '" + this.cboHXLB.Text.Trim() + "'";
				}
			}
			if (this.cboZYFS.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "E11 like '%" + this.cboZYFS.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and E11 like '%" + this.cboZYFS.Text.Trim() + "%'";
				}
			}
			if (this.cboNYLB.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "E29 = '" + this.cboNYLB.Text.Trim() + "'";
				}
				else
				{
					text = text + " and E29 = '" + this.cboNYLB.Text.Trim() + "'";
				}
			}
			if (this.cboFXFF.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "E10 like '%" + this.cboFXFF.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and E10 like '%" + this.cboFXFF.Text.Trim() + "%'";
				}
			}
			DataRow[] array2 = MDIParent.dsAED.Tables["AED"].Select(text);
			DataTable dataTable = new DataTable();
			dataTable = this.tblResult.Clone();
			for (int i = 0; i < array2.Length; i++)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["E2"] = array2[i]["E2"];
				dataRow["E3"] = array2[i]["E3"];
				dataRow["E4"] = array2[i]["E4"];
				dataRow["E5"] = array2[i]["E5"];
				dataRow["E8"] = array2[i]["E8"];
				dataRow["E29"] = array2[i]["E29"];
				dataRow["E11"] = array2[i]["E11"];
				dataRow["E30"] = array2[i]["E30"];
				dataRow["E13"] = array2[i]["E13"];
				dataRow["E14"] = array2[i]["E14"];
				dataRow["E10"] = array2[i]["E10"];
				dataTable.Rows.Add(dataRow);
			}
			this.tblResult = dataTable.Copy();
			DataView dataSource = new DataView(this.tblResult);
			this.gridControl1.DataSource = dataSource;
			this.Cursor = Cursors.Default;
			if (this.tblResult.Rows.Count == 0)
			{
				MessageBox.Show(this, "查询不到相关数据！\r\n请您重新输入简单正确条件后继续查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtYXCF.Focus();
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.txtYXCF.Text = "";
			this.txtCADJH.Text = "";
			this.cboHXLB.Text = "";
			this.cboZYFS.Text = "";
			this.cboNYLB.Text = "";
			this.cboFXFF.Text = "";
			this.txtYXCF.Focus();
		}
		private void SetHeaders()
		{
			this.tblResult.Columns.Add("E2");
			this.tblResult.Columns.Add("E3");
			this.tblResult.Columns.Add("E4");
			this.tblResult.Columns.Add("E5");
			this.tblResult.Columns.Add("E8");
			this.tblResult.Columns.Add("E29");
			this.tblResult.Columns.Add("E11");
			this.tblResult.Columns.Add("E30");
			this.tblResult.Columns.Add("E13");
			this.tblResult.Columns.Add("E14");
			this.tblResult.Columns.Add("E10");
		}
		private void SetGridControl()
		{
			this.gridControl1.UseEmbeddedNavigator = true;
			this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ColumnAutoWidth = false;
			this.gridView1.OptionsView.EnableAppearanceOddRow = true;
			this.gridView1.Appearance.OddRow.BackColor = Color.FromArgb(255, 255, 255);
			this.gridView1.Appearance.HeaderPanel.Font = new Font("宋体", 10.5f);
			this.gridView1.Appearance.Row.Font = new Font("宋体", 10.5f);
			this.gridView1.IndicatorWidth = 50;
			this.gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(248, 240, 230);
			this.gridView1.Columns[0].Caption = "中文名称";
			this.gridView1.Columns[0].FieldName = "E2";
			this.gridView1.Columns[0].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[0].AppearanceCell.Font = new Font("宋体", 10.5f, FontStyle.Underline);
			this.gridView1.Columns[0].AppearanceCell.ForeColor = Color.Blue;
			this.gridView1.Columns[0].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[0].Width = 210;
			this.gridView1.Columns[0].Visible = true;
			this.gridView1.Columns[1].Caption = "英文名称";
			this.gridView1.Columns[1].FieldName = "E3";
			this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[1].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[1].Width = 210;
			this.gridView1.Columns[2].Caption = "中文别名";
			this.gridView1.Columns[2].FieldName = "E4";
			this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[2].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[2].Width = 150;
			this.gridView1.Columns[3].Caption = "英文别名";
			this.gridView1.Columns[3].FieldName = "E5";
			this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[3].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[3].Width = 150;
			this.gridView1.Columns[4].Caption = "CA登记号";
			this.gridView1.Columns[4].FieldName = "E8";
			this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[4].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[4].Width = 150;
			this.gridView1.Columns[5].Caption = "农药类别";
			this.gridView1.Columns[5].FieldName = "E29";
			this.gridView1.Columns[5].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[5].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[5].Width = 150;
			this.gridView1.Columns[6].Caption = "作用方式";
			this.gridView1.Columns[6].FieldName = "E11";
			this.gridView1.Columns[6].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[6].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[6].Width = 150;
			this.gridView1.Columns[7].Caption = "化学类别";
			this.gridView1.Columns[7].FieldName = "E30";
			this.gridView1.Columns[7].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[7].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[7].Width = 150;
			this.gridView1.Columns[8].Caption = "急性经口LD50";
			this.gridView1.Columns[8].FieldName = "E13";
			this.gridView1.Columns[8].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[8].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[8].Width = 200;
			this.gridView1.Columns[9].Caption = "急性经皮LD50";
			this.gridView1.Columns[9].FieldName = "E14";
			this.gridView1.Columns[9].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[9].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[9].Width = 200;
			this.gridView1.Columns[10].Caption = "分析方法";
			this.gridView1.Columns[10].FieldName = "E10";
			this.gridView1.Columns[10].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[10].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[10].Width = 150;
		}
		private void frmYXCF_Load(object sender, EventArgs e)
		{
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.txtYXCF.Focus();
		}
		private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
		{
			if (e.Column.FieldName.ToUpper() == "E2")
			{
				frmYXCFDetail frmYXCFDetail = new frmYXCFDetail(e.CellValue.ToString(), this.gridView1.GetRowCellValue(e.RowHandle, "E3").ToString());
				frmYXCFDetail.ShowDialog();
			}
		}
		private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
		{
			if (e.Info.IsRowIndicator && e.RowHandle >= 0)
			{
				e.Info.DisplayText = (e.RowHandle + 1).ToString();
			}
		}
		private void paneltitle_middle_MouseDown(object sender, MouseEventArgs e)
		{
			this.formPoint = default(Point);
			if (e.Button == MouseButtons.Left)
			{
				int x = -e.X - SystemInformation.FrameBorderSize.Width;
				int y = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
				this.formPoint = new Point(x, y);
				this.formMove = true;
			}
		}
		private void paneltitle_middle_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.formMove)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.formPoint.X, this.formPoint.Y);
				base.Location = mousePosition;
			}
		}
		private void paneltitle_middle_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.formMove = false;
			}
		}
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\exit_enter.png");
		}
		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\exit_leave.png");
		}
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\max_enter.png");
		}
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\max_leave.png");
		}
		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\images\\min_enter.png");
		}
		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\images\\min_leave.png");
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Maximized)
			{
				base.WindowState = FormWindowState.Normal;
			}
			else
			{
				if (base.WindowState == FormWindowState.Normal)
				{
					base.WindowState = FormWindowState.Maximized;
				}
			}
		}
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Maximized || base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Minimized;
			}
			else
			{
				if (base.WindowState == FormWindowState.Minimized)
				{
					base.WindowState = FormWindowState.Normal;
				}
			}
		}
		private void gridView1_RowCountChanged(object sender, EventArgs e)
		{
			this.labeldatacount.Text = "记录数合计：" + this.gridView1.RowCount.ToString() + "个。";
		}
		private void pictureBox_filter_Click(object sender, EventArgs e)
		{
			if (this.gridView1.RowCount > 0)
			{
				frmFilter frmFilter = new frmFilter(this.gridView1.Columns);
				frmFilter.ShowDialog();
				clsMe clsMe = new clsMe();
				if (frmFilter.FilterColumn.Length > 0)
				{
					clsMe.FilterView(this.gridControl1, frmFilter.FilterColumn);
				}
			}
			else
			{
				MessageBox.Show(this, "请您先查询数据后再过滤！", "提示", MessageBoxButtons.OK);
			}
		}
		private void pictureBox_sort_Click(object sender, EventArgs e)
		{
			if (this.gridView1.RowCount > 0)
			{
				frmSort frmSort = new frmSort(this.gridView1.Columns);
				frmSort.ShowDialog();
				clsMe clsMe = new clsMe();
				if (frmSort.SortColumn.Length > 0)
				{
					clsMe.SortView(this.gridControl1, frmSort.SortColumn);
				}
			}
			else
			{
				MessageBox.Show(this, "请您先查询数据后再排序！", "提示", MessageBoxButtons.OK);
			}
		}
		private void pictureBox_view_Click(object sender, EventArgs e)
		{
			if (this.gridView1.RowCount > 0)
			{
				frmView frmView = new frmView(this.gridView1.Columns);
				frmView.ShowDialog();
				clsMe clsMe = new clsMe();
				clsMe.ViewGrid(this.gridView1, frmView.listbox);
			}
			else
			{
				MessageBox.Show(this, "请您先查询数据后再视图显示！", "提示", MessageBoxButtons.OK);
			}
		}
		private void frmYXCF_Resize(object sender, EventArgs e)
		{
			this.userManu1.navBarControl1.Height = this.panelmenu.Height - 2;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmYXCF));
			this.label2 = new Label();
			this.label1 = new Label();
			this.cboNYLB = new ComboBox();
			this.lblCount = new Label();
			this.btnReset = new Button();
			this.panelcondition = new Panel();
			this.label6 = new Label();
			this.txtCADJH = new TextBox();
			this.btnSearch = new Button();
			this.label5 = new Label();
			this.txtYXCF = new TextBox();
			this.label4 = new Label();
			this.cboFXFF = new ComboBox();
			this.label3 = new Label();
			this.cboZYFS = new ComboBox();
			this.cboHXLB = new ComboBox();
			this.paneldata = new Panel();
			this.gridControl1 = new GridControl();
			this.gridView1 = new GridView();
			this.gridColumn1 = new GridColumn();
			this.gridColumn2 = new GridColumn();
			this.gridColumn3 = new GridColumn();
			this.gridColumn4 = new GridColumn();
			this.gridColumn5 = new GridColumn();
			this.gridColumn6 = new GridColumn();
			this.gridColumn7 = new GridColumn();
			this.gridColumn8 = new GridColumn();
			this.gridColumn9 = new GridColumn();
			this.gridColumn10 = new GridColumn();
			this.gridColumn11 = new GridColumn();
			this.panelmenu = new Panel();
			this.userManu1 = new UserManu();
			this.paneltop_right = new Panel();
			this.paneltop_middle = new Panel();
			this.paneltop_left = new Panel();
			this.paneltitle_right = new Panel();
			this.pictureBox3 = new PictureBox();
			this.pictureBox2 = new PictureBox();
			this.pictureBox1 = new PictureBox();
			this.paneltitle_middle = new Panel();
			this.paneltitle_left = new Panel();
			this.panelright = new Panel();
			this.panelwhite = new Panel();
			this.panelbutton = new Panel();
			this.pictureBox_sum = new PictureBox();
			this.pictureBox_view = new PictureBox();
			this.pictureBox_sort = new PictureBox();
			this.pictureBox_filter = new PictureBox();
			this.paneldatasum = new Panel();
			this.labeldatacount = new Label();
			this.pictureBox_right = new PictureBox();
			this.panel_middle = new Panel();
			this.label7 = new Label();
			this.pictureBox_left = new PictureBox();
			this.panelcondition.SuspendLayout();
			this.paneldata.SuspendLayout();
			((ISupportInitialize)this.gridControl1).BeginInit();
			((ISupportInitialize)this.gridView1).BeginInit();
			this.panelmenu.SuspendLayout();
			this.paneltitle_right.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panelright.SuspendLayout();
			this.panelwhite.SuspendLayout();
			this.panelbutton.SuspendLayout();
			((ISupportInitialize)this.pictureBox_sum).BeginInit();
			((ISupportInitialize)this.pictureBox_view).BeginInit();
			((ISupportInitialize)this.pictureBox_sort).BeginInit();
			((ISupportInitialize)this.pictureBox_filter).BeginInit();
			this.paneldatasum.SuspendLayout();
			((ISupportInitialize)this.pictureBox_right).BeginInit();
			this.panel_middle.SuspendLayout();
			((ISupportInitialize)this.pictureBox_left).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label2.Location = new Point(440, 14);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 14);
			this.label2.TabIndex = 18;
			this.label2.Text = "化学类别";
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(254, 50);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 17;
			this.label1.Text = "农药类别";
			this.cboNYLB.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboNYLB.FormattingEnabled = true;
			this.cboNYLB.Items.AddRange(new object[]
			{
				"杀菌剂/杀虫剂",
				"杀虫剂/杀菌剂",
				"杀虫剂/杀螨剂/杀菌剂",
				"杀菌剂/植物生长调节剂",
				"昆虫调节剂",
				"杀线虫剂/杀菌剂",
				"昆虫引诱剂",
				"植物抗性诱导剂",
				"杀螨剂",
				"杀螨剂/杀菌剂",
				"杀螨剂/杀虫剂",
				"杀藻剂",
				"杀鸟剂",
				"熏蒸剂",
				"杀菌剂",
				"除草剂",
				"除草剂/植物生长调节剂",
				"昆虫生长调节剂",
				"杀虫剂",
				"杀虫剂/杀螨剂",
				"杀虫剂/杀线虫剂",
				"杀虫剂/卫生杀虫剂",
				"杀螺剂",
				"杀软体动物剂",
				"杀线虫剂",
				"其它",
				"植物生长调节剂",
				"卫生杀虫剂",
				"忌避剂",
				"杀鼠剂",
				"增效剂"
			});
			this.cboNYLB.Location = new Point(317, 46);
			this.cboNYLB.Name = "cboNYLB";
			this.cboNYLB.Size = new Size(118, 22);
			this.cboNYLB.TabIndex = 8;
			this.lblCount.AutoSize = true;
			this.lblCount.BackColor = Color.Transparent;
			this.lblCount.Location = new Point(211, 58);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new Size(0, 14);
			this.lblCount.TabIndex = 14;
			this.btnReset.Location = new Point(71, 88);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(50, 23);
			this.btnReset.TabIndex = 29;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.label6);
			this.panelcondition.Controls.Add(this.txtCADJH);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.label5);
			this.panelcondition.Controls.Add(this.txtYXCF);
			this.panelcondition.Controls.Add(this.label4);
			this.panelcondition.Controls.Add(this.cboFXFF);
			this.panelcondition.Controls.Add(this.label3);
			this.panelcondition.Controls.Add(this.cboZYFS);
			this.panelcondition.Controls.Add(this.label2);
			this.panelcondition.Controls.Add(this.label1);
			this.panelcondition.Controls.Add(this.cboHXLB);
			this.panelcondition.Controls.Add(this.lblCount);
			this.panelcondition.Controls.Add(this.cboNYLB);
			this.panelcondition.Location = new Point(3, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(573, 117);
			this.panelcondition.TabIndex = 27;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label6.Location = new Point(254, 14);
			this.label6.Name = "label6";
			this.label6.Size = new Size(63, 14);
			this.label6.TabIndex = 26;
			this.label6.Text = "CA登记号";
			this.txtCADJH.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtCADJH.Location = new Point(317, 10);
			this.txtCADJH.Name = "txtCADJH";
			this.txtCADJH.Size = new Size(118, 23);
			this.txtCADJH.TabIndex = 25;
			this.btnSearch.Location = new Point(15, 88);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(50, 23);
			this.btnSearch.TabIndex = 28;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Transparent;
			this.label5.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label5.Location = new Point(2, 14);
			this.label5.Name = "label5";
			this.label5.Size = new Size(63, 14);
			this.label5.TabIndex = 24;
			this.label5.Text = "有效成分";
			this.txtYXCF.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtYXCF.ImeMode = ImeMode.On;
			this.txtYXCF.Location = new Point(65, 10);
			this.txtYXCF.Name = "txtYXCF";
			this.txtYXCF.Size = new Size(183, 23);
			this.txtYXCF.TabIndex = 23;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label4.Location = new Point(440, 50);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 14);
			this.label4.TabIndex = 22;
			this.label4.Text = "分析方法";
			this.cboFXFF.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboFXFF.FormattingEnabled = true;
			this.cboFXFF.Items.AddRange(new object[]
			{
				"薄层色谱法",
				"化学法",
				"气-液相色谱",
				"气谱法",
				"气相色谱",
				"生物测定法",
				"液谱法",
				"液相色谱",
				"紫外分光光度法"
			});
			this.cboFXFF.Location = new Point(503, 46);
			this.cboFXFF.Name = "cboFXFF";
			this.cboFXFF.Size = new Size(118, 22);
			this.cboFXFF.TabIndex = 21;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label3.Location = new Point(2, 50);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 14);
			this.label3.TabIndex = 20;
			this.label3.Text = "作用方式";
			this.cboZYFS.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboZYFS.FormattingEnabled = true;
			this.cboZYFS.Items.AddRange(new object[]
			{
				"保护",
				"铲除",
				"触杀",
				"调节生长",
				"抗凝血",
				"内吸",
				"胃毒",
				"治疗"
			});
			this.cboZYFS.Location = new Point(65, 46);
			this.cboZYFS.Name = "cboZYFS";
			this.cboZYFS.Size = new Size(183, 22);
			this.cboZYFS.TabIndex = 19;
			this.cboHXLB.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboHXLB.FormattingEnabled = true;
			this.cboHXLB.Items.AddRange(new object[]
			{
				"N-邻苯二酰苯胺",
				"氨基甲酸酯",
				"苯并咪唑",
				"苯酚",
				"苯基吡唑",
				"苯基羧酸",
				"苯甲酰胺",
				"苯甲酰脲",
				"苯醚类",
				"苯氧羧酸",
				"苯酰胺",
				"苯酰脲",
				"丁酮",
				"丁香油",
				"二苯醚",
				"二硝基",
				"二硝基苯胺",
				"二嗪",
				"二羧甲酰亚胺",
				"核苷",
				"环己烷",
				"环己烯酮",
				"磺酰氨基苯甲酰甲酯",
				"磺酰脲",
				"激素类",
				"季胺盐",
				"甲基环丙烯",
				"甲脒",
				"聚合体",
				"硫代氨基甲酸酯",
				"硫脲",
				"氯代乙酰胺",
				"吗啉",
				"拟除虫菊酯",
				"其它",
				"三嗪",
				"沙蚕毒",
				"生物源",
				"天然化合物",
				"微生物源",
				"无机",
				"香豆素",
				"硝基苯",
				"有机氮",
				"有机汞",
				"有机含卤",
				"有机磷",
				"有机硫",
				"有机氯",
				"有机醚",
				"有机铜",
				"有机锡",
				"有机胂",
				"杂环化合物",
				"植物源",
				"苄基醚",
				"茚酮",
				"吡唑",
				"吡啶",
				"哒嗪酮",
				"哌啶",
				"咪唑啉酮",
				"唑类",
				"嘧啶",
				"脲类",
				"羧酸脂",
				"酰胺",
				"酰苯胺",
				"酰基丙氨酸"
			});
			this.cboHXLB.Location = new Point(503, 10);
			this.cboHXLB.Name = "cboHXLB";
			this.cboHXLB.Size = new Size(118, 22);
			this.cboHXLB.TabIndex = 16;
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(12, 188);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(221, 111);
			this.paneldata.TabIndex = 36;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(221, 111);
			this.gridControl1.TabIndex = 27;
			this.gridControl1.ViewCollection.AddRange(new BaseView[]
			{
				this.gridView1
			});
			this.gridView1.Columns.AddRange(new GridColumn[]
			{
				this.gridColumn1,
				this.gridColumn2,
				this.gridColumn3,
				this.gridColumn4,
				this.gridColumn5,
				this.gridColumn6,
				this.gridColumn7,
				this.gridColumn8,
				this.gridColumn9,
				this.gridColumn10,
				this.gridColumn11
			});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
			this.gridView1.RowCountChanged += new EventHandler(this.gridView1_RowCountChanged);
			this.gridView1.RowCellClick += new RowCellClickEventHandler(this.gridView1_RowCellClick);
			this.gridColumn1.Caption = "gridColumn1";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn2.Caption = "gridColumn2";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn3.Caption = "gridColumn3";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn4.Caption = "gridColumn4";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			this.gridColumn5.Caption = "gridColumn5";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 4;
			this.gridColumn6.Caption = "gridColumn6";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 5;
			this.gridColumn7.Caption = "gridColumn7";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 6;
			this.gridColumn8.Caption = "gridColumn8";
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 7;
			this.gridColumn9.Caption = "gridColumn9";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 8;
			this.gridColumn10.Caption = "gridColumn10";
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.Visible = true;
			this.gridColumn10.VisibleIndex = 9;
			this.gridColumn11.Caption = "gridColumn11";
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.Visible = true;
			this.gridColumn11.VisibleIndex = 10;
			this.panelmenu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panelmenu.Controls.Add(this.userManu1);
			this.panelmenu.Location = new Point(2, 117);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(176, 448);
			this.panelmenu.TabIndex = 38;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(176, 448);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(373, 36);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(407, 25);
			this.paneltop_right.TabIndex = 44;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(197, 32);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(165, 29);
			this.paneltop_middle.TabIndex = 43;
			this.paneltop_left.Location = new Point(14, 32);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 42;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(543, 3);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(237, 25);
			this.paneltitle_right.TabIndex = 41;
			this.pictureBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(170, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(21, 21);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 23;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.MouseLeave += new EventHandler(this.pictureBox3_MouseLeave);
			this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
			this.pictureBox3.MouseEnter += new EventHandler(this.pictureBox3_MouseEnter);
			this.pictureBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(192, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(21, 21);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 22;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseLeave += new EventHandler(this.pictureBox2_MouseLeave);
			this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
			this.pictureBox2.MouseEnter += new EventHandler(this.pictureBox2_MouseEnter);
			this.pictureBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(214, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(21, 21);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox1_MouseLeave);
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox1_MouseEnter);
			this.paneltitle_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltitle_middle.Location = new Point(266, 3);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(280, 25);
			this.paneltitle_middle.TabIndex = 40;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(2, 3);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 39;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(197, 76);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(581, 478);
			this.panelright.TabIndex = 45;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(8, 160);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(568, 315);
			this.panelwhite.TabIndex = 40;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(4, 37);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(547, 40);
			this.panelbutton.TabIndex = 38;
			this.pictureBox_sum.BackColor = Color.Transparent;
			this.pictureBox_sum.Cursor = Cursors.Hand;
			this.pictureBox_sum.Location = new Point(352, 9);
			this.pictureBox_sum.Name = "pictureBox_sum";
			this.pictureBox_sum.Size = new Size(65, 24);
			this.pictureBox_sum.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_sum.TabIndex = 3;
			this.pictureBox_sum.TabStop = false;
			this.pictureBox_sum.Visible = false;
			this.pictureBox_view.BackColor = Color.Transparent;
			this.pictureBox_view.Cursor = Cursors.Hand;
			this.pictureBox_view.Location = new Point(253, 9);
			this.pictureBox_view.Name = "pictureBox_view";
			this.pictureBox_view.Size = new Size(65, 24);
			this.pictureBox_view.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_view.TabIndex = 2;
			this.pictureBox_view.TabStop = false;
			this.pictureBox_view.Click += new EventHandler(this.pictureBox_view_Click);
			this.pictureBox_sort.BackColor = Color.Transparent;
			this.pictureBox_sort.Cursor = Cursors.Hand;
			this.pictureBox_sort.Location = new Point(154, 9);
			this.pictureBox_sort.Name = "pictureBox_sort";
			this.pictureBox_sort.Size = new Size(65, 24);
			this.pictureBox_sort.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_sort.TabIndex = 1;
			this.pictureBox_sort.TabStop = false;
			this.pictureBox_sort.Click += new EventHandler(this.pictureBox_sort_Click);
			this.pictureBox_filter.BackColor = Color.Transparent;
			this.pictureBox_filter.Cursor = Cursors.Hand;
			this.pictureBox_filter.Location = new Point(55, 9);
			this.pictureBox_filter.Name = "pictureBox_filter";
			this.pictureBox_filter.Size = new Size(65, 24);
			this.pictureBox_filter.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_filter.TabIndex = 0;
			this.pictureBox_filter.TabStop = false;
			this.pictureBox_filter.Click += new EventHandler(this.pictureBox_filter_Click);
			this.paneldatasum.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldatasum.Controls.Add(this.labeldatacount);
			this.paneldatasum.Location = new Point(4, 3);
			this.paneldatasum.Name = "paneldatasum";
			this.paneldatasum.Size = new Size(547, 28);
			this.paneldatasum.TabIndex = 37;
			this.labeldatacount.BackColor = Color.Transparent;
			this.labeldatacount.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.labeldatacount.Location = new Point(41, 8);
			this.labeldatacount.Name = "labeldatacount";
			this.labeldatacount.Size = new Size(253, 14);
			this.labeldatacount.TabIndex = 0;
			this.pictureBox_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox_right.Location = new Point(538, 3);
			this.pictureBox_right.Name = "pictureBox_right";
			this.pictureBox_right.Size = new Size(38, 28);
			this.pictureBox_right.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_right.TabIndex = 39;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label7);
			this.panel_middle.Location = new Point(69, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(328, 28);
			this.panel_middle.TabIndex = 38;
			this.label7.BackColor = Color.Transparent;
			this.label7.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label7.Location = new Point(41, 7);
			this.label7.Name = "label7";
			this.label7.Size = new Size(253, 14);
			this.label7.TabIndex = 1;
			this.label7.Text = "有效成分查询";
			this.pictureBox_left.Location = new Point(0, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 37;
			this.pictureBox_left.TabStop = false;
			base.AcceptButton = this.btnSearch;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(792, 566);
			base.Controls.Add(this.panelright);
			base.Controls.Add(this.paneltop_right);
			base.Controls.Add(this.paneltop_middle);
			base.Controls.Add(this.paneltop_left);
			base.Controls.Add(this.paneltitle_right);
			base.Controls.Add(this.paneltitle_middle);
			base.Controls.Add(this.paneltitle_left);
			base.Controls.Add(this.panelmenu);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmYXCF";
			this.Text = "有效成分查询与名称互检";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frmYXCF_Load);
			base.Resize += new EventHandler(this.frmYXCF_Resize);
			this.panelcondition.ResumeLayout(false);
			this.panelcondition.PerformLayout();
			this.paneldata.ResumeLayout(false);
			((ISupportInitialize)this.gridControl1).EndInit();
			((ISupportInitialize)this.gridView1).EndInit();
			this.panelmenu.ResumeLayout(false);
			this.paneltitle_right.ResumeLayout(false);
			this.paneltitle_right.PerformLayout();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panelright.ResumeLayout(false);
			this.panelright.PerformLayout();
			this.panelwhite.ResumeLayout(false);
			this.panelbutton.ResumeLayout(false);
			this.panelbutton.PerformLayout();
			((ISupportInitialize)this.pictureBox_sum).EndInit();
			((ISupportInitialize)this.pictureBox_view).EndInit();
			((ISupportInitialize)this.pictureBox_sort).EndInit();
			((ISupportInitialize)this.pictureBox_filter).EndInit();
			this.paneldatasum.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox_right).EndInit();
			this.panel_middle.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox_left).EndInit();
			base.ResumeLayout(false);
		}
	}
}
