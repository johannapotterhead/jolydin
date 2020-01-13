using System;

namespace textäventyr_johannaochsonia
{
    class Program
    {
        static void Main(string[] args)
        {

            StartGame();

        }
        static void One()
        {
            Console.WriteLine("I det här rummet kommer du att se ett bord och på bordet finns det en ask. I asken finns det en nyckel men för att kunna få tag på nyckeln måste du svara rätt på en gåta.\n\nGåtan lyder: Jag har många blad men är varken ett träd eller en blomma. Vad är jag?");
            string temp = Console.ReadLine().ToLower();

            if (temp == "bok" || temp == "en bok" || temp == "böcker")
            {
                Console.WriteLine(" Grattis!!, Du klarade av den första gåtan. Välkommen til rum två");
                Two();

            }
            else
            {
                FelSvar();
            }
        }
        static void Two()
        {
            Console.WriteLine(" Alla har det men ingen kan förlora det, vad är jag? \n");
            string temp = Console.ReadLine().ToLower();
            if ( temp == "skugga" || temp == "skuggor" )
            {
                Console.WriteLine(" Grattis!!, Du klarade av den första gåtan. Välkommen till rum tre");
                Three();
            }
            else
            {
                FelSvar();
            } 
        }
        static void Three()
        {
            Console.WriteLine("du ska välja mellan tre dörrar. En av dom här dörrarna leder dig till frihet.");

                Console.WriteLine("dörr 1 - en frätande syra, som dödar dig på direkten");
            Console.WriteLine("dörr 2 - en gas som smittar dig med cancer");
            Console.WriteLine("dörr 3 - en alligator som inte har ätit på ett år");

            string temp = Console.ReadLine().ToLower();
            if (temp == "dörr 2" || temp == "2" || temp == "en gas som smittar dig med cancer")
            {
                Console.WriteLine(" Grattis, du är fri. Tryck på en valfri tangent för att avsluta" );
                Console.ReadKey();
            }
            else
            {
                FelSvar();
            }
        }

        
        static void StartGame()

        {
            GameTitle();
            One();
        }
        static void GameTitle()
        {
            //Present game title and instructions
            Console.WriteLine(" välkommen till Huset av gåtor. I varje rum finns det en gåta som du måste svara rätt på för att kunna gå vidare." +
                " Du har ett försök på dig vid varje gåta och ifall du svarar fel så börjar du om från början. ");
        }
        static void FelSvar()
        {
            Console.WriteLine(" Grattis.......... du skrev fel svar. Vill du försöka igen? (J/N)");
            ConsoleKey response = Console.ReadKey(true).Key;
            if (response == ConsoleKey.J)
            {
                StartGame();
            }
            else if (response == ConsoleKey.N)
            {

            }
            else
            {
                Console.WriteLine("Klicka på tangent \"J\" eller \"N\"");
                FelSvar();
            }
        }

     }
}
