using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logfournetdemo
{
    internal class prilev
    {
        public void Getlog()
        {
            String path = "C:/Users/User/Desktop/logfournet.txt";
            String levelpath = "C:/Users/User/Desktop/levels.txt";

            String line, levelline;
            List<String> levellines = new List<String>();

            ////////////////////////////////

            try
            {
                StreamReader sr1 = new StreamReader(levelpath);
                levelline = sr1.ReadLine();
                levellines.Add(levelline);
                while (levelline != null)
                {
                    levelline = sr1.ReadLine();
                    //Console.WriteLine(levelline);
                    levellines.Add(levelline);
                }
                sr1.Close();
            }
            catch (Exception ex) { Console.WriteLine("went to catch sr1"); }

            levellines.RemoveAll(string.IsNullOrEmpty);

            foreach (String st in levellines)
            {
                Console.WriteLine(st);
            }

            ///////////////////////////////

            try
            {
                StreamReader sr2 = new StreamReader(path);
                line = sr2.ReadLine();

                while (line != null)
                {
                    foreach (String level in levellines)
                    {
                        if (line.Contains(level))
                            Console.WriteLine(line);
                    }
                    //Console.WriteLine(line);
                    line = sr2.ReadLine();
                }
                sr2.Close();
            }
            catch (Exception ex) { Console.WriteLine("went to catch sr2"); }
        }
    }
}
