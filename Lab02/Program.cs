/*
 * Student ID :1690700685
 * Name       :Witul Thawon
 * Section    :129A
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name:  {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP:  {currentHp} / {maxHp}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp}  / {maxHp}");
            Console.WriteLine($"HP Percent 47%");

            Console.WriteLine("======PART B: HERO NAMES=======/n");
            string heroName = "Armmy";
            int heroHp = 110;
            float heroAtk = 18;
            double heroCritRate = 16.5;
            char heroRank = 'B';
            Console.WriteLine();
            Console.WriteLine("/n____HERO NO. 1____");
            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"HP: {heroHp}");
            Console.WriteLine($"ATK: {heroAtk}");
            Console.WriteLine($"CRIT RATE: {heroCritRate}");
            Console.WriteLine($"RANK: {heroRank}");

            string AssasinName = "Weir";
            int AssasinHp = 120;
            float AssasinAtk = 20;
            double AssasinCritRate = 19.5;
            char AssasinRank = 'A';
            Console.WriteLine();
            Console.WriteLine("/n____HERO NO. 2____");
            Console.WriteLine($"AssasinName: {AssasinName}");
            Console.WriteLine($"AssasinHP: {AssasinHp}");
            Console.WriteLine($"AssasinATK: {AssasinAtk}");
            Console.WriteLine($"AssasinCRIT RATE: {AssasinCritRate}");
            Console.WriteLine($"AssasinRANK: {AssasinRank}");

            string CarryName = "Myja";
            int CarryHp = 150;
            float CarryAtk = 25;
            double CarryCritRate = 22.5;
            char CarryRank = 'S';
            Console.WriteLine();
            Console.WriteLine("/n____HERO NO. 3____");
            Console.WriteLine($"CarryName: {CarryName}");
            Console.WriteLine($"CarryHP: {CarryHp}");
            Console.WriteLine($"CarryATK: {CarryAtk}");
            Console.WriteLine($"CarryCRIT RATE: {CarryCritRate}");
            Console.WriteLine($"CarryRANK: {CarryRank}");

            string FighterName = "Farm";
            int FighterHp = 200;
            float FighterAtk = 16;
            double FighterCritRate = 20;
            char FighterRank = 'C';
            Console.WriteLine();
            Console.WriteLine("/n____HERO NO. 4____");
            Console.WriteLine($"FighterName: {FighterName}");
            Console.WriteLine($"FighterHP: {FighterHp}");
            Console.WriteLine($"FighterATK: {FighterAtk}");
            Console.WriteLine($"FighterCRIT RATE: {FighterCritRate}");
            Console.WriteLine($"FighterRANK: {FighterRank}");



























        }

    }
}
