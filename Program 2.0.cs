using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ny_og_best
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start prices for tickets, needs to be changed immidiately after every restart//
            int Zone1Pri = 0;
            int Zone2Pri = 0;
            int Zone3Pri = 0;
            int Zone4Pri = 0;
            int Zone5Pri = 0;
            int Zone6Pri = 0;
            int Zone7Pri = 0;


            int cz1 = 0;
            int cz2 = 0;
            int cz3 = 0;
            int cz4 = 0;
            int cz5 = 0;
            int cz6 = 0;
            int cz7 = 0;
            int czT = cz1 + cz2 + cz3 + cz4 + cz5 + cz6 + cz7;
            int totalPenge = 0;


            int exchangeMoney = 0;
            int missing = 0;
            int moneyInd = 0;
            int ekstra = 0;

            string message = "Thank you for your purchase";



        Start:

            Console.Clear();
            exchangeMoney = 0;
            missing = 0;
            moneyInd = 0;

            Console.WriteLine("Hello welcome to the ticket booth");
            Console.WriteLine("Please hit the corresponding key to the menu you want to go to");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1) Tickets");
            Console.WriteLine("2) Prices");
            int CaseSwitchMenu = Convert.ToInt32(Console.ReadLine());
            if (CaseSwitchMenu == 1)
            {
                switch (CaseSwitchMenu)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Welcome to the Ticket menu");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Select the number of Zones you would like to travel through");
                        Console.WriteLine("1: [1 Zone]");
                        Console.WriteLine("2: [2 Zone]");
                        Console.WriteLine("3: [3 Zone]");
                        Console.WriteLine("4: [4 Zone]");
                        Console.WriteLine("5: [5 Zone]");
                        Console.WriteLine("6: [6 Zone]");
                        Console.WriteLine("7: [7 Zone]");

                        int UserZoneSelectTravel = Convert.ToInt32(Console.ReadLine());

                        if (UserZoneSelectTravel == 1)
                        {
                            cz1++;
                            Console.WriteLine("The price of traveling through 1 Zone is " + Zone1Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone1Pri);
                            missing = (Zone1Pri - moneyInd);

                            if (moneyInd == Zone1Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone1Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone1Pri)
                            {

                                for (int i = moneyInd; i < Zone1Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone1Pri)
                                    {
                                        int missing2 = (moneyInd - Zone1Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);

                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone1Pri)
                                    {
                                        int missing2 = (moneyInd - Zone1Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone1Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }

                            
                            string[] lines = { "Zone 1", "Second line", "Third line" };

                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;

                        }


                        if (UserZoneSelectTravel == 2)
                        {

                            cz2++;
                            Console.WriteLine("The price of traveling through 2 Zone is " + Zone2Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone1Pri);
                            missing = (Zone2Pri - moneyInd);

                            if (moneyInd == Zone2Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone2Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone2Pri)
                            {

                                for (int i = moneyInd; i < Zone2Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone2Pri)
                                    {
                                        int missing2 = (moneyInd - Zone2Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);
                                        
                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone2Pri)
                                    {
                                        int missing2 = (moneyInd - Zone2Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone2Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }

                            
                            string[] lines = { "Zone 2", "Second line", "Third line" };

                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;

                        }

                        if (UserZoneSelectTravel == 3)
                        {
                            cz3++;
                            Console.WriteLine("The price of traveling through 3 Zone is " + Zone3Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone3Pri);
                            missing = (Zone3Pri - moneyInd);

                            if (moneyInd == Zone3Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone3Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone3Pri)
                            {

                                for (int i = moneyInd; i < Zone3Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone3Pri)
                                    {
                                        int missing2 = (moneyInd - Zone3Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);
                                        
                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone3Pri)
                                    {
                                        int missing2 = (moneyInd - Zone3Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone3Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }


                            string[] lines = { "Zone 3", "Second line", "Third line" };

                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;

                        }


                        if (UserZoneSelectTravel == 4)
                        {
                            cz4++;
                            Console.WriteLine("The price of traveling through 4 Zone is " + Zone4Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone4Pri);
                            missing = (Zone4Pri - moneyInd);

                            if (moneyInd == Zone4Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone4Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone4Pri)
                            {

                                for (int i = moneyInd; i < Zone4Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone4Pri)
                                    {
                                        int missing2 = (moneyInd - Zone4Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);
                                        
                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone4Pri)
                                    {
                                        int missing2 = (moneyInd - Zone4Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone4Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }


                            string[] lines = { "Zone 4", "Second line", "Third line" };

                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;


                        }

                        if (UserZoneSelectTravel == 5)
                        {
                            cz5++;
                            Console.WriteLine("The price of traveling through 5 Zone is " + Zone5Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone5Pri);
                            missing = (Zone5Pri - moneyInd);

                            if (moneyInd == Zone5Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone5Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone5Pri)
                            {

                                for (int i = moneyInd; i < Zone5Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone5Pri)
                                    {
                                        int missing2 = (moneyInd - Zone5Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);
                                        
                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone5Pri)
                                    {
                                        int missing2 = (moneyInd - Zone5Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone5Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }


                            string[] lines = { "Zone 5", "Second line", "Third line" };


                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;
                        }

                        if (UserZoneSelectTravel == 6)
                        {
                            cz6++;
                            Console.WriteLine("The price of traveling through 6 Zone is " + Zone6Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone6Pri);
                            missing = (Zone6Pri - moneyInd);

                            if (moneyInd == Zone6Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone6Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone6Pri)
                            {

                                for (int i = moneyInd; i < Zone6Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone6Pri)
                                    {
                                        int missing2 = (moneyInd - Zone6Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);
                                        
                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone6Pri)
                                    {
                                        int missing2 = (moneyInd - Zone6Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone6Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }


                            string[] lines = { "Zone 6", "Second line", "Third line" };

                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;

                        }

                        if (UserZoneSelectTravel == 7)
                        {
                            cz7++;
                            Console.WriteLine("The price of traveling through 7 Zone is " + Zone7Pri + " DKK");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Please write the amount you intend to insert");
                            moneyInd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("You have inserted {0} DKK ", moneyInd);
                            exchangeMoney = (moneyInd - Zone7Pri);
                            missing = (Zone7Pri - moneyInd);

                            if (moneyInd == Zone7Pri)
                            {
                                Console.WriteLine("Thanks for your purchase");
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd > Zone7Pri)
                            {
                                Console.WriteLine("Thanks for your purchase her is {0} DKK back ", exchangeMoney);
                                Console.WriteLine("Hit ENTER to return to main menu");
                                Console.ReadLine();
                            }

                            if (moneyInd < Zone7Pri)
                            {

                                for (int i = moneyInd; i < Zone7Pri; moneyInd += ekstra)
                                {

                                    if (moneyInd < Zone7Pri)
                                    {
                                        int missing2 = (moneyInd - Zone7Pri) * -1;
                                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", missing2);
                                        
                                        ekstra = Convert.ToInt32(Console.ReadLine());

                                    }

                                    else if (moneyInd > Zone7Pri)
                                    {
                                        int missing2 = (moneyInd - Zone7Pri);
                                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", missing2);
                                        Console.WriteLine("Hit enter to go back to terminal");
                                        Console.ReadLine();
                                        break;


                                    }

                                    else if (moneyInd == Zone7Pri)
                                    {
                                        Console.WriteLine("Thanks for your purchase");
                                        Console.WriteLine("Hit enter to return to terminal");
                                        Console.ReadLine();
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Fejl");
                                        Console.ReadLine();
                                        break;
                                    }



                                }


                            }


                            string[] lines = { "Zone 7", "Second line", "Third line" };

                            System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                            Console.WriteLine("Billet udskrives");
                            Console.ReadLine();



                            goto Start;

                        }


                        goto Start;

                }
            }
            if (CaseSwitchMenu == 2)
            {
                switch (CaseSwitchMenu)
                {
                    case 2:
                        Console.Clear();
                        Console.WriteLine("This is the price menu of the Zone Tickets");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Zone 1 = " + Zone1Pri);
                        Console.WriteLine("Zone 2 = " + Zone2Pri);
                        Console.WriteLine("Zone 3 = " + Zone3Pri);
                        Console.WriteLine("Zone 4 = " + Zone4Pri);
                        Console.WriteLine("Zone 5 = " + Zone5Pri);
                        Console.WriteLine("Zone 6 = " + Zone6Pri);
                        Console.WriteLine("Zone 7 = " + Zone7Pri);

                        Console.WriteLine("When you are done inspecting menu press any key to return");
                        Console.ReadLine();
                        goto Start;
                }
            }
            if (CaseSwitchMenu == 3)
            {
                switch (CaseSwitchMenu)
                {
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Administrator Acces");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Type Password");
                        int AdmCode = Convert.ToInt32(Console.ReadLine());
                        if (AdmCode == 927)
                        {
                            Console.WriteLine("Acces granted please press enter to continue");
                            Console.ReadLine();
                            goto case 4;


                        }
                        else
                        {
                            Console.WriteLine("WRONG PASSWORD ERROR!");
                            Console.WriteLine("You will be redirected to the menu");
                            System.Threading.Thread.Sleep(5000);
                        }
                        goto Start;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Please select the menu you would like to see");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("1] Pricing menu");
                        Console.WriteLine("2] Tickets purchased");
                        Console.WriteLine("3] Total money for today");
                        Console.WriteLine("4] Printing Test");
                        Console.WriteLine("9] Exit to main interface");
                        int AdmMenInp = Convert.ToInt32(Console.ReadLine());
                        if (AdmMenInp == 1)
                        {

                            Console.Clear();
                            Console.WriteLine("You are in Administrator pricing portal");

                            Console.WriteLine("Write the price for travel through Zone 1");
                            Zone1Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Write the price for travel through Zone 2");
                            Zone2Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Write the price for travel through Zone 3");
                            Zone3Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Write the price for travel through Zone 4");
                            Zone4Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Write the price for travel through Zone 5");
                            Zone5Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Write the price for travel through Zone 6");
                            Zone6Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Write the price for travel through Zone 7");
                            Zone7Pri = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Press ENTER to be redirected to the previous menu");
                            Console.ReadLine();

                            goto case 4;
                        }

                        if (AdmMenInp == 2)
                        {
                            czT = cz1 + cz2 + cz3 + cz4 + cz5 + cz6 + cz7;
                            Console.WriteLine("his is how many tickets has been collected for today: {0}", czT);
                            Console.WriteLine("Press \"9\" to return to adminportal");
                            Console.ReadLine();
                            goto case 4;
                        }

                        if (AdmMenInp == 3)
                        {
                            totalPenge = (cz1 * Zone1Pri) + (cz2 * Zone2Pri) + (cz3 * Zone3Pri) + (cz4 * Zone4Pri) +
                                         (cz5 * Zone5Pri) + (cz6 * Zone6Pri) + (cz7 * Zone7Pri);
                            Console.WriteLine("This is how much money has been collected for today per zone: ");
                            Console.WriteLine("1] Zone: {0} DKK", cz1 * Zone1Pri);
                            Console.WriteLine("2] Zone: {0} DKK", cz2 * Zone2Pri);
                            Console.WriteLine("3] Zone: {0} DKK", cz3 * Zone3Pri);
                            Console.WriteLine("4] Zone: {0} DKK", cz4 * Zone4Pri);
                            Console.WriteLine("5] Zone: {0} DKK", cz5 * Zone5Pri);
                            Console.WriteLine("6] Zone: {0} DKK", cz6 * Zone6Pri);
                            Console.WriteLine("7] Zone: {0} DKK", cz7 * Zone7Pri);
                            Console.WriteLine("Total money {0} DKK", totalPenge);
                            Console.WriteLine("Press \"1\" to withdraw money");
                            Console.WriteLine("Press \"9\" to return to adminportal");
                            int i = Convert.ToInt32(Console.ReadLine());

                            if (i == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("You have withdrawn the amount {0} ", totalPenge);
                                Console.WriteLine("Press ENTER to go back to adminportal");
                                Console.ReadLine();
                                goto case 4;
                            }

                            if (i == 9)
                            {
                                goto case 4;
                            }

                            Console.WriteLine("Abdi det her var ikke en mulighed. Klik ENTER for at komme til admportal");
                            Console.ReadLine();
                            goto case 4;

                        }

                        if (AdmMenInp == 4)
                        {
                            Console.WriteLine("Pick the zone you want to test print or hit \"9\" to exit");
                            Console.WriteLine("1: [1 Zone]");
                            Console.WriteLine("2: [2 Zone]");
                            Console.WriteLine("3: [3 Zone]");
                            Console.WriteLine("4: [4 Zone]");
                            Console.WriteLine("5: [5 Zone]");
                            Console.WriteLine("6: [6 Zone]");
                            Console.WriteLine("7: [7 Zone]");

                            int i = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (i == 1)
                            {
                                testBillet1();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();

                            }

                            if (i == 2)
                            {
                                testBillet2();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                            }

                            if (i == 3)
                            {
                                testBillet3();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                            }

                            if (i == 4)
                            {
                                testBillet4();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                            }

                            if (i == 5)
                            {
                                testBillet5();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                            }

                            if (i == 6)
                            {
                                testBillet6();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                            }

                            if (i == 7)
                            {
                                testBillet7();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                            }

                            if (i == 9)
                            {
                                Console.WriteLine("Press ENTER to exit");
                                Console.ReadLine();
                                goto case 4;
                            }


                            goto case 4;


                        }

                        if (AdmMenInp == 9)
                        {
                            goto Start;
                        }
                        goto Start;
                }



            }


            //Koden stopper her

            void testBillet1()
            {
                string[] lines = { "Zone 1", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            void testBillet2()
            {
                string[] lines = { "Zone 2", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            void testBillet3()
            {
                string[] lines = { "Zone 3", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            void testBillet4()
            {
                string[] lines = { "Zone 4", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            void testBillet5()
            {
                string[] lines = { "Zone 5", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            void testBillet6()
            {
                string[] lines = { "Zone 6", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            void testBillet7()
            {
                Console.WriteLine("Billet udskrives");
                string[] lines = { "Zone 7", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);

            }



           

        }
    }
}
