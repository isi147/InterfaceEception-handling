
//sealed - class in toreme etmesinin qarsini alir
//sealed class Human
//{

//}


//class Student : Human
//{

//}

// sealed method ise hemenclasdan
// torenen classda methodun ovveride etmeye icaze vermir

//class Student
//{
//    public virtual void study()
//    {
//        Console.WriteLine("Student study");
//    }
//}
//class GoodStudent:Student
//{
//    public override void study()
//    {
//        Console.WriteLine("Good study");
//    }
//}
//class FailedStudent:Student
//{
//    public sealed override void study()
//    {
//        Console.WriteLine("Failed study");
//    }
//}
//class DismissStudent : FailedStudent
//{
//    override 
//}






//Inheritance - is a  toreme
//Assocation - has a
//Inerface - can do implement etmek

//interfacein obyekti yardila bilmir
//evveller methodlari icerisinde body yazmaga icaze vermidir
//indi verir
//interface icerisindeki methodlar default olaraq publicdir
//interface icerisinde  property yazmaq olar ama public olaraq
//interface i implimentasiya edirsense mutleq sekilde hemen interfeysin
//butun metodlarini yazmalisan
//Interfeysler yazilis zamni I boyuk herifle baslamalidir


//class Program{
//    interface ISport
//    {
//        void SportMode();
//    }
//    interface IClassic
//    {
//        void ClassicMode();
//    }
//    class car : IClassic, ISport
//    {
//        public void ClassicMode()
//        {
//            Console.WriteLine("Classic mode");
//        }

//        public void SportMode()
//        {
//            Console.WriteLine("Sport mode");
//        }
//    }
//    static void Main(string[] args)
//    {
//        car car = new car();
//        ISport sport = new car();

//    }

//}







//using System.Xml;

//class Program
//{
//    interface IFighter
//    {
//        void Atack();
//        void Fire();
//        void Shot();
//        void Jump();
//    }
//    interface IKiller
//    {
//        void Kill();
//    }
//    interface IManage
//    {
//        void Control();
//        void CompleteMission();
//        void GatherPeople();
//    }

//    class Fighter : IFighter, IKiller
//    {
//        public virtual void Atack() { Console.WriteLine("Fighter Atack"); }

//        public void Fire() { Console.WriteLine("Fighter Fire"); }

//        public void Jump()
//        {
//            throw new NotImplementedException();
//        }

//        public void Kill() { Console.WriteLine("Fighter Kill"); }

//        public void Shot() { Console.WriteLine("Fighter Shot"); }

//    }
//    class Commander : Fighter, IManage
//    {
//        public void CompleteMission() { Console.WriteLine("Kommander Complete Mission"); }
//        public void Control() { Console.WriteLine("Kommander Control"); }
//        public void GatherPeople() { Console.WriteLine("Commander Gather Poeple"); }
//        public override void Atack() { Console.WriteLine("Commander Attack"); }
//    }




//    static void Main(string[] args)
//    {

//        //Fighter fighter = new Fighter();
//        //Commander commander = new Commander();



//        //List<IKiller> list = new List<IKiller>();
//        //list.Add(fighter);
//        //list.Add(commander);

//        //foreach (var item in list)
//        //{
//        //    item.Kill();
//        //}



//        IFighter killer = new Fighter();






//    }
//}



//class Program
//{

//interface Idemo1
//{
//    void foo();
//}
//interface Idemo2:Idemo1
//{
//    void boo();
//}

//class Temp : Idemo2
//{
//    public void boo()
//    {
//        throw new NotImplementedException();
//    }

//    public void foo()
//    {
//        throw new NotImplementedException();
//    }
//}

//interface IDemo1
//{
//    void Foo();
//}
//interface IDemo2
//{
//    void Foo();
//}

//class temp : IDemo1, IDemo2
//{
//    void IDemo1.Foo()
//    {

//    }
//    void IDemo2.Foo()
//    {

//    }

//}







//}

using ConsoleApp8;

class Program
{
    interface IManage
    {
        void Add(Student student);
        void Delete(Student student);
        Student GetById(int id);
        List<Student> GetAll();
    }


    class Student
    {
        public Student()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Average { get; set; }
        public Student(int id, string name, string surname, float average)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Average = average;
        }


        public override string ToString()
           => $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAverage:{Average}";
    }


    class Group : IManage
    {
        List<Student> students = new List<Student>();

 

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Delete(Student student)
        {
            students.Remove(student);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            throw new NotFoundException($"Student with ID {id} not found.");
        }
        public void ShowStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }

    static void Main(string[] args)
    {


        Student student1 = new Student(1, "Nazim", "Nazimli", 5.5f);
        Student student2 = new Student(2, "Fazil", "Fazilli", 5.5f);
        Student student3 = new Student(3, "Raci", "Racili", 5.5f);
        Student student4 = new Student(4, "Elmar", "Tugay", 5.5f);
        Student student5 = new Student(5, "Gunduz", "Yasinli", 5.5f);
        Student student6 = new Student(6, "Elvin", "Azimli", 5.5f);
        Student student7 = new Student(7, "Fikret", "Qoca", 5.5f);


        //List<Student> students = new List<Student>();
        //students.Add(student1);
        //students.Add(student2);
        //students.Add(student3);
        //students.Add(student4);
        //students.Add(student5);
        //students.Add(student6);
        //students.Add(student7);


        Group group = new Group();
        group.Add(student1);
        group.Add(student2);
        group.Add(student3);
        group.Add(student4);
        group.Add(student5);
        group.Add(student6);
        group.Add(student7);
            


        group.ShowStudents();

        group.GetById(14);





    }


}






