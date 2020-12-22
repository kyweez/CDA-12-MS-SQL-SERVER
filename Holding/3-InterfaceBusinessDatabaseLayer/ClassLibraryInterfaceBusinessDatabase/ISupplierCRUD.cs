namespace ClassLibraryInterfaceBusinessDatabase
{
    public interface ISupplierCRUD
    {
        int CreateSupplier(StructSupplier _supplier);

        StructSupplier ReadSupplier(int _idSupplier);

        bool UpdateSupplier(StructSupplier _supplier);

        bool DeleteSupplier(StructSupplier _supplier);
    }
}