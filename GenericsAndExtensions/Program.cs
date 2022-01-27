using GenericsExtensions;

var person1 = new Person(1, "Jonas", "Kirk");
var person2 = new Person(1, "Jonas", "Kirk");
var value = 1;

var arePersonTheSame1 = Helpers.AreTheSame(person1, person2);
Console.WriteLine($"(AreTheSame) Person1 == Person2 ? {{0}}", arePersonTheSame1);

Helpers.AreTheSameSerialized(person1, person2).WriteToConsole("AreTheSameSerialized");

person1.AreTheSameExtension(person2).WriteToConsole("AreTheSameExtension");

Helpers.AreTheSameWithObject(person1, person2).WriteToConsole("AreTheSameWithObject");

Helpers.AreTheSameWithObject(person1, value).WriteToConsole("AreTheSameWithObject"); // It will work, but can lead to mistakes, since you trying o compare Jonas Kirk with 1

Helpers.AreTheSameGeneric<Person>(person1, person2).WriteToConsole("AreTheSameGeneric");

Helpers.AreTheSame(person1, person2).WriteToConsole("AreTheSame"); // Since the two object are type person, you can omit <Person>

//Helpers.AreTheSameGeneric<Person>(person1, value); // Not allowed

person1.AreTheSameGenericExtension<Person>(person2).WriteToConsole("AreTheSameGenericExtension");

person1.AreTheSameGenericExtension(person2).WriteToConsole("AreTheSameGenericExtension"); // Since the extension is for a variable Typed as Person, you can omit <Person>

person1.WriteFullName();