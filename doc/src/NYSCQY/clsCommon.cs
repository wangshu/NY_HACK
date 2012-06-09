using System;
using System.Data;
using System.Diagnostics;
using System.IO;
namespace NYSCQY
{
	internal class clsCommon
	{
		public DataView FilterNY(DataView dvTblResult)
		{
			clsStr clsStr = new clsStr();
			if (MDIParent.strKeyWord != "")
			{
				string text = "";
				string[] array = clsStr.Seperate(MDIParent.strKeyWord, ' ');
				if (MDIParent.strFilterField == "")
				{
					string text2 = "";
					if (MDIParent.strAndOr == "or")
					{
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
					}
					else
					{
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
									text2 = text2 + " and R1 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
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
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R2 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and R2 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "HL like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or HL like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "HL like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and HL like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R13 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or R13 like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R13 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and R13 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "F2 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or F2 like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "F2 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and F2 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R4 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or R4 like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R4 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and R4 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R5 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or R5 like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R5 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and R5 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R11 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or R11 like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R11 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and R11 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
					text2 = "";
					if (MDIParent.strAndOr == "or")
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R12 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " or R12 like '%" + array[i] + "%'";
								}
							}
						}
					}
					else
					{
						for (int i = 0; i < array.Length; i++)
						{
							if (!(array[i] == ""))
							{
								if (text2 == "")
								{
									text2 = "R12 like '%" + array[i] + "%'";
								}
								else
								{
									text2 = text2 + " and R12 like '%" + array[i] + "%'";
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
							text = text + " or (" + text2 + ")";
						}
					}
				}
				else
				{
					string[] array2 = clsStr.Seperate(MDIParent.strFilterField, '|');
					for (int j = 0; j < array2.Length; j++)
					{
						string text3 = array2[j];
						switch (text3)
						{
						case "R1":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
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
							}
							else
							{
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
											text2 = text2 + " and R1 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "R2":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
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
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R2 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and R2 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "HL":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "HL like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or HL like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "HL like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and HL like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "R12":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R12 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or R12 like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R12 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and R12 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "F2":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "F2 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or F2 like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "F2 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and F2 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "R4":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R4 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or R4 like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R4 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and R4 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "R5":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R5 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or R5 like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R5 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and R5 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "R13":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R13 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or R13 like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R13 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and R13 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						case "R11":
						{
							string text2 = "";
							if (MDIParent.strAndOr == "or")
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R11 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " or R11 like '%" + array[i] + "%'";
										}
									}
								}
							}
							else
							{
								for (int i = 0; i < array.Length; i++)
								{
									if (!(array[i] == ""))
									{
										if (text2 == "")
										{
											text2 = "R11 like '%" + array[i] + "%'";
										}
										else
										{
											text2 = text2 + " and R11 like '%" + array[i] + "%'";
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
									text = text + " or (" + text2 + ")";
								}
							}
							break;
						}
						}
					}
				}
				dvTblResult.RowFilter = text;
				dvTblResult.Sort = "";
			}
			return dvTblResult;
		}
		public DataView Filter(DataView dvTblResult)
		{
			clsStr clsStr = new clsStr();
			if (MDIParent.strKeyWord != "")
			{
				string text = "";
				for (int i = 0; i < dvTblResult.Table.Columns.Count; i++)
				{
					if (text == "")
					{
						text = dvTblResult.Table.Columns[i].ColumnName + " like '%" + MDIParent.strKeyWord + "%'";
					}
					else
					{
						string text2 = text;
						text = string.Concat(new string[]
						{
							text2,
							" or ",
							dvTblResult.Table.Columns[i].ColumnName,
							" like '%",
							MDIParent.strKeyWord,
							"%'"
						});
					}
				}
				dvTblResult.RowFilter = text;
			}
			return dvTblResult;
		}
		public DataTable GetFile(string strFileName)
		{
			DataSet dataSet = new DataSet();
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			clsMe.GetFile(Directory.GetCurrentDirectory() + "\\" + strFileName + ".dat", Directory.GetCurrentDirectory() + "\\" + strFileName + ".zip");
			clsCompression.UnZipFile(Directory.GetCurrentDirectory() + "\\" + strFileName + ".zip", Directory.GetCurrentDirectory() + "\\" + strFileName + ".xml");
			dataSet.ReadXml(Directory.GetCurrentDirectory() + "\\" + strFileName + ".xml", XmlReadMode.ReadSchema);
			File.Delete(Directory.GetCurrentDirectory() + "\\" + strFileName + ".zip");
			File.Delete(Directory.GetCurrentDirectory() + "\\" + strFileName + ".xml");
			return dataSet.Tables[0];
		}
		public DataTable GetFileData(string strFileName)
		{
			DataSet dataSet = new DataSet();
			clsMe clsMe = new clsMe();
			clsCompression clsCompression = new clsCompression();
			clsMe.GetFile(Directory.GetCurrentDirectory() + "\\" + strFileName + ".dat", Directory.GetCurrentDirectory() + "\\" + strFileName + ".zip");
			clsCompression.UnZipFile(Directory.GetCurrentDirectory() + "\\" + strFileName + ".zip", Directory.GetCurrentDirectory() + "\\" + strFileName + ".xml");
			dataSet.ReadXml(Directory.GetCurrentDirectory() + "\\" + strFileName + ".xml", XmlReadMode.ReadSchema);
			File.Delete(Directory.GetCurrentDirectory() + "\\" + strFileName + ".zip");
			File.Delete(Directory.GetCurrentDirectory() + "\\" + strFileName + ".xml");
			return dataSet.Tables[0];
		}
		public void RunProcess(string strFileName)
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = strFileName;
				try
				{
					process.Start();
				}
				catch
				{
				}
			}
		}
		public void RunProcess(string strFileName, string strArguments)
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = strFileName;
				process.StartInfo.Arguments = strArguments;
				process.Start();
			}
		}
	}
}
