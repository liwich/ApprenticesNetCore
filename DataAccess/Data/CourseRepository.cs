using WebAPI.BusinessLogic.Contracts;
using WebAPI.DataAccess.Models;

namespace WebAPI.DataAccess
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

    }
}
