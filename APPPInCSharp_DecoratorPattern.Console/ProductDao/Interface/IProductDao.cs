namespace APPPInCSharp_DecoratorPattern
{
    public interface IProductDao
    {
        string Message { get; }

        void Create(Product product);

        void Delete(string id);

        Product Query(string id);
    }
}