using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistence
{
    public struct StructProduct
    {
        #region ############### CONSTRUCTOR ###############
        public StructProduct(int _id, string _label, int _realStock, int _criticalStock, int _annualOutput, string _measurementUnit, float _price)
        {
            Id = _id;
            Label = _label;
            RealStock = _realStock;
            CriticalStock = _criticalStock;
            AnnualOutput = _annualOutput;
            MeasurementUnit = _measurementUnit;
            Price = _price;
        }

        #endregion

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
        #endregion


    }
}
