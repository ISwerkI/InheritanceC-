using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Academy
{
    internal class Streamer
    {
        public void Save(Human[] group, string filename)
        {
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
            //string filename = "group.csv";
            StreamWriter writer = new StreamWriter(filename);
            foreach (Human h in group)
            {
                writer.WriteLine(h.ToFileSring());
            }
            writer.Close();
            Process.Start("notepad", filename);
        }

        public void Print(Human[] group)
        {
            foreach (Human h in group)
            {
                Console.WriteLine(h);
            }
        }

        public Human[] Load(string filename)
        {
            List<Human> group = new List<Human>();
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string record = reader.ReadLine();
                Console.WriteLine(record);
                group.Add(Factory.Create(record.Split(':').First()).Init(record.Split(":,;".ToCharArray())));
            }

            reader.Close();
            return group.ToArray();
        }
    }

}
