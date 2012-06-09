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
	public class frmYXCF2JX : Form
	{
		private IContainer components = null;
		private Button btnReset;
		private Button btnSearch;
		private Panel panelcondition;
		private RadioButton radYY;
		private RadioButton radHJ;
		private RadioButton radDJ;
		private RadioButton radAll;
		private ComboBox cboAndOr;
		private Label label3;
		private TextBox txtJX;
		private Label label1;
		private TextBox txtYXCF;
		private Panel paneldata;
		private Panel panelmenu;
		private GridControl gridControl1;
		private GridView gridView1;
		private GridColumn gridColumn1;
		private GridColumn gridColumn2;
		private GridColumn gridColumn3;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmYXCF2JX));
			this.btnReset = new Button();
			this.btnSearch = new Button();
			this.panelcondition = new Panel();
			this.radYY = new RadioButton();
			this.radHJ = new RadioButton();
			this.radDJ = new RadioButton();
			this.radAll = new RadioButton();
			this.cboAndOr = new ComboBox();
			this.label3 = new Label();
			this.txtJX = new TextBox();
			this.label1 = new Label();
			this.txtYXCF = new TextBox();
			this.paneldata = new Panel();
			this.gridControl1 = new GridControl();
			this.gridView1 = new GridView();
			this.gridColumn1 = new GridColumn();
			this.gridColumn2 = new GridColumn();
			this.gridColumn3 = new GridColumn();
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
			this.btnReset.Location = new Point(73, 80);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(50, 23);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.btnSearch.Location = new Point(17, 80);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(50, 23);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.radYY);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.radHJ);
			this.panelcondition.Controls.Add(this.radDJ);
			this.panelcondition.Controls.Add(this.radAll);
			this.panelcondition.Controls.Add(this.cboAndOr);
			this.panelcondition.Controls.Add(this.label3);
			this.panelcondition.Controls.Add(this.txtJX);
			this.panelcondition.Controls.Add(this.label1);
			this.panelcondition.Controls.Add(this.txtYXCF);
			this.panelcondition.Location = new Point(10, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(566, 107);
			this.panelcondition.TabIndex = 19;
			this.radYY.AutoSize = true;
			this.radYY.BackColor = Color.Transparent;
			this.radYY.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radYY.Location = new Point(474, 45);
			this.radYY.Name = "radYY";
			this.radYY.Size = new Size(53, 18);
			this.radYY.TabIndex = 16;
			this.radYY.Text = "原药";
			this.radYY.UseVisualStyleBackColor = false;
			this.radHJ.AutoSize = true;
			this.radHJ.BackColor = Color.Transparent;
			this.radHJ.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radHJ.Location = new Point(421, 45);
			this.radHJ.Name = "radHJ";
			this.radHJ.Size = new Size(53, 18);
			this.radHJ.TabIndex = 11;
			this.radHJ.Text = "混剂";
			this.radHJ.UseVisualStyleBackColor = false;
			this.radDJ.AutoSize = true;
			this.radDJ.BackColor = Color.Transparent;
			this.radDJ.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radDJ.Location = new Point(362, 45);
			this.radDJ.Name = "radDJ";
			this.radDJ.Size = new Size(53, 18);
			this.radDJ.TabIndex = 10;
			this.radDJ.Text = "单剂";
			this.radDJ.UseVisualStyleBackColor = false;
			this.radAll.AutoSize = true;
			this.radAll.BackColor = Color.Transparent;
			this.radAll.Checked = true;
			this.radAll.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.radAll.Location = new Point(303, 45);
			this.radAll.Name = "radAll";
			this.radAll.Size = new Size(53, 18);
			this.radAll.TabIndex = 9;
			this.radAll.TabStop = true;
			this.radAll.Text = "全部";
			this.radAll.UseVisualStyleBackColor = false;
			this.cboAndOr.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboAndOr.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.cboAndOr.FormattingEnabled = true;
			this.cboAndOr.Items.AddRange(new object[]
			{
				"或",
				"且"
			});
			this.cboAndOr.Location = new Point(277, 13);
			this.cboAndOr.Name = "cboAndOr";
			this.cboAndOr.Size = new Size(49, 22);
			this.cboAndOr.TabIndex = 8;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label3.Location = new Point(25, 47);
			this.label3.Name = "label3";
			this.label3.Size = new Size(35, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "剂型";
			this.txtJX.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtJX.Location = new Point(64, 43);
			this.txtJX.Name = "txtJX";
			this.txtJX.Size = new Size(208, 23);
			this.txtJX.TabIndex = 5;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(1, 16);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "有效成分";
			this.txtYXCF.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtYXCF.Location = new Point(64, 12);
			this.txtYXCF.Name = "txtYXCF";
			this.txtYXCF.Size = new Size(208, 23);
			this.txtYXCF.TabIndex = 1;
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(22, 198);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(109, 91);
			this.paneldata.TabIndex = 21;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(109, 91);
			this.gridControl1.TabIndex = 9;
			this.gridControl1.ViewCollection.AddRange(new BaseView[]
			{
				this.gridView1
			});
			this.gridView1.Columns.AddRange(new GridColumn[]
			{
				this.gridColumn1,
				this.gridColumn2,
				this.gridColumn3
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
			this.panelmenu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panelmenu.Controls.Add(this.userManu1);
			this.panelmenu.Location = new Point(2, 92);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(170, 470);
			this.panelmenu.TabIndex = 23;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(170, 470);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(383, 36);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(395, 25);
			this.paneltop_right.TabIndex = 29;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(207, 32);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(165, 29);
			this.paneltop_middle.TabIndex = 28;
			this.paneltop_left.Location = new Point(24, 32);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 27;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(553, 3);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(227, 25);
			this.paneltitle_right.TabIndex = 26;
			this.pictureBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(160, 2);
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
			this.pictureBox2.Location = new Point(182, 2);
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
			this.pictureBox1.Location = new Point(204, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(21, 21);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox1_MouseLeave);
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox1_MouseEnter);
			this.paneltitle_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltitle_middle.Location = new Point(276, 3);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(280, 25);
			this.paneltitle_middle.TabIndex = 25;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(12, 3);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 24;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(197, 77);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(581, 477);
			this.panelright.TabIndex = 30;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(16, 153);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(560, 321);
			this.panelwhite.TabIndex = 25;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(11, 48);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(522, 40);
			this.panelbutton.TabIndex = 23;
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
			this.paneldatasum.Location = new Point(11, 14);
			this.paneldatasum.Name = "paneldatasum";
			this.paneldatasum.Size = new Size(522, 28);
			this.paneldatasum.TabIndex = 22;
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
			this.pictureBox_right.TabIndex = 24;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label6);
			this.panel_middle.Location = new Point(79, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(328, 28);
			this.panel_middle.TabIndex = 23;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label6.Location = new Point(41, 7);
			this.label6.Name = "label6";
			this.label6.Size = new Size(253, 14);
			this.label6.TabIndex = 1;
			this.label6.Text = "有效成分=>剂型";
			this.pictureBox_left.Location = new Point(10, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 22;
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
			base.Name = "frmYXCF2JX";
			base.ShowInTaskbar = false;
			this.Text = "有效成分=>剂型";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frmYXCF2JX_Load);
			base.Resize += new EventHandler(this.frmYXCF2JX_Resize);
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
		public frmYXCF2JX()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem25.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void frmYXCF2JX_Load(object sender, EventArgs e)
		{
			this.cboAndOr.SelectedIndex = 0;
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.txtYXCF.Focus();
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
							"(E2 like '%",
							array[i],
							"%' or E3 like '%",
							array[i],
							"%' or E4 like '%",
							array[i],
							"%' or E5 like '%",
							array[i],
							"%')"
						});
					}
					else
					{
						if (this.cboAndOr.Text == "且")
						{
							string text3 = text2;
							text2 = string.Concat(new string[]
							{
								text3,
								" and  (E2 like '%",
								array[i],
								"%' or E3 like '%",
								array[i],
								"%' or E4 like '%",
								array[i],
								"%' or E5 like '%",
								array[i],
								"%')"
							});
						}
						else
						{
							string text3 = text2;
							text2 = string.Concat(new string[]
							{
								text3,
								" or (E2 like '%",
								array[i],
								"%' or E3 like '%",
								array[i],
								"%' or E4 like '%",
								array[i],
								"%' or E5 like '%",
								array[i],
								"%')"
							});
						}
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
			if (this.radHJ.Checked)
			{
				if (text == "")
				{
					text = "E2 like '%、%'";
				}
				else
				{
					text += " and E2 like '%、%'";
				}
			}
			else
			{
				if (this.radDJ.Checked)
				{
					if (text == "")
					{
						text = "E2 not like '%、%'";
					}
					else
					{
						text += " and E2 not like '%、%'";
					}
				}
			}
			if (this.radYY.Checked)
			{
				if (text == "")
				{
					text = "(R13 like '%原药%' or R13 like '%原粉%' or R13 like '%母液%' or R13 like '%母药%' or R13 like '%母粉%')";
				}
				else
				{
					text += " and (R13 like '%原药%' or R13 like '%原粉%' or R13 like '%母液%' or R13 like '%母药%' or R13 like '%母粉%')";
				}
			}
			else
			{
				if (!this.radAll.Checked)
				{
					if (text == "")
					{
						text = "(R13 not like '%原药%' and R13 not like '%原粉%' and R13 not like '%母液%' and R13 not like '%母药%' and R13 not like '%母粉%')";
					}
					else
					{
						text += " and (R13 not like '%原药%' and R13 not like '%原粉%' and R13 not like '%母液%' and R13 not like '%母药%' and R13 not like '%母粉%')";
					}
				}
			}
			DataRow[] array2 = MDIParent.dsP.Tables["P"].Select(text);
			DataTable dataTable = new DataTable();
			dataTable = this.tblResult.Clone();
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = clsStr.Seperate(array2[i]["E2"].ToString(), '、');
				string[] array4 = clsStr.Seperate(array2[i]["E3"].ToString(), '、');
				string[] array5 = clsStr.Seperate(array2[i]["E4"].ToString(), '、');
				string[] array6 = clsStr.Seperate(array2[i]["E5"].ToString(), '、');
				for (int j = 0; j < array4.Length; j++)
				{
					bool flag = false;
					if (this.txtYXCF.Text.Trim() != "")
					{
						for (int k = 0; k < array.Length; k++)
						{
							if (!(array[k].ToString() == ""))
							{
								if (array4[j].IndexOf(array[k]) >= 0 || array3[j].IndexOf(array[k]) >= 0 || array6[j].IndexOf(array[k]) >= 0 || array5[j].IndexOf(array[k]) >= 0)
								{
									flag = true;
									break;
								}
								flag = false;
							}
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["E2"] = array3[j];
						dataRow["E3"] = array4[j];
						dataRow["R13"] = array2[i]["R13"];
						dataTable.Rows.Add(dataRow);
					}
				}
			}
			DataRow[] array7 = dataTable.Select("E2<>''", "E2,E3,R13");
			DataTable dataTable2 = new DataTable();
			dataTable2 = this.tblResult.Clone();
			string b = "***";
			string b2 = "***";
			string b3 = "***";
			for (int i = 0; i < array7.Length; i++)
			{
				if (array7[i]["E2"].ToString() != b || array7[i]["E3"].ToString() != b2 || array7[i]["R13"].ToString() != b3)
				{
					DataRow dataRow = dataTable2.NewRow();
					dataRow["E2"] = array7[i]["E2"];
					dataRow["E3"] = array7[i]["E3"];
					dataRow["R13"] = array7[i]["R13"];
					b = array7[i]["E2"].ToString();
					b2 = array7[i]["E3"].ToString();
					b3 = array7[i]["R13"].ToString();
					dataTable2.Rows.Add(dataRow);
				}
			}
			this.tblResult = dataTable2.Copy();
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
			this.cboAndOr.SelectedIndex = 0;
			this.txtJX.Text = "";
			this.radAll.Checked = true;
			this.txtYXCF.Focus();
		}
		private void SetHeaders()
		{
			this.tblResult.Columns.Add("E2");
			this.tblResult.Columns.Add("E3");
			this.tblResult.Columns.Add("R13");
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
			this.gridView1.Columns[0].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[0].Width = 250;
			this.gridView1.Columns[0].Visible = true;
			this.gridView1.Columns[1].Caption = "英文名称";
			this.gridView1.Columns[1].FieldName = "E3";
			this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[1].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[1].Width = 250;
			this.gridView1.Columns[2].Caption = "剂型";
			this.gridView1.Columns[2].FieldName = "R13";
			this.gridView1.Columns[2].AppearanceCell.Font = new Font("宋体", 10.5f, FontStyle.Underline);
			this.gridView1.Columns[2].AppearanceCell.ForeColor = Color.Blue;
			this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[2].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[2].Width = 250;
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
			if (e.Column.FieldName.ToUpper() == "R13")
			{
				string text;
				if (this.radDJ.Checked)
				{
					text = "E2 not like '%、%'";
				}
				else
				{
					if (this.radHJ.Checked)
					{
						text = "E2 like '%、%'";
					}
					else
					{
						text = "E2 like '%%'";
					}
				}
				frmNYList frmNYList = new frmNYList("YXCF2JX", string.Concat(new string[]
				{
					this.gridView1.GetRowCellValue(e.RowHandle, "E2").ToString(),
					"|",
					this.gridView1.GetRowCellValue(e.RowHandle, "E3").ToString(),
					"|",
					e.CellValue.ToString(),
					"|",
					text
				}));
				frmNYList.ShowDialog();
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
		private void frmYXCF2JX_Resize(object sender, EventArgs e)
		{
			this.userManu1.navBarControl1.Height = this.panelmenu.Height - 2;
		}
	}
}
