using System;
using eCom.Infrastructure.Cognitive;
using eCom.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace eCom
{
   internal class Program
    {
        static void Main(string[] args)
        {

             while (true)
             {
                 var command = System.Console.ReadLine();


                 if (!string.IsNullOrEmpty(command))
                 {
                     if (command.Trim().ToLower() == "exit")
                         break;

                     System.Console.WriteLine("Enter keywords to search products or type Exit to  close");

                     command = command.Trim().ToLower();

                     var res = Search.FindProducts(new PagingInfo(), command);

                     var drs = res.GetResults();

                    foreach (var dr in drs)
                     {
                         System.Console.WriteLine("ProductId: {0}, ProductName: {1}, CategoryName: {2}," +
                             "Price: {3}, Description: {4}, ImageUrl: {5}, DateAdd: {6}",
                        dr.Document.product_id, dr.Document.product_name, dr.Document.category_name,
                             dr.Document.price, dr.Document.description, dr.Document.image_url, dr.Document.date_added);
                        System.Console.WriteLine();
                     }

                     System.Console.WriteLine(res.TotalCount.ToString() + " total products found");
                     System.Console.ReadLine();


                 }

             }
                       
        }
    }
}
