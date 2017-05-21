using System;
using System.Collections.Generic;
namespace NoteBook
{
    public class PersonRepo:IRepo<Person>
    {
        public IEnumerable<Person> GetAll(){
            return new Person[]{};
        }
        public Person Get(object id){
            return new Person ( name : id.ToString() );
        }
        public PersonRepo()
        {
        }
    }
}
