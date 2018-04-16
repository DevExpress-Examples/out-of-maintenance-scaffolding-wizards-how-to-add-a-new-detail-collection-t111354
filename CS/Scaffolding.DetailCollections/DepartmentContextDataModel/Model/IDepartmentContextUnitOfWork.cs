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
    public interface IDepartmentContextUnitOfWork : IUnitOfWork {
        bool HasChanges();
        ICourseRepository Courses { get; }
        IDepartmentRepository Departments { get; }
        IEmployeeRepository Employees { get; }
    }
}
