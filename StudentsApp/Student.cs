using System;

namespace StudentsApp
{
    public class Student
    {
        private string _fullname;
        private byte _age;
        private string _groupNo;

        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("Invalid fullname format. Please enter again!!.");
                    Console.Write("Enter Fullname: ");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }

        private static bool CheckFullname(string fullname)
        {
            return !string.IsNullOrWhiteSpace(fullname) && fullname.Split(' ').Length == 2;
        }


        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 4)
                return false;

            if (!char.IsUpper(groupNo[0]) || !char.IsDigit(groupNo[1]) || !char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3]))
                return false;
            return true;
        }

        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Invalid GroupNo format. Please enter again!!.");
                    Console.Write("Enter GroupNo: ");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }
    }
}