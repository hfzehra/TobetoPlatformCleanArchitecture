﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Skill : Entity<int>  //güncellendi
{ 
    public string Name { get; set; }

    public Skill()
    {

    }

    public Skill(Guid profileId, string name, int id) : this()
    {
        Id = id;
        Name = name;
    }
}
