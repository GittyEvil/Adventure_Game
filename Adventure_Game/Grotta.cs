using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    //när man kommit in i grottan
    internal class Grotta
    {
        //funktion för när man står vid grottöppningen
        public static void Grottöppning()
        {
            Console.WriteLine("När du väl besegrat vargarna så ser du lite längre fram i skogen att det smalnar av.");
            Console.WriteLine("Du går åt det hållet och ser ett hål lite längre fram som liknar ett hål till en sorts grotta");
            Console.WriteLine("Du tänker genast att det är där draken ligger och beger dig mot hålet.");
            Console.ReadKey();
            Console.WriteLine("Hur vill du göra nu?");
            Console.WriteLine("(H)oppa   (S)tå kvar");
            string input = Console.ReadLine();

            if(input.ToLower() == "h" || input.ToLower() =="hoppa")
            {
                //tar sig in i grottan
                Grottan();
            }
            
            if(input.ToLower() == "s"|| input.ToLower() == "stå kvar")
            {
                Console.WriteLine("Du står kvar och ser ut som en idiot som tappat bort sig.");
                Console.ReadKey();
                //du kommer inte kunna backa utan du måste in tillslut för att fortsätta
                Grottöppning();
            }




        }

        //när du kommer längre in i grottan 
        static void Grottan()
        {
            Console.WriteLine("Du har nu hoppat ner i grottan och det är kolsvart.");
            Console.WriteLine("Det enda du kan göra när du väl kollat dig runt är att gå framåt.");
            Console.WriteLine("när du väl gått i den mörka grottan ett tag ser du en stooor port framför dig");
            Console.ReadKey();
            Console.WriteLine("Hur vill du göra nu?");
            Console.WriteLine("(G)å in   (S)tå kvar");

            string input = Console.ReadLine();

            if (input.ToLower() == "g" || input.ToLower() == "gå in")
            {
                Drake();
            }

            if (input.ToLower() == "s" || input.ToLower() == "stå kvar")
            {
                Console.WriteLine("Du står framför den stoora porten och väntar på bättre tider.");
                Console.ReadKey();
                Grottan();

            }
        }

        //bossfight
        static void Drake()
        {
            Console.WriteLine("Du tar tag i det stooora handtaget och drar med allt du har.");
            Console.WriteLine("Du hör hur det knarrar i den stooora porten och lyckas få upp en liten glipa");
            Console.WriteLine("När du väl smyger in i det mörka rummet");
            Console.WriteLine("Ser du hur det ligger högar med guld och andra juveler.");
            Console.WriteLine("du fortsätter röra dig som vad du tror är in i rummet och slår i något mjukt");
            Console.WriteLine("Känner efter med handen och inser att det är något levande, eller åtminstonde vad du tror är levande.");
            Console.WriteLine("Du snubblar även på något vapen när du fortsätter röra dig runt objektet");
            Console.WriteLine("Medans du ramla omkull väcker du den sovande draken och den börjar ryta");
            Console.ReadKey();
            Console.WriteLine("Hur vill du göra nu?");
            Console.WriteLine("(A)ttack   (S)pringa");

            string input = Console.ReadLine();
            if (input.ToLower() == "a" || input.ToLower() == "attack")
            {
                Console.WriteLine("Du gör dig redo för strid.");
                Console.ReadKey();
                //bossfight funktion



            }

            if (input.ToLower() == "s" || input.ToLower() == "springa")
            {
                Console.WriteLine("Du reser dig hastigt och försöker springa mot dörren innan draken hinner slå till");
                Console.ReadKey();
                Grottan();

            }

        }

        /*fight funktion åter igen, har inte hittat något där jag kan rätt av kopiera/använda
          den gamla fight funktionen direkt så jag får göra en kopia
        */
        static void Attack(int health, int power)
        {

            while (health > 0)
            {
                Console.Clear();

                Console.WriteLine("varg");
                Console.WriteLine("hp:" + health + "skada" + power);
                Console.WriteLine("----------------------");
                Console.WriteLine("(A)ttack       (B)lock");
                Console.WriteLine("(H)eal         (R)un  ");
                Console.WriteLine("----------------------");
                Console.WriteLine("Potions:" + Program.currentPlayer.potion + "Health:" + Program.currentPlayer.health); // tar in värdena från class Player



                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {

                }

                if (input.ToLower() == "b" || input.ToLower() == "block")
                {

                }

                if (input.ToLower() == "h" || input.ToLower() == "heal")
                {

                }

                if (input.ToLower() == "r" || input.ToLower() == "run")
                {

                }




            }



    }
}
