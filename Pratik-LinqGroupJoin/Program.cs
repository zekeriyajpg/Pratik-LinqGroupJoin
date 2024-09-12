using Pratik_LinqGroupJoin;

List<Student> students = new List<Student>()
{
    new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 }, // Ali belongs to class 1 (Ali, 1. sınıfa ait)
    new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 }, // Ayşe belongs to class 2 (Ayşe, 2. sınıfa ait)
    new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 }, // Mehmet belongs to class 1 (Mehmet, 1. sınıfa ait)
    new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 }, // Fatma belongs to class 3 (Fatma, 3. sınıfa ait)
    new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 } // Ahmet belongs to class 2 (Ahmet, 2. sınıfa ait)
};


// Sample data for classes (Sınıflar için örnek veri seti)
List<Class> classes = new List<Class>()
{
    new Class { ClassId = 1, ClassName = "Matematik" }, // Class 1: Mathematics (1. sınıf: Matematik)
    new Class { ClassId = 2, ClassName = "Türkçe" }, // Class 2: Turkish (2. sınıf: Türkçe)
    new Class { ClassId = 3, ClassName = "Kimya" } // Class 3: Chemistry (3. sınıf: Kimya)
};

// LINQ Group Join query (LINQ Group Join sorgusu)
var result = from cls in classes
             join stu in students on cls.ClassId equals stu.ClassId into studentGroup
             select new
             {
                 ClassName = cls.ClassName, // Class name (Sınıf adı)
                 Students = studentGroup.Select(s => s.StudentName) // Students in the class (Sınıftaki öğrenciler)
             };

// Output the results (Sonuçları yazdır)
foreach (var item in result)
{
    Console.WriteLine($"Sınıf: {item.ClassName}"); // Print the class name (Sınıf adını yazdır)
    foreach (var student in item.Students)
    {
        Console.WriteLine($"  Öğrenci: {student}"); // Print each student in the class (Sınıftaki her öğrenciyi yazdır)
    }
}