using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments_For_Sale
{
    class Appartment
    {
        public int AppartmentNumber { get; private set; }
        public double Area { get; private set; }
        public int RoomNumber { get; private set; }
        public int Price { get; private set; }
        public string PhoneNumber { get; private set; }
        public Appartment(int appartmentNumber, double area, int roomNumber, int price, string phoneNumber)
        {
            this.AppartmentNumber = appartmentNumber;
            this.Area = area;
            this.RoomNumber = roomNumber;
            this.Price = price;
            this.PhoneNumber = phoneNumber;
        }

        public int ReturnFloor(int AppartmentNumber)
        {
            int Floor = 0;
            int k = (AppartmentNumber % 27);
            if(AppartmentNumber % 3 == 0)
            {
                Floor = AppartmentNumber / 3;
            }
            else
            {
                k = k / 3;
                Floor = ++k;
            }
            while(Floor > 9)
            {
                Floor-=9;
            }
            return Floor;
        }

        public override bool Equals(object obj)
        {
            return obj is Appartment appartment &&
                   AppartmentNumber == appartment.AppartmentNumber;
        }

        public override int GetHashCode()
        {
            return -2106159292 + AppartmentNumber.GetHashCode();
        }
    }
}
