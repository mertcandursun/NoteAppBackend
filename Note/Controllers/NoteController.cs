using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Note.Business.Concrete;

namespace Note.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private INoteService _noteService;

        public NoteController()
        {
            _noteService = new NoteManager();
        }

        [HttpGet]
        public List<Entities.Note> getAllCustomer()
        {
            return _noteService.GetAllNotes();
        }

        [HttpPost]
        public Entities.Note CreateCustomer([FromBody] Entities.Note note)
        {
            return _noteService.CreateNote(note);
        }

        [HttpGet("{id}")]
        public Entities.Note GetById(int id)
        {
            return _noteService.GetNoteById(id);
        }

        [HttpPut]
        public Entities.Note UpdateCustomer([FromBody] Entities.Note note)
        {
            return _noteService.UpdateNote(note);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _noteService.DeleteNote(id);
        }
    }
}
