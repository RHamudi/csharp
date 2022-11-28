using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            // var articles = new List<Article>();
            // articles.Add(new Article("Artigo sobre opp", "orientação-objetos"));
            // articles.Add(new Article("Artigo sobre c#", "csharp"));
            // articles.Add(new Article("Artigo sobre .Net", ".net"));
            // foreach (var item in articles)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.Title);
            //     Console.WriteLine(item.Url);
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASPNET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-.dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem2);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine(notification.Propety);
                        Console.WriteLine(notification.Message);
                    }
                }
            }
        }
    }
}