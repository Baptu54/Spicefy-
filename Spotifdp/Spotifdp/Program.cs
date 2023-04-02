using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using Microsoft.Win32;
using System.Text;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Globalization;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Spotifdp
{
    public partial class Program
    {
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.SetValue("Spotifdp", Application.ExecutablePath);
            for (; ; )
            {
                if (Process.GetProcessesByName("spotify").Length > 0)
                {
                    Application.Run(new Form1());
                    break;
                }
                else
                {
                    Thread.Sleep(5000);
                }                
            }
        }      
    }
}
