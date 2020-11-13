using System;

namespace ConsoleApp
{
    class Program
    {
        private static SamuraiAppData.SamuraiContext context = new SamuraiAppData.SamuraiContext();//این روش خوب نیست 
        //فقط برای برنامه های کوچیک خوبه => بهترین روش استفاده از الگوی ریپازیتوری و یونیت آو ورک است 
        //در این پروژه هدف صرفا EF CORE 
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
            var samurai = new SamuraiAppDomain.Samurai { Name = "Ruholah Jafari" };
            context.Samurais.Add(samurai);
            context.SaveChanges();
            
        }
        private static void GetSamurais(string text)
        {
            var samurais =context.Samurais
        }
    }
}
