using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmNYList : Form
	{
		private DataTable tblResult = new DataTable();
		private clsStr Stra = new clsStr();
		private IContainer components = null;
		private DataGridView grv;
		private Button btnClose;
		private Button btnPrint;
		public frmNYList(string strLinkType, string strConditions)
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			clsStr clsStr = new clsStr();
			DataView dataView = new DataView(MDIParent.dsP.Tables["P"]);
			switch (strLinkType)
			{
			case "QY_Used":
				dataView.RowFilter = string.Concat(new string[]
				{
					"F2='",
					strConditions,
					"' and R5>'",
					clsStr.Format(DateTime.Now.Date.ToString(), '-'),
					"'"
				});
				this.SetHeaders_QY();
				for (int i = 0; i < dataView.Count; i++)
				{
					DataRow dataRow = this.tblResult.NewRow();
					dataRow["R1"] = dataView[i]["R1"];
					dataRow["R2"] = dataView[i]["R2"];
					dataRow["HL"] = dataView[i]["HL"];
					dataRow["R12"] = dataView[i]["R12"];
					dataRow["R4"] = dataView[i]["R4"];
					dataRow["R5"] = dataView[i]["R5"];
					dataRow["F2"] = dataView[i]["F2"];
					dataRow["R13"] = dataView[i]["R13"];
					dataRow["R11"] = dataView[i]["R11"];
					dataRow["C2"] = dataView[i]["C2"].ToString().Replace("|", "、");
					dataRow["T2"] = dataView[i]["T2"].ToString().Replace("|", "、");
					dataRow["R10"] = dataView[i]["R10"].ToString().Replace("|", "、");
					this.tblResult.Rows.Add(dataRow);
				}
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_QY();
				break;
			case "QY_Unused":
				dataView.RowFilter = string.Concat(new string[]
				{
					"F2='",
					strConditions,
					"' and R5<'",
					clsStr.Format(DateTime.Now.Date.ToString(), '-'),
					"'"
				});
				this.SetHeaders_QY();
				for (int i = 0; i < dataView.Count; i++)
				{
					DataRow dataRow = this.tblResult.NewRow();
					dataRow["R1"] = dataView[i]["R1"];
					dataRow["R2"] = dataView[i]["R2"];
					dataRow["HL"] = dataView[i]["HL"];
					dataRow["R12"] = dataView[i]["R12"];
					dataRow["R4"] = dataView[i]["R4"];
					dataRow["R5"] = dataView[i]["R5"];
					dataRow["F2"] = dataView[i]["F2"];
					dataRow["R13"] = dataView[i]["R13"];
					dataRow["R11"] = dataView[i]["R11"];
					dataRow["C2"] = dataView[i]["C2"].ToString().Replace("|", "、");
					dataRow["T2"] = dataView[i]["T2"].ToString().Replace("|", "、");
					dataRow["R10"] = dataView[i]["R10"].ToString().Replace("|", "、");
					this.tblResult.Rows.Add(dataRow);
				}
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_QY();
				break;
			case "YXCF":
			{
				string[] array = clsStr.Seperate(strConditions, '|');
				dataView.RowFilter = string.Concat(new string[]
				{
					"E2 like '%",
					array[0],
					"%' and E3 like '%",
					array[1],
					"%'"
				});
				this.SetHeaders_YXCF();
				for (int i = 0; i < dataView.Count; i++)
				{
					string[] array2 = clsStr.Seperate(dataView[i]["E2"].ToString(), '、');
					string[] array3 = clsStr.Seperate(dataView[i]["E3"].ToString(), '、');
					for (int j = 0; j < array2.Length; j++)
					{
						if (array2[j] == array[0] && array3[j] == array[1])
						{
							DataRow dataRow = this.tblResult.NewRow();
							dataRow["R1"] = dataView[i]["R1"];
							dataRow["R2"] = dataView[i]["R2"];
							dataRow["HL"] = dataView[i]["HL"];
							dataRow["R12"] = dataView[i]["R12"];
							dataRow["R4"] = dataView[i]["R4"];
							dataRow["R5"] = dataView[i]["R5"];
							dataRow["F2"] = dataView[i]["F2"];
							dataRow["R13"] = dataView[i]["R13"];
							dataRow["R11"] = dataView[i]["R11"];
							dataRow["C2"] = dataView[i]["C2"].ToString().Replace("|", "、");
							dataRow["T2"] = dataView[i]["T2"].ToString().Replace("|", "、");
							dataRow["R10"] = dataView[i]["R10"].ToString().Replace("|", "、");
							this.tblResult.Rows.Add(dataRow);
							break;
						}
					}
				}
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_YXCF();
				break;
			}
			case "ZWFZDX":
			{
				string[] array = clsStr.Seperate(strConditions, '|');
				dataView.RowFilter = string.Concat(new string[]
				{
					"C2 like '%",
					array[0],
					"%' and T2 like '%",
					array[1],
					"%'"
				});
				this.SetHeaders_ZWFZDX();
				for (int i = 0; i < dataView.Count; i++)
				{
					bool flag = false;
					string[] array4 = clsStr.Seperate(dataView[i]["C2"].ToString(), '|');
					string[] array5 = clsStr.Seperate(dataView[i]["T2"].ToString(), '|');
					for (int j = 0; j < array4.Length; j++)
					{
						if (array4[j] == array[0] && array5[j] == array[1])
						{
							flag = true;
							DataRow dataRow = this.tblResult.NewRow();
							dataRow["R1"] = dataView[i]["R1"];
							dataRow["R2"] = dataView[i]["R2"];
							dataRow["HL"] = dataView[i]["HL"];
							dataRow["R12"] = dataView[i]["R12"];
							dataRow["R80"] = dataView[i]["R80"];
							dataRow["R90"] = dataView[i]["R90"];
							dataRow["R4"] = dataView[i]["R4"];
							dataRow["R5"] = dataView[i]["R5"];
							dataRow["F2"] = dataView[i]["F2"];
							dataRow["R13"] = dataView[i]["R13"];
							dataRow["R11"] = dataView[i]["R11"];
							dataRow["C2"] = dataView[i]["C2"].ToString().Replace("|", "、");
							dataRow["T2"] = dataView[i]["T2"].ToString().Replace("|", "、");
							dataRow["R10"] = dataView[i]["R10"].ToString().Replace("|", "、");
							this.tblResult.Rows.Add(dataRow);
						}
						if (flag)
						{
							break;
						}
					}
				}
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_ZWFXDX();
				break;
			}
			case "YXCF2JX":
			{
				string[] array = clsStr.Seperate(strConditions, '|');
				dataView.RowFilter = string.Concat(new string[]
				{
					"E2 like '%",
					array[0],
					"%' and E3 like '%",
					array[1],
					"%' ",
					(array[2] == "") ? "" : (" and R13='" + array[2] + "'"),
					" and ",
					array[3]
				});
				this.SetHeaders_JX();
				for (int i = 0; i < dataView.Count; i++)
				{
					DataRow dataRow = this.tblResult.NewRow();
					dataRow["R1"] = dataView[i]["R1"];
					dataRow["R2"] = dataView[i]["R2"];
					dataRow["HL"] = dataView[i]["HL"];
					dataRow["R12"] = dataView[i]["R12"];
					dataRow["R80"] = dataView[i]["R80"];
					dataRow["R90"] = dataView[i]["R90"];
					dataRow["R4"] = dataView[i]["R4"];
					dataRow["R5"] = dataView[i]["R5"];
					dataRow["F2"] = dataView[i]["F2"];
					dataRow["R13"] = dataView[i]["R13"];
					dataRow["R11"] = dataView[i]["R11"];
					dataRow["C2"] = dataView[i]["C2"].ToString().Replace("|", "、");
					dataRow["T2"] = dataView[i]["T2"].ToString().Replace("|", "、");
					dataRow["R10"] = dataView[i]["R10"].ToString().Replace("|", "、");
					this.tblResult.Rows.Add(dataRow);
				}
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_JX();
				break;
			}
			case "YXCF2ZWFXDX":
			{
				string[] array = clsStr.Seperate(strConditions, '|');
				dataView.RowFilter = string.Concat(new string[]
				{
					"C2 like '%",
					array[0],
					"%' and T2 like '%",
					array[1],
					"%' and ",
					array[2]
				});
				this.SetHeaders_ZWFZDX();
				for (int i = 0; i < dataView.Count; i++)
				{
					bool flag = false;
					string[] array4 = clsStr.Seperate(dataView[i]["C2"].ToString(), '|');
					string[] array5 = clsStr.Seperate(dataView[i]["T2"].ToString(), '|');
					for (int j = 0; j < array4.Length; j++)
					{
						if (array4[j] == array[0] && array5[j] == array[1])
						{
							flag = true;
							DataRow dataRow = this.tblResult.NewRow();
							dataRow["R1"] = dataView[i]["R1"];
							dataRow["R2"] = dataView[i]["R2"];
							dataRow["HL"] = dataView[i]["HL"];
							dataRow["R12"] = dataView[i]["R12"];
							dataRow["R80"] = dataView[i]["R80"];
							dataRow["R90"] = dataView[i]["R90"];
							dataRow["R4"] = dataView[i]["R4"];
							dataRow["R5"] = dataView[i]["R5"];
							dataRow["F2"] = dataView[i]["F2"];
							dataRow["R13"] = dataView[i]["R13"];
							dataRow["R11"] = dataView[i]["R11"];
							dataRow["C2"] = dataView[i]["C2"].ToString().Replace("|", "、");
							dataRow["T2"] = dataView[i]["T2"].ToString().Replace("|", "、");
							dataRow["R10"] = dataView[i]["R10"].ToString().Replace("|", "、");
							this.tblResult.Rows.Add(dataRow);
						}
						if (flag)
						{
							break;
						}
					}
				}
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_ZWFXDX();
				break;
			}
			case "QYCPTJ":
			{
				this.SetHeaders_QYCPTJ();
				DataRow[] array6 = MDIParent.dsP.Tables["P"].Select("", "F2");
				DataRow[] array7 = MDIParent.dsF.Tables["F"].Select("", "F2");
				DataTable dataTable = new DataTable();
				dataTable = this.tblResult.Clone();
				int second = DateTime.Now.Second;
				string text = second.ToString();
				int num;
				if (text.Length > 1)
				{
					num = (int)Convert.ToInt16(text.Substring(text.Length - 1));
				}
				else
				{
					num = (int)Convert.ToInt16(text);
				}
				int k = 0;
				for (int i = 0; i < array7.Length; i++)
				{
					while (k < array6.Length)
					{
						if (!(array7[i]["F2"].ToString() == array6[k]["F2"].ToString()))
						{
							break;
						}
						DataRow dataRow = dataTable.NewRow();
						dataRow["R1"] = array6[k]["R1"];
						dataRow["R2"] = array6[k]["R2"];
						dataRow["HL"] = array6[k]["HL"];
						dataRow["R12"] = array6[k]["R12"];
						dataRow["R80"] = array6[k]["R80"];
						dataRow["R90"] = array6[k]["R90"];
						dataRow["R4"] = array6[k]["R4"];
						dataRow["R5"] = array6[k]["R5"];
						dataRow["F2"] = array7[i]["F2"];
						dataRow["F9"] = array7[i]["F9"];
						dataRow["F14"] = array7[i]["F14"];
						dataRow["R11"] = array6[k]["R11"];
						dataRow["R13"] = array6[k]["R13"];
						dataRow["F8"] = array7[i]["F8"];
						int num2 = (int)Convert.ToInt16(dataRow["R1"].ToString().Trim().Substring(dataRow["R1"].ToString().Trim().Length - 1));
						if (num2 < num)
						{
							dataRow["XH"] = num2 - num + 10;
						}
						else
						{
							dataRow["XH"] = num2 - num;
						}
						if (dataRow["JS"].ToString().Trim() != "")
						{
							dataTable.Rows.Add(dataRow);
						}
						k++;
					}
					if (k == array6.Length)
					{
						break;
					}
				}
				this.tblResult = dataTable.Copy();
				this.tblResult.DefaultView.Sort = "R5 desc";
				this.grv.DataSource = this.tblResult.DefaultView;
				this.SetStyle_QYCPTJ();
				break;
			}
			}
		}
		private void SetStyle_QY()
		{
			this.grv.Columns["R1"].HeaderText = "登记证号";
			this.grv.Columns["R1"].Width = 100;
			this.grv.Columns["R1"].DefaultCellStyle.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.grv.Columns["R1"].DefaultCellStyle.ForeColor = Color.Blue;
			this.grv.Columns["R2"].HeaderText = "登记名称";
			this.grv.Columns["R2"].Width = 170;
			this.grv.Columns["HL"].HeaderText = "含量";
			this.grv.Columns["HL"].Width = 80;
			this.grv.Columns["R13"].HeaderText = "剂型";
			this.grv.Columns["R13"].Width = 80;
			this.grv.Columns["R11"].HeaderText = "毒性";
			this.grv.Columns["R11"].Width = 80;
			this.grv.Columns["R12"].HeaderText = "农药类别";
			this.grv.Columns["R12"].Width = 100;
			this.grv.Columns["C2"].HeaderText = "作物";
			this.grv.Columns["C2"].Width = 120;
			this.grv.Columns["T2"].HeaderText = "防治对象";
			this.grv.Columns["T2"].Width = 120;
			this.grv.Columns["R10"].HeaderText = "有效成分用药量";
			this.grv.Columns["R10"].Width = 150;
			this.grv.Columns["R4"].HeaderText = "有效起始日";
			this.grv.Columns["R4"].Width = 120;
			this.grv.Columns["R5"].HeaderText = "有效截止日";
			this.grv.Columns["R5"].Width = 120;
			this.grv.Columns["F2"].HeaderText = "生产企业";
			this.grv.Columns["F2"].Width = 250;
		}
		private void SetStyle_YXCF()
		{
			this.grv.Columns["R1"].HeaderText = "登记证号";
			this.grv.Columns["R1"].Width = 100;
			this.grv.Columns["R1"].DefaultCellStyle.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.grv.Columns["R1"].DefaultCellStyle.ForeColor = Color.Blue;
			this.grv.Columns["R2"].HeaderText = "登记名称";
			this.grv.Columns["R2"].Width = 170;
			this.grv.Columns["HL"].HeaderText = "含量";
			this.grv.Columns["HL"].Width = 80;
			this.grv.Columns["R13"].HeaderText = "剂型";
			this.grv.Columns["R13"].Width = 80;
			this.grv.Columns["R11"].HeaderText = "毒性";
			this.grv.Columns["R11"].Width = 80;
			this.grv.Columns["R12"].HeaderText = "农药类别";
			this.grv.Columns["R12"].Width = 100;
			this.grv.Columns["C2"].HeaderText = "作物";
			this.grv.Columns["C2"].Width = 120;
			this.grv.Columns["T2"].HeaderText = "防治对象";
			this.grv.Columns["T2"].Width = 120;
			this.grv.Columns["R10"].HeaderText = "有效成分用药量";
			this.grv.Columns["R10"].Width = 150;
			this.grv.Columns["R4"].HeaderText = "有效起始日";
			this.grv.Columns["R4"].Width = 120;
			this.grv.Columns["R5"].HeaderText = "有效截止日";
			this.grv.Columns["R5"].Width = 120;
			this.grv.Columns["F2"].HeaderText = "生产企业";
			this.grv.Columns["F2"].Width = 250;
		}
		private void SetStyle_ZWFXDX()
		{
			this.grv.Columns["R1"].HeaderText = "登记证号";
			this.grv.Columns["R1"].Width = 100;
			this.grv.Columns["R1"].DefaultCellStyle.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.grv.Columns["R1"].DefaultCellStyle.ForeColor = Color.Blue;
			this.grv.Columns["R2"].HeaderText = "登记名称";
			this.grv.Columns["R2"].Width = 170;
			this.grv.Columns["HL"].HeaderText = "含量";
			this.grv.Columns["HL"].Width = 80;
			this.grv.Columns["R13"].HeaderText = "剂型";
			this.grv.Columns["R13"].Width = 80;
			this.grv.Columns["R11"].HeaderText = "毒性";
			this.grv.Columns["R11"].Width = 80;
			this.grv.Columns["R12"].HeaderText = "农药类别";
			this.grv.Columns["R12"].Width = 100;
			this.grv.Columns["C2"].HeaderText = "作物";
			this.grv.Columns["C2"].Width = 120;
			this.grv.Columns["T2"].HeaderText = "防治对象";
			this.grv.Columns["T2"].Width = 120;
			this.grv.Columns["R10"].HeaderText = "有效成分用药量";
			this.grv.Columns["R10"].Width = 150;
			this.grv.Columns["R80"].HeaderText = "生产批准/许可证号";
			this.grv.Columns["R80"].Width = 180;
			this.grv.Columns["R90"].HeaderText = "执行标准/企业标准";
			this.grv.Columns["R90"].Width = 180;
			this.grv.Columns["R4"].HeaderText = "有效起始日";
			this.grv.Columns["R4"].Width = 120;
			this.grv.Columns["R5"].HeaderText = "有效截止日";
			this.grv.Columns["R5"].Width = 120;
			this.grv.Columns["F2"].HeaderText = "生产企业";
			this.grv.Columns["F2"].Width = 250;
			this.grv.Columns["F9"].HeaderText = "电话";
			this.grv.Columns["F9"].Width = 160;
			this.grv.Columns["F14"].HeaderText = "联系人";
			this.grv.Columns["F14"].Width = 160;
			this.grv.Columns["XH"].HeaderText = "XH";
			this.grv.Columns["XH"].Visible = false;
		}
		private void SetStyle_JX()
		{
			this.grv.Columns["R1"].HeaderText = "登记证号";
			this.grv.Columns["R1"].Width = 100;
			this.grv.Columns["R1"].DefaultCellStyle.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.grv.Columns["R1"].DefaultCellStyle.ForeColor = Color.Blue;
			this.grv.Columns["R2"].HeaderText = "登记名称";
			this.grv.Columns["R2"].Width = 170;
			this.grv.Columns["HL"].HeaderText = "含量";
			this.grv.Columns["HL"].Width = 80;
			this.grv.Columns["R13"].HeaderText = "剂型";
			this.grv.Columns["R13"].Width = 80;
			this.grv.Columns["R11"].HeaderText = "毒性";
			this.grv.Columns["R11"].Width = 80;
			this.grv.Columns["R12"].HeaderText = "农药类别";
			this.grv.Columns["R12"].Width = 100;
			this.grv.Columns["C2"].HeaderText = "作物";
			this.grv.Columns["C2"].Width = 120;
			this.grv.Columns["T2"].HeaderText = "防治对象";
			this.grv.Columns["T2"].Width = 120;
			this.grv.Columns["R10"].HeaderText = "有效成分用药量";
			this.grv.Columns["R10"].Width = 150;
			this.grv.Columns["R80"].HeaderText = "生产批准/许可证号";
			this.grv.Columns["R80"].Width = 180;
			this.grv.Columns["R90"].HeaderText = "执行标准/企业标准";
			this.grv.Columns["R90"].Width = 180;
			this.grv.Columns["R4"].HeaderText = "有效起始日";
			this.grv.Columns["R4"].Width = 120;
			this.grv.Columns["R5"].HeaderText = "有效截止日";
			this.grv.Columns["R5"].Width = 120;
			this.grv.Columns["F2"].HeaderText = "生产企业";
			this.grv.Columns["F2"].Width = 250;
			this.grv.Columns["F9"].HeaderText = "电话";
			this.grv.Columns["F9"].Width = 160;
			this.grv.Columns["F14"].HeaderText = "联系人";
			this.grv.Columns["F14"].Width = 160;
			this.grv.Columns["XH"].HeaderText = "XH";
			this.grv.Columns["XH"].Visible = false;
		}
		private void SetStyle_QYCPTJ()
		{
			this.grv.Columns["R1"].HeaderText = "登记证号";
			this.grv.Columns["R1"].Width = 100;
			this.grv.Columns["R1"].DefaultCellStyle.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.grv.Columns["R1"].DefaultCellStyle.ForeColor = Color.Blue;
			this.grv.Columns["R2"].HeaderText = "登记名称";
			this.grv.Columns["R2"].Width = 170;
			this.grv.Columns["HL"].HeaderText = "含量";
			this.grv.Columns["HL"].Width = 80;
			this.grv.Columns["R13"].HeaderText = "剂型";
			this.grv.Columns["R13"].Width = 80;
			this.grv.Columns["R11"].HeaderText = "毒性";
			this.grv.Columns["R11"].Width = 80;
			this.grv.Columns["R12"].HeaderText = "农药类别";
			this.grv.Columns["R12"].Width = 100;
			this.grv.Columns["R80"].HeaderText = "生产批准/许可证号";
			this.grv.Columns["R80"].Width = 180;
			this.grv.Columns["R90"].HeaderText = "执行标准/企业标准";
			this.grv.Columns["R90"].Width = 180;
			this.grv.Columns["R4"].HeaderText = "有效起始日";
			this.grv.Columns["R4"].Width = 120;
			this.grv.Columns["R5"].HeaderText = "有效截止日";
			this.grv.Columns["R5"].Width = 120;
			this.grv.Columns["F2"].HeaderText = "生产企业";
			this.grv.Columns["F2"].Width = 250;
			this.grv.Columns["F2"].DefaultCellStyle.Font = new Font("宋体", 10f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.grv.Columns["F2"].DefaultCellStyle.ForeColor = Color.Blue;
			this.grv.Columns["F9"].HeaderText = "电话";
			this.grv.Columns["F9"].Width = 160;
			this.grv.Columns["F14"].HeaderText = "联系人";
			this.grv.Columns["F14"].Width = 160;
			this.grv.Columns["XH"].HeaderText = "XH";
			this.grv.Columns["XH"].Visible = false;
			this.grv.Columns["F8"].HeaderText = "单位类别";
			this.grv.Columns["F8"].Visible = false;
		}
		private void SetHeaders_QY()
		{
			this.tblResult.Columns.Add("R1");
			this.tblResult.Columns.Add("R2");
			this.tblResult.Columns.Add("HL");
			this.tblResult.Columns.Add("R12");
			this.tblResult.Columns.Add("C2");
			this.tblResult.Columns.Add("T2");
			this.tblResult.Columns.Add("R10");
			this.tblResult.Columns.Add("R13");
			this.tblResult.Columns.Add("R11");
			this.tblResult.Columns.Add("R4");
			this.tblResult.Columns.Add("R5");
			this.tblResult.Columns.Add("F2");
		}
		private void SetHeaders_YXCF()
		{
			this.tblResult.Columns.Add("R1");
			this.tblResult.Columns.Add("R2");
			this.tblResult.Columns.Add("HL");
			this.tblResult.Columns.Add("R12");
			this.tblResult.Columns.Add("C2");
			this.tblResult.Columns.Add("T2");
			this.tblResult.Columns.Add("R10");
			this.tblResult.Columns.Add("R13");
			this.tblResult.Columns.Add("R11");
			this.tblResult.Columns.Add("R4");
			this.tblResult.Columns.Add("R5");
			this.tblResult.Columns.Add("F2");
		}
		private void SetHeaders_ZWFZDX()
		{
			this.tblResult.Columns.Add("R1");
			this.tblResult.Columns.Add("R2");
			this.tblResult.Columns.Add("HL");
			this.tblResult.Columns.Add("R12");
			this.tblResult.Columns.Add("C2");
			this.tblResult.Columns.Add("T2");
			this.tblResult.Columns.Add("R10");
			this.tblResult.Columns.Add("R80");
			this.tblResult.Columns.Add("R90");
			this.tblResult.Columns.Add("R4");
			this.tblResult.Columns.Add("R5");
			this.tblResult.Columns.Add("F2");
			this.tblResult.Columns.Add("F9");
			this.tblResult.Columns.Add("F14");
			this.tblResult.Columns.Add("R13");
			this.tblResult.Columns.Add("R11");
			this.tblResult.Columns.Add("XH");
		}
		private void SetHeaders_JX()
		{
			this.tblResult.Columns.Add("R1");
			this.tblResult.Columns.Add("R2");
			this.tblResult.Columns.Add("HL");
			this.tblResult.Columns.Add("R12");
			this.tblResult.Columns.Add("C2");
			this.tblResult.Columns.Add("T2");
			this.tblResult.Columns.Add("R10");
			this.tblResult.Columns.Add("R80");
			this.tblResult.Columns.Add("R90");
			this.tblResult.Columns.Add("R4");
			this.tblResult.Columns.Add("R5");
			this.tblResult.Columns.Add("F2");
			this.tblResult.Columns.Add("F9");
			this.tblResult.Columns.Add("F14");
			this.tblResult.Columns.Add("R13");
			this.tblResult.Columns.Add("R11");
			this.tblResult.Columns.Add("XH");
		}
		private void SetHeaders_QYCPTJ()
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
			this.tblResult.Columns.Add("XH");
			this.tblResult.Columns.Add("F8");
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void grv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex < 0 && e.RowIndex >= 0)
			{
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
				Rectangle cellBounds = e.CellBounds;
				cellBounds.Inflate(-2, -2);
				TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), new Font("CHINESE_GB2312", 10f, FontStyle.Regular, GraphicsUnit.Point, 134), cellBounds, e.CellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
				e.Handled = true;
			}
			if (e.RowIndex != -1)
			{
				if (e.ColumnIndex != -1 && this.grv.Columns[e.ColumnIndex].DefaultCellStyle.Font != null && this.grv.Columns[e.ColumnIndex].DefaultCellStyle.Font.Underline)
				{
					this.grv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Blue;
				}
				else
				{
					if (string.Compare(this.grv.Rows[e.RowIndex].Cells["R5"].Value.ToString().Trim(), this.Stra.Format(DateTime.Now.Date.ToString(), '-')) < 0)
					{
						this.grv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
					}
				}
			}
		}
		private void grv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (e.ColumnIndex >= 0)
				{
					if (this.grv.Columns[e.ColumnIndex].DataPropertyName == "R1")
					{
						frmNYDetail frmNYDetail = new frmNYDetail(this.grv.CurrentCell.Value.ToString().Trim(), "", "");
						frmNYDetail.ShowDialog();
					}
					else
					{
						if (this.grv.Columns[e.ColumnIndex].DataPropertyName == "F2")
						{
							frmQYDetail frmQYDetail = new frmQYDetail(this.grv.CurrentCell.Value.ToString().Trim(), "", "");
							frmQYDetail.ShowDialog();
						}
					}
				}
			}
		}
		private void grv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmNYList));
			this.grv = new DataGridView();
			this.btnClose = new Button();
			this.btnPrint = new Button();
			((ISupportInitialize)this.grv).BeginInit();
			base.SuspendLayout();
			this.grv.AllowUserToAddRows = false;
			this.grv.AllowUserToDeleteRows = false;
			this.grv.AllowUserToResizeRows = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle.SelectionForeColor = SystemColors.InfoText;
			this.grv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.grv.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.grv.BackgroundColor = SystemColors.Window;
			this.grv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 242, 254);
			dataGridViewCellStyle2.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.grv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 153);
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.InfoText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.grv.DefaultCellStyle = dataGridViewCellStyle3;
			this.grv.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.grv.Location = new Point(0, 2);
			this.grv.Name = "grv";
			this.grv.ReadOnly = true;
			this.grv.RowHeadersWidth = 50;
			this.grv.RowTemplate.Height = 23;
			this.grv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.grv.ShowEditingIcon = false;
			this.grv.Size = new Size(790, 527);
			this.grv.TabIndex = 1;
			this.grv.CellMouseUp += new DataGridViewCellMouseEventHandler(this.grv_CellMouseUp);
			this.grv.CellFormatting += new DataGridViewCellFormattingEventHandler(this.grv_CellFormatting);
			this.grv.CellPainting += new DataGridViewCellPaintingEventHandler(this.grv_CellPainting);
			this.btnClose.Anchor = AnchorStyles.Bottom;
			this.btnClose.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.btnClose.Location = new Point(348, 533);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new Size(113, 29);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.btnPrint.Anchor = AnchorStyles.Bottom;
			this.btnPrint.Location = new Point(217, 535);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new Size(75, 23);
			this.btnPrint.TabIndex = 4;
			this.btnPrint.Text = "打印预览";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Visible = false;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(792, 566);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.btnPrint);
			base.Controls.Add(this.grv);
			this.Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmNYList";
			this.Text = "农药列表";
			base.WindowState = FormWindowState.Maximized;
			((ISupportInitialize)this.grv).EndInit();
			base.ResumeLayout(false);
		}
	}
}
