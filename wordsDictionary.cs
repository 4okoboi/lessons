static void Main()
{
    // Создаем словарь для хранения слов и их частот
    Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

    string filePath = "файл.txt";


    // Считываем текст из файла
    string text = File.ReadAllText(filePath);

    // Разбиваем текст на слова, используя регулярное выражение
    string[] words = Regex.Split(text, @"\W+");

    // Подсчитываем частоту каждого слова
    foreach (string word in words)
    {
        if (!string.IsNullOrEmpty(word))
        {
            string lowercaseWord = word.ToLower(); // Приводим слово к нижнему регистру
            if (wordFrequency.ContainsKey(lowercaseWord))
            {
                wordFrequency[lowercaseWord]++;
            }
            else
            {
                wordFrequency[lowercaseWord] = 1;
            }
        }
    }

    // Выводим результаты
    foreach (var kvp in wordFrequency)
    {
        Console.WriteLine($"Слово: {kvp.Key}, Повторений: {kvp.Value}");
    }
    
}
