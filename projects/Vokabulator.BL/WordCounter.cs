namespace Vokabulator.BL
{
  public class WordCounter
  {
    private readonly char seperator;

    public WordCounter(char seperator)
    {
      this.seperator = seperator;
    }

    //Zählen
    public Dictionary<string, int> Count(string content)
    {
      Dictionary<string, int> countDictionary = new Dictionary<string,int>();

      // Wörter auftrennen
      string[] words = content.Split(seperator);
      // für jedes Wort:
      foreach (string word in words)
      {
        // schauen, ob es im Dictionary vorhanden ist
        if (countDictionary.ContainsKey(word))
        {
          // wenn ja, dann Zähler hochzählen
          countDictionary[word]++;
        }
        else
        {
          // wenn nicht, dann neu einfügen
          countDictionary.Add(word, 1);
        }

      }

      return countDictionary;
    }
  }
}