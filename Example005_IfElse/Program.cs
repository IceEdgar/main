Console.Write("Введите имя пользовотелля: ");
string username=Console.ReadLine();

if(username.ToLower()=="Маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}