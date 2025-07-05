// Declare variables
string name = string.Empty;
int age = 0;
int retirementage = 65;


// Prompt the user for input
Console.WriteLine("Please enter you name");
name = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearRemaining = retirementage - age;

// Output the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearRemaining}");



