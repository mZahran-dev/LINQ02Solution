using System.ComponentModel;
using static LINQ02.ListGenerators;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            #region 1.Get first Product out of Stock 
            //var Result = ProductList.FirstOrDefault(p=> p.UnitsInStock == 0);
            //Console.WriteLine(Result);
            #endregion

            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion

            #region 3.Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(a => a > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(res);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(a => a % 2 != 0);
            //Console.WriteLine(result);
            #endregion

            #region 2.Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(c => new
            //{
            //    customerName = c.CustomerName,
            //    orderCount = c.Orders.Count()
            //}
            //).ToList();
            //foreach (var customer in result)
            //{
            //    Console.WriteLine($"{customer.customerName}: {customer.orderCount} orders");
            //}

            #endregion

            #region 3.Return a list of categories and how many products each has
            //var result = ProductList.Select(c => new
            //{
            //    category = c.Category,
            //    categoryCount = c.Category.Count(),
            //}
            //).ToList();
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.category}: {product.categoryCount} orders");
            //}
            #endregion

            #region 4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum(x => x);
            //Console.WriteLine(result);
            #endregion

            #region 5.Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            string filePath = "dictionary_english.txt";
            string[] words = File.ReadAllLines (filePath);
            //int totalCharCount = words.Sum(word => word.Length);
            //Console.WriteLine(totalCharCount);

            #endregion

            #region 6.Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int shortestWord = words.Where(w => !string.IsNullOrEmpty(w)).Min(w => w.Length);
            //Console.WriteLine(shortestWord);

            #endregion

            #region 7.Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int longestWord = words.Where(word => !string.IsNullOrWhiteSpace(word)).Max(w => w.Length);
            //Console.WriteLine(longestWord);

            #endregion

            #region 8.Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //double averageLength = words.Where(word => !string.IsNullOrWhiteSpace(word)).Average(w => w.Length);
            //Console.WriteLine(averageLength);

            #endregion

            #region 9.Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new { productCategory = c.Key, totalUnits = c.Sum(p => p.UnitsInStock) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.productCategory}: {item.totalUnits} units in stock");
            //}

            #endregion

            #region 10.Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new { productCategory = c.Key, cheapestPrice = c.Min(m => m.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.productCategory}: {item.cheapestPrice} ");
            //}

            #endregion

            #region 11.Get the products with the cheapest price in each category (Use Let)
            //var results = from product in ProductList
            //              let res = ProductList
            //              .Where(p => p.Category == product.Category)
            //              .Min(p => p.UnitPrice)
            //              where product.UnitPrice == res                    
            //              select new
            //              {
            //                    Category = product.Category,
            //                    product = product
            //              };


            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result}");
            //}
            #endregion

            #region 12.Get the most expensive price among each category's products.
            //var results = from product in ProductList
            //              let mostExpensive = ProductList
            //              .Where(p => p.Category == product.Category)
            //              .Max(m => m.UnitPrice)
            //              where product.UnitPrice == mostExpensive
            //              select new
            //              {
            //                  Category = product.Category,
            //                  product = product
            //              };
            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.Category}: ${result.product.UnitPrice:F2}");
            //}

            #endregion

            #region 13.Get the products with the most expensive price in each category.
            //var results = from product in ProductList
            //              let res = ProductList
            //              .Where(p => p.Category == product.Category)
            //              .Max(p => p.UnitPrice)
            //              where product.UnitPrice == res
            //              select new
            //              {
            //                  Category = product.Category,
            //                  product = product
            //              };

            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result}");
            //}

            #endregion

            #region 14.Get the average price of each category's products.
            //var result = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    AveragePrice = g.Average(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //} 


            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1.Find the unique Category names from Product List
            //var uniqueCategoryNames = ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in uniqueCategoryNames)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 2.Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0])
            //             .Union(CustomerList.Select(c => c.CustomerName[0])).Distinct();

            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region 3.Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0])
            //             .Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region 4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(p => p.ProductName[0])
            //            .Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region 5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList
            //    .Select(p => p.ProductName.Length >= 3 ? p.ProductName.Skip(p.ProductName.Length - 3) : p.ProductName)
            //    .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Skip(c.CustomerName.Length - 3) : c.CustomerName))
            //    .Select(seq => new string(seq.ToArray()) ).ToList();
            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1.Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(c => c.Address == "Washington")       
            //             .SelectMany(c => c.Orders)
            //             .Take(3).ToList();

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region 2.Get all but the first 2 orders from customers in Washington.
            var result = CustomerList.Where(c => c.Address == "Washington")
                         .SelectMany(c => c.Orders)
                         .Skip(2).ToList();

            foreach (var order in result)
            {
                Console.WriteLine(order);
            }
            #endregion

            #endregion
        }
    }
}
