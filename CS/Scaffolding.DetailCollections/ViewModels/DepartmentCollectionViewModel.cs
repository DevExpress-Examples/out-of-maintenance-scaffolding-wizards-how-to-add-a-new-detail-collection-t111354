using System;
using System.Linq;
using Scaffolding.DetailCollections.Common.Utils;
using Scaffolding.DetailCollections.DepartmentContextDataModel;
using Scaffolding.DetailCollections.Common.DataModel;
using Scaffolding.DetailCollections.Model;
using Scaffolding.DetailCollections.Common.ViewModel;

namespace Scaffolding.DetailCollections.ViewModels {
    public partial class DepartmentCollectionViewModel : CollectionViewModel<Department, int, IDepartmentContextUnitOfWork> {
        public DepartmentCollectionViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public DepartmentCollectionViewModel(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Departments) {
        }
    }
}