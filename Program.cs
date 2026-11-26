Console.Clear();
Console.WriteLine("Name: [ไกรศักดิ์ นามวิเศษ]");
Console.WriteLine("Course: Advanced Programming");
Console.WriteLine("Instructor: [ผม นายไกรศักดิ์ นามวิเศษ รหัสนักศึกษา68040249103]");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("โปรแกรมแนะนำตัวเอง");
Console.Write("โปรดบอกชื่อของคุณ: ");
string name = Console.ReadLine();
Console.WriteLine("สวัสดีครับ, " + name + "!");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("ขอบคุณที่ใช้โปรแกรมแนะนำตัวเอง!");

//ทดสอบสร้าง Function
void strLine(string strInput, int n)
{
    string strOutput = "";
    for (int i = 0; i < n; i++)
    {
        strOutput += strInput;
    }
    Console.WriteLine(strOutput+"\n");
}