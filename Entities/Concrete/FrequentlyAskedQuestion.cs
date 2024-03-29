﻿using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class FrequentlyAskedQuestion : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
