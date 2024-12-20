namespace labb1._1;
class Program
{
    static void Main(string[] args)
    {
        int flightDurationsHour = 7; // Antalet timmar för flygtiden
        int flightDurationsMinute = 25; // Antalet minuter för flygtiden

        int newYorkHour = 10, newYorkMinute = 10; // Klockan är 10:10 i New York
        int stockholmHour = 14, stockholmMinute = 03; // Klockan är 14:03 i Stockholm
        int timeDifference = 6; // Det är 6-timmars mellanskillnad i städerna. Detta justerar tidpunkterna vid uträkning av ankomstiden.

        int landingHour; // Denna variabel lagrar timmen när flygplanet landar.
        int landingMinute; // Och denna lagarar minuterna när flygplanet landar.


        bool openProgram = true; // tilldelas en boolean variabel för att hålla programmmet igång i en loop tills rätt alternativ matas in.
        

        while (openProgram == true) // Starten på while-loop som forsätter så länge variabeln är true. I den här loopen kommer använderen att få alternativ och vid rätt alternativ avsluts loopen.
        {
                Console.WriteLine("Vilken flyg vill du se deltejerad information om? Svara med en siffra"); // Denna information skrivs ut till användaren.
                Console.WriteLine("1. Stockholm - New York"); // Denna alternativ skrivs ut för att välja om den ska ha information om denna flyg.
                Console.WriteLine("2. New York - Stockholm"); // Denna alternativ skrivs ut för att välja om den ska ha information om denna flyg.
                Console.WriteLine("3. Avsluta programmet!"); // Denna alternativ skriv ut för användaren att välja om den skulle vilja avsluta programmet.
                Console.WriteLine("Ange ditt val här: "); // Utskriv för att uppmana användaren att välja 1,2 eller 3.
                int choice = Convert.ToInt32(Console.ReadLine()); // Läser in användarens input som sträng och omvandlar till ett heltal. 

                try
                {
                if (choice == 1) // kontrollerar om användaren valt alternativ 1 och om choice motsvarar 1 kärs koden inuti blocket.
                {
                    landingHour = stockholmHour + flightDurationsHour + timeDifference; // landingHour beräknas... resultatet är den totala ankomsttiden i timmar.
                   
                    landingMinute = stockholmMinute + flightDurationsMinute; // landingMinute beräkas på samma sätt... resultatet är den totala ankomsttiden i minuter.
                Console.WriteLine($"Avgångstiden från Stockholm: {stockholmHour}:{stockholmMinute.ToString("00")}"); // Avgångstiden skrivs ut och ToString("00") säkerställer att minuterna visas med två siffror.
                   
                    if (landingHour > 23) // hanterar då landingHour blir större än 23.
                    {
                       
                        int formattedHour = landingHour - 24;
                    Console.WriteLine($"Ankomsttid till New York: {formattedHour.ToString("00")}:{landingMinute}");
                    /* Denna del är till för att justera överstigande timmar av 24. Och skriver ut ankomsstiden till NY med nya tiden.
                     
                     */
                }
                else
                    {
                        Console.WriteLine($"Ankomsttid till New York: {landingHour}:{landingMinute}");
                    }
                    // Om landingHour inte är större än 23, skrivs ankomsstiden till NY ut utan några justeringar i timmarna.
                    //När man vill blanda ihop vanlig text med variabler då används $

                    openProgram = false; // här säts programmet till false som stoppar den yttre while-loopen och programmet avsluts då användaren fick sin info
                }


                else if (choice == 2) // kontrollerar om användaren valt alternativ 2 och om choice motsvarar 2 körs koden inuti blocket.
            {
                    landingHour = newYorkHour + flightDurationsHour + timeDifference; // här beräkas ankomsstiden i timme som tidgare fast till anann rutt.
                    landingMinute = newYorkMinute + flightDurationsMinute; // här beräknas ankomsstiden i minuter som tidigare fast till annan rutt.
                    Console.WriteLine($"Avgångstid från New York: {newYorkHour}:{newYorkMinute.ToString("00")}"); // Skriver ut avgångstiden och säkertäller att minuterna visas två siffrigt.

                    Console.WriteLine($"Ankomsttid till Stockholm: {landingHour}:{landingMinute.ToString("00")}"); // Skriver ut avgångstiden och säkertäller att minuterna visas två siffrigt.
                openProgram = false;  // här sätts programmet till false som tidigare för att avsluta programmet.
                }

                else if (choice != 1 && choice != 2 && choice != 3) // Är en villkorkontroll och hanterar ogiltiga val från användaren. Denna kod körs bara om choice inte är motsvarar 1,2 eller 3.
                {
                    Console.WriteLine("Fel val! Var vänlig och välj alternativen mellan 1, 2 eller 3."); // detta skrivs ut om användaren matar in ogiltigt val, programmet exekverar koden inuti denna block.
                    openProgram = true; // Sedan sätts denna, som gör att programmet forstäter och visar alternativen igen, genom att återuppta loopen.
                }
                else
                {
                    Console.WriteLine("Programmet avslutas");
                    openProgram = false;  // vill du ha programmet öppet? Nej
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Tecken eller bokstav kan inte tas emot, var vänlig och välj ett utav de här!");
                }
            }
    }
}