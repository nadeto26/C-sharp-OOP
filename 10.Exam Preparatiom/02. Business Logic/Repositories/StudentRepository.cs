﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class StudentRepository : IRepository<IStudent>
    {
        private List<IStudent> models;
        public StudentRepository()
        {
            models = new List<IStudent>();
        }
        public IReadOnlyCollection<IStudent> Models => models;

        public void AddModel(IStudent model)
        {
             models.Add(model);
        }

        public IStudent FindById(int id)
        => models.FirstOrDefault(x => x.Id == id);

        public IStudent FindByName(string name)
        {
            string firstName = name.Split(" ")[0];
            string lastName = name.Split(" ")[1];

            return this.models.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

        }

    }
}
