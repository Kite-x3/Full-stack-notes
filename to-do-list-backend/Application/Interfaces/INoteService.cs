using Application.DTOs;

namespace Application.Interfaces
{
    public interface INoteService
    {
        Task CreateAsync(string text, string title, CancellationToken cancellationToken = default);
        Task<NoteDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task UpdateAsync(int id, string? newText, string? newTitle, CancellationToken cancellationToken = default);

        Task DeleteAsync(int id, CancellationToken cancellationToken = default);

        Task<IEnumerable<NoteDto>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
