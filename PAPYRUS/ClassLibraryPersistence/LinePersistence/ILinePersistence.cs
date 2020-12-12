namespace ClassLibraryPersistence.LinePersistence
{
    public interface ILinePersistence
    {
        void CreateOne(StructLine singleProductToCreate);

        StructLine ReadOne();

        void UpdateOne(StructLine productToUpdate, StructLine newSingleProduct);

        void DeleteOne(StructLine productToDelete);

        //void Create(List<StructProduct> productsToCreate);
        //List<StructProduct> Read();
        //void Update(List<StructProduct> productsToUpdate, List<StructProduct> newProducts);
        //void Delete(List<StructProduct> productsToDelete);
    }
}
