using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S2.L02C.Properties;

namespace _1DV402.S2.L02C
{
    class AlarmClock
    {
        private ClockDisplay[] _alarmTimes;
        private ClockDisplay _time;

        //Omkapslar _alarmTimes
        public string[] AlarmTimes { 
            get 
            {
                int alarms = _alarmTimes.Length;

                string[] alarmTimes = new string[alarms];

                for (int i = 0; i < alarms; i++)
                {
                    alarmTimes[i] = _alarmTimes[i].ToString();
                }

                return alarmTimes;
            }

            set {
                int alarms = value.Length;

                _alarmTimes = new ClockDisplay[alarms];

                for (int i = 0; i < alarms; i++)
                {
                    _alarmTimes[i] = new ClockDisplay(value[i]);
                }                
            } 
        }
        
        //Omkaplsar _time
        public string Time {
            get
            {
                return _time.ToString();
            }
            set 
            {
                _time = new ClockDisplay(value);
            } 
        }

        //Construct #1
        public AlarmClock()
            : this (0, 0){ 
        }

        //Construct #2
        public AlarmClock(int hour, int minute)
            : this (hour, minute, hour, minute)
        {
        }

        //Construct #3
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _alarmTimes = new ClockDisplay[1] {new ClockDisplay(alarmHour, alarmMinute)};
            _time = new ClockDisplay(hour, minute);
        }

        //Construct #4
        public AlarmClock(string time, params string[] alarmTimes)
        {
            AlarmTimes = alarmTimes;
            _time = new ClockDisplay(time);
        }

        //Undersöker om hashkoden överensstämmer
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            AlarmClock ac = obj as AlarmClock;

            if (ac != null && ac.GetHashCode() == this.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Hämtar hashkoden för tid + alarmtider
        public override int GetHashCode() {
            return ToString().GetHashCode();
        }

        public static bool operator !=(AlarmClock a, AlarmClock b){
            if (ReferenceEquals(a, null))
            {
                return !(ReferenceEquals(b, null));
            }
            return !a.Equals(b);
        }

        public static bool operator ==(AlarmClock a, AlarmClock b)
        {

            if (ReferenceEquals(a, null))
            {
                return ReferenceEquals(b, null);
            }
            return a.Equals(b);
        }

        //Ökar klockans värde med 1 minut, returnerar true om alarm går av
        public bool TickTock() {

            _time.Increment();

            for (int i = 0; i < AlarmTimes.Length; i++)
            {
                if (Time == AlarmTimes[i])
                {
                    return true;
                }
            }

            return false;
        }

        //Sträng med tid + alarmtider
        public override string ToString()
        {
            string output = Time;
            for (int i = 0; i < AlarmTimes.Length; i++)
            {
                output += String.Format(" ({0})", AlarmTimes[i]);

            }

            return output;
        }

    }
}
