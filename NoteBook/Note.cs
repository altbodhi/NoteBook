using System;
namespace NoteBook
{
    public class Note
    {
        public Person Creator { get; private set; }
        public string CreatorName { get {return Creator?.Name?? "нет автора" ; }}
        public Note(Person creator)
        {
            this.Creator = creator;
        }
    }
}
