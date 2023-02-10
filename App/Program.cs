string aFriend = "Bill";
Console.WriteLine(aFriend);

var anotherFriend = "Susan";
Console.WriteLine(anotherFriend);

aFriend = "Maria";
Console.WriteLine(aFriend);

anotherFriend = "Jill";
Console.WriteLine(anotherFriend);
Console.WriteLine("Hello " + anotherFriend);
Console.WriteLine("Hi " + aFriend);
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Bob";
string secondFriend = "Charlie";
Console.WriteLine($"My two friends are {firstFriend} and {secondFriend}.");
Console.WriteLine(firstFriend.Length);
Console.WriteLine(secondFriend.Length);
Console.WriteLine($"My first friend's name has {firstFriend.Length} letters and {secondFriend} her name has {secondFriend.Length} letters.");

string greeting = "             Hello World!           ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

string anotherTrimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{anotherTrimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hi, my name is Ellen!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hi", "Hey");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("I"));
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.StartsWith("I"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));