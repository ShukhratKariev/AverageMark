// See https://aka.ms/new-console-template for more information


namespace AverageMark;

static class Program
{
    static void Main(string[] args)
    {
        // var myFavoriteMovies = new string[5];
        //
        // for (var i = 0; i < myFavoriteMovies.Length; i++)
        // {
        //     Console.WriteLine($"Enter the movie No. {i + 1} please");
        //     myFavoriteMovies[i] = Console.ReadLine();
        // }
        //
        var myFavMoviesWithDirectors = new string[2, 2]
        {
            { "Lotr", "Peter Jackson" },
            { "Interstellar", "Christopher Nolan" },
        };
        
        for (var j = 0; j < myFavMoviesWithDirectors.GetLength(0); j++)
        {
            for (var k = 0; k < myFavMoviesWithDirectors.GetLength(1); k++)
            {
                Console.WriteLine(myFavMoviesWithDirectors[j, k]);
            }
        }


        


        // var fileName = "";
        // var extensions = new string[5]
        // {
        //     ".pdf", ".txt", ".sln", ".csproj", ".cs"
        // };
        //
        // Console.WriteLine("Enter file name please:");
        // fileName = Console.ReadLine();
        // foreach (var format in extensions)
        // {
        //     if (fileName.Contains(format))
        //     {
        //         Console.WriteLine("Success!");
        //         break;
        //     }
        // }


        // var myArray = new int[5]
        // {
        //     1, 2, 3, 4, 5
        // };
        // var evenCounter = 0;
        // foreach (var num in myArray)
        // {
        //     if (num % 2 == 0)
        //     {
        //         evenCounter++;
        //     }
        // }
        //
        // Console.WriteLine(evenCounter);



        // string[,] kek =
        // {
        //     { "Гарри Поттер", "Домик", "Фильм" },
        //     { "Любимый режисер1", "Любимый режисер2", "Любимый режисер3" }
        // };


        // string[,] arr = { { "Аватар", "Batman", "Титаник" }, { "James Cameron", "hz kto", "eshe kto-to" } };
        //
        // foreach (var item in arr)
        // {
        //     Console.WriteLine(item);
        // }
        //
        //
        // string[,] films = { {"film1","film2","film3" },{"autor1","autor2","autor3"} };
        // int columns = films.GetUpperBound(1) + 1;
        // for (int i = 0; i < films.Length; i++)
        // {
        //     for (int j = 0; j < columns; j++)
        //     {
        //         Console.Write($"{films[i, j]} \t");
        //     }
        //     Console.WriteLine();
        // }
        
        //
        // var extensions = new string[3] { ".txt", ".exe", ".pdf" };
        // Console.Write("Input file name: ");
        // var file = Console.ReadLine().ToLower();
        // foreach(var value in extensions)
        // {
        //     if (file.Contains(value))
        //     {
        //         Console.WriteLine("Success!");
        //         break;
        //     }
        // }
        
        
        var directorName = "Elon";
        var directorSurname = "Musk";
        var name = "";
        var surname = "";
        Console.WriteLine("Enter the name please:");
        name = Console.ReadLine();
        Console.WriteLine("Enter the surname please:");
        surname = Console.ReadLine();
        if (name.Contains(directorName) && surname.Contains(directorSurname))
        {
            Console.WriteLine("Welcome Mr. {0}",directorSurname);
        }
        else
        {
            Console.WriteLine("Hi {0} {1}", name, surname);
        }

        
        
        
        
        // string[] extensions2 = new string[3] { ".txt", ".exe", ".pdf" };
        // Console.Write("Input file name: ");
        // string file2 = Console.ReadLine().ToLower();
        // foreach (string extension in extensions)
        // {
        //     if (file.EndsWith(extension))
        //     {
        //         Console.WriteLine("Success!");
        //     }
        // }
    }
}