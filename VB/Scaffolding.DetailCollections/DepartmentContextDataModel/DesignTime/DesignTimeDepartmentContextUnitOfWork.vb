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
	Public Class DepartmentContextDesignTimeUnitOfWork
		Inherits DesignTimeUnitOfWork
		Implements IDepartmentContextUnitOfWork
		Private Shared coursesRepository As New DesignTimeCourseRepository()
		Private Shared departmentsRepository As New DesignTimeDepartmentRepository()
		Private Shared employeesRepository As New DesignTimeEmployeeRepository()

		Public Sub New()
		End Sub

		Private Function HasChanges() As Boolean Implements IDepartmentContextUnitOfWork.HasChanges
			Return False
		End Function
		Private ReadOnly Property Courses() As ICourseRepository Implements IDepartmentContextUnitOfWork.Courses
			Get
				Return coursesRepository
			End Get
		End Property
		Private ReadOnly Property Departments() As IDepartmentRepository Implements IDepartmentContextUnitOfWork.Departments
			Get
				Return departmentsRepository
			End Get
		End Property
		Private ReadOnly Property Employees() As IEmployeeRepository Implements IDepartmentContextUnitOfWork.Employees
			Get
				Return employeesRepository
			End Get
		End Property
		Public Overloads Sub Detach(ByVal entity As Object) Implements Scaffolding.DetailCollections.Common.DataModel.IUnitOfWork.Detach
		End Sub
	End Class
End Namespace
