using System.Net;

namespace Exception_handling
{
    internal class Program
    {
        public static void Main()
        {
          Student student = new Student();
            Console.WriteLine(  "Please enter studnet name");
          
           
            bool ok = false;
            while(!ok)
            {
           
            {
                    try
                    {
                        student.Name = Console.ReadLine();
                        student.Age = int.Parse(Console.ReadLine());
                        ok = true;
                    }

                    catch(ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"invalid name  {ex.Message}");
                    }

                    catch(MinimumAgeException ex)
                    {
                        Console.WriteLine($"Invalid age {ex.Message}"  );
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(  $"unknown error {ex.Message} ");
                    }
                        
                   
                   
            }
           

               
            }

        }

        
    }
}
