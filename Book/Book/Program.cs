using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace SecondTask
{
    class Book
    {
        public Book(string title, string author, string content)
        {
            MyTitleBook.Caption = title;
            MyAuthorBook.Writer = author;
            MyContentBook.Meaning = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            MyTitleBook.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            MyAuthorBook.Show();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MyContentBook.Show();
        }
        public Title MyTitleBook { get; set; } = new Title();
        public Author MyAuthorBook { get; set; } = new Author();
        public Content MyContentBook { get; set; } = new Content();
    }

    class Title
    {
        public string Caption { get; set; }
        public void Show()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Назва: " + Caption);
        }
    }

    class Author
    {
        public string Writer { get; set; }
        public void Show()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Автор: " + Writer);
        }

    }

    class Content
    {
        public string Meaning { get; set; }
        public void Show()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Зміст: " + Meaning);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book;
            Console.WriteLine("Введіть назву книги та її автора, ось таким чином => назва$автор):");
            string[] input = Console.ReadLine().Split('$');
            Console.WriteLine("Введіть зміст книги: ");
            string content = Console.ReadLine();
            book = new Book(input[0], input[1], content);
            book.Show();
            Console.ReadKey();
        }
    }
}
