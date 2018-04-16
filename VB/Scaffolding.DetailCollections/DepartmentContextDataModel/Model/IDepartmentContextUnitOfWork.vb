Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Common.DataModel.EntityFramework
Imports Scaffolding.DetailCollections.Model

Namespace Scaffolding.DetailCollections.DepartmentContextDataModel
	Public Interface IDepartmentContextUnitOfWork
	Inherits IUnitOfWork
		Function HasChanges() As Boolean
		ReadOnly Property Courses() As ICourseRepository
		ReadOnly Property Departments() As IDepartmentRepository
		ReadOnly Property Employees() As IEmployeeRepository
	End Interface
End Namespace
