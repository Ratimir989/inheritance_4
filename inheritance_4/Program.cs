using System;

namespace inheritance_4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
    class ProDocmentWorker : DocumentWorker
    {
        public string Key { get; } = "pro";

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocmentWorker
    {
        public new string Key { get; } = "exp";

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw;
            string key;
            Console.Write("Введите ключь для доступап к версии pro или expert: ");
            key = Console.ReadLine();
            if (key.Equals(new ProDocmentWorker().Key))
            {
                Console.WriteLine("Вы используете версию Pro!");
                dw = new ProDocmentWorker();
            }
            else if (key.Equals(new ExpertDocumentWorker().Key))
            {
                Console.WriteLine("Вы используете версию Expert!");
                dw = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("Вы используете стандартную версию редактора!");
                dw = new DocumentWorker();
            }
            Console.ReadKey();
        }
    }
}
