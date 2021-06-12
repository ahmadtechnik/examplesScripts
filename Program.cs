using System;

namespace Tutorial
{
    class Program
    {
        // gefälschte Daten zur Verarbeitung deklarieren
        public static string[] Teilnehmer = {"Emma","Olivia","Sophia","Ava","Isabella","Mia","Abigail","Emily","Charlotte","Harper","Madison","Amelia","Elizabeth","Sofia","Evelyn","Avery","Chloe","Ella","Grace","Victoria","Aubrey","Scarlett","Zoey","Addison","Lily","Lillian","Natalie","Hannah","Aria","Layla","Brooklyn","Alexa","Zoe","Penelope","Riley","Leah","Audrey","Savannah","Allison","Samantha","Nora","Skylar","Camila","Anna","Paisley","Ariana","Ellie","Aaliyah","Claire","Violet","Stella","Sadie","Mila","Gabriella","Lucy","Arianna","Kennedy","Sarah","Madelyn","Eleanor","Kaylee","Caroline","Hazel","Hailey","Genesis","Kylie","Autumn","Piper","Maya","Nevaeh","Serenity","Peyton","Mackenzie","Bella","Eva","Taylor","Naomi","Aubree","Aurora","Melanie","Lydia","Brianna","Ruby","Katherine","Ashley","Alexis","Alice","Cora","Julia","Madeline","Faith","Annabelle","Alyssa","Isabelle","Vivian","Gianna","Quinn","Clara","Reagan","Khloe","Alexandra","Hadley","Eliana","Sophie","London","Elena","Kimberly","Bailey","Maria","Luna","Willow","Jasmine","Kinsley","Valentina","Kayla","Delilah","Andrea","Natalia","Lauren","Morgan","Rylee","Sydney","Adalynn","Mary","Ximena","Jade","Liliana","Brielle","Ivy","Trinity","Josephine","Adalyn","Jocelyn","Emery","Adeline","Jordyn","Ariel","Everly","Lilly","Paige","Isla","Lyla","Makayla","Molly","Emilia","Mya","Kendall","Melody","Isabel","Brooke","Mckenzie","Nicole","Payton","Margaret","Mariah","Eden","Athena","Amy","Norah","Londyn","Valeria","Sara","Aliyah","Angelina","Gracie","Rose","Rachel","Juliana","Laila","Brooklynn","Valerie","Alina","Reese","Elise","Eliza","Alaina","Raelynn","Leilani","Catherine","Emerson","Cecilia","Genevieve","Daisy","Harmony","Vanessa","Adriana","Presley","Rebecca","Destiny","Hayden","Julianna","Michelle","Adelyn","Arabella","Summer","Callie","Kaitlyn","Ryleigh","Lila","Daniela","Arya","Alana","Esther","Finley","Gabrielle","Jessica","Charlie","Stephanie","Tessa","Makenzie","Ana","Amaya","Alexandria","Alivia","Nova","Anastasia","Iris","Marley","Fiona","Angela","Giselle","Kate","Alayna","Lola","Lucia","Juliette","Parker","Teagan","Sienna","Georgia","Hope","Cali","Vivienne","Izabella","Kinley","Daleyza","Kylee","Jayla","Katelyn","Juliet","Maggie","Dakota","Delaney","Brynlee","Keira","Camille","Leila","Mckenna","Aniyah","Noelle","Josie","Jennifer","Melissa","Gabriela","Allie","Eloise","Cassidy","Jacqueline","Brynn","Sawyer","Evangeline","Jordan","Paris","Olive","Ayla","Rosalie","Kali","Maci","Gemma","Lilliana","Raegan","Lena","Adelaide","Journey","Adelynn","Alessandra","Kenzie","Miranda","Haley","June","Harley","Charlee","Lucille","Talia","Skyler","Makenna","Phoebe","Jane","Lyric","Angel","Elaina","Adrianna","Ruth","Miriam","Diana","Mariana","Danielle","Jenna","Shelby","Nina","Madeleine","Elliana","Amina","Amiyah","Chelsea","Joanna","Jada","Lexi","Katie","Maddison","Fatima","Vera","Malia","Lilah","Madilyn","Amanda","Daniella","Alexia","Kathryn","Paislee","Selena","Laura","Annie","Nyla","Catalina","Kayleigh","Sloane","Kamila","Lia","Haven","Rowan","Ashlyn","Christina","Amber","Myla","Addilyn","Erin","Alison","Ainsley","Raelyn","Cadence","Kendra","Heidi","Kelsey","Nadia","Alondra","Cheyenne","Kaydence","Mikayla","River","Heaven","Arielle","Lana","Blakely","Sabrina","Kyla","Ada","Gracelyn","Allyson","Felicity","Kira","Briella","Kamryn","Adaline","Alicia","Ember","Aylin","Veronica","Esmeralda","Sage","Leslie","Aspen","Gia","Camilla","Ashlynn","Scarlet","Journee","Daphne","Bianca","Mckinley","Amira","Carmen","Kyleigh","Megan","Skye","Elsie","Kennedi","Averie","Carly","Rylie","Gracelynn","Mallory","Emersyn","Logan","Camryn","Annabella","Dylan","Elle","Kiara","Yaretzi","Ariella","Zara","April","Gwendolyn","Anaya","Baylee","Brinley","Sierra","Annalise","Tatum","Serena","Dahlia","Macy","Miracle","Madelynn","Briana","Freya","Macie","Helen","Bethany","Leia","Harlow","Blake","Jayleen","Angelica","Marilyn","Viviana","Francesca","Juniper","Carolina","Jazmin","Emely","Maliyah","Cataleya","Jillian","Joy","Abby","Malaysia","Nylah","Sarai","Evelynn","Nia","Zuri","Addyson","Aleah","Kaia","Bristol","Lorelei","Jazmine","Maeve","Alejandra","Justice","Julie","Marlee","Phoenix","Jimena","Emmalyn","Nayeli","Aleena","Brittany","Amara","Karina","Giuliana","Thea","Braelynn","Kassidy","Braelyn","Luciana","Aubrie","Janelle","Madisyn","Brylee","Leighton","Ryan","Amari","Eve","Millie","Kelly","Selah","Lacey","Willa","Haylee","Jaylah","Sylvia","Melany","Elisa","Elsa","Hattie","Raven","Holly","Aisha","Itzel","Kyra","Tiffany","Jayda","Michaela","Madilynn","Jamie","Celeste","Lilian","Remi","Priscilla","Jazlyn","Karen","Savanna","Zariah","Lauryn","Alanna","Kara","Karla","Cassandra","Ariah","Evie","Frances","Aileen","Lennon","Charley","Rosemary","Danna","Regina","Kaelyn","Virginia","Hanna","Rebekah","Alani","Edith","Liana","Charleigh","Gloria","Cameron","Colette","Kailey","Carter","Helena","Matilda","Imani","Bridget","Cynthia","Janiyah","Marissa","Johanna","Sasha","Kaliyah","Cecelia","Adelina","Jessa","Hayley","Julissa","Winter","Crystal","Kaylie","Bailee","Charli","Henley","Anya","Maia","Skyla","Liberty","Fernanda","Monica","Braylee","Dallas","Mariam","Marie","Beatrice","Hallie","Maryam","Angelique","Anne","Madalyn","Alayah","Annika","Greta","Lilyana","Kadence","Coraline","Lainey","Mabel","Lillie","Anika","Azalea","Dayana","Jaliyah","Addisyn","Emilee","Mira","Angie","Lilith","Mae","Meredith","Guadalupe","Emelia","Margot","Melina","Aniya","Alena","Myra","Elianna","Caitlyn","Jaelynn","Jaelyn","Demi","Mikaela","Tiana","Blair","Shiloh","Ariyah","Saylor","Caitlin","Lindsey","Oakley","Alia","Everleigh","Ivanna","Miah","Emmy","Jessie","Anahi","Kaylin","Ansley","Annabel","Remington","Kora","Maisie","Nathalie","Emory","Karsyn","Pearl","Irene","Kimber","Rosa","Lylah","Magnolia","Samara","Elliot","Renata","Galilea","Kensley","Kiera","Whitney","Amelie","Siena","Bria","Laney","Perla","Tatiana","Zelda","Jaycee","Kori","Montserrat","Lorelai","Adele","Elyse","Katelynn","Kynlee","Marina","Jayden","Kailyn","Avah","Kenley","Aviana","Armani","Dulce","Alaia","Teresa","Natasha","Milani","Amirah","Breanna","Linda","Tenley","Sutton","Elaine","Elliott","Aliza","Kenna","Meadow","Alyson","Rory","Milana","Erica","Esme","Leona","Joselyn","Madalynn","Alma","Chanel","Myah","Karter","Zahra","Audrina","Ariya","Jemma","Eileen","Kallie","Milan","Emmalynn","Lailah","Sloan","Clarissa","Karlee","Laylah","Amiya","Collins","Ellen","Hadassah","Danica","Jaylene","Averi","Reyna","Saige","Wren","Lexie","Dorothy","Lilianna","Monroe","Aryanna","Elisabeth","Ivory","Liv","Janessa","Jaylynn","Livia","Rayna","Alaya","Malaya","Cara","Erika","Amani","Clare","Addilynn","Roselyn","Corinne","Paola","Jolene","Anabelle","Aliana","Lea","Mara","Lennox","Claudia","Kristina","Jaylee","Kaylynn","Zariyah","Gwen","Kinslee","Avianna","Lisa","Raquel","Jolie","Carolyn","Courtney","Penny","Royal","Alannah","Ciara","Chaya","Kassandra","Milena","Mina","Noa","Leanna","Zoie","Ariadne","Monserrat","Nola","Carlee","Isabela","Jazlynn","Kairi","Laurel","Sky","Rosie","Arely","Aubrielle","Kenia","Noemi","Scarlette","Farrah","Leyla","Amia","Bryanna","Naya","Wynter","Hunter","Katalina","Taliyah","Amaris","Emerie","Martha","Thalia","Christine","Estrella","Brenna","Milania","Salma","Lillianna","Marjorie","Shayla","Zendaya","Aurelia","Brenda","Julieta","Adilynn","Deborah","Keyla","Patricia","Emmeline","Hadlee","Giovanna","Kailee","Desiree","Casey","Karlie","Khaleesi","Lara","Tori","Clementine","Nancy","Simone","Ayleen","Estelle","Celine","Madyson","Zaniyah","Adley","Amalia","Paityn","Kathleen","Sandra","Lizbeth","Maleah","Micah","Aryana","Hailee","Aiyana","Joyce","Ryann","Caylee","Kalani","Marisol","Nathaly","Briar","Holland","Lindsay","Remy","Adrienne","Azariah","Harlee","Dana","Frida","Marianna","Yamileth","Chana","Kaya","Lina","Celia","Analia","Hana","Jayde","Joslyn","Romina","Anabella","Barbara","Bryleigh","Emilie","Nathalia","Ally","Evalyn","Bonnie","Zaria","Carla","Estella","Kailani","Rivka","Rylan","Paulina","Kayden","Giana","Yareli","Kaiya","Sariah","Avalynn","Jasmin","Aya","Jewel","Kristen","Paula","Astrid","Jordynn","Kenya","Ann","Annalee","Kai","Kiley","Marleigh","Julianne","Zion","Emmaline","Nataly","Aminah","Amya","Iliana","Jaida","Paloma","Asia","Louisa","Sarahi","Tara","Andi","Arden","Dalary","Aimee","Alisson","Halle","Aitana","Landry","Alisha","Elin","Maliah","Belen","Briley","Raina","Vienna","Esperanza","Judith","Faye","Susan","Aliya","Aranza","Yasmin","Jaylin","Kyndall","Saniyah","Wendy","Yaritza","Azaria","Kaelynn","Neriah","Zainab","Alissa","Cherish","Dixie","Veda","Nala","Tabitha","Cordelia","Ellison","Meilani","Angeline","Reina","Tegan","Hadleigh","Harmoni","Kimora","Ingrid","Lilia","Luz","Aislinn","America","Ellis","Elora","Heather","Natalee","Miya","Heavenly","Jenny","Aubriella","Emmalee","Kensington","Kiana","Lilyanna","Tinley","Ophelia","Moriah","Sharon","Charlize","Abril","Avalyn","Mariyah","Taya","Ireland","Lyra","Noor","Sariyah","Giavanna","Stevie","Rhea","Zaylee","Denise","Frankie","Janiya","Jocelynn","Libby","Aubrianna","Kaitlynn","Princess","Sidney","Alianna"};

