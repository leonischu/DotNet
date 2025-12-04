/*String firstFriend = "            Maria";

firstFriend = firstFriend.Trim();

String secondFriend = "Scott";

string friends = $"My friends are {firstFriend} and {secondFriend}";
 
Console.WriteLine(friends); 
friends = friends.Replace("Scott", "Damian");
Console.WriteLine(friends.Contains("Scott"));
Console.WriteLine(friends.Length);
Console.WriteLine(friends.StartsWith("My "));


var names = new List <string>{ "<name>", "Ana", "Felipe" };
///names = [..names, "damian"];

names.Sort( );

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


int[]scores = { 3,45,82,97, 92, 100,81, 60 };


IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;
  

var scoreQuery = scores.Where(s => s > 80).
    OrderByDescending(s => s);
    foreach (int i in scoreQuery)
    {
    Console.WriteLine(i);

    }
 */

var p1 = new Person(
"Ram",
     "Nepal" ,
     new DateOnly(1970,1,1)
);
var p2 = new Person
(
     "David",
     "Fowler",
   new DateOnly(1980, 1, 1)
);

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
public string Last { get; } = lastname;
public DateOnly BirthDay { get; } = birthday;
}
 