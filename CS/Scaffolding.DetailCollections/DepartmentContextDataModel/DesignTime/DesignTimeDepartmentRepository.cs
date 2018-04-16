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
    public class DesignTimeDepartmentRepository : DesignTimeRepository<Department, int>, IDepartmentRepository {
        public DesignTimeDepartmentRepository()
            : base(x => x.DepartmentID) {
        }
    }
}