using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using ZadanieWPF.Access;
using ZadanieWPF.Dto;
using ZadanieWPF.Model;

namespace ZadanieWPF.Service
{
    public class NoteService
    {
        private readonly AppDbContext _appDbContext;

        public NoteService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<NoteEntity> GetNotes()
        {
            var query = "SELECT * FROM Notes;";
            return _appDbContext.GetFromDatabase<NoteEntity>(query);
        }

        public void CreateNote(NoteDto noteDto)
        {
            _appDbContext.CreateNewNote(noteDto);
        }

        public IEnumerable<NoteEntity> ReadNote(int id)
        {
            var query = "SELECT * FROM Notes WHERE id = @id";
            return _appDbContext.GetFromDatabase<NoteEntity>(query);
        }

        public void UpdateNote(NoteDto noteDto)
        {
            _appDbContext.UpdateNote(noteDto);
        }

        public void DeleteNote(NoteDto noteDto)
        {
            _appDbContext.DeleteNote(noteDto);
        }
    }
}
