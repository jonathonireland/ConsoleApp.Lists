Console.WriteLine("*************** - Lists - *****************");

// Declare a List 
List<int> grades = new List<int>();
int grade = 0;
// var grades = new List<int>();
// List <int> grades = new();

// Add values to list
// grades.Add(45);
// grades.Add(46);
// Console.WriteLine(grades[0]);
// Console.WriteLine(grades[1]);

do
{
    Console.Write("Enter Grade: (-1 to exit)");
    grade = Convert.ToInt32(Console.ReadLine());

    if (grade != -1)
    {
        grades.Add(grade);
    }
} 
while (grade != -1);

// Print values in list - for
Console.WriteLine("Printing names via forloop");
for (int i = 0; i < grades.Count; i++)
{
    Console.WriteLine(grades[i]);
}


// Print values list - foreach
foreach(int g in grades)
{
    Console.WriteLine(g);
}

