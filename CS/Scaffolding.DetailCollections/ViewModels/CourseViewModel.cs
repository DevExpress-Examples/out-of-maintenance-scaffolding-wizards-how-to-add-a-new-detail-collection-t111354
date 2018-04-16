using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Scaffolding.DetailCollections.Common.Utils;
using Scaffolding.DetailCollections.DepartmentContextDataModel;
using Scaffolding.DetailCollections.Common.DataModel;
using Scaffolding.DetailCollections.Model;
using Scaffolding.DetailCollections.Common.ViewModel;

namespace Scaffolding.DetailCollections.ViewModels {
    public partial class CourseViewModel : SingleObjectViewModel<Course, int, IDepartmentContextUnitOfWork> {
        public CourseViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public CourseViewModel(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Courses) {
        }
        public IList<Department> LookUpDepartments {
            get { return GetLookUpEntities(UnitOfWork.Departments); }
        }
        protected override bool TryInitializeDetail(IDetailEntityInfo detailEntityInfo) {
            return TryInitializeDetail(detailEntityInfo, UnitOfWork.Departments, (entity, detailEntity) => entity.Department = detailEntity);
        }
    }
}
