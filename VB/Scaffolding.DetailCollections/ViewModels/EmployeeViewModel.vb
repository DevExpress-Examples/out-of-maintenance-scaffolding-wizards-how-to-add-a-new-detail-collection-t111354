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
	Partial Public Class EmployeeViewModel
		Inherits SingleObjectViewModel(Of Employee, Integer, IDepartmentContextUnitOfWork)
		Public Sub New()
			Me.New(UnitOfWorkSource.GetUnitOfWorkFactory())
		End Sub
		Public Sub New(ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork))
			MyBase.New(unitOfWorkFactory, Function(x) x.Employees)
		End Sub
		Public ReadOnly Property LookUpDepartments() As IList(Of Department)
			Get
				Return GetLookUpEntities(UnitOfWork.Departments)
			End Get
		End Property
		Protected Overrides Function TryInitializeDetail(ByVal detailEntityInfo As IDetailEntityInfo) As Boolean
'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: Return TryInitializeDetail(detailEntityInfo, UnitOfWork.Departments, (entity, detailEntity) => entity.Department = detailEntity);
            Return TryInitializeDetail(detailEntityInfo, UnitOfWork.Departments, Sub(entity, detailEntity) entity.Department = detailEntity)
		End Function
	End Class
End Namespace
