// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable / global scope
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If...Elase...statement - Decide to print pass or fail based on input
Console.WriteLine("******************* Simple IF Results *********************");
if (grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recomend student to student affair's office");
}
Console.WriteLine("******************* Simple IF Results End *********************");


// Complex If..Else if...statement - Decide to print letter based on grade value
Console.WriteLine("******************* Complex IF..ELSE IF Results *********************");

/* 
 * A: 86 - 100
 * B: 75 - 84
 * C: 65 - 74
 * C- : 51 - 64
 * F: less than 50
 */

// add Global variable to check for grade after bonus
int gradeAfterBonus = grade;

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
    gradeAfterBonus += 10; // gradeAfterBonus = grade + 10;

}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
    gradeAfterBonus += 10; // gradeAfterBonus = grade + 10;
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
    gradeAfterBonus += 10; // gradeAfterBonus = grade + 10;
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
    gradeAfterBonus += 10; // gradeAfterBonus = grade + 10;
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
    gradeAfterBonus += 10; // gradeAfterBonus = grade + 10;
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A");
    gradeAfterBonus += 10; // gradeAfterBonus = grade + 10;
}
else
{
    Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");
}

Console.WriteLine("******************* Complex IF..ELSE IF Results End *********************");


// Ternary Operator - Used to assign a value to a variable based on a condition.
Console.WriteLine("******************* Ternary Operator Results *********************");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");

Console.WriteLine("******************* Ternary Operator Results End *********************");


// Switch statements - used to evaluate a value and take an action
Console.WriteLine("******************* Switch Statement Results *********************");
/* 
 * Write a program to accept an integer as the days of the week and print the appropriate
   message as outlined below.
1 - Sunday
2 - Monday
3 - Tuesday
4 - Wednesday (Hump Day)
5 - Thursday
6 - Friday (TGIF!!!)
7 - Saturday (Beach Day!!!)
 */

Console.Write("Please enter a number between 1 and 7 to represent the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday - Hump Day");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday - TGIF!!!");
        break;
    case 7:
        Console.WriteLine("Saturday - Beach Day!!!");
        break;
    default:
        Console.WriteLine("Invalid day number entered");
        break;
}
Console.WriteLine("******************* Switch Statement Results End *********************");



// The rest of the application
Console.WriteLine("Thank you for using this program");


