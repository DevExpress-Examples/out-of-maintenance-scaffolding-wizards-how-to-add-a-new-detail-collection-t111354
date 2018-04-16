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
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, int, IDepartmentContextUnitOfWork> {
        public EmployeeViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public EmployeeViewModel(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Employees) {
        }
        public IList<Department> LookUpDepartments {
            get { return GetLookUpEntities(UnitOfWork.Departments); }
        }
        protected override bool TryInitializeDetail(IDetailEntityInfo detailEntityInfo) {
            return TryInitializeDetail(detailEntityInfo, UnitOfWork.Departments, (entity, detailEntity) => entity.Department = detailEntity);
        }
    }
}
