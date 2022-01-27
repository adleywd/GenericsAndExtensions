using System.Text.Json;

namespace GenericsExtensions
{
    public static class Helpers
    {
        public static bool AreTheSame(Person person1, Person person2)
        {
            return person1.Id == person2.Id
                && person1.Name == person2.Name;
        }

        public static bool AreTheSameSerialized(Person person1, Person person2)
        {
            return JsonSerializer.Serialize(person1) == JsonSerializer.Serialize(person2);
        }

        public static bool AreTheSameExtension(this Person person1, Person person2)
        {
            return JsonSerializer.Serialize(person1) == JsonSerializer.Serialize(person2);
        }

        public static bool AreTheSameWithObject(object source, object target)
        {
            return JsonSerializer.Serialize(source) == JsonSerializer.Serialize(target);
        }

        public static bool AreTheSameGeneric<T>(T source, T target)
        {
            return JsonSerializer.Serialize(source) == JsonSerializer.Serialize(target);
        }

        public static bool AreTheSameGenericExtension<TMyGenircModel>(this TMyGenircModel source, TMyGenircModel target)
        {
            return JsonSerializer.Serialize(source) == JsonSerializer.Serialize(target);

        }

        public static void WriteToConsole(this bool result, string functionName)
        {
            Console.WriteLine($"({functionName}) Person1 == Person2 ? {result}");
        }

        public static void WriteFullName(this Person person)
        {
            Console.WriteLine(person.GetFullName());
        }

        private static string GetFullName(this Person person)
        {
            return $"{person.Name} {person.LastName}";
        }

    }
}
