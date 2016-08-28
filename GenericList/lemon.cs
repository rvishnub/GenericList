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
        public Lemon[] sprites;
        public Lemon lemon;

        public Lemon(decimal priceLemon)
        {
            this.priceLemon = GetPriceLemon();
        }

        public Lemon[] MakeLemonArray()
        {
            Lemon[] array = new Lemon[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = new Lemon(this.priceLemon);
            }
            return array;
        }

        public void GetArray()
        {
            Lemon[] sprites = MakeLemonArray();
        }

        public void MakeListOfLemons()
        {
            List<Lemon> lemons = new List<Lemon>() { };
            List<decimal> LemonPrices = new List<decimal>() { };
            for (int i = 0; i < 10; i++)
            {
                Lemon lemon = new Lemon(priceLemon);
                lemons.Add(lemon);
                LemonPrices.Add(priceLemon);
            }
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
