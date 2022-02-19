using Vokabulator.BL;

string content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";

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