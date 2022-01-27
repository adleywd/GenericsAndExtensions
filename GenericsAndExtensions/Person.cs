namespace GenericsExtensions
{
    public sealed class Person
    {

        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string LastName { get; set; }
    }
}
