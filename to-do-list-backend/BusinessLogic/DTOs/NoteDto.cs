using DataAccess;

namespace BusinessLogic.DTOs
{
    public class NoteDto
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public NoteDto(Note note)
        {
            Title = note.Title;
            Text = note.Text;
        }
    }
}
