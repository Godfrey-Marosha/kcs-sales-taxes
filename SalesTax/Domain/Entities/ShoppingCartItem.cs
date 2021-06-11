using System;

namespace Domain.Entities
{
    public class ShoppingCartItem
    {
        private readonly SalesTaxCalculator _salesTaxCalculator;

        public ShoppingCartItem(SalesTaxCalculator salesTaxCalculator)
        {
            if (salesTaxCalculator == null)
            {
                throw new ArgumentException("Shopping Cart Item is invalid");
            }

            _salesTaxCalculator = salesTaxCalculator;
        }

        public decimal GetItemPrice()
        {
            return _salesTaxCalculator.GetPriceWithTaxIncluded(this);
        }
    }
}