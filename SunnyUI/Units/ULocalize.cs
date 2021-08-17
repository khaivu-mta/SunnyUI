/******************************************************************************
 * SunnyUI 开源控件库、工具类库、扩展类库、多页面开发框架。
 * CopyRight (C) 2012-2021 ShenYongHua(沈永华).
 * QQ群：56829229 QQ：17612584 EMail：SunnyUI@QQ.Com
 *
 * Blog:   https://www.cnblogs.com/yhuse
 * Gitee:  https://gitee.com/yhuse/SunnyUI
 * GitHub: https://github.com/yhuse/SunnyUI
 *
 * SunnyUI.Common.dll can be used for free under the MIT license.
 * If you use this code, please keep this note.
 * 如果您使用此代码，请保留此说明。
 ******************************************************************************
 * 文件名称: UIFormHelper.cs
 * 文件说明: 多语言字符串定义
 * 当前版本: V3.0
 * 创建日期: 2020-01-01
 *
 * 2020-04-19: V2.2.0 增加文件说明
 * 2021-07-24: V3.0.5 内置字符串已经处理完国际化
******************************************************************************/

namespace Sunny.UI
{
    public static class UILocalize
    {
        public static string InfoTitle = "Thông báo";
        public static string SuccessTitle = "Thành công";
        public static string WarningTitle = "Cảnh cáo";
        public static string ErrorTitle = "Lỗi";
        public static string AskTitle = "Truy suất";
        public static string InputTitle = "Nhập";
        public static string SelectTitle = "Chọn";
        public static string CloseAll = "Đóng toàn bộ";
        public static string OK = "OK";
        public static string Cancel = "Huỷ bỏ";
        public static string GridNoData = "[ Không có dữ liệu ]";
        public static string GridDataLoading = "Đang tải ...";
        public static string GridDataSourceException = "Nguồn dữ liệu phải được định nghĩa trong DataTable hoặc List";
        public static string SystemProcessing = "Hệ thống đang xử lý ...";

        public static string Monday = "T2";
        public static string Tuesday = "T3";
        public static string Wednesday = "T4";
        public static string Thursday = "T5";
        public static string Friday = "T6";
        public static string Saturday = "T7";
        public static string Sunday = "CN";

        public static string Prev = "Trước";
        public static string Next = "Sau";
        public static string SelectPageLeft = "Trái";
        public static string SelectPageRight = "Phải";

        public static string January = "Th.1";
        public static string February = "Th.2";
        public static string March = "Th.3";
        public static string April = "Th.4";
        public static string May = "Th.5";
        public static string June = "Th.6";
        public static string July = "Th.7";
        public static string August = "Th.8";
        public static string September = "Th.9";
        public static string October = "Th.10";
        public static string November = "Th.11";
        public static string December = "Th.12";

        public static string Today = "Hôm nay";
    }

