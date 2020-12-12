using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistence.LinePersistence
{
    public struct StructLine
    {
        #region ############### CONSTRUCTOR ###############
        public StructLine(int _productQuantity, DateTime _deliveryDate, float _productPrice, string _productLabel)
        {
            ProductQuantity = _productQuantity;
            DeliveryDate = _deliveryDate;
            ProductPrice = _productPrice;
            ProductLabel = _productLabel;
        }
        #endregion

        #region ############### PROPERTIES ###############
        public int ProductQuantity
        {
            get; private set;
        }

        public DateTime DeliveryDate
        {
            get; private set;
        }

        public float ProductPrice
        {
            get; private set;
        }

        public string ProductLabel
        {
            get; private set;
        }
        #endregion
    }
}
