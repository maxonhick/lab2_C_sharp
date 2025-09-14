using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    // The class of an expert employee with documents that is inherited from a ProDocumentWorker
    public class ExpertDocumentWorker: ProDocumentWorker
    {
        // Redefining the document saving function
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
