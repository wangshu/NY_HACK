using DevExpress.XtraGrid.Localization;
using System;
namespace NYSCQY
{
	public class DxperienceXtraGridLocalizationCHS : GridLocalizer
	{
		public override string Language
		{
			get
			{
				return "简体中文";
			}
		}
		public override string GetLocalizedString(GridStringId id)
		{
			string result;
			switch (id)
			{
			case GridStringId.FileIsNotFoundError:
				result = "文件{0}没有找到";
				return result;
			case GridStringId.ColumnViewExceptionMessage:
				result = "是否确定修改？";
				return result;
			case GridStringId.CustomizationCaption:
				result = "自定义显示字段";
				return result;
			case GridStringId.CustomizationColumns:
				result = "列";
				return result;
			case GridStringId.CustomizationBands:
				result = "分区";
				return result;
			case GridStringId.PopupFilterAll:
				result = "(所有)";
				return result;
			case GridStringId.PopupFilterCustom:
				result = "(自定义)";
				return result;
			case GridStringId.PopupFilterBlanks:
				result = "(空值)";
				return result;
			case GridStringId.PopupFilterNonBlanks:
				result = "(非空值)";
				return result;
			case GridStringId.CustomFilterDialogFormCaption:
				result = "自定义筛选条件";
				return result;
			case GridStringId.CustomFilterDialogCaption:
				result = "条件为:";
				return result;
			case GridStringId.CustomFilterDialogRadioAnd:
				result = "并且";
				return result;
			case GridStringId.CustomFilterDialogRadioOr:
				result = "或者";
				return result;
			case GridStringId.CustomFilterDialogOkButton:
				result = "确定(&O)";
				return result;
			case GridStringId.CustomFilterDialogClearFilter:
				result = "清除筛选条件(&L)";
				return result;
			case GridStringId.CustomFilterDialog2FieldCheck:
				result = "字段";
				return result;
			case GridStringId.CustomFilterDialogCancelButton:
				result = "取消(&C)";
				return result;
			case GridStringId.CustomFilterDialogConditionEQU:
				result = "等于=";
				return result;
			case GridStringId.CustomFilterDialogConditionNEQ:
				result = "不等于<>";
				return result;
			case GridStringId.CustomFilterDialogConditionGT:
				result = "大于>";
				return result;
			case GridStringId.CustomFilterDialogConditionGTE:
				result = "大于或等于>=";
				return result;
			case GridStringId.CustomFilterDialogConditionLT:
				result = "小于<";
				return result;
			case GridStringId.CustomFilterDialogConditionLTE:
				result = "小于或等于<=";
				return result;
			case GridStringId.CustomFilterDialogConditionBlanks:
				result = "空值";
				return result;
			case GridStringId.CustomFilterDialogConditionNonBlanks:
				result = "非空值";
				return result;
			case GridStringId.CustomFilterDialogConditionLike:
				result = "包含";
				return result;
			case GridStringId.CustomFilterDialogConditionNotLike:
				result = "不包含";
				return result;
			case GridStringId.MenuFooterSum:
				result = "合计";
				return result;
			case GridStringId.MenuFooterMin:
				result = "最小";
				return result;
			case GridStringId.MenuFooterMax:
				result = "最大";
				return result;
			case GridStringId.MenuFooterCount:
				result = "计数";
				return result;
			case GridStringId.MenuFooterAverage:
				result = "平均";
				return result;
			case GridStringId.MenuFooterNone:
				result = "空";
				return result;
			case GridStringId.MenuFooterSumFormat:
				result = "合计={0:#.##}";
				return result;
			case GridStringId.MenuFooterMinFormat:
				result = "最小={0}";
				return result;
			case GridStringId.MenuFooterMaxFormat:
				result = "最大={0}";
				return result;
			case GridStringId.MenuFooterCountFormat:
				result = "{0}";
				return result;
			case GridStringId.MenuFooterAverageFormat:
				result = "平均={0:#.##}";
				return result;
			case GridStringId.MenuColumnSortAscending:
				result = "升序排序";
				return result;
			case GridStringId.MenuColumnSortDescending:
				result = "降序排序";
				return result;
			case GridStringId.MenuColumnGroup:
				result = "按此列分组";
				return result;
			case GridStringId.MenuColumnUnGroup:
				result = "取消分组";
				return result;
			case GridStringId.MenuColumnColumnCustomization:
				result = "显示/隐藏字段";
				return result;
			case GridStringId.MenuColumnBestFit:
				result = "自动调整字段宽度";
				return result;
			case GridStringId.MenuColumnFilter:
				result = "筛选";
				return result;
			case GridStringId.MenuColumnClearFilter:
				result = "清除筛选条件";
				return result;
			case GridStringId.MenuColumnBestFitAllColumns:
				result = "自动调整所有字段宽度";
				return result;
			case GridStringId.MenuGroupPanelFullExpand:
				result = "展开全部分组";
				return result;
			case GridStringId.MenuGroupPanelFullCollapse:
				result = "收缩全部分组";
				return result;
			case GridStringId.MenuGroupPanelClearGrouping:
				result = "清除所有分组";
				return result;
			case GridStringId.PrintDesignerGridView:
				result = "打印设置(表格模式)";
				return result;
			case GridStringId.PrintDesignerCardView:
				result = "打印设置(卡片模式)";
				return result;
			case GridStringId.PrintDesignerBandedView:
				result = "打印设置(区域模式)";
				return result;
			case GridStringId.PrintDesignerBandHeader:
				result = "区标题";
				return result;
			case GridStringId.MenuColumnGroupBox:
				result = "显示/隐藏分组区";
				return result;
			case GridStringId.CardViewNewCard:
				result = "新卡片";
				return result;
			case GridStringId.CardViewQuickCustomizationButton:
				result = "自定义格式";
				return result;
			case GridStringId.CardViewQuickCustomizationButtonFilter:
				result = "筛选";
				return result;
			case GridStringId.CardViewQuickCustomizationButtonSort:
				result = "排序:";
				return result;
			case GridStringId.GridGroupPanelText:
				result = "拖动列标题到这进行分组";
				return result;
			case GridStringId.GridNewRowText:
				result = "新增资料";
				return result;
			case GridStringId.GridOutlookIntervals:
				result = "一个月以上;上个月;三周前;两周前;上周;;;;;;;;昨天;今天;明天;;;;;;;;下周;两周后;三周后;下个月;一个月之后;";
				return result;
			case GridStringId.PrintDesignerDescription:
				result = "为当前视图设置不同的打印选项.";
				return result;
			case GridStringId.MenuFooterCustomFormat:
				result = "自定={0}";
				return result;
			case GridStringId.MenuFooterCountGroupFormat:
				result = "计数={0}";
				return result;
			case GridStringId.MenuColumnClearSorting:
				result = "清除排序";
				return result;
			}
			result = base.GetLocalizedString(id);
			return result;
		}
	}
}
