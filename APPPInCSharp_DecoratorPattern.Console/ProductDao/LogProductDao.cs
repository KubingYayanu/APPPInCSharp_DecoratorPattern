namespace APPPInCSharp_DecoratorPattern
{
    public class LogProductDao : IProductDao
    {
        public LogProductDao(IProductDao productDao, ILog logger)
        {
            this.productDao = productDao;
            this.logger = this.logger;
        }

        public string Message => productDao.Message;

        private IProductDao productDao { get; }

        private ILog logger { get; }

        public void Create(Product product)
        {
            productDao.Create(product);
            logger.Write(productDao.Message);
        }

        public void Delete(string id)
        {
            productDao.Delete(id);
            logger.Write(productDao.Message);
        }

        public Product Query(string id)
        {
            var product = productDao.Query(id);
            return product;
        }
    }
}