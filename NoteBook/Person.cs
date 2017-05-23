using System;
namespace NoteBook
{
    public class Person
    {
		public int Id { get; protected set; }
        public string Name { get; private set; }
		public Person() { }
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
