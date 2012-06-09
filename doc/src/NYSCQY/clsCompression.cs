using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
namespace NYSCQY
{
	internal class clsCompression
	{
		public void ZipFile(string FileToZip, string ZipedFile, int CompressionLevel, int BlockSize)
		{
			if (!File.Exists(FileToZip))
			{
				throw new FileNotFoundException("The specified file " + FileToZip + " could not be found. Zipping aborderd");
			}
			FileStream fileStream = new FileStream(FileToZip, FileMode.Open, FileAccess.Read);
			FileStream baseOutputStream = File.Create(ZipedFile);
			ZipOutputStream zipOutputStream = new ZipOutputStream(baseOutputStream);
			ZipEntry entry = new ZipEntry("ZippedFile");
			zipOutputStream.PutNextEntry(entry);
			zipOutputStream.SetLevel(CompressionLevel);
			byte[] array = new byte[BlockSize];
			int num = fileStream.Read(array, 0, array.Length);
			zipOutputStream.Write(array, 0, num);
			try
			{
				while ((long)num < fileStream.Length)
				{
					int num2 = fileStream.Read(array, 0, array.Length);
					zipOutputStream.Write(array, 0, num2);
					num += num2;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			zipOutputStream.Finish();
			zipOutputStream.Close();
			fileStream.Close();
		}
		public void UnZipFile(string ZipedFile, string UnZipFile)
		{
			ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead(ZipedFile));
			ZipEntry nextEntry;
			while ((nextEntry = zipInputStream.GetNextEntry()) != null)
			{
				string directoryName = Path.GetDirectoryName(UnZipFile);
				string fileName = Path.GetFileName(nextEntry.Name);
				Directory.CreateDirectory(directoryName);
				if (fileName != string.Empty)
				{
					FileStream fileStream = File.OpenWrite(UnZipFile);
					byte[] array = new byte[2048];
					while (true)
					{
						int num = zipInputStream.Read(array, 0, array.Length);
						if (num <= 0)
						{
							break;
						}
						fileStream.Write(array, 0, num);
					}
					fileStream.Close();
				}
			}
			zipInputStream.Close();
		}
	}
}
