namespace Launcher.HelpClasses
{
    internal class Strings
    {
        public class Info
        {
            public static readonly string NOT_SET = "未指定";

            public static readonly string PATH_CHOOSE = "选择游戏客户端文件夹";

            public static readonly string INIT = "初始化…";

            public static readonly string UPDATE_IN_PROGRESS = "正在更新…";
            public static readonly string UPDATE_DONE = "游戏已更新";
        }

        public class Error
        {
            public static readonly string CONNECTION_ERROR = "连接错误";
            public static readonly string CONNECTION_ERROR_EXPLAIN = "无法连接到Internet，请检查连接并重试";

            public static readonly string PATH_ERROR = "位置错误";
            public static readonly string PATH_ERROR_EXPLAIN = "找不到文件wow.exe";

            public static readonly string PATH_CHOOSE_ERROR = "文件夹选择错误";
            public static readonly string PATH_CHOOSE_ERROR_EXPLAIN = "在选定的文件夹中找不到文件wow.exe";
        }

    }
}