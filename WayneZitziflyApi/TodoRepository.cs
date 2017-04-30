namespace WayneZitziflyApi
{
    public interface ITodoRepository
    {

    }

    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {

        }

    }
}