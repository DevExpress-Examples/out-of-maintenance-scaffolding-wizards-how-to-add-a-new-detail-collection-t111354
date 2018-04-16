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
	Public Class DepartmentContextUnitOfWork
		Inherits DbUnitOfWork(Of DepartmentContext)
		Implements IDepartmentContextUnitOfWork
		Private coursesRepository As Lazy(Of ICourseRepository)
		Private departmentsRepository As Lazy(Of IDepartmentRepository)
		Private employeesRepository As Lazy(Of IEmployeeRepository)

		Public Sub New(ByVal context As DepartmentContext)
			MyBase.New(context)
			coursesRepository = New Lazy(Of ICourseRepository)(Function() New CourseRepository(Me))
			departmentsRepository = New Lazy(Of IDepartmentRepository)(Function() New DepartmentRepository(Me))
			employeesRepository = New Lazy(Of IEmployeeRepository)(Function() New EmployeeRepository(Me))
		End Sub
		Private Function HasChanges() As Boolean Implements IDepartmentContextUnitOfWork.HasChanges
			Return Context.ChangeTracker.HasChanges()
		End Function
		Private ReadOnly Property Courses() As ICourseRepository Implements IDepartmentContextUnitOfWork.Courses
			Get
				Return coursesRepository.Value
			End Get
		End Property
		Private ReadOnly Property Departments() As IDepartmentRepository Implements IDepartmentContextUnitOfWork.Departments
			Get
				Return departmentsRepository.Value
			End Get
		End Property
		Private ReadOnly Property Employees() As IEmployeeRepository Implements IDepartmentContextUnitOfWork.Employees
			Get
				Return employeesRepository.Value
			End Get
		End Property
	End Class
End Namespace
