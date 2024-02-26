﻿using Entitiess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // interfaceler refarans tutuculardır
    public interface IApplicantService
    {
         void ApplyForMask(Person person);

         List<Person> GetList();

         bool CheckPerson(Person person);
       
    }
}
