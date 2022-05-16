using System;

namespace CityList
{
    class CityNameList
    {
        private List<string> Cities = new List<string>();
        private string cityInput;
        private int listSize;

        public CityNameList()
        {
            this.cityInput = "";
            this.listSize = 0;
        }

        public int setDb()
        {
            Console.WriteLine("Add meg hány városnevet akarsz eltárolni");
            listSize = int.Parse(Console.ReadLine());
            return listSize;
        }

        public void setNevek(int listSize)
        {
            Console.WriteLine("Add meg a neveket");
            
            while(cityInput != "")
            {
                if ((listSize == 0) || (listSize.ToString() == "")) {
                    break;
                }

                cityInput = Console.ReadLine();
                Cities.Add(cityInput);
            }
                
        }

        public void getNevek()
        {
            Console.WriteLine("\nA letárolt nevek a következők:");

            for (int i = 0; i < listSize; i++)
            {
                Console.Write("{0}, ", Cities[i]);
            }
        }

        public bool getVan()
        {
            bool nameExists = false;
            string nameCheck;
            Console.WriteLine("\nAdd meg melyik várost akarod ellenőrízni");
            nameCheck = Console.ReadLine();

            for (int i = 0; i < listSize; i++)
            {
                if (nameCheck == Cities[i])
                {
                    Console.WriteLine("A megadott név szerepel a listában");
                    nameExists = true;
                    break;
                }
            }

            if (!nameExists)
            {
                Console.WriteLine("A név NEM szerepel a listában");
            }

            return nameExists;
        }

        public void delNev()
        {
            bool nameExists = false;
            string nameCheck;
            Console.WriteLine("\nAdd meg melyik várost akarod hozzáadni/elvenni");
            nameCheck = Console.ReadLine();

            for (int i = 0; i < listSize; i++)
            {
                if (nameCheck == Cities[i])
                {
                    Console.WriteLine("A megadott név törlésre került a listából");

                    nameExists = true;
                    break;
                }
            }

            if (!nameExists)
            {
                Console.WriteLine("A név NEM szerepel a listában");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
        }
    }
}
