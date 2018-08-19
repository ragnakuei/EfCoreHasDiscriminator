using System.Collections.Generic;
using System.Linq;
using Mvc5Web.EF;

namespace Mvc5Web.BLL
{
    public class InstructorBL
    {
        private readonly DemoDbContext _dbContext;

        public InstructorBL(DemoDbContext dbContext) { _dbContext = dbContext; }

        public List<Instructor> Get()
        {
            var result = _dbContext.Instructors.ToList();
            return result;
        }
    }
}