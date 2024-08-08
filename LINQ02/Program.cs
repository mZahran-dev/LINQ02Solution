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
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Arr.Count(a => a % 2 != 0);
            Console.WriteLine(result);
            #endregion



            #endregion
        }
    }
}
