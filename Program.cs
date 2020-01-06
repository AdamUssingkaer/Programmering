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
            int totalPenge = cz1 * Zone1Pri + cz2 * Zone2Pri + cz3 * Zone3Pri + cz4 * Zone4Pri + cz5 * Zone5Pri + cz6 * Zone6Pri + cz7 * Zone7Pri;

            int byttePenge = 0;
            int mangler = 0;
            int pengeInd = 0;
            int ekstra = 0;

            string message = "Thank you for your purchase";



            Start:

            Console.Clear();
            byttePenge = 0;
            mangler = 0;
            pengeInd = 0;

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
                            KøbBillet1();
                            cz1++;

                            goto Start;

                        }


                        if (UserZoneSelectTravel == 2)
                        {
                            
                            KøbBillet2();
                            cz2++;
                            goto Start;

                        }

                        if (UserZoneSelectTravel == 3)
                        {
                            

                            KøbBillet3();
                            cz3++;
                            goto Start;


                        }


                        if (UserZoneSelectTravel == 4)
                        {
                            
                            KøbBillet4();
                            cz4++;
                            goto Start;

                        }

                        if (UserZoneSelectTravel == 5)
                        {
                            
                            KøbBillet5();
                            cz5++;
                            goto Start;

                        }

                        if (UserZoneSelectTravel == 6)
                        {
                            
                            KøbBillet6();
                            cz6++;
                            goto Start;


                        }

                        if (UserZoneSelectTravel == 7)
                        {
                            
                            KøbBillet7();
                            cz7++;
                            goto Start;


                        }

                        Console.ReadLine();
                        goto Start;

                }
            }
            if (CaseSwitchMenu == 2)
            {
                switch (CaseSwitchMenu)
                {
                    case 2:
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


                            goto case 4;
                        }

                        if (AdmMenInp == 2)
                        {
                            czT = cz1 + cz2 + cz3 + cz4 + cz5 + cz6 + cz7;
                            Console.WriteLine("his is how many tickets has been collected for today: {0}", czT);
                            Console.WriteLine("Press \"9\" to return to adminportal");
                            int i = Convert.ToInt32(Console.ReadLine());
                            if (i == 9)
                            {
                                goto case 4;
                            }
                            else
                            {
                                Console.WriteLine("Abdi, umuligt du ikke kan ramme tasten \"9\" jeg skal nok gøre det for dig ewa");
                                Console.WriteLine("Klik ENTER");
                                Console.ReadLine();
                                goto case 4;
                            }
                        }

                        if (AdmMenInp == 3)
                        {
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
                            if (i == 1)
                            {
                                testBillet1();
                                Console.WriteLine("Hit ENTER to return to adminportal");
                                Console.ReadLine();
                                goto case 4;
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

                            Console.WriteLine("If you're done with testing press ENTER");
                            Console.ReadLine();
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

            


            void KøbBillet1()
            {
                Console.WriteLine("The price of traveling through 1 Zone is " + Zone1Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone1Pri);
                mangler = (Zone1Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler > 0)
                {
                    
                    for (pengeInd = pengeInd; pengeInd < Zone1Pri; mangler -= ekstra)
                    {
                        
                        if (mangler > 0)
                        {
                            int mangler2 = mangler;
                            Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                            Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                            string tjek = "";
                            tjek = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone1Pri);
                            if (tjek == "c")
                            {
                                Console.WriteLine("You have insereted {0} DKK at this moment", Zone1Pri - mangler2);
                                Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                                string exit = "";
                                exit = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone1Pri);
                                if (exit == "e")
                                {
                                    return;
                                }

                            }
                            ekstra = Convert.ToInt32(Console.ReadLine());

                        }

                        else if (mangler < 0)
                        {
                            Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                            Console.WriteLine("Hit enter to go back to terminal");
                            Console.ReadLine();
                            break;


                        }

                        else if (mangler == 0)
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

                //indsæt billet
                // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
                // You can modify the path if necessary.


                // Example #1: Write an array of strings to a file.
                // Create a string array that consists of three lines.
                string[] lines = { "First line", "Second line", "Third line" };
                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.  You do NOT need to call Flush() or Close().
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();

            }

           


            void KøbBillet2()
            {
                Console.WriteLine("The price of traveling through 2 Zone is " + Zone2Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone2Pri);
                mangler = (Zone2Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }


                for (pengeInd = pengeInd; pengeInd < Zone2Pri; mangler -= ekstra)
                {

                    if (mangler > 0)
                    {
                        int mangler2 = mangler;
                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                        Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                        string tjek = "";
                        tjek = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone2Pri);
                        if (tjek == "c")
                        {
                            Console.WriteLine("You have insereted {0} DKK at this moment", Zone2Pri - mangler2);
                            Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                            string exit = "";
                            exit = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone2Pri);
                            if (exit == "e")
                            {
                                return;
                            }

                        }
                        ekstra = Convert.ToInt32(Console.ReadLine());



                    }

                    else if (mangler < 0)
                    {
                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                        Console.WriteLine("Hit enter to go back to terminal");
                        Console.ReadLine();
                        break;


                    }

                    else if (mangler == 0)
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



            void KøbBillet3()
            {
                Console.WriteLine("The price of traveling through 3 Zone is " + Zone3Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone3Pri);
                mangler = (Zone3Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                for (pengeInd = pengeInd; pengeInd < Zone3Pri; mangler -= ekstra)
                {

                    if (mangler > 0)
                    {
                        int mangler2 = mangler;
                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                        Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                        string tjek = "";
                        tjek = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone3Pri);
                        if (tjek == "c")
                        {
                            Console.WriteLine("You have insereted {0} DKK at this moment", Zone3Pri - mangler2);
                            Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                            string exit = "";
                            exit = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone3Pri);
                            if (exit == "e")
                            {
                                return;
                            }

                        }
                        ekstra = Convert.ToInt32(Console.ReadLine());



                    }

                    else if (mangler < 0)
                    {
                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                        Console.WriteLine("Hit enter to go back to terminal");
                        Console.ReadLine();
                        break;


                    }

                    else if (mangler == 0)
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

            void KøbBillet4()
            {
                Console.WriteLine("The price of traveling through 4 Zone is " + Zone4Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone4Pri);
                mangler = (Zone4Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                for (pengeInd = pengeInd; pengeInd < Zone4Pri; mangler -= ekstra)
                {

                    if (mangler > 0)
                    {
                        int mangler2 = mangler;
                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                        Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                        string tjek = "";
                        tjek = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone4Pri);
                        if (tjek == "c")
                        {
                            Console.WriteLine("You have insereted {0} DKK at this moment", Zone4Pri - mangler2);
                            Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                            string exit = "";
                            exit = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone4Pri);
                            if (exit == "e")
                            {
                                return;
                            }

                        }
                        ekstra = Convert.ToInt32(Console.ReadLine());



                    }

                    else if (mangler < 0)
                    {
                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                        Console.WriteLine("Hit enter to go back to terminal");
                        Console.ReadLine();
                        break;


                    }

                    else if (mangler == 0)
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

            void KøbBillet5()
            {
                Console.WriteLine("The price of traveling through 5 Zone is " + Zone5Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone5Pri);
                mangler = (Zone5Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                for (pengeInd = pengeInd; pengeInd < Zone5Pri; mangler -= ekstra)
                {

                    if (mangler > 0)
                    {
                        int mangler2 = mangler;
                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                        Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                        string tjek = "";
                        tjek = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone5Pri);
                        if (tjek == "c")
                        {
                            Console.WriteLine("You have insereted {0} DKK at this moment", Zone5Pri - mangler2);
                            Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                            string exit = "";
                            exit = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone5Pri);
                            if (exit == "e")
                            {
                                return;
                            }

                        }
                        ekstra = Convert.ToInt32(Console.ReadLine());


                    }

                    else if (mangler < 0)
                    {
                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                        Console.WriteLine("Hit enter to go back to terminal");
                        Console.ReadLine();
                        break;


                    }

                    else if (mangler == 0)
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

            void KøbBillet6()
            {
                Console.WriteLine("The price of traveling through 6 Zone is " + Zone6Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone6Pri);
                mangler = (Zone6Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                for (pengeInd = pengeInd; pengeInd < Zone6Pri; mangler -= ekstra)
                {

                    if (mangler > 0)
                    {
                        int mangler2 = mangler;
                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                        Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                        string tjek = "";
                        tjek = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone6Pri);
                        if (tjek == "c")
                        {
                            Console.WriteLine("You have insereted {0} DKK at this moment", Zone6Pri - mangler2);
                            Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                            string exit = "";
                            exit = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone6Pri);
                            if (exit == "e")
                            {
                                return;
                            }

                        }
                        ekstra = Convert.ToInt32(Console.ReadLine());



                    }

                    else if (mangler < 0)
                    {
                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                        Console.WriteLine("Hit enter to go back to terminal");
                        Console.ReadLine();
                        break;


                    }

                    else if (mangler == 0)
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


            void KøbBillet7()
            {
                Console.WriteLine("The price of traveling through 7 Zone is " + Zone7Pri + " DKK");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please write the amount you intend to insert");
                pengeInd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have inserted {0} DKK ", pengeInd);
                byttePenge = (pengeInd - Zone7Pri);
                mangler = (Zone7Pri - pengeInd);

                if (mangler == 0)
                {
                    Console.WriteLine("Thanks for your purchase");
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                if (mangler < 0)
                {
                    Console.WriteLine("Thanks for your purchase her is {0} DKK back ", byttePenge);
                    Console.WriteLine("Hit ENTER to return to main menu");
                    Console.ReadLine();
                }

                for (pengeInd = pengeInd; pengeInd < Zone7Pri; mangler -= ekstra)
                {

                    if (mangler > 0)
                    {
                        int mangler2 = mangler;
                        Console.WriteLine("Sorry you didn't put enough money in please insert {0} DKK more ", mangler2);
                        Console.WriteLine("Press \"c\" to check amout of money you've put in, hit ENTER to continue");
                        string tjek = "";
                        tjek = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Insert amount {0} DKK to get {1} DKK", mangler2, Zone7Pri);
                        if (tjek == "c")
                        {
                            Console.WriteLine("You have insereted {0} DKK at this moment", Zone7Pri - mangler2);
                            Console.WriteLine("Press \"e\" to exit, if you want to contiune hit ENTER");
                            string exit = "";
                            exit = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insert amount to {0} DKK to get {1} DKK", mangler2, Zone7Pri);
                            if (exit == "e")
                            {
                                return;
                            }

                        }
                        ekstra = Convert.ToInt32(Console.ReadLine());



                    }

                    else if (mangler < 0)
                    {
                        Console.WriteLine("Thanks for your purchase here is {0} DKK back", mangler * -1);
                        Console.WriteLine("Hit enter to go back to terminal");
                        Console.ReadLine();
                        break;


                    }

                    else if (mangler == 0)
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
                string[] lines = { "Zone 7", "Second line", "Third line" };
                System.IO.File.WriteAllLines(@"C:\Users\aske_\Desktop\programering\bTekst filer til Billetter\Billet.txt", lines);
                Console.WriteLine("Billet udskrives");
                Console.ReadLine();
            }

            

            void købEkstra()
            {
                Console.WriteLine("Would you like to buy another ticket?");
                Console.WriteLine("If \"Yes\" press 1, if \"no\" press 2");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.ReadLine();


            }

        }
    }
}
