using System;
using System.Collections.Generic;
using System.Text;

namespace SysInfo
{
    /// <summary>
    /// 現在のシステム環境に関する情報を提供します。
    /// </summary>
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
