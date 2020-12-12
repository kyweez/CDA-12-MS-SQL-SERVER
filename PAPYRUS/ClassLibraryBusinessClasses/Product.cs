using ClassLibraryPersistence.ProductPersistence;
using ClassLibraryPersistence.SupplierPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessClasses
{
    public class Product
    {
        #region ############### PROPERTIES ###############
        public int Id
        {
            get; private set;
        }

        public string Label
        {
            get; private set;
        }

        public int RealStock
        {
            get; private set;
        }

        public int CriticalStock
        {
            get; private set;
        }

        public int AnnualOutput
        {
            get; private set;
        }

        public string MeasurementUnit
        {
            get; private set;
        }

        public float Price
        {
            get; private set;
        }

        public Supplier SupplierInstance
        {
            get; private set;
        }
        #endregion

        #region ############### CONSTRUCTORS ###############
        public Product(StructProduct _product, Supplier _supplier)
        {
            Id = _product.Id;
            Label = _product.Label;
            RealStock = _product.RealStock;
            CriticalStock = _product.CriticalStock;
            AnnualOutput = _product.AnnualOutput;
            MeasurementUnit = _product.MeasurementUnit;
            Price = _product.Price;
            SupplierInstance = _supplier;
        }
        #endregion
    }
}
