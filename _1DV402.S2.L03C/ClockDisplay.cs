using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S2.L03C.Properties;

namespace _1DV402.S2.L03C
{
    class ClockDisplay
    {
        private NumberDisplay _hourDisplay;
        private NumberDisplay _minuteDisplay;

        public string Time
        {
            //Publik egenskap av typen string, som kapslar in de privata fälten _hourDisplay och _minuteDisplay. Strängens format ska vara HH:mm, d.v.s. timmar och minuter åtskilda av ett kolon.
            //set-metoden ska kasta ett undantag av typen FormatException om strängen som tilldelas egenskapen inte har rätt format. Använd det reguljära uttrycket "^(([0-1]?[0-9])|([2][0-3])):([0-5][0-9])$" för att validera tiden. När väl tiden är validerad delas den enkelt upp i timmar och minuter med hjälp av metoden String.Split().
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }
        public ClockDisplay() {
            //Standardkonstruktorn ClockDisplay() ska se till att fälten initieras så de refererar till NumberDisplay-objekt men ingen tilldelning får ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför anropa den konstruktor i klassen som har två parametrar.
        }

        public ClockDisplay(int hour, int minute)
        {
            //Med konstruktorn ClockDisplay(int hour, int minute) ska ett objekt initieras så att objektet ställs på den tid som parametrarna anger. Detta är den ena av konstruktorerna som får innehålla kod som leder till att fält i klassen tilldelas värden.
        }

        public ClockDisplay(string time)
        {
            //Med konstruktorn ClockDisplay(string time) ska ett objekt initieras så att objektet ställs på den tid som parametern, på formatet HH:mm, anger. Detta är den ena av konstruktorerna som får innehålla kod som leder till att fält i klassen tilldelas värden.
        }

        public override bool Equals() {
            //Överskuggar metoden Equals() i basklassen Object och returnerar ett värde som anger om den anropande instansen är lika med ett angivet objekt beträffande fälten _hourDisplay och _minuteDisplay.
            throw new NotImplementedException();
        }

        public override int GetHashCode(){
            //Överskuggar metoden GetHashCode() i basklassen Object och returnerar ett heltal av typen int som beskriver det anropande objektet. Lämpligen returnerar metoden hashkoden för textbeskrivningen, d.v.s. det som metoden ToString() returnerar
            throw new NotImplementedException();
        }

        public static bool operator ==(ClockDisplay a, ClockDisplay b)
        {
            
            throw new NotImplementedException();
        }

        public static bool operator !=(ClockDisplay a, ClockDisplay b)
        {
            
            throw new NotImplementedException();
        }

        public void Increment() {
            //Publik metod som anropas för att få ClockDisplay-objektet att gå en minut. Metoden ansvarar för att öka minuternas värde med 1. Då värdet för minuterna blir 0 ökas lämpligen timmarnas värde med 1. Inga utskrifter till konsolfönstret får göras av metoden.
            throw new NotImplementedException();
        }

        public string ToString(){
            //Publik metod som har som uppgift att returnera en sträng representerande värdet av en instans av klassen ClockDisplay. Strängen ska innehålla tiden på formatet HH:mm. Inga utskrifter till konsolfönstret får göras av metoden.
            throw new NotImplementedException();
        }
    }
}
