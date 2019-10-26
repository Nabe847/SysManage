using System;
using SysInfo;

namespace SysManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SystemInformation.MachineName);
            Console.WriteLine(SystemInformation.UserName);
            Console.WriteLine(SystemInformation.Platform);
        }
    }
}
