using Vokabulator.BL;

string content = System.IO.File.ReadAllText(@"C:\Users\JanKästner\Desktop\Textfile\file.txt");

// Datentyp; Bezeichnung; aufgerufene Klasse 
var myWordCounter = new WordCounter(' ');

// Datentyp; Bezeichnung; Ergebnis der Klasse; Funktion; Objekt
Dictionary<string, int> words = myWordCounter.Count(content);

foreach (KeyValuePair<string, int> pair in words)
{
  Console.WriteLine($"{pair.Key} kommt {pair.Value} Mal im Text vor.");
}



//Kaiser cäsar = new Kaiser("Julius");
//Mensch derLange = new Mensch("Jan");

//derLange.Alter

//var eagle = new President("Joe Biden");
//Console.WriteLine(eagle.VizePresigent.Name) -> Camilla Harris

//var tvGröße = new Größe(140, 80);
//int zoll = tvGröße.Zoll;
//Console.WriteLine(zoll);