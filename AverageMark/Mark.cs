namespace AverageMark;

public class Mark
{
    private void Test()
    {
        var marks = new int[5];
        var random = new Random();
        for (var a = 0; a < marks.Length; a++)
        {
            var mark = random.Next(1, 5);
            Console.WriteLine(mark);
            marks[a] = mark;
        }
    
        int Average(int[] marksArg)
        {
            var average = marksArg.Sum() / marksArg.Length;
            return average;
        }
    }

    private void Test2()
    {
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
            Console.WriteLine("Welcome mr {0}",directorSurname);
        }
    }
    
    
    
}