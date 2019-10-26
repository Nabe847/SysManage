using System;
using System.Collections.Generic;
using System.Text;

namespace SysInfo
{
    public static class SystemInformation
    {
        /// <summary>
        /// ローカル コンピューターの NetBIOS 名を取得します。
        /// </summary>
        public static string MachineName => Environment.MachineName;

        /// <summary>
        /// 現在オペレーティング システムにログオンしている人のユーザー名を取得します。
        /// </summary>
        public static string UserName => Environment.UserName;

        /// <summary>
        /// オペレーティング システム プラットフォームを識別する文字列を取得します。
        /// </summary>
        public static string Platform => Environment.OSVersion.Platform.ToString();
    }
}
