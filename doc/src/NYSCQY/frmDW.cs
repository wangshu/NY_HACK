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
	public class frmDW : Form
	{
		private bool formMove = false;
		private Point formPoint;
		private DataTable tblResult = new DataTable();
		private int intRowNum = 0;
		private int intColNum = 0;
		private IContainer components = null;
		private Label lblCount;
		private ComboBox cboDWLB;
		private Label label5;
		private ComboBox cboCountry;
		private Label label4;
		private Label label3;
		private TextBox txtCounty;
		private Label label2;
		private TextBox txtCity;
		private Label label1;
		private Button btnReset;
		private Button btnSearch;
		private Panel panelcondition;
		private TextBox txtDWMC;
		private Label label6;
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
		private GridColumn gridColumn12;
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
		private ComboBox cboProvince;
		public frmDW()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem15.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			string text = "";
			if (this.cboDWLB.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "F8='" + this.cboDWLB.Text.Trim() + "'";
				}
				else
				{
					text = text + " and F8='" + this.cboDWLB.Text.Trim() + "'";
				}
			}
			if (this.cboCountry.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "F3='" + this.cboCountry.Text.Trim() + "'";
				}
				else
				{
					text = text + " and F3='" + this.cboCountry.Text.Trim() + "'";
				}
			}
			if (this.cboProvince.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "F4='" + this.cboProvince.Text.Trim() + "'";
				}
				else
				{
					text = text + " and F4='" + this.cboProvince.Text.Trim() + "'";
				}
			}
			if (this.txtCity.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "F5 like '%" + this.txtCity.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and F5 like'%" + this.txtCity.Text.Trim() + "%'";
				}
			}
			if (this.txtCounty.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "F6 like'%" + this.txtCounty.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and F6 like'%" + this.txtCounty.Text.Trim() + "%'";
				}
			}
			if (this.txtDWMC.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "F2 like'%" + this.txtDWMC.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and F2 like'%" + this.txtDWMC.Text.Trim() + "%'";
				}
			}
			DataRow[] array = MDIParent.dsF.Tables["F"].Select(text, "F2");
			DataTable dataTable = new DataTable();
			dataTable = this.tblResult.Clone();
			for (int i = 0; i < array.Length; i++)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["F2"] = array[i]["F2"];
				dataRow["F3"] = array[i]["F3"];
				dataRow["F4"] = array[i]["F4"];
				dataRow["F5"] = array[i]["F5"];
				dataRow["F6"] = array[i]["F6"];
				dataRow["F7"] = array[i]["F7"];
				dataRow["F8"] = array[i]["F8"];
				dataRow["F9"] = array[i]["F9"];
				dataRow["F10"] = array[i]["F10"];
				dataRow["F11"] = array[i]["F11"];
				dataRow["F12"] = array[i]["F12"];
				dataRow["F14"] = array[i]["F14"];
				dataTable.Rows.Add(dataRow);
			}
			this.tblResult = dataTable.Copy();
			DataView dataSource = new DataView(this.tblResult);
			this.gridControl1.DataSource = dataSource;
			this.Cursor = Cursors.Default;
			if (this.tblResult.Rows.Count == 0)
			{
				MessageBox.Show(this, "查询不到相关数据,可能由以下原因造成：\r\n1、您输入的条件太多,过于复杂；\r\n2、该厂家或已更改名称；\r\n3、不存在该厂家；\r\n请您重新输入简单正确条件后继续查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtDWMC.Focus();
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.cboDWLB.Text = "";
			this.cboCountry.Text = "";
			this.cboProvince.Text = "";
			this.txtCity.Text = "";
			this.txtCounty.Text = "";
			this.txtDWMC.Text = "";
			this.txtDWMC.Focus();
		}
		private void SetHeaders()
		{
			this.tblResult.Columns.Add("F2");
			this.tblResult.Columns.Add("F8");
			this.tblResult.Columns.Add("F3");
			this.tblResult.Columns.Add("F4");
			this.tblResult.Columns.Add("F5");
			this.tblResult.Columns.Add("F6");
			this.tblResult.Columns.Add("F7");
			this.tblResult.Columns.Add("F11");
			this.tblResult.Columns.Add("F9");
			this.tblResult.Columns.Add("F10");
			this.tblResult.Columns.Add("F14");
			this.tblResult.Columns.Add("F12");
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
			this.gridView1.Columns[0].Caption = "单位名称";
			this.gridView1.Columns[0].FieldName = "F2";
			this.gridView1.Columns[0].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[0].AppearanceCell.Font = new Font("宋体", 10.5f, FontStyle.Underline);
			this.gridView1.Columns[0].AppearanceCell.ForeColor = Color.Blue;
			this.gridView1.Columns[0].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[0].Width = 300;
			this.gridView1.Columns[0].Visible = true;
			this.gridView1.Columns[1].Caption = "类别";
			this.gridView1.Columns[1].FieldName = "F8";
			this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[1].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[1].Width = 80;
			this.gridView1.Columns[2].Caption = "国家";
			this.gridView1.Columns[2].FieldName = "F3";
			this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[2].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[2].Width = 80;
			this.gridView1.Columns[3].Caption = "省份";
			this.gridView1.Columns[3].FieldName = "F4";
			this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[3].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[3].Width = 80;
			this.gridView1.Columns[4].Caption = "城市";
			this.gridView1.Columns[4].FieldName = "F5";
			this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[4].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[4].Width = 80;
			this.gridView1.Columns[5].Caption = "县";
			this.gridView1.Columns[5].FieldName = "F6";
			this.gridView1.Columns[5].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[5].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[5].Width = 80;
			this.gridView1.Columns[6].Caption = "乡镇街道";
			this.gridView1.Columns[6].FieldName = "F7";
			this.gridView1.Columns[6].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[6].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[6].Width = 250;
			this.gridView1.Columns[7].Caption = "邮政编码";
			this.gridView1.Columns[7].FieldName = "F11";
			this.gridView1.Columns[7].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[7].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[7].Width = 120;
			this.gridView1.Columns[8].Caption = "电话";
			this.gridView1.Columns[8].FieldName = "F9";
			this.gridView1.Columns[8].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[8].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[8].Width = 160;
			this.gridView1.Columns[9].Caption = "传真";
			this.gridView1.Columns[9].FieldName = "F10";
			this.gridView1.Columns[9].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[9].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[9].Width = 160;
			this.gridView1.Columns[10].Caption = "联系人";
			this.gridView1.Columns[10].FieldName = "F14";
			this.gridView1.Columns[10].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[10].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[10].Width = 160;
			this.gridView1.Columns[11].Caption = "邮箱";
			this.gridView1.Columns[11].FieldName = "F12";
			this.gridView1.Columns[11].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[11].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[11].Width = 160;
		}
		private void frwDW_Load(object sender, EventArgs e)
		{
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.txtDWMC.Focus();
		}
		private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
		{
			if (e.Info.IsRowIndicator && e.RowHandle >= 0)
			{
				e.Info.DisplayText = (e.RowHandle + 1).ToString();
			}
		}
		private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
		{
			if (e.Column.FieldName.ToUpper() == "F2")
			{
				frmQYDetail frmQYDetail = new frmQYDetail(e.CellValue.ToString(), "", "");
				frmQYDetail.ShowDialog();
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
		private void frmDW_Resize(object sender, EventArgs e)
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmDW));
			this.lblCount = new Label();
			this.cboDWLB = new ComboBox();
			this.label5 = new Label();
			this.cboCountry = new ComboBox();
			this.label4 = new Label();
			this.label3 = new Label();
			this.txtCounty = new TextBox();
			this.label2 = new Label();
			this.txtCity = new TextBox();
			this.label1 = new Label();
			this.btnReset = new Button();
			this.btnSearch = new Button();
			this.panelcondition = new Panel();
			this.cboProvince = new ComboBox();
			this.label6 = new Label();
			this.txtDWMC = new TextBox();
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
			this.gridColumn12 = new GridColumn();
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
			this.lblCount.AutoSize = true;
			this.lblCount.BackColor = Color.Transparent;
			this.lblCount.Location = new Point(320, 58);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new Size(0, 14);
			this.lblCount.TabIndex = 14;
			this.cboDWLB.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboDWLB.FormattingEnabled = true;
			this.cboDWLB.Items.AddRange(new object[]
			{
				"管理",
				"科研",
				"推广",
				"销售",
				"贸易",
				"其他",
				"卫生杀虫剂试验",
				"植调剂试验",
				"杀鼠剂试验",
				"杀菌剂试验",
				"杀虫剂试验",
				"除草剂试验",
				"除草/植调试验"
			});
			this.cboDWLB.Location = new Point(66, 12);
			this.cboDWLB.Name = "cboDWLB";
			this.cboDWLB.Size = new Size(96, 22);
			this.cboDWLB.TabIndex = 13;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Transparent;
			this.label5.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label5.Location = new Point(3, 16);
			this.label5.Name = "label5";
			this.label5.Size = new Size(63, 14);
			this.label5.TabIndex = 12;
			this.label5.Text = "单位类别";
			this.cboCountry.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboCountry.FormattingEnabled = true;
			this.cboCountry.Items.AddRange(new object[]
			{
				"中国",
				"奥地利",
				"澳大利亚",
				"保加利亚",
				"比利时",
				"波兰",
				"德国",
				"俄罗斯",
				"法国",
				"芬兰",
				"哥伦比亚",
				"古巴",
				"韩国",
				"荷兰",
				"加拿大",
				"捷克斯洛伐克",
				"肯尼亚",
				"马来西亚",
				"美国",
				"墨西哥",
				"葡萄牙",
				"日本",
				"瑞士",
				"斯洛伐克",
				"斯洛文尼亚",
				"泰国",
				"乌克兰",
				"西班牙",
				"新加坡",
				"新西兰",
				"匈牙利",
				"以色列",
				"意大利",
				"印度",
				"英国"
			});
			this.cboCountry.Location = new Point(197, 12);
			this.cboCountry.Name = "cboCountry";
			this.cboCountry.Size = new Size(108, 22);
			this.cboCountry.TabIndex = 8;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label4.Location = new Point(165, 16);
			this.label4.Name = "label4";
			this.label4.Size = new Size(35, 14);
			this.label4.TabIndex = 7;
			this.label4.Text = "国家";
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label3.Location = new Point(575, 16);
			this.label3.Name = "label3";
			this.label3.Size = new Size(21, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "县";
			this.txtCounty.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtCounty.Location = new Point(596, 12);
			this.txtCounty.Name = "txtCounty";
			this.txtCounty.Size = new Size(96, 23);
			this.txtCounty.TabIndex = 5;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label2.Location = new Point(453, 16);
			this.label2.Name = "label2";
			this.label2.Size = new Size(21, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "市";
			this.txtCity.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtCity.Location = new Point(476, 12);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new Size(96, 23);
			this.txtCity.TabIndex = 3;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(3, 52);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "单位名称";
			this.btnReset.Location = new Point(81, 82);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(45, 23);
			this.btnReset.TabIndex = 21;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.btnSearch.Location = new Point(21, 82);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(45, 23);
			this.btnSearch.TabIndex = 20;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.cboProvince);
			this.panelcondition.Controls.Add(this.label6);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.lblCount);
			this.panelcondition.Controls.Add(this.cboDWLB);
			this.panelcondition.Controls.Add(this.label5);
			this.panelcondition.Controls.Add(this.cboCountry);
			this.panelcondition.Controls.Add(this.label4);
			this.panelcondition.Controls.Add(this.label3);
			this.panelcondition.Controls.Add(this.txtCounty);
			this.panelcondition.Controls.Add(this.label2);
			this.panelcondition.Controls.Add(this.txtCity);
			this.panelcondition.Controls.Add(this.label1);
			this.panelcondition.Controls.Add(this.txtDWMC);
			this.panelcondition.Location = new Point(3, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(712, 112);
			this.panelcondition.TabIndex = 19;
			this.cboProvince.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboProvince.FormattingEnabled = true;
			this.cboProvince.Items.AddRange(new object[]
			{
				"安徽省",
				"北京市",
				"福建省",
				"甘肃省",
				"广东省",
				"广西壮族自治区",
				"贵州省",
				"国外",
				"海南省",
				"河北省",
				"河南省",
				"黑龙江省",
				"湖北省",
				"湖南省",
				"吉林省",
				"江苏省",
				"江西省",
				"辽宁省",
				"内蒙古自治区",
				"宁夏回族自治区",
				"青海省",
				"山东省",
				"山西省",
				"陕西省",
				"上海市",
				"四川省",
				"台湾省",
				"天津市",
				"西藏自治区",
				"香港",
				"新疆区",
				"新疆维吾尔自治区",
				"云南省",
				"浙江省",
				"重庆市"
			});
			this.cboProvince.Location = new Point(328, 12);
			this.cboProvince.Name = "cboProvince";
			this.cboProvince.Size = new Size(124, 22);
			this.cboProvince.TabIndex = 17;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label6.Location = new Point(308, 16);
			this.label6.Name = "label6";
			this.label6.Size = new Size(21, 14);
			this.label6.TabIndex = 16;
			this.label6.Text = "省";
			this.txtDWMC.CharacterCasing = CharacterCasing.Upper;
			this.txtDWMC.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtDWMC.ImeMode = ImeMode.On;
			this.txtDWMC.Location = new Point(66, 48);
			this.txtDWMC.Name = "txtDWMC";
			this.txtDWMC.Size = new Size(506, 23);
			this.txtDWMC.TabIndex = 1;
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(24, 238);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(356, 88);
			this.paneldata.TabIndex = 29;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(356, 88);
			this.gridControl1.TabIndex = 19;
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
				this.gridColumn11,
				this.gridColumn12
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
			this.gridColumn12.Caption = "gridColumn12";
			this.gridColumn12.Name = "gridColumn12";
			this.gridColumn12.Visible = true;
			this.gridColumn12.VisibleIndex = 11;
			this.panelmenu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panelmenu.Controls.Add(this.userManu1);
			this.panelmenu.Location = new Point(1, 124);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(169, 439);
			this.panelmenu.TabIndex = 31;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(169, 439);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(510, 36);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(408, 25);
			this.paneltop_right.TabIndex = 37;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(196, 32);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(303, 29);
			this.paneltop_middle.TabIndex = 36;
			this.paneltop_left.Location = new Point(13, 32);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 35;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(680, 3);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(238, 25);
			this.paneltitle_right.TabIndex = 34;
			this.pictureBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(171, 2);
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
			this.pictureBox2.Location = new Point(193, 2);
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
			this.pictureBox1.Location = new Point(215, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(21, 21);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox1_MouseLeave);
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox1_MouseEnter);
			this.paneltitle_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltitle_middle.Location = new Point(265, 3);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(418, 25);
			this.paneltitle_middle.TabIndex = 33;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(1, 3);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 32;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(196, 67);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(722, 487);
			this.panelright.TabIndex = 38;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(3, 155);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(712, 329);
			this.panelwhite.TabIndex = 30;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(6, 37);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(689, 40);
			this.panelbutton.TabIndex = 31;
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
			this.paneldatasum.Location = new Point(6, 3);
			this.paneldatasum.Name = "paneldatasum";
			this.paneldatasum.Size = new Size(689, 28);
			this.paneldatasum.TabIndex = 30;
			this.labeldatacount.BackColor = Color.Transparent;
			this.labeldatacount.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.labeldatacount.Location = new Point(41, 8);
			this.labeldatacount.Name = "labeldatacount";
			this.labeldatacount.Size = new Size(253, 14);
			this.labeldatacount.TabIndex = 0;
			this.pictureBox_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox_right.Location = new Point(677, 3);
			this.pictureBox_right.Name = "pictureBox_right";
			this.pictureBox_right.Size = new Size(38, 28);
			this.pictureBox_right.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_right.TabIndex = 19;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label7);
			this.panel_middle.Location = new Point(69, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(466, 28);
			this.panel_middle.TabIndex = 18;
			this.label7.BackColor = Color.Transparent;
			this.label7.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label7.Location = new Point(41, 7);
			this.label7.Name = "label7";
			this.label7.Size = new Size(253, 14);
			this.label7.TabIndex = 1;
			this.label7.Text = "农药单位查询";
			this.pictureBox_left.Location = new Point(0, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 17;
			this.pictureBox_left.TabStop = false;
			base.AcceptButton = this.btnSearch;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(930, 566);
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
			base.Name = "frmDW";
			this.Text = "农药相关单位查询";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frwDW_Load);
			base.Resize += new EventHandler(this.frmDW_Resize);
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
