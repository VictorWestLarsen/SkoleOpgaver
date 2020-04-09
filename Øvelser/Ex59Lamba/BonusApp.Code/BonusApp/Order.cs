using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        private List<Product> _products = new List<Product>();

        public BonusProvider Bonus { get; set; }

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }
        public double GetValueOfProducts()
        {

            return  _products.Sum(product => product.Value);

        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            return new List<Product>(_products.OrderBy(product => product.AvailableTo));
        }

        public double GetValueOfProducts(DateTime date)
        {
            var products = from p in _products
                                    where p.AvailableFrom <= date && p.AvailableTo >= date
                                    select p.Value;
            return _products.Sum(product =>
            {
                if (product.AvailableFrom <= date && date <= product.AvailableTo)
                {
                    return product.Value;
                }
                return 0;
            });
        }


        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(Func<double, double> bonusDelegate)
        {
            return bonusDelegate(GetValueOfProducts());
        }

        public double GetBonus(DateTime date, Func<double, double> bonusDel)
        {
            return bonusDel(GetValueOfProducts(date));
        }
        

        
        public double GetTotalPrice() 
        {
            return GetValueOfProducts()-GetBonus();
        }
        public double GetTotalPrice(Func<double,double> totalPriceDelegate)
        {
            return GetValueOfProducts() - totalPriceDelegate(GetValueOfProducts());

        }
        public double GetTotalPrice(DateTime date, Func<double, double> delTotalprice)
        {
            return GetValueOfProducts(date) - GetBonus(date, delTotalprice);
        }

    }
}
