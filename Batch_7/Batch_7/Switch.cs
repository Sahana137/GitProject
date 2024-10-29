namespace Batch_7
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the roll number");
            int student = int.Parse(Console.ReadLine());
            switch (student)
            {
                case 1:
                    {
                        Console.WriteLine("student 1 : sahana");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("student 2 : sakshi");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("student 1 : rachana");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("student 1 : vaishnavi");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("student 1 : shashvitha");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("student 1 : sahana");
                        break;
                    }
            }
        }
    }
}
