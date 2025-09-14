using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    // The basic class of an employee with documents
    public class DocumentWorker
    {
        // Basic functions for opening, editing, and saving a document
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версси Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
}
