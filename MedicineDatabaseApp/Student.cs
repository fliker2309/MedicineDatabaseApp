using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabaseApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Borndate { get; set; }
        public string Sex { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string Specialty { get; set; }
        public bool IsOffline { get; set; }
    }

}
