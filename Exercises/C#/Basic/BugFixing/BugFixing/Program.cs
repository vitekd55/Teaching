using System;

namespace BugFixing
{
    class Program
    {
        static void Main(string[] args)
        {

            // !--V PŘÍPADĚ POTŘEBY NAPIŠ--!


            // co je to komentář ?
            // komentáře jsou pouze poznámky, které nejsou nějak zpracovávány
            // V komentářích lze používat diakritiku

            // Toto je jednořádkový komentář
            
            /* Toto 
             * je 
             * Více 
             * řádkový
             * komentář
             */

            // Já většinou používám jednořádkové jako více řádkové


            // co je to modulo ? modulo je zbytek po celočíselném dělení značí se '%'
            // lze ho využít například pro zjištění zda je číslo sudé tzn. number % 2 == 0; -> číslo je sudé

            // Tip: pokud potřebuješ něco co neznáš, ale znáš něco co s tím souvisí zkus 'něco.' a v našeptávači hledej podle anglického názvu
            // příklad délka textu: 
            // anglicky délka je length případně  by šlo i size
            // pokud máme nějaký text nebo proměnnou
            // text.Length našeptávač obsahuje
            // pokud nic nenajdeš jdi googlit -> jedna z nejdůležitějších schopností programátora je rávě umět jednoduše a rychle vyhledat
            // řešení problému a zároveň ho pochopit a být připadně schopen si ho upravit svých jeho potřeb

            // Zadání:
            // 1. Opravit chyby aby byl kód spustitelný
            // 2. Pokusit se co nejvíc zjednodyšit a zefektivnit
            // 3. Napsat podmínku, která zjistí zda je age dělitelná číslem 3
            // 4. Vypiš délku jména tak, aby byla součástí výpisu nakonci
            // bonus: předělat proměnné(name, catColor, age, nameInitial,favouriteCharacter) tak aby je zadával uživatel

            nameInitial = "N"
            string name = "Adéla";
            double catColor = "black";
            string nameInitial = "A"
            int age = 20.0;
            bool favouriteCharacter = (char)36
            char isAdult = false;
           
            // Jelikož existuje více datových typů pro desetinné číslo musíme často hodnotu upřesnit pro konkrétní typ
            // U floatu se to dělá tak, že se na konec čísla přidá f
            float pi = 3.1459;
            
            if (catColor = "red")
            {
                catColor = "red"
            }
            else
            {
                catColor = "uknown";
            }
            else if (catColor = "white")
            {
                catColor = "white";
            }


            if (age >= 18)
            {
                int x = 10;
                isAdult = true;
            }
            x = x + 1;

            if (age < 18)
            {
                isAdult = false;
            }

            // Konzole má 2 části 
            // 1. Forgeround česky popředí = text
            // 2. Background česky pozadí

            // Úprava barvy textu konzole -> jen zajímavost
            Console.ForegroundColor = ConsoleColor.Green;
    
            // pojem syntaxe = to jak se něco píše/jak to vypadá
            // Pokud dáme před uvozovky znak $ lze do něj vkládat proměnné. syntaxe: {promena}
            // Pokud v textu použijeme \n  říkáme tím, že to co bude následovat bude na novém řádku
            Console.WriteLine($"My name is: {name}\nMy name starts with: {nameInitial}\nI have a cute cat with {catColor} fur\nAge of my programming teacher Vitek is {age}\nVitek can drink alcohol:{isAdult}\nMy favourite character is {favouriteCharacter}");
          
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
