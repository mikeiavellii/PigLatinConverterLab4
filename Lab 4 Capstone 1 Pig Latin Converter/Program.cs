bool restart = true;
Console.WriteLine("Welcome to the Pig Latin Translator!\n");

while (restart == true)
{
    Console.WriteLine("Enter a a word you would like to be translated:\n");
    string sentences = Console.ReadLine().Trim().ToLower();

    string[] words = sentences.Split(' ');
    string pigTranslation = "";
    foreach (string word in words)
    {
        //find vowel placement using method
        if (vowelFinder(word))
        {
            pigTranslation = word + "way";
            Console.Write(pigTranslation + " ");
        }
        else
        {
            int vCount = 0;
            string letter = "";
            foreach (char w in word)
            {
                letter = w.ToString();

                if (vowelFinder(letter))
                {
                    string aWord = word.Substring(vCount);
                    string bWord = word.Substring(0, vCount);
                    string combinedWord = aWord + bWord;
                    pigTranslation = (combinedWord + "ay");
                    Console.Write(pigTranslation + " ");
                    break;
                }
                else
                {
                    vCount++;
                }
            }
        }
    }
    while (restart == true)
    {
        Console.WriteLine("\nWould you like to translate more? (Yes or no.)");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "yes" || choice == "y")
        {
            restart = true;
            break;
        }
        else if (choice == "no" || choice == "n")
        {
            Console.WriteLine("Opehay ouyay earnedlay omethingsay, idkay. Ebyay.");
            restart = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid response. Please respond with either a yes or a no.");
        }
    }

}

//Methods 
static bool vowelFinder(string vow)
{
    return (vow.StartsWith("a")) || (vow.StartsWith("e")) || (vow.StartsWith("i")) || (vow.StartsWith("o")) || (vow.StartsWith("u")) || (vow.StartsWith("A")) || (vow.StartsWith("E")) || (vow.StartsWith("I")) || (vow.StartsWith("O")) || (vow.StartsWith("U"));
}
