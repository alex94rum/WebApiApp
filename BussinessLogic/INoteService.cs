namespace BussinessLogic;

public interface INoteService
{
    Task CreateAsync(string text, CancellationToken cancellationToken = default);
}
