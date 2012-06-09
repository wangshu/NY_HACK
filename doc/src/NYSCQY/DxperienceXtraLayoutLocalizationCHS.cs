using DevExpress.XtraLayout.Localization;
using System;
namespace NYSCQY
{
	public class DxperienceXtraLayoutLocalizationCHS : LayoutLocalizer
	{
		public override string Language
		{
			get
			{
				return "简体中文";
			}
		}
		public override string GetLocalizedString(LayoutStringId id)
		{
			string result;
			switch (id)
			{
			case LayoutStringId.CustomizationParentName:
				result = "自定义";
				return result;
			case LayoutStringId.DefaultItemText:
				result = "项目";
				return result;
			case LayoutStringId.DefaultActionText:
				result = "默认方式";
				return result;
			case LayoutStringId.DefaultEmptyText:
				result = "无";
				return result;
			case LayoutStringId.LayoutItemDescription:
				result = "版面";
				return result;
			case LayoutStringId.LayoutGroupDescription:
				result = "版面分组";
				return result;
			case LayoutStringId.TabbedGroupDescription:
				result = "版面标签组";
				return result;
			case LayoutStringId.LayoutControlDescription:
				result = "版面控件";
				return result;
			case LayoutStringId.CustomizationFormTitle:
				result = "自定义";
				return result;
			case LayoutStringId.HiddenItemsPageTitle:
				result = "隐藏项目";
				return result;
			case LayoutStringId.TreeViewPageTitle:
				result = "版面视图";
				return result;
			case LayoutStringId.RenameSelected:
				result = "重命名";
				return result;
			case LayoutStringId.HideItemMenutext:
				result = "隐藏项目";
				return result;
			case LayoutStringId.LockItemSizeMenuText:
				result = "锁定项目大小";
				return result;
			case LayoutStringId.UnLockItemSizeMenuText:
				result = "解开锁定项目大小";
				return result;
			case LayoutStringId.GroupItemsMenuText:
				result = "分组";
				return result;
			case LayoutStringId.UnGroupItemsMenuText:
				result = "取消分组";
				return result;
			case LayoutStringId.CreateTabbedGroupMenuText:
				result = "创建标签";
				return result;
			case LayoutStringId.AddTabMenuText:
				result = "新增标签";
				return result;
			case LayoutStringId.UnGroupTabbedGroupMenuText:
				result = "移除标签";
				return result;
			case LayoutStringId.TreeViewRootNodeName:
				result = "根目录";
				return result;
			case LayoutStringId.ShowCustomizationFormMenuText:
				result = "显示自定义窗体";
				return result;
			case LayoutStringId.HideCustomizationFormMenuText:
				result = "隐藏自定义窗体";
				return result;
			case LayoutStringId.EmptySpaceItemDefaultText:
				result = "空项";
				return result;
			case LayoutStringId.ControlGroupDefaultText:
				result = "组";
				return result;
			case LayoutStringId.EmptyRootGroupText:
				result = "拖动到这";
				return result;
			case LayoutStringId.EmptyTabbedGroupText:
				result = "拖动分组到标题区";
				return result;
			case LayoutStringId.ResetLayoutMenuText:
				result = "重置版面";
				return result;
			case LayoutStringId.RenameMenuText:
				result = "重命名";
				return result;
			case LayoutStringId.TextPositionMenuText:
				result = "文本位置";
				return result;
			case LayoutStringId.TextPositionLeftMenuText:
				result = "左";
				return result;
			case LayoutStringId.TextPositionRightMenuText:
				result = "右";
				return result;
			case LayoutStringId.TextPositionTopMenuText:
				result = "上";
				return result;
			case LayoutStringId.TextPositionBottomMenuText:
				result = "下";
				return result;
			case LayoutStringId.ShowTextMenuItem:
				result = "显示文本";
				return result;
			case LayoutStringId.LockSizeMenuItem:
				result = "锁定大小";
				return result;
			case LayoutStringId.LockWidthMenuItem:
				result = "锁定宽度";
				return result;
			case LayoutStringId.LockHeightMenuItem:
				result = "锁定高度";
				return result;
			}
			result = base.GetLocalizedString(id);
			return result;
		}
	}
}
