namespace ClassLibraryPersistence.ProductPersistence
{
    public struct StructProduct
    {
        #region ############### CONSTRUCTOR ###############
        public StructProduct(int _id, string _label, int _realStock, int _criticalStock, int _annualOutput, string _measurementUnit, float _price, int _supplierId)
        {
            Id = _id;
            Label = _label;
            RealStock = _realStock;
            CriticalStock = _criticalStock;
            AnnualOutput = _annualOutput;
            MeasurementUnit = _measurementUnit;
            Price = _price;
            SupplierId = _supplierId;
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
        
        public int SupplierId
        {
            get; private set;
        }
        #endregion
    }
}
