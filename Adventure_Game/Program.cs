namespace Adventure_Game {
    internal class Program
    {

        class Player
        {
            public static int health;
            public static int dmg;
        }

        class Enemy
        {
            public static int ehealth;
            public static int edmg;
        }
        //main funktionen för allt 
        static void Main(string[] args) {
            int edmg = 5;
            int dmg = 20;
            int health = 200;

            Start();
            
        }

        //första fighten som kommer även starten av spelet.
        static void Skogen() {


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
                Console.WriteLine("du flydde...");
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
        static void attack(int health, int ehealth, int dmg, int edmg) {
            
            
            
          
            while (health > 0)
            {
                if(ehealth > 0)
                {
                    //attack
                
                    Console.WriteLine("monstret har"+ehealth+ "hp kvar.");
                    Console.WriteLine("du har tagit skada,"+health+"hp kvar.");
                    attack(health, ehealth, dmg, edmg);
                }
                    

                if(ehealth <0)
                {
                    Console.WriteLine("du dödade monstret");
                }

            }


        }
    }
}