using DevExpress.XtraPrinting.Localization;
using System;
namespace NYSCQY
{
	public class DxperienceXtraPrintingLocalizationCHS : PreviewLocalizer
	{
		public override string Language
		{
			get
			{
				return "简体中文";
			}
		}
		public override string GetLocalizedString(PreviewStringId id)
		{
			string result;
			switch (id)
			{
			case PreviewStringId.Button_Cancel:
				result = "取消";
				return result;
			case PreviewStringId.Button_Ok:
				result = "确定";
				return result;
			case PreviewStringId.Button_Help:
				result = "帮助";
				return result;
			case PreviewStringId.Button_Apply:
				result = "应用";
				return result;
			case PreviewStringId.PreviewForm_Caption:
				result = "预览";
				return result;
			case PreviewStringId.TB_TTip_Customize:
				result = "自定义";
				return result;
			case PreviewStringId.TB_TTip_Print:
				result = "打印";
				return result;
			case PreviewStringId.TB_TTip_PrintDirect:
				result = "直接打印";
				return result;
			case PreviewStringId.TB_TTip_PageSetup:
				result = "页面设置";
				return result;
			case PreviewStringId.TB_TTip_Magnifier:
				result = "放大/缩小";
				return result;
			case PreviewStringId.TB_TTip_ZoomIn:
				result = "放大";
				return result;
			case PreviewStringId.TB_TTip_ZoomOut:
				result = "缩小";
				return result;
			case PreviewStringId.TB_TTip_Zoom:
				result = "缩放";
				return result;
			case PreviewStringId.TB_TTip_Search:
				result = "搜索";
				return result;
			case PreviewStringId.TB_TTip_FirstPage:
				result = "首页";
				return result;
			case PreviewStringId.TB_TTip_PreviousPage:
				result = "上一页";
				return result;
			case PreviewStringId.TB_TTip_NextPage:
				result = "下一页";
				return result;
			case PreviewStringId.TB_TTip_LastPage:
				result = "尾页";
				return result;
			case PreviewStringId.TB_TTip_MultiplePages:
				result = "多页";
				return result;
			case PreviewStringId.TB_TTip_Backgr:
				result = "背景色";
				return result;
			case PreviewStringId.TB_TTip_Close:
				result = "退出";
				return result;
			case PreviewStringId.TB_TTip_EditPageHF:
				result = "页眉页脚";
				return result;
			case PreviewStringId.TB_TTip_HandTool:
				result = "手掌工具";
				return result;
			case PreviewStringId.TB_TTip_Export:
				result = "导出文件...";
				return result;
			case PreviewStringId.TB_TTip_Send:
				result = "发送e-mail...";
				return result;
			case PreviewStringId.TB_TTip_Map:
				result = "文档视图";
				return result;
			case PreviewStringId.TB_TTip_Watermark:
				result = "水印";
				return result;
			case PreviewStringId.MenuItem_PdfDocument:
				result = "PDF文件";
				return result;
			case PreviewStringId.MenuItem_PageLayout:
				result = "页面布置(&P)";
				return result;
			case PreviewStringId.MenuItem_TxtDocument:
				result = "Text文件";
				return result;
			case PreviewStringId.MenuItem_GraphicDocument:
				result = "图片文件";
				return result;
			case PreviewStringId.MenuItem_CsvDocument:
				result = "CSV文件";
				return result;
			case PreviewStringId.MenuItem_MhtDocument:
				result = "MHT文件";
				return result;
			case PreviewStringId.MenuItem_XlsDocument:
				result = "Excel文件";
				return result;
			case PreviewStringId.MenuItem_RtfDocument:
				result = "RichText文件";
				return result;
			case PreviewStringId.MenuItem_HtmDocument:
				result = "HTML文件";
				return result;
			case PreviewStringId.SaveDlg_FilterBmp:
				result = "BMPBitmapFormat";
				return result;
			case PreviewStringId.SaveDlg_FilterGif:
				result = "GIFGraphicsInterchangeFormat";
				return result;
			case PreviewStringId.SaveDlg_FilterJpeg:
				result = "JPEGFileInterchangeFormat";
				return result;
			case PreviewStringId.SaveDlg_FilterPng:
				result = "PNGPortableNetworkGraphicsFormat";
				return result;
			case PreviewStringId.SaveDlg_FilterTiff:
				result = "TIFFTagImageFileFormat";
				return result;
			case PreviewStringId.SaveDlg_FilterEmf:
				result = "EMFEnhancedWindowsMetafile";
				return result;
			case PreviewStringId.SaveDlg_FilterWmf:
				result = "WMFWindowsMetafile";
				return result;
			case PreviewStringId.SB_TotalPageNo:
				result = "总页码:";
				return result;
			case PreviewStringId.SB_CurrentPageNo:
				result = "目前页码:";
				return result;
			case PreviewStringId.SB_ZoomFactor:
				result = "缩放系数:";
				return result;
			case PreviewStringId.SB_PageNone:
				result = "无";
				return result;
			case PreviewStringId.SB_PageInfo:
				result = "{0}/{1}";
				return result;
			case PreviewStringId.MPForm_Lbl_Pages:
				result = "页";
				return result;
			case PreviewStringId.Msg_EmptyDocument:
				result = "此文件没有页面.";
				return result;
			case PreviewStringId.Msg_CreatingDocument:
				result = "正在生成文件...";
				return result;
			case PreviewStringId.Msg_UnavailableNetPrinter:
				result = "网络打印机无法使用.";
				return result;
			case PreviewStringId.Msg_NeedPrinter:
				result = "没有安装打印机.";
				return result;
			case PreviewStringId.Msg_WrongPrinter:
				result = "无效的打印机名称.请检查打印机的设置是否正确.";
				return result;
			case PreviewStringId.Msg_WrongPageSettings:
				result = "打印机不支持所选的纸张大小.\n是否继续打印？";
				return result;
			case PreviewStringId.Msg_CustomDrawWarning:
				result = "警告！";
				return result;
			case PreviewStringId.Msg_PageMarginsWarning:
				result = "一个或以上的边界超出了打印范围.是否继续？";
				return result;
			case PreviewStringId.Msg_IncorrectPageRange:
				result = "设置的页边界不正确";
				return result;
			case PreviewStringId.Msg_FontInvalidNumber:
				result = "字体大小不能为0或负数";
				return result;
			case PreviewStringId.Msg_NotSupportedFont:
				result = "这种字体不被支持";
				return result;
			case PreviewStringId.Msg_IncorrectZoomFactor:
				result = "数字必须在{0}与{1}之间。";
				return result;
			case PreviewStringId.Msg_InvalidMeasurement:
				result = "不规范";
				return result;
			case PreviewStringId.Margin_Inch:
				result = "英寸";
				return result;
			case PreviewStringId.Margin_Millimeter:
				result = "毫米";
				return result;
			case PreviewStringId.Margin_TopMargin:
				result = "上边界";
				return result;
			case PreviewStringId.Margin_BottomMargin:
				result = "下边界";
				return result;
			case PreviewStringId.Margin_LeftMargin:
				result = "左边界";
				return result;
			case PreviewStringId.Margin_RightMargin:
				result = "右边界";
				return result;
			case PreviewStringId.ScrollingInfo_Page:
				result = "页";
				return result;
			case PreviewStringId.WMForm_PictureDlg_Title:
				result = "选择图片";
				return result;
			case PreviewStringId.WMForm_ImageStretch:
				result = "伸展";
				return result;
			case PreviewStringId.WMForm_ImageClip:
				result = "剪辑";
				return result;
			case PreviewStringId.WMForm_ImageZoom:
				result = "缩放";
				return result;
			case PreviewStringId.WMForm_Watermark_Asap:
				result = "ASAP";
				return result;
			case PreviewStringId.WMForm_Watermark_Confidential:
				result = "CONFIDENTIAL";
				return result;
			case PreviewStringId.WMForm_Watermark_Copy:
				result = "COPY";
				return result;
			case PreviewStringId.WMForm_Watermark_DoNotCopy:
				result = "DONOTCOPY";
				return result;
			case PreviewStringId.WMForm_Watermark_Draft:
				result = "DRAFT";
				return result;
			case PreviewStringId.WMForm_Watermark_Evaluation:
				result = "EVALUATION";
				return result;
			case PreviewStringId.WMForm_Watermark_Original:
				result = "ORIGINAL";
				return result;
			case PreviewStringId.WMForm_Watermark_Personal:
				result = "PERSONAL";
				return result;
			case PreviewStringId.WMForm_Watermark_Sample:
				result = "SAMPLE";
				return result;
			case PreviewStringId.WMForm_Watermark_TopSecret:
				result = "TOPSECRET";
				return result;
			case PreviewStringId.WMForm_Watermark_Urgent:
				result = "URGENT";
				return result;
			case PreviewStringId.WMForm_Direction_Horizontal:
				result = "横向";
				return result;
			case PreviewStringId.WMForm_Direction_Vertical:
				result = "纵向";
				return result;
			case PreviewStringId.WMForm_Direction_BackwardDiagonal:
				result = "反向倾斜";
				return result;
			case PreviewStringId.WMForm_Direction_ForwardDiagonal:
				result = "正向倾斜";
				return result;
			case PreviewStringId.WMForm_VertAlign_Bottom:
				result = "底端";
				return result;
			case PreviewStringId.WMForm_VertAlign_Middle:
				result = "中间";
				return result;
			case PreviewStringId.WMForm_VertAlign_Top:
				result = "顶端";
				return result;
			case PreviewStringId.WMForm_HorzAlign_Left:
				result = "靠左";
				return result;
			case PreviewStringId.WMForm_HorzAlign_Center:
				result = "置中";
				return result;
			case PreviewStringId.WMForm_HorzAlign_Right:
				result = "靠右";
				return result;
			case PreviewStringId.WMForm_ZOrderRgrItem_InFront:
				result = "在前面";
				return result;
			case PreviewStringId.WMForm_ZOrderRgrItem_Behind:
				result = "在后面";
				return result;
			case PreviewStringId.WMForm_PageRangeRgrItem_All:
				result = "全部";
				return result;
			case PreviewStringId.WMForm_PageRangeRgrItem_Pages:
				result = "页码";
				return result;
			case PreviewStringId.SaveDlg_Title:
				result = "另存为";
				return result;
			case PreviewStringId.SaveDlg_FilterPdf:
				result = "PDF文件";
				return result;
			case PreviewStringId.SaveDlg_FilterHtm:
				result = "HTML文件";
				return result;
			case PreviewStringId.SaveDlg_FilterMht:
				result = "MHT文件";
				return result;
			case PreviewStringId.SaveDlg_FilterRtf:
				result = "Rtf文件";
				return result;
			case PreviewStringId.SaveDlg_FilterXls:
				result = "Excel文件";
				return result;
			case PreviewStringId.SaveDlg_FilterCsv:
				result = "CSV文件";
				return result;
			case PreviewStringId.SaveDlg_FilterTxt:
				result = "Txt文件";
				return result;
			case PreviewStringId.MenuItem_File:
				result = "文件(&F)";
				return result;
			case PreviewStringId.MenuItem_View:
				result = "视图(&V)";
				return result;
			case PreviewStringId.MenuItem_Background:
				result = "背景(&B)";
				return result;
			case PreviewStringId.MenuItem_PageSetup:
				result = "页面设置(&U)";
				return result;
			case PreviewStringId.MenuItem_Print:
				result = "打印(&P)...";
				return result;
			case PreviewStringId.MenuItem_PrintDirect:
				result = "直接打印(&R)";
				return result;
			case PreviewStringId.MenuItem_Export:
				result = "导出(&E)";
				return result;
			case PreviewStringId.MenuItem_Send:
				result = "发送(&D)";
				return result;
			case PreviewStringId.MenuItem_Exit:
				result = "退出(&X)";
				return result;
			case PreviewStringId.MenuItem_ViewToolbar:
				result = "工具栏(&T)";
				return result;
			case PreviewStringId.MenuItem_ViewStatusbar:
				result = "状态栏(&S)";
				return result;
			case PreviewStringId.MenuItem_ViewContinuous:
				result = "连续";
				return result;
			case PreviewStringId.MenuItem_ViewFacing:
				result = "对页";
				return result;
			case PreviewStringId.MenuItem_BackgrColor:
				result = "颜色(&C)...";
				return result;
			case PreviewStringId.MenuItem_Watermark:
				result = "水印(&W)...";
				return result;
			case PreviewStringId.MenuItem_ZoomPageWidth:
				result = "页宽";
				return result;
			case PreviewStringId.MenuItem_ZoomTextWidth:
				result = "整页";
				return result;
			case PreviewStringId.PageInfo_PageNumber:
				result = "[Page#]";
				return result;
			case PreviewStringId.PageInfo_PageNumberOfTotal:
				result = "[Page#ofPages#]";
				return result;
			case PreviewStringId.PageInfo_PageDate:
				result = "[DatePrinted]";
				return result;
			case PreviewStringId.PageInfo_PageTime:
				result = "[TimePrinted]";
				return result;
			case PreviewStringId.PageInfo_PageUserName:
				result = "[UserName]";
				return result;
			case PreviewStringId.EMail_From:
				result = "From";
				return result;
			case PreviewStringId.BarText_Toolbar:
				result = "工具栏";
				return result;
			case PreviewStringId.BarText_MainMenu:
				result = "主菜单";
				return result;
			case PreviewStringId.BarText_StatusBar:
				result = "状态栏";
				return result;
			}
			result = base.GetLocalizedString(id);
			return result;
		}
	}
}
