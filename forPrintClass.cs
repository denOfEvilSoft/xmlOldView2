using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlOldViewer
{
    class forPrintClass
    {
        public string loaction { get; private set; }
        public string name { get; private set; }
        public string institution { get; private set; }
        public string number { get; private set; }
        public string dbLocation { get; private set; }
        public string target { get; private set; }
        public string time { get; private set; }
        public string dayOfTheWeek { get; private set; }
        public double latitude { get; private set; }
        public double longtitude { get; private set; }
        public int dead { get; set; }
        public int severelyInjured { get; set; }
        public int minorInjury { get; set; }

        public string getName()
        {
            return name;
        }

        public forPrintClass(string name, string location, string institution, string number, string dbLocation, 
            string target, string time, string dayOfTheWeek, double latitude, double longtitude)
        {
            this.loaction = location;
            this.name = name;
            this.institution = institution;
            this.number = number;
            this.dbLocation = dbLocation;
            this.target = target;
            this.time = time;
            this.dayOfTheWeek = dayOfTheWeek;
            this.latitude = latitude;
            this.longtitude = longtitude;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
