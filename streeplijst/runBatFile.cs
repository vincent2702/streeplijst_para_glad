using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streeplijst
{
    class runBatFile
    {
        public runBatFile() {
            BadFile();
        }
        public void BadFile() {

            Process proc = null;
            try
            {
                string batDir = string.Format(@"C:\Users\vince\Desktop\mysql_backup");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "backup_mysql.bat";
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Console.WriteLine("Bat file executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

    }
}
