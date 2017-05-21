using System;
using System.Collections.Generic;
namespace NoteBook
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T Get(object id);
    }
}
