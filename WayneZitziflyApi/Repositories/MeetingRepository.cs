using System.Collections.Generic;
using System.Linq;
using WayneZitziflyApi.Model;

namespace WayneZitziflyApi
{
    public interface IMeetingRepository
    {
        IEnumerable<Meeting> GetAll();

        Meeting FindById(int id);

        void Create(Meeting meeting);

        void RemoveById(int id);

        void Update(Meeting meeting);
    }

    public class MeetingRepository : IMeetingRepository
    {
        private readonly MeetingContext _context;

        public MeetingRepository(MeetingContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all meetings
        /// </summary>
        public IEnumerable<Meeting> GetAll()
        {
            return _context.Meetings.ToList();
        }

        /// <summary>
        /// Finds a meeting based on the unique id
        /// </summary>
        public Meeting FindById(int id)
        {
            return _context.Meetings.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Creates a meeting
        /// </summary>
        public void Create(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            _context.SaveChanges();
        }

        /// <summary>
        /// Removes a meeting by id
        /// </summary>
        public void RemoveById(int id)
        {
            var meeting = _context.Meetings.First(x => x.Id == id);
            _context.Meetings.Remove(meeting);
            _context.SaveChanges();
        }

        /// <summary>
        /// Updates a meeting
        /// </summary>
        public void Update(Meeting meeting)
        {
            _context.Meetings.Update(meeting);
            _context.SaveChanges();
        }
    }
}