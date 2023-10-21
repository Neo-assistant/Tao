System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting . . .");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted! {age}");
int TaosAge = 10;
int ageDeffrence = age - TaosAge;
System.Console.WriteLine($"The deffernece between your and kescha's age is {ageDeffrence} ");

