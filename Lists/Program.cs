//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

List<int> integers = new List<int>{10,12,24,12,123,4,5,6,9,10};
List<string> words = new List<string> { "hello", "there", "you", "while do", "me" };
static int sumEven(List<int> arr)
{
    int total = 0;
    foreach (int integer in arr)
    {
        if (integer % 2 == 0)
        {
            Console.WriteLine(integer);
            total += integer;
        }
    }
    return total;
}

Console.WriteLine(sumEven(integers));

static void fiveLetter(List<string> arr)
{ 
    foreach(string letter in arr)
    {
        if (letter.Length == 5)
        {
            Console.WriteLine(letter);
        }
    }
}
//Console.WriteLine(fiveLetter(words);
