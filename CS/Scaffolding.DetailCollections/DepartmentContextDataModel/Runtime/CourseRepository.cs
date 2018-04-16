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
    public class CourseRepository : DbRepository<Course, int, DepartmentContext>, ICourseRepository {
        public CourseRepository(DbUnitOfWork<DepartmentContext> unitOfWork)
            : base(unitOfWork, context => context.Set<Course>(), x => x.CourseID) {
        }
    }
}