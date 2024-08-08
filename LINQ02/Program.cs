using static LINQ02.ListGenerators;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            #region 1.Get first Product out of Stock 
            var Result = ProductList.FirstOrDefault(p=> p.UnitsInStock == 0);
            Console.WriteLine(Result);
            #endregion

            #endregion
        }
    }
}
