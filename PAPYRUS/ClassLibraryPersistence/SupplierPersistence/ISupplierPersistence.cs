namespace ClassLibraryPersistence.SupplierPersistence
{
    public interface ISupplierPersistence
    {
        void CreateOne(StructSupplier singleProductToCreate);

        StructSupplier ReadOne();

        void UpdateOne(StructSupplier productToUpdate, StructSupplier newSingleProduct);

        void DeleteOne(StructSupplier productToDelete);

        //void Create(List<StructSupplier> productsToCreate);
        //List<StructSupplier> Read();
        //void Update(List<StructSupplier> productsToUpdate, List<StructSupplier> newProducts);
        //void Delete(List<StructSupplier> productsToDelete);
    }
}