using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adventure_Game
{
    //när man kommit in i grottan
    class Grotta
    {
        //funktion för när man står vid grottöppningen
        public static Flykt encounters = new Flykt();
        public static void Grottöppning()
        {
            Console.Clear();
            Console.WriteLine("När du väl besegrat vargen så ser du lite längre fram i skogen att det smalnar av.");
            Console.WriteLine("Du går åt det hållet och ser ett hål lite längre fram som liknar ett hål till en sorts grotta");
            Console.WriteLine("Du tänker genast att det är där draken ligger och beger dig mot hålet.");
            Console.ReadKey();
            Console.WriteLine("Hur vill du göra nu?");
            Console.WriteLine("(H)oppa   (S)tå kvar");
            string input = Console.ReadLine();

            if (input.ToLower() == "h" || input.ToLower() == "hoppa")
            {
                //tar sig in i grottan
                Grottan();
            }

            if (input.ToLower() == "s" || input.ToLower() == "stå kvar")
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
            Console.Clear();
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
            Console.Clear();
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
                Attack_drake(50, 3);



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
        static void Attack_drake(int health, int power)
        {
            int potion = 5;
            while (health > 0)
            {
                Console.Clear();

                Console.WriteLine("Drake");
                Console.WriteLine("hp:" + health + "skada" + power);
                Console.WriteLine("----------------------");
                Console.WriteLine("(A)ttack       (B)lock");
                Console.WriteLine("(H)eal         (R)un  ");
                Console.WriteLine("----------------------");
                Console.WriteLine("Potions:" + potion + "Health:" + Program.currentPlayer.health); // tar in värdena från class Player



                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    int attack = Program.currentPlayer.weaponValue + 4;
                    int dmg = power - Program.currentPlayer.armorValue;
                    if (dmg < 0)
                    {
                        dmg = 0;
                    }

                    Console.WriteLine("du SPRINGER mot draken, höjer ditt vapen samt skriker mot draken och");
                    Console.WriteLine("drar in vapnet i drakens hårda hud.");
                    Console.WriteLine("draken tar " + attack + " i skada när du dragit svärdet i magen på den");

                    Console.WriteLine("Samtidigt som svärdet går igenom drakens hud höjer draken en av sina tassar och");
                    Console.WriteLine("slår med klorna mot dig och du tar " + dmg + " skada och ditt hp ligger nu på: " + Program.currentPlayer.health+ ".");
                    Program.currentPlayer.health -= dmg;
                    health -= attack;
                    Console.ReadKey();

                    
                }

                if (input.ToLower() == "b" || input.ToLower() == "block")
                {
                    Console.WriteLine("Draken höjer sin högra tass och slår med klorna mot dig");
                    Console.WriteLine("Du höjer vapnet som skydd och lyckas blocka slaget");

                    Console.WriteLine("du ligger pressad med en tung klo på dig men lyckas nätt och jämt slå bort den");
                    Console.WriteLine("du är svettig och sjukt trött men lyckas ställa dig upp");
                    Console.ReadKey();
                }

                if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (potion == 0)
                    {
                        Console.WriteLine("i panik letar du efter potions men inser att du inte har några kvar utan en tom flaska.");
                        Console.ReadKey();
                    }
                    else
                    {
                           Console.WriteLine("du tar fram en health potion och tar bort korken");
                        Console.WriteLine("du helar " + potion + "hp.");
                        Program.currentPlayer.health += potion;
                        potion -= 1;
                        Console.ReadKey();
                    }
                }

                if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    Console.WriteLine("du vet inte om du skulle kunna döda denna drake och försöker fly");
                    Console.WriteLine("du springer mot dörren och glider lätt igenom glipan du öppnade innan");
                    Drake();
                }

                if(health <= 0 )
                {
                    Console.Clear();
                    Console.WriteLine("Du lyckades döda draken nätt och jämnt");
                    Console.WriteLine("Du skär av drakens huvud och lägger den i en säck du fick med dig innan äventyret.");
                    Console.WriteLine("du kommer ihåg att ditt uppdrag du fick var att döda draken och ta dig ut levande");
                    Console.WriteLine("så du börjar leta efter en utgång samtidigt som du plockar på dig det du kan få upp");
                    Console.WriteLine("du lyckas plocka på dig 3000 guldmynt");
                    Program.currentPlayer.gold += 3000;
                    Console.WriteLine("du har nu "+ Program.currentPlayer.gold+" mynt.");

                    Console.Clear();
                    Console.WriteLine("du kollar dig runt om i den stora salen och fortsätter att gå längre in");
                    Console.WriteLine("du ser hur det ligger massor av skelett runt i salen och tänker genast att de som gav dig uppdraget");
                    Console.WriteLine("har lurat dig och har bara försökt döda dig");
                    Console.WriteLine("när du väl går djupare in så märker du att du har gått väldigt länge och det känns som om du inte kommit någon vart");
                    Console.WriteLine("du testar att gå tillbaka där du kom i från");
                    Console.WriteLine("går och går och det känns som att dörren du kom in i aldrig kommer närmare");
                    Console.WriteLine("du börjar springa mot dörren");
                    Console.WriteLine("ingenting händer.");
                    Console.WriteLine("du vaknar igen av du ligger vid draken du döda men nu har du en katt brevid dig");
                    Console.WriteLine("katten sitter och kollar på skumt");
                    Console.WriteLine("du kollar på draken och inser direkt vad du gör här och försöker ta dig mot dörren återigen");
                    Console.WriteLine("du börjar gå");
                    Console.WriteLine("denna gång känns det som att du faktiskt kommer närmre dörren");
                    Console.WriteLine("kan det vara katten som följer dig?");
                    Console.ReadKey();
                    Flykt.Flykten();


                }

                
                if(Program.currentPlayer.health <= 0) {
                    Console.Clear();
                    Console.WriteLine("du dog");
                    Console.ReadKey();
                    Drake();
                }


            }



        }
    }
}
