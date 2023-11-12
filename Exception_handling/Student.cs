using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">when name dont start with capital letters or has digit in it</exception>
    /// <exception cref="MinimumAgeException"></exception>
    public class Student
    {
        //fields
        private string name;
        private int age;

        //properties
 //throws exception if name not valid
        public string Name { get => name; set { if (!ValidateName(value)) throw new ArgumentOutOfRangeException("Name Should start with capital letter and cnot contain digits"); name = value; } }
        //throws exception if age under 5
        public int Age { get => age; set { if (value < 5) throw new MinimumAgeException("age must be more than 5"); age = value; } } 
        public int Kita { get; set; }


        /// <summary>
        /// validate method for Name. Name must start with capital letter and not containg digit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        
        private bool ValidateName(string value)
        {
            return (value[0] >= 'A' && value[0] <= 'Z') && !(value.Any(x => x >= '0' && x <= '9'));
        }
    }
}
