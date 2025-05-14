using Model_Yourself;

var mahder = new Mahder();
mahder.Info();
mahder.Lese();

var august = new August();
august.Info();
august.Spill();

Console.WriteLine("Skrive navnet ditt");
var name = Console.ReadLine();
Console.WriteLine("Hvor gammel er du?");
var age = Console.ReadLine();
Console.WriteLine("Hvilket land kommer du fra");
var country = Console.ReadLine();
Console.WriteLine("Har du en hobby?");
var hobby = Console.ReadLine();
var user = new User(name, age, country, hobby);
user.Info();
user.DoHobby();
