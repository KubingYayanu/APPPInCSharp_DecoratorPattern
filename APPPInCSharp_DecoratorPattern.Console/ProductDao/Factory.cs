namespace APPPInCSharp_DecoratorPattern
{
    public class Factory
    {
        internal static Product GetProduct()
        {
            if (!Context.IsTestEnvironment())
            {
                var productDao = new ProductDao();

                var logger = new Logger();
                var logDao = new LogProductDao(productDao, logger);

                var auth = new ProductAuthorizationService();
                var authDao = new AuthrizeProductDao(logDao, auth);

                var result = new ProductService(authDao);
                return result.Product;
            }
            else
            {
                var result = new Product();
                return result;
            }
        }
    }

    internal class Context
    {
        public static bool IsTestEnvironment()
        {
            return true;
        }
    }
}