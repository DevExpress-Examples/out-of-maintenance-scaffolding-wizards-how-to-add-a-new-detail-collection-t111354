using System;
using System.Linq;
using Scaffolding.DetailCollections.Common.Utils;
using Scaffolding.DetailCollections.DepartmentContextDataModel;
using Scaffolding.DetailCollections.Common.DataModel;
using Scaffolding.DetailCollections.Model;
using Scaffolding.DetailCollections.Common.ViewModel;

namespace Scaffolding.DetailCollections.ViewModels {
    public partial class CourseCollectionViewModel : CollectionViewModel<Course, int, IDepartmentContextUnitOfWork> {
        public CourseCollectionViewModel()
            : this(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }
        public CourseCollectionViewModel(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory)
            : base(unitOfWorkFactory, x => x.Courses) {
        }
    }
}