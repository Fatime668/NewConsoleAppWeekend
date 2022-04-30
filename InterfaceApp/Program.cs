using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Fatima",100);
            Student stu1 = new Student("Gunel",90);


            Console.WriteLine("Fullname daxil edin: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Email daxil edin: ");
            string email = Console.ReadLine();
            string pass;
            
            User user = new User(fullname,email);
            bool check = true;
            do
            {
                Console.WriteLine("Password daxil edin: ");
                pass = Console.ReadLine();
            } while (!user.PasswordChecker(pass));
            user.Password = pass;
            do
            {
                Console.WriteLine("1.Show info");
                Console.WriteLine("2.Create new group");
                Console.WriteLine("3.New menu"); 
                
                switch (Console.ReadLine())
                {
                    case "1":
                        user.ShowInfo();
                        break;
                    case "2":
                        string groupno;
                        byte studentLimit;
                        do
                        {
                            Console.WriteLine("groupno daxil edin");
                            groupno = Console.ReadLine();

                        } while (!Group.CheckGroupNo(groupno));
                        do
                        {
                            Console.WriteLine("studentlimiti daxil edin");
                            studentLimit = Convert.ToByte(Console.ReadLine());
                        } while (studentLimit<0 || studentLimit>18);
                        Group gr = new Group(groupno, studentLimit);
                        gr.GroupNo = groupno;
                        gr.StudentLimit = studentLimit;
                        Console.WriteLine("GroupNo: " + gr.GroupNo + " " + "StudentLimit: " + gr.StudentLimit);
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("1. Show all students");
                            Console.WriteLine("2. Get student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("0. Quit");

                            switch (Console.ReadLine())
                            {

                                case "1":
                                    Student[] students = { stu, stu1 };

                                    foreach (Student student in students)
                                    {
                                        student.StudentInfo();
                                    }
                                    break;
                                case "2":
                                    Student[] students1 = { stu, stu1 };
                                    int id;
                                    id = Convert.ToInt32(Console.ReadLine());
                                    foreach (var item in students1)
                                    {
                                        if (item.Id == id)
                                        {
                                            Console.WriteLine("Id: " + item.Id + " " + "Fullname: " + item.Fullname + " " + "Point: " + item.Point );
                                            return;
                                        }
                                        else 
                                        {
                                            Console.WriteLine("Bele bir id-li telebe tapilmadi");
                                            return;
                                        }
                                       
                                    }
                                    break;
                                case "3":
                                    byte point;
                                    Console.WriteLine("Fullname daxil edin: ");
                                    string FullName = Console.ReadLine();
                                    do
                                    {
                                        Console.WriteLine("Point daxil edin: ");
                                        point = Convert.ToByte(Console.ReadLine());
                                    } while (point<0 || point >100);
                                    Student stu2 = new Student(FullName, point);
                                    stu2.Fullname = FullName;
                                    stu2.Point = point;
                                    stu2.StudentInfo();
                                    break;
                                default:
                                    break;
                                case "0":
                                    check = false;
                                    Console.WriteLine("End.");
                                    break;
                                    
                            }

                        } while (check);
                        break;
                    default:
                        break;
                }
            } while (check);
        }
    }
}
