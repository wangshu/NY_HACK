using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace NYSCQY
{
	internal class clsMe
	{
		public class clsMeException : ApplicationException
		{
			public clsMeException(string msg) : base(msg)
			{
			}
		}
		private const ulong FC_TAG = 18158797384510146255uL;
		private const int BUFFER_SIZE = 131072;
		private SymmetricAlgorithm mobjCryptoService = new RijndaelManaged();
		private string Key = "nv24^E39%0_~!am$^@#";
		private static RandomNumberGenerator rand = new RNGCryptoServiceProvider();
		private string GetFields(string strTableName)
		{
			string result = "";
			switch (strTableName)
			{
			case "P":
				result = "R1|R2|HL|F2|R5|F9|F14|R80|";
				break;
			case "F":
				result = "F2|F9|F14|";
				break;
			case "AED":
				result = "E2|E3|";
				break;
			case "bq":
				result = "R1|R2|";
				break;
			case "SYZZ":
				result = "C1|C2|";
				break;
			case "t14":
				result = "BH|CPMC|QYMC|";
				break;
			case "t15":
				result = "CPMC|FMISPCNAME|";
				break;
			}
			return result;
		}
		public string GetVolumeID()
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
			string result;
			try
			{
				managementObject.Get();
				result = managementObject.GetPropertyValue("VolumeSerialNumber").ToString();
				return result;
			}
			catch
			{
			}
			result = "ABC";
			return result;
		}
		public string ConvertData(string strSource)
		{
			this.Key = "@#*&^%3861wfkx/\\";
			string result = this.Encrypto(strSource);
			this.Key = "nv24^E39%0_~!am$^@#";
			return result;
		}
		public void ConvertData(DataSet dsSource, string strTableName)
		{
			this.ConvertData(dsSource, strTableName, this.GetFields(strTableName));
		}
		public void ConvertData(DataSet dsSource, string strTableName, string strFields)
		{
			for (int i = 0; i < dsSource.Tables[strTableName].Rows.Count; i++)
			{
				for (int j = 0; j < dsSource.Tables[strTableName].Columns.Count; j++)
				{
					if (dsSource.Tables[strTableName].Rows[i][j].ToString().Trim() != "")
					{
						if (strFields.IndexOf(dsSource.Tables[strTableName].Columns[j].ColumnName + "|") >= 0)
						{
							string source = dsSource.Tables[strTableName].Rows[i][j].ToString().Trim();
							dsSource.Tables[strTableName].Rows[i][j] = this.Encrypto(source);
						}
					}
				}
			}
		}
		public DataSet GetData(DataSet dsSource, string strTableName)
		{
			return this.GetData(dsSource, strTableName, this.GetFields(strTableName));
		}
		public DataSet GetData(DataSet dsSource, string strTableName, string strFields)
		{
			for (int i = 0; i < dsSource.Tables[strTableName].Rows.Count; i++)
			{
				for (int j = 0; j < dsSource.Tables[strTableName].Columns.Count; j++)
				{
					if (dsSource.Tables[strTableName].Rows[i][j].ToString().Trim() != "")
					{
						if (strFields.IndexOf(dsSource.Tables[strTableName].Columns[j].ColumnName + "|") >= 0)
						{
							dsSource.Tables[strTableName].Rows[i][j] = this.Decrypto(dsSource.Tables[strTableName].Rows[i][j].ToString().Trim());
						}
					}
				}
			}
			return dsSource;
		}
		public void ConvertFile(string strFromFile, string strToFile)
		{
			clsMe.EncryptFile(strFromFile, strToFile, "nv86^E39%0_~!f3$^@#");
		}
		public void GetFile(string strFromFile, string strToFile)
		{
			clsMe.DecryptFile(strFromFile, strToFile, "nv86^E39%0_~!f3$^@#");
		}
		private byte[] GetLegalKey()
		{
			string text = this.Key;
			this.mobjCryptoService.GenerateKey();
			byte[] key = this.mobjCryptoService.Key;
			int num = key.Length;
			if (text.Length > num)
			{
				text = text.Substring(0, num);
			}
			else
			{
				if (text.Length < num)
				{
					text = text.PadRight(num, ' ');
				}
			}
			return Encoding.ASCII.GetBytes(text);
		}
		private byte[] GetLegalIV()
		{
			string text = "#";
			this.mobjCryptoService.GenerateIV();
			byte[] iV = this.mobjCryptoService.IV;
			int num = iV.Length;
			if (text.Length > num)
			{
				text = text.Substring(0, num);
			}
			else
			{
				if (text.Length < num)
				{
					text = text.PadRight(num, ' ');
				}
			}
			return Encoding.ASCII.GetBytes(text);
		}
		public string Encrypto(string Source)
		{
			byte[] bytes = Encoding.Default.GetBytes(Source);
			MemoryStream memoryStream = new MemoryStream();
			this.mobjCryptoService.Key = this.GetLegalKey();
			this.mobjCryptoService.IV = this.GetLegalIV();
			ICryptoTransform transform = this.mobjCryptoService.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			memoryStream.Close();
			byte[] array = memoryStream.ToArray();
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				byte b = array2[i];
				stringBuilder.AppendFormat("{0:X2}", b);
			}
			return stringBuilder.ToString();
		}
		public string Decrypto(string Source)
		{
			MemoryStream memoryStream = new MemoryStream();
			this.mobjCryptoService.Key = this.GetLegalKey();
			this.mobjCryptoService.IV = this.GetLegalIV();
			ICryptoTransform transform = this.mobjCryptoService.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array = new byte[Source.Length / 2];
			for (int i = 0; i < Source.Length / 2; i++)
			{
				array[i] = Convert.ToByte("0x" + Source.Substring(i * 2, 2), 16);
			}
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			string @string = Encoding.Default.GetString(memoryStream.ToArray());
			memoryStream.Close();
			return @string;
		}
		private static bool CheckByteArrays(byte[] b1, byte[] b2)
		{
			bool result;
			if (b1.Length == b2.Length)
			{
				for (int i = 0; i < b1.Length; i++)
				{
					if (b1[i] != b2[i])
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}
		private static SymmetricAlgorithm CreateRijndael(string password, byte[] salt)
		{
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, salt, "SHA256", 1000);
			SymmetricAlgorithm symmetricAlgorithm = Rijndael.Create();
			symmetricAlgorithm.KeySize = 256;
			symmetricAlgorithm.Key = passwordDeriveBytes.GetBytes(32);
			symmetricAlgorithm.Padding = PaddingMode.PKCS7;
			return symmetricAlgorithm;
		}
		private static byte[] GenerateRandomBytes(int count)
		{
			byte[] array = new byte[count];
			clsMe.rand.GetBytes(array);
			return array;
		}
		public static void EncryptFile(string inFile, string outFile, string password)
		{
			using (FileStream fileStream = File.OpenRead(inFile))
			{
				using (FileStream fileStream2 = File.OpenWrite(outFile))
				{
					long length = fileStream.Length;
					int num = (int)length;
					byte[] array = new byte[131072];
					int num2 = 0;
					byte[] array2 = clsMe.GenerateRandomBytes(16);
					byte[] array3 = clsMe.GenerateRandomBytes(16);
					SymmetricAlgorithm symmetricAlgorithm = clsMe.CreateRijndael(password, array3);
					symmetricAlgorithm.IV = array2;
					fileStream2.Write(array2, 0, array2.Length);
					fileStream2.Write(array3, 0, array3.Length);
					HashAlgorithm hashAlgorithm = SHA256.Create();
					using (CryptoStream cryptoStream = new CryptoStream(fileStream2, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
					{
						using (CryptoStream cryptoStream2 = new CryptoStream(Stream.Null, hashAlgorithm, CryptoStreamMode.Write))
						{
							BinaryWriter binaryWriter = new BinaryWriter(cryptoStream);
							binaryWriter.Write(length);
							binaryWriter.Write(18158797384510146255uL);
							int num3;
							while ((num3 = fileStream.Read(array, 0, array.Length)) != 0)
							{
								cryptoStream.Write(array, 0, num3);
								cryptoStream2.Write(array, 0, num3);
								num2 += num3;
							}
							cryptoStream2.Flush();
							cryptoStream2.Close();
							byte[] hash = hashAlgorithm.Hash;
							cryptoStream.Write(hash, 0, hash.Length);
							cryptoStream.Flush();
							cryptoStream.Close();
						}
					}
				}
			}
		}
		public static void DecryptFile(string inFile, string outFile, string password)
		{
			using (FileStream fileStream = File.OpenRead(inFile))
			{
				using (FileStream fileStream2 = File.OpenWrite(outFile))
				{
					int num = (int)fileStream.Length;
					byte[] array = new byte[131072];
					int num2 = 0;
					byte[] array2 = new byte[16];
					fileStream.Read(array2, 0, 16);
					byte[] array3 = new byte[16];
					fileStream.Read(array3, 0, 16);
					SymmetricAlgorithm symmetricAlgorithm = clsMe.CreateRijndael(password, array3);
					symmetricAlgorithm.IV = array2;
					int num3 = 32;
					long num4 = -1L;
					HashAlgorithm hashAlgorithm = SHA256.Create();
					using (CryptoStream cryptoStream = new CryptoStream(fileStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read))
					{
						using (CryptoStream cryptoStream2 = new CryptoStream(Stream.Null, hashAlgorithm, CryptoStreamMode.Write))
						{
							BinaryReader binaryReader = new BinaryReader(cryptoStream);
							num4 = binaryReader.ReadInt64();
							ulong num5 = binaryReader.ReadUInt64();
							if (18158797384510146255uL != num5)
							{
								throw new clsMe.clsMeException("文件被破坏");
							}
							long num6 = num4 / 131072L;
							long num7 = num4 % 131072L;
							int num8 = 0;
							int num9;
							while ((long)num8 < num6)
							{
								num9 = cryptoStream.Read(array, 0, array.Length);
								fileStream2.Write(array, 0, num9);
								cryptoStream2.Write(array, 0, num9);
								num3 += num9;
								num2 += num9;
								num8++;
							}
							if (num7 > 0L)
							{
								num9 = cryptoStream.Read(array, 0, (int)num7);
								fileStream2.Write(array, 0, num9);
								cryptoStream2.Write(array, 0, num9);
								num3 += num9;
								num2 += num9;
							}
							cryptoStream2.Flush();
							cryptoStream2.Close();
							fileStream2.Flush();
							fileStream2.Close();
							byte[] hash = hashAlgorithm.Hash;
							byte[] array4 = new byte[hashAlgorithm.HashSize / 8];
							num9 = cryptoStream.Read(array4, 0, array4.Length);
							if (array4.Length != num9 || !clsMe.CheckByteArrays(array4, hash))
							{
								throw new clsMe.clsMeException("文件被破坏");
							}
						}
					}
					if ((long)num2 != num4)
					{
						throw new clsMe.clsMeException("文件大小不匹配");
					}
				}
			}
		}
		private void btn_MouseEnter(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\mouse_enter.png");
		}
		private void btn_MouseLeave(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (button.Text == "搜索")
			{
				button.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\search_leave.png");
			}
			else
			{
				if (button.Text == "重置")
				{
					button.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\reset_leave.png");
				}
				else
				{
					button.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\search_leave.png");
				}
			}
		}
		private void pic_MouseEnter(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (pictureBox.Name.ToLower() == "picturebox_filter")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\filter_enter.png");
			}
			if (pictureBox.Name.ToLower() == "picturebox_sort")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\sort_enter.png");
			}
			if (pictureBox.Name.ToLower() == "picturebox_view")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\view_enter.png");
			}
			if (pictureBox.Name.ToLower() == "picturebox_sum")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\sum_enter.png");
			}
		}
		private void pic_MouseLeave(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (pictureBox.Name.ToLower() == "picturebox_filter")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\filter_leave.png");
			}
			if (pictureBox.Name.ToLower() == "picturebox_sort")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\sort_leave.png");
			}
			if (pictureBox.Name.ToLower() == "picturebox_view")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\view_leave.png");
			}
			if (pictureBox.Name.ToLower() == "picturebox_sum")
			{
				pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\sum_leave.png");
			}
		}
		private void ptop_DoubleClick(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
			Form form = (Form)panel.Parent;
			if (form.WindowState == FormWindowState.Maximized)
			{
				form.WindowState = FormWindowState.Normal;
			}
			else
			{
				if (form.WindowState == FormWindowState.Normal)
				{
					form.WindowState = FormWindowState.Maximized;
				}
			}
		}
		public void setFormStyl(Form tempForm)
		{
			IEnumerator enumerator;
			if (tempForm.Name.ToLower() == "frmfilter" || tempForm.Name.ToLower() == "frmsort" || tempForm.Name.ToLower() == "frmview" || tempForm.Name.ToLower() == "frmgroup" || tempForm.Name.ToLower() == "frmhao" || tempForm.Name.ToLower() == "frmdx" || tempForm.Name.ToLower() == "frmhj" || tempForm.Name.ToLower() == "frmjxydetail" || tempForm.Name.ToLower() == "frmlhxz" || tempForm.Name.ToLower() == "frmzytd" || tempForm.Name.ToLower() == "frmnydetail" || tempForm.Name.ToLower() == "frmqydetail" || (tempForm.Name.ToLower() == "frmnylist" | tempForm.Name.ToLower() == "frmjgs") || tempForm.Name.ToLower() == "frmyxcfdetail" || tempForm.Name.ToLower() == "frmtjsyspxx")
			{
				tempForm.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\images\\icon.ico");
				tempForm.BackColor = Color.FromArgb(225, 231, 234);
				enumerator = tempForm.Controls.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						if (control is Button)
						{
							control.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\search_leave.png");
							Button button = (Button)control;
							button.MouseEnter += new EventHandler(this.btn_MouseEnter);
							button.MouseLeave += new EventHandler(this.btn_MouseLeave);
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			else
			{
				tempForm.BackColor = Color.FromArgb(225, 230, 229);
				tempForm.Width = 850;
				tempForm.Height = 589;
				tempForm.MaximumSize = new Size(MDIParent.screen_width, MDIParent.screen_height);
				tempForm.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\images\\icon.ico");
				tempForm.ShowInTaskbar = true;
			}
			enumerator = tempForm.Controls.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					if (control is DataGridView)
					{
						DataGridView dataGridView = (DataGridView)control;
						dataGridView.BackgroundColor = tempForm.BackColor;
						dataGridView.EnableHeadersVisualStyles = false;
						dataGridView.RowHeadersDefaultCellStyle.BackColor = tempForm.BackColor;
						dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
					}
					if (control is Panel)
					{
						Panel panel = (Panel)control;
						if (panel.Name.ToLower() == "paneltitle_left")
						{
							panel.Location = new Point(0, 0);
							panel.Width = 235;
							panel.Height = 25;
							panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\title_left.png");
							PictureBox pictureBox = new PictureBox();
							pictureBox.Name = "pic_log";
							pictureBox.Location = new Point(5, 5);
							pictureBox.Image = Image.FromFile(Application.StartupPath + "\\images\\minlogo.png");
							pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
							pictureBox.BackColor = Color.Transparent;
							panel.Controls.Add(pictureBox);
							Panel panel2 = panel;
							panel2.DoubleClick += new EventHandler(this.ptop_DoubleClick);
						}
						if (panel.Name.ToLower() == "paneltitle_middle")
						{
							panel.Location = new Point(235, 0);
							panel.Width = 335;
							panel.Height = 25;
							panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\title_middle.png");
							Panel panel2 = panel;
							panel2.DoubleClick += new EventHandler(this.ptop_DoubleClick);
						}
						if (panel.Name.ToLower() == "paneltitle_right")
						{
							panel.Location = new Point(569, 0);
							panel.Width = 279;
							panel.Height = 25;
							panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\title_right.png");
							Panel panel2 = panel;
							panel2.DoubleClick += new EventHandler(this.ptop_DoubleClick);
						}
						if (panel.Name.ToLower() == "paneltop_left")
						{
							panel.Location = new Point(0, 25);
							panel.Width = 305;
							panel.Height = 50;
							panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\top_left.png");
							Panel panel2 = panel;
							panel2.DoubleClick += new EventHandler(this.ptop_DoubleClick);
						}
						if (panel.Name.ToLower() == "paneltop_middle")
						{
							panel.Location = new Point(305, 25);
							panel.Width = 125;
							panel.Height = 50;
							panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\top_middle.png");
							Panel panel2 = panel;
							panel2.DoubleClick += new EventHandler(this.ptop_DoubleClick);
						}
						if (panel.Name.ToLower() == "paneltop_right")
						{
							panel.Location = new Point(430, 25);
							panel.Width = 418;
							panel.Height = 50;
							panel.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\top_right.png");
							Panel panel2 = panel;
							panel2.DoubleClick += new EventHandler(this.ptop_DoubleClick);
						}
						if (panel.Name.ToLower() == "panelmenu")
						{
							panel.Location = new Point(6, 86);
							panel.Width = 185;
							panel.Height = 491;
							panel.BackColor = Color.FromArgb(107, 161, 179);
						}
						if (panel.Name.ToLower() == "panelright")
						{
							panel.Location = new Point(195, 86);
							panel.Width = 652;
							panel.Height = 490;
							panel.BackColor = Color.FromArgb(107, 161, 179);
							foreach (Control control2 in panel.Controls)
							{
								if (control2.Name.ToLower() == "picturebox_left")
								{
									PictureBox pictureBox2 = (PictureBox)control2;
									pictureBox2.Location = new Point(1, 1);
									pictureBox2.Height = 28;
									pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\zuo.png");
								}
								if (control2.Name.ToLower() == "panel_middle")
								{
									Panel panel3 = (Panel)control2;
									panel3.Location = new Point(18, 1);
									panel3.Height = 28;
									panel3.Width = 595;
									panel3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\zhong.png");
								}
								if (control2.Name.ToLower() == "picturebox_right")
								{
									PictureBox pictureBox2 = (PictureBox)control2;
									pictureBox2.Location = new Point(613, 1);
									pictureBox2.Height = 28;
									pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\you.png");
								}
								if (control2 is Panel)
								{
									if (control2.Name.ToLower() == "panelcondition")
									{
										control2.Location = new Point(1, 29);
										control2.Width = 650;
										control2.Height = 120;
										control2.BackColor = Color.FromArgb(255, 255, 255);
										foreach (Control control3 in control2.Controls)
										{
											if (control3.Name.ToLower() == "btnsearch")
											{
												control3.Text = "搜索";
												control3.Location = new Point(69, 79);
												control3.Font = new Font("宋体", 10.5f);
												control3.Width = 113;
												control3.Height = 29;
												control3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\search_leave.png");
												Button button = (Button)control3;
												button.MouseEnter += new EventHandler(this.btn_MouseEnter);
												button.MouseLeave += new EventHandler(this.btn_MouseLeave);
											}
											if (control3.Name.ToLower() == "btnreset")
											{
												control3.Text = "重置";
												control3.Location = new Point(315, 79);
												control3.Font = new Font("宋体", 10.5f);
												control3.Width = 113;
												control3.Height = 29;
												control3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\reset_leave.png");
												Button button = (Button)control3;
												button.MouseEnter += new EventHandler(this.btn_MouseEnter);
												button.MouseLeave += new EventHandler(this.btn_MouseLeave);
											}
										}
									}
									if (control2.Name.ToLower() == "panelwhite")
									{
										control2.Location = new Point(1, 149);
										control2.Width = 650;
										control2.Height = 340;
										control2.BackColor = Color.FromArgb(255, 255, 255);
										foreach (Control control4 in control2.Controls)
										{
											if (control4.Name.ToLower() == "paneldatasum")
											{
												control4.Location = new Point(10, 1);
												control4.Width = 630;
												control4.Height = 30;
												control4.BackColor = Color.FromArgb(231, 237, 239);
											}
											if (control4.Name.ToLower() == "panelbutton")
											{
												control4.Location = new Point(10, 31);
												control4.Width = 630;
												control4.Height = 44;
												control4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\11.png");
												foreach (Control control5 in control4.Controls)
												{
													if (control5.Name.ToLower() == "picturebox_filter")
													{
														control5.Location = new Point(55, 9);
														PictureBox pictureBox2 = (PictureBox)control5;
														pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\filter_leave.png");
														pictureBox2.MouseEnter += new EventHandler(this.pic_MouseEnter);
														pictureBox2.MouseLeave += new EventHandler(this.pic_MouseLeave);
													}
													if (control5.Name.ToLower() == "picturebox_sort")
													{
														control5.Location = new Point(155, 9);
														PictureBox pictureBox2 = (PictureBox)control5;
														pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\sort_leave.png");
														pictureBox2.MouseEnter += new EventHandler(this.pic_MouseEnter);
														pictureBox2.MouseLeave += new EventHandler(this.pic_MouseLeave);
													}
													if (control5.Name.ToLower() == "picturebox_view")
													{
														control5.Location = new Point(255, 9);
														PictureBox pictureBox2 = (PictureBox)control5;
														pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\view_leave.png");
														pictureBox2.MouseEnter += new EventHandler(this.pic_MouseEnter);
														pictureBox2.MouseLeave += new EventHandler(this.pic_MouseLeave);
													}
													if (control5.Name.ToLower() == "picturebox_sum")
													{
														control5.Location = new Point(355, 9);
														PictureBox pictureBox2 = (PictureBox)control5;
														pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\images\\sum_leave.png");
														pictureBox2.MouseEnter += new EventHandler(this.pic_MouseEnter);
														pictureBox2.MouseLeave += new EventHandler(this.pic_MouseLeave);
													}
												}
											}
											if (control4.Name.ToLower() == "paneldata")
											{
												control4.Location = new Point(10, 81);
												control4.Width = 630;
												control4.Height = 250;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
		public static byte[] Encrypt(byte[] original, byte[] key)
		{
			return new TripleDESCryptoServiceProvider
			{
				Key = clsMe.MakeMD5(key),
				Mode = CipherMode.ECB
			}.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
		}
		public static byte[] Decrypt(byte[] encrypted, byte[] key)
		{
			return new TripleDESCryptoServiceProvider
			{
				Key = clsMe.MakeMD5(key),
				Mode = CipherMode.ECB
			}.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
		}
		public static byte[] MakeMD5(byte[] key)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			return mD5CryptoServiceProvider.ComputeHash(key);
		}
		public string Encrypt(string original, string key)
		{
			byte[] bytes = Encoding.Default.GetBytes(original);
			byte[] bytes2 = Encoding.Default.GetBytes(key);
			return Convert.ToBase64String(clsMe.Encrypt(bytes, bytes2));
		}
		public string Decrypt(string encrypted, string key, Encoding encoding)
		{
			byte[] encrypted2 = Convert.FromBase64String(encrypted);
			byte[] bytes = Encoding.Default.GetBytes(key);
			return encoding.GetString(clsMe.Decrypt(encrypted2, bytes));
		}
		private string Reverse(string strReverse)
		{
			char[] array = strReverse.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}
		private string Decode(string strDecode)
		{
			string text = "";
			for (int i = 0; i < strDecode.Length / 4; i++)
			{
				text += (char)short.Parse(strDecode.Substring(i * 4, 4), NumberStyles.HexNumber);
			}
			return text;
		}
		public DataSet PlanData(DataSet dsSource, string strTableName, string strFields)
		{
			for (int i = 0; i < dsSource.Tables[strTableName].Rows.Count; i++)
			{
				for (int j = 0; j < dsSource.Tables[strTableName].Columns.Count; j++)
				{
					if (dsSource.Tables[strTableName].Rows[i][j].ToString().Trim() != "")
					{
						if (strFields.IndexOf(dsSource.Tables[strTableName].Columns[j].ColumnName + "|") >= 0)
						{
							dsSource.Tables[strTableName].Rows[i][j] = this.Decode(this.Reverse(dsSource.Tables[strTableName].Rows[i][j].ToString().Trim().Substring(5)));
						}
					}
				}
			}
			return dsSource;
		}
		public void SortView(DataGridView datagridview, string sortcolumn)
		{
			DataView dataView = (DataView)datagridview.DataSource;
			dataView.Sort = sortcolumn;
			datagridview.DataSource = dataView;
		}
		public void SortView(GridControl datagridview, string sortcolumn)
		{
			DataView dataView = (DataView)datagridview.DataSource;
			dataView.Sort = sortcolumn;
			datagridview.DataSource = dataView;
		}
		public void ViewGrid(DataGridView datagridview, ListBox listbox)
		{
			if (listbox != null)
			{
				if (listbox.Items.Count > 0)
				{
					for (int i = 0; i < datagridview.Columns.Count; i++)
					{
						datagridview.Columns[i].Visible = false;
					}
					for (int i = 0; i < listbox.Items.Count; i++)
					{
						string colheadertext = listbox.Items[i].ToString();
						datagridview.Columns[this.getColIndex(datagridview, colheadertext)].Visible = true;
						datagridview.Columns[this.getColIndex(datagridview, colheadertext)].DisplayIndex = i;
					}
				}
			}
		}
		public void ViewGrid(GridView datagridview, ListBox listbox)
		{
			if (listbox != null)
			{
				if (listbox.Items.Count > 0)
				{
					for (int i = 0; i < datagridview.Columns.Count; i++)
					{
						datagridview.Columns[i].Visible = false;
					}
					for (int i = 0; i < listbox.Items.Count; i++)
					{
						string colheadertext = listbox.Items[i].ToString();
						int colIndex = this.getColIndex(datagridview, colheadertext);
						int visibleIndex = datagridview.Columns.Count + 5 + i;
						datagridview.Columns[colIndex].Visible = true;
						datagridview.Columns[colIndex].VisibleIndex = visibleIndex;
					}
				}
			}
		}
		private int getColIndex(DataGridView datagridview, string colheadertext)
		{
			int result = -1;
			for (int i = 0; i < datagridview.Columns.Count; i++)
			{
				if (colheadertext == datagridview.Columns[i].HeaderText)
				{
					result = i;
					break;
				}
			}
			return result;
		}
		private int getColIndex(GridView datagridview, string colheadertext)
		{
			int result = -1;
			for (int i = 0; i < datagridview.Columns.Count; i++)
			{
				if (colheadertext == datagridview.Columns[i].Caption)
				{
					result = i;
					break;
				}
			}
			return result;
		}
		public void FilterView(DataGridView datagridview, string filtercolumn)
		{
			DataView dataView = (DataView)datagridview.DataSource;
			dataView.RowFilter = filtercolumn;
			datagridview.DataSource = dataView;
		}
		public void FilterView(GridControl datagridview, string filtercolumn)
		{
			DataView dataView = (DataView)datagridview.DataSource;
			dataView.RowFilter = filtercolumn;
			datagridview.DataSource = dataView;
		}
	}
}
