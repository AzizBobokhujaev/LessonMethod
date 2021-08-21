using System;

namespace ConsoleApp
{
    // Class Rectangle
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double AreaCalculator()
        {
            return this.side1 * this.side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (this.side1 + this.side2);
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
        public void Print()
        {
            Console.WriteLine($"Area = {Area}\nPerimeter = {Perimeter}");
        }
    }
    // Class Book
    class Book
    {
        public Title newTitle { get; set; }
        public Author newAuthor { get; set; }
        public Content newContent { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            newTitle.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            newAuthor.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            newContent.Show();
        }
        public Book()
        {
            newTitle = new Title();
            newAuthor = new Author();
            newContent = new Content();
        }
        public Book(string bookTitle, string autName, string bookContent)
        {
           
            newTitle = new Title();
            newAuthor = new Author();
            newContent = new Content();
            newTitle.BookName = bookTitle;
            newAuthor.AuthorName = autName;
            newContent.Content_ = bookContent;
        }

    }
    class Title
    {
        public string BookName { get; set; }
        public void Show()
        {
            Console.WriteLine($"Имя книги: {BookName}");
        }
    }
    class Author
    {
        public string AuthorName { get; set; }
        public void Show()
        {
            Console.WriteLine($"Имя автора: {AuthorName}");
        }
    }
    class Content
    {
        public string Content_ { get; set; }
        public void Show()
        {
            Console.WriteLine($"Содержание: {Content_}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Homework_2----------");
            Console.Write("A = "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine());
            Rectangle rct = new Rectangle(a, b);
            rct.Print();
            Console.WriteLine("----------HomeWork_3----------");
            Console.Write("Введите название книги: "); string title = Console.ReadLine();
            Console.Write("Введите автора книги: "); string author = Console.ReadLine();
            Console.Write("Введите содержания книги: "); string content = Console.ReadLine();
            Book book = new Book(title, author, content);
            book.Show();

        }
    }
}
