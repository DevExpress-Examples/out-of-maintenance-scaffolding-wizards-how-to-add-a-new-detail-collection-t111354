using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.DetailCollections.Common.Utils;
using Scaffolding.DetailCollections.Common.DataModel;
using Scaffolding.DetailCollections.Common.DataModel.EntityFramework;
using Scaffolding.DetailCollections.Model;

namespace Scaffolding.DetailCollections.DepartmentContextDataModel {
    public class DepartmentContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IDepartmentContextUnitOfWork {
        static DesignTimeCourseRepository coursesRepository = new DesignTimeCourseRepository();
        static DesignTimeDepartmentRepository departmentsRepository = new DesignTimeDepartmentRepository();
        static DesignTimeEmployeeRepository employeesRepository = new DesignTimeEmployeeRepository();

        public DepartmentContextDesignTimeUnitOfWork() {
        }

        bool IDepartmentContextUnitOfWork.HasChanges() {
            return false;
        }
        ICourseRepository IDepartmentContextUnitOfWork.Courses {
            get { return coursesRepository; }
        }
        IDepartmentRepository IDepartmentContextUnitOfWork.Departments {
            get { return departmentsRepository; }
        }
        IEmployeeRepository IDepartmentContextUnitOfWork.Employees {
            get { return employeesRepository; }
        }
        public void Detach(object entity) {
        }
    }
}
