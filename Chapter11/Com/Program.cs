using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (var report = new Report())
            {

                Console.WriteLine("To start word press Enter");
                Console.ReadLine();

                //dynamic word = new Application();
                //dynamic doc = word.Documents.Add();
                //doc.Activate();
                var doc = report.AddDocument();

                Console.WriteLine("Look in Task Manager for Word.");
                Console.ReadLine();

                Console.WriteLine("Press Enter to close and quit Word.");
                Console.ReadLine();

                //word.Quit();

                Console.WriteLine("Look in Task Manager for Word.");
                Console.ReadLine();
            }
        }
    }

    class Report: IDisposable {

        private dynamic _word;

        public dynamic Document { get; set; }
       
        public Report()
        {
            _word = new Application();            
        }

        public dynamic AddDocument()
        {
            dynamic doc = _word.Documents.Add();
            doc.Activate();
            return doc;
        }

        public void Dispose()
        {
            _word.Quit();
        }
    }

}
