using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EFProductDal());

foreach (var product in productManager.GetByUnitPrice(30, 90))
{
    Console.WriteLine(product.ProductName);
}