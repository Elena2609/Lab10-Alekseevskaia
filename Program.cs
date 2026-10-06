//Шаг 1. foreachпо строке
string subject = "Программирование";

foreach (char letter in subject){
    Console.WriteLine(letter);
}
Console.WriteLine($"Общее количество букв в слове: {subject.Length}");

//Шаг 2. Массив и foreach
int[] grades = { 4, 5, 3, 5, 4 };
int count = 0;

foreach (int grade in grades)
{
    Console.WriteLine(grade);
    count += grade;
}
double average = (double)count / grades.Length;
Console.WriteLine($"Средний балл: {average}");
