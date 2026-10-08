// //Шаг 1. foreachпо строке
// using System.Diagnostics.CodeAnalysis;
// using System.Drawing;
// using System.IO.Compression;
// using System.Runtime.InteropServices;

// string subject = "Программирование";

// foreach (char letter in subject){
//     Console.WriteLine(letter);
// }
// Console.WriteLine($"Общее количество букв в слове: {subject.Length}");

// //Шаг 2. Массив и foreach
// Console.WriteLine();
// int[] grades = { 4, 5, 3, 5, 4 };
// int count = 0;

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     count += grade;
// }
// double average = (double)count / grades.Length;
// Console.WriteLine($"Средний балл: {average}");

// //Шаг 3. Массив строк
// Console.WriteLine();
// string[] students = { "Аня", "Ярослав", "Вика" };
// int count1 = 0;

// foreach (string student in students) {
//     count1++;
//     Console.WriteLine($"{count1}. {student}");
// }
// Console.WriteLine($"Всего учеников: {count1}");

// //Шаг 4. Ограничение foreach
// Console.WriteLine();
// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
//     Console.WriteLine(points[i]);
// }

// //Шаг 5. Нумерация элементов вручную
// Console.WriteLine();
// string[] students1 = {"Аня", "Борис", "Вика"};
// int number = 1;

// foreach (string student1 in students1){
//     Console.WriteLine($"{number}. {student1}");
//     number++;

// }

// //Самостоятельные задания
// Console.WriteLine();
// Console.WriteLine("Задача А");

// int[] num = {1, 2, 3, 4, 5};
// int sum = 0;
// foreach (int i in num){
//     Console.WriteLine(i);
//     sum += i;
// }
// Console.WriteLine($"Сумма: {sum}"); 

// Console.WriteLine();
// Console.WriteLine("Задача Б");

// string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
// foreach (string day in days){
//     Console.WriteLine($"{day}!");
// }

// //Индивидуальный вариант
// // Console.Write("Введите свою фамилию: ");
// // string surname = Console.ReadLine()!.Trim();
// // if (string.IsNullOrEmpty(surname)) {
// // Console.WriteLine("Фамилия не введена. Завершение работы.");
// // return;
// // }
// // Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// // var assigned = Enumerable.Range(1, 10)
// // .OrderBy(_ => rnd.Next())
// // .Take(2)
// // .OrderBy(x => x)
// // .ToList();
// // Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine();
Console.WriteLine("Вариант 1");
int[] temperature = {24, 15, 23, -2, 0, 35, 17};

int summ = 0;

foreach (int temp in temperature) {
    summ += temp;
}
double average1 = (double)summ/temperature.Length;
Console.WriteLine($"Средняя температура за неделю: {average1}");

Console.WriteLine();
Console.WriteLine("Вариант 5");

string[] books = {"Война и мир", "Мастер и Маргарита", "Преступление и наказание", "Ромео и Джульета"};
string name = "Война и мир";
bool found = false;

foreach (string book in books) {
    if (book == name){
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Найдено" : "Не найдено");

//Дополнительное задание.Журнал оценок класса.
// string[] names = {"Оля", "Катя", "Алена", "Соня", "Даша"};
// int[] grades = {5, 4, 3, 5, 5};

// double sum = 0;
// int max = grades[0];
// string topName = names[0];

// for (int i = 0; i < names.Length; i++) {
//     Console.WriteLine($"{names[i]} - {grades[i]}");
//     sum += grades[i];

//     if (grades[0] > max){
//         max = grades[i];
//         topName = names[i];
//     }
// }
// double average = sum / names.Length;
// Console.WriteLine($"Средний балл по классу: {average}");
// Console.WriteLine($"Ученик с максимальной оценкой: {topName}");
