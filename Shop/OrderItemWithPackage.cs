using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public override decimal GetValue()
        {
            //(quantity * product unit price + quantity *  package unit price)
            return base.GetValue() + quantity * unitPrice;
        }

        public override string? ToString()
        {
            return $"{name}, price: {price} PLN, package: {packageName}, unit price; {unitPrice}, {quantity} szt, value: {GetValue()} PLN";
        }
    }

}
