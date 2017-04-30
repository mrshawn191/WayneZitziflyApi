namespace WayneZitziflyApi
{
    public interface IMeetingRepository
    {

    }

    public class MeetingRepository : IMeetingRepository
    {
        private readonly TodoContext _context;

        public MeetingRepository(TodoContext context)
        {

        }

    }
}