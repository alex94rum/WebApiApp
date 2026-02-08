namespace DataAccess;

internal class NoteRepository(AppContext context) : INoteRepository
{
    public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Created = DateTime.UtcNow;
        await context.Notes.AddAsync(note, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
