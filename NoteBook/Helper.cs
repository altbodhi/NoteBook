using System;
using System.Configuration;
using LiteDB;
#if DEBUG
using System.Diagnostics;
#endif            
namespace NoteBook
{
	public class Helper
	{
		public static void BuildSchema() {
			using (var db = new LiteDatabase(PathDb)) {
				var notes = db.GetCollection<Note>("notes");

				var persons = db.GetCollection<Person>("persons");
				var person = new Person(DateTime.Now.ToString());
				persons.Insert(person);
				var note = new Note(person);
				notes.Insert(note);
			}
			Debug.Print("BuildSchema - OK");
		}
		public static string PathDb { 
			get { return ConfigurationManager.AppSettings["db"];}
		}
		public Helper()
		{
			
		}
	}
}
