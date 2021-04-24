using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri_Zigulev_OOADP_A
{
    public class Special : Packet
    {
        protected int discount;
        protected int discvalidfrom;
        public Special(string ttype , int tlength,double tprice,int tcapacity,int discount,int discvalidfrom):base(ttype,tlength,tprice,tcapacity)
        {
            if(discvalidfrom>=tcapacity)
            {
                this.discvalidfrom = tcapacity;
            }
            else
            {
                this.discvalidfrom = discvalidfrom;
            }
            //количество людей,начиная с которого действует скидка,
            //не превышает максимальное количестволюдей в группе

            //если превышает, то количество людей, начиная с которого
            //действует скидка, приравнивается максимальному количеству людей в группе
            this.discount = discount;
        }
        public int Discount
        {
            get { return discount; }
        }
        public  override double HowMuch(int i)
        {
            if (i > tcapacity)
            {
                ForWho(i);
                return -1;
            }
            else if (i < discvalidfrom || discvalidfrom == 0)
            {
                Console.WriteLine("Your price is : {0,3} .", i * tprice);
                return i * tprice;
            }
            else
            {
                Console.WriteLine("Your price with {0,2}% discount is : {1,3} ", discount, i * (tprice - (tprice * discount) / 100));
                return i* (tprice - (tprice * discount) / 100);
            }
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("\n{0,2}% discount is valid for {1,2} and above . ", discount, discvalidfrom );
        }
    }
}
