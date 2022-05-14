using System;
using Learning.View;
using Learning.Model;

namespace Learning.Model
{
	public class SolidElement : iElement
	{
        
        private String Name { get; set; }

        private int Mass { get; set;}

        private int MeltingPoint { get; set; }

        private int BoilingPoint { get; set; }

        private bool isRadioactive { get; set; }

        private int Volatility { get; set; }

        private bool isMelted { get; set; }



        public SolidElement(int mass, int meltingPoint, int boilingPoint, bool isRadioactive, int volatility)
        {
            Mass = mass;
            MeltingPoint = meltingPoint;
            BoilingPoint = boilingPoint;
            this.isRadioactive = isRadioactive;
            Volatility = volatility;
        }

        public SolidElement()
        {

        }

        public SolidElement MakeRandomElement(FieldJournal journal)
        {
           
            Random rnd = new Random();
            int randomMass = rnd.Next(10, 300);

            // The following should check to see if an element with that atomic number already exists and returns it to the caller. I do not
            // want multiple elements in the periodic table with the same atomic mass. 
            if (journal.GetKnownElements().Count != 0)
            {
                foreach (SolidElement elem in journal.GetKnownElements())
                {
                    if (elem.Mass == randomMass)
                    {
                        return elem;
                    }

                }
            }

            int randomMeltingPoint = rnd.Next(40, 3000);
            int randomBoilingPoint = randomMeltingPoint + (randomMeltingPoint / 10);
            bool isAtomic = GetRadioactiveBool(randomMass, rnd);
            int randomVolatility = rnd.Next(1, 100);


            SolidElement newElement = new SolidElement(randomMass, randomMeltingPoint,
                randomBoilingPoint, isAtomic, randomVolatility);


            newElement.Name = UserInput.NewElementPrompt();
            journal.SetKnownElements(newElement);
            return newElement;
        }

        private bool GetRadioactiveBool(int randomMass, Random rnd)
        {
            double randomDouble = rnd.NextDouble();
            if (randomMass > 250 && randomDouble > .50)
            {
                return true;

            }
            else if(randomMass > 150 && randomDouble > .75)
            {
                return true;
            }
            else if(randomMass > 75 && randomDouble > .94)
            {
                return true;
            }

            return false;
        }
    }
}

