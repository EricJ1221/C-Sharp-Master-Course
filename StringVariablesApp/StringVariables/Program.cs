

//type    name   =  initial value
string firstName = string.Empty;
string lastName = string.Empty;

firstName =  "Eric";
lastName = "Oliver";

// "" is known as a string literal
//Console.WriteLine(firstName + " " + lastName);

//String Interpolation example
Console.WriteLine($"{firstName} {lastName}");