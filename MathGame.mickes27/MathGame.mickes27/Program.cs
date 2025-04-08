using MathGame.mickes27;

var name = Helpers.GetName();
var date = DateTime.UtcNow;
var menu = new Menu();

menu.Show(name, date);