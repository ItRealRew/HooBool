using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HoodBool.Models;
using System.Text.Json;

namespace HoodBool.Services
{
    public class SettingsHandler
    {
        public void Get()
        {
            string path = @"MyDir";
            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine(File.ReadAllText(path));
                }
                else
                {
                    string[] dirs = Directory.GetFiles(Directory.GetCurrentDirectory());
                    File.Create(Directory.GetCurrentDirectory());
                    Console.WriteLine();
                    Console.WriteLine("ПУТЬ ГОВНО");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Set()
        {

        }
    }
}