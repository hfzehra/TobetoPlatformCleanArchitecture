﻿using Core.Persistence.Repositories;
using System;
namespace Domain.Entities
{
    public class ProfileExam : Entity<int> 
    {
        public bool IsCompleted { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

    }
}
