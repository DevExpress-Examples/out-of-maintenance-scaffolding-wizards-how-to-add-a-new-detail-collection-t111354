using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.DetailCollections.Common.Utils;
using Scaffolding.DetailCollections.Common.DataModel;
using Scaffolding.DetailCollections.Common.DataModel.DesignTime;
using Scaffolding.DetailCollections.Common.DataModel.EntityFramework;
using Scaffolding.DetailCollections.Model;

namespace Scaffolding.DetailCollections.DepartmentContextDataModel {
    /// <summary>
    /// A DepartmentContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IDepartmentContextUnitOfWork interface.
    /// </summary>
    public class DepartmentContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IDepartmentContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the DepartmentContextDesignTimeUnitOfWork class.
        /// </summary>
        public DepartmentContextDesignTimeUnitOfWork() {
        }

        IRepository<Course, int> IDepartmentContextUnitOfWork.Courses {
            get { return GetRepository((Course x) => x.CourseID); }
        }

        IRepository<Department, int> IDepartmentContextUnitOfWork.Departments {
            get { return GetRepository((Department x) => x.DepartmentID); }
        }

        IRepository<Employee, int> IDepartmentContextUnitOfWork.Employees {
            get { return GetRepository((Employee x) => x.EmployeeID); }
        }
    }
}
