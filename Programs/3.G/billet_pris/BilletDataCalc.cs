using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billet_pris
{
    internal class BilletDataCalc
    {
        public int FraZone { get; set; }
        public int DestinationsZone { get; set; }
        public bool Pensionist { get; set; }
        public List<Destination> Destinations { get; private set; }
        

        public BilletDataCalc(bool pensionist, string FraZone, string DestinationZone)
        {
            Pensionist = pensionist;
            Zones();
            Destinations.;
        }

        public int Pris
        {
            get { return 35 + Math.Abs(FraZone - DestinationsZone) * 20 - (Pensionist ? 20 : 0); }
        }

        public DateTime DateTime
        {
            get { return DateTime.AddHours(36); }
        }

        private List<Destination> Zones()
        {
            Destinations = new List<Destination> { 
            new Destination() {Name = "HTX Håndbækvej 50", Zone = 1},
            new Destination() {Name = "GærumsPizza Distro", Zone = 1},
            new Destination() {Name = "Fr.Havn station", Zone = 2},
            new Destination() {Name = "DonnerWetterVej 4", Zone = 3},
            new Destination() {Name = "KirstenDonhammersvej 18", Zone = 4},
            new Destination() {Name = "Andebyvej 44", Zone = 5},
            new Destination() {Name = "FCM Arena", Zone = 5},
            new Destination() {Name = "GunnarGrumsvej", Zone = 6},
            new Destination() {Name = "KlipfiskArnesvej 222", Zone = 7},
            new Destination() {Name = "Tåneglsallé 13", Zone = 7},
            new Destination() {Name = "Viborg vandværk 35", Zone = 8},
            new Destination() {Name = "Esbjerg havnefront 18", Zone = 9},
            };

            return Destinations;
        }
        
    }
}
