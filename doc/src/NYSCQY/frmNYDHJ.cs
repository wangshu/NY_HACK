using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
	public class frmNYDHJ : Form
	{
		private bool formMove = false;
		private Point formPoint;
		private DataTable dtlok = new DataTable();
		private DataTable dtColumns = new DataTable();
		private DataTable tblResult = new DataTable();
		private clsStr Stra = new clsStr();
		private IContainer components = null;
		private Button btnReset;
		private Button btnSearch;
		private Panel panelcondition;
		private RadioButton radYY;
		private Label lblCount;
		private RadioButton radHJ;
		private RadioButton radDJ;
		private RadioButton radAll;
		private System.Windows.Forms.ComboBox cboUnit1;
		private Label label1;
		private TextBox txtHL1;
		private Label label2;
		private Panel pan3;
		private Label label5;
		private Label label6;
		private TextBox txtHL3;
		private System.Windows.Forms.ComboBox cboUnit3;
		private Panel pan2;
		private Label label3;
		private Label label4;
		private TextBox txtHL2;
		private System.Windows.Forms.ComboBox cboUnit2;
		private Panel pan1;
		private Panel paneldata;
		private Panel panYY;
		private Label label7;
		private Label label8;
		private System.Windows.Forms.ComboBox cboYYZL;
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
		private GridColumn gridColumn14;
		private GridColumn gridColumn15;
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
		private Label label9;
		private PictureBox pictureBox_left;
		private Panel panelwhite;
		private Panel panelbutton;
		private PictureBox pictureBox_sum;
		private PictureBox pictureBox_view;
		private PictureBox pictureBox_sort;
		private PictureBox pictureBox_filter;
		private Panel paneldatasum;
		private Label labeldatacount;
		private GridLookUpEdit gridlokYXCF1;
		private GridView gridLookUpEdit1View;
		private GridLookUpEdit gridlokYXCF3;
		private GridView gridView3;
		private GridLookUpEdit gridlokYXCF2;
		private GridView gridView2;
		private GridLookUpEdit gridlokYXCF;
		private GridView gridView4;
		private GridColumn gridColumn16;
		private GridColumn gridColumn17;
		private GridColumn gridColumn18;
		private GridColumn gridColumn19;
		private GridColumn gridColumn20;
		private GridColumn gridColumn21;
		private GridColumn gridColumn22;
		public frmNYDHJ()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem6.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			clsStr clsStr = new clsStr();
			if (this.radHJ.Checked)
			{
				if ((this.txtHL1.Text.Trim() != "" || this.cboUnit1.Text.Trim() != "") && this.gridlokYXCF1.Text.Trim() == "")
				{
					MessageBox.Show(this, "请输入对应的有效成分1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.gridlokYXCF1.Focus();
					return;
				}
				if ((this.txtHL2.Text.Trim() != "" || this.cboUnit2.Text.Trim() != "") && this.gridlokYXCF2.Text.Trim() == "")
				{
					MessageBox.Show(this, "请输入对应的有效成分2！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.gridlokYXCF2.Focus();
					return;
				}
				if ((this.txtHL3.Text.Trim() != "" || this.cboUnit3.Text.Trim() != "") && this.gridlokYXCF3.Text.Trim() == "")
				{
					MessageBox.Show(this, "请输入对应的有效成分3！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.gridlokYXCF3.Focus();
					return;
				}
				if (this.txtHL1.Text.Trim() != "" && this.cboUnit1.Text.Trim() == "")
				{
					MessageBox.Show(this, "请输入对应的单位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.cboUnit1.Focus();
					return;
				}
				if (this.txtHL2.Text.Trim() != "" && this.cboUnit2.Text.Trim() == "")
				{
					MessageBox.Show(this, "请输入对应的单位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.cboUnit2.Focus();
					return;
				}
				if (this.txtHL3.Text.Trim() != "" && this.cboUnit3.Text.Trim() == "")
				{
					MessageBox.Show(this, "请输入对应的单位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					this.cboUnit3.Focus();
					return;
				}
			}
			else
			{
				if (this.radDJ.Checked)
				{
					if ((this.txtHL1.Text.Trim() != "" || this.cboUnit1.Text.Trim() != "") && this.gridlokYXCF1.Text.Trim() == "")
					{
						MessageBox.Show(this, "请输入对应的有效成分1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.gridlokYXCF1.Focus();
						return;
					}
					if (this.txtHL1.Text.Trim() != "" && this.cboUnit1.Text.Trim() == "")
					{
						MessageBox.Show(this, "请输入对应的单位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.cboUnit1.Focus();
						return;
					}
				}
			}
			this.Cursor = Cursors.WaitCursor;
			string text = "";
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
			if (this.gridlokYXCF1.Text.Trim() != "")
			{
				if (text == "")
				{
					text = string.Concat(new string[]
					{
						"(E2 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
				else
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						" and (E2 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF1.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
			}
			if (this.gridlokYXCF2.Text.Trim() != "")
			{
				if (text == "")
				{
					text = string.Concat(new string[]
					{
						"(E2 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
				else
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						" and (E2 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF2.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
			}
			if (this.gridlokYXCF3.Text.Trim() != "")
			{
				if (text == "")
				{
					text = string.Concat(new string[]
					{
						"(E2 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
				else
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						" and (E2 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF3.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
			}
			if (this.cboYYZL.Text.Trim() != "")
			{
				if (text == "")
				{
					text = "R13 like '%" + this.cboYYZL.Text.Trim() + "%'";
				}
				else
				{
					text = text + " and R13 like '%" + this.cboYYZL.Text.Trim() + "%'";
				}
			}
			else
			{
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
			}
			if (this.gridlokYXCF.Text.Trim() != "")
			{
				if (text == "")
				{
					text = string.Concat(new string[]
					{
						"(E2 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
				else
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						" and (E2 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%' or E3 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%' or E4 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%' or E5 like '%",
						this.gridlokYXCF.Text.Trim().Replace("%", "[%]"),
						"%')"
					});
				}
			}
			DataRow[] array = MDIParent.dsP.Tables["P"].Select(text, "F2");
			DataRow[] array2 = MDIParent.dsF.Tables["F"].Select("", "F2");
			DataTable dataTable = new DataTable();
			dataTable = this.tblResult.Clone();
			int num = 0;
			int num2 = 0;
			int i = 0;
			for (int j = 0; j < array.Length; j++)
			{
				while (i < array2.Length)
				{
					if (!this.radYY.Checked)
					{
						string[] array3 = clsStr.Seperate(array[j]["E2"].ToString(), '、');
						string[] array4 = clsStr.Seperate(array[j]["E3"].ToString(), '、');
						string[] array5 = clsStr.Seperate(array[j]["E4"].ToString(), '、');
						string[] array6 = clsStr.Seperate(array[j]["E5"].ToString(), '、');
						string[] array7 = clsStr.Seperate(array[j]["R7"].ToString(), '、');
						num = 0;
						num2 = 0;
						if (this.gridlokYXCF1.Text.Trim() != "")
						{
							num++;
							if (this.txtHL1.Text.Trim() != "")
							{
								for (int k = 0; k < array3.Length; k++)
								{
									if ((array3[k].IndexOf(this.gridlokYXCF1.Text.Trim()) >= 0 || array4[k].IndexOf(this.gridlokYXCF1.Text.Trim()) >= 0 || array5[k].IndexOf(this.gridlokYXCF1.Text.Trim()) >= 0 || array6[k].IndexOf(this.gridlokYXCF1.Text.Trim()) >= 0) && array7[k] == this.txtHL1.Text.Trim() + this.cboUnit1.Text.Trim())
									{
										num2++;
									}
								}
							}
							else
							{
								num2++;
							}
						}
						if (this.gridlokYXCF2.Text.Trim() != "")
						{
							num++;
							if (this.txtHL2.Text.Trim() != "")
							{
								for (int k = 0; k < array3.Length; k++)
								{
									if ((array3[k].IndexOf(this.gridlokYXCF2.Text.Trim()) >= 0 || array4[k].IndexOf(this.gridlokYXCF2.Text.Trim()) >= 0 || array5[k].IndexOf(this.gridlokYXCF2.Text.Trim()) >= 0 || array6[k].IndexOf(this.gridlokYXCF2.Text.Trim()) >= 0) && array7[k] == this.txtHL2.Text.Trim() + this.cboUnit2.Text.Trim())
									{
										num2++;
									}
								}
							}
							else
							{
								num2++;
							}
						}
						if (this.gridlokYXCF3.Text.Trim() != "")
						{
							num++;
							if (this.txtHL3.Text.Trim() != "")
							{
								for (int k = 0; k < array3.Length; k++)
								{
									if ((array3[k].IndexOf(this.gridlokYXCF3.Text.Trim()) >= 0 || array4[k].IndexOf(this.gridlokYXCF3.Text.Trim()) >= 0 || array5[k].IndexOf(this.gridlokYXCF3.Text.Trim()) >= 0 || array6[k].IndexOf(this.gridlokYXCF3.Text.Trim()) >= 0) && array7[k] == this.txtHL3.Text.Trim() + this.cboUnit3.Text.Trim())
									{
										num2++;
									}
								}
							}
							else
							{
								num2++;
							}
						}
					}
					if (array[j]["F2"].ToString() == array2[i]["F2"].ToString())
					{
						if (num2 >= num || this.radYY.Checked)
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow["R1"] = array[j]["R1"];
							dataRow["R2"] = array[j]["R2"];
							dataRow["HL"] = array[j]["HL"];
							dataRow["R12"] = array[j]["R12"];
							dataRow["R80"] = array[j]["R80"];
							dataRow["R90"] = array[j]["R90"];
							dataRow["R4"] = array[j]["R4"];
							dataRow["R5"] = array[j]["R5"];
							dataRow["F2"] = array[j]["F2"];
							dataRow["F9"] = array2[i]["F9"];
							dataRow["F14"] = array2[i]["F14"];
							dataRow["R11"] = array[j]["R11"];
							dataRow["R13"] = array[j]["R13"];
							dataRow["E2"] = array[j]["E2"];
							dataRow["E3"] = array[j]["E3"];
							if (this.radDJ.Checked || this.radYY.Checked)
							{
							}
							dataTable.Rows.Add(dataRow);
						}
						break;
					}
					i++;
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
				if (this.panYY.Visible)
				{
					this.gridlokYXCF.Focus();
				}
				else
				{
					this.gridlokYXCF1.Focus();
				}
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.ClearValue();
			this.radAll.Checked = true;
			this.gridlokYXCF1.Focus();
		}
		private void ClearValue()
		{
			this.gridlokYXCF1.Text = "";
			this.gridlokYXCF2.Text = "";
			this.gridlokYXCF3.Text = "";
			this.txtHL1.Text = "";
			this.txtHL2.Text = "";
			this.txtHL3.Text = "";
			this.cboUnit1.Text = "";
			this.cboUnit2.Text = "";
			this.cboUnit3.Text = "";
			this.gridlokYXCF.Text = "";
			this.cboYYZL.Text = "";
		}
		private void btnFilter_Click(object sender, EventArgs e)
		{
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
			this.tblResult.Columns.Add("E2");
			this.tblResult.Columns.Add("E3");
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
			this.gridView1.Columns[13].Caption = "中文通用名称";
			this.gridView1.Columns[13].FieldName = "E2";
			this.gridView1.Columns[13].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[13].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[13].Width = 160;
			this.gridView1.Columns[14].Caption = "英文通用名称";
			this.gridView1.Columns[14].FieldName = "E3";
			this.gridView1.Columns[14].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[14].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[14].Width = 160;
		}
		private void frmNYDHJ_Load(object sender, EventArgs e)
		{
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.gridlokYXCF1.Focus();
			this.dtlok = MDIParent.dsAED.Tables["AED"].Copy();
			this.dtlok.TableName = "dtlok";
			if (this.dtlok.Columns.Count > 4)
			{
				this.dtlok.Columns.Remove(this.dtlok.Columns["E1"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E6"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E7"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E8"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E9"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E10"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E11"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E12"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E13"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E14"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E15"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E16"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E17"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E18"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E19"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E20"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E21"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E23"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E24"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E25"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E26"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E27"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E28"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E29"]);
				this.dtlok.Columns.Remove(this.dtlok.Columns["E30"]);
			}
			this.dtColumns.Columns.Add("YXCF", typeof(string));
			for (int i = 0; i < this.dtlok.Rows.Count; i++)
			{
				for (int j = 0; j < this.dtlok.Columns.Count; j++)
				{
					if (this.dtlok.Rows[i][j].ToString().Length != 0)
					{
						DataRow dataRow = this.dtColumns.NewRow();
						dataRow["YXCF"] = this.dtlok.Rows[i][j];
						this.dtColumns.Rows.Add(dataRow);
					}
				}
			}
			DataView defaultView = this.dtColumns.DefaultView;
			defaultView.Sort = "YXCF asc";
			this.dtColumns = defaultView.ToTable(true, new string[]
			{
				"YXCF"
			});
			this.gridlokYXCF1.Properties.ImmediatePopup = true;
			this.gridlokYXCF1.Properties.DataSource = this.dtColumns.DefaultView;
			this.gridlokYXCF1.Properties.DisplayMember = "YXCF";
			this.gridlokYXCF1.Properties.ValueMember = "YXCF";
			this.gridlokYXCF1.Properties.AllowNullInput = DefaultBoolean.True;
			this.gridlokYXCF1.Properties.PopupFilterMode = PopupFilterMode.Contains;
			this.gridlokYXCF2.Properties.ImmediatePopup = true;
			this.gridlokYXCF2.Properties.DataSource = this.dtColumns.DefaultView;
			this.gridlokYXCF2.Properties.DisplayMember = "YXCF";
			this.gridlokYXCF2.Properties.ValueMember = "YXCF";
			this.gridlokYXCF2.Properties.AllowNullInput = DefaultBoolean.True;
			this.gridlokYXCF2.Properties.PopupFilterMode = PopupFilterMode.Contains;
			this.gridlokYXCF3.Properties.ImmediatePopup = true;
			this.gridlokYXCF3.Properties.DataSource = this.dtColumns.DefaultView;
			this.gridlokYXCF3.Properties.DisplayMember = "YXCF";
			this.gridlokYXCF3.Properties.ValueMember = "YXCF";
			this.gridlokYXCF3.Properties.AllowNullInput = DefaultBoolean.True;
			this.gridlokYXCF3.Properties.PopupFilterMode = PopupFilterMode.Contains;
			this.gridlokYXCF.Properties.ImmediatePopup = true;
			this.gridlokYXCF.Properties.DataSource = this.dtColumns.DefaultView;
			this.gridlokYXCF.Properties.DisplayMember = "YXCF";
			this.gridlokYXCF.Properties.ValueMember = "YXCF";
			this.gridlokYXCF.Properties.AllowNullInput = DefaultBoolean.True;
			this.gridlokYXCF.Properties.PopupFilterMode = PopupFilterMode.Contains;
			this.gridlokYXCF1.Properties.TextEditStyle = TextEditStyles.Standard;
			this.gridlokYXCF2.Properties.TextEditStyle = TextEditStyles.Standard;
			this.gridlokYXCF3.Properties.TextEditStyle = TextEditStyles.Standard;
			this.gridlokYXCF.Properties.TextEditStyle = TextEditStyles.Standard;
		}
		private void radHJ_Click(object sender, EventArgs e)
		{
			this.ClearValue();
			this.gridlokYXCF1.Focus();
			this.pan1.Enabled = true;
			this.pan2.Enabled = true;
			this.pan3.Enabled = true;
			this.panYY.Visible = false;
			this.pan1.Visible = true;
		}
		private void radDJ_Click(object sender, EventArgs e)
		{
			this.ClearValue();
			this.gridlokYXCF1.Focus();
			this.pan1.Enabled = true;
			this.pan2.Enabled = false;
			this.pan3.Enabled = false;
			this.panYY.Visible = false;
			this.pan1.Visible = true;
		}
		private void radYY_Click(object sender, EventArgs e)
		{
			this.ClearValue();
			this.gridlokYXCF.Focus();
			this.pan1.Visible = false;
			this.pan2.Enabled = false;
			this.pan3.Enabled = false;
			this.panYY.Enabled = true;
			this.panYY.Visible = true;
			this.panYY.Location = this.pan1.Location;
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
		private void frmNYDHJ_Resize(object sender, EventArgs e)
		{
			this.userManu1.navBarControl1.Height = this.panelmenu.Height - 2;
		}
		private void DataTableDispaly(string strDisplay)
		{
			DataTable dataTable = this.dtColumns;
			DataRow dataRow = dataTable.NewRow();
			dataRow["YXCF"] = strDisplay;
			dataTable.Rows.Add(dataRow);
		}
		private void gridlokYXCF1_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
		{
			string strDisplay = e.DisplayValue.ToString();
			this.DataTableDispaly(strDisplay);
			e.Handled = true;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmNYDHJ));
			this.btnReset = new Button();
			this.btnSearch = new Button();
			this.panelcondition = new Panel();
			this.pan3 = new Panel();
			this.gridlokYXCF3 = new GridLookUpEdit();
			this.gridView3 = new GridView();
			this.gridColumn21 = new GridColumn();
			this.label6 = new Label();
			this.txtHL3 = new TextBox();
			this.cboUnit3 = new System.Windows.Forms.ComboBox();
			this.label5 = new Label();
			this.pan1 = new Panel();
			this.gridlokYXCF1 = new GridLookUpEdit();
			this.gridLookUpEdit1View = new GridView();
			this.gridColumn17 = new GridColumn();
			this.label1 = new Label();
			this.txtHL1 = new TextBox();
			this.cboUnit1 = new System.Windows.Forms.ComboBox();
			this.label2 = new Label();
			this.radYY = new RadioButton();
			this.pan2 = new Panel();
			this.gridlokYXCF2 = new GridLookUpEdit();
			this.gridView2 = new GridView();
			this.gridColumn20 = new GridColumn();
			this.label4 = new Label();
			this.txtHL2 = new TextBox();
			this.cboUnit2 = new System.Windows.Forms.ComboBox();
			this.label3 = new Label();
			this.lblCount = new Label();
			this.radHJ = new RadioButton();
			this.radDJ = new RadioButton();
			this.radAll = new RadioButton();
			this.panYY = new Panel();
			this.gridlokYXCF = new GridLookUpEdit();
			this.gridView4 = new GridView();
			this.gridColumn22 = new GridColumn();
			this.label8 = new Label();
			this.cboYYZL = new System.Windows.Forms.ComboBox();
			this.label7 = new Label();
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
			this.gridColumn14 = new GridColumn();
			this.gridColumn15 = new GridColumn();
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
			this.label9 = new Label();
			this.pictureBox_left = new PictureBox();
			this.gridColumn16 = new GridColumn();
			this.gridColumn18 = new GridColumn();
			this.gridColumn19 = new GridColumn();
			this.panelcondition.SuspendLayout();
			this.pan3.SuspendLayout();
			((ISupportInitialize)this.gridlokYXCF3.Properties).BeginInit();
			((ISupportInitialize)this.gridView3).BeginInit();
			this.pan1.SuspendLayout();
			((ISupportInitialize)this.gridlokYXCF1.Properties).BeginInit();
			((ISupportInitialize)this.gridLookUpEdit1View).BeginInit();
			this.pan2.SuspendLayout();
			((ISupportInitialize)this.gridlokYXCF2.Properties).BeginInit();
			((ISupportInitialize)this.gridView2).BeginInit();
			this.panYY.SuspendLayout();
			((ISupportInitialize)this.gridlokYXCF.Properties).BeginInit();
			((ISupportInitialize)this.gridView4).BeginInit();
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
			this.btnReset.Location = new Point(97, 84);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(45, 23);
			this.btnReset.TabIndex = 12;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.btnSearch.Location = new Point(22, 84);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(45, 23);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.pan3);
			this.panelcondition.Controls.Add(this.pan1);
			this.panelcondition.Controls.Add(this.radYY);
			this.panelcondition.Controls.Add(this.pan2);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.lblCount);
			this.panelcondition.Controls.Add(this.radHJ);
			this.panelcondition.Controls.Add(this.radDJ);
			this.panelcondition.Controls.Add(this.radAll);
			this.panelcondition.Controls.Add(this.panYY);
			this.panelcondition.Location = new Point(16, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(603, 114);
			this.panelcondition.TabIndex = 18;
			this.pan3.BackColor = Color.Transparent;
			this.pan3.Controls.Add(this.gridlokYXCF3);
			this.pan3.Controls.Add(this.label6);
			this.pan3.Controls.Add(this.txtHL3);
			this.pan3.Controls.Add(this.cboUnit3);
			this.pan3.Controls.Add(this.label5);
			this.pan3.Location = new Point(9, 41);
			this.pan3.Name = "pan3";
			this.pan3.Size = new Size(340, 26);
			this.pan3.TabIndex = 21;
			this.gridlokYXCF3.Location = new Point(69, 2);
			this.gridlokYXCF3.Name = "gridlokYXCF3";
			this.gridlokYXCF3.Properties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
			this.gridlokYXCF3.Properties.NullText = "";
			this.gridlokYXCF3.Properties.View = this.gridView3;
			this.gridlokYXCF3.Size = new Size(96, 21);
			this.gridlokYXCF3.TabIndex = 25;
			this.gridlokYXCF3.ProcessNewValue += new ProcessNewValueEventHandler(this.gridlokYXCF1_ProcessNewValue);
			this.gridView3.Columns.AddRange(new GridColumn[]
			{
				this.gridColumn21
			});
			this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			this.gridColumn21.Caption = "有效成分";
			this.gridColumn21.FieldName = "YXCF";
			this.gridColumn21.Name = "gridColumn21";
			this.gridColumn21.Visible = true;
			this.gridColumn21.VisibleIndex = 0;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Location = new Point(1, 5);
			this.label6.Name = "label6";
			this.label6.Size = new Size(70, 14);
			this.label6.TabIndex = 2;
			this.label6.Text = "有效成分3";
			this.txtHL3.Location = new Point(202, 1);
			this.txtHL3.Name = "txtHL3";
			this.txtHL3.Size = new Size(58, 23);
			this.txtHL3.TabIndex = 17;
			this.cboUnit3.DropDownWidth = 78;
			this.cboUnit3.FormattingEnabled = true;
			this.cboUnit3.Items.AddRange(new object[]
			{
				"%",
				"克/升",
				"毫克/片"
			});
			this.cboUnit3.Location = new Point(263, 2);
			this.cboUnit3.Name = "cboUnit3";
			this.cboUnit3.Size = new Size(75, 21);
			this.cboUnit3.TabIndex = 8;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Transparent;
			this.label5.Location = new Point(164, 5);
			this.label5.Name = "label5";
			this.label5.Size = new Size(35, 14);
			this.label5.TabIndex = 18;
			this.label5.Text = "含量";
			this.pan1.BackColor = Color.Transparent;
			this.pan1.Controls.Add(this.gridlokYXCF1);
			this.pan1.Controls.Add(this.label1);
			this.pan1.Controls.Add(this.txtHL1);
			this.pan1.Controls.Add(this.cboUnit1);
			this.pan1.Controls.Add(this.label2);
			this.pan1.Location = new Point(9, 8);
			this.pan1.Name = "pan1";
			this.pan1.Size = new Size(342, 26);
			this.pan1.TabIndex = 19;
			this.gridlokYXCF1.EditValue = "";
			this.gridlokYXCF1.Location = new Point(69, 4);
			this.gridlokYXCF1.Name = "gridlokYXCF1";
			this.gridlokYXCF1.Properties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
			this.gridlokYXCF1.Properties.NullText = "";
			this.gridlokYXCF1.Properties.TextEditStyle = TextEditStyles.Standard;
			this.gridlokYXCF1.Properties.View = this.gridLookUpEdit1View;
			this.gridlokYXCF1.Size = new Size(96, 21);
			this.gridlokYXCF1.TabIndex = 24;
			this.gridlokYXCF1.ProcessNewValue += new ProcessNewValueEventHandler(this.gridlokYXCF1_ProcessNewValue);
			this.gridLookUpEdit1View.Columns.AddRange(new GridColumn[]
			{
				this.gridColumn17
			});
			this.gridLookUpEdit1View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
			this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
			this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			this.gridColumn17.Caption = "有效成分";
			this.gridColumn17.FieldName = "YXCF";
			this.gridColumn17.Name = "gridColumn17";
			this.gridColumn17.Visible = true;
			this.gridColumn17.VisibleIndex = 0;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Location = new Point(1, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(70, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "有效成分1";
			this.txtHL1.Location = new Point(202, 3);
			this.txtHL1.Name = "txtHL1";
			this.txtHL1.Size = new Size(58, 23);
			this.txtHL1.TabIndex = 17;
			this.cboUnit1.DropDownWidth = 78;
			this.cboUnit1.FormattingEnabled = true;
			this.cboUnit1.Items.AddRange(new object[]
			{
				"%",
				"克/升",
				"毫克/片"
			});
			this.cboUnit1.Location = new Point(263, 4);
			this.cboUnit1.Name = "cboUnit1";
			this.cboUnit1.Size = new Size(75, 21);
			this.cboUnit1.TabIndex = 8;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Location = new Point(164, 7);
			this.label2.Name = "label2";
			this.label2.Size = new Size(35, 14);
			this.label2.TabIndex = 18;
			this.label2.Text = "含量";
			this.radYY.AutoSize = true;
			this.radYY.BackColor = Color.Transparent;
			this.radYY.Location = new Point(556, 45);
			this.radYY.Name = "radYY";
			this.radYY.Size = new Size(53, 18);
			this.radYY.TabIndex = 16;
			this.radYY.Text = "原药";
			this.radYY.UseVisualStyleBackColor = false;
			this.radYY.Click += new EventHandler(this.radYY_Click);
			this.pan2.BackColor = Color.Transparent;
			this.pan2.Controls.Add(this.gridlokYXCF2);
			this.pan2.Controls.Add(this.label4);
			this.pan2.Controls.Add(this.txtHL2);
			this.pan2.Controls.Add(this.cboUnit2);
			this.pan2.Controls.Add(this.label3);
			this.pan2.Location = new Point(369, 8);
			this.pan2.Name = "pan2";
			this.pan2.Size = new Size(342, 26);
			this.pan2.TabIndex = 20;
			this.gridlokYXCF2.Location = new Point(70, 2);
			this.gridlokYXCF2.Name = "gridlokYXCF2";
			this.gridlokYXCF2.Properties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
			this.gridlokYXCF2.Properties.NullText = "";
			this.gridlokYXCF2.Properties.View = this.gridView2;
			this.gridlokYXCF2.Size = new Size(96, 21);
			this.gridlokYXCF2.TabIndex = 25;
			this.gridlokYXCF2.ProcessNewValue += new ProcessNewValueEventHandler(this.gridlokYXCF1_ProcessNewValue);
			this.gridView2.Columns.AddRange(new GridColumn[]
			{
				this.gridColumn20
			});
			this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			this.gridColumn20.Caption = "有效成分";
			this.gridColumn20.FieldName = "YXCF";
			this.gridColumn20.Name = "gridColumn20";
			this.gridColumn20.Visible = true;
			this.gridColumn20.VisibleIndex = 0;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Location = new Point(1, 5);
			this.label4.Name = "label4";
			this.label4.Size = new Size(70, 14);
			this.label4.TabIndex = 2;
			this.label4.Text = "有效成分2";
			this.txtHL2.Location = new Point(202, 2);
			this.txtHL2.Name = "txtHL2";
			this.txtHL2.Size = new Size(58, 23);
			this.txtHL2.TabIndex = 17;
			this.cboUnit2.DropDownWidth = 78;
			this.cboUnit2.FormattingEnabled = true;
			this.cboUnit2.Items.AddRange(new object[]
			{
				"%",
				"克/升",
				"毫克/片"
			});
			this.cboUnit2.Location = new Point(263, 2);
			this.cboUnit2.Name = "cboUnit2";
			this.cboUnit2.Size = new Size(75, 21);
			this.cboUnit2.TabIndex = 8;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Location = new Point(164, 7);
			this.label3.Name = "label3";
			this.label3.Size = new Size(35, 14);
			this.label3.TabIndex = 18;
			this.label3.Text = "含量";
			this.lblCount.AutoSize = true;
			this.lblCount.BackColor = Color.Transparent;
			this.lblCount.Location = new Point(293, 59);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new Size(0, 14);
			this.lblCount.TabIndex = 14;
			this.radHJ.AutoSize = true;
			this.radHJ.BackColor = Color.Transparent;
			this.radHJ.Location = new Point(503, 45);
			this.radHJ.Name = "radHJ";
			this.radHJ.Size = new Size(53, 18);
			this.radHJ.TabIndex = 11;
			this.radHJ.Text = "混剂";
			this.radHJ.UseVisualStyleBackColor = false;
			this.radHJ.Click += new EventHandler(this.radHJ_Click);
			this.radDJ.AutoSize = true;
			this.radDJ.BackColor = Color.Transparent;
			this.radDJ.Location = new Point(444, 45);
			this.radDJ.Name = "radDJ";
			this.radDJ.Size = new Size(53, 18);
			this.radDJ.TabIndex = 10;
			this.radDJ.Text = "单剂";
			this.radDJ.UseVisualStyleBackColor = false;
			this.radDJ.Click += new EventHandler(this.radDJ_Click);
			this.radAll.AutoSize = true;
			this.radAll.BackColor = Color.Transparent;
			this.radAll.Checked = true;
			this.radAll.Location = new Point(385, 45);
			this.radAll.Name = "radAll";
			this.radAll.Size = new Size(53, 18);
			this.radAll.TabIndex = 9;
			this.radAll.TabStop = true;
			this.radAll.Text = "全部";
			this.radAll.UseVisualStyleBackColor = false;
			this.radAll.Click += new EventHandler(this.radHJ_Click);
			this.panYY.BackColor = Color.Transparent;
			this.panYY.Controls.Add(this.gridlokYXCF);
			this.panYY.Controls.Add(this.label8);
			this.panYY.Controls.Add(this.cboYYZL);
			this.panYY.Controls.Add(this.label7);
			this.panYY.Location = new Point(9, 76);
			this.panYY.Name = "panYY";
			this.panYY.Size = new Size(342, 26);
			this.panYY.TabIndex = 23;
			this.panYY.Visible = false;
			this.gridlokYXCF.AllowDrop = true;
			this.gridlokYXCF.Location = new Point(69, 4);
			this.gridlokYXCF.Name = "gridlokYXCF";
			this.gridlokYXCF.Properties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
			this.gridlokYXCF.Properties.NullText = "";
			this.gridlokYXCF.Properties.View = this.gridView4;
			this.gridlokYXCF.Size = new Size(125, 21);
			this.gridlokYXCF.TabIndex = 25;
			this.gridlokYXCF.ProcessNewValue += new ProcessNewValueEventHandler(this.gridlokYXCF1_ProcessNewValue);
			this.gridView4.Columns.AddRange(new GridColumn[]
			{
				this.gridColumn22
			});
			this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
			this.gridView4.Name = "gridView4";
			this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView4.OptionsView.ShowGroupPanel = false;
			this.gridColumn22.Caption = "有效成分";
			this.gridColumn22.FieldName = "YXCF";
			this.gridColumn22.Name = "gridColumn22";
			this.gridColumn22.Visible = true;
			this.gridColumn22.VisibleIndex = 0;
			this.label8.AutoSize = true;
			this.label8.BackColor = Color.Transparent;
			this.label8.Location = new Point(1, 7);
			this.label8.Name = "label8";
			this.label8.Size = new Size(63, 14);
			this.label8.TabIndex = 2;
			this.label8.Text = "有效成分";
			this.cboYYZL.FormattingEnabled = true;
			this.cboYYZL.Items.AddRange(new object[]
			{
				"母粉",
				"母药",
				"母液",
				"原粉",
				"原药"
			});
			this.cboYYZL.Location = new Point(263, 4);
			this.cboYYZL.Name = "cboYYZL";
			this.cboYYZL.Size = new Size(75, 21);
			this.cboYYZL.TabIndex = 8;
			this.label7.AutoSize = true;
			this.label7.BackColor = Color.Transparent;
			this.label7.Location = new Point(195, 7);
			this.label7.Name = "label7";
			this.label7.Size = new Size(63, 14);
			this.label7.TabIndex = 18;
			this.label7.Text = "原药种类";
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(95, 131);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(89, 48);
			this.paneldata.TabIndex = 24;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(89, 48);
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
				this.gridColumn13,
				this.gridColumn14,
				this.gridColumn15
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
			this.gridColumn14.Caption = "gridColumn14";
			this.gridColumn14.Name = "gridColumn14";
			this.gridColumn14.Visible = true;
			this.gridColumn14.VisibleIndex = 13;
			this.gridColumn15.Caption = "gridColumn15";
			this.gridColumn15.Name = "gridColumn15";
			this.gridColumn15.Visible = true;
			this.gridColumn15.VisibleIndex = 14;
			this.panelmenu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.panelmenu.Controls.Add(this.userManu1);
			this.panelmenu.Location = new Point(0, 134);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(178, 452);
			this.panelmenu.TabIndex = 26;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(178, 452);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(429, 36);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(407, 25);
			this.paneltop_right.TabIndex = 32;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(195, 32);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(223, 29);
			this.paneltop_middle.TabIndex = 31;
			this.paneltop_left.Location = new Point(12, 32);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 30;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(599, 3);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(239, 25);
			this.paneltitle_right.TabIndex = 29;
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
			this.paneltitle_middle.Location = new Point(264, 3);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(338, 25);
			this.paneltitle_middle.TabIndex = 28;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(0, 3);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 27;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(214, 85);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(628, 492);
			this.panelright.TabIndex = 33;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(18, 161);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(604, 328);
			this.panelwhite.TabIndex = 28;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(5, 37);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(596, 40);
			this.panelbutton.TabIndex = 26;
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
			this.paneldatasum.Location = new Point(5, 3);
			this.paneldatasum.Name = "paneldatasum";
			this.paneldatasum.Size = new Size(596, 28);
			this.paneldatasum.TabIndex = 25;
			this.labeldatacount.BackColor = Color.Transparent;
			this.labeldatacount.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.labeldatacount.Location = new Point(41, 8);
			this.labeldatacount.Name = "labeldatacount";
			this.labeldatacount.Size = new Size(253, 14);
			this.labeldatacount.TabIndex = 0;
			this.pictureBox_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox_right.Location = new Point(587, 3);
			this.pictureBox_right.Name = "pictureBox_right";
			this.pictureBox_right.Size = new Size(38, 28);
			this.pictureBox_right.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_right.TabIndex = 27;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label9);
			this.panel_middle.Location = new Point(73, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(328, 28);
			this.panel_middle.TabIndex = 26;
			this.label9.BackColor = Color.Transparent;
			this.label9.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label9.Location = new Point(41, 7);
			this.label9.Name = "label9";
			this.label9.Size = new Size(253, 14);
			this.label9.TabIndex = 1;
			this.label9.Text = "农药单混剂查询";
			this.pictureBox_left.Location = new Point(4, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 25;
			this.pictureBox_left.TabStop = false;
			this.gridColumn16.Caption = "有效成分";
			this.gridColumn16.FieldName = "YXCF";
			this.gridColumn16.Name = "gridColumn16";
			this.gridColumn16.Visible = true;
			this.gridColumn16.VisibleIndex = 0;
			this.gridColumn18.Caption = "有效成分";
			this.gridColumn18.FieldName = "YXCF";
			this.gridColumn18.Name = "gridColumn18";
			this.gridColumn18.Visible = true;
			this.gridColumn18.VisibleIndex = 0;
			this.gridColumn19.Caption = "有效成分";
			this.gridColumn19.FieldName = "YXCF";
			this.gridColumn19.Name = "gridColumn19";
			this.gridColumn19.Visible = true;
			this.gridColumn19.VisibleIndex = 0;
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
			base.Name = "frmNYDHJ";
			this.Text = "农药单混剂查询";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frmNYDHJ_Load);
			base.Resize += new EventHandler(this.frmNYDHJ_Resize);
			this.panelcondition.ResumeLayout(false);
			this.panelcondition.PerformLayout();
			this.pan3.ResumeLayout(false);
			this.pan3.PerformLayout();
			((ISupportInitialize)this.gridlokYXCF3.Properties).EndInit();
			((ISupportInitialize)this.gridView3).EndInit();
			this.pan1.ResumeLayout(false);
			this.pan1.PerformLayout();
			((ISupportInitialize)this.gridlokYXCF1.Properties).EndInit();
			((ISupportInitialize)this.gridLookUpEdit1View).EndInit();
			this.pan2.ResumeLayout(false);
			this.pan2.PerformLayout();
			((ISupportInitialize)this.gridlokYXCF2.Properties).EndInit();
			((ISupportInitialize)this.gridView2).EndInit();
			this.panYY.ResumeLayout(false);
			this.panYY.PerformLayout();
			((ISupportInitialize)this.gridlokYXCF.Properties).EndInit();
			((ISupportInitialize)this.gridView4).EndInit();
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
