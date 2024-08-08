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
            int totalCharCount = words.Sum(word => word.Length);
            Console.WriteLine(totalCharCount);

            #endregion

            #endregion
        }
    }
}
