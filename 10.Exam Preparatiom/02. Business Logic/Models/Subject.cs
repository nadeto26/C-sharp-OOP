﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public abstract class Subject : ISubject
    {
        public Subject(int subjectId, string subjectName, double subjectRate)
        {
            this.Id = id;
            this.Name = subjectName;
            this.Rate = subjectRate;
        }
        private int id;
        private double rate;
        private string name;

        public int Id
        {
            get => id;
            private set
            {

                id = value;
            }
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }

        public double Rate { get => rate; private set => rate = value; }
    }
}
