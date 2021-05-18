using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeAnim
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists("ffmpeg.exe"))
            {
                RunApplication();
                return;
            }
            var envPath = Environment.GetEnvironmentVariable("Path").Split(';');
            foreach (var path in envPath)
            {
                if (File.Exists(Path.Combine(path, "ffmpeg.exe")))
                {
                    RunApplication();
                    return;
                }
            }
            MessageBox.Show("未找到ffmpeg.exe，请安装程序", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void RunApplication()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
