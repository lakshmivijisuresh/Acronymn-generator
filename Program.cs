// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


 try
{
    Console.WriteLine("Please enter a phrase to acronym: ");
    String input = Console.ReadLine();

    //OPTIONAL EXCLUSIONS
    string exclusions = input.Replace("and", "");
    String[] wordArr = exclusions.Split(' ');
    Console.WriteLine(wordArr.Length);

    // loop through sentence
    String acronym = "";
    for(int i = 0; i < wordArr.Length; i++)
    {
        if (wordArr[i] !="")
        {
            acronym += wordArr[i][0]; //word arr of i and very 1st character
        }
    }
    acronym = acronym.ToUpper();

    Console.WriteLine("Your acronym is: " + acronym);

}
catch(Exception e)
{
    Console.Write(e.ToString());
}


 /*try
{
    //gather ip from the user
    Console.WriteLine("Please enter a phrase to convert to an acronym:");
    String input = Comsole.ReadLine();
    //optional exclusions
    String exclusions = input.Replace("and", "");
    String[] wordArr = exclusions.Split(' ');
    Console.WriteLine(wordArr.Length);
    // The thing and the thing
}
catch(Exception e)
{
    Console.Write(e.ToString());
}
 */