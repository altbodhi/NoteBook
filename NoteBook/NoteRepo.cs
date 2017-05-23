using System;
using System.Collections.Generic;
using LiteDB;
namespace NoteBook
{
    public class NoteRepo
    {
		public IEnumerable<Note> GetAll()
		{
			using (var db = new LiteDatabase(Helper.PathDb)) {
				return db.GetCollection<Note>("notes").FindAll();
			}
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
