namespace APPPInCSharp_DecoratorPattern
{
    public class ProductService
    {
        public ProductService(IProductDao productDao)
        {
            this.productDao = productDao;
        }

        private IProductDao productDao { get; }

        public Product Product { get; set; }

        public void Create()
        {
            var product = new Product();
            productDao.Create(product);
        }

        public void Delete()
        {
            var id = "Kubing";
            productDao.Delete(id);
        }

        public void Query()
        {
            var id = "Kubing";
            var result = productDao.Query(id);
        }
    }
}