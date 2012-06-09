using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmTJSYSPXX : Form
	{
		private string strCPMC = "";
		private string strCPBM = "";
		private DataSet dsT14 = new DataSet();
		private IContainer components = null;
		private Label lblQYMC;
		private DataGridView grvZWFZDXSPXX;
		private DataGridViewTextBoxColumn ZW;
		private DataGridViewTextBoxColumn FZDX;
		private DataGridViewTextBoxColumn SPZT;
		private Label lblSM;
		private Button btnClose;
		public frmTJSYSPXX(string strZLBH)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			clsStr clsStr = new clsStr();
			clsCommon clsCommon = new clsCommon();
			this.initT14();
			DataRow[] array = this.dsT14.Tables["t14"].Select("BH='" + strZLBH + "'");
			this.lblQYMC.Text = array[0]["QYMC"].ToString() + "：";
			this.strCPMC = array[0]["CPMC"].ToString();
			this.strCPBM = array[0]["CPBM"].ToString();
			DataTable dataTable = new DataTable();
			dataTable.TableName = "Result";
			dataTable.Columns.Add("ZW");
			dataTable.Columns.Add("FZDX");
			dataTable.Columns.Add("SPZT");
			string[] array2 = clsStr.Seperate(array[0]["ZW"].ToString(), '|');
			string[] array3 = clsStr.Seperate(array[0]["FZDX"].ToString(), '|');
			string[] array4 = clsStr.Seperate(array[0]["SPZT"].ToString(), '|');
			for (int i = 0; i < array2.Length; i++)
			{
				if (!(array2[i].ToString() == "") || !(array3[i].ToString() == ""))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ZW"] = array2[i];
					dataRow["FZDX"] = array3[i];
					string text = array4[i];
					if (text != null)
					{
						if (text == "1")
						{
							dataRow["SPZT"] = "同意";
						}
					}
					dataTable.Rows.Add(dataRow);
				}
			}
			this.grvZWFZDXSPXX.DataSource = dataTable;
		}
		private void initT14()
		{
			this.dsT14 = frmTJSY.dsT14;
		}
		private void lblSM_Paint(object sender, PaintEventArgs e)
		{
			float num = 2f;
			float num2 = num;
			float num3 = 2f;
			float num4 = 4f;
			float num5 = 2f;
			float width = e.Graphics.MeasureString("车", this.lblQYMC.Font).Width;
			float num6 = e.Graphics.MeasureString("车", this.lblQYMC.Font).Height + num5;
			float emSize = this.lblQYMC.Font.Size + 1f;
			SizeF sizeF = new SizeF(width, num6);
			Font font = new Font("宋体", emSize, FontStyle.Regular);
			Brush brush = new SolidBrush(Color.Black);
			brush = new SolidBrush(Color.Black);
			e.Graphics.DrawString("你公司申请的", font, brush, new PointF(num2, num3));
			sizeF = e.Graphics.MeasureString("你公司申请的", font);
			num2 += sizeF.Width;
			brush = new SolidBrush(Color.Red);
			e.Graphics.DrawString(this.strCPMC, font, brush, new PointF(num2 - num4, num3));
			sizeF = e.Graphics.MeasureString(this.strCPMC, font);
			num2 += sizeF.Width;
			brush = new SolidBrush(Color.Black);
			e.Graphics.DrawString("的药效试验申请，", font, brush, new PointF(num2 - num4, num3));
			num2 = num;
			brush = new SolidBrush(Color.Black);
			e.Graphics.DrawString("试验批准证号：", font, brush, new PointF(num2, num3 += num6));
			sizeF = e.Graphics.MeasureString("试验批准证号：", font);
			num2 += sizeF.Width;
			brush = new SolidBrush(Color.Red);
			e.Graphics.DrawString(this.strCPBM, font, brush, new PointF(num2 - num4, num3));
			num2 = num;
			brush = new SolidBrush(Color.Black);
			e.Graphics.DrawString("当前审批情况如下表：", font, brush, new PointF(num2, num3 + num6));
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmTJSYSPXX));
			this.lblQYMC = new Label();
			this.grvZWFZDXSPXX = new DataGridView();
			this.ZW = new DataGridViewTextBoxColumn();
			this.FZDX = new DataGridViewTextBoxColumn();
			this.SPZT = new DataGridViewTextBoxColumn();
			this.lblSM = new Label();
			this.btnClose = new Button();
			((ISupportInitialize)this.grvZWFZDXSPXX).BeginInit();
			base.SuspendLayout();
			this.lblQYMC.AutoSize = true;
			this.lblQYMC.Location = new Point(8, 4);
			this.lblQYMC.Name = "lblQYMC";
			this.lblQYMC.Size = new Size(0, 14);
			this.lblQYMC.TabIndex = 20;
			this.grvZWFZDXSPXX.AllowUserToAddRows = false;
			this.grvZWFZDXSPXX.AllowUserToDeleteRows = false;
			this.grvZWFZDXSPXX.AllowUserToResizeRows = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle.SelectionForeColor = SystemColors.InfoText;
			this.grvZWFZDXSPXX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.grvZWFZDXSPXX.BackgroundColor = SystemColors.Window;
			this.grvZWFZDXSPXX.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle2.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.grvZWFZDXSPXX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grvZWFZDXSPXX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvZWFZDXSPXX.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ZW,
				this.FZDX,
				this.SPZT
			});
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.InfoText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.grvZWFZDXSPXX.DefaultCellStyle = dataGridViewCellStyle3;
			this.grvZWFZDXSPXX.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.grvZWFZDXSPXX.Location = new Point(5, 83);
			this.grvZWFZDXSPXX.Name = "grvZWFZDXSPXX";
			this.grvZWFZDXSPXX.ReadOnly = true;
			this.grvZWFZDXSPXX.RowHeadersVisible = false;
			this.grvZWFZDXSPXX.RowHeadersWidth = 50;
			this.grvZWFZDXSPXX.RowTemplate.Height = 23;
			this.grvZWFZDXSPXX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.grvZWFZDXSPXX.ShowEditingIcon = false;
			this.grvZWFZDXSPXX.Size = new Size(423, 119);
			this.grvZWFZDXSPXX.TabIndex = 19;
			this.ZW.DataPropertyName = "ZW";
			this.ZW.HeaderText = "作物";
			this.ZW.Name = "ZW";
			this.ZW.ReadOnly = true;
			this.ZW.Width = 150;
			this.FZDX.DataPropertyName = "FZDX";
			this.FZDX.HeaderText = "防治对象";
			this.FZDX.Name = "FZDX";
			this.FZDX.ReadOnly = true;
			this.FZDX.Width = 150;
			this.SPZT.DataPropertyName = "SPZT";
			this.SPZT.HeaderText = "审批结果";
			this.SPZT.Name = "SPZT";
			this.SPZT.ReadOnly = true;
			this.SPZT.Width = 120;
			this.lblSM.Location = new Point(7, 24);
			this.lblSM.Name = "lblSM";
			this.lblSM.Size = new Size(416, 53);
			this.lblSM.TabIndex = 24;
			this.lblSM.Paint += new PaintEventHandler(this.lblSM_Paint);
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(150, 216);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 25;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(434, 256);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.lblSM);
			base.Controls.Add(this.lblQYMC);
			base.Controls.Add(this.grvZWFZDXSPXX);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(442, 290);
			this.MinimumSize = new Size(442, 290);
			base.Name = "frmTJSYSPXX";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "田间试验审批情况";
			((ISupportInitialize)this.grvZWFZDXSPXX).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
