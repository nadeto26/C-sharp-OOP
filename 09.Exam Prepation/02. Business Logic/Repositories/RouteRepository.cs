﻿using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    public class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> routes;
        public RouteRepository()
        {
            routes = new List<IRoute>();
        }

        public void AddModel(IRoute model)
        {
            routes.Add(model);
        }

        public IRoute FindById(string identifier) 
            => this.routes.FirstOrDefault(u => u.RouteId == int.Parse(identifier));


        public IReadOnlyCollection<IRoute> GetAll() => this.routes;


        public bool RemoveById(string identifier)
        {
            return routes.Remove(this.FindById(identifier));
        }
    }
}