    public static class UILocalizeHelper
    {
        public static void SetVI()
        {
            UILocalize.InfoTitle = "Thông báo";
            UILocalize.SuccessTitle = "Thành công";
            UILocalize.WarningTitle = "Cảnh cáo";
            UILocalize.ErrorTitle = "Lỗi";
            UILocalize.AskTitle = "Truy suất";
            UILocalize.InputTitle = "Nhập";
            UILocalize.SelectTitle = "Chọn";
            UILocalize.CloseAll = "Đóng toàn bộ";
            UILocalize.OK = "OK";
            UILocalize.Cancel = "Huỷ bỏ";
            UILocalize.GridNoData = "[ Không có dữ liệu ]";
            UILocalize.GridDataLoading = "Đang tải ...";
            UILocalize.GridDataSourceException = "Nguồn dữ liệu phải được định nghĩa trong DataTable hoặc List";
            UILocalize.SystemProcessing = "Hệ thống đang xử lý ...";

            UILocalize.Monday = "T2";
            UILocalize.Tuesday = "T3";
            UILocalize.Wednesday = "T4";
            UILocalize.Thursday = "T5";
            UILocalize.Friday = "T6";
            UILocalize.Saturday = "T7";
            UILocalize.Sunday = "CN";

            UILocalize.Prev = "Trước";
            UILocalize.Next = "Sau";
            UILocalize.SelectPageLeft = "Trái";
            UILocalize.SelectPageRight = "Phải";

            UILocalize.January = "Th.1";
            UILocalize.February = "Th.2";
            UILocalize.March = "Th.3";
            UILocalize.April = "Th.4";
            UILocalize.May = "Th.5";
            UILocalize.June = "Th.6";
            UILocalize.July = "Th.7";
            UILocalize.August = "Th.8";
            UILocalize.September = "Th.9";
            UILocalize.October = "Th.10";
            UILocalize.November = "Th.11";
            UILocalize.December = "Th.12";

            UILocalize.Today = "Hôm nay";

            UIStyles.Translate();
        }
        public static void SetEN()
        {
            UILocalize.InfoTitle = "Info";
            UILocalize.SuccessTitle = "Success";
            UILocalize.WarningTitle = "Warning";
            UILocalize.ErrorTitle = "Error";
            UILocalize.AskTitle = "Query";
            UILocalize.InputTitle = "Input";
            UILocalize.SelectTitle = "Select";
            UILocalize.CloseAll = "Close all";
            UILocalize.OK = "OK";
            UILocalize.Cancel = "Cancel";
            UILocalize.GridNoData = "[ No data ]";
            UILocalize.GridDataLoading = "Data loading, please wait...";
            UILocalize.GridDataSourceException = "The data source must be DataTable or List";
            UILocalize.SystemProcessing = "The system is processing, please wait...";

            UILocalize.Monday = "Mon.";
            UILocalize.Tuesday = "Tue.";
            UILocalize.Wednesday = "Wed.";
            UILocalize.Thursday = "Thur.";
            UILocalize.Friday = "Fri.";
            UILocalize.Saturday = "Sat.";
            UILocalize.Sunday = "Sun.";

            UILocalize.Prev = "Previous";
            UILocalize.Next = "Next";
            UILocalize.SelectPageLeft = "Page";
            UILocalize.SelectPageRight = "";

            UILocalize.January = "Jan.";
            UILocalize.February = "Feb.";
            UILocalize.March = "Mar.";
            UILocalize.April = "Apr.";
            UILocalize.May = "May";
            UILocalize.June = "Jun.";
            UILocalize.July = "Jul.";
            UILocalize.August = "Aug.";
            UILocalize.September = "Sep.";
            UILocalize.October = "Oct.";
            UILocalize.November = "Nov.";
            UILocalize.December = "Dec.";

            UILocalize.Today = "Today";

            UIStyles.Translate();
        }

        public static void SetCH()
        {
            UILocalize.InfoTitle = "提示";
            UILocalize.SuccessTitle = "正确";
            UILocalize.WarningTitle = "警告";
            UILocalize.ErrorTitle = "错误";
            UILocalize.AskTitle = "提示";
            UILocalize.InputTitle = "输入";
            UILocalize.SelectTitle = "选择";
            UILocalize.CloseAll = "全部关闭";
            UILocalize.OK = "确定";
            UILocalize.Cancel = "取消";
            UILocalize.GridNoData = "[ 无数据 ]";
            UILocalize.GridDataLoading = "数据加载中，请稍候...";
            UILocalize.GridDataSourceException = "数据源必须为DataTable或者List";
            UILocalize.SystemProcessing = "系统正在处理中，请稍候...";

            UILocalize.Monday = "一";
            UILocalize.Tuesday = "二";
            UILocalize.Wednesday = "三";
            UILocalize.Thursday = "四";
            UILocalize.Friday = "五";
            UILocalize.Saturday = "六";
            UILocalize.Sunday = "日";

            UILocalize.Prev = "上一页";
            UILocalize.Next = "下一页";

            UILocalize.SelectPageLeft = "第";
            UILocalize.SelectPageRight = "页";

            UILocalize.January = "一月";
            UILocalize.February = "二月";
            UILocalize.March = "三月";
            UILocalize.April = "四月";
            UILocalize.May = "五月";
            UILocalize.June = "六月";
            UILocalize.July = "七月";
            UILocalize.August = "八月";
            UILocalize.September = "九月";
            UILocalize.October = "十月";
            UILocalize.November = "十一月";
            UILocalize.December = "十二月";

            UILocalize.Today = "今天";

            UIStyles.Translate();
        }
    }
}