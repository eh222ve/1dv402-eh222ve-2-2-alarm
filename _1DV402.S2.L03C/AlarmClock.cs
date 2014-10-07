using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S2.L03C.Properties;

namespace _1DV402.S2.L03C
{
    class AlarmClock
    {
        //Innehåller referens till ett ClockDisplay[]-objekt som ansvarar för alarmtiderna
        private ClockDisplay[] _alarmTimes;
        //Innehåller referens till ett ClockDisplay-objekt som ansvarar för väckarklockans aktuella tid
        private ClockDisplay _time;

        public string[] AlarmTimes { 
            //get-metoden ska ge en array innehållande alarmtider i form av strängar. Egenskapen konverterar alltså referenser till ClockDisplay-objekt till strängar. Vid ändring av en sträng i arrayen ska inte underliggande ClockDisplay-objekt ändras.
            //set-metoden ska konvertera varje alarmtid, i form av en sträng, till ett ClockDisplay-objekt.
            get; set; 
        }
        
        public string Time {
            //Publik egenskap av typen string som kapslar in fältet _time som är av typen ClockDisplay
            get; set; 
        }

        public AlarmClock() { 
            //Standardkonstruktorn AlarmClock() ska initiera fälten så att de refererar till objekt. Ingen tilldelning får ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför anropa den konstruktor i klassen som har två parametrar.
        }

        public AlarmClock(int hour, int minute)
        {
            //Med konstruktorn AlarmClock(int hour, int minute) ska ett objekt kunna initieras så att väckarklockan ställs på den tid som parametrarna för timme respektive minut anger. Ingen tilldelning får ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför anropa den konstruktor i klassen som har fyra parametrar.
            throw new NotImplementedException();
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            //Med konstruktorn AlarmClock(int hour, int minute , int alarmHour, int alarmMinute) ska ett objekt kunna initieras så att väckarklockan ställs på den tid och alarmtid som parametrarna anger. Detta är en konstruktor som får innehålla kod som leder till att fält i klassen tilldelas värden.
            throw new NotImplementedException();
        }

        public AlarmClock(string time, params string[] alarmTimes)
        {
            //Med konstruktorn AlarmClock(string time, params string[] alarmTimes) ska ett objekt kunna initieras så att väckarklockan ställs på den tid och ett godtyckligt antal, minst en dock, alarmtider som parametrarna anger. Detta är en konstruktor som får innehålla kod som leder till att fält i klassen tilldelas värden.
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            //Överskuggar metoden Equals() i basklassen Object och returnerar ett värde som anger om den anropande instansen är lika med ett angivet objekt beträffande textbeskrivningarna innehållande aktuell tid samt alarmtider.
            throw new NotImplementedException();
        }

        public override int GetHashCode() {
            //Överskuggar metoden GetHashCode() i basklassen Object och returnerar ett heltal av typen int som beskriver det anropande objektet. Lämpligen returnerar metoden hashkoden för textbeskrivningen, d.v.s. det som metoden ToString() returnerar.
            throw new NotImplementedException();
        }

        public static bool operator ==(AlarmClock a, AlarmClock b){
            //Operatorn !=
            //Avgör om två instanser av AlarmClock är olika. Enkel att implementera då metoden Equals() finns att tillgå.
            throw new NotImplementedException();
        }

        public static bool operator !=(AlarmClock a, AlarmClock b)
        {
            //Operatorn ==
            //Avgör om två instanser av AlarmClock är lika. Enkel att implementera då metoden Equals() finns att tillgå.
            throw new NotImplementedException();
        }

        public bool TickTock() {
            //Publik metod som anropas för att få klockan att gå en minut. Om den nya tiden överensstämmer med någon av alarmtiderna ska metoden returnera true, annars false. Inga utskrifter till konsolfönstret får göras av metoden.
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //Publik metod som har som uppgift att returnera en sträng representerande värdet av en instans av klassen AlarmClock. Strängen ska innehålla aktuell tid samt alarmtiderna inom parenteser. Inga utskrifter till konsolfönstret får göras av metoden.
            throw new NotImplementedException();
        }

    }
}
