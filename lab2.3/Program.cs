using lab2_3;

namespace lab2_3
{
    class task3
    {
        static void Main()
        {
            // Reading the access key
            Console.Write("Введите ключ доступа: ");
            string? access_key = Console.ReadLine();

            // Creating the right employee
            DocumentWorker worker;
            switch (access_key)
            {
                case "pro": worker = new ProDocumentWorker(); break;
                case "exp": worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }

            // Working with the document
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}