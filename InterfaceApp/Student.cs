using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        private byte _point;
        public byte Point { 
            get => _point;
            set
            {
                if (value>0 || value<=100)
                {
                    _point = value;
                }
            }
        }
        public Student(string fullname, byte point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id} Fullname: {Fullname} Point: {Point}");
        }
    }
}
