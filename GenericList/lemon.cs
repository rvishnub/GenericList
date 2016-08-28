using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Lemon:IComparable<Lemon>
    {

        public decimal priceLemon;
        public Lemon lemon;

        public Lemon(decimal priceLemon)
        {
            this.priceLemon = GetPriceLemon();
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
    }
}
