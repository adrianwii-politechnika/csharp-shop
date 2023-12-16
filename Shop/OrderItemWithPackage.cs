using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class OrderItemWithPackage : OrderItem
    {
        private String packageName;

        private decimal unitPrice;
        public OrderItemWithPackage(string name, decimal price, int quantity, string packageName, decimal unitPrice) : base(name, price, quantity)
        {
            this.packageName = packageName;
            this.unitPrice = unitPrice;
        }
    }

}
