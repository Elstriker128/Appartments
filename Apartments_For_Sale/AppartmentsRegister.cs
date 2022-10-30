using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments_For_Sale
{
    class AppartmentsRegister
    {
        private List<Appartment> AllAppartments;

        public AppartmentsRegister()
        {
            AllAppartments = new List<Appartment>();
        }
        public AppartmentsRegister(List<Appartment> allAppartments)
        {
            AllAppartments = new List<Appartment>();
            foreach (Appartment appart in allAppartments)
            {
                AllAppartments.Add(appart);
            }
        }
        public void Add(Appartment app)
        {
            this.AllAppartments.Add(app);
        }
        public bool Contains(Appartment app)
        {
            return this.AllAppartments.Contains(app);
        }
        public int AppartCount()
        {
            return this.AllAppartments.Count();
        }
        public Appartment ReturnAppartmentAccordingToIndex(int index)
        {
            return this.AllAppartments[index];
        }
        public AppartmentsRegister FindRequiredAppartments(ref int RequiredRooms, ref int RequiredFloorFirst, ref int RequiredFloorSec, ref int RequiredPrice)
        {
            AppartmentsRegister Filtered = new AppartmentsRegister();
            for (int i = 0; i < AllAppartments.Count(); i++)
            {
                Appartment info = this.ReturnAppartmentAccordingToIndex(i);
                if(info.RoomNumber==RequiredRooms && info.ReturnFloor(info.AppartmentNumber) >= RequiredFloorFirst 
                    && info.ReturnFloor(info.AppartmentNumber) <= RequiredFloorSec && info.Price<=RequiredPrice)
                {
                    Filtered.Add(info);
                }
            }
            return Filtered;
        }
    }
}
