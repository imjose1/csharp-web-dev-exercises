//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

string word = "I would not, could not, in a box. I would not, could not with a fox." +
    "\r\nI will not eat them in a house. I will not eat them with a mouse.";

string[] newWord = word.Split("word");
Console.WriteLine(newWord);
Console.WriteLine(string.Join(",", newWord));
Console.WriteLine(string.Join(".", newWord));


Console.WriteLine("Hello, Strings!");

