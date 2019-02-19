﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Updater
{
    public class UpdateChecker
    {
        private static readonly DirectoryInfo UpdaterBaseDirectory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\g-node\GinWindowsClient\Updates\");
        private static readonly string UpdatedMsi = "https://web.gin.g-node.org/G-Node/gin-ui-installers/raw/master/Setup.msi";

        public static void DoUpdate()
        {
            try
            {
                var wb = new WebClient();
                wb.DownloadFile(new Uri(UpdatedMsi), UpdaterBaseDirectory + @"\setup.msi");
            }
            catch(Exception e) {
                MessageBox.Show("Error unable to download new version.");
                return;
            }
            if (!UninstallProgram("Gin Windows Client")) return;
            var procstartinfo = new ProcessStartInfo();
            procstartinfo.FileName = "msiexec.exe";
            procstartinfo.Arguments = "/i \"" + UpdaterBaseDirectory.FullName + "\\setup.msi\"";
            procstartinfo.CreateNoWindow = true;
            procstartinfo.UseShellExecute = true;
            procstartinfo.Verb = "runas";
            var process = Process.Start(procstartinfo);
            process.WaitForExit();
        }
        /// <summary>
        /// uninstalls old version of GinUI
        /// </summary>
        /// <param name="ProgramName">Name of program</param>
        /// <returns>true for success</returns>
        private static bool UninstallProgram(string ProgramName)
        {
            try
            {
                var installedPrograms =
                    GetSubkeysValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
                        RegistryHive.LocalMachine);

                foreach (var key in installedPrograms)
                {
                    if ((from value in key.Values where value.Key == "DisplayName" select value.Value as string).Any(s => s != null &&
                                                                                                                          s == "Gin Windows Client"))
                    {
                        var uninstallString = (from value in key.Values
                                               where value.Key == "UninstallString"
                                               select value.Value as string).First();

                        uninstallString = uninstallString.Replace("/I", "/x");
                        var psInfo = new ProcessStartInfo();
                        psInfo.FileName = "cmd.exe";
                        psInfo.Arguments = "/C " + uninstallString + " /q";
                        psInfo.CreateNoWindow = true;
                        psInfo.UseShellExecute = true;
                        psInfo.Verb = "runas";
                        var process = Process.Start(psInfo);
                        process.WaitForExit();
                        return process.ExitCode == 0;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }

        class Key
        {
            public string KeyName { get; set; }
            public List<KeyValuePair<string, object>> Values { get; set; }
        }

        private static List<Key> GetSubkeysValue(string path, RegistryHive hive)
        {
            var result = new List<Key>();
            using (var hiveKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
            using (var key = hiveKey.OpenSubKey(path))
            {
                var subkeys = key.GetSubKeyNames();

                foreach (var subkey in subkeys)
                {
                    var values = GetKeyValue(key, subkey);
                    result.Add(values);
                }
            }
            return result;
        }

        private static Key GetKeyValue(RegistryKey hive, string keyName)
        {
            var result = new Key() { KeyName = keyName, Values = new List<KeyValuePair<string, object>>() };
            var key = hive.OpenSubKey(keyName);
            if (key != null)
            {
                foreach (var valueName in key.GetValueNames())
                {
                    var val = key.GetValue(valueName);
                    var pair = new KeyValuePair<string, object>(valueName, val);
                    result.Values.Add(pair);
                }
            }

            return result;
        }
    }
}