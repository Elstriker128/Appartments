using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Apartments_For_Sale
{
     class InOutUtils
    {
        public static AppartmentsRegister ReadAppartments(string filename)
        {
            AppartmentsRegister Appart = new AppartmentsRegister();
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            foreach(string line in lines)
            {
                string[] Values = line.Split(';');
                int appartNum = int.Parse(Values[0]);
                double area = double.Parse(Values[1]);
                int roomNum = int.Parse(Values[2]);
                int price = int.Parse(Values[3]);
                string phoneNum = Values[4];

                Appartment all = new Appartment(appartNum, area, roomNum,price,phoneNum);
                if(!Appart.Contains(all))
                {
                    Appart.Add(all);
                }
            }
            return Appart;
        }
        public static void OutputChangingRequirements(out int RequiredRooms, out int RequiredFloorFirst, out int RequiredFloorSec, out int RequiredPrice)
        {
            Console.WriteLine("Input required room count:");
            RequiredRooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Input required floor (first period):");
            RequiredFloorFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Input required floor (second period):");
            RequiredFloorSec = int.Parse(Console.ReadLine());
            Console.WriteLine("Input required price:");
            RequiredPrice = int.Parse(Console.ReadLine());
        }
        public static void PrintAppartments(AppartmentsRegister AllAppartments)
        {
            for (int i = 0; i < AllAppartments.AppartCount(); i++)
            {
                if(AllAppartments.AppartCount()!=0)
                {
                    Appartment printed = AllAppartments.ReturnAppartmentAccordingToIndex(i);
                    Console.WriteLine("| {0, 3:d} | {1, 5:f} | {2} | {3} | {4,-8} | {5} |", printed.AppartmentNumber, printed.Area,
                        printed.RoomNumber, printed.Price, printed.PhoneNumber, printed.ReturnFloor(printed.AppartmentNumber));
                }
                else
                {
                    Console.WriteLine("No possible appartment options!");
                }
            }
        }

    }
}
