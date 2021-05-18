using System;
using System.Collections.Generic;
using System.Text;

namespace Prog121Annons
{
    public class Annons
    {

        public string Rubrik { get; set; }
        public decimal Pris { get; set; }
        public string Username { get; set; }
        public DateTime SlutDatumOchTid{ get; set; }

        public bool SlutarSnart()
        {
            var omTolvTimmar = DateTime.Now;
            omTolvTimmar = omTolvTimmar.AddHours(12);
            if (SlutDatumOchTid > omTolvTimmar)
                return false;
            return true;
            //SLutDatumTid < Datetime.now + 12 timmar
        }

        public string GetWeekday()
        {
            return SlutDatumOchTid.DayOfWeek.ToString();
        }

        public DateTime Created { get; set; }

        public string Description { get; set; }

    }
}
