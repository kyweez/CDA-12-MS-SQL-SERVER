namespace ClassLibraryPersistence
{
    public interface IProductPersistence
    {
        void CreateOne(StructProduct singleProductToCreate);
        StructProduct ReadOne();
        void UpdateOne(StructProduct productToUpdate, StructProduct newSingleProduct);
        void DeleteOne(StructProduct productToDelete);

        //void Create(List<StructProduct> productsToCreate);
        //List<StructProduct> Read();
        //void Update(List<StructProduct> productsToUpdate, List<StructProduct> newProducts);
        //void Delete(List<StructProduct> productsToDelete);
    }
}