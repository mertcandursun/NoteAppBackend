using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.Entities;

namespace Note.DataAccess.Abstract
{
    public interface INoteRepository
    {
        public List<Entities.Note> GetAllNotes();
        public Entities.Note GetNoteById(int id);
        public Entities.Note CreateNote(Entities.Note note);
        public Entities.Note UpdateNote(Entities.Note note);
        public void DeleteNote(int id);
    }
}
