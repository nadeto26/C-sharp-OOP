using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public class User : IUser
    {
        public  User (string firstName, string lastName, string drivingLicenseNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DrivingLicenseNumber = drivingLicenseNumber;
            this.IsBlocked = true;
        }
        private string firstName;
        private string lastName;
        private double rating;
        private string drivingLicenseNumber;

        public string FirstName
        {
            get => firstName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.FirstNameNull);
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LastNameNull);
                }
                lastName = value;
            }
        }

        public double Rating
        {
            get => rating;
            private set
            {
                
               rating = value;
            }
        }

        public string DrivingLicenseNumber
        {
            get => drivingLicenseNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.DrivingLicenseRequired);
                }
                drivingLicenseNumber = value;
            }
        }

        public bool IsBlocked { get; private set; }  

        public void DecreaseRating()
        {
            this.Rating -= 2.0;
            if (this.Rating < 10.0)
            {
                this.Rating = 10.0;
            }
        }

        public void IncreaseRating()
        {
            this.Rating += 0.5;
            if (this.Rating <0.0)
            {
                this.Rating = 0.0;
            }
            IsBlocked = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{FirstName} {LastName} Driving license: {drivingLicenseNumber} Rating: {rating}");
            return sb.ToString().TrimEnd();
        }
    }
}
