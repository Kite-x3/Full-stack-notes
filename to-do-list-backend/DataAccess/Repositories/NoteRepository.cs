using Infrastracture.Data;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Repository
{
    internal class NoteRepository(Data.AppContext context) : INoteRepository
    {
        public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.CreatedAt = DateTime.UtcNow;
            await context.Notes.AddAsync(note, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Note note, CancellationToken cancellationToken = default)
        {
            context.Notes.Remove(note);

            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<Note>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Notes.ToListAsync(cancellationToken);
        }

        public async Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Notes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.UpdatedAt = DateTime.UtcNow;

            context.Notes.Update(note);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
