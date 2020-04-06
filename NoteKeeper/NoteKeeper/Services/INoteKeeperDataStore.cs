using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public interface INoteKeeperDataStore
    {
        Task<string> AddNoteAsync(Note courseNote);
        Task<bool> UpdateNoteAsync(Note courseNote);
        Task<Note> GetNoteAsync(String id);
        Task<IList<Note>> GetNotesAsync();
        Task<IList<string>> GetCoursesAsync();
    }
}
