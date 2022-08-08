string name;

Console.WriteLine("Как вас зовут?");
name=Console.ReadLine();

string familia;

Console.WriteLine("Какая у вас фамилия?");
familia=Console.ReadLine();



string otchestvo;

Console.WriteLine("Какое у вас отчество?");
otchestvo=Console.ReadLine();


string fullName= familia + " "+name+" "+otchestvo;
Console.WriteLine(fullName);