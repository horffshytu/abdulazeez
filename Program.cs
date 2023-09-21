// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("c# is a general purpose language");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Examination calculator");
Console.WriteLine("My First Calculator");
Console.WriteLine("The name of the founder calculator is HORFFSHYTU");
// Working with variables
string name = "abdulazeez";
float testscore = 28;
float examscore = 58;
double totalscore = testscore + examscore;

Console.WriteLine("My name is" + "  " +name);
Console.WriteLine("Your test score is" + " " +testscore);
Console.WriteLine("Your exam score is" + " " +examscore);
Console.WriteLine("Your total score is" + " " +totalscore);

// Working with users input
Console.WriteLine("Enter your Name");
string student_name = Console.ReadLine();
Console.WriteLine("Welcome"+" "+student_name);

Console.WriteLine("Enter your Test score");
int test_score = int.Parse(Console.ReadLine());
Console.WriteLine("You have Enter Test score to be "+" "+test_score);

Console.WriteLine("Enter Exam Score");
int exam = int.Parse(Console.ReadLine());
Console.WriteLine("You have Enter Exam score to be "+" "+exam);

float total = test_score + exam;
Console.WriteLine("Your Total Score Per Percentage is"+ " "+total);