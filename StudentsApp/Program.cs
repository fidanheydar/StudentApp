using StudentsApp;
using System;
  bool isValidInput = false;

        do
        {
            Student student = new Student();

            Console.Write("Enter Fullname: ");
            student.Fullname = Console.ReadLine();

            Console.Write("Enter GroupNo: ");
            student.GroupNo = Console.ReadLine();

            Console.Write("Enter Age: ");
            string ageInput = Console.ReadLine();

            if (byte.TryParse(ageInput, out byte age) &&
                !string.IsNullOrWhiteSpace(student.Fullname) &&
                Student.CheckGroupNo(student.GroupNo))
            {
                student.Age = age;
                isValidInput = true;
                Console.WriteLine($"Fullname: {student.Fullname} - Age: {student.Age} - GroupNo: {student.GroupNo}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again!!.");
            }

        } while (!isValidInput);
    

