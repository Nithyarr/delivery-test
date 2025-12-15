// See https://aka.ms/new-console-template for more information

//inheritence example
using Basic_OOPs;

class Food
{
    public string item = "Pizza";
    public void order()
    {
        Console.WriteLine("Tuuuuuuu!!");
    }
}
class Menu: Food
{
    public string type = "Veg";
}

class Program
{
    static void Main(string[] args)
    {
        Menu menu= new Menu();
        Console.WriteLine("Item: " + menu.item);
        Console.WriteLine("Type: " + menu.type);
        menu.order();

        Class1 clas1= new Class1();
        clas1.display();


        Console.WriteLine("*******************");
        Console.WriteLine(Demo.x);
        Demo d = new Demo();
        Console.WriteLine(d.y);

        //dictonary example
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Nithya");
        students.Add(2, "Arun");
        Console.WriteLine(students[1]);

        //stack 
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine(stack.Pop());

        //2D Array Example

        //Console.WriteLine("Enter rows and column of Matrices: ");
        //int Rows = Convert.ToInt32(Console.ReadLine());
        //int Columns = Convert.ToInt32(Console.ReadLine());


        //int[,] arr1 = new int[Rows, Columns];
        //int[,] arr2 = new int[Rows, Columns];
        //int[,] Result = new int[Rows, Columns];
        
        //Console.WriteLine("\nEnter ele for array 1:");
        //for (int i = 0; i < Rows; i++)
        //{
        //    for (int j = 0; j < Columns; j++)
        //    {
        //        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        
        //Console.WriteLine("\nEnter ele for array 2:");
        //for (int i = 0; i < Rows; i++)
        //{
        //    for (int j = 0; j < Columns; j++)
        //    {
        //        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
     
        //Console.WriteLine("\nSum of arrays:");
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Result[i, j] = arr1[i, j] + arr2[i, j];
        //        Console.Write($"{Result[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadKey();

        //linq to upper
        string[] names = { "nithya", "arun" };
        var upperNames = names.Select(n => n.ToUpper());
        foreach (var name in upperNames)
        {
         Console.WriteLine(name);
        }

        //LINQ Demo query method 
        List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 10, 3 }; 
        var result = numbers
            .Where(n => n % 2 == 0)               
            .Select(n => $"Even number: {n}")     
            .OrderBy(n => n);                     

        foreach (var item in result)
        {
         Console.WriteLine(item);
        }

        Console.WriteLine("*********************");
        
            Employee emp;

            emp = new Employee();
            emp.CalculateSalary();   // Basic salary calculation

            emp = new Manager();
            emp.CalculateSalary();   // Salary + bonus

            emp = new Developer();
            emp.CalculateSalary();   // Salary + overtime pay
        }
    }
