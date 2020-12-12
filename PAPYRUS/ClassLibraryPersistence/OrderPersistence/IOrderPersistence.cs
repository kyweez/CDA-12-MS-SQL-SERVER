namespace ClassLibraryPersistence.OrderPersistence
{
    public interface IOrderPersistence
    {
        void CreateOne(StructOrder singleProductToCreate);

        StructOrder ReadOne();

        void UpdateOne(StructOrder productToUpdate, StructOrder newSingleProduct);

        void DeleteOne(StructOrder productToDelete);

        //void Create(List<StructProduct> productsToCreate);
        //List<StructProduct> Read();
        //void Update(List<StructProduct> productsToUpdate, List<StructProduct> newProducts);
        //void Delete(List<StructProduct> productsToDelete);
    }
}