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
    /// <summary>
    /// Represents the single Course object view model.
    /// </summary>
    public partial class CourseViewModel : SingleObjectViewModel<Course, int, IDepartmentContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CourseViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CourseViewModel Create(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CourseViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CourseViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CourseViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CourseViewModel(IUnitOfWorkFactory<IDepartmentContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Courses, x => x.Title) {
        }

        /// <summary>
        /// The look-up collection of Departments for the corresponding navigation property in the view.
        /// </summary>
        public IList<Department> LookUpDepartments {
            get { return GetLookUpEntities(x => x.Departments); }
        }
    }
}
