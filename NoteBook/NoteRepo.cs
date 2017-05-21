using System;
using System.Collections.Generic;

namespace NoteBook
{
    public class NoteRepo
    {
		public IEnumerable<Note> GetAll()
		{
            var pr = new PersonRepo();
			return new Note[] {
                new Note(pr.Get("Вася")),
                new Note(pr.Get("Оля")),
                new Note(pr.Get("Петя")),
                new Note(pr.Get("Коля"))
            };
		}
		public Note Get(object id)
		{
			return new Note (null);
		}
        public NoteRepo()
        {
        }
    }
}
