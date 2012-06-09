using System;
namespace NYSCQY
{
	internal class clsStr
	{
		public string[] Seperate(string str, char c)
		{
			str = str.Replace("\u3000", " ");
			str = str.Trim();
			return str.Split(new char[]
			{
				c
			});
		}
		public string Format(string str, char c)
		{
			if (str.IndexOf(' ') > 0)
			{
				str = str.Substring(0, str.IndexOf(' '));
			}
			else
			{
				str = str.Substring(0, 10);
			}
			string text = Convert.ToDateTime(str).ToString("yyyy.MM.dd");
			string result;
			if (str != "")
			{
				result = text;
			}
			else
			{
				result = "";
			}
			return result;
		}
	}
}
