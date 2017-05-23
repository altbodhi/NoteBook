using System;
namespace NoteBook
{
    public class Note
    {
		public int Id { get; protected set; }
        public Person Creator { get; private set; }
        public string CreatorName { get {return Creator?.Name?? "нет автора" ; }}
		public Note() { }
		public Note(Person creator)
        {
            this.Creator = creator;
        }
    }
}
