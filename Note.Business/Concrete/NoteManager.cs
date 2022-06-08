using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.Business.Abstract;
using Note.DataAccess.Abstract;
using Note.DataAccess.Concrete;

namespace Note.Business.Concrete
{
    public class NoteManager : INoteService
    {
        private INoteRepository _noteRepository;

        public NoteManager()
        {
            _noteRepository = new NoteRepository();
        }

        public List<Entities.Note> GetAllNotes()
        {
            return _noteRepository.GetAllNotes();
        }

        public Entities.Note GetNoteById(int id)
        {
            return _noteRepository.GetNoteById(id);
        }

        public Entities.Note CreateNote(Entities.Note note)
        {
            return _noteRepository.CreateNote(note);
        }

        public Entities.Note UpdateNote(Entities.Note note)
        {
            return _noteRepository.UpdateNote(note);
        }

        public void DeleteNote(int id)
        {
            _noteRepository.DeleteNote(id);
        }
    }
}
