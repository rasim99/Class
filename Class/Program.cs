using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------Task1
            //Animal animal = new Animal("Colibri", "bird", "black",2);
            //animal.GetAnimalDetails(); 

            //--------------Task2
            //Building building = new Building("House MTK", 15, 100, "Baku");
            //building.GetBuildingDetails();


            //------------------Task3
            //Student student=new Student("Jhon","Doe",26,
            //    new[] { 100,95,96},
            //    new [] { 100,98,99},
            //   new[] { 90,87,98},100,
            //   new [] { true,false,true,false,true,true}
            //    );
            //student.GetResultGrades();

            //----------------Task4
            //Gun gun = new Gun("SV", 10, 8, 250, "sniper");
            //gun.Fire(); 
            //gun.Reload();
            //gun.GetDetailsGun();
            //Gun newGun = new Gun("FAMAS",25,24,300, "assault");
            //newGun.Fire();
            //newGun.GetDetailsGun();
            //newGun.Reload();
            //newGun.GetDetailsGun();


            //----------------------Task5 
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator(num1, num2);
            calculator.Caculate();
        }




    }


    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;

        public Animal(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }

        public void GetAnimalDetails()
        {
            Console.WriteLine($"animal-name : {name} animal-breed: {breed}  animal-color :{color} animal-age : {age}");
        }
    }

    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;

        public Building(string name, int height, int area, string adress)
        {
            this.name = name;
            this.height = height;
            this.area = area;
            this.adress = adress;


        }

        public int GetBuildingSize()
        {
            return height * area;
        }

        public void GetBuildingDetails()
        {
            Console.WriteLine($"{name} {height} {area} {adress}" + "  " + GetBuildingSize());
        }


    }



    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public int[] homeworkGrades;
        public int[] projectGrades;
        public int[] quizGrades;
        public int finalGrade;
        public bool[] continutiy;

        public Student(string name, string surname, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continutiy)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.homeworkGrades = homeworkGrades;
            this.projectGrades = projectGrades;
            this.quizGrades = quizGrades;
            this.finalGrade = finalGrade;
            this.continutiy = continutiy;
        }

        public int GetAvarageGrades(int[] grades)
        {
            int gradesSum = 0;
            foreach (var gradesItem in grades)
            {
                gradesSum += gradesItem;
            }
            return (gradesSum) / grades.Length;
        }
        public int GetCountOfAttended(bool[] attendeds)
        {
            int attendedCount = 0;
            foreach (var attendedItem in attendeds)
            {
                if (attendedItem)
                {
                    attendedCount++;
                }
            }
            return (attendedCount * 100) / attendeds.Length;
        }

        public void GetResultGrades()
        {
            int homeworkGrade = GetAvarageGrades(homeworkGrades);
            int projectGrade = GetAvarageGrades(projectGrades);
            int quizGrade = GetAvarageGrades(quizGrades);
            int continutyGrade = GetCountOfAttended(continutiy);
            int totalResult = (homeworkGrade * 20) / 100 + (projectGrade * 20) / 100 + (quizGrade * 20) / 100 + (continutyGrade * 10) / 100 + (finalGrade * 30) / 100;
            GetDegresType(totalResult);
        }
        public void GetDegresType(int totalResult)
        {

            if (totalResult >= 95)
            {
                Console.WriteLine($"{name} {surname} {totalResult} ---- HIGH HONOR");
            }
            else if (totalResult >= 85)
            {
                Console.WriteLine($"{name} {surname} {totalResult} ----  HONOR");

            }
            else if (totalResult >= 65)
            {
                Console.WriteLine($"{name} {surname} {totalResult} ---- NORMAL ");

            }
            else
            {
                Console.WriteLine($"{name} {surname} {totalResult} ---- FAIL");

            }
        }
    }


    public class Gun
    {
        public string gunName;
        public int maxCapacity;
        public int currentBullet;
        public int totalBullet;
        public string type;

        public Gun(string gunName, int maxCapacity, int currentBullet, int totalBullet, string type)
        {
            this.gunName = gunName;
            this.maxCapacity = maxCapacity;
            this.currentBullet = currentBullet;
            this.totalBullet = totalBullet;
            this.type = type;
            if (currentBullet > maxCapacity)
            {
                Console.WriteLine("currentBullet cannot lot then maxCapacity");
            }

        }


        public int Fire()
        {

            if (type == "assault")
            {
                currentBullet = 0;
            }
            if (type == "sniper")
            {
                currentBullet = currentBullet - 1;
            }
            return currentBullet;
        }


        public void Reload()
        {
            if (currentBullet != maxCapacity)
            {
                if (totalBullet > 0)
                {



                    int temp = maxCapacity - currentBullet;
                    if (totalBullet >= temp)
                    {
                        currentBullet += temp;
                        totalBullet -= temp;
                    }
                    else
                    {
                        currentBullet += totalBullet;
                        totalBullet = 0;
                    }


                }
                else
                {
                    Console.WriteLine("have not enought bullet");
                }
            }

            else
            {
                Console.WriteLine("Full Charged");
            }


        }

        public void GetDetailsGun()
        {
            Console.WriteLine($"Gun-Name :{gunName}   maxCapacity :{maxCapacity}   currentBullet :{currentBullet} totalBullet :{totalBullet}  type {type}:");
        }
    }


    public class Calculator
    {
        public int num1;
        public int num2;

        public Calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void Caculate()
        {
            Console.WriteLine("enter operator");
        Initalizie: string _operator = Console.ReadLine();
            switch (_operator)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num2 - num1);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num2 / num1);
                    break;
                default:
                    Console.WriteLine("enter correct operator");
                    goto Initalizie;
                   
            }


        }
    }


}


