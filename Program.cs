using System;
using System.ComponentModel.Design;

namespace program
{

    class RestockingTool
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========    RESTOCKING TOOL    ========== \n");
            Console.WriteLine("===========================================");

            {

                //  soda full 100, soda restock 40

                //full stock
                int SodaFullStock = 100;
                int CandyFullStock = 60;
                int ChipFullStock = 40;

                // Soda starts with 100 in stock and will need a restock at 40
                //Candy starts with 60 in stock and will need a restock at 40
                //Chips starts with 40 in stock and will need a restock at 20
                //Each item should have a variable that holds its current stock value and a variable that holds the restock value
                

                //restock needed
                int sodaRestock = 100;                
                int candyRestock = 60;
                int chipRestock = 40;

                //strictly for storing user input
                int sodaOrder;
                int candyOrder;
                int chipOrder;

                int sodaRemains;
                int candyRemains;
                int chipRemains;

                SodaFullStock = sodaRestock;
                CandyFullStock = candyRestock;
                ChipFullStock = chipRestock;

                //soda
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("===========================================");
                Console.WriteLine("=========         SODA         ============");
                Console.WriteLine("===========================================\n\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to the Restocking Tool \n\n");

                
                {
                    Console.WriteLine($" Soda in stock : {SodaFullStock}\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    

                    Console.WriteLine(" How much soda have we sold today? ");
                    {
                        sodaOrder = int.Parse(Console.ReadLine());

                        sodaOrder = Convert.ToInt32(sodaOrder);

                        sodaRemains = SodaFullStock - sodaOrder;

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.ReadLine();

                        if (sodaRemains >= 1 && sodaRemains <= 40) 
                        {
                            Console.WriteLine("soda needs to be restocked.");
                        }

                        //===== if order is between 60 and 100 restock

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (sodaRemains < 0 )
                        {

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Can't complete order. Order too large.  don’t adjust the stock.   ");
                            Console.WriteLine($"Chips amount left in stock: {sodaRestock}");
                        }
                        

                        if (sodaRemains < 40  && sodaRemains >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Please restock soda now. \n ");
                            Console.WriteLine($"Chips amount left in stock: {sodaRemains}");
                        }
                        
                        if (sodaRemains >= 40)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" No need to restock currently.  \n ");
                            Console.WriteLine($"Chips amount left in stock: {sodaRemains}");
                        }
                        

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("===========================================");
                        Console.WriteLine("=========         CANDY         ===========");
                        Console.WriteLine("===========================================\n\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" Candy in stock : {CandyFullStock}\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;

                       
                        Console.WriteLine(" How much candy have we sold today? ");

                        candyOrder = int.Parse(Console.ReadLine());

                        candyOrder = Convert.ToInt32(candyOrder);

                        candyRemains = CandyFullStock - candyOrder;

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.ReadLine();
                       
                        if (candyRemains <= 40 && candyRemains >= 0)
                        {
                            Console.WriteLine("Candy needs to be restocked.");
                            Console.WriteLine($"Ccandy amount left in stock: {candyRemains}");
                        }

                        //===== candy full at 60 and 40 restock

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (candyRemains < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Can't complete order. Order too large.  don’t adjust the stock.   ");
                            Console.WriteLine($"Candy amount left in stock: {candyRestock}");
                        }

                        if (candyRemains < 40 && candyRemains >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Please restock candy now. \n ");
                            Console.WriteLine($"Candy amount left in stock: {candyRemains}");
                        }

                        if (candyRemains >= 41)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" No need to restock currently.  \n ");
                            Console.WriteLine($"Chips amount left in stock: {candyRemains}");
                        }
                        

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("===========================================");
                        Console.WriteLine("=========         CHIPS         ===========");
                        Console.WriteLine("===========================================\n\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" Chips in stock : {ChipFullStock}\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;


                        Console.WriteLine(" How much chips have we sold today? ");
                        {
                            chipOrder = int.Parse(Console.ReadLine());

                            chipOrder = Convert.ToInt32(sodaOrder);

                            chipRemains = SodaFullStock - sodaOrder;

                            Console.ForegroundColor = ConsoleColor.Magenta;

                            Console.ReadLine();

                            if (chipRemains <= 40 && chipRemains >= 0)
                            {
                                Console.WriteLine("chips needs to be restocked.");
                                Console.WriteLine($"Chips amount left in stock: {chipRemains}");
                            }

                            //===== if order is between 60 and 100 restock

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            if (chipRemains < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"Can't complete order. Order too large.  don’t adjust the stock.   ");
                                Console.WriteLine($"Chips amount left in stock: {chipRestock}");
                            }

                            if (chipRemains < 20 && chipRemains >= 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Please restock chips now. \n ");

                                Console.WriteLine($"Chips amount left in stock: {chipRemains}");
                            }

                            if (sodaRemains >= 21)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("No need to restock currently.  \n ");

                                Console.WriteLine($"Chips amount left in stock: {chipRemains}");
                            }
                            
                            


                                Console.ForegroundColor = ConsoleColor.Magenta;
                                //chipOrder = int.Parse(Console.ReadLine());
                                Console.WriteLine("___________________________________________________\n");
                            if (sodaRemains >= 0) 
                            {
                                Console.WriteLine($"{sodaRemains}:amount left. Restock Soda needed. ");
                            }
                            if (candyRemains >= 0) 
                            {
                                Console.WriteLine($"{candyRemains}:amount left. Restock Candy needed. ");
                            }
                                
                            if (chipRemains >= 0) 
                            {
                                Console.WriteLine($"{chipRemains}:amount left. Restock Chips needed.\n\n");
                            }
                                
                            
                               
                            
                            //Console.WriteLine($" Soda: {candyRemains} needs to be restocked at 40 or less. ");
                            //Console.WriteLine($" Soda: {chipRemains} needs to be restocked at 20 or less. ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("PRESS ANY KEY TO EXIT. ");
                            Console.ReadLine();
                        }

                    }



                }
            }
        }
    }
}