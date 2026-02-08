namespace BussinessLogic;

public interface INoteService
{
    Task CreateAsync(string text, CancellationToken cancellationToken = default);

    Task<string> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
