using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите строку: ");
//         string text = Console.ReadLine() ?? "";

       
//         int length = text.Length;
//         int letters = CountLetters(text);
//         int digits = CountDigits(text);
//         int spaces = CountCharacter(text, ' ');
//         int words = CountWordsManually(text); 

//         string trimmed = text.Trim();
//         string upper = text.ToUpper();
//         string replaced = text.Replace(' ', '_');

//         Console.WriteLine("\n>>> Анализ строки <<<\n");
//         Console.WriteLine($"Исходная строка: [{text}]");
//         Console.WriteLine($"Длина: {length}");
//         Console.WriteLine($"Букв: {letters}");
//         Console.WriteLine($"Цифр: {digits}");
//         Console.WriteLine($"Пробелов: {spaces}");
//         Console.WriteLine($"Слов: {words}");
//         Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
//         Console.WriteLine($"Верхний регистр: [{upper}]");
//         Console.WriteLine($"Замена пробелов: [{replaced}]");

        
//         Console.Write("\nВведите один символ для поиска: ");
//         string? input = Console.ReadLine();
//         if (string.IsNullOrEmpty(input))
//         {
//             Console.WriteLine("Символ не найден");
//             return;
//         }
//         char target = input[0];

//         int index = FindCharacterIndex(text, target);
//         if (index == -1)
//         {
//             Console.WriteLine("Символ не найден");
//         }
//         else
//         {
//             Console.WriteLine($"Первый индекс: {index}");
//         }
//     }


//     static int CountCharacter(string text, char target)
//     {
//         int count = 0;
//         foreach (char symbol in text)
//         {
//             if (symbol == target)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }

    
//     static int CountDigits(string text)
//     {
//         int count = 0;
//         foreach (char symbol in text)
//         {
//             if (char.IsDigit(symbol))
//             {
//                 count++; 
//             }
//         }
//         return count;
//     }

//     // Подсчёт букв
//     static int CountLetters(string text)
//     {
//         int count = 0;
//         foreach (char symbol in text)
//         {
//             if (char.IsLetter(symbol))
//             {
//                 count++;
//             }
//         }
//         return count;
//     }

    
//     static int FindCharacterIndex(string text, char target)
//     {
//         for (int i = 0; i < text.Length; i++)
//         {
//             if (text[i] == target)
//             {
//                 return i; 
//             }
//         }
//         return -1;
//     }

//     static int CountWordsManually(string text)
//     {
//         int count = 0;
//         bool inWord = false;

//         for (int i = 0; i < text.Length; i++)
//         {
//             char c = text[i];
//             if (c != ' ')
//             {
//                 if (!inWord)
//                 {
                    
//                     count++;
//                     inWord = true;
//                 }
//             }
//             else
//             {
//                 inWord = false;
//             }
//         }

//         return count;
//     }
// }

public static int FindLastCharacterIndex(string text, char target)
{
    if (string.IsNullOrEmpty(text))
        return -1;

    int lastIndex = -1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            lastIndex = i;
        }
    }

    return lastIndex;
}
Console.Write("Введите строку: ");
string input = Console.ReadLine() ?? "";

Console.Write("Введите символ для поиска: ");
string targetInput = Console.ReadLine() ?? "";
char target = targetInput.Length > 0 ? targetInput[0] : ' ';

int result = FindLastCharacterIndex(input, target);
Console.WriteLine($"Последний индекс символа '{target}': {result}");

