using ClassLibraryPersistence.LinePersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessClasses
{
    public class Line
    {
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

        public Product RelatedProduct
        {
            get; set;
        }

   

        #endregion

        #region ############### CONSTRUCTOR ###############
        public Line(StructLine _line)
        {
            
        }
        #endregion

    }
}
