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
            var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            Console.WriteLine(result);
            #endregion
            #endregion
        }
    }
}
