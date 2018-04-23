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
    /// IDepartmentContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IDepartmentContextUnitOfWork : IUnitOfWork {

        /// <summary>
        /// The Course entities repository.
        /// </summary>
        IRepository<Course, int> Courses { get; }

        /// <summary>
        /// The Department entities repository.
        /// </summary>
        IRepository<Department, int> Departments { get; }

        /// <summary>
        /// The Employee entities repository.
        /// </summary>
        IRepository<Employee, int> Employees { get; }
    }
}
