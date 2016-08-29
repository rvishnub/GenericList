using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Lemon : IComparable<Lemon>
    {

        public decimal priceLemon;
        public Lemon lemon;
        public string label;

        public Lemon(decimal priceLemon)
        {
            this.priceLemon = GetPriceLemon();
            this.label = GetCompareLemonsByPrice();
        }

        public decimal GetRandomNumber()
        {
            Random random = new Random();
            decimal i = random.Next(0, 20);
            return i;
        }

        public decimal GetPriceLemon()
        {
            decimal i = GetRandomNumber();
            return i;
        }

        public void SetPriceLemon()
        {
            priceLemon = GetPriceLemon();

        }

        public int CompareTo(Lemon that)
        {
            return this.priceLemon.CompareTo(that.priceLemon);
        }

        public string GetCompareLemonsByPrice()
        {
            if (priceLemon > 15) label = "expensive";
            else if (priceLemon > 10 & priceLemon<15) label = "pricey";
            else if (priceLemon > 5 & priceLemon<10) label = "reasonable";
            else label = "bargain";
            return label;
        }

        public void SetCompareLemonsByPrice()
        {
            label = GetCompareLemonsByPrice();
        }

        public int CompareLemonsByLabel(Lemon lemon1, Lemon lemon2)
        {
            return lemon1.label.CompareTo(lemon2.label);
        }
        
    }
}
