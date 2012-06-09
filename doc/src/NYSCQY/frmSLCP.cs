using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmSLCP : Form
	{
		private IContainer components = null;
		private Label lblCount;
		private Button btnReset;
		private Button btnSearch;
		private Panel panelcondition;
		private Label label3;
		private TextBox txtZHSLH;
		private Label label1;
		private TextBox txtZLBH;
		private Panel paneldata;
		private Label label4;
		private TextBox txtSCQY;
		private Label label2;
		private TextBox txtCPMC;
		private Panel panelmenu;
		private GridControl gridControl1;
		private GridView gridView1;
		private GridColumn gridColumn1;
		private GridColumn gridColumn2;
		private GridColumn gridColumn3;
		private GridColumn gridColumn4;
		private GridColumn gridColumn5;
		private GridColumn gridColumn6;
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
		private Panel panelwhite;
		private PictureBox pictureBox_right;
		private Panel panel_middle;
		private Label label6;
		private PictureBox pictureBox_left;
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
		private DataSet dsT15 = new DataSet();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSLCP));
			this.lblCount = new Label();
			this.btnReset = new Button();
			this.btnSearch = new Button();
			this.panelcondition = new Panel();
			this.label4 = new Label();
			this.txtSCQY = new TextBox();
			this.label2 = new Label();
			this.txtCPMC = new TextBox();
			this.label3 = new Label();
			this.txtZHSLH = new TextBox();
			this.label1 = new Label();
			this.txtZLBH = new TextBox();
			this.paneldata = new Panel();
			this.gridControl1 = new GridControl();
			this.gridView1 = new GridView();
			this.gridColumn1 = new GridColumn();
			this.gridColumn2 = new GridColumn();
			this.gridColumn3 = new GridColumn();
			this.gridColumn4 = new GridColumn();
			this.gridColumn5 = new GridColumn();
			this.gridColumn6 = new GridColumn();
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
			this.lblCount.AutoSize = true;
			this.lblCount.BackColor = Color.Transparent;
			this.lblCount.Location = new Point(82, 59);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new Size(0, 14);
			this.lblCount.TabIndex = 14;
			this.btnReset.Location = new Point(88, 69);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(50, 23);
			this.btnReset.TabIndex = 20;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.btnSearch.Location = new Point(14, 69);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(50, 23);
			this.btnSearch.TabIndex = 19;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.label4);
			this.panelcondition.Controls.Add(this.txtSCQY);
			this.panelcondition.Controls.Add(this.label2);
			this.panelcondition.Controls.Add(this.txtCPMC);
			this.panelcondition.Controls.Add(this.lblCount);
			this.panelcondition.Controls.Add(this.label3);
			this.panelcondition.Controls.Add(this.txtZHSLH);
			this.panelcondition.Controls.Add(this.label1);
			this.panelcondition.Controls.Add(this.txtZLBH);
			this.panelcondition.Location = new Point(10, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(562, 117);
			this.panelcondition.TabIndex = 18;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Location = new Point(274, 37);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 14);
			this.label4.TabIndex = 19;
			this.label4.Text = "生产企业";
			this.txtSCQY.ImeMode = ImeMode.On;
			this.txtSCQY.Location = new Point(337, 32);
			this.txtSCQY.Name = "txtSCQY";
			this.txtSCQY.Size = new Size(191, 23);
			this.txtSCQY.TabIndex = 18;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Location = new Point(1, 37);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 14);
			this.label2.TabIndex = 17;
			this.label2.Text = "产品名称";
			this.txtCPMC.ImeMode = ImeMode.On;
			this.txtCPMC.Location = new Point(64, 32);
			this.txtCPMC.Name = "txtCPMC";
			this.txtCPMC.Size = new Size(191, 23);
			this.txtCPMC.TabIndex = 16;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Location = new Point(260, 8);
			this.label3.Name = "label3";
			this.label3.Size = new Size(77, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "综合受理号";
			this.txtZHSLH.Location = new Point(337, 3);
			this.txtZHSLH.Name = "txtZHSLH";
			this.txtZHSLH.Size = new Size(191, 23);
			this.txtZHSLH.TabIndex = 5;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Location = new Point(1, 8);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "资料编号";
			this.txtZLBH.Location = new Point(64, 3);
			this.txtZLBH.Name = "txtZLBH";
			this.txtZLBH.Size = new Size(191, 23);
			this.txtZLBH.TabIndex = 1;
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(16, 208);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(161, 81);
			this.paneldata.TabIndex = 27;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(161, 81);
			this.gridControl1.TabIndex = 18;
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
				this.gridColumn6
			});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
			this.gridView1.RowCountChanged += new EventHandler(this.gridView1_RowCountChanged);
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
			this.panelmenu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panelmenu.Controls.Add(this.userManu1);
			this.panelmenu.Location = new Point(1, 177);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(176, 387);
			this.panelmenu.TabIndex = 29;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(176, 387);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(372, 35);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(408, 25);
			this.paneltop_right.TabIndex = 35;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(196, 31);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(165, 29);
			this.paneltop_middle.TabIndex = 34;
			this.paneltop_left.Location = new Point(13, 31);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 33;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(542, 2);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(238, 25);
			this.paneltitle_right.TabIndex = 32;
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
			this.paneltitle_middle.Location = new Point(265, 2);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(280, 25);
			this.paneltitle_middle.TabIndex = 31;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(1, 2);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 30;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(201, 74);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(579, 480);
			this.panelright.TabIndex = 36;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(10, 173);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(562, 304);
			this.panelwhite.TabIndex = 31;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(4, 48);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(541, 40);
			this.panelbutton.TabIndex = 29;
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
			this.paneldatasum.Location = new Point(4, 14);
			this.paneldatasum.Name = "paneldatasum";
			this.paneldatasum.Size = new Size(541, 28);
			this.paneldatasum.TabIndex = 28;
			this.labeldatacount.BackColor = Color.Transparent;
			this.labeldatacount.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.labeldatacount.Location = new Point(41, 8);
			this.labeldatacount.Name = "labeldatacount";
			this.labeldatacount.Size = new Size(253, 14);
			this.labeldatacount.TabIndex = 0;
			this.pictureBox_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox_right.Location = new Point(534, 3);
			this.pictureBox_right.Name = "pictureBox_right";
			this.pictureBox_right.Size = new Size(38, 28);
			this.pictureBox_right.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_right.TabIndex = 30;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label6);
			this.panel_middle.Location = new Point(79, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(328, 28);
			this.panel_middle.TabIndex = 29;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label6.Location = new Point(41, 7);
			this.label6.Name = "label6";
			this.label6.Size = new Size(253, 14);
			this.label6.TabIndex = 1;
			this.label6.Text = "农药受理查询";
			this.pictureBox_left.Location = new Point(10, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 28;
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
			base.Name = "frmSLCP";
			base.ShowInTaskbar = false;
			this.Text = "农药受理产品查询";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frmSLCP_Load);
			base.Resize += new EventHandler(this.frmSLCP_Resize);
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
		public frmSLCP()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem13.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void initT15()
		{
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			string strFromFile = Directory.GetCurrentDirectory() + "\\t15.dat";
			string text = Directory.GetCurrentDirectory() + "\\t15.zip";
			string text2 = Directory.GetCurrentDirectory() + "\\t15.xml";
			DataSet dataSet = new DataSet();
			clsMe.GetFile(strFromFile, text);
			clsCompression.UnZipFile(text, text2);
			this.dsT15.ReadXmlSchema(text2);
			this.dsT15.ReadXml(text2, XmlReadMode.IgnoreSchema);
			clsMe.PlanData(this.dsT15, "T15", "CPMC|FMISPCNAME|");
			File.Delete(text);
			File.Delete(text2);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			clsStr clsStr = new clsStr();
			this.Cursor = Cursors.WaitCursor;
			if (this.txtZLBH.Text.Trim().Length <= 0 && this.txtZHSLH.Text.Trim().Length <= 0)
			{
				MessageBox.Show(this, "综合受理号和资料编号不能都空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtZHSLH.Focus();
				this.Cursor = Cursors.Arrow;
			}
			else
			{
				if (this.txtSCQY.Text.Trim().Length <= 0)
				{
					MessageBox.Show(this, "生产企业名称不能空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.txtSCQY.Focus();
					this.Cursor = Cursors.Arrow;
				}
				else
				{
					string text = "";
					if (this.txtZLBH.Text.Trim() != "")
					{
						if (text == "")
						{
							text = "ZLBH like '%" + this.txtZLBH.Text.Trim() + "%'";
						}
						else
						{
							text = text + " and ZLBH like '%" + this.txtZLBH.Text.Trim() + "%'";
						}
					}
					if (this.txtZHSLH.Text.Trim() != "")
					{
						if (text == "")
						{
							text = "BSBH like '%" + this.txtZHSLH.Text.Trim() + "%'";
						}
						else
						{
							text = text + " and BSBH like '%" + this.txtZHSLH.Text.Trim() + "%'";
						}
					}
					if (this.txtCPMC.Text.Trim() != "")
					{
						if (text == "")
						{
							text = "CPMC like '%" + this.txtCPMC.Text.Trim() + "%'";
						}
						else
						{
							text = text + " and CPMC like '%" + this.txtCPMC.Text.Trim() + "%'";
						}
					}
					if (this.txtSCQY.Text.Trim() != "")
					{
						if (text == "")
						{
							text = "FMISPCNAME = '" + this.txtSCQY.Text.Trim() + "'";
						}
						else
						{
							text = text + " and FMISPCNAME = '" + this.txtSCQY.Text.Trim() + "'";
						}
					}
					DataRow[] array = this.dsT15.Tables["t15"].Select(text);
					DataTable dataTable = new DataTable();
					dataTable = this.tblResult.Clone();
					for (int i = 0; i < array.Length; i++)
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ZLBH"] = array[i]["ZLBH"];
						dataRow["BSBH"] = array[i]["BSBH"];
						dataRow["CPMC"] = array[i]["CPMC"];
						dataRow["FMISPCNAME"] = array[i]["FMISPCNAME"];
						dataRow["ZTMC"] = array[i]["ZTMC"];
						dataRow["SQRQ"] = array[i]["SQRQ"];
						dataTable.Rows.Add(dataRow);
					}
					this.tblResult = dataTable.Copy();
					DataView dataSource = new DataView(this.tblResult);
					this.gridControl1.DataSource = dataSource;
					this.Cursor = Cursors.Default;
					if (this.tblResult.Rows.Count == 0)
					{
						MessageBox.Show(this, "查询不到相关数据！\r\n请您重新输入简单正确条件后继续查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.txtZLBH.Focus();
					}
				}
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.txtZLBH.Text = "";
			this.txtZHSLH.Text = "";
			this.txtCPMC.Text = "";
			this.txtSCQY.Text = "";
			this.txtZLBH.Focus();
		}
		private void SetHeaders()
		{
			this.tblResult.Columns.Add("ZLBH");
			this.tblResult.Columns.Add("BSBH");
			this.tblResult.Columns.Add("CPMC");
			this.tblResult.Columns.Add("FMISPCNAME");
			this.tblResult.Columns.Add("ZTMC");
			this.tblResult.Columns.Add("SQRQ");
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
			this.gridView1.Columns[0].Caption = "资料编号";
			this.gridView1.Columns[0].FieldName = "ZLBH";
			this.gridView1.Columns[0].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[0].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[0].Width = 120;
			this.gridView1.Columns[0].Visible = true;
			this.gridView1.Columns[1].Caption = "综合受理号";
			this.gridView1.Columns[1].FieldName = "BSBH";
			this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[1].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[1].Width = 120;
			this.gridView1.Columns[2].Caption = "产品名称";
			this.gridView1.Columns[2].FieldName = "CPMC";
			this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[2].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[2].Width = 180;
			this.gridView1.Columns[3].Caption = "生产企业";
			this.gridView1.Columns[3].FieldName = "FMISPCNAME";
			this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[3].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[3].Width = 280;
			this.gridView1.Columns[4].Caption = "审批状态";
			this.gridView1.Columns[4].FieldName = "ZTMC";
			this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[4].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[4].Width = 100;
			this.gridView1.Columns[5].Caption = "受理日期";
			this.gridView1.Columns[5].FieldName = "SQRQ";
			this.gridView1.Columns[5].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[5].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[5].Width = 100;
		}
		private void frmSLCP_Load(object sender, EventArgs e)
		{
			this.initT15();
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.txtZLBH.Focus();
		}
		private void grvYXCF_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex < 0 && e.RowIndex >= 0)
			{
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
				Rectangle cellBounds = e.CellBounds;
				cellBounds.Inflate(-2, -2);
				TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), new Font("CHINESE_GB2312", 10f, FontStyle.Regular, GraphicsUnit.Point, 134), cellBounds, e.CellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
				e.Handled = true;
			}
		}
		private void grvYXCF_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.lblCount.Text = string.Concat(new object[]
				{
					"记录数：",
					e.RowIndex + 1,
					"/",
					this.intRowNum
				});
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
		private void frmSLCP_Resize(object sender, EventArgs e)
		{
			this.userManu1.navBarControl1.Height = this.panelmenu.Height - 2;
		}
	}
}
