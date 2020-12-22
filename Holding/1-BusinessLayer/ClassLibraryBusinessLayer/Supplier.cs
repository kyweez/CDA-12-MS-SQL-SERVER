using ClassLibraryInterfaceBusinessDatabase;
using ClassLibrarySQLServer.Supplier;

namespace ClassLibraryBusinessLayer
{
    public class Supplier
    {
        #region ############### FIELDS & PROPERTIES ###############
        public ISupplierCRUD Crud
        {
            get; private set;
        }

        public string SqlConectionString
        {
            get; private set;
        }

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
        public Supplier(string _sqlConnectionString, int _id, string _name, string _address, string _zipCode, string _city, string _contactName, byte _satisfaction)
        {
            SqlConectionString = _sqlConnectionString;
            Crud = new SupplierSQL(SqlConectionString);
            Id = _id;
            Name = _name;
            Address = _address;
            ZipCode = _zipCode;
            City = _city;
            ContactName = _contactName;
            Satisfaction = _satisfaction;
        }

        public Supplier(string _sqlConnectionString, StructSupplier _sup)
        {
            SqlConectionString = _sqlConnectionString;
            Crud = new SupplierSQL(SqlConectionString);
            Id = _sup.Id;
            Name = _sup.Name;
            Address = _sup.Address;
            ZipCode = _sup.ZipCode;
            City = _sup.City;
            ContactName = _sup.ContactName;
            Satisfaction = _sup.Satisfaction;
        }

        public Supplier(string _sqlConnectionString, int _id)
        {
            SqlConectionString = _sqlConnectionString;
            Crud = new SupplierSQL(SqlConectionString);
            StructSupplier structSupplier = Crud.ReadSupplier(_id);
            Id = structSupplier.Id;
            Name = structSupplier.Name;
            Address = structSupplier.Address;
            ZipCode = structSupplier.ZipCode;
            City = structSupplier.City;
            ContactName = structSupplier.ContactName;
            Satisfaction = structSupplier.Satisfaction;
        }
        #endregion

        #region ############### METHODS ###############
        public bool Save()
        {
            if (Id == 0)
            {
                Id = Crud.CreateSupplier(GetStruct());
                return true;
            }
            else
                return Crud.UpdateSupplier(GetStruct());
        }

        private StructSupplier GetStruct()
        {
            return new StructSupplier(Id, Name, Address, ZipCode, City, ContactName, Satisfaction);
        }

        public static Supplier Load(string _sqlConnectionString, int _id)
        {
            return new Supplier(_sqlConnectionString, _id);
        }

        public bool Delete()
        {
            return Crud.DeleteSupplier(GetStruct());
        }
        #endregion
    }
}