Console.WriteLine("Пожалуйста, введите нужные слова через пробел:");
// Используем функцию в классе String, которая может разделить строку
// на слова через указанный символ: функция Split.
String[] words = Console.ReadLine().Split(' '); // Разделили строку на массив слов
for(int i = 0; i < words.Length; i++) // Проходим по каждому слову
{
    if(words[i].Length <= 3) // Проверяем длинну слова
    {
        Console.WriteLine(words[i]);
    }
}
Console.WriteLine();