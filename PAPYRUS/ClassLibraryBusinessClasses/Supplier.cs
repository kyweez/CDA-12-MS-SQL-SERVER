using ClassLibraryPersistence.SupplierPersistence;

namespace ClassLibraryBusinessClasses
{
    public class Supplier
    {
        #region ############### PROPERTIES ###############
        public int Id
        {
            get; private set;
        }

        public string Name
        {
            get; private set;
        }

        public string Address
        {
            get; private set;
        }

        public string ZipCode
        {
            get; private set;
        }

        public string City
        {
            get; private set;
        }

        public string ContactName
        {
            get; private set;
        }

        public byte Satisfaction
        {
            get; private set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public Supplier(StructSupplier _supplier)
        {
            Id = _supplier.Id;
            Name = _supplier.Name;
            Address = _supplier.Address;
            ZipCode = _supplier.ZipCode;
            City = _supplier.City;
            ContactName = _supplier.ContactName;
            Satisfaction = _supplier.Satisfaction;
        }
        #endregion
    }
}