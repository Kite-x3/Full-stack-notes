using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    internal class NoteService(INoteRepository noteRepository) :INoteService
    {
        public async Task CreateAsync(string text, string title, CancellationToken cancellationToken = default)
        {
            Note note = new Note { Text = text, Title = title };

            await noteRepository.CreateAsync(note, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);

            if (note is null)
            {
                throw new Exception("Note not found");
            }

            await noteRepository.DeleteAsync(note, cancellationToken);
        }

        public async Task<IEnumerable<NoteDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var notes = await noteRepository.GetAllAsync(cancellationToken);

            if (notes is null)
            {
                throw new Exception("Notes not found");
            }
            
            return notes.Select(note=> new NoteDto(note));
        }

        public async Task<NoteDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);

            if (note is null)
            {
                throw new Exception("Note not found ");
            }

            return new NoteDto(note);
        }

        public async Task UpdateAsync(int id, string? newText, string? newTitle, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(newText) && string.IsNullOrEmpty(newTitle))
            {
                throw new Exception("At least one field (text or title) must be provided");
            }

            var note = await noteRepository.GetByIdAsync(id, cancellationToken);

            if (note is null)
            {
                throw new Exception("Note not found ");
            }

            bool isUpdated = false;

            if (!string.IsNullOrEmpty(newText) && note.Text != newText)
            {
                note.Text = newText;
                isUpdated = true;
            }

            if (!string.IsNullOrEmpty(newTitle) && note.Title != newTitle)
            {
                note.Title = newTitle;
                isUpdated = true;
            }

            if (!isUpdated)
            {
                return; // Ничего не изменилось, обновление не требуется
            }

            await noteRepository.UpdateAsync(note, cancellationToken);

        }
    }
}
