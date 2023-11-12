using System.Net;
namespace DownloadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Please enter remote file address");
           
            string? remoteFile = Console.ReadLine(); //https://i.pinimg.com/originals/f6/9b/9a/f69b9aa3e004ddbb4664934b12c8d6a6.gif

            Console.WriteLine("Please enter the local file name");
            string? fileName = Console.ReadLine();//"success.gif"
            
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile(remoteFile, $@"C:\Users\Home\Downloads\{fileName}");
                client.DownloadFile(new Uri(remoteFile), $@"C:\Users\Home\Downloads\1{fileName}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"{e.GetType()}:{e.Message}");
            }
            catch (WebException e)
            {
                Console.WriteLine($"{e.GetType()}:{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}:{e.Message}");
            }
        }
    }
}