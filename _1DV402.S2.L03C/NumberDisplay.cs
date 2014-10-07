using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S2.L03C.Properties;

namespace _1DV402.S2.L03C
{
    class NumberDisplay
    {
        private int _maxNumber;
        private int _number;

        public int MaxNumber
        {
            //Publik egenskap, som kapslar in det privata fältet _maxNumber. set-metoden måste validera att värdet som ska tilldelas _maxNumber är större än 0. Är värdet inte det ska ett undantag av typen ArgumentException kastas.
            private set;
            get { 
                throw new NotImplementedException(); 
            }
        }

        public int Number
        {
            //Publik egenskap, som kapslar in det privata fältet _number. set-metoden måste validera att värdet som ska tilldelas _number är i det slutna intervallet mellan 0 och maxvärdet. Är värdet inte i intervallet ska ett undantag av typen ArgumentException kastas.
            private set;
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool Equals(object obj) {
            //Överskuggar metoden Equals() i basklassen Object och returnerar ett värde som anger om den anropande instansen är lika med ett angivet objekt beträffande fälten _maxNumber och _number.
            throw new NotImplementedException();
        }

        public override void GetHashCode()
        {
            //Överskuggar metoden GetHashCode() i basklassen Object och returnerar ett heltal av typen int som beskriver det anropande objektet. Lämpligen returnerar metoden hashkoden för t.ex. textbeskrivningen av fälten.
            throw new NotImplementedException();
        }

        public void Increment()
        {
            //Publik metod som anropas för att få NumberDisplay-objektet att öka numret med 1. Då värdet fältet _number har ska passera värdet fältet _maxNumber har ska fältet _number tilldelas värdet 0. Inga utskrifter till konsolfönstret får göras av metoden.
            throw new NotImplementedException();
        }

        public NumberDisplay(int maxNumber)
        {
            //Konstruktorn NumberDisplay(int maxNumber) ska se till att fälten initieras så de refererar till NumberDisplay-obejkt men ingen tilldelning får ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför anropa den konstruktor i klassen som har två parametrar.
            throw new NotImplementedException();
        }

        public NumberDisplay(int maxNumber, int number)
        {
            //Med konstruktorn NumberDisplay(int maxNumber, int number) ska ett objekt initieras så att objektets fält tilldelas värdena parametrarna har. Detta är den enda av konstruktorerna som får innehålla kod som tilldelar fält i klassen värden.
            throw new NotImplementedException();
        }

        public string ToString(){
            //Den publika metoden ToString() har som uppgift att returnera en sträng representerande värdet av en instans av klassen NumberDisplay. Strängen ska innehålla numret, utan att nummer mindre än tio inleds med 0. Inga utskrifter till konsolfönstret får göras av metoden
            throw new NotImplementedException();
        }

        public string ToString(string format)
        {
            //Den publika metoden ToString(string format) har som uppgift att returnera en sträng representerande värdet av en instans av klassen NumberDisplay. Formatsträngen ska bestämma om nummer mindre än tio ska inledas med 0.
            //Är formatsträngen ”0” eller ”G” ska numret inte inledas med 0. Är formatsträngen ”00” ska numret inleda med 0 om numret är mindre än tio. Alla övriga värden på formatsträngen ska leda till att ett undantag av typen FormatException kastas.
            throw new NotImplementedException();
        }

        public static bool operator ==(NumberDisplay a, NumberDisplay b)
        {

            throw new NotImplementedException();
        }

        public static bool operator !=(NumberDisplay a, NumberDisplay b)
        {

            throw new NotImplementedException();
        }
    }
}
