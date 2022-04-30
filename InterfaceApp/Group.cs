using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    class Group
    {
        private string _groupNo;
        public string GroupNo { 
            get => _groupNo; 
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        private byte _studentLimit;
        public byte StudentLimit { 
            get => _studentLimit;
            set 
            {
                if (value>=5 && value<=18)
                {
                    _studentLimit = value;
                }
            } 
        }
        private Student[] Students = new Student[0];
        public Group(string groupno, byte studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5)
            {
                if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
                {
                    if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (Students.Length<=StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
        }
        public bool GetStudents(int? id)
        {
            foreach (var item in Students)
            {
                if (item.Id == id)
                {
                    return true;
                }
            } 
            return false;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }

    }
}
