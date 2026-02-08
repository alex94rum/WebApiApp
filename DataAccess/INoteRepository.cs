namespace DataAccess;

public interface INoteRepository
{
    Task CreateAsync(Note note, CancellationToken cancellationToken = default);
}
