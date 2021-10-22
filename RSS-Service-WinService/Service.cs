using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSS_Service_WinService
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }


        public void OnDebug()
        {
            OnStart(null);
        }


        protected override void OnStart(string[] args)
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Application started" + Environment.NewLine);
            while (0 == 0)
            {
                Thread.Sleep(1000);
                File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Item" + Environment.NewLine);
            }
        }

        protected override void OnStop()
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Application ended" + Environment.NewLine);
        }
    }
}
