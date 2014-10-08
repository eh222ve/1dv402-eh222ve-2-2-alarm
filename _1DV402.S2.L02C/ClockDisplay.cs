using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _1DV402.S2.L02C.Properties;

namespace _1DV402.S2.L02C
{
    class ClockDisplay
    {
        private NumberDisplay _hourDisplay = new NumberDisplay(23);
        private NumberDisplay _minuteDisplay = new NumberDisplay(59);

        //Delar upp HH:mm och tilldelar värden till fälten
        public string Time
        {
            get {
                return String.Format("{0}:{1}", _hourDisplay.ToString("0"), _minuteDisplay.ToString("00"));
            }
            set {
                Regex rx = new Regex("^(([0-1]?[0-9])|([2][0-3])):([0-5][0-9])$");
                if (rx.IsMatch(value))
                {
                    string[] values = value.Split(':');
                    _hourDisplay.Number = Int32.Parse(values[0]);
                    _minuteDisplay.Number = Int32.Parse(values[1]);
                }
                else
                {
                    throw new FormatException(String.Format(Strings.Format_Exception_Time, value));
                }
            }
        }

        //Construct #1
        public ClockDisplay() : this(0, 0){
        }

        //Construct #2
        public ClockDisplay(int hour, int minute)
        {
            _hourDisplay.Number = hour;
            _minuteDisplay.Number = minute;
        }

        //Construct #3
        public ClockDisplay(string time)
        {
            Time = time;
        }

        //Undersöker om hashkoden överensstämmer
        public override bool Equals(object obj) {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            NumberDisplay cd = obj as NumberDisplay;

            if (cd != null && cd.GetHashCode() == this.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Hämtar hashkoden för HH:mm
        public override int GetHashCode(){
            return ToString().GetHashCode();
        }


        public static bool operator ==(ClockDisplay a, ClockDisplay b)
        {

            if (ReferenceEquals(a, null))
            {
                return ReferenceEquals(b, null);
            }
            return a.Equals(b);
        }

        public static bool operator !=(ClockDisplay a, ClockDisplay b)
        {

            if (ReferenceEquals(a, null))
            {
                return !(ReferenceEquals(b, null));
            }
            return !a.Equals(b);
        }

        //Ökar klockans värde med 1 minut
        public void Increment() {
            _minuteDisplay.Increment();

            if (_minuteDisplay.Number == 0)
            {
                _hourDisplay.Increment();
            }
        }

        //Returnerar HH:mm
        public override string ToString(){
            return Time;
        }
    }
}
