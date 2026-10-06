//Шаг 1. foreachпо строке
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

string subject = "Программирование";

foreach (char letter in subject){
    Console.WriteLine(letter);
}
Console.WriteLine($"Общее количество букв в слове: {subject.Length}");

//Шаг 2. Массив и foreach
Console.WriteLine();
int[] grades = { 4, 5, 3, 5, 4 };
int count = 0;

foreach (int grade in grades)
{
    Console.WriteLine(grade);
    count += grade;
}
double average = (double)count / grades.Length;
Console.WriteLine($"Средний балл: {average}");

//Шаг 3. Массив строк
Console.WriteLine();
string[] students = { "Аня", "Ярослав", "Вика" };
int count1 = 0;

foreach (string student in students) {
    count1++;
    Console.WriteLine($"{count1}. {student}");
}
Console.WriteLine($"Всего учеников: {count1}");

//Шаг 4. Ограничение foreach
Console.WriteLine();
int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
    Console.WriteLine(points[i]);
}