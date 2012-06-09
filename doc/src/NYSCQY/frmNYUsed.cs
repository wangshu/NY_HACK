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
	public class frmNYUsed : Form
	{
		private IContainer components = null;
		private Button btnReset;
		private Button btnSearch;
		private Panel panelcondition;
		private ComboBox cboNYLB;
		private Label label4;
		private Label label3;
		private TextBox txtJX;
		private Label label2;
		private TextBox txtDJMC;
		private Label label1;
		private TextBox txtDJZH;
		private RadioButton rad;
		private RadioButton radUnused;
		private RadioButton radUsed;
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
		private GridColumn gridColumn13;
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
		private Label label6;
		private PictureBox pictureBox_left;
		private Panel panelwhite;
		private Panel panelbutton;
		private PictureBox pictureBox_sum;
		private PictureBox pictureBox_view;
		private PictureBox pictureBox_sort;
		private PictureBox pictureBox_filter;
		private Panel paneldatasum;
		private Label labeldatacount;
		private bool formMove = false;
		private Point formPoint;
		private DataTable tblResult = new DataTable();
		private int intRowNum = 0;
		private int intColNum = 0;
		private bool IsHaveJS = false;
		private clsStr Stra = new clsStr();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmNYUsed));
			this.btnReset = new Button();
			this.btnSearch = new Button();
			this.panelcondition = new Panel();
			this.rad = new RadioButton();
			this.radUnused = new RadioButton();
			this.radUsed = new RadioButton();
			this.cboNYLB = new ComboBox();
			this.label4 = new Label();
			this.label3 = new Label();
			this.txtJX = new TextBox();
			this.label2 = new Label();
			this.txtDJMC = new TextBox();
			this.label1 = new Label();
			this.txtDJZH = new TextBox();
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
			this.gridColumn13 = new GridColumn();
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
			this.label6 = new Label();
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
			this.btnReset.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnReset.Location = new Point(75, 77);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(45, 23);
			this.btnReset.TabIndex = 12;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.btnSearch.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnSearch.Location = new Point(24, 77);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(45, 23);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.rad);
			this.panelcondition.Controls.Add(this.radUnused);
			this.panelcondition.Controls.Add(this.radUsed);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.cboNYLB);
			this.panelcondition.Controls.Add(this.label4);
			this.panelcondition.Controls.Add(this.label3);
			this.panelcondition.Controls.Add(this.txtJX);
			this.panelcondition.Controls.Add(this.label2);
			this.panelcondition.Controls.Add(this.txtDJMC);
			this.panelcondition.Controls.Add(this.label1);
			this.panelcondition.Controls.Add(this.txtDJZH);
			this.panelcondition.Location = new Point(3, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(633, 116);
			this.panelcondition.TabIndex = 10;
			this.rad.AutoSize = true;
			this.rad.BackColor = Color.Transparent;
			this.rad.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.rad.Location = new Point(518, 38);
			this.rad.Name = "rad";
			this.rad.Size = new Size(53, 18);
			this.rad.TabIndex = 18;
			this.rad.Text = "所有";
			this.rad.UseVisualStyleBackColor = false;
			this.radUnused.AutoSize = true;
			this.radUnused.BackColor = Color.Transparent;
			this.radUnused.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radUnused.Location = new Point(459, 38);
			this.radUnused.Name = "radUnused";
			this.radUnused.Size = new Size(53, 18);
			this.radUnused.TabIndex = 17;
			this.radUnused.Text = "过期";
			this.radUnused.UseVisualStyleBackColor = false;
			this.radUsed.AutoSize = true;
			this.radUsed.BackColor = Color.Transparent;
			this.radUsed.Checked = true;
			this.radUsed.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radUsed.Location = new Point(371, 38);
			this.radUsed.Name = "radUsed";
			this.radUsed.Size = new Size(81, 18);
			this.radUsed.TabIndex = 16;
			this.radUsed.TabStop = true;
			this.radUsed.Text = "有效期内";
			this.radUsed.UseVisualStyleBackColor = false;
			this.cboNYLB.DropDownWidth = 160;
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
			this.cboNYLB.Location = new Point(69, 36);
			this.cboNYLB.Name = "cboNYLB";
			this.cboNYLB.Size = new Size(124, 22);
			this.cboNYLB.TabIndex = 8;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label4.Location = new Point(6, 40);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 14);
			this.label4.TabIndex = 7;
			this.label4.Text = "农药类别";
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label3.Location = new Point(201, 40);
			this.label3.Name = "label3";
			this.label3.Size = new Size(35, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "剂型";
			this.txtJX.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtJX.ImeMode = ImeMode.On;
			this.txtJX.Location = new Point(242, 36);
			this.txtJX.Name = "txtJX";
			this.txtJX.Size = new Size(123, 23);
			this.txtJX.TabIndex = 5;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label2.Location = new Point(274, 9);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "登记名称";
			this.txtDJMC.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtDJMC.ImeMode = ImeMode.On;
			this.txtDJMC.Location = new Point(337, 5);
			this.txtDJMC.Name = "txtDJMC";
			this.txtDJMC.Size = new Size(203, 23);
			this.txtDJMC.TabIndex = 3;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "登记证号";
			this.txtDJZH.CharacterCasing = CharacterCasing.Upper;
			this.txtDJZH.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtDJZH.Location = new Point(69, 5);
			this.txtDJZH.Name = "txtDJZH";
			this.txtDJZH.Size = new Size(203, 23);
			this.txtDJZH.TabIndex = 1;
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(48, 204);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(182, 103);
			this.paneldata.TabIndex = 19;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(182, 103);
			this.gridControl1.TabIndex = 10;
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
				this.gridColumn12,
				this.gridColumn13
			});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
			this.gridView1.CustomDrawCell += new RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
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
			this.gridColumn13.Caption = "gridColumn13";
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.Visible = true;
			this.gridColumn13.VisibleIndex = 12;
			this.panelmenu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panelmenu.Controls.Add(this.userManu1);
			this.panelmenu.Location = new Point(0, 81);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(171, 507);
			this.panelmenu.TabIndex = 21;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(171, 507);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(429, 34);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(409, 25);
			this.paneltop_right.TabIndex = 27;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(195, 30);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(223, 29);
			this.paneltop_middle.TabIndex = 26;
			this.paneltop_left.Location = new Point(12, 30);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 25;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(599, 1);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(239, 25);
			this.paneltitle_right.TabIndex = 24;
			this.pictureBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(172, 2);
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
			this.pictureBox2.Location = new Point(194, 2);
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
			this.pictureBox1.Location = new Point(216, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(21, 21);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox1_MouseLeave);
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox1_MouseEnter);
			this.paneltitle_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltitle_middle.Location = new Point(264, 1);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(338, 25);
			this.paneltitle_middle.TabIndex = 23;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(0, 1);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 22;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(195, 81);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(643, 496);
			this.panelright.TabIndex = 28;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(3, 159);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(633, 322);
			this.panelwhite.TabIndex = 23;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(9, 37);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(607, 40);
			this.panelbutton.TabIndex = 21;
			this.pictureBox_sum.BackColor = Color.Transparent;
			this.pictureBox_sum.Cursor = Cursors.Hand;
			this.pictureBox_sum.Location = new Point(352, 9);
			this.pictureBox_sum.Name = "pictureBox_sum";
			this.pictureBox_sum.Size = new Size(65, 24);
			this.pictureBox_sum.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_sum.TabIndex = 3;
			this.pictureBox_sum.TabStop = false;
			this.pictureBox_sum.Click += new EventHandler(this.pictureBox_sum_Click);
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
			this.paneldatasum.Location = new Point(9, 3);
			this.paneldatasum.Name = "paneldatasum";
			this.paneldatasum.Size = new Size(607, 28);
			this.paneldatasum.TabIndex = 20;
			this.labeldatacount.BackColor = Color.Transparent;
			this.labeldatacount.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.labeldatacount.Location = new Point(41, 8);
			this.labeldatacount.Name = "labeldatacount";
			this.labeldatacount.Size = new Size(253, 14);
			this.labeldatacount.TabIndex = 0;
			this.pictureBox_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox_right.Location = new Point(598, 3);
			this.pictureBox_right.Name = "pictureBox_right";
			this.pictureBox_right.Size = new Size(38, 28);
			this.pictureBox_right.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_right.TabIndex = 22;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label6);
			this.panel_middle.Location = new Point(69, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(386, 28);
			this.panel_middle.TabIndex = 21;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label6.Location = new Point(41, 7);
			this.label6.Name = "label6";
			this.label6.Size = new Size(253, 14);
			this.label6.TabIndex = 1;
			this.label6.Text = "农药有效性查询";
			this.pictureBox_left.Location = new Point(0, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 20;
			this.pictureBox_left.TabStop = false;
			base.AcceptButton = this.btnSearch;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(850, 589);
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
			base.Name = "frmNYUsed";
			base.ShowInTaskbar = false;
			this.Text = "农药有效性查询";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frmNYUsed_Load);
			base.Resize += new EventHandler(this.frmNYUsed_Resize);
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
		public frmNYUsed()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem9.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			clsStr clsStr = new clsStr();
			clsMe clsMe = new clsMe();
			this.Cursor = Cursors.WaitCursor;
			string text = "";
			string[] array = clsStr.Seperate(this.txtDJZH.Text, ' ');
			string text2 = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (!(array[i] == ""))
				{
					if (text2 == "")
					{
						text2 = "R1 like '%" + array[i] + "%'";
					}
					else
					{
						text2 = text2 + " or R1 like '%" + array[i] + "%'";
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
			array = clsStr.Seperate(this.txtDJMC.Text, ' ');
			text2 = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (!(array[i] == ""))
				{
					array[i] = array[i].Replace("%", "[%]");
					if (text2 == "")
					{
						text2 = "R2 like '%" + array[i] + "%'";
					}
					else
					{
						text2 = text2 + " or R2 like '%" + array[i] + "%'";
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
			if (this.radUsed.Checked)
			{
				if (text == "")
				{
					text = "R5>='" + clsStr.Format(DateTime.Now.Date.ToString(), '-') + "'";
				}
				else
				{
					text = text + "and R5>='" + clsStr.Format(DateTime.Now.Date.ToString(), '-') + "'";
				}
			}
			else
			{
				if (this.radUnused.Checked)
				{
					if (text == "")
					{
						text = "R5<'" + clsStr.Format(DateTime.Now.Date.ToString(), '-') + "'";
					}
					else
					{
						text = text + "and R5<'" + clsStr.Format(DateTime.Now.Date.ToString(), '-') + "'";
					}
				}
			}
			if (this.cboNYLB.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "R12 = '" + this.cboNYLB.Text.Trim() + "'";
				}
				else
				{
					text = text + " and R12 = '" + this.cboNYLB.Text.Trim() + "'";
				}
			}
			if (this.txtJX.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "R13 like '%" + this.txtJX.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and R13 like '%" + this.txtJX.Text.Trim() + "%'";
				}
			}
			DataRow[] array2 = MDIParent.dsP.Tables["P"].Select(text, "F2");
			DataRow[] array3 = MDIParent.dsF.Tables["F"].Select("", "F2");
			DataTable dataTable = new DataTable();
			dataTable = this.tblResult.Clone();
			int j = 0;
			string text3 = DateTime.Now.Second.ToString();
			if (text3.Length > 1)
			{
				int num = (int)Convert.ToInt16(text3.Substring(text3.Length - 1));
			}
			else
			{
				int num = (int)Convert.ToInt16(text3);
			}
			for (int i = 0; i < array3.Length; i++)
			{
				while (j < array2.Length)
				{
					if (!(array3[i]["F2"].ToString() == array2[j]["F2"].ToString()))
					{
						break;
					}
					DataRow dataRow = dataTable.NewRow();
					dataRow["R1"] = array2[j]["R1"];
					dataRow["R2"] = array2[j]["R2"];
					dataRow["HL"] = array2[j]["HL"];
					dataRow["R12"] = array2[j]["R12"];
					dataRow["R80"] = array2[j]["R80"];
					dataRow["R90"] = array2[j]["R90"];
					dataRow["R4"] = array2[j]["R4"];
					dataRow["R5"] = array2[j]["R5"];
					dataRow["F2"] = array3[i]["F2"];
					dataRow["F9"] = array3[i]["F9"];
					dataRow["F14"] = array3[i]["F14"];
					dataRow["R11"] = array2[j]["R11"];
					dataRow["R13"] = array2[j]["R13"];
					dataTable.Rows.Add(dataRow);
					j++;
				}
				if (j == array2.Length)
				{
					break;
				}
			}
			this.tblResult = dataTable.Copy();
			DataView dataView = new DataView(this.tblResult);
			dataView.Sort = "R5 desc";
			this.gridControl1.DataSource = dataView;
			this.Cursor = Cursors.Default;
			if (this.tblResult.Rows.Count == 0)
			{
				MessageBox.Show(this, "查询不到相关数据,可能由以下原因造成：\r\n1、您输入的条件太多,过于复杂；\r\n2、该产品已被吊销、禁止发布等；\r\n3、不存在该产品；\r\n请您重新输入简单正确条件后继续查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtDJZH.Focus();
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.txtDJZH.Text = "";
			this.txtDJMC.Text = "";
			this.radUsed.Checked = true;
			this.cboNYLB.Text = "";
			this.txtJX.Text = "";
			this.txtDJZH.Focus();
		}
		private void SetHeaders()
		{
			this.tblResult.Columns.Add("R1");
			this.tblResult.Columns.Add("R2");
			this.tblResult.Columns.Add("HL");
			this.tblResult.Columns.Add("R12");
			this.tblResult.Columns.Add("R80");
			this.tblResult.Columns.Add("R90");
			this.tblResult.Columns.Add("R4");
			this.tblResult.Columns.Add("R5");
			this.tblResult.Columns.Add("F2");
			this.tblResult.Columns.Add("F9");
			this.tblResult.Columns.Add("F14");
			this.tblResult.Columns.Add("R13");
			this.tblResult.Columns.Add("R11");
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
			this.gridView1.Columns[0].Caption = "登记证号";
			this.gridView1.Columns[0].FieldName = "R1";
			this.gridView1.Columns[0].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[0].AppearanceCell.Font = new Font("宋体", 10.5f, FontStyle.Underline);
			this.gridView1.Columns[0].AppearanceCell.ForeColor = Color.Blue;
			this.gridView1.Columns[0].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[0].Width = 100;
			this.gridView1.Columns[0].Visible = true;
			this.gridView1.Columns[1].Caption = "登记名称";
			this.gridView1.Columns[1].FieldName = "R2";
			this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[1].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[1].Width = 170;
			this.gridView1.Columns[2].Caption = "含量";
			this.gridView1.Columns[2].FieldName = "HL";
			this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[2].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[2].Width = 80;
			this.gridView1.Columns[3].Caption = "剂型";
			this.gridView1.Columns[3].FieldName = "R13";
			this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[3].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[3].Width = 80;
			this.gridView1.Columns[4].Caption = "毒性";
			this.gridView1.Columns[4].FieldName = "R11";
			this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[4].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[4].Width = 80;
			this.gridView1.Columns[5].Caption = "农药类别";
			this.gridView1.Columns[5].FieldName = "R12";
			this.gridView1.Columns[5].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[5].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[5].Width = 80;
			this.gridView1.Columns[6].Caption = "生产批准/许可证号";
			this.gridView1.Columns[6].FieldName = "R80";
			this.gridView1.Columns[6].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[6].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[6].Width = 160;
			this.gridView1.Columns[7].Caption = "执行标准/企业标准";
			this.gridView1.Columns[7].FieldName = "R90";
			this.gridView1.Columns[7].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[7].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[7].Width = 160;
			this.gridView1.Columns[8].Caption = "有效起始日";
			this.gridView1.Columns[8].FieldName = "R4";
			this.gridView1.Columns[8].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[8].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[8].Width = 120;
			this.gridView1.Columns[9].Caption = "有效截止日";
			this.gridView1.Columns[9].FieldName = "R5";
			this.gridView1.Columns[9].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[9].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[9].Width = 120;
			this.gridView1.Columns[10].Caption = "生产企业";
			this.gridView1.Columns[10].FieldName = "F2";
			this.gridView1.Columns[10].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[10].AppearanceCell.Font = new Font("宋体", 10.5f, FontStyle.Underline);
			this.gridView1.Columns[10].AppearanceCell.ForeColor = Color.Blue;
			this.gridView1.Columns[10].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[10].Width = 250;
			this.gridView1.Columns[11].Caption = "电话";
			this.gridView1.Columns[11].FieldName = "F9";
			this.gridView1.Columns[11].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[11].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[11].Width = 160;
			this.gridView1.Columns[12].Caption = "联系人";
			this.gridView1.Columns[12].FieldName = "F14";
			this.gridView1.Columns[12].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[12].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[12].Width = 160;
		}
		private void frmNYUsed_Load(object sender, EventArgs e)
		{
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.txtDJZH.Focus();
		}
		private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
		{
			if (e.Column.FieldName.ToUpper() == "R1")
			{
				frmNYDetail frmNYDetail = new frmNYDetail(e.CellValue.ToString(), "", "");
				frmNYDetail.ShowDialog();
			}
			if (e.Column.FieldName.ToUpper() == "F2")
			{
				frmQYDetail frmQYDetail = new frmQYDetail(e.CellValue.ToString(), "", "");
				frmQYDetail.ShowDialog();
			}
		}
		private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
		{
			if (string.Compare(this.gridView1.GetRowCellValue(e.RowHandle, "R5").ToString(), this.Stra.Format(DateTime.Now.Date.ToString(), '-')) < 0)
			{
				e.Appearance.ForeColor = Color.Red;
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
				frmFilter frmFilter = new frmFilter("NY");
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
		private void pictureBox_sum_Click(object sender, EventArgs e)
		{
			if (this.gridView1.RowCount > 0)
			{
				frmGroup frmGroup = new frmGroup(this.gridControl1, base.Name);
				frmGroup.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "请您先查询数据后再统计！", "提示", MessageBoxButtons.OK);
			}
		}
		private void frmNYUsed_Resize(object sender, EventArgs e)
		{
			this.userManu1.navBarControl1.Height = this.panelmenu.Height - 2;
		}
	}
}
