﻿namespace MediPlus.Models
{
    public class Department : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Service>? Services { get; set; }
    }
}
