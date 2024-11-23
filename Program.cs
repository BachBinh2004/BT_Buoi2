using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một danh sách chứa các đối tượng Student
            List<Student> students = new List<Student>
            {
                new Student(1, "Anh", 16),
                new Student(2, "Binh", 14),
                new Student(3, "Cuong", 15),
                new Student(4, "Duong", 17),
                new Student(5, "Ngan", 18)
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"Ma: {student.Ma}, Ten: {student.HoTen}, Tuoi: {student.Tuoi}");
            }
            Console.WriteLine();

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var studentsAge15to18 = from s in students
                                    where s.Tuoi >= 15 && s.Tuoi <= 18
                                    select s;

            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in studentsAge15to18)
            {
                Console.WriteLine($"Ma: {student.Ma}, Ten: {student.HoTen}, Tuoi: {student.Tuoi}");
            }
            Console.WriteLine();

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var studentsStartWithA = from s in students
                                     where s.HoTen.StartsWith("A")
                                     select s;

            Console.WriteLine("Danh sach hoc sinh co ten bat dau bang chu 'A':");
            foreach (var student in studentsStartWithA)
            {
                Console.WriteLine($"Ma: {student.Ma}, Ten: {student.HoTen}, Tuoi: {student.Tuoi}");
            }
            Console.WriteLine();

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            var totalAge = students.Sum(s => s.Tuoi);
            Console.WriteLine($"Tong tuoi cua tat ca hoc sinh: {totalAge}");
            Console.WriteLine();

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Tuoi).FirstOrDefault();
            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            Console.WriteLine($"Ma: {oldestStudent.Ma}, Ten: {oldestStudent.HoTen}, Tuoi: {oldestStudent.Tuoi}");
            Console.WriteLine();

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sortedStudents = students.OrderBy(s => s.Tuoi).ToList();

            Console.WriteLine("Danh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Ma: {student.Ma}, Ten: {student.HoTen}, Tuoi: {student.Tuoi}");
            }
            Console.ReadLine();
        }
    }
}
