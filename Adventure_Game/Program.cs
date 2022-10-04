namespace Adventure_Game
{
    internal class Program
    {
        private static int ehealth;
        private static int edmg;
        private static int health;
        private static int dmg;

       
        //main funktionen för allt 
        static void Main(string[] args) {
            /*int edmg = 5;
            int dmg = 20;
            int health = 200;
            */

            Start();
            
        }

        //första fighten som kommer även starten av spelet.
        static void Skogen() {
            int varg = 100;
            int varghealth = 50;


            Console.WriteLine("Du står nu djupt inuti skogen och hör något som prasslar");
            Console.WriteLine("du blir överfallen av ett par vargar.");
            Console.WriteLine("Hur vill du göra?,vill du attackera eller fly?");

            string val = Console.ReadLine();
            
            if (val == "attackera")
            {
                attack();
            }
            else if (val == "fly")
            {
                Start();
            }

        }

        //start funktionen
        static void Start() {

            //Lite backstory/ inledning på spelet
            Console.WriteLine("Du är en hjälte som fått uppdrag att döda en drake i en skog vid namn Nargusskogar...");
            Console.WriteLine("När du väl vandrar dit så är allt lugnt med fin väg på vägen dit...");
            Console.WriteLine("När du väl är framme så ser skogen ut att vara väldigt tät och mörk...");
            Console.WriteLine("Du blir spänd av skogens mörka känsla men går ändå in...");

            Console.WriteLine("Du står nu vid ingången av skogen, vad vill du göra?");
            Console.WriteLine("Vill du fortsätta inåt i skogen eller vill du stå kvar?");

            string gå_Framåt = Console.ReadLine();

            if (gå_Framåt == "gå framåt")
            {
                Skogen();
            }

            if (gå_Framåt == "stå kvar")
            {
                Start();
            }



        }

        //attack funktion, ska fungera för alla fighter framöver.
        static void attack()
        {
            
            ehealth = 50;
            edmg = 5;
            health = 200;
            dmg = 25;
          
            while (health > 0)
            {
                if(ehealth > 0)
                {
                    ehealth--;
                }

                if(ehealth <0)
                {
                    Console.WriteLine("du dödade monstret");
                }
            }


        }
    }
}