# MultiplyBasic


## การนำไปใช้
ให้ทำการ clone โดยใช้

```
git clone https://github.com/taefreeze/MultiplyBasic.git

```
เข้าไปยัง Folder ของโปรแกรม \
เปิดด้วย Text Editor ที่ต้องการ เช่น Visual Studio Code\
CMD ก็ได้เช่นกัน\
พิมคำสั่ง

```
dotnet run

```

## การทำงานของโปรแกรม
โปรแกรมการคูณตัวเลขแบบแม่สูตรคูณ
* ผู้ใช้ใส่ตัวเลขที่ต้องการ (input)
* ระบบจะพิมผลการคูณของตัวเลขตั้งแต่ 1-12 (process)
* ระบบคืนค่าผลรวมของการคูณทั้งหมดออกมา (output)

## ตารางการทำงาน

| Code                                      | การทำงาน                                                       |
| ------------------------------------------|:--------------------------------------------------------------:|
| Console.WriteLine("Hello World!");        | พิม Hello World!                                                |
| Console.WriteLine("Input number");        | พิม Input Number!                                               |
| var input =int.Parse(Console.ReadLine()); | กำหนดให้ input รับค่าจากคีย์บอร์ดแล้วแปลงเป็นตัวเลข                     |
| var result = Multiply(input);             | ให้ result เรียกฟังก์ชัน Multiply โดยใส่ตัวแปร input เข้าไป             |
| Console.WriteLine(result);                | พิม output จาก result                                           |
| static int Multiply(int number)           | ฟังก์ชัน Multiply                                                 |
| Console.WriteLine("Multiple");            | พิมพ์ Multiple                                                   |
| var result = 0;                           | กำหนดให้ result มีค่าเป็น 0                                        |
| for (int i = 1; i <= 12; i++)             | เรียกวนรอบ ให้ i เป็น 1 ถ้า i น้อยกว่าหรือเท่ากับ 12 ให้เพิ่มค่า i ไป 1      |
| Console.WriteLine(i * number);            | พิมผมลัพธ์การคูณแม่สูตรคูณ                                           |
| result += i * number;                     | ให้ result บวกค่าเข้าไป                                            |
| return result;                            | ส่งค่า output ออกไป                                               |