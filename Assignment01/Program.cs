/*
 * Student ID :1690700685
 * Name       :Witul Thawon
 * Section    :129A
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Starlight Ascension"; 

            var heroName = "MyjaTV";
            var heroRank = 'B';
            int heroLevel = 12;
            float critChance = 0.30f;
            double staminaPrecise = 80.5;
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Rank        : {heroRank}");
            Console.WriteLine($"Level       : {heroLevel}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            double heroLevelAsDouble = heroLevel;
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;
            int staminaRounded = Convert.ToInt32(staminaPrecise);
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
