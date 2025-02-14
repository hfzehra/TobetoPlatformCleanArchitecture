﻿using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class EducationPath : Entity<int>
{
    public int ProfileEducationId { get; set; }
    public int EducationAboutId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public virtual ProfileEducation ProfileEducation { get; set; }
    public virtual EducationAbout EducationAbout { get; set; }
    public EducationPath()
    {

    }

}
