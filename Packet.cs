using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri_Zigulev_OOADP_A
{
     public class Packet
    {
        protected string ttype;
        protected int tlength;
        protected double tprice;
        protected int tcapacity;
        public string Ttype
        {
            get { return ttype; }
        }
        public int Tlength
        {
            get { return tlength; }
        }
        public double Tprice
        {
            get { return tprice; }
            set { tprice = value; }
        }
        public int Tcapacity
        {
            get { return tcapacity; }
        }
        public Packet (string ttype,int tlength,double tprice,int tcapacity)
        {
            this.ttype = ttype;
            this.tlength = tlength;
            this.tprice = tprice;
            this.tcapacity = tcapacity;
        }
        public bool ForWho(int i)
        {
            if (i <= tcapacity && i>0)
            {
                Console.WriteLine("This offer is valid for the following amount of people.");
                return true;
            }
            else
            {
                Console.WriteLine("This offer is not valid for the following amount of people!");
                return false;
            }
        }
        public virtual double HowMuch(int i)
        {
            if (i <= tcapacity && i>0)
            {
                Console.WriteLine("Price is : {0,3} .", i * tprice);
                return i * tprice;
            }
            else
            {
                ForWho(i);
                return -1;
            }
        }
        public override string ToString()
        {
            if (tlength >= 24)
            {
                return String.Format("{0,1} " +
                    "\nTravel length : {1,3} days " +
                    "\nPrice for one : {2,3}" +
                    "\nFor : {3,1}", ttype, tlength / 24, tprice, tcapacity);
            }
            else
            {
                return String.Format("{0,1} " +
                    "\nTravel length : {1,3} hours " +
                    "\nPrice for one : {2,3}" +
                    "\nFor : {3,1}", ttype, tlength, tprice, tcapacity);
            }
        }
    }      
}
