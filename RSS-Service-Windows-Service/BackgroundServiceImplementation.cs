using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSS_Service_Windows_Service
{
    public class BackgroundServiceImplementation : BackgroundService
    {

        public async Task OnDebug()
        {
            await StartAsync(new CancellationToken());
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Application started" + Environment.NewLine);

            await base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                string fullpath = System.IO.Directory.GetCurrentDirectory();
                string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
                File.AppendAllText(mainpath + @"Logs\" + "log.txt", "test" + Environment.NewLine);
                await Task.Delay(1000, cancellationToken);
            }
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Application ended" + Environment.NewLine);
            await base.StopAsync(cancellationToken);
        }
    }
}
