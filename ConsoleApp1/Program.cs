using System;

namespace ConsoleApp1
{
    class Program
    {
        public void Izris(int[] array)
        {
            Console.WriteLine("");
            for(int i=1; i<array.Length; i++)
            { 
                Console.Write(array[i] + " ");
                if(i%3==0)
                    Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        public void Vnesi(int[] array)
        {
            while (true)
            {
                int izbira = Int32.Parse(Console.ReadLine());
                if (array[izbira] == 0)
                {
                    array[izbira] = 1;
                    break;
                }
                Console.WriteLine("Izbrali ste ne prazno polje\nProsim izberite prazno polje:");
            }
            
            

        }
        public void RandomPoteza(int[] array)
        {
            while (true)
            {
                Random rnd = new Random();
                int num = rnd.Next(9) + 1;
                if (array[num] == 0)
                {
                    array[num] = 2;
                    return;
                }  
            }
        }
        public bool KonecIgre(int[] array)
        {
            if(array[1] != 0)
            {
                if (array[1] == array[2] && array[1] == array[3])
                    return true;
                if (array[1] == array[4] && array[1] == array[7])
                    return true;
                if (array[1] == array[5] && array[1] == array[9])
                    return true;
            }
            if(array[5] != 0)
            {
                if (array[5] == array[2] && array[5] == array[8])
                    return true;
                if (array[5] == array[3] && array[5] == array[7])
                    return true;
                if (array[5] == array[4] && array[5] == array[6])
                    return true;
            }
            if(array[9] != 0)
            {
                if (array[9] == array[8] && array[9] == array[7])
                    return true;
                if (array[9] == array[6] && array[9] == array[3])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] IgralnoPolje = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int counter = 0;
            pr.Izris(IgralnoPolje);
            while (true)
            {
                pr.Vnesi(IgralnoPolje);
                counter++;
                pr.Izris(IgralnoPolje);
                if (pr.KonecIgre(IgralnoPolje))
                {
                    Console.WriteLine("ZMAGAL SI!");
                    break;
                }
                if (counter == 5)
                {
                    Console.WriteLine("Izenačena igra.");
                    break;
                }
                pr.RandomPoteza(IgralnoPolje);
                pr.Izris(IgralnoPolje);
                if (pr.KonecIgre(IgralnoPolje))
                {
                    Console.WriteLine("Zgubil si:(");
                    break;
                }
            }
           

        }
    }
}
