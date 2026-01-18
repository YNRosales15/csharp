// String interpolation combines multiple values into a single string literal by using a template and one or more interpolation expressions
// interpolation expression is indicated by an opening and closing curly brace symbol { }
// You can put any C# expression that returns a value inside the braces
// literal string becomes a template when it's prefixed by the $ character.

//string firstName = "Yessi";
//string message = $"Hello {firstName}!";

//int version = 11;
//string updateText = "Update to Windows";
// string message = $"{updateText} {version}";
//Console.WriteLine($"{updateText} {version}!");

//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data"); // $ allows to reference projectName. @ allows to use unescape \ character

// String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
// You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine("View English output:");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");
Console.WriteLine("\n");
Console.WriteLine($"{russianMessage}:");
Console.WriteLine($@"C:\Exercise\{projectName}\ru-RU\data.txt");