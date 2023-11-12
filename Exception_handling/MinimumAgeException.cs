using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    //מחלקת חריגים משלי
    public  class MinimumAgeException:Exception
    {

        public MinimumAgeException() : base() { }   

        public MinimumAgeException(string message) : base(message) { }

        public MinimumAgeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
