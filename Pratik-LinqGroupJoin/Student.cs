using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_LinqGroupJoin
{
    public class Student
    {
        public int StudentId { get; set; } // Unique ID of the student (Öğrencinin benzersiz kimliği)
        public string StudentName { get; set; } // Name of the student (Öğrencinin adı)
        public int ClassId { get; set; } // The class ID the student belongs to (Öğrencinin ait olduğu sınıf kimliği)

    }
    public class Class
    {
        public int ClassId { get; set; } // Unique ID of the class (Sınıfın benzersiz kimliği)
        public string ClassName { get; set; } // Name of the class (Sınıfın adı)
    }
}
