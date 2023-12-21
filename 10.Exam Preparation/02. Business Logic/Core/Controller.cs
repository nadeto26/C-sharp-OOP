﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;



        public string AddStudent(string firstName, string lastName)
        {
            string result;
           if (students.FindByName (firstName) != null)
            {
               result = string.Format(OutputMessages.AlreadyAddedSubject, firstName);
            }
           else
            {
                IStudent student = new Student(this.students.Models.Count +1, firstName, lastName);
                this.students.AddModel (student);
                result = string
                    .Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, nameof(StudentRepository));

            }
           return result.TrimEnd ();
        }

        public string AddSubject(string subjectName, string subjectType)
        {


            if (subjectType != nameof(TechnicalSubject) &&
                subjectType != nameof(EconomicalSubject) &&
                subjectType != nameof(HumanitySubject))
            {
                return string.Format(OutputMessages.SubjectTypeNotSupported, subjectType);
            }
            else if (subjects.FindByName(subjectName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedStudent, subjectName);
            }
            else
            {
                ISubject subject;
                int subjectId = subjects.Models.Count + 1;

                if (subjectType == nameof(TechnicalSubject))
                {
                    subject = new TechnicalSubject(subjectId, subjectName);
                }
                else if (subjectType == nameof(EconomicalSubject))
                {
                    subject = new EconomicalSubject(subjectId, subjectName);
                }
                else
                {
                    subject = new HumanitySubject(subjectId, subjectName);
                }


                this.subjects.AddModel(subject);
                return string.Format
                   (OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, nameof(SubjectRepository));
            }
                

            }








        

        public string AddUniversity(string universityName, string category, int capacity, 
            List<string> requiredSubjects)
        {
            string resut;

            if(universities.FindByName(universityName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedUniversity, universityName);
            }
            List<int> rs = new List<int>();
            foreach (var subName in requiredSubjects)
            {
                rs.Add(this.subjects.FindByName(subName).Id);
            }
            IUniversity university =
                new University(this.universities.Models.Count + 1, universityName, category, capacity, rs);
            this.universities.AddModel(university);

            resut = string
                .Format(OutputMessages.UniversityAddedSuccessfully, universityName, nameof(UniversityRepository));
      

            return resut.TrimEnd();
        }




        public string ApplyToUniversity(string studentName, string universityName)
        {
            string result = "";

            string firstName = studentName.Split(" ")[0];
            string lastName = studentName.Split(" ")[1];

            var student = this.students.FindByName(studentName);
            var university = this.universities.FindByName(universityName);

            if (student == null)
            {
                result = string.Format(OutputMessages.StudentNotRegitered, firstName, lastName);
            }
            else if (university == null)
            {
                result = string.Format(OutputMessages.UniversityNotRegitered, universityName);
            }
            else if (!university.RequiredSubjects.All(x => student.CoveredExams.Any(e => e == x)))
            {
                result = string.Format(OutputMessages.StudentHasToCoverExams, studentName, universityName);
            }
            else if (student.University != null && student.University.Name == universityName)
            {
                result = string.Format(OutputMessages.StudentAlreadyJoined, firstName, lastName, universityName);
            }
            else
            {
                student.JoinUniversity(university);
                result = string.Format(OutputMessages.StudentSuccessfullyJoined, firstName, lastName, universityName);
            }

            return result.TrimEnd();
        }

    

    public string TakeExam(int studentId, int subjectId)
        {
            string result = "";

            if (this.students.FindById(studentId) == null)
            {
                result = string.Format(OutputMessages.InvalidStudentId);
            }
            else if (this.subjects.FindById(subjectId) == null)
            {
                result = string.Format(OutputMessages.InvalidSubjectId);
            }
            else if (students.FindById(studentId).CoveredExams.Any(e => e == subjectId))
            {
                result = string
                    .Format(OutputMessages
                    .StudentAlreadyCoveredThatExam,
                    students.FindById(studentId).FirstName,
                    students.FindById(studentId).LastName,
                    subjects.FindById(subjectId).Name);
            }
            else
            {
                var student = this.students.FindById(studentId);
                var subject = this.subjects.FindById(subjectId);

                student.CoverExam(subject);
                result = string.Format(OutputMessages.StudentSuccessfullyCoveredExam, student.FirstName, student.LastName, subject.Name);
            }

            return result.TrimEnd();
        }

    

    public string UniversityReport(int universityId)
        {
            var university = this.universities.FindById(universityId);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {this.students.Models.Where(s => s.University == university).Count()}");
            sb.AppendLine($"University vacancy: {university.Capacity - this.students.Models.Where(s => s.University == university).Count()}");

            return sb.ToString().TrimEnd();

        }
    }
}
