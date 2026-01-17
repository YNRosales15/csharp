// String interpolation combines multiple values into a single string literal by using a template and one or more interpolation expressions
// interpolation expression is indicated by an opening and closing curly brace symbol { }
// You can put any C# expression that returns a value inside the braces
// literal string becomes a template when it's prefixed by the $ character.

//string firstName = "Yessi";
//string message = $"Hello {firstName}!";

int version = 11;
string updateText = "Update to Windows";
// string message = $"{updateText} {version}";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data"); // $ allows to reference projectName. @ allows to use unescape \ character

// String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
// You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.
