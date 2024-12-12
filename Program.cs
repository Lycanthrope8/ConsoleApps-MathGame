using ConsoleApp___MathGame;

var menu = new Menu();
var date = DateTime.UtcNow;
string name = Helpers.GetName();

var games = new List<string>();

menu.ShowMenu(name, date);



