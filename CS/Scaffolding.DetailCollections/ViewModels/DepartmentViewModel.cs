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
    public partial class DepartmentViewModel : SingleObjectViewModel<Department, int, IDepartmentContextUnitOfWork> {
        public DepartmentViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public DepartmentViewModel(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Departments) {
        }
        protected override void RefreshLookUpCollections(int key) {
            DepartmentCoursesLookUp = CreateLookUpCollectionViewModel(x => x.Courses, x => x.DepartmentID == key, key);
            DepartmentEmployeesLookUp = CreateLookUpCollectionViewModel(x => x.Employees, x => x.DepartmentID == key, key);
        }
        public virtual LookUpCollectionViewModel<Department, Course, int, IDepartmentContextUnitOfWork> DepartmentCoursesLookUp { get; set; }
        public virtual LookUpCollectionViewModel<Department, Employee, int, IDepartmentContextUnitOfWork> DepartmentEmployeesLookUp { get; set; }
    }
}
