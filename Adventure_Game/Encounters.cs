using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Encounters
    {

        public static void Förstafight()
        {
            Console.WriteLine("vargarna ser argt på dig medans de morrar mot dig");
            Console.WriteLine("du märker att de rör sig sakta mot dig och börjar omringa dig");
            Console.WriteLine("samtidigt gör du dig redo för strid.");
            Console.ReadKey();
            Attack(1,4);
        }

        static void Attack(int health, int power)
        {
            int p = power;
            int hp = health; 
            while (health > 0)
            {
                Console.Clear();
                Console.WriteLine("varg");
                Console.WriteLine("hp:" + hp+ "skada" + p);
                Console.WriteLine("----------------------");
                Console.WriteLine("(A)ttack (B)lock");
                Console.WriteLine("(H)eal   (R)un  ");
                Console.WriteLine("----------------");
                Console.WriteLine("Potions:" + Program.currentPlayer.potion + "Health:" + Program.currentPlayer.health);
                string input = Console.ReadLine();

                if(input.ToLower() == "a" ||input.ToLower() == "attack")
                {
                    Console.WriteLine("du slår mot vargarna med ditt vapen och vargarna hugger tillbaka");
                    int damage = p - Program.currentPlayer.armorValue;
                    if(damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = Program.currentPlayer.weaponValue + 4;

                    Console.WriteLine("Du tar "+damage+"i skada och ditt hp är nu"+health+"och du gör"+attack+"mot vargarna");
                    Program.currentPlayer.health-= damage;
                    hp -= attack;
                    Console.ReadKey();
                }
                if (input.ToLower() == "b" || input.ToLower() == "block")
                {
                    Console.WriteLine("När vargarna slår på dig väljer du att blocka skadan");
                    int damage = (p/6) - Program.currentPlayer.armorValue;
                    if(damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = Program.currentPlayer.weaponValue + 1;
                    Console.WriteLine("du tar"+damage+"du ligger nu på"+health+"samt att du skadar"+attack+".");
                    Console.ReadKey();
                }
                if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("i panik letar du efter potions men inser att du inte har några kvar utan en tom flaska.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("du tar fram en health potion och tar bort korken");
                        int potion = 5;
                        Console.WriteLine("du helar"+potion+"hp.");
                        Program.currentPlayer.health += potion;
                        Console.ReadKey();
                    }
                }
                if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    Console.WriteLine("du försöker fly men samtidigt som du springer iväg så överfaller vargarna dig och du dör...");
                    Console.ReadKey();

                }


            }


        }




    }
}
