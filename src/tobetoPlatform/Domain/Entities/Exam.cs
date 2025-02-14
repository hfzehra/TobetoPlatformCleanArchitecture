﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Exam:Entity<int>
{
    public int ExamResultId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Duration { get; set; }
    public virtual ExamResult ExamResult { get; set; }

    public Exam()
    {

    }

    public Exam(int id, int examResultId, string name, string description, string duration) : this()
    {
        Id = id;
        ExamResultId = examResultId;
        Name = name;
        Description = description;
        Duration = duration;
    }
}
