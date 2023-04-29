

//- Welcome User To App
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This application was built by Eric Oliver");
Console.WriteLine("-----------------------------------------");
    //Creates a blank line because of no input, clever.
Console.WriteLine();


//- Ask for First Name
Console.Write("What is your first name? :  ");
string firstName;
firstName = Console.ReadLine();

//Note for some reason this program is completely disregarding my if statement
//I am moving on with the course for now as to not waste time on some simple syntax etc.
//Its extremely perplexing to me that its skipping over the if and then spits out everything in the else
// somehow, regardless of the input
if (firstName.GetType()!= typeof(string))
{
    Console.WriteLine("Please enter your first name only. ");  
}
else
{
    //- Greet User by name
    Console.WriteLine();
    Console.WriteLine("Hello " + firstName);
    Console.WriteLine("Thank you for using my application.");
    //Added a readline to keep terminal window open
    Console.ReadLine();
}

/*- Greet User by name
Console.WriteLine();
Console.WriteLine("Hello " + firstName);
Console.WriteLine("Thank you for using my application.");
//Added a readline to keep terminal window open
Console.ReadLine();*/