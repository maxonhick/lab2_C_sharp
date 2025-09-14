using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    // The class of an pro employee with documents that is inherited from a DocumentWorker
    public class ProDocumentWorker: DocumentWorker
    {
        // Redefining the document saving and editing functions
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }
}
