// --------- Divide By Zero! ----------


using System.Data;

static double Divide(double x, double y)
{
    // Write your code here!
    if (y == 0.0)
    {
        throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
    }
    else
    {
        return x / y;
    }

}

// Test out your Divide() function here!


// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    // Write your code here!
    
    if (fileName == null || fileName == "")
    {
        throw new ArgumentNullException("The file is empy");


    }
    else if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
    {
        return 1;
    }
    else
    {
        return 0;
    }
    
}

// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

Console.WriteLine(Divide(5,2));


