namespace Zahlenraten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Number = new Random();
            int randomNumber = Number.Next(1, 100);
            bool erraten = false;
            Console.WriteLine("Schreibe eine Zahl zwischen 1 und 100");

            while (!erraten)
            {
                
                int Zahl1 = Convert.ToInt32(Console.ReadLine());
                if (Zahl1 > randomNumber)
                {
                    Console.WriteLine("Tiefer!");
                    
                }
                else if (Zahl1 < randomNumber)
                {
                    Console.WriteLine("Höher!");

                }
                else
                {
                    erraten = true;
                    Console.WriteLine("Zahl erraten!");
                    
                    
                }

                    

            } 

            
            
               


        }
    }
}