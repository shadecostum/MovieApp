using MovieApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

                while (true)
                {
                    Console.WriteLine("Menu:\n 1. Add Movie\n 2. Display Movies\n 3. Delete Movie\n 4. Exit");
                   
                    Console.Write("Enter your choice: ");

               
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                switch (choice)
                    {
                        case 1:
                                AddMovies movies = new AddMovies();
                        Console.WriteLine("=======");
                        break;

                        case 2:
                                DisplayMovies display=new DisplayMovies();
                        Console.WriteLine("=======");
                        break;

                        case 3:
                              DeleteMovies delete=new  DeleteMovies();
                                break;

                        case 4:
                            Console.WriteLine("Exiting program.");
                        Console.WriteLine("=======");
                        return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            
        }
     
    }
}

   
