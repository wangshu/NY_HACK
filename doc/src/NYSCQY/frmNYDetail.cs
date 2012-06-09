using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmNYDetail : Form
	{
		private IContainer components = null;
		private Button btnPrint;
		private Panel panel1;
		private TextBox txtDJZH;
		private Label label1;
		private Button btnClose;
		private TextBox txtXKZH;
		private Label label10;
		private TextBox txtQYBZ;
		private Label label9;
		private TextBox txtNYLB;
		private Label label8;
		private TextBox txtDWMC;
		private Label label7;
		private TextBox txtJX;
		private Label label6;
		private TextBox txtDX;
		private Label label5;
		private TextBox txtDJMC;
		private Label label4;
		private TextBox txtYXJZRQ;
		private Label label3;
		private TextBox txtYXQSRQ;
		private Label label2;
		private DataGridView grvYXCF;
		private DataGridView grvZWFZDX;
		private DataGridViewTextBoxColumn E2;
		private DataGridViewTextBoxColumn E3;
		private DataGridViewTextBoxColumn R7;
		private DataGridViewTextBoxColumn C2;
		private DataGridViewTextBoxColumn T2;
		private DataGridViewTextBoxColumn R10;
		private DataGridViewTextBoxColumn R14;
		private PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
		private int pagesize = 12;
		private int curpage = 0;
		private int startrow = 0;
		private int pages = 1;
		private string strF8 = "";
		private string strF14 = "";
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmNYDetail));
			this.btnPrint = new Button();
			this.panel1 = new Panel();
			this.txtXKZH = new TextBox();
			this.label10 = new Label();
			this.txtQYBZ = new TextBox();
			this.label9 = new Label();
			this.txtNYLB = new TextBox();
			this.label8 = new Label();
			this.txtDWMC = new TextBox();
			this.label7 = new Label();
			this.txtJX = new TextBox();
			this.label6 = new Label();
			this.txtDX = new TextBox();
			this.label5 = new Label();
			this.txtDJMC = new TextBox();
			this.label4 = new Label();
			this.txtYXJZRQ = new TextBox();
			this.label3 = new Label();
			this.txtYXQSRQ = new TextBox();
			this.label2 = new Label();
			this.txtDJZH = new TextBox();
			this.label1 = new Label();
			this.btnClose = new Button();
			this.grvYXCF = new DataGridView();
			this.E2 = new DataGridViewTextBoxColumn();
			this.E3 = new DataGridViewTextBoxColumn();
			this.R7 = new DataGridViewTextBoxColumn();
			this.grvZWFZDX = new DataGridView();
			this.C2 = new DataGridViewTextBoxColumn();
			this.T2 = new DataGridViewTextBoxColumn();
			this.R10 = new DataGridViewTextBoxColumn();
			this.R14 = new DataGridViewTextBoxColumn();
			this.printDocument1 = new PrintDocument();
			this.printPreviewDialog1 = new PrintPreviewDialog();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.grvYXCF).BeginInit();
			((ISupportInitialize)this.grvZWFZDX).BeginInit();
			base.SuspendLayout();
			this.btnPrint.Font = new Font("宋体", 10.5f);
			this.btnPrint.Location = new Point(167, 423);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new Size(113, 29);
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "打印预览";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
			this.panel1.Controls.Add(this.txtXKZH);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtQYBZ);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtNYLB);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtDWMC);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtJX);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtDX);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtDJMC);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtYXJZRQ);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtYXQSRQ);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtDJZH);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(594, 124);
			this.panel1.TabIndex = 2;
			this.txtXKZH.Location = new Point(131, 92);
			this.txtXKZH.Name = "txtXKZH";
			this.txtXKZH.Size = new Size(167, 23);
			this.txtXKZH.TabIndex = 19;
			this.label10.AutoSize = true;
			this.label10.Location = new Point(5, 97);
			this.label10.Name = "label10";
			this.label10.Size = new Size(126, 14);
			this.label10.TabIndex = 18;
			this.label10.Text = "生产批准/许可证号";
			this.txtQYBZ.Location = new Point(426, 92);
			this.txtQYBZ.Name = "txtQYBZ";
			this.txtQYBZ.Size = new Size(167, 23);
			this.txtQYBZ.TabIndex = 17;
			this.label9.AutoSize = true;
			this.label9.Location = new Point(301, 97);
			this.label9.Name = "label9";
			this.label9.Size = new Size(126, 14);
			this.label9.TabIndex = 16;
			this.label9.Text = "执行标准/企业标准";
			this.txtNYLB.Location = new Point(467, 62);
			this.txtNYLB.Name = "txtNYLB";
			this.txtNYLB.Size = new Size(126, 23);
			this.txtNYLB.TabIndex = 15;
			this.label8.AutoSize = true;
			this.label8.Location = new Point(406, 67);
			this.label8.Name = "label8";
			this.label8.Size = new Size(63, 14);
			this.label8.TabIndex = 14;
			this.label8.Text = "农药类别";
			this.txtDWMC.BackColor = SystemColors.Window;
			this.txtDWMC.Cursor = Cursors.Hand;
			this.txtDWMC.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.txtDWMC.ForeColor = Color.Blue;
			this.txtDWMC.Location = new Point(67, 62);
			this.txtDWMC.Name = "txtDWMC";
			this.txtDWMC.ReadOnly = true;
			this.txtDWMC.Size = new Size(325, 23);
			this.txtDWMC.TabIndex = 13;
			this.txtDWMC.MouseUp += new MouseEventHandler(this.txtDWMC_MouseUp);
			this.label7.AutoSize = true;
			this.label7.Location = new Point(5, 67);
			this.label7.Name = "label7";
			this.label7.Size = new Size(63, 14);
			this.label7.TabIndex = 12;
			this.label7.Text = "单位名称";
			this.txtJX.Location = new Point(467, 33);
			this.txtJX.Name = "txtJX";
			this.txtJX.Size = new Size(126, 23);
			this.txtJX.TabIndex = 11;
			this.label6.AutoSize = true;
			this.label6.Location = new Point(434, 38);
			this.label6.Name = "label6";
			this.label6.Size = new Size(35, 14);
			this.label6.TabIndex = 10;
			this.label6.Text = "剂型";
			this.txtDX.Location = new Point(268, 33);
			this.txtDX.Name = "txtDX";
			this.txtDX.Size = new Size(124, 23);
			this.txtDX.TabIndex = 9;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(235, 38);
			this.label5.Name = "label5";
			this.label5.Size = new Size(35, 14);
			this.label5.TabIndex = 8;
			this.label5.Text = "毒性";
			this.txtDJMC.Location = new Point(67, 33);
			this.txtDJMC.Name = "txtDJMC";
			this.txtDJMC.Size = new Size(126, 23);
			this.txtDJMC.TabIndex = 7;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(5, 38);
			this.label4.Name = "label4";
			this.label4.Size = new Size(63, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "登记名称";
			this.txtYXJZRQ.Location = new Point(467, 4);
			this.txtYXJZRQ.Name = "txtYXJZRQ";
			this.txtYXJZRQ.Size = new Size(126, 23);
			this.txtYXJZRQ.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(392, 9);
			this.label3.Name = "label3";
			this.label3.Size = new Size(77, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "有效截止日";
			this.txtYXQSRQ.Location = new Point(268, 4);
			this.txtYXQSRQ.Name = "txtYXQSRQ";
			this.txtYXQSRQ.Size = new Size(124, 23);
			this.txtYXQSRQ.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(193, 9);
			this.label2.Name = "label2";
			this.label2.Size = new Size(77, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "有效起始日";
			this.txtDJZH.Location = new Point(67, 4);
			this.txtDJZH.Name = "txtDJZH";
			this.txtDJZH.Size = new Size(126, 23);
			this.txtDJZH.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "登记证号";
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(302, 423);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.grvYXCF.AllowUserToAddRows = false;
			this.grvYXCF.AllowUserToDeleteRows = false;
			this.grvYXCF.AllowUserToResizeRows = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle.SelectionForeColor = SystemColors.InfoText;
			this.grvYXCF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.grvYXCF.BackgroundColor = SystemColors.Window;
			this.grvYXCF.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle2.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.grvYXCF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grvYXCF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvYXCF.Columns.AddRange(new DataGridViewColumn[]
			{
				this.E2,
				this.E3,
				this.R7
			});
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.InfoText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.grvYXCF.DefaultCellStyle = dataGridViewCellStyle3;
			this.grvYXCF.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.grvYXCF.Location = new Point(3, 131);
			this.grvYXCF.Name = "grvYXCF";
			this.grvYXCF.ReadOnly = true;
			this.grvYXCF.RowHeadersVisible = false;
			this.grvYXCF.RowHeadersWidth = 50;
			this.grvYXCF.RowTemplate.Height = 23;
			this.grvYXCF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.grvYXCF.ShowEditingIcon = false;
			this.grvYXCF.Size = new Size(595, 140);
			this.grvYXCF.TabIndex = 9;
			this.grvYXCF.CellMouseUp += new DataGridViewCellMouseEventHandler(this.grvYXCF_CellMouseUp);
			this.E2.DataPropertyName = "E2";
			dataGridViewCellStyle4.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			dataGridViewCellStyle4.ForeColor = Color.Blue;
			this.E2.DefaultCellStyle = dataGridViewCellStyle4;
			this.E2.HeaderText = "有效成分中文名称";
			this.E2.Name = "E2";
			this.E2.ReadOnly = true;
			this.E2.Width = 230;
			this.E3.DataPropertyName = "E3";
			this.E3.HeaderText = "有效成分英文名称";
			this.E3.Name = "E3";
			this.E3.ReadOnly = true;
			this.E3.Width = 230;
			this.R7.DataPropertyName = "R7";
			this.R7.HeaderText = "含量";
			this.R7.Name = "R7";
			this.R7.ReadOnly = true;
			this.grvZWFZDX.AllowUserToAddRows = false;
			this.grvZWFZDX.AllowUserToDeleteRows = false;
			this.grvZWFZDX.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.InfoText;
			this.grvZWFZDX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.grvZWFZDX.BackgroundColor = SystemColors.Window;
			this.grvZWFZDX.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle6.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.grvZWFZDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.grvZWFZDX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvZWFZDX.Columns.AddRange(new DataGridViewColumn[]
			{
				this.C2,
				this.T2,
				this.R10,
				this.R14
			});
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = SystemColors.Window;
			dataGridViewCellStyle7.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.InfoText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
			this.grvZWFZDX.DefaultCellStyle = dataGridViewCellStyle7;
			this.grvZWFZDX.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.grvZWFZDX.Location = new Point(4, 277);
			this.grvZWFZDX.Name = "grvZWFZDX";
			this.grvZWFZDX.ReadOnly = true;
			this.grvZWFZDX.RowHeadersVisible = false;
			this.grvZWFZDX.RowHeadersWidth = 50;
			this.grvZWFZDX.RowTemplate.Height = 23;
			this.grvZWFZDX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.grvZWFZDX.ShowEditingIcon = false;
			this.grvZWFZDX.Size = new Size(595, 140);
			this.grvZWFZDX.TabIndex = 10;
			this.C2.DataPropertyName = "C2";
			this.C2.HeaderText = "作物";
			this.C2.Name = "C2";
			this.C2.ReadOnly = true;
			this.C2.Width = 120;
			this.T2.DataPropertyName = "T2";
			this.T2.HeaderText = "防治对象";
			this.T2.Name = "T2";
			this.T2.ReadOnly = true;
			this.T2.Width = 120;
			this.R10.DataPropertyName = "R10";
			this.R10.HeaderText = "有效成分用药量";
			this.R10.Name = "R10";
			this.R10.ReadOnly = true;
			this.R10.Width = 220;
			this.R14.DataPropertyName = "R14";
			this.R14.HeaderText = "施用方法";
			this.R14.Name = "R14";
			this.R14.ReadOnly = true;
			this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
			this.printDocument1.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
			this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
			this.printPreviewDialog1.ClientSize = new Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			this.printPreviewDialog1.Load += new EventHandler(this.printPreviewDialog1_Load);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(602, 456);
			base.Controls.Add(this.grvZWFZDX);
			base.Controls.Add(this.grvYXCF);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.btnPrint);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(610, 490);
			this.MinimumSize = new Size(610, 490);
			base.Name = "frmNYDetail";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "农药信息";
			base.Load += new EventHandler(this.frmNYDetail_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.grvYXCF).EndInit();
			((ISupportInitialize)this.grvZWFZDX).EndInit();
			base.ResumeLayout(false);
		}
		public frmNYDetail(string strR1, string strF8, string strF14)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.strF8 = strF8;
			this.strF14 = strF14;
			clsStr clsStr = new clsStr();
			DataRow[] array = MDIParent.dsP.Tables["P"].Select("R1='" + strR1 + "'");
			this.txtDJZH.Text = array[0]["R1"].ToString();
			this.txtYXQSRQ.Text = array[0]["R4"].ToString();
			this.txtYXJZRQ.Text = array[0]["R5"].ToString();
			this.txtDJMC.Text = array[0]["R2"].ToString();
			this.txtDX.Text = array[0]["R11"].ToString();
			this.txtJX.Text = array[0]["R13"].ToString();
			this.txtDWMC.Text = array[0]["F2"].ToString();
			this.txtNYLB.Text = array[0]["R12"].ToString();
			this.txtXKZH.Text = array[0]["R80"].ToString();
			this.txtQYBZ.Text = array[0]["R90"].ToString();
			DataTable dataTable = new DataTable();
			dataTable.TableName = "Result1";
			dataTable.Columns.Add("E2");
			dataTable.Columns.Add("E3");
			dataTable.Columns.Add("R7");
			string[] array2 = clsStr.Seperate(array[0]["E2"].ToString(), '、');
			string[] array3 = clsStr.Seperate(array[0]["E3"].ToString(), '、');
			string[] array4 = clsStr.Seperate(array[0]["R7"].ToString(), '、');
			for (int i = 0; i < array2.Length; i++)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["E2"] = array2[i];
				dataRow["E3"] = array3[i];
				dataRow["R7"] = array4[i];
				dataTable.Rows.Add(dataRow);
			}
			this.grvYXCF.DataSource = dataTable;
			DataTable dataTable2 = new DataTable();
			dataTable2.TableName = "Result2";
			dataTable2.Columns.Add("C2");
			dataTable2.Columns.Add("T2");
			dataTable2.Columns.Add("R10");
			dataTable2.Columns.Add("R14");
			string[] array5 = clsStr.Seperate(array[0]["C2"].ToString(), '|');
			string[] array6 = clsStr.Seperate(array[0]["T2"].ToString(), '|');
			string[] array7 = clsStr.Seperate(array[0]["R10"].ToString(), '|');
			string[] array8 = clsStr.Seperate(array[0]["R14"].ToString(), '|');
			for (int i = 0; i < array5.Length; i++)
			{
				if (!(array5[i].ToString() == "") || !(array6[i].ToString() == ""))
				{
					DataRow dataRow = dataTable2.NewRow();
					dataRow["C2"] = array5[i];
					dataRow["T2"] = array6[i];
					dataRow["R10"] = array7[i];
					dataRow["R14"] = array8[i];
					dataTable2.Rows.Add(dataRow);
				}
			}
			this.grvZWFZDX.DataSource = dataTable2;
			this.pages = ((DataTable)this.grvZWFZDX.DataSource).Rows.Count / (this.pagesize + 1);
			if (this.pages * (this.pagesize + 1) != ((DataTable)this.grvZWFZDX.DataSource).Rows.Count)
			{
				this.pages++;
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void txtDWMC_MouseUp(object sender, MouseEventArgs e)
		{
			frmQYDetail frmQYDetail = new frmQYDetail(this.txtDWMC.Text.Trim(), "", "");
			frmQYDetail.ShowDialog();
		}
		private void grvYXCF_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.grvYXCF.Columns[e.ColumnIndex].DataPropertyName == "E2")
			{
				frmYXCFDetail frmYXCFDetail = new frmYXCFDetail(this.grvYXCF.CurrentCell.Value.ToString().Trim(), this.grvYXCF.Rows[this.grvYXCF.CurrentCell.RowIndex].Cells["E3"].Value.ToString().Trim());
				frmYXCFDetail.ShowDialog();
			}
		}
		private void frmNYDetail_Load(object sender, EventArgs e)
		{
			if (this.grvYXCF.Rows.Count > 0)
			{
				this.grvYXCF.Rows[0].Selected = false;
			}
			if (this.grvZWFZDX.Rows.Count > 0)
			{
				this.grvZWFZDX.Rows[0].Selected = false;
			}
		}
		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				this.printPreviewDialog1.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			int num = 15;
			int num2 = 80;
			int num3 = 80;
			int num4 = 3;
			int num5 = 25;
			int num6 = 650;
			int num7 = 25;
			int num8 = num6 / 2 - 100;
			Image image = Image.FromFile(Directory.GetCurrentDirectory() + "\\adv\\logo.GIF");
			int x = 0;
			int y = 0;
			e.Graphics.DrawImageUnscaled(image, x, y);
			PaintEventArgs paintEventArgs = new PaintEventArgs(e.Graphics, new Rectangle(num2, num3, 800, 30));
			e.Graphics.DrawString("农药登记详细信息", new Font("宋体", (float)(num + 5), FontStyle.Bold), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num6 / 2 - 120, num3 - 45, num6, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3, num6, num7);
			e.Graphics.DrawString("登记证号", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtDJZH.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("有效起始日", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtYXQSRQ.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("有效截止日", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtYXJZRQ.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("登记名称", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtDJMC.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("毒性", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtDX.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("剂型", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtJX.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("生产厂家", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtDWMC.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("农药类别", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtNYLB.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("执行标准/企业标准", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtQYBZ.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
			e.Graphics.DrawString("生产批准/许可证号", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString(this.txtXKZH.Text.Trim(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			paintEventArgs.Graphics.DrawLine(new Pen(Color.Black), num2 + num8, 80, num2 + num8, 330);
			num8 = num6 / 3;
			int num9 = num3 + num5 + 20;
			num9 += 25;
			e.Graphics.DrawString("有效成分", new Font("宋体", (float)(num + 5), FontStyle.Bold), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num6 / 2 - 60, num3 + 30, num6, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5 + 20 + 25, num6, num7);
			e.Graphics.DrawString("有效成分中文名", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString("有效成分英文名", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8 + 100, num7));
			e.Graphics.DrawString("含量", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8 * 2 + 100, num3 + num4, num6 - num8 - 100, num7));
			for (int i = 0; i < ((DataTable)this.grvYXCF.DataSource).Rows.Count; i++)
			{
				paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7);
				e.Graphics.DrawString(this.grvYXCF[0, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
				e.Graphics.DrawString(this.grvYXCF[1, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
				e.Graphics.DrawString(this.grvYXCF[2, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8 * 2 + 100, num3 + num4, num6 - num8 - 100, num7));
			}
			paintEventArgs.Graphics.DrawLine(new Pen(Color.Black), num2 + num8, num9, num2 + num8, num9 + 25 * (((DataTable)this.grvYXCF.DataSource).Rows.Count + 1));
			paintEventArgs.Graphics.DrawLine(new Pen(Color.Black), num2 + num8 * 2 + 100, num9, num2 + num8 * 2 + 100, num9 + 25 * (((DataTable)this.grvYXCF.DataSource).Rows.Count + 1));
			num8 = num6 / 4;
			num9 = num3 + num5 + 20;
			num9 += 25;
			e.Graphics.DrawString("作物、防治对象", new Font("宋体", (float)(num + 5), FontStyle.Bold), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num6 / 2 - 90, num3 + 30, num6, num7));
			paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5 + 20 + 25, num6, num7);
			e.Graphics.DrawString("作物", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, num8, num7));
			e.Graphics.DrawString("防治对象", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, num6 - num8, num7));
			e.Graphics.DrawString("有效成分用量", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8 * 2, num3 + num4, num6 - num8, num7));
			e.Graphics.DrawString("施用方法", new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8 * 3 + 60, num3 + num4, num6 - num8 - 60, num7));
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			this.curpage++;
			for (int i = this.startrow; i < ((DataTable)this.grvZWFZDX.DataSource).Rows.Count; i++)
			{
				byte[] bytes = Encoding.Default.GetBytes(this.grvZWFZDX[0, i].Value.ToString());
				byte[] bytes2 = Encoding.Default.GetBytes(this.grvZWFZDX[1, i].Value.ToString());
				byte[] bytes3 = Encoding.Default.GetBytes(this.grvZWFZDX[2, i].Value.ToString());
				byte[] bytes4 = Encoding.Default.GetBytes(this.grvZWFZDX[3, i].Value.ToString());
				int num13;
				if (Math.Max(Math.Max(bytes.Length, bytes2.Length), Math.Max(bytes3.Length, bytes4.Length)) % 14 == 0)
				{
					num13 = Math.Max(Math.Max(bytes.Length, bytes2.Length), Math.Max(bytes3.Length, bytes4.Length)) / 14;
				}
				else
				{
					num13 = Math.Max(Math.Max(bytes.Length, bytes2.Length), Math.Max(bytes3.Length, bytes4.Length)) / 14 + 1;
				}
				if (i % (this.pagesize + 1) == 0)
				{
					paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5, num6, num7 * num13);
				}
				else
				{
					paintEventArgs.Graphics.DrawRectangle(new Pen(Color.Black), num2, num3 += num5 * num11, num6, num7 * num13);
				}
				e.Graphics.DrawString(this.grvZWFZDX[0, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2, num3 + num4, 162, num7 * num13));
				e.Graphics.DrawString(this.grvZWFZDX[1, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8, num3 + num4, 162, num7 * num13));
				e.Graphics.DrawString(this.grvZWFZDX[2, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8 * 2, num3 + num4, 222, num7 * num13));
				e.Graphics.DrawString(this.grvZWFZDX[3, i].Value.ToString(), new Font("宋体", (float)num, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(num2 + num8 * 3 + 60, num3 + num4, 104, num7 * num13));
				num10 += num13;
				num11 = num13;
				num12++;
				if (num12 > this.pagesize)
				{
					break;
				}
			}
			paintEventArgs.Graphics.DrawLine(new Pen(Color.Black), num2 + num8, num9, num2 + num8, num9 + num10 * 25 + 25);
			paintEventArgs.Graphics.DrawLine(new Pen(Color.Black), num2 + num8 * 2, num9, num2 + num8 * 2, num9 + num10 * 25 + 25);
			paintEventArgs.Graphics.DrawLine(new Pen(Color.Black), num2 + num8 * 3 + 60, num9, num2 + num8 * 3 + 60, num9 + num10 * 25 + 25);
			e.Graphics.DrawString(string.Concat(new string[]
			{
				"第[",
				this.curpage.ToString(),
				"]页,共[",
				this.pages.ToString(),
				"]页"
			}), new Font("宋体", 10f, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), 700f, 1150f);
			if (((DataTable)this.grvZWFZDX.DataSource).Rows.Count - this.curpage * this.pagesize > 0)
			{
				this.startrow = this.curpage * this.pagesize + 1;
				e.HasMorePages = true;
			}
			else
			{
				e.HasMorePages = false;
			}
		}
		private void printPreviewDialog1_Load(object sender, EventArgs e)
		{
			this.printPreviewDialog1.WindowState = FormWindowState.Maximized;
			((PrintPreviewControl)this.printPreviewDialog1.Controls[0]).Zoom = 1.0;
		}
		private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.curpage = 0;
			this.startrow = 0;
		}
	}
}
