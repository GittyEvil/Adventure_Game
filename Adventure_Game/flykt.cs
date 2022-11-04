using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Flykt
    {
        public static void Flykten()
        {
            Console.Clear();
            Console.WriteLine("Du når dörren och katten fortsätter att följa dig");
            Console.WriteLine("det är ingen normal katt utan den lyser mörklila och pälsen liknar mer rymden än normal päls");
            Console.WriteLine("du smiter genom glipan du skapa förut");
            Console.WriteLine("du försöker lämna katten men den kommer bara tillbaka till dig som om den teleporterar");
            Console.WriteLine("du struntar i katten och kollar runt");
            Console.WriteLine("du känner genast igen dig och går tillbaka mot öppningen där du hoppa ner");
            Console.WriteLine("när du väl kommer till öppningen så är det helmörkt och du ser inget hål");
            Console.WriteLine("kan någon ha förföljt dig och blockerat öppningen för dig?");
            Console.WriteLine("katten lyser förvånansvärt upp grottan där ni är och du ser nu en liten håla snett framför dig");
            Console.WriteLine("du testar att trycka in dig i hålet men lyckas inte");
            Console.WriteLine("du sitter vid hålan och ser helt förstörd ut");
            Console.WriteLine("hur ska du ta dig ut nu");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Katten som nu inte gjort något hittils går igenom hålan");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DU är nu katten");
            Console.WriteLine("du börjar trycka dig in i den smala hålan medans killen sitter vid utgången");
            Console.WriteLine("det är kolsvart men du fortsätter krypa framåt ");
            Console.WriteLine("tillslut når du en större öppning och en halvmeter fram så fins det ytterligare 3 gångar");
            Console.WriteLine("Vilken av gångarna vill du ta?");
            Console.WriteLine("(V)änster  (M)itten  (H)öger  ");
            string input = Console.ReadLine();

            if(input.ToLower() == "v" || input.ToLower() =="vänster")
            {
                Console.WriteLine("du beger dig mot den vänstra gången och börjar krypa igenom");
                Console.WriteLine("det går rätt så fort tills att du kommit igenom gången");
                Console.WriteLine("när du väl kommit till slutet och kollar ut så ser du massa vargar som står upp");
                Console.WriteLine("du smyger in");
                Console.Clear();
                Console.WriteLine("du har nu blivit upptäckt av någon varulv");
                Console.WriteLine("varulven ryter och rusar mot dig och du står helt blickstilla som om du inte kan röra dig");
                Console.WriteLine("varulven biter mot dig och så fort den hugger in i din lilla kropp så förlorar du din syn men du hör en bomb gå av");
                Console.WriteLine("det enda du såg var en stor galax full med stjärnor och sen så vaknar du i killens knä där han satt och vänta");
                Console.ReadKey();
                Flykten();
            }

            if(input.ToLower() == "m" || input.ToLower() == "mitten" )
            {
                Console.WriteLine("du beger dig mot gången i mitten och börjar krypa igenom");
                Console.WriteLine("det är en väldigt trång gång och det känns som om du aldrig kommer någon vart");
                Console.WriteLine("du fortsätter krypa och trycka dig igenom");
                Console.WriteLine("gången smalnar av mer nu och du behöver verkligen trycka dig igenom");
                Console.WriteLine("du kommer tillslut igenom gången och är nu i en stooor mörk sal");
                Console.WriteLine("du ser hiver med guld och döda kroppar");
                Console.WriteLine("du inser att du är tillbaka i salen där du mötte killen");
                Console.WriteLine("du går tillbaka där du kom ifrån, dörren längst bort i rummet");
                Console.WriteLine("när du kommer fram går du igenom lilla luckan som finns i dörren");
                Console.WriteLine("du är nu i rummet där du bor.");
                Console.Clear();
                Console.WriteLine("du inser att killen sitter nog fortfarande och väntar på dig vid gången döendes, du plockar på dig en röd sten");
                Console.WriteLine("du beger dig tillbaka till killen, tar samma väg, genom salen och igenom glipan");
                Console.WriteLine("när du väl kommer fram så lyfter du på stenen och det börjar skaka i marken");
                Console.WriteLine("nu flyttas stenen sakta på sig och man kan börja se ut, det är mörkt ute");
                Console.WriteLine("stenen är nu borta");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("du är nu killen igen");
                Console.WriteLine("du tittar förvirrat på den skumma katten med den röda stenen");
                Console.WriteLine("du undrar hur katten lyckades med det där men du är samtidigt tacksam");
                Console.WriteLine("du börjar försöka ta dig upp men hittar inget lätt sätt att klättra upp");
                Console.WriteLine("du är fortfarande skadad och har väldigt svårt att röra dig utan att du stör läkningen");
                Console.WriteLine("katten ser detta och lyfter på sin sten igen och du blir fundersam på vad den tänker göra");
                Console.WriteLine("du lyfts nu sakta från marken och är nu uppe igen");
                Console.ReadKey();
                Console.Clear();
                Staden();
            }

            if(input.ToLower() == "h" || input.ToLower() == "höger")
            {
                Console.WriteLine("du beger dig mot den högra gången och börjar krypa igenom");
                Console.WriteLine("du tar dig snabbt igenom gången och är nu uppe vid skogen igen");
                Console.WriteLine("du står brevid den stora bumlingen din herre har lagt där när han lämna huset");
                Console.WriteLine("du använder dina krafter och lyfter snabbt undan stenen och killen sitter där och väntar");
                Console.WriteLine("du lyfter snabbt upp killen");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Du är nu killen och du blir fort förvirrad över hur du flyger tills att du ser den lysande katten");
                Console.WriteLine("du inser att det är en magisk katt från någon annan dimension");
                Console.ReadKey();
                Console.Clear();
                Staden();

            }


        }


        public static void Staden()
        {
            Console.WriteLine("Du och din nya kompanjon beger er mot staden där du ska få din belöning för att ha dödat draken ");
            Console.WriteLine("Solen börjar gå upp och det är inte alls lika mörkt");
            Console.WriteLine("Ni tar er lätt tillbaka och du kan börja se staden igen");
            Console.WriteLine("Ni går genom den stora ingången till staden och det är kolsvart");
            Console.WriteLine("alla hus är nedsläckta men ni rör er inåt");
            Console.WriteLine("finns endast en stor brasa mitt i och där sitter det folk runt om som sitter i svarta mantlar med huvor");
            Console.WriteLine("Du blir genast försiktig och är redo på att dra från staden");
            Console.WriteLine("Du ropar till byborna och frågar vad som försigår");
            Console.WriteLine("du får inget svar utan de alla ställer sig upp och vänder sig och stirrar mot dig och katten");
            Console.WriteLine("En av dem ställer sig längre fram och skriker att du ska ge tillbaka katten");
            Console.WriteLine("om inte kommer du ångra dig rejält");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("du svarar snabbt: Han är min!");
            Console.WriteLine("Figuren längst fram skriker anfall som svar");
            Console.WriteLine("Alla figurerna rusar mot dig med vapen och annat de gömt under mantlarna och skriker");
            Console.WriteLine("Du inser vilket dumt val du gjort och försöker springa ifrån");
            Console.WriteLine("du kollar bakom dig och ser att katten står kvar och du vänder dig för att ta upp katten");
            Console.WriteLine("Katten börjar lysa i din famn och du ser hur galaxen i pälsen börjar lysa starkare");
            Console.WriteLine("Du springer so fort du kan med dina skador och du märker hur figurerna i mantlar kommer närmare");
            Console.WriteLine("du når ingången men du snubblar på något");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("försöker ta dig upp igen");
            Console.WriteLine("när du kollar upp igen så står du upp och det ser ut som om du står i rymden");
            Console.WriteLine("du vänder dig mot där figurerna skulle komma ifrån och du ser hur de alla sprängs och du ser dig själv");
            Console.WriteLine("du står framför dem och du har den lysande katten i famnen");
            Console.WriteLine("men du står helt oskadad och alla figurerna dör och du klarar dig på något sätt från explosionen");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|        Spelet är           |");
            Console.WriteLine("|        avklarat            |");
            Console.WriteLine("|   du slutade spelet utan   |");
            Console.WriteLine("|         att dö             |");
            Console.WriteLine("|       med " + Program.currentPlayer.gold+  " guld.       |");
            Console.WriteLine("------------------------------");


            Console.ReadKey();
            Console.Clear();
        }
    }
}
