namespace APPPInCSharp_DecoratorPattern
{
    public class AuthrizeProductDao : IProductDao
    {
        public AuthrizeProductDao(IProductDao productDao, IProductAuthorizationService productAuthorizationService)
        {
            this.productDao = productDao;
            this.productAuthorizationService = productAuthorizationService;
        }

        public string Message { get; private set; }

        private IProductDao productDao { get; }

        private IProductAuthorizationService productAuthorizationService { get; }

        public void Create(Product product)
        {
            var isValid = productAuthorizationService.Check();
            if (isValid)
            {
                productDao.Create(product);
                Message = productDao.Message;
            }
            else
            {
                Message = "權限不符，新增失敗";
            }
        }

        public void Delete(string id)
        {
            var isValid = productAuthorizationService.Check();
            if (isValid)
            {
                productDao.Delete(id);
                Message = productDao.Message;
            }
            else
            {
                Message = "權限不符，刪除失敗";
            }
        }

        public Product Query(string id)
        {
            var product = productDao.Query(id);
            return product;
        }
    }
}