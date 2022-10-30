using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Apartments_For_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RequiredRooms, RequiredFloorFirst, RequiredFloorSec, RequiredPrice;
            AppartmentsRegister register = InOutUtils.ReadAppartments(@"Appartments.csv");
            InOutUtils.PrintAppartments(register);
            Console.WriteLine();

            InOutUtils.OutputChangingRequirements(out RequiredRooms, out RequiredFloorFirst, out RequiredFloorSec,  out RequiredPrice);
            Console.WriteLine();

            Console.WriteLine("Filtered appartments:");
            InOutUtils.PrintAppartments(register.FindRequiredAppartments(ref RequiredRooms, ref RequiredFloorFirst, ref RequiredFloorSec, ref RequiredPrice));
            Console.WriteLine();
        }
    }
}
