
//Ex5

Console.WriteLine("Week2Lesson4Ex5:");

Console.WriteLine("Name:");
string name = Console.ReadLine();
Console.WriteLine("Second Name:"); 
string secondName = Console.ReadLine();
int old;
Int32.TryParse(Console.ReadLine(), out old);
Console.WriteLine("Sex:");
char sex = char.Parse(Console.ReadLine());
Console.WriteLine("Phone Number:");
long phoneNumber = long.Parse(Console.ReadLine());
Console.WriteLine("Email Adress:");
string emailAdres = Console.ReadLine();
Console.WriteLine("Height:");
double height = double.Parse(Console.ReadLine());
Console.WriteLine("Weight:");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name} \r\n Second Name: {secondName}");
Console.WriteLine($"Years Old: {old}");
Console.WriteLine($"Sex: {sex}");
Console.WriteLine($"Phone Number: +48 {phoneNumber}");
Console.WriteLine($"Email Adress: {emailAdres}");
Console.WriteLine($"Height: {height}cm");
Console.WriteLine($"Weight: {weight}kg");






