/*
* Student ID :1690700685
* Name       :Witul Thawon
* Section    :129A
* No.        :N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHP = 100;
            int monHp = 100;
            int atk = 100;

            Console.WriteLine("Adventure of Brian");
            Console.WriteLine(">=== Monster Encounter 1 <===");
            Console.WriteLine("ACTION A: ATTACK");
            Console.WriteLine("ACTION B: FLEE\n");

            // รับ input ผู้เล่น
            Console.Write("Choose your action: ");
            bool inputOk = char.TryParse(Console.ReadLine(), out char choice);

            // เช็คว่าผู้เล่นพิมพ์ถูกต้องมั้ย 1. ตัวอักษร, A, a หรือ b, B
            if (!inputOk || (choice != 'a' && choice != 'A' && choice != 'b' && choice != 'B'))
            {
                Console.WriteLine("Invalid input, Please choose between a, b");
            }
            else if (choice == 'a' || choice == 'A')
            {
                //ให้ทำอะไรเมื่อเลือก 1
                monHp -= atk;
                //ผู้เล่นโจมตีมอนต์ n หน่วย เลือดเหลือ ...
                if (monHp <= 0)
                {
                    Console.WriteLine($"Player attack monster with {atk} points, Monster defeated!!!"); //output เมื่อ HP เหลือ 0
                }
                else
                {
                    Console.WriteLine($"Player attack monster with {atk} points, Monster HP has {monHp}HP left."); //output เมื่อ HP เหลือมากกว่า 0
                }
            }
            else if (choice == 'b' || choice == 'B')
            {
                //ให้ทำอะไรเมื่อเลือก 2
                heroHP -= atk;
                //ผู้เล่นวิ่งหนีมอนต์ โดนโจมตี n หน่วย เลือดผู้เล่นเหลือ ...
            }
            else
            {
                Console.WriteLine("Timeout: You ran out of time");
            }

        }
    }
}
