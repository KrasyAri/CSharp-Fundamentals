using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Content = command[1];
                        break;
                    case "ChangeAuthor":
                        article.Autor = command[1];
                        break;
                    case "Rename":
                        article.Title = command[1];
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public Article(string title, string content, string autor)
        {
            this.Title = title;
            this.Content = content;
            this.Autor = autor;
        }

        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAutor(string autor)
        {
            this.Autor = autor;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
