using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //พิมพ์ Hello World
            Console.WriteLine("Input number");
            //พิม input number
            var input =int.Parse(Console.ReadLine());
            //กำหนดให้ input = อ่านค่าจากคีย์บอร์ด แล้วแปลงเป็นตัวเลข(int.parse)
            //โจทย์ input
            var result = Multiply(input);
            //กำหนดให้ result เรียกใช้ Multiply โดยใส่ค่า input เข้าไป
            Console.WriteLine(result);
            //พิมพ์ค่า return หรือ output ออกมา
        }
        //ฟังก์ชัน Multiply
        static int Multiply(int number)
        {
            Console.WriteLine("Multiple");
            //พิมพ์ Multiple
            var result = 0;
            //กำหนดให้ result มีค่าเป็น 0
            for (int i = 1; i <= 12; i++)
            //เรียกวนรอบ ให้ i เป็น 1 ถ้า i น้อยกว่าหรือเท่ากับ 12 ให้เพิ่มค่า i ไป 1
            {
                Console.WriteLine(i * number);
                //พิมผมลัพธ์การคูณแม่สูตรคูณ
                result += i * number;
                //โจทย์ประมวลผล
                //ให้ result บวกค่าเข้าไป
                //เช่นจาก i = 1 แล้ว number เป็น 1
                //ก็จะ 1 * 1 ได้ 1 result จะเก็บค่า 1 บวกเข้าไป 0 + 1 result จะเท่ากับ 1
            }
            return result;
            //ส่งค่า output ออกไป
            //โจทย์ output
        }
    }
}
