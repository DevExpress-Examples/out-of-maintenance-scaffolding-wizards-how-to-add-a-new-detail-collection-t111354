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
    public class DepartmentContextUnitOfWork : DbUnitOfWork<DepartmentContext>, IDepartmentContextUnitOfWork {
        Lazy<ICourseRepository> coursesRepository;
        Lazy<IDepartmentRepository> departmentsRepository;
        Lazy<IEmployeeRepository> employeesRepository;

        public DepartmentContextUnitOfWork(DepartmentContext context)
            : base(context) {
            coursesRepository = new Lazy<ICourseRepository>(() => new CourseRepository(this));
            departmentsRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(this));
            employeesRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(this));
        }
        bool IDepartmentContextUnitOfWork.HasChanges() {
            return Context.ChangeTracker.HasChanges();
        }
        ICourseRepository IDepartmentContextUnitOfWork.Courses {
            get { return coursesRepository.Value; }
        }
        IDepartmentRepository IDepartmentContextUnitOfWork.Departments {
            get { return departmentsRepository.Value; }
        }
        IEmployeeRepository IDepartmentContextUnitOfWork.Employees {
            get { return employeesRepository.Value; }
        }
    }
}
