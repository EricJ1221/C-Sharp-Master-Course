// Yes - 2 , 18, 2854, -9
// No - 2.5, - 1.7

int age = 0;

age = 43;

int ageInTenYears = age + 10;

// two billion +/-
// Signed 32-bit integer, Int32
// unsigned - 4 billion
// bit - 0 or 1
// byte - 8 bits - 00000000
// 1, 11, 111


Console.WriteLine(age); 
Console.WriteLine(ageInTenYears);

Console.WriteLine(age / 2);
// 43/2 is rounded down to 21

Console.WriteLine(age / 3);
// 43/3 is rounded down to 14

Console.WriteLine(age / 3.0);
// 43/3.0 is 14.33333333333333333

// how to check the type of our variable

//age = age/3.0;
Console.WriteLine(age.GetType());
Console.WriteLine(age.ToString());