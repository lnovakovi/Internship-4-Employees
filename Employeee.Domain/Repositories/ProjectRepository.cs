using System;
using System.Collections.Generic;
using Employee.Data.Enums;
using Employee.Data.Models;

namespace Employeee.Domain.Repositories
{
    public class ProjectRepository
    {
        public List<Project> _ListOfProjects;

        public ProjectRepository()
        {
            AddProjectData();
        }

        private void AddProjectData()
        {

            _ListOfProjects = new List<Project>()
            {
                new Project("DUMP days", StateEnum.StateProject.Finished, new DateTime(2017 - 12 - 02),
                    new DateTime(2018 - 11 - 02)),
                new Project("Web page", StateEnum.StateProject.Planned)
            };
        }
   
    }
}
