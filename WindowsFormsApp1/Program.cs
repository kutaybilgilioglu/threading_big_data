using System;
using System.Collections.Generic;
using System.Linq;
using LINQtoCSV;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    static class Globals
    {
        public static List<Data_set> yazlab_list = new List<Data_set>();
        public static List<int> indexes = new List<int>();
        public static float[] thr_runtime = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static List<found_index> result_i = new List<found_index>();
        public static ui_data ui_info = new ui_data(0,0,0,0,0,0);
        public static bool is_pressed = false;

    }
    internal class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("teste2");
            ReadCsvFile();
            /*Thread[] workerThreads = new Thread[Globals.ui_info.Thread_];
            for (int a = 0; a < Globals.ui_info.Thread_; a++)
            {
                Console.WriteLine("thread start");
                workerThreads[a] = new Thread(thread_method);
                //workerThreads[a].IsBackground = false;
                workerThreads[a].Start(a);
            }*/
            Console.WriteLine($"{Globals.yazlab_list.ElementAt(0).Product}");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
            Console.WriteLine($"{Globals.yazlab_list.Count}");
            Console.WriteLine($"{Globals.ui_info.Count_}");
            Console.WriteLine("teste");
            Console.WriteLine("teste");
            

            Console.WriteLine(Globals.yazlab_list.ElementAt(0).Product);
            //await ParallelAsync(5);
           
              
                   
                    
                
            
            
            

        
        }
        public static void thread_method(object threadID)
        {
            
            var diff = 0;
            var row = 0;
            var f = new Form1();
            
            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = (int)threadID; i < Globals.ui_info.Count_; i++)
            {
                //Console.WriteLine($"count: {Globals.indexes.Count}");
                if (Globals.indexes.Count() == (Globals.ui_info.Count_ - 1))
                {
                    timer.Stop();
                    Globals.thr_runtime[(int)threadID] = (float)(timer.ElapsedMilliseconds / 1000);
                    Console.WriteLine($"thread_id:{threadID} runtime:{timer.ElapsedMilliseconds / 1000} seconds");
                    return;
                }
                if (Globals.indexes.Contains(i))
                {
                    continue;
                }
                Globals.indexes.Add(i);
                if (Globals.ui_info.Comp == 1)
                {
                    for (int j = i + 1; j < Globals.ui_info.Count_; j++)
                    {
                        diff = stringDifference(Globals.yazlab_list.ElementAt(i).Product, Globals.yazlab_list.ElementAt(j).Product);
                        if (diff > Globals.ui_info.Oran)
                        {
                            
                            //f.insert_table(row, i, j, diff);
                            //row++;
                            Globals.result_i.Add(new found_index(i, j, diff));

                        }
                    }
                }
                else if (Globals.ui_info.Comp == 2)
                {
                    for (int j = i + 1; j < Globals.ui_info.Count_; j++)
                    {
                        diff = stringDifference(Globals.yazlab_list.ElementAt(i).Issue, Globals.yazlab_list.ElementAt(j).Issue);
                        if (diff > Globals.ui_info.Oran)
                        {
                            f.insert_table(row, i, j, diff);
                            row++;
                            //Globals.result_i.Add(new found_index(i, j, diff));

                        }
                    }
                }
                else if (Globals.ui_info.Comp == 3)
                {
                    for (int j = i + 1; j < Globals.ui_info.Count_; j++)
                    {
                        diff = stringDifference(Globals.yazlab_list.ElementAt(i).Company, Globals.yazlab_list.ElementAt(j).Company);
                        if (diff > Globals.ui_info.Oran)
                        {
                            f.insert_table(row, i, j, diff);
                            row++;
                            //Globals.result_i.Add(new found_index(i, j, diff));

                        }
                    }
                }
                else
                {
                    for (int j = i + 1; j < Globals.ui_info.Count_; j++)
                    {
                        diff = stringDifference(Globals.yazlab_list.ElementAt(i).State, Globals.yazlab_list.ElementAt(j).State);
                        if (diff > Globals.ui_info.Oran)
                        {
                            f.insert_table(row, i, j, diff);
                            row++;
                            //Globals.result_i.Add(new found_index(i, j, diff));

                        }
                    }
                }

               


            }
            timer.Stop();
            Globals.thr_runtime[(int)threadID] = (float)(timer.ElapsedMilliseconds / 1000);
            Console.WriteLine($"thread_id:{threadID} runtime:{timer.ElapsedMilliseconds / 1000} seconds");
            return;
        }
        public static void ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,

                UseFieldIndexForReadingData = false
            };
            char[] charsToTrim = { ',', '.' };
            var csvContext = new CsvContext();
            var csvContext2 = new CsvContext();
            var rows = csvContext.Read<Rows>("yazlab.csv", csvFileDescription);
            //List<Data_set> yazlab_list = new List<Data_set>();
            //var yazlab_list = new Yazlab_List();
            foreach (var row in rows)
            {
                if (row.Product == null || row.Company == null || row.ID == null || row.Issue == null || row.State == null || row.Zip_Code == null)
                {
                    continue;
                }
                else
                {
                    row.Product = row.Product.Replace(".", "");
                    row.Company = row.Company.Replace(".", "");
                    row.Issue = row.Issue.Replace(".", "");
                    row.State = row.State.Replace(".", "");
                    Globals.yazlab_list.Add(new Data_set(row.Product.Replace(",", ""), row.Issue.Replace(",", ""), row.Company.Replace(",", ""), row.State.Replace(",", ""), row.ID, row.Zip_Code));
                }
                //Console.WriteLine($"{row.Product.Replace(",","")} | {row.Issue.Replace(",","")} | {row.Company.Replace(",","")} |{row.State.Replace(",","")}| {row.ID} | {row.Zip_Code}");
            }


        }
        
        public static int stringDifference(string str1, string str2)
        {
            List<string> diff;

            int oran;
            IEnumerable<string> set1 = str1.Split(' ');
            IEnumerable<string> set2 = str2.Split(' ');

            if (set2.Count() > set1.Count())
            {
                diff = set2.Where(e => !set1.Any(f => f == e)).ToList();
                oran = 100 - (diff.Count() * 100) / set2.Count();

            }
            else
            {
                diff = set1.Where(e => !set2.Any(f => f == e)).ToList();
                oran = 100 - (diff.Count() * 100) / set1.Count();
                //Console.WriteLine((diff.Count()*100)/set2.Count());
            }
            //Console.WriteLine(diff.Count());
            return oran;
        }
    }
}
