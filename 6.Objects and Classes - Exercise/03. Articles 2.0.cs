using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string title = command[0];
                string content = command[1];
                string autor = command[2];

                Article article = new Article();

                article.Title = title;
                article.Content = content;
                article.Autor = autor;

                articles.Add(article);

            }

            string orderCriteria = Console.ReadLine();

            switch (orderCriteria)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Autor).ToList();
                    break;
            }

            foreach (Article item in articles)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Autor}");
            }
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }


        //public override string ToString()
        //{
        //    return $"{Title} - {Content}: {Autor}";
        //}
    }
}
