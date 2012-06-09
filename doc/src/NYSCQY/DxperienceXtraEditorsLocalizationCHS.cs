using DevExpress.XtraEditors.Controls;
using System;
namespace NYSCQY
{
	public class DxperienceXtraEditorsLocalizationCHS : Localizer
	{
		public override string Language
		{
			get
			{
				return "简体中文";
			}
		}
		public override string GetLocalizedString(StringId id)
		{
			string result;
			switch (id)
			{
			case StringId.None:
				result = "";
				return result;
			case StringId.CaptionError:
				result = "错误";
				return result;
			case StringId.InvalidValueText:
				result = "无效的值";
				return result;
			case StringId.CheckChecked:
				result = "选中";
				return result;
			case StringId.CheckUnchecked:
				result = "未选中";
				return result;
			case StringId.CheckIndeterminate:
				result = "未选择";
				return result;
			case StringId.DateEditToday:
				result = "今天";
				return result;
			case StringId.DateEditClear:
				result = "清除";
				return result;
			case StringId.OK:
				result = "确定(&O)";
				return result;
			case StringId.Cancel:
				result = "取消(&C)";
				return result;
			case StringId.NavigatorFirstButtonHint:
				result = "第一条";
				return result;
			case StringId.NavigatorPreviousButtonHint:
				result = "上一条";
				return result;
			case StringId.NavigatorPreviousPageButtonHint:
				result = "上一页";
				return result;
			case StringId.NavigatorNextButtonHint:
				result = "下一条";
				return result;
			case StringId.NavigatorNextPageButtonHint:
				result = "下一页";
				return result;
			case StringId.NavigatorLastButtonHint:
				result = "最后一条";
				return result;
			case StringId.NavigatorAppendButtonHint:
				result = "添加";
				return result;
			case StringId.NavigatorRemoveButtonHint:
				result = "删除";
				return result;
			case StringId.NavigatorEditButtonHint:
				result = "编辑";
				return result;
			case StringId.NavigatorEndEditButtonHint:
				result = "结束编辑";
				return result;
			case StringId.NavigatorCancelEditButtonHint:
				result = "取消编辑";
				return result;
			case StringId.NavigatorTextStringFormat:
				result = "记录{0}/{1}";
				return result;
			case StringId.PictureEditMenuCut:
				result = "剪贴";
				return result;
			case StringId.PictureEditMenuCopy:
				result = "复制";
				return result;
			case StringId.PictureEditMenuPaste:
				result = "粘贴";
				return result;
			case StringId.PictureEditMenuDelete:
				result = "删除";
				return result;
			case StringId.PictureEditMenuLoad:
				result = "读取";
				return result;
			case StringId.PictureEditMenuSave:
				result = "保存";
				return result;
			case StringId.PictureEditOpenFileFilter:
				result = "BitmapFiles(*.bmp)|*.bmp|GraphicsInterchangeFormat(*.gif)|*.gif|JPEGFileInterchangeFormat(*.jpg;*.jpeg)|*.jpg;*.jpeg|IconFiles(*.ico)|*.ico|AllPictureFiles|*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|AllFiles|*.*";
				return result;
			case StringId.PictureEditSaveFileFilter:
				result = "BitmapFiles(*.bmp)|*.bmp|GraphicsInterchangeFormat(*.gif)|*.gif|JPEGFileInterchangeFormat(*.jpg)|*.jpg";
				return result;
			case StringId.PictureEditOpenFileTitle:
				result = "打开";
				return result;
			case StringId.PictureEditSaveFileTitle:
				result = "另存为";
				return result;
			case StringId.PictureEditOpenFileError:
				result = "错误的图片格式";
				return result;
			case StringId.PictureEditOpenFileErrorCaption:
				result = "打开错误";
				return result;
			case StringId.LookUpEditValueIsNull:
				result = "[无数据]";
				return result;
			case StringId.LookUpInvalidEditValueType:
				result = "无效的数据类型";
				return result;
			case StringId.LookUpColumnDefaultName:
				result = "名称";
				return result;
			case StringId.MaskBoxValidateError:
				result = "输入数值不完整.是否须要修改?\r\n\r\n是-回到编辑模式以修改数值.\r\n否-保持原来数值.\r\n取消-回复原来数值.\r\n";
				return result;
			case StringId.UnknownPictureFormat:
				result = "不明图片格式";
				return result;
			case StringId.DataEmpty:
				result = "无图像";
				return result;
			case StringId.NotValidArrayLength:
				result = "无效的数组长度.";
				return result;
			case StringId.ImagePopupEmpty:
				result = "(空)";
				return result;
			case StringId.ImagePopupPicture:
				result = "(图片)";
				return result;
			case StringId.ColorTabCustom:
				result = "自定";
				return result;
			case StringId.ColorTabWeb:
				result = "网络";
				return result;
			case StringId.ColorTabSystem:
				result = "系统";
				return result;
			case StringId.CalcButtonMC:
				result = "MC";
				return result;
			case StringId.CalcButtonMR:
				result = "MR";
				return result;
			case StringId.CalcButtonMS:
				result = "MS";
				return result;
			case StringId.CalcButtonMx:
				result = "M ";
				return result;
			case StringId.CalcButtonSqrt:
				result = "sqrt";
				return result;
			case StringId.CalcButtonBack:
				result = "Back";
				return result;
			case StringId.CalcButtonCE:
				result = "CE";
				return result;
			case StringId.CalcButtonC:
				result = "C";
				return result;
			case StringId.CalcError:
				result = "计算错误";
				return result;
			case StringId.TabHeaderButtonPrev:
				result = "向左滚动";
				return result;
			case StringId.TabHeaderButtonNext:
				result = "向右滚动";
				return result;
			case StringId.TabHeaderButtonClose:
				result = "关闭";
				return result;
			case StringId.XtraMessageBoxOkButtonText:
				result = "确定(&O)";
				return result;
			case StringId.XtraMessageBoxCancelButtonText:
				result = "取消(&C)";
				return result;
			case StringId.XtraMessageBoxYesButtonText:
				result = "是(&Y)";
				return result;
			case StringId.XtraMessageBoxNoButtonText:
				result = "否(&N)";
				return result;
			case StringId.XtraMessageBoxAbortButtonText:
				result = "中断(&A)";
				return result;
			case StringId.XtraMessageBoxRetryButtonText:
				result = "重试(&R)";
				return result;
			case StringId.XtraMessageBoxIgnoreButtonText:
				result = "忽略(&I)";
				return result;
			case StringId.TextEditMenuUndo:
				result = "撤消(&U)";
				return result;
			case StringId.TextEditMenuCut:
				result = "剪贴(&T)";
				return result;
			case StringId.TextEditMenuCopy:
				result = "复制(&C)";
				return result;
			case StringId.TextEditMenuPaste:
				result = "粘贴(&P)";
				return result;
			case StringId.TextEditMenuDelete:
				result = "删除(&D)";
				return result;
			case StringId.TextEditMenuSelectAll:
				result = "全选(&A)";
				return result;
			}
			result = base.GetLocalizedString(id);
			return result;
		}
	}
}
