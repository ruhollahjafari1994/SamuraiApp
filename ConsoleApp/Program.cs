using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static SamuraiAppData.SamuraiContext context = new SamuraiAppData.SamuraiContext();//این روش خوب نیست 
        //فقط برای برنامه های کوچیک خوبه => بهترین روش استفاده از الگوی ریپازیتوری و یونیت آو ورک است 
        //در این پروژه هدف صرفا EF CORE => صرفا سریع ترین تجربه کار با EF Core هست
        //This IS Not Best Practise For Real Application Just The Very Quickly Experience The Persistence Before Going Further with Your Learning 
        static void Main(string[] args)
        {
                context.Database.EnsureCreated();
            GetSamurais("Before Add : ");
            AddSamurai();
            GetSamurais("After Add : ");
            Console.WriteLine("Press Any Key ...");
            Console.ReadLine();
        }
        private static void AddSamurai()
        {
            var samurai = new SamuraiAppDomain.Samurai { Name = "Mr.Nobody" };
            context.Samurais.Add(samurai);
            context.SaveChanges();
            
        }
        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();
            Console.WriteLine($"{text} : Samurai Count Is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
