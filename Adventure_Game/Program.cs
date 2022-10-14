namespace Adventure_Game {
    internal class Program
    {
        
        public static Player currentPlayer = new Player();
        public static Boss currentBoss = new Boss();
        public static Skog encounters = new Skog();
       
        //main funktionen för allt 
        static void Main(string[] args) {

            Start();
            
        }

        //första fighten som kommer även starten av spelet.
        static void Skogen() {


            Console.WriteLine("Du står nu djupt inuti skogen och hör något som prasslar");
            Console.WriteLine("du blir överfallen av en stor varg.");
            Console.WriteLine("Hur vill du göra?,vill du attackera eller fly?");

            string val = Console.ReadLine();
            
            if (val == "attackera")
            {
                Skog.Förstafight();
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

        
   }
}