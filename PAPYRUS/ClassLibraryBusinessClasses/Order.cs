using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessClasses
{
    public class Order
    {
        #region ############### PROPERTIES ###############
        public int Id
        {
            get; private set;
        }

        public DateTime OrderDate
        {
            get; private set;
        }

        public string Comments
        {
            get; private set;
        }
        #endregion
    }
}
