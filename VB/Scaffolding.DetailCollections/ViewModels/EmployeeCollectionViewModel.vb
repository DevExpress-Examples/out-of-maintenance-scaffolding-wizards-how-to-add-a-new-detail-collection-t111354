Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.DepartmentContextDataModel
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Model
Imports Scaffolding.DetailCollections.Common.ViewModel

Namespace Scaffolding.DetailCollections.ViewModels
	Partial Public Class EmployeeCollectionViewModel
		Inherits CollectionViewModel(Of Employee, Integer, IDepartmentContextUnitOfWork)
		Public Sub New()
			Me.New(UnitOfWorkSource.GetUnitOfWorkFactory())
		End Sub
		Public Sub New(ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IDepartmentContextUnitOfWork))
			MyBase.New(unitOfWorkFactory, Function(x) x.Employees)
		End Sub
	End Class
End Namespace