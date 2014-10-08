using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S2.L02C.Properties;

namespace _1DV402.S2.L02C
{
    class NumberDisplay
    {
        private int _maxNumber;
        private int _number;

        //Kapslar in _maxNumber
        public int MaxNumber
        {
            set {
                if (value < 1)
                {
                    throw new ArgumentException(value.ToString());
                }
                _maxNumber = value;
            }
            get {
                return _maxNumber; 
            }
        }

        //Kapslar in _number
        public int Number
        {
            //Publik egenskap, som kapslar in det privata fältet _number. set-metoden måste validera att värdet som ska tilldelas _number är i det slutna intervallet mellan 0 och maxvärdet. Är värdet inte i intervallet ska ett undantag av typen ArgumentException kastas.
            set
            {
                if (value < 0 || value > MaxNumber)
                {
                    throw new ArgumentException(value.ToString());
                }
                _number = value;
            }
            get
            {
                return _number;
            }
        }

        //Undersöker om hashkoden överensstämmer
        public override bool Equals(object obj) {

            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            NumberDisplay nd = obj as NumberDisplay;

            if (nd != null && nd.GetHashCode() == this.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Returnerar hashkoden för textbeskrivningen av Number+MaxNumber.
        public override int GetHashCode()
        {
            int hashCode = MaxNumber.ToString().GetHashCode();
            hashCode ^= Number.ToString().GetHashCode();

            return hashCode;
        }

        //Ökar värdet av Number, slår om om det är MaxNumber
        public void Increment()
        {
            if (Number == MaxNumber)
            {
                Number = 0;
            }
            else
            {
                Number++;
            }
        }

        //Initierar värden, skickas till andra constructor
        public NumberDisplay(int maxNumber)
            :   this(maxNumber, 0){
        }

        //Initierar värden
        public NumberDisplay(int maxNumber, int number)
        {
            MaxNumber = maxNumber;
            Number = number;
        }

        //Returnerar Number utan inledande 0
        public override string ToString(){
            return String.Format("{0}", Number);
        }

        //Kollar om Number ska formatteras med inledande 0
        public string ToString(string format)
        {
            if (format == "00")
            {
                if (Number < 10)
                {
                    return String.Format("{0}{1}", 0, Number);
                }
                else
                {
                    return ToString();
                }
                
            }
            else if(format == "0" || format == "G")
            {
                return ToString();
            }
            else
            {
                throw new FormatException(String.Format("Format parameter \"{0}\" not valid", format));
            }
        }

        public static bool operator ==(NumberDisplay a, NumberDisplay b)
        {

            if (ReferenceEquals(a, null))
            {
                return ReferenceEquals(b, null);
            }
            return a.Equals(b);

        }

        public static bool operator !=(NumberDisplay a, NumberDisplay b)
        {

            if (ReferenceEquals(a, null))
            {
                return !(ReferenceEquals(b, null));
            }
            return !a.Equals(b);

        }
    }
}
