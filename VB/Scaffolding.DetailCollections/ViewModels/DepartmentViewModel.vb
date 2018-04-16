Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.DepartmentContextDataModel
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Model
Imports Scaffolding.DetailCollections.Common.ViewModel

Namespace Scaffolding.DetailCollections.ViewModels
	Partial Public Class DepartmentViewModel
		Inherits SingleObjectViewModel(Of Department, Integer, IDepartmentContextUnitOfWork)
		Public Sub New()
			Me.New(UnitOfWorkSource.GetUnitOfWorkFactory())
		End Sub
		Public Sub New(ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork))
			MyBase.New(unitOfWorkFactory, Function(x) x.Departments)
		End Sub
		Protected Overrides Sub RefreshLookUpCollections(ByVal key As Integer)
			DepartmentCoursesLookUp = CreateLookUpCollectionViewModel(Function(x) x.Courses, Function(x) x.DepartmentID = key, key)
			DepartmentEmployeesLookUp = CreateLookUpCollectionViewModel(Function(x) x.Employees, Function(x) x.DepartmentID = key, key)
		End Sub
		Private privateDepartmentCoursesLookUp As LookUpCollectionViewModel(Of Department, Course, Integer, IDepartmentContextUnitOfWork)
		Public Overridable Property DepartmentCoursesLookUp() As LookUpCollectionViewModel(Of Department, Course, Integer, IDepartmentContextUnitOfWork)
			Get
				Return privateDepartmentCoursesLookUp
			End Get
			Set(ByVal value As LookUpCollectionViewModel(Of Department, Course, Integer, IDepartmentContextUnitOfWork))
				privateDepartmentCoursesLookUp = value
			End Set
		End Property
		Private privateDepartmentEmployeesLookUp As LookUpCollectionViewModel(Of Department, Employee, Integer, IDepartmentContextUnitOfWork)
		Public Overridable Property DepartmentEmployeesLookUp() As LookUpCollectionViewModel(Of Department, Employee, Integer, IDepartmentContextUnitOfWork)
			Get
				Return privateDepartmentEmployeesLookUp
			End Get
			Set(ByVal value As LookUpCollectionViewModel(Of Department, Employee, Integer, IDepartmentContextUnitOfWork))
				privateDepartmentEmployeesLookUp = value
			End Set
		End Property
	End Class
End Namespace
