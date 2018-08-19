using System.Collections.Generic;
using System.Linq;
using Mvc5Web.EF;

namespace Mvc5Web.BLL
{
    public class StudentBL
    {
        private readonly DemoDbContext _dbContext;

        public StudentBL(DemoDbContext dbContext) { _dbContext = dbContext; }

        public List<Student> Get()
        {
            var result = _dbContext.Students.ToList();
            return result;
        }
    }
}
