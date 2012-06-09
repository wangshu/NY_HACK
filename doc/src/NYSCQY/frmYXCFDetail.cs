using NYSCQY.YXCF;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmYXCFDetail : Form
	{
		private string strE1 = "";
		private string strLHXZ = "";
		private string strDX = "";
		private string strZYTD = "";
		private string strHJ = "";
		private string strJXY = "";
		private IContainer components = null;
		private Panel panel1;
		private TextBox txtHXMC;
		private Label label12;
		private TextBox txtZYFS;
		private Label label8;
		private TextBox txtChTYMC;
		private Label label7;
		private TextBox txtHXFL;
		private Label label6;
		private TextBox txtEnBM;
		private Label label5;
		private TextBox txtEnTYMC;
		private Label label4;
		private TextBox txtCADJH;
		private Label label3;
		private Button btnPrint;
		private Button btnClose;
		private TextBox txtChBM;
		private Label label15;
		private TextBox txtZYSX;
		private Label label2;
		private TextBox txtFXFF;
		private Label label1;
		private Button btnJGS;
		private Button btnLHXX;
		private Button btnDX;
		private Button txtZYTD;
		private Button btnJXY;
		private Button btnHYGYXCFY;
		private Button btnHJ;
		private TextBox txtNYLB;
		private Label label9;
		private TextBox txtFZS;
		private Label label10;
		public frmYXCFDetail(string strE2, string strE3)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			string filterExpression;
			if (strE3.Length <= 0)
			{
				filterExpression = "E2='" + strE2 + "'";
			}
			else
			{
				filterExpression = string.Concat(new string[]
				{
					"E2='",
					strE2,
					"' and E3='",
					strE3,
					"'"
				});
			}
			DataRow[] array = MDIParent.dsAED.Tables["AED"].Select(filterExpression);
			this.strE1 = array[0]["E1"].ToString();
			this.strLHXZ = array[0]["E9"].ToString().Trim();
			this.strDX = array[0]["E16"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E17"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E18"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E15"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E13"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E14"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E23"].ToString().Trim();
			this.strDX = this.strDX + "|" + array[0]["E24"].ToString().Trim();
			this.strZYTD = array[0]["E12"].ToString().Trim();
			this.strHJ = array[0]["E25"].ToString().Trim();
			this.strHJ = this.strHJ + "|" + array[0]["E26"].ToString().Trim();
			this.strHJ = this.strHJ + "|" + array[0]["E27"].ToString().Trim();
			this.strHJ = this.strHJ + "|" + array[0]["E28"].ToString().Trim();
			this.strJXY = array[0]["E19"].ToString().Trim();
			this.strJXY = this.strJXY + "|" + array[0]["E20"].ToString().Trim();
			this.strJXY = this.strJXY + "|" + array[0]["E21"].ToString().Trim();
			this.txtChTYMC.Text = array[0]["E2"].ToString();
			this.txtChBM.Text = array[0]["E4"].ToString();
			this.txtEnTYMC.Text = array[0]["E3"].ToString();
			this.txtEnBM.Text = array[0]["E5"].ToString();
			this.txtFZS.Text = array[0]["E6"].ToString();
			this.txtCADJH.Text = array[0]["E8"].ToString();
			this.txtZYFS.Text = array[0]["E11"].ToString();
			this.txtHXMC.Text = array[0]["E7"].ToString();
			this.txtFXFF.Text = array[0]["E10"].ToString();
			this.txtNYLB.Text = array[0]["E29"].ToString();
			this.txtHXFL.Text = array[0]["E30"].ToString();
			this.txtZYSX.Text = array[0]["E18"].ToString();
		}
		private void btnHYGYXCFY_Click(object sender, EventArgs e)
		{
			frmNYList frmNYList = new frmNYList("YXCF", this.txtChTYMC.Text.Trim() + "|" + this.txtEnTYMC.Text.Trim());
			frmNYList.ShowDialog();
		}
		private void btnJGS_Click(object sender, EventArgs e)
		{
			if (File.Exists(Directory.GetCurrentDirectory() + "\\JGS\\" + this.strE1 + ".bmp"))
			{
				frmJGS frmJGS = new frmJGS(this.strE1);
				frmJGS.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "无结构式记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void btnLHXX_Click(object sender, EventArgs e)
		{
			if (this.strLHXZ != "")
			{
				frmLHXZ frmLHXZ = new frmLHXZ(this.strLHXZ);
				frmLHXZ.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "无理化性质记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void btnDX_Click(object sender, EventArgs e)
		{
			if (this.strDX.Replace("|", "") != "")
			{
				frmDX frmDX = new frmDX(this.strDX);
				frmDX.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "无毒性记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void txtZYTD_Click(object sender, EventArgs e)
		{
			if (this.strZYTD != "")
			{
				frmZYTD frmZYTD = new frmZYTD(this.strZYTD);
				frmZYTD.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "无作用特点记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void btnHJ_Click(object sender, EventArgs e)
		{
			if (this.strHJ.Replace("|", "") != "")
			{
				frmHJ frmHJ = new frmHJ(this.strHJ);
				frmHJ.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "无环境记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void btnJXY_Click(object sender, EventArgs e)
		{
			if (this.strJXY.Replace("|", "") != "")
			{
				frmJXYDetail frmJXYDetail = new frmJXYDetail(this.strJXY);
				frmJXYDetail.ShowDialog();
			}
			else
			{
				MessageBox.Show(this, "无禁限用记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmYXCFDetail));
			this.panel1 = new Panel();
			this.txtNYLB = new TextBox();
			this.label9 = new Label();
			this.txtFZS = new TextBox();
			this.label10 = new Label();
			this.txtZYSX = new TextBox();
			this.label2 = new Label();
			this.txtFXFF = new TextBox();
			this.label1 = new Label();
			this.txtChBM = new TextBox();
			this.label15 = new Label();
			this.txtHXMC = new TextBox();
			this.label12 = new Label();
			this.txtZYFS = new TextBox();
			this.label8 = new Label();
			this.txtChTYMC = new TextBox();
			this.label7 = new Label();
			this.txtHXFL = new TextBox();
			this.label6 = new Label();
			this.txtEnBM = new TextBox();
			this.label5 = new Label();
			this.txtEnTYMC = new TextBox();
			this.label4 = new Label();
			this.txtCADJH = new TextBox();
			this.label3 = new Label();
			this.btnPrint = new Button();
			this.btnClose = new Button();
			this.btnJGS = new Button();
			this.btnLHXX = new Button();
			this.btnDX = new Button();
			this.txtZYTD = new Button();
			this.btnJXY = new Button();
			this.btnHYGYXCFY = new Button();
			this.btnHJ = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.txtNYLB);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtFZS);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtZYSX);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtFXFF);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnPrint);
			this.panel1.Controls.Add(this.txtChBM);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.txtHXMC);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txtZYFS);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtChTYMC);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtHXFL);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtEnBM);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtEnTYMC);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtCADJH);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new Point(4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(507, 297);
			this.panel1.TabIndex = 8;
			this.txtNYLB.Location = new Point(330, 61);
			this.txtNYLB.Name = "txtNYLB";
			this.txtNYLB.Size = new Size(168, 23);
			this.txtNYLB.TabIndex = 35;
			this.label9.AutoSize = true;
			this.label9.Location = new Point(266, 68);
			this.label9.Name = "label9";
			this.label9.Size = new Size(63, 14);
			this.label9.TabIndex = 34;
			this.label9.Text = "农药类别";
			this.txtFZS.Location = new Point(93, 61);
			this.txtFZS.Name = "txtFZS";
			this.txtFZS.Size = new Size(168, 23);
			this.txtFZS.TabIndex = 33;
			this.label10.AutoSize = true;
			this.label10.Location = new Point(31, 68);
			this.label10.Name = "label10";
			this.label10.Size = new Size(49, 14);
			this.label10.TabIndex = 32;
			this.label10.Text = "分子式";
			this.txtZYSX.Location = new Point(93, 240);
			this.txtZYSX.Multiline = true;
			this.txtZYSX.Name = "txtZYSX";
			this.txtZYSX.Size = new Size(405, 46);
			this.txtZYSX.TabIndex = 31;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(31, 255);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 14);
			this.label2.TabIndex = 30;
			this.label2.Text = "注意事项";
			this.txtFXFF.Location = new Point(93, 190);
			this.txtFXFF.Multiline = true;
			this.txtFXFF.Name = "txtFXFF";
			this.txtFXFF.Size = new Size(405, 46);
			this.txtFXFF.TabIndex = 29;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(31, 205);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 28;
			this.label1.Text = "分析方法";
			this.txtChBM.Location = new Point(330, 9);
			this.txtChBM.Name = "txtChBM";
			this.txtChBM.Size = new Size(168, 23);
			this.txtChBM.TabIndex = 27;
			this.label15.AutoSize = true;
			this.label15.Location = new Point(266, 14);
			this.label15.Name = "label15";
			this.label15.Size = new Size(63, 14);
			this.label15.TabIndex = 26;
			this.label15.Text = "中文别名";
			this.txtHXMC.Location = new Point(93, 140);
			this.txtHXMC.Multiline = true;
			this.txtHXMC.Name = "txtHXMC";
			this.txtHXMC.Size = new Size(405, 46);
			this.txtHXMC.TabIndex = 21;
			this.label12.AutoSize = true;
			this.label12.Location = new Point(31, 155);
			this.label12.Name = "label12";
			this.label12.Size = new Size(63, 14);
			this.label12.TabIndex = 20;
			this.label12.Text = "化学名称";
			this.txtZYFS.Location = new Point(93, 114);
			this.txtZYFS.Name = "txtZYFS";
			this.txtZYFS.Size = new Size(405, 23);
			this.txtZYFS.TabIndex = 15;
			this.label8.AutoSize = true;
			this.label8.Location = new Point(31, 120);
			this.label8.Name = "label8";
			this.label8.Size = new Size(63, 14);
			this.label8.TabIndex = 14;
			this.label8.Text = "作用方式";
			this.txtChTYMC.Location = new Point(93, 9);
			this.txtChTYMC.Name = "txtChTYMC";
			this.txtChTYMC.Size = new Size(168, 23);
			this.txtChTYMC.TabIndex = 13;
			this.label7.AutoSize = true;
			this.label7.Location = new Point(3, 14);
			this.label7.Name = "label7";
			this.label7.Size = new Size(91, 14);
			this.label7.TabIndex = 12;
			this.label7.Text = "中文通用名称";
			this.txtHXFL.Location = new Point(330, 88);
			this.txtHXFL.Name = "txtHXFL";
			this.txtHXFL.Size = new Size(168, 23);
			this.txtHXFL.TabIndex = 11;
			this.label6.AutoSize = true;
			this.label6.Location = new Point(266, 95);
			this.label6.Name = "label6";
			this.label6.Size = new Size(63, 14);
			this.label6.TabIndex = 10;
			this.label6.Text = "化学分类";
			this.txtEnBM.Location = new Point(330, 35);
			this.txtEnBM.Name = "txtEnBM";
			this.txtEnBM.Size = new Size(168, 23);
			this.txtEnBM.TabIndex = 9;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(266, 39);
			this.label5.Name = "label5";
			this.label5.Size = new Size(63, 14);
			this.label5.TabIndex = 8;
			this.label5.Text = "英文别名";
			this.txtEnTYMC.Location = new Point(93, 35);
			this.txtEnTYMC.Name = "txtEnTYMC";
			this.txtEnTYMC.Size = new Size(168, 23);
			this.txtEnTYMC.TabIndex = 7;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(3, 39);
			this.label4.Name = "label4";
			this.label4.Size = new Size(91, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "英文通用名称";
			this.txtCADJH.Location = new Point(93, 88);
			this.txtCADJH.Name = "txtCADJH";
			this.txtCADJH.Size = new Size(168, 23);
			this.txtCADJH.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(31, 95);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "CA登记号";
			this.btnPrint.Location = new Point(20, 229);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new Size(23, 23);
			this.btnPrint.TabIndex = 9;
			this.btnPrint.Text = "打印预览";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Visible = false;
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(377, 344);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.btnJGS.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnJGS.Location = new Point(29, 309);
			this.btnJGS.Name = "btnJGS";
			this.btnJGS.Size = new Size(113, 29);
			this.btnJGS.TabIndex = 11;
			this.btnJGS.Text = "结构式";
			this.btnJGS.UseVisualStyleBackColor = true;
			this.btnJGS.Click += new EventHandler(this.btnJGS_Click);
			this.btnLHXX.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnLHXX.Location = new Point(145, 309);
			this.btnLHXX.Name = "btnLHXX";
			this.btnLHXX.Size = new Size(113, 29);
			this.btnLHXX.TabIndex = 12;
			this.btnLHXX.Text = "理化性质";
			this.btnLHXX.UseVisualStyleBackColor = true;
			this.btnLHXX.Click += new EventHandler(this.btnLHXX_Click);
			this.btnDX.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnDX.Location = new Point(261, 309);
			this.btnDX.Name = "btnDX";
			this.btnDX.Size = new Size(113, 29);
			this.btnDX.TabIndex = 13;
			this.btnDX.Text = "毒性";
			this.btnDX.UseVisualStyleBackColor = true;
			this.btnDX.Click += new EventHandler(this.btnDX_Click);
			this.txtZYTD.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtZYTD.Location = new Point(377, 309);
			this.txtZYTD.Name = "txtZYTD";
			this.txtZYTD.Size = new Size(113, 29);
			this.txtZYTD.TabIndex = 14;
			this.txtZYTD.Text = "作用特点";
			this.txtZYTD.UseVisualStyleBackColor = true;
			this.txtZYTD.Click += new EventHandler(this.txtZYTD_Click);
			this.btnJXY.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnJXY.Location = new Point(145, 344);
			this.btnJXY.Name = "btnJXY";
			this.btnJXY.Size = new Size(113, 29);
			this.btnJXY.TabIndex = 15;
			this.btnJXY.Text = "禁限用";
			this.btnJXY.UseVisualStyleBackColor = true;
			this.btnJXY.Click += new EventHandler(this.btnJXY_Click);
			this.btnHYGYXCFY.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnHYGYXCFY.Location = new Point(261, 344);
			this.btnHYGYXCFY.Name = "btnHYGYXCFY";
			this.btnHYGYXCFY.Size = new Size(113, 29);
			this.btnHYGYXCFY.TabIndex = 16;
			this.btnHYGYXCFY.Text = "含该有效成分的药";
			this.btnHYGYXCFY.UseVisualStyleBackColor = true;
			this.btnHYGYXCFY.Click += new EventHandler(this.btnHYGYXCFY_Click);
			this.btnHJ.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnHJ.Location = new Point(29, 344);
			this.btnHJ.Name = "btnHJ";
			this.btnHJ.Size = new Size(113, 29);
			this.btnHJ.TabIndex = 17;
			this.btnHJ.Text = "环境";
			this.btnHJ.UseVisualStyleBackColor = true;
			this.btnHJ.Click += new EventHandler(this.btnHJ_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(515, 387);
			base.Controls.Add(this.btnHJ);
			base.Controls.Add(this.btnJXY);
			base.Controls.Add(this.btnHYGYXCFY);
			base.Controls.Add(this.btnDX);
			base.Controls.Add(this.txtZYTD);
			base.Controls.Add(this.btnJGS);
			base.Controls.Add(this.btnLHXX);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.btnClose);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(523, 421);
			this.MinimumSize = new Size(523, 421);
			base.Name = "frmYXCFDetail";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "有效成分信息";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
