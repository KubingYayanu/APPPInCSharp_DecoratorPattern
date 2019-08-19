namespace APPPInCSharp_DecoratorPattern
{
    public class ProductDao : IProductDao
    {
        public string Message { get; private set; }

        public void Create(Product product)
        {
            System.Console.WriteLine($"新增商品ID為{product.Id}, Name為{product.Name}, Supplier為{product.Supplier} 的資料");
            Message = "新增成功";
        }

        public void Delete(string id)
        {
            System.Console.WriteLine($"刪除商品ID為{id}的資料");
            Message = "刪除成功";
        }

        public Product Query(string id)
        {
            var product = new Product
            {
                Id = id,
                Name = "Kubing",
                Supplier = "ABC"
            };
            Message = "查詢成功";

            return product;
        }
    }
}