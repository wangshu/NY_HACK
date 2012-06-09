using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
namespace NYSCQY
{
	public class frmBQ : Form
	{
		private bool formMove = false;
		private Point formPoint;
		private DataTable tblResult = new DataTable();
		private int intRowNum = 0;
		private int intColNum = 0;
		private int intPageNum = 0;
		private clsStr Stra = new clsStr();
		private IContainer components = null;
		private Label lblCount;
		private Button btnReset;
		private Button btnSearch;
		private Panel panelcondition;
		private Label label3;
		private TextBox txtDWMC;
		private Label label1;
		private TextBox txtDJZH;
		private Label label2;
		private TextBox txtDJMC;
		private PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
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
		public frmBQ()
		{
			this.InitializeComponent();
			clsMe clsMe = new clsMe();
			clsMe.setFormStyl(this);
			this.SetGridControl();
			this.userManu1.navBarItem11.Appearance.ForeColor = Color.FromArgb(177, 81, 28);
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			clsStr clsStr = new clsStr();
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
			DataTable dataTable = new DataTable();
			dataTable = this.tblResult.Clone();
			DataRow[] array2 = MDIParent.dsP.Tables["P"].Select(text, "F2");
			for (int i = 0; i < array2.Length; i++)
			{
				DataRow[] array3 = MDIParent.dsBQ.Tables["bq"].Select("R1='" + array2[i]["R1"].ToString() + "'");
				if (array3.Length == 1)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["R1"] = array3[0]["R1"];
					dataRow["R2"] = array2[i]["R2"];
					dataRow["F2"] = array2[i]["F2"];
					dataTable.Rows.Add(dataRow);
				}
			}
			this.tblResult = dataTable.Copy();
			DataView dataSource = new DataView(this.tblResult);
			this.gridControl1.DataSource = dataSource;
			this.Cursor = Cursors.Default;
			if (this.tblResult.Rows.Count == 0)
			{
				MessageBox.Show(this, "查询不到相关数据,可能由以下原因造成：\r\n1、您输入的条件太多,过于复杂；\r\n2、该产品已被吊销、禁止发布等；\r\n3、不存在该产品；\r\n请您输入简单正确条件后继续查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txtDJZH.Focus();
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.txtDJZH.Text = "";
			this.txtDJMC.Text = "";
			this.txtDWMC.Text = "";
			this.txtDJZH.Focus();
		}
		private void btnFilter_Click(object sender, EventArgs e)
		{
		}
		private void SetHeaders()
		{
			this.tblResult.Columns.Add("R1");
			this.tblResult.Columns.Add("R2");
			this.tblResult.Columns.Add("F2");
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
			this.gridView1.Columns[0].Width = 150;
			this.gridView1.Columns[0].Visible = true;
			this.gridView1.Columns[1].Caption = "登记名称";
			this.gridView1.Columns[1].FieldName = "R2";
			this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[1].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[1].Width = 150;
			this.gridView1.Columns[2].Caption = "单位名称";
			this.gridView1.Columns[2].FieldName = "F2";
			this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
			this.gridView1.Columns[2].OptionsFilter.AllowFilter = false;
			this.gridView1.Columns[2].Width = 350;
		}
		private void frmBQ_Load(object sender, EventArgs e)
		{
			this.tblResult.TableName = "Result";
			this.SetHeaders();
			this.txtDJZH.Focus();
		}
		private void grvBQ_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
		private void grvBQ_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
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
				if (e.ColumnIndex == 0)
				{
					try
					{
						this.printPreviewDialog1.ShowDialog();
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.Message + "\r\n可能是没安装打印机！", "错误提示");
					}
				}
			}
		}
		private void grvBQ_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
		}
		private void printPreviewDialog1_Load(object sender, EventArgs e)
		{
			this.printPreviewDialog1.StartPosition = FormStartPosition.CenterScreen;
			this.printPreviewDialog1.WindowState = FormWindowState.Maximized;
			((PrintPreviewControl)this.printPreviewDialog1.Controls[0]).Zoom = 1.0;
			this.printPreviewDialog1.PrintPreviewControl.Columns = 2;
		}
		private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.intPageNum++;
		}
		private void printDocument1_EndPrint(object sender, PrintEventArgs e)
		{
			this.intPageNum = 0;
		}
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			int num = 20;
			int num2 = 15;
			int num3 = 300;
			int num4 = 315;
			int width = 745;
			int num5 = 11;
			float num6 = 100f;
			float num7 = 5f;
			int num8 = 770;
			int num9 = 1120;
			Pen pen = new Pen(Color.Black);
			Font font = new Font("宋体", (float)num5, FontStyle.Regular);
			Font font2 = new Font("宋体", 14f, FontStyle.Bold);
			Brush brush = new SolidBrush(Color.Black);
			SizeF sizeF = new SizeF(12f, 12f);
			RectangleF rectangleF = new RectangleF(10f, (float)num2, sizeF.Width, sizeF.Height);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			stringFormat.LineAlignment = StringAlignment.Far;
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2f), 5, 5, num8, num9);
			DataRow[] array = null;
			DataRow focusedDataRow = this.gridView1.GetFocusedDataRow();
			string str = focusedDataRow["R1"].ToString();
			array = MDIParent.dsBQ.Tables["bq"].Select("R1='" + str + "'");
			clsCommon clsCommon = new clsCommon();
			if (array != null && array.Length == 1)
			{
				if (array[0]["R1"].ToString().Trim() == "PD20060003")
				{
					clsCommon.RunProcess("IEXPLORE.EXE", Directory.GetCurrentDirectory() + "\\lblImage\\PD20060003.jpg");
				}
				if (array[0]["R1"].ToString().Trim() == "PD20060003F060050")
				{
					clsCommon.RunProcess("IEXPLORE.EXE", Directory.GetCurrentDirectory() + "\\lblImage\\PD20060003F060050.jpg");
				}
				if (array[0]["R1"].ToString().Trim() == "PD20060033")
				{
					clsCommon.RunProcess("IEXPLORE.EXE", Directory.GetCurrentDirectory() + "\\lblImage\\PD20060033.jpg");
				}
				if (array[0]["R1"].ToString().Trim() == "PD20060033F060051")
				{
					clsCommon.RunProcess("IEXPLORE.EXE", Directory.GetCurrentDirectory() + "\\lblImage\\PD20060033F060051.jpg");
				}
				if (array[0]["R1"].ToString().Trim() != "PD20060003" && array[0]["R1"].ToString().Trim() != "PD20060003F060050" && array[0]["R1"].ToString().Trim() != "PD20060033" && array[0]["R1"].ToString().Trim() != "PD20060033F060051")
				{
					DataRow[] array2 = MDIParent.dsP.Tables["P"].Select("R1='" + array[0]["R1"].ToString() + "'");
					DataRow[] array3 = null;
					if (array2.Length == 1)
					{
						array3 = MDIParent.dsF.Tables["F"].Select("F2='" + array2[0]["F2"].ToString() + "'");
					}
					if (array2.Length > 0 && array3.Length > 0)
					{
						rectangleF.X = (float)num;
						rectangleF.Y = (float)num2;
						if (this.intPageNum == 1)
						{
							stringFormat.Alignment = StringAlignment.Center;
							stringFormat.LineAlignment = StringAlignment.Center;
							if (array2[0]["R12"].ToString().IndexOf("鼠") >= 0)
							{
								sizeF = e.Graphics.MeasureString("防伪标识", font2);
								rectangleF.Width = 250f;
								rectangleF.Height = 54f + num7;
								e.Graphics.DrawString("防伪标识", font2, brush, rectangleF, stringFormat);
							}
							else
							{
								sizeF = e.Graphics.MeasureString(array[0]["B6"].ToString(), font2);
								rectangleF.Width = 250f;
								rectangleF.Height = 54f + num7;
								e.Graphics.DrawString(array[0]["B6"].ToString(), font2, brush, rectangleF, stringFormat);
							}
							stringFormat.Alignment = StringAlignment.Near;
							stringFormat.LineAlignment = StringAlignment.Far;
							rectangleF.X = (float)num3;
							if (array[0]["R1"].ToString().IndexOf("L") >= 0)
							{
								sizeF = e.Graphics.MeasureString("农药临时登记证号：" + array[0]["R1"].ToString(), font);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString("农药临时登记证号：" + array[0]["R1"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
							}
							else
							{
								sizeF = e.Graphics.MeasureString("农药登记证号：" + array[0]["R1"].ToString(), font);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString("农药登记证号：" + array[0]["R1"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
							}
							sizeF = e.Graphics.MeasureString("农药生产许可证（或生产批准文件）号：", font);
							rectangleF.Width = sizeF.Width;
							rectangleF.Height = sizeF.Height;
							e.Graphics.DrawString("农药生产许可证（或生产批准文件）号：", font, brush, rectangleF, stringFormat);
							rectangleF.Y += rectangleF.Height;
							sizeF = e.Graphics.MeasureString("产品标准号：", font);
							rectangleF.Width = sizeF.Width;
							rectangleF.Height = sizeF.Height;
							e.Graphics.DrawString("产品标准号：", font, brush, rectangleF, stringFormat);
							rectangleF.Y += rectangleF.Height;
							stringFormat.Alignment = StringAlignment.Center;
							sizeF = e.Graphics.MeasureString("\r\n" + array2[0]["R2"].ToString(), font2);
							rectangleF.Width = (float)num4;
							rectangleF.Height = sizeF.Height;
							e.Graphics.DrawString("\r\n" + array2[0]["R2"].ToString(), font2, brush, rectangleF, stringFormat);
							rectangleF.Y += rectangleF.Height;
							if (array2[0]["R7"].ToString().Trim().IndexOf('、') < 0)
							{
								if (array[0]["R1"].ToString().IndexOf("W") >= 0)
								{
									sizeF = e.Graphics.MeasureString(array2[0]["E2"].ToString() + array2[0]["R7"].ToString(), font2);
									rectangleF.Width = (float)num4;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString(array2[0]["E2"].ToString() + array2[0]["R7"].ToString(), font2, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								else
								{
									sizeF = e.Graphics.MeasureString("有效成分含量:" + array2[0]["R7"].ToString(), font2);
									rectangleF.Width = (float)num4;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString("有效成分含量:" + array2[0]["R7"].ToString(), font2, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
							}
							else
							{
								string[] array4 = array2[0]["E2"].ToString().Split(new char[]
								{
									'、'
								});
								string[] array5 = array2[0]["R7"].ToString().Split(new char[]
								{
									'、'
								});
								string text = "";
								for (int i = 0; i < array4.Length; i++)
								{
									if (text == "")
									{
										text = array4[i] + "含量" + array5[i];
									}
									else
									{
										string text2 = text;
										text = string.Concat(new string[]
										{
											text2,
											"\r\n",
											array4[i],
											"含量",
											array5[i]
										});
									}
								}
								if (text == "")
								{
									sizeF = e.Graphics.MeasureString("总有效成分含量:" + array2[0]["HL"].ToString(), font2);
									rectangleF.Width = (float)num4;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString("总有效成分含量:" + array2[0]["HL"].ToString(), font2, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								else
								{
									sizeF = e.Graphics.MeasureString("总有效成分含量:" + array2[0]["HL"].ToString() + "\r\n" + text, font2);
									rectangleF.Width = (float)num4;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString("总有效成分含量:" + array2[0]["HL"].ToString() + "\r\n" + text, font2, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
							}
							if (array[0]["R1"].ToString().IndexOf("W") < 0)
							{
								sizeF = e.Graphics.MeasureString("剂型:" + array2[0]["R13"].ToString(), font2);
								rectangleF.Width = (float)num4;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("剂型:" + array2[0]["R13"].ToString(), font2, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
							}
							if (array2[0]["R11"].ToString().Trim() == "低毒")
							{
								try
								{
									Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx3.JPG");
									rectangleF.Width = (float)image.Width;
									rectangleF.Height = (float)image.Height;
									e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
									rectangleF.Y += rectangleF.Height;
								}
								catch
								{
								}
							}
							else
							{
								try
								{
									string text3 = array2[0]["R11"].ToString();
									if (text3 != null)
									{
										if (!(text3 == "低毒(原药高毒)"))
										{
											if (!(text3 == "中等毒"))
											{
												if (!(text3 == "中等毒(原药高毒)"))
												{
													if (!(text3 == "中等毒(原药剧毒)"))
													{
														if (!(text3 == "高毒"))
														{
															if (text3 == "剧毒")
															{
																Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx1.JPG");
																rectangleF.Width = (float)image.Width;
																rectangleF.Height = (float)image.Height;
																e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
																rectangleF.Y += rectangleF.Height;
															}
														}
														else
														{
															Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx1.JPG");
															rectangleF.Width = (float)image.Width;
															rectangleF.Height = (float)image.Height;
															e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
															rectangleF.Y += rectangleF.Height;
														}
													}
													else
													{
														Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx2.JPG");
														rectangleF.Width = (float)image.Width;
														rectangleF.Height = (float)image.Height;
														e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
														rectangleF.Y += rectangleF.Height;
													}
												}
												else
												{
													Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx2.JPG");
													rectangleF.Width = (float)image.Width;
													rectangleF.Height = (float)image.Height;
													e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
													rectangleF.Y += rectangleF.Height;
												}
											}
											else
											{
												Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx2.JPG");
												rectangleF.Width = (float)image.Width;
												rectangleF.Height = (float)image.Height;
												e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
												rectangleF.Y += rectangleF.Height;
											}
										}
										else
										{
											Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/dx3.JPG");
											rectangleF.Width = (float)image.Width;
											rectangleF.Height = (float)image.Height;
											e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
											rectangleF.Y += rectangleF.Height;
										}
									}
								}
								catch
								{
								}
								sizeF = e.Graphics.MeasureString("\r\n", font);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("\r\n", font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								brush = new SolidBrush(Color.Red);
								font = new Font("宋体", (float)num5, FontStyle.Bold);
								if (array2[0]["R11"].ToString().IndexOf("(") >= 0)
								{
									if (array2[0]["R11"].ToString() != "低毒(原药高毒)")
									{
										sizeF = e.Graphics.MeasureString(array2[0]["R11"].ToString().Substring(0, array2[0]["R11"].ToString().IndexOf('(')) + "\r\n", font);
										rectangleF.Width = (float)num4;
										rectangleF.Height = sizeF.Height;
										e.Graphics.DrawString(array2[0]["R11"].ToString().Substring(0, array2[0]["R11"].ToString().IndexOf('(')) + "\r\n", font, brush, rectangleF, stringFormat);
										rectangleF.Y += rectangleF.Height;
									}
									sizeF = e.Graphics.MeasureString(array2[0]["R11"].ToString().Substring(array2[0]["R11"].ToString().IndexOf('(')), font);
									rectangleF.Width = (float)num4;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString(array2[0]["R11"].ToString().Substring(array2[0]["R11"].ToString().IndexOf('(')), font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								else
								{
									sizeF = e.Graphics.MeasureString(array2[0]["R11"].ToString(), font);
									rectangleF.Width = (float)num4;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString(array2[0]["R11"].ToString(), font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								brush = new SolidBrush(Color.Black);
								font = new Font("宋体", (float)num5, FontStyle.Regular);
							}
							if (array2[0]["R12"].ToString().IndexOf("鼠") >= 0)
							{
								try
								{
									Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/mouse.JPG");
									rectangleF.Width = (float)image.Width;
									rectangleF.Height = (float)image.Height;
									e.Graphics.DrawImageUnscaled(image, Convert.ToInt32(rectangleF.Left) + Convert.ToInt32((double)num4 / 2.5), Convert.ToInt32(rectangleF.Top));
									rectangleF.Y += rectangleF.Height;
								}
								catch
								{
								}
							}
							stringFormat.Alignment = StringAlignment.Near;
							rectangleF.X = (float)num;
							string[] array6 = array2[0]["C2"].ToString().Split(new char[]
							{
								'|'
							});
							string[] array7 = array2[0]["T2"].ToString().Split(new char[]
							{
								'|'
							});
							string[] array8 = array2[0]["R15"].ToString().Split(new char[]
							{
								'|'
							});
							string[] array9 = array2[0]["R14"].ToString().Split(new char[]
							{
								'|'
							});
							float num10 = 0f;
							float num11 = 0f;
							float num12 = 0f;
							float num13 = 0f;
							bool flag = false;
							for (int j = 0; j < array6.Length; j++)
							{
								if (array6.Length == 1 && array6[0] == "")
								{
									break;
								}
								flag = true;
								if (j == 0)
								{
									sizeF = e.Graphics.MeasureString("\r\n使用技术和使用方法:", font2);
									rectangleF.Width = sizeF.Width + num6;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawString("\r\n使用技术和使用方法:", font2, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
									rectangleF.X = (float)num;
									sizeF = e.Graphics.MeasureString("作物(或范围)", font);
									rectangleF.Width = sizeF.Width + num6;
									num10 = rectangleF.Width;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString("作物(或范围)", font, brush, rectangleF, stringFormat);
									rectangleF.X += rectangleF.Width;
									sizeF = e.Graphics.MeasureString("防治对象", font);
									rectangleF.Width = sizeF.Width + num6;
									num11 = rectangleF.Width;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString("防治对象", font, brush, rectangleF, stringFormat);
									rectangleF.X += rectangleF.Width;
									sizeF = e.Graphics.MeasureString("制剂用药量", font);
									rectangleF.Width = sizeF.Width + num6;
									num12 = rectangleF.Width;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString("制剂用药量", font, brush, rectangleF, stringFormat);
									rectangleF.X += rectangleF.Width;
									sizeF = e.Graphics.MeasureString("使用方法", font);
									rectangleF.Width = sizeF.Width + num6;
									num13 = rectangleF.Width;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString("使用方法", font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
									sizeF = e.Graphics.MeasureString(array6[j], font, Convert.ToInt32(num10));
									float height = sizeF.Height;
									sizeF = e.Graphics.MeasureString(array7[j], font, Convert.ToInt32(num11));
									if (sizeF.Height > height)
									{
										height = sizeF.Height;
									}
									sizeF = e.Graphics.MeasureString(array8[j], font, Convert.ToInt32(num12));
									if (sizeF.Height > height)
									{
										height = sizeF.Height;
									}
									sizeF = e.Graphics.MeasureString(array9[j], font, Convert.ToInt32(num13));
									if (sizeF.Height > height)
									{
										height = sizeF.Height;
									}
									if (height > e.Graphics.MeasureString("车", font).Height)
									{
										stringFormat.LineAlignment = StringAlignment.Center;
									}
									else
									{
										stringFormat.LineAlignment = StringAlignment.Far;
									}
									rectangleF.X = (float)num;
									rectangleF.Width = num10;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array6[j], font, brush, rectangleF, stringFormat);
									rectangleF.X += num10;
									rectangleF.Width = num11;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array7[j], font, brush, rectangleF, stringFormat);
									rectangleF.X += num11;
									rectangleF.Width = num12;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array8[j], font, brush, rectangleF, stringFormat);
									rectangleF.X += num12;
									rectangleF.Width = num13;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array9[j], font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								else
								{
									sizeF = e.Graphics.MeasureString(array6[j], font, Convert.ToInt32(num10));
									float height = sizeF.Height;
									sizeF = e.Graphics.MeasureString(array7[j], font, Convert.ToInt32(num11));
									if (sizeF.Height > height)
									{
										height = sizeF.Height;
									}
									sizeF = e.Graphics.MeasureString(array8[j], font, Convert.ToInt32(num12));
									if (sizeF.Height > height)
									{
										height = sizeF.Height;
									}
									sizeF = e.Graphics.MeasureString(array9[j], font, Convert.ToInt32(num13));
									if (sizeF.Height > height)
									{
										height = sizeF.Height;
									}
									if (height > e.Graphics.MeasureString("车", font).Height)
									{
										stringFormat.LineAlignment = StringAlignment.Center;
									}
									else
									{
										stringFormat.LineAlignment = StringAlignment.Far;
									}
									rectangleF.X = (float)num;
									rectangleF.Width = num10;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array6[j], font, brush, rectangleF, stringFormat);
									rectangleF.X += num10;
									rectangleF.Width = num11;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array7[j], font, brush, rectangleF, stringFormat);
									rectangleF.X += num11;
									rectangleF.Width = num12;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array8[j], font, brush, rectangleF, stringFormat);
									rectangleF.X += num12;
									rectangleF.Width = num13;
									rectangleF.Height = height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
									e.Graphics.DrawString(array9[j], font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
							}
							stringFormat.LineAlignment = StringAlignment.Far;
							rectangleF.X = (float)num;
							float num14 = 0f;
							if (flag)
							{
								if (array[0]["R1"].ToString().IndexOf("W") < 0)
								{
									font = new Font("华文仿宋", 9f, FontStyle.Regular);
									sizeF = e.Graphics.MeasureString("(注:(1)公顷用制剂量=亩用制剂量×15\r\n      (2)总有效成分量浓度值(毫克/千克)=(制剂含量×1000000)÷制剂稀释倍数)", font, Convert.ToInt32(num10 + num11 + num12 + num13));
									rectangleF.Width = sizeF.Width;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawString("(注:(1)公顷用制剂量=亩用制剂量×15\r\n      (2)总有效成分量浓度值(毫克/千克)=(制剂含量×1000000)÷制剂稀释倍数)", font, brush, rectangleF, stringFormat);
									font = new Font("宋体", (float)num5, FontStyle.Regular);
									rectangleF.Y += rectangleF.Height;
									num14 = rectangleF.Height;
									sizeF = e.Graphics.MeasureString(array[0]["B5"].ToString(), font, Convert.ToInt32(num10 + num11 + num12 + num13));
									rectangleF.Width = sizeF.Width;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top - num14, (float)Convert.ToInt32(num10 + num11 + num12 + num13), rectangleF.Height + num14);
									e.Graphics.DrawString(array[0]["B5"].ToString(), font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								else
								{
									sizeF = e.Graphics.MeasureString(array[0]["B5"].ToString(), font, Convert.ToInt32(num10 + num11 + num12 + num13));
									rectangleF.Width = sizeF.Width;
									rectangleF.Height = sizeF.Height + num7;
									e.Graphics.DrawRectangle(pen, rectangleF.Left, rectangleF.Top - num14, (float)Convert.ToInt32(num10 + num11 + num12 + num13), rectangleF.Height + num14);
									e.Graphics.DrawString(array[0]["B5"].ToString(), font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
							}
							if (!flag && array[0]["B5"].ToString().Trim() != "")
							{
								sizeF = e.Graphics.MeasureString("\r\n使用技术和使用方法:", font2);
								rectangleF.Width = sizeF.Width + num6;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString("\r\n使用技术和使用方法:", font2, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString(array[0]["B5"].ToString(), font, width);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString(array[0]["B5"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
							}
							if (array[0]["R1"].ToString().IndexOf("F") >= 0)
							{
								sizeF = e.Graphics.MeasureString("分装企业名称：" + array3[0]["F2"].ToString(), font);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString("分装企业名称：" + array3[0]["F2"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
							}
							else
							{
								sizeF = e.Graphics.MeasureString("生产企业名称：" + array3[0]["F2"].ToString(), font);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString("生产企业名称：" + array3[0]["F2"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
							}
							sizeF = e.Graphics.MeasureString(string.Concat(new string[]
							{
								"地址：",
								array3[0]["F4"].ToString(),
								array3[0]["F5"].ToString(),
								array3[0]["F6"].ToString(),
								array3[0]["F7"].ToString(),
								"邮编：",
								array3[0]["F11"].ToString()
							}), font);
							rectangleF.Width = sizeF.Width;
							rectangleF.Height = sizeF.Height;
							e.Graphics.DrawString(string.Concat(new string[]
							{
								"地址：",
								array3[0]["F4"].ToString(),
								array3[0]["F5"].ToString(),
								array3[0]["F6"].ToString(),
								array3[0]["F7"].ToString(),
								"邮编：",
								array3[0]["F11"].ToString()
							}), font, brush, rectangleF, stringFormat);
							rectangleF.Y += rectangleF.Height;
							sizeF = e.Graphics.MeasureString(string.Concat(new string[]
							{
								"电话：",
								array3[0]["F9"].ToString(),
								" 传真：",
								array3[0]["F10"].ToString(),
								" 网址：",
								array3[0]["F13"].ToString()
							}), font);
							rectangleF.Width = sizeF.Width;
							rectangleF.Height = sizeF.Height;
							e.Graphics.DrawString(string.Concat(new string[]
							{
								"电话：",
								array3[0]["F9"].ToString(),
								" 传真：",
								array3[0]["F10"].ToString(),
								" 网址：",
								array3[0]["F13"].ToString()
							}), font, brush, rectangleF, stringFormat);
							rectangleF.Y += rectangleF.Height;
							if (array[0]["R1"].ToString().IndexOf("W") < 0)
							{
								string text4 = "#FFFFFF";
								string a = "0";
								string text3 = array2[0]["R12"].ToString();
								switch (text3)
								{
								case "杀鼠剂":
									text4 = "#0000FF";
									break;
								case "杀虫剂":
									text4 = "#FF0000";
									break;
								case "杀螨剂":
									text4 = "#FF0000";
									break;
								case "杀螺剂":
									text4 = "#FF0000";
									break;
								case "杀菌剂":
									text4 = "#000000";
									break;
								case "杀线虫剂":
									text4 = "#000000";
									break;
								case "除草剂":
									text4 = "#00FF00";
									break;
								case "植物生长调节剂":
									text4 = "#FFCC00";
									break;
								case "杀虫剂/杀螨剂":
									text4 = "#FF0000";
									break;
								case "杀螨剂/杀虫剂":
									text4 = "#FF0000";
									break;
								case "杀虫剂/杀菌剂":
									text4 = "#000000";
									a = "1";
									break;
								case "杀线虫剂/杀菌剂":
									text4 = "#000000";
									break;
								case "杀虫剂/卫生杀虫剂":
									text4 = "#FF0000";
									break;
								case "昆虫生长调节剂":
									text4 = "#FF0000";
									break;
								case "除草剂/植物生长调节剂":
									a = "1";
									break;
								case "杀菌剂/杀虫剂":
									a = "1";
									break;
								case "杀螨剂/杀菌剂":
									a = "1";
									break;
								case "杀菌剂/植物生长调节剂":
									a = "1";
									break;
								case "杀虫剂/杀线虫剂":
									a = "1";
									break;
								}
								rectangleF.Width = (float)(num8 - num);
								stringFormat.Alignment = StringAlignment.Center;
								stringFormat.LineAlignment = StringAlignment.Center;
								ColorConverter colorConverter = new ColorConverter();
								if (a == "0")
								{
									sizeF = e.Graphics.MeasureString(array2[0]["R12"].ToString(), font);
									rectangleF.Height = sizeF.Height + num7;
									rectangleF.Y = (float)num9 - rectangleF.Height;
									if (text4 == "#000000")
									{
										brush = new SolidBrush(Color.White);
										e.Graphics.FillRectangle(new SolidBrush((Color)colorConverter.ConvertFromString(text4)), rectangleF);
										rectangleF.Y += 2f;
										e.Graphics.DrawString(array2[0]["R12"].ToString(), font, brush, rectangleF, stringFormat);
										rectangleF.Y -= 2f;
										brush = new SolidBrush(Color.Black);
									}
									else
									{
										e.Graphics.FillRectangle(new SolidBrush((Color)colorConverter.ConvertFromString(text4)), rectangleF);
										rectangleF.Y += 2f;
										e.Graphics.DrawString(array2[0]["R12"].ToString(), font, brush, rectangleF, stringFormat);
										rectangleF.Y -= 2f;
									}
								}
								else
								{
									string text5 = "#000000";
									string text6 = "#000000";
									string text7 = "#000000";
									string text8 = "";
									string text9 = "";
									text3 = array2[0]["R12"].ToString();
									if (text3 != null)
									{
										if (!(text3 == "杀虫剂/杀菌剂"))
										{
											if (!(text3 == "除草剂/植物生长调节剂"))
											{
												if (!(text3 == "杀菌剂/杀虫剂"))
												{
													if (!(text3 == "杀螨剂/杀菌剂"))
													{
														if (!(text3 == "杀菌剂/植物生长调节剂"))
														{
															if (text3 == "杀虫剂/杀线虫剂")
															{
																text8 = "杀虫剂";
																text4 = "#FF0000";
																text6 = "#000000";
																text9 = "杀线虫剂";
																text5 = "#000000";
																text7 = "#FFFFFF";
															}
														}
														else
														{
															text8 = "杀菌剂";
															text4 = "#000000";
															text6 = "#FFFFFF";
															text9 = "植物生长调节剂";
															text5 = "#FFFF00";
															text7 = "#000000";
														}
													}
													else
													{
														text8 = "杀螨剂";
														text4 = "#FF0000";
														text6 = "#000000";
														text9 = "杀菌剂";
														text5 = "#000000";
														text7 = "#FFFFFF";
													}
												}
												else
												{
													text8 = "杀菌剂";
													text4 = "#000000";
													text6 = "#FFFFFF";
													text9 = "杀虫剂";
													text5 = "#FF0000";
													text7 = "#000000";
												}
											}
											else
											{
												text8 = "除草剂";
												text4 = "#00FF00";
												text6 = "#000000";
												text9 = "植物生长调节剂";
												text5 = "#FFFF00";
												text7 = "#000000";
											}
										}
										else
										{
											text8 = "杀虫剂";
											text4 = "#FF0000";
											text6 = "#000000";
											text9 = "杀菌剂";
											text5 = "#000000";
											text7 = "#FFFFFF";
										}
									}
									sizeF = e.Graphics.MeasureString(text9, font);
									rectangleF.Height = sizeF.Height + num7;
									rectangleF.Y = (float)num9 - rectangleF.Height;
									brush = new SolidBrush((Color)colorConverter.ConvertFromString(text7));
									e.Graphics.FillRectangle(new SolidBrush((Color)colorConverter.ConvertFromString(text5)), rectangleF);
									rectangleF.Y += 2f;
									e.Graphics.DrawString(text9, font, brush, rectangleF, stringFormat);
									rectangleF.Y -= 2f;
									sizeF = e.Graphics.MeasureString(text8, font);
									rectangleF.Height = sizeF.Height;
									rectangleF.Y -= rectangleF.Height;
									brush = new SolidBrush((Color)colorConverter.ConvertFromString(text6));
									e.Graphics.FillRectangle(new SolidBrush((Color)colorConverter.ConvertFromString(text4)), rectangleF);
									rectangleF.Y += 2f;
									e.Graphics.DrawString(text8, font, brush, rectangleF, stringFormat);
									rectangleF.Y -= 2f;
									brush = new SolidBrush(Color.Black);
								}
								stringFormat.Alignment = StringAlignment.Near;
								stringFormat.LineAlignment = StringAlignment.Far;
							}
							this.intPageNum = 2;
							e.HasMorePages = true;
						}
						else
						{
							if (this.intPageNum == 2)
							{
								sizeF = e.Graphics.MeasureString("产品性能（用途）：", font2);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("产品性能（用途）：", font2, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString(array[0]["B1"].ToString(), font, width);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString(array[0]["B1"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString("注意事项：", font2);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("注意事项：", font2, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString(array[0]["B2"].ToString(), font, width);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString(array[0]["B2"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString("中毒急救：", font2);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("中毒急救：", font2, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString(array[0]["B3"].ToString(), font, width);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString(array[0]["B3"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString("储存和运输：", font2);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("储存和运输：", font2, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								sizeF = e.Graphics.MeasureString(array[0]["B4"].ToString(), font, width);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height + num7;
								e.Graphics.DrawString(array[0]["B4"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								if (array[0]["B8"].ToString().Trim() != "")
								{
									sizeF = e.Graphics.MeasureString(array[0]["B8"].ToString(), font);
									rectangleF.Width = sizeF.Width;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString(array[0]["B8"].ToString(), font, brush, rectangleF, stringFormat);
									rectangleF.Y += rectangleF.Height;
								}
								if (array[0]["R1"].ToString().IndexOf("F") >= 0)
								{
									string text10 = array[0]["R1"].ToString().Substring(0, array[0]["R1"].ToString().IndexOf("F"));
									if (text10.Substring(text10.Length - 1) == "-")
									{
										text10 = text10.Substring(0, text10.Length - 1);
									}
									DataRow[] array10 = MDIParent.dsP.Tables["P"].Select("R1='" + text10 + "'");
									DataRow[] array11 = null;
									if (array10.Length == 1)
									{
										array11 = MDIParent.dsF.Tables["F"].Select("F2='" + array10[0]["F2"].ToString() + "'");
									}
									if (array11.Length == 1 && array10.Length == 1)
									{
										sizeF = e.Graphics.MeasureString(string.Concat(new string[]
										{
											"原大包装生产企业:",
											array11[0]["F2"].ToString(),
											" 登记证号:",
											text10,
											"\r\n地址:",
											array11[0]["F4"].ToString(),
											array11[0]["F5"].ToString(),
											array11[0]["F6"].ToString(),
											array11[0]["F7"].ToString(),
											" 邮编:",
											array11[0]["F11"].ToString(),
											"\r\n电话:",
											array11[0]["F9"].ToString(),
											" 传真:",
											array11[0]["F10"].ToString(),
											"\r\n生产许可证或农药生产批准文件号:  生产日期和批号:"
										}), font);
										rectangleF.Width = sizeF.Width;
										rectangleF.Height = sizeF.Height;
										e.Graphics.DrawString(string.Concat(new string[]
										{
											"原大包装生产企业:",
											array11[0]["F2"].ToString(),
											" 登记证号:",
											text10,
											"\r\n地址:",
											array11[0]["F4"].ToString(),
											array11[0]["F5"].ToString(),
											array11[0]["F6"].ToString(),
											array11[0]["F7"].ToString(),
											" 邮编:",
											array11[0]["F11"].ToString(),
											"\r\n电话:",
											array11[0]["F9"].ToString(),
											" 传真:",
											array11[0]["F10"].ToString(),
											"\r\n生产许可证或农药生产批准文件号:  生产日期和批号:"
										}), font, brush, rectangleF, stringFormat);
										rectangleF.Y += rectangleF.Height;
									}
									else
									{
										sizeF = e.Graphics.MeasureString("原大包装生产企业: 登记证号:\r\n地址: 邮编:\r\n电话: 传真:\r\n生产许可证或农药生产批准文件号:   生产日期和批号:", font);
										rectangleF.Width = sizeF.Width;
										rectangleF.Height = sizeF.Height;
										e.Graphics.DrawString("原大包装生产企业: 登记证号:\r\n地址: 邮编:\r\n电话: 传真:\r\n生产许可证或农药生产批准文件号:   生产日期和批号:", font, brush, rectangleF, stringFormat);
										rectangleF.Y += rectangleF.Height;
									}
									sizeF = e.Graphics.MeasureString("\r\n净含量（重量）： 毫升（克） 分装日期:  年 月 日 批号: ", font);
									rectangleF.Width = sizeF.Width;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString("\r\n净含量（重量）： 毫升（克） 分装日期:  年 月 日 批号: ", font, brush, rectangleF, stringFormat);
									rectangleF.X += rectangleF.Width;
								}
								else
								{
									sizeF = e.Graphics.MeasureString("\r\n净含量（重量）： 毫升（克） 生产日期:  年 月 日 批号: ", font);
									rectangleF.Width = sizeF.Width;
									rectangleF.Height = sizeF.Height;
									e.Graphics.DrawString("\r\n净含量（重量）： 毫升（克） 生产日期:  年 月 日 批号: ", font, brush, rectangleF, stringFormat);
									rectangleF.X += rectangleF.Width;
								}
								sizeF = e.Graphics.MeasureString("\r\n有效期：" + array[0]["B9"].ToString(), font);
								rectangleF.Width = sizeF.Width;
								rectangleF.Height = sizeF.Height;
								e.Graphics.DrawString("\r\n有效期：" + array[0]["B9"].ToString(), font, brush, rectangleF, stringFormat);
								rectangleF.Y += rectangleF.Height;
								if (array[0]["R1"].ToString().IndexOf("W") < 0)
								{
									string[] array12 = array[0]["B7"].ToString().Split(new char[]
									{
										'/'
									});
									rectangleF.Y = (float)(num9 - 40);
									rectangleF.X = (float)(num8 - 40 * array12.Length);
									for (int k = 0; k < array12.Length; k++)
									{
										try
										{
											Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/lblImage/" + array12[k] + ".JPG");
											rectangleF.Width = (float)image.Width;
											rectangleF.Height = (float)image.Height;
											e.Graphics.DrawImage(image, Convert.ToInt32(rectangleF.Left), Convert.ToInt32(rectangleF.Top), 40, 40);
											rectangleF.X += 40f;
										}
										catch
										{
										}
									}
								}
							}
						}
					}
				}
			}
		}
		private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
		{
			if (e.Column.FieldName.ToUpper() == "R1")
			{
				try
				{
					this.printPreviewDialog1.ShowDialog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, ex.Message + "\r\n可能是没安装打印机！", "错误提示");
				}
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
		private void frmBQ_Resize(object sender, EventArgs e)
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmBQ));
			this.lblCount = new Label();
			this.btnReset = new Button();
			this.btnSearch = new Button();
			this.panelcondition = new Panel();
			this.label2 = new Label();
			this.txtDJMC = new TextBox();
			this.label3 = new Label();
			this.txtDWMC = new TextBox();
			this.label1 = new Label();
			this.txtDJZH = new TextBox();
			this.printDocument1 = new PrintDocument();
			this.printPreviewDialog1 = new PrintPreviewDialog();
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
			this.lblCount.AutoSize = true;
			this.lblCount.BackColor = Color.Transparent;
			this.lblCount.Location = new Point(66, 59);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new Size(0, 14);
			this.lblCount.TabIndex = 14;
			this.btnReset.Location = new Point(72, 69);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new Size(50, 23);
			this.btnReset.TabIndex = 20;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new EventHandler(this.btnReset_Click);
			this.btnSearch.Location = new Point(10, 69);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new Size(50, 23);
			this.btnSearch.TabIndex = 19;
			this.btnSearch.Text = "查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
			this.panelcondition.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelcondition.Controls.Add(this.btnReset);
			this.panelcondition.Controls.Add(this.btnSearch);
			this.panelcondition.Controls.Add(this.label2);
			this.panelcondition.Controls.Add(this.txtDJMC);
			this.panelcondition.Controls.Add(this.lblCount);
			this.panelcondition.Controls.Add(this.label3);
			this.panelcondition.Controls.Add(this.txtDWMC);
			this.panelcondition.Controls.Add(this.label1);
			this.panelcondition.Controls.Add(this.txtDJZH);
			this.panelcondition.Location = new Point(3, 37);
			this.panelcondition.Name = "panelcondition";
			this.panelcondition.Size = new Size(562, 98);
			this.panelcondition.TabIndex = 18;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label2.Location = new Point(277, 12);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 14);
			this.label2.TabIndex = 18;
			this.label2.Text = "登记名称";
			this.txtDJMC.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtDJMC.ImeMode = ImeMode.On;
			this.txtDJMC.Location = new Point(340, 8);
			this.txtDJMC.Name = "txtDJMC";
			this.txtDJMC.Size = new Size(208, 23);
			this.txtDJMC.TabIndex = 17;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label3.Location = new Point(1, 43);
			this.label3.Name = "label3";
			this.label3.Size = new Size(63, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "单位名称";
			this.txtDWMC.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtDWMC.ImeMode = ImeMode.On;
			this.txtDWMC.Location = new Point(64, 39);
			this.txtDWMC.Name = "txtDWMC";
			this.txtDWMC.Size = new Size(484, 23);
			this.txtDWMC.TabIndex = 5;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.label1.Location = new Point(1, 12);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "登记证号";
			this.txtDJZH.CharacterCasing = CharacterCasing.Upper;
			this.txtDJZH.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.txtDJZH.Location = new Point(64, 8);
			this.txtDJZH.Name = "txtDJZH";
			this.txtDJZH.Size = new Size(208, 23);
			this.txtDJZH.TabIndex = 1;
			this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
			this.printDocument1.EndPrint += new PrintEventHandler(this.printDocument1_EndPrint);
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
			this.paneldata.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.paneldata.Controls.Add(this.gridControl1);
			this.paneldata.Location = new Point(18, 219);
			this.paneldata.Name = "paneldata";
			this.paneldata.Size = new Size(250, 100);
			this.paneldata.TabIndex = 28;
			this.gridControl1.Dock = DockStyle.Fill;
			this.gridControl1.Location = new Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new Size(250, 100);
			this.gridControl1.TabIndex = 18;
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
			this.panelmenu.Location = new Point(0, 132);
			this.panelmenu.Name = "panelmenu";
			this.panelmenu.Size = new Size(178, 430);
			this.panelmenu.TabIndex = 30;
			this.userManu1.BackColor = Color.FromArgb(107, 161, 179);
			this.userManu1.Dock = DockStyle.Fill;
			this.userManu1.Location = new Point(0, 0);
			this.userManu1.Name = "userManu1";
			this.userManu1.Size = new Size(178, 430);
			this.userManu1.TabIndex = 0;
			this.paneltop_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltop_right.Location = new Point(371, 33);
			this.paneltop_right.Name = "paneltop_right";
			this.paneltop_right.Size = new Size(414, 25);
			this.paneltop_right.TabIndex = 36;
			this.paneltop_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltop_middle.Location = new Point(195, 29);
			this.paneltop_middle.Name = "paneltop_middle";
			this.paneltop_middle.Size = new Size(165, 29);
			this.paneltop_middle.TabIndex = 35;
			this.paneltop_left.Location = new Point(12, 29);
			this.paneltop_left.Name = "paneltop_left";
			this.paneltop_left.Size = new Size(185, 29);
			this.paneltop_left.TabIndex = 34;
			this.paneltitle_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.paneltitle_right.Controls.Add(this.pictureBox3);
			this.paneltitle_right.Controls.Add(this.pictureBox2);
			this.paneltitle_right.Controls.Add(this.pictureBox1);
			this.paneltitle_right.Location = new Point(541, 0);
			this.paneltitle_right.Name = "paneltitle_right";
			this.paneltitle_right.Size = new Size(244, 25);
			this.paneltitle_right.TabIndex = 33;
			this.pictureBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(177, 2);
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
			this.pictureBox2.Location = new Point(199, 2);
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
			this.pictureBox1.Location = new Point(221, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(21, 21);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox1_MouseLeave);
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox1_MouseEnter);
			this.paneltitle_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.paneltitle_middle.Location = new Point(264, 0);
			this.paneltitle_middle.Name = "paneltitle_middle";
			this.paneltitle_middle.Size = new Size(280, 25);
			this.paneltitle_middle.TabIndex = 32;
			this.paneltitle_middle.MouseMove += new MouseEventHandler(this.paneltitle_middle_MouseMove);
			this.paneltitle_middle.MouseDown += new MouseEventHandler(this.paneltitle_middle_MouseDown);
			this.paneltitle_middle.MouseUp += new MouseEventHandler(this.paneltitle_middle_MouseUp);
			this.paneltitle_left.Location = new Point(0, 0);
			this.paneltitle_left.Name = "paneltitle_left";
			this.paneltitle_left.Size = new Size(264, 25);
			this.paneltitle_left.TabIndex = 31;
			this.panelright.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelright.Controls.Add(this.panelwhite);
			this.panelright.Controls.Add(this.pictureBox_right);
			this.panelright.Controls.Add(this.panel_middle);
			this.panelright.Controls.Add(this.pictureBox_left);
			this.panelright.Controls.Add(this.panelcondition);
			this.panelright.Location = new Point(215, 78);
			this.panelright.Name = "panelright";
			this.panelright.Size = new Size(570, 476);
			this.panelright.TabIndex = 37;
			this.panelwhite.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelwhite.Controls.Add(this.panelbutton);
			this.panelwhite.Controls.Add(this.paneldatasum);
			this.panelwhite.Controls.Add(this.paneldata);
			this.panelwhite.Location = new Point(7, 141);
			this.panelwhite.Name = "panelwhite";
			this.panelwhite.Size = new Size(558, 332);
			this.panelwhite.TabIndex = 32;
			this.panelbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panelbutton.Controls.Add(this.pictureBox_sum);
			this.panelbutton.Controls.Add(this.pictureBox_view);
			this.panelbutton.Controls.Add(this.pictureBox_sort);
			this.panelbutton.Controls.Add(this.pictureBox_filter);
			this.panelbutton.Location = new Point(6, 37);
			this.panelbutton.Name = "panelbutton";
			this.panelbutton.Size = new Size(538, 40);
			this.panelbutton.TabIndex = 30;
			this.pictureBox_sum.BackColor = Color.Transparent;
			this.pictureBox_sum.Cursor = Cursors.Hand;
			this.pictureBox_sum.Enabled = false;
			this.pictureBox_sum.Location = new Point(352, 9);
			this.pictureBox_sum.Name = "pictureBox_sum";
			this.pictureBox_sum.Size = new Size(65, 24);
			this.pictureBox_sum.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_sum.TabIndex = 3;
			this.pictureBox_sum.TabStop = false;
			this.pictureBox_sum.Visible = false;
			this.pictureBox_view.BackColor = Color.Transparent;
			this.pictureBox_view.Cursor = Cursors.Hand;
			this.pictureBox_view.Enabled = false;
			this.pictureBox_view.Location = new Point(253, 9);
			this.pictureBox_view.Name = "pictureBox_view";
			this.pictureBox_view.Size = new Size(65, 24);
			this.pictureBox_view.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_view.TabIndex = 2;
			this.pictureBox_view.TabStop = false;
			this.pictureBox_view.Visible = false;
			this.pictureBox_sort.BackColor = Color.Transparent;
			this.pictureBox_sort.Cursor = Cursors.Hand;
			this.pictureBox_sort.Enabled = false;
			this.pictureBox_sort.Location = new Point(154, 9);
			this.pictureBox_sort.Name = "pictureBox_sort";
			this.pictureBox_sort.Size = new Size(65, 24);
			this.pictureBox_sort.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_sort.TabIndex = 1;
			this.pictureBox_sort.TabStop = false;
			this.pictureBox_sort.Visible = false;
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
			this.paneldatasum.Size = new Size(538, 28);
			this.paneldatasum.TabIndex = 29;
			this.labeldatacount.BackColor = Color.Transparent;
			this.labeldatacount.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.labeldatacount.Location = new Point(41, 8);
			this.labeldatacount.Name = "labeldatacount";
			this.labeldatacount.Size = new Size(253, 14);
			this.labeldatacount.TabIndex = 0;
			this.pictureBox_right.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pictureBox_right.Location = new Point(530, 3);
			this.pictureBox_right.Name = "pictureBox_right";
			this.pictureBox_right.Size = new Size(38, 28);
			this.pictureBox_right.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_right.TabIndex = 31;
			this.pictureBox_right.TabStop = false;
			this.panel_middle.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.panel_middle.Controls.Add(this.label6);
			this.panel_middle.Location = new Point(72, 3);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new Size(328, 28);
			this.panel_middle.TabIndex = 30;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("宋体", 10.5f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.label6.Location = new Point(41, 7);
			this.label6.Name = "label6";
			this.label6.Size = new Size(253, 14);
			this.label6.TabIndex = 1;
			this.label6.Text = "农药标签信息查询";
			this.pictureBox_left.Location = new Point(3, 3);
			this.pictureBox_left.Name = "pictureBox_left";
			this.pictureBox_left.Size = new Size(17, 28);
			this.pictureBox_left.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox_left.TabIndex = 29;
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
			base.Name = "frmBQ";
			base.ShowInTaskbar = false;
			this.Text = "标签信息";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.frmBQ_Load);
			base.Resize += new EventHandler(this.frmBQ_Resize);
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
