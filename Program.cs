Console.WriteLine("*************** - Lists - *****************");

// Declare a List 
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
int gradeCount = 0;
string name;
int @continue;

// var grades = new List<int>();
// List <int> grades = new();

// Add values to list
// grades.Add(45);
// grades.Add(46);
// Console.WriteLine(grades[0]);
// Console.WriteLine(grades[1]);

do
{
    gradeCount += 1;
    Console.Write("Enter Student Name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());

    if (grade != -1)
    {
        grades.Add(grade);
    }

    Console.Write("Do you wish to continue? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());
} 
while (@continue == 1);

// Print values in list - for
Console.WriteLine("The Grades you have entered are:");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

Console.WriteLine("Printing grades via for loop");
// for (int i = 0; i < grades.Count; i++)
// {
//    Console.WriteLine(grades[i]);
//}


// Print values list - foreach
// foreach(int g in grades)
// {
//    Console.WriteLine(g);
//}

