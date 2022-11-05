using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{

    class Skog
    {
        public static Grotta encounter = new Grotta();
        //första fighten vid skogen
        public static void Förstafight()
        {
            Console.Clear();
            Console.WriteLine("vargen ser argt på dig medans den morrar mot dig");
            Console.WriteLine("du märker att den rör sig sakta mot dig");
            Console.WriteLine("samtidigt gör du dig redo för strid.");
            Console.ReadKey();
            Attack(15,1);
        }
        //själva fight funktionen
        static void Attack(int health, int power)
        {
            int potion = 5;
            int p = power;
            int hp = health; 
            while (hp > 0)
            {
                //visar motståndarens hp skada samt vad spelaren kan göra, visar hp och potions
                Console.Clear();
                Console.WriteLine("varg");
                Console.WriteLine("hp:" + hp + "skada" + p);
                Console.WriteLine("----------------------");
                Console.WriteLine("(A)ttack       (B)lock");
                Console.WriteLine("(H)eal         (R)un  ");
                Console.WriteLine("----------------------");
                Console.WriteLine("Potions:" + potion + "Health:" + Program.currentPlayer.health);
                string input = Console.ReadLine();

                if(input.ToLower() == "a" ||input.ToLower() == "attack")
                {
                    Console.WriteLine("du slår mot vargen med ditt vapen och vargen hugger tillbaka");
                    int damage = p - Program.currentPlayer.armorValue;
                    //kollar så att det inte kan bli negativ skada och att moståndaren inte helear spelaren
                    if(damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = Program.currentPlayer.weaponValue + 4;

                    Console.WriteLine("Du tar "+damage+" i skada och ditt hp är nu "+Program.currentPlayer.health+" och du gör "+attack+" mot vargen");
                    Program.currentPlayer.health-= damage;
                    hp -= attack;
                    Console.ReadKey();
                }
                if (input.ToLower() == "b" || input.ToLower() == "block")
                {
                    Console.WriteLine("När vargen slår på dig väljer du att blocka skadan");
                    int damage = (p/6) - Program.currentPlayer.armorValue;

                    if(damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = Program.currentPlayer.weaponValue + 1;
                    Console.WriteLine("du tar"+damage+" i skada och du ligger nu på"+Program.currentPlayer.health+" samt att du skadar"+attack+".");
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
                        Console.WriteLine("du helar"+potion+" hp.");
                        Program.currentPlayer.health += potion;
                        potion -= 1;
                        Console.ReadKey();
                    }
                }
                if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    Console.WriteLine("du försöker fly men samtidigt som du springer iväg så överfaller vargen dig och du dör...");
                    Console.ReadKey();

                }
                /*lyckas motståndaren få ner ditt hp till 0 eller under förlorar du och spelet avslutas, borde loopa om så den sätter dig vid start igen eller
                 åtminstonde börjar om fighten
                */
                if(Program.currentPlayer.health <=0)
                {
                    Console.WriteLine("Monstret lyckades få det bättre av dig och gjorde det sista slaget mot dig och du faller som en tapper hjälte..");
                }
                Console.ReadKey();

            }
            //om du lyckats få motståndarens hp ner till 0 eller under så vinner du striden
            if (hp<= 0)
            {
                Console.Clear();
                Console.WriteLine("Du står nu över vargens döda kropp och letar efter guld eller annat som du kan plocka på dig..");
                Console.WriteLine("du hittar: 300 guldmynt i pälsen på vargen");
                Program.currentPlayer.gold += 300;
                Console.ReadKey();
                Grotta.Grottöppning();
            }
                

        }




    }
}
