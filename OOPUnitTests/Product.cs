using OOP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUnitTests
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }
        //NULL type -> Decimal?
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        private String _ProductName;

        public String ProductName
        {
            get {

                return _ProductName.InsertSpacess();
            }
            set { _ProductName = value; }
        }
        



        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
        public override string ToString()
        {
            return ProductName;
        }

        
    }

}
