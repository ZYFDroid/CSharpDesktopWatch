using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    static class Program
    {

        public static FileInfo requestFileInfo = null;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && File.Exists(args[0])) {
                requestFileInfo =new FileInfo(new FileInfo(args[0]).FullName);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Environment.CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            Application.Run(new Form1());
        }
    }
}
