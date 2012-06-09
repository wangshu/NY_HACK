using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmQYDetail : Form
	{
		private IContainer components = null;
		private Panel panel1;
		private TextBox txtLXR;
		private Label label10;
		private TextBox txtFax;
		private Label label9;
		private TextBox txtAddress;
		private Label label8;
		private TextBox txtDWMC;
		private Label label7;
		private TextBox txtCounty;
		private Label label6;
		private TextBox txtProvince;
		private Label label5;
		private TextBox txtCountry;
		private Label label4;
		private TextBox txtCity;
		private Label label3;
		private TextBox txtDWLB;
		private Label label2;
		private TextBox txtEmail;
		private Label label1;
		private Button btnClose;
		private Button btnPrint;
		private Button btnQYYXQNY;
		private Button btnQYGQY;
		private TextBox txtHTTP;
		private Label label13;
		private TextBox txtPhone;
		private Label label11;
		private TextBox txtPostalcode;
		private Label label12;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmQYDetail));
			this.panel1 = new Panel();
			this.txtHTTP = new TextBox();
			this.label13 = new Label();
			this.txtPhone = new TextBox();
			this.label11 = new Label();
			this.txtPostalcode = new TextBox();
			this.label12 = new Label();
			this.txtLXR = new TextBox();
			this.label10 = new Label();
			this.txtFax = new TextBox();
			this.label9 = new Label();
			this.txtAddress = new TextBox();
			this.label8 = new Label();
			this.txtDWMC = new TextBox();
			this.label7 = new Label();
			this.txtCounty = new TextBox();
			this.label6 = new Label();
			this.txtProvince = new TextBox();
			this.label5 = new Label();
			this.txtCountry = new TextBox();
			this.label4 = new Label();
			this.txtCity = new TextBox();
			this.label3 = new Label();
			this.txtDWLB = new TextBox();
			this.label2 = new Label();
			this.txtEmail = new TextBox();
			this.label1 = new Label();
			this.btnClose = new Button();
			this.btnPrint = new Button();
			this.btnQYYXQNY = new Button();
			this.btnQYGQY = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.txtHTTP);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txtPostalcode);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txtLXR);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtFax);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtDWMC);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtCounty);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtProvince);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtCountry);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtCity);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtDWLB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(507, 224);
			this.panel1.TabIndex = 3;
			this.txtHTTP.Location = new Point(71, 191);
			this.txtHTTP.Name = "txtHTTP";
			this.txtHTTP.Size = new Size(428, 23);
			this.txtHTTP.TabIndex = 25;
			this.label13.AutoSize = true;
			this.label13.Location = new Point(35, 197);
			this.label13.Name = "label13";
			this.label13.Size = new Size(35, 14);
			this.label13.TabIndex = 24;
			this.label13.Text = "网址";
			this.txtPhone.Location = new Point(316, 113);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new Size(183, 23);
			this.txtPhone.TabIndex = 23;
			this.label11.AutoSize = true;
			this.label11.Location = new Point(282, 118);
			this.label11.Name = "label11";
			this.label11.Size = new Size(35, 14);
			this.label11.TabIndex = 22;
			this.label11.Text = "电话";
			this.txtPostalcode.Location = new Point(71, 113);
			this.txtPostalcode.Name = "txtPostalcode";
			this.txtPostalcode.Size = new Size(183, 23);
			this.txtPostalcode.TabIndex = 21;
			this.label12.AutoSize = true;
			this.label12.Location = new Point(7, 118);
			this.label12.Name = "label12";
			this.label12.Size = new Size(63, 14);
			this.label12.TabIndex = 20;
			this.label12.Text = "邮政编码";
			this.txtLXR.Location = new Point(316, 139);
			this.txtLXR.Name = "txtLXR";
			this.txtLXR.Size = new Size(183, 23);
			this.txtLXR.TabIndex = 19;
			this.label10.AutoSize = true;
			this.label10.Location = new Point(268, 145);
			this.label10.Name = "label10";
			this.label10.Size = new Size(49, 14);
			this.label10.TabIndex = 18;
			this.label10.Text = "联系人";
			this.txtFax.Location = new Point(71, 139);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new Size(183, 23);
			this.txtFax.TabIndex = 17;
			this.label9.AutoSize = true;
			this.label9.Location = new Point(35, 145);
			this.label9.Name = "label9";
			this.label9.Size = new Size(35, 14);
			this.label9.TabIndex = 16;
			this.label9.Text = "传真";
			this.txtAddress.Location = new Point(71, 87);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new Size(428, 23);
			this.txtAddress.TabIndex = 15;
			this.label8.AutoSize = true;
			this.label8.Location = new Point(7, 93);
			this.label8.Name = "label8";
			this.label8.Size = new Size(63, 14);
			this.label8.TabIndex = 14;
			this.label8.Text = "乡镇街道";
			this.txtDWMC.BackColor = SystemColors.Window;
			this.txtDWMC.Location = new Point(71, 9);
			this.txtDWMC.Name = "txtDWMC";
			this.txtDWMC.ReadOnly = true;
			this.txtDWMC.Size = new Size(428, 23);
			this.txtDWMC.TabIndex = 13;
			this.label7.AutoSize = true;
			this.label7.Location = new Point(7, 14);
			this.label7.Name = "label7";
			this.label7.Size = new Size(63, 14);
			this.label7.TabIndex = 12;
			this.label7.Text = "单位名称";
			this.txtCounty.Location = new Point(316, 61);
			this.txtCounty.Name = "txtCounty";
			this.txtCounty.Size = new Size(183, 23);
			this.txtCounty.TabIndex = 11;
			this.label6.AutoSize = true;
			this.label6.Location = new Point(296, 68);
			this.label6.Name = "label6";
			this.label6.Size = new Size(21, 14);
			this.label6.TabIndex = 10;
			this.label6.Text = "县";
			this.txtProvince.Location = new Point(316, 35);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.Size = new Size(183, 23);
			this.txtProvince.TabIndex = 9;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(296, 39);
			this.label5.Name = "label5";
			this.label5.Size = new Size(21, 14);
			this.label5.TabIndex = 8;
			this.label5.Text = "省";
			this.txtCountry.Location = new Point(71, 35);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new Size(183, 23);
			this.txtCountry.TabIndex = 7;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(35, 39);
			this.label4.Name = "label4";
			this.label4.Size = new Size(35, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "国家";
			this.txtCity.Location = new Point(71, 61);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new Size(183, 23);
			this.txtCity.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(35, 68);
			this.label3.Name = "label3";
			this.label3.Size = new Size(35, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "城市";
			this.txtDWLB.Location = new Point(316, 165);
			this.txtDWLB.Name = "txtDWLB";
			this.txtDWLB.Size = new Size(183, 23);
			this.txtDWLB.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(254, 171);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "单位类别";
			this.txtEmail.Location = new Point(71, 165);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new Size(183, 23);
			this.txtEmail.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(35, 171);
			this.label1.Name = "label1";
			this.label1.Size = new Size(35, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "邮箱";
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(336, 236);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(90, 29);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.btnPrint.Location = new Point(474, 239);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new Size(29, 23);
			this.btnPrint.TabIndex = 4;
			this.btnPrint.Text = "打印预览";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Visible = false;
			this.btnQYYXQNY.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnQYYXQNY.Location = new Point(87, 236);
			this.btnQYYXQNY.Name = "btnQYYXQNY";
			this.btnQYYXQNY.Size = new Size(110, 29);
			this.btnQYYXQNY.TabIndex = 6;
			this.btnQYYXQNY.Text = "企业有效期内药";
			this.btnQYYXQNY.UseVisualStyleBackColor = true;
			this.btnQYYXQNY.Click += new EventHandler(this.btnQYYXQNY_Click);
			this.btnQYGQY.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnQYGQY.Location = new Point(216, 236);
			this.btnQYGQY.Name = "btnQYGQY";
			this.btnQYGQY.Size = new Size(110, 29);
			this.btnQYGQY.TabIndex = 7;
			this.btnQYGQY.Text = "企业过期药";
			this.btnQYGQY.UseVisualStyleBackColor = true;
			this.btnQYGQY.Click += new EventHandler(this.btnQYGQY_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(520, 272);
			base.Controls.Add(this.btnQYGQY);
			base.Controls.Add(this.btnQYYXQNY);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.btnPrint);
			base.Controls.Add(this.panel1);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(528, 306);
			this.MinimumSize = new Size(528, 306);
			base.Name = "frmQYDetail";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "企业信息";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
		public frmQYDetail(string strF2, string strF8, string strF14)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			DataRow[] array = MDIParent.dsF.Tables["F"].Select(string.Concat(new string[]
			{
				"F2='",
				strF2,
				"'",
				(strF8 == "") ? "" : (" and F8='" + strF8 + "'"),
				(strF14 == "") ? "" : (" and F14='" + strF14 + "'")
			}));
			this.txtDWMC.Text = array[0]["F2"].ToString();
			this.txtCountry.Text = array[0]["F3"].ToString();
			this.txtProvince.Text = array[0]["F4"].ToString();
			this.txtCity.Text = array[0]["F5"].ToString();
			this.txtCounty.Text = array[0]["F6"].ToString();
			this.txtAddress.Text = array[0]["F7"].ToString();
			this.txtPostalcode.Text = array[0]["F11"].ToString();
			this.txtPhone.Text = array[0]["F9"].ToString();
			this.txtFax.Text = array[0]["F10"].ToString();
			this.txtLXR.Text = array[0]["F14"].ToString();
			this.txtEmail.Text = array[0]["F12"].ToString();
			this.txtEmail.Text = array[0]["F13"].ToString();
			this.txtDWLB.Text = array[0]["F8"].ToString();
		}
		private void btnQYYXQNY_Click(object sender, EventArgs e)
		{
			frmNYList frmNYList = new frmNYList("QY_Used", this.txtDWMC.Text.Trim());
			frmNYList.ShowDialog();
		}
		private void btnQYGQY_Click(object sender, EventArgs e)
		{
			frmNYList frmNYList = new frmNYList("QY_Unused", this.txtDWMC.Text.Trim());
			frmNYList.ShowDialog();
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
