using System;
using System.Collections.Generic;

namespace BusinessLogic.Domain
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
