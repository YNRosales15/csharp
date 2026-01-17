Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyi-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


// Use escape sequences when you need to insert character literal string such as:
// new line \n, double quotation marks \"
//use a escape character for the backlash \\ when you need to use a backlash in all other scenarios
// use @ directive to create a verbatim string literal that keeps all the whitespace formatting and backslash characters in string
// use \u plus four character code to represent unicode characters (UTF-16) in a string

