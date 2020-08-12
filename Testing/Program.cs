
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {

        
        
        static void Main(string[] args)
        {
            Test();

            Console.ReadKey();
        }
        public static void Test()
        {

            Thread th = new Thread(searchForFile);

            th.Start();

            


            

            
        }

        public static void readArrayToFile()
        {
            ArrayList test = new ArrayList();

            generateArray(test);

            var clone = (from string item in test select item).GroupBy(s => s).Select(
            group => new { Word = group.Key, Count = group.Count() }).Where(x => x.Count >= 1);

            foreach (var duplicate in clone)
            {
                //Items.Add(duplicate.Word);
                Console.WriteLine(duplicate.Word);
            }
        }

        private static void generateArray(ArrayList ar)
        {
            ar.Add("test1");
            ar.Add("test2");
            ar.Add("test3");
            ar.Add("test3");
            ar.Add("test3");
            ar.Add("test4");
            ar.Add("test5");
            ar.Add("test5");
            ar.Add("test5");
            ar.Add("test5");
            ar.Add("test6");
            ar.Add("test2");
            ar.Add("test3");
            ar.Add("Funktioniert");

            ar.Sort();
        }
        public static void searchForFile()
        {
            while (true) { 
                string[] filePaths = Directory.GetFiles(@"c:\temp\");
                if (filePaths.Length > 1) {

                    readArrayToFile();
                    //
                    //Convert File
                    //
                    deleteOldFile();


                }
                Thread.Sleep(5000);
            }
        }

        private static void deleteOldFile()
        {
            throw new NotImplementedException();
        }
    }
    
}
