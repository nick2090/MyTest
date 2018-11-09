using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int xx = 0; xx < 3; xx++)
            //{
            //    using (var db = new EFDataContext())
            //    {
            //        Console.WriteLine("输入一个新博客名称：");
            //        var name = Console.ReadLine();

            //        var blog = new Blog { Name = name };
            //        var post = new Post();



            //        for (int k = 0; k < 4; k++)
            //        {
            //            Post a = new Post();
            //            a.Title = "adsklfdksf";
            //            a.Content = "djfewikw;";
            //            db.Posts.Add(a);
            //        }

            //        db.Blogs.Add(blog);
            //        db.Posts.Add(post);
            //        db.SaveChanges();
            //        var query = from b in db.Blogs
            //                    orderby b.Name
            //                    select b;

            //        Console.WriteLine("数据库中全部博客：");
            //        foreach (var item in query)
            //        {
            //            Console.WriteLine(item.Name);
            //        }
            //        Console.WriteLine("数据库中全部博客文章：");
            //        var query2 = from b in db.Posts
            //                     orderby b.Title
            //                     select b;
            //        foreach (var item in query2)
            //        {
            //            Console.WriteLine(item.Title);
            //            Console.WriteLine(item.Content);
            //        }

            //    }
            //}

            using (var db = new EFDataContext())
            {


            }
                Console.ReadKey();
        }
    }
}