        static void Main(string[] args)
        {
            // Bitten den Benutzer immer wieder, etwas einzugeben
            while (true)
            {
                PrintAvailableColorsAsList();

                // Konsolennachricht an den Benutzer, um Daten einzugeben
                Console.Write("Wählen Sie einen Index von 0 bis 15 :");

                // Variable initialisieren, um Benutzereingaben darin zu speichern
                long userInput = -1;

                // versuchen den eingegebenen Wert in (int 64 bit) umzuwandeln, um Fehlermeldungen vom Compiler zu vermeiden
                try
                {
                    // Benutzereingaben in Variable speichern, um den Wert später zu verarbeiten
                    userInput = Convert.ToInt64(Console.ReadLine());
                }

                // Wenn ein Fehler aufgetreten ist, werden wir ihn hier in diesem Block abfangen und anderen Anweisungen entgehen
                catch (Exception ex)
                {
                    // Rufen Sie die Methode ShowErrorMessage in auf, um die Nachricht in einer bestimmten Farbe anzuzeigen (Rot)
                    ShowErrorMessage(ex.Message);
                    continue;
                }

                // Wenn der Benutzer -1 eingegeben hat, verlassen Sie das Programm
                if (userInput == -1)
                {
                    PrintLoader();
                    Console.Write("Schade ! Bay Bay 🤪 ");
                    System.Threading.Thread.Sleep(100);
                    break;
                }

                // Überprüfen Sie, ob die Benutzereingabe zwischen 0 und 15 . liegt
                if (!IsBtween(0, 15, userInput))
                {
                    // Rufen Sie die Methode ShowErrorMessage in auf, um die Nachricht in einer bestimmten Farbe anzuzeigen (Rot)
                    ShowErrorMessage("WAS !! was hast du von wert eingegeben ! nur sauberen Wert eingeben 😑  ");
                    // Wenn die Benutzereingabe nicht zwischen 0 und 15 liegt, führe den Code nicht aus
                    continue;
                }

                // Konsolenfarbe auf die Farbe setzen, die der Benutzer ausgewählt hat
                Console.ForegroundColor = (ConsoleColor)userInput;

                // vom Benutzer ausgewählten Farbnamen und Index anzeigen
                Console.WriteLine($"Cool ! du hast die Farbe '{(ConsoleColor)userInput} / mit index {userInput}' ausgewählt. Lass uns jetzt die Nahmen mit der Farbe drucken Warte 2 Secunde.");

                // Schick ! Benutzerlader anzeigen, um das Gefühl zu geben, dass etwas im Gange ist
                PrintLoader();

                // Gefälschte Daten in der Konsole drucken
                for (int i = 0; i < Teilnehmer.Length; i++)
                {
                    Console.Write($"[{Teilnehmer[i]}] - ");
                    System.Threading.Thread.Sleep(10);
                }

                // neue 2 Zeilen drucken
                Console.Write("\n\n");

                // Schriftfarbe wieder auf weiß setzen
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        /*
         * Diese Methode prüft, ob der angegebene Wert im Bereich zwischen (min) und (max) liegt
         */
        static bool IsBtween(int min, int max, long value)
        {
            return value >= min && value <= max;
        }

        /*
         * lösche die letzte Zeile in der Konsole
         */
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.Write($"({currentLineCursor} , {Console.CursorTop} , {Console.GetCursorPosition().Left})");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        /*
         * jede Ausgabe in der Konsole zwischen Position (Start) und (End) wird gelöscht um etwas Neues im gleichen Bereich anzuzeigen
         */
        public static void ClearConsoleByLength(int start, int end)
        {
            int currentLineCursor = Console.CursorTop;

            Console.SetCursorPosition(start, currentLineCursor);
            Console.Write(new string(' ', end));
            Console.SetCursorPosition(start, currentLineCursor);
        }

        /*
         * Machen wir unser Programm ein bisschen realistisch,
         * jedes Programm muss eine Prozesszeit haben,
         * daher müssen wir dem Benutzer zeigen,
         * was im Hintergrund vor sich geht und in welchem ​​Stadium wir uns gerade befinden
         */
        public static void PrintLoader()
        {
            var w = Console.WindowWidth;
            var prependMessage = "Loading [";
            Console.Write(prependMessage);

            for (int i = 0; i < w - prependMessage.Length - 1; i++)
            {
                float precent = (float)i / (float)w * 100;
                ClearConsoleByLength(prependMessage.Length, precent.ToString("0.00").Length);
                Console.Write($"{precent.ToString("0.00")}%]");
                System.Threading.Thread.Sleep(5);
            }
            Console.Write('\n');
        }

        /*
         * Es ist immer besser,
         * die Nachrichten in der richtigen Farbe anzuzeigen,
         * hier ändern wir die Farbe der Schriftart,
         * um die Nachricht in Rot zu drucken
         */
        public static void ShowErrorMessage(string message)
        {
            // set console font color to red to show error message
            Console.ForegroundColor = ConsoleColor.Red;
            // print message to console
            Console.WriteLine(message);
            // set console font color to white again
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*
         * Waw-Funktion, Thins-Methode zeigt dem Benutzer alle verfügbaren Farben, aus denen ausgewählt werden würde
         */
        public static void PrintAvailableColorsAsList()
        {
            var availbleColorsLength = Enum.GetNames(typeof(ConsoleColor)).Length;
            Console.WriteLine();
            for (int i = 0; i < availbleColorsLength -1 ; i++)
            {
                Console.Write($"{i} - ");
                Console.ForegroundColor = (ConsoleColor)i;
                Console.Write($"{(ConsoleColor)i}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }


}
