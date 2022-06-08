using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.DataAccess.Abstract;

namespace Note.DataAccess.Concrete
{
    public class NoteRepository : INoteRepository
    {
        public Entities.Note CreateNote(Entities.Note note)
        {
            using (var dbContext = new NoteDbContext())
            {
                dbContext.Notes.Add(note);
                dbContext.SaveChanges();
                return note;
            }
        }

        public void DeleteNote(int id)
        {
            using (var dbContext = new NoteDbContext())
            {
                var whichNote = GetNoteById(id);
                dbContext.Notes.Remove(whichNote);
                dbContext.SaveChanges();
            }
        }

        public List<Entities.Note> GetAllNotes()
        {
            using (var dbContext = new NoteDbContext())
            {
                return dbContext.Notes.ToList();
            }
        }

        public Entities.Note GetNoteById(int id)
        {
            using (var dbContext = new NoteDbContext())
            {
                return dbContext.Notes.Find(id);
            }
        }

        public Entities.Note UpdateNote(Entities.Note note)
        {
            using (var dbContext = new NoteDbContext())
            {
                dbContext.Notes.Update(note);
                dbContext.SaveChanges();
                return note;
            }
        }
    }
}
