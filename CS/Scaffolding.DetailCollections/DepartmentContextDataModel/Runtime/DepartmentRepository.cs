using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.DetailCollections.Common.Utils;
using Scaffolding.DetailCollections.Model;
using Scaffolding.DetailCollections.Common.DataModel;
using Scaffolding.DetailCollections.Common.DataModel.EntityFramework;

namespace Scaffolding.DetailCollections.DepartmentContextDataModel {
    public class DepartmentRepository : DbRepository<Department, int, DepartmentContext>, IDepartmentRepository {
        public DepartmentRepository(DbUnitOfWork<DepartmentContext> unitOfWork)
            : base(unitOfWork, context => context.Set<Department>(), x => x.DepartmentID) {
        }
    }
}