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
    /// <summary>
    /// A DepartmentContextUnitOfWork instance that represents the run-time implementation of the IDepartmentContextUnitOfWork interface.
    /// </summary>
    public class DepartmentContextUnitOfWork : DbUnitOfWork<DepartmentContext>, IDepartmentContextUnitOfWork {

        public DepartmentContextUnitOfWork(Func<DepartmentContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Course, int> IDepartmentContextUnitOfWork.Courses {
            get { return GetRepository(x => x.Set<Course>(), x => x.CourseID); }
        }

        IRepository<Department, int> IDepartmentContextUnitOfWork.Departments {
            get { return GetRepository(x => x.Set<Department>(), x => x.DepartmentID); }
        }

        IRepository<Employee, int> IDepartmentContextUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), x => x.EmployeeID); }
        }
    }
}
