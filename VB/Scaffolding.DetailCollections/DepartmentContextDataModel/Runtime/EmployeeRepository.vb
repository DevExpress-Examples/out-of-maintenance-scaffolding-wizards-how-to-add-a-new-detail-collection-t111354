Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.Model
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Common.DataModel.EntityFramework

Namespace Scaffolding.DetailCollections.DepartmentContextDataModel
	Public Class EmployeeRepository
		Inherits DbRepository(Of Employee, Integer, DepartmentContext)
		Implements IEmployeeRepository
		Public Sub New(ByVal unitOfWork As DbUnitOfWork(Of DepartmentContext))
			MyBase.New(unitOfWork, Function(context) context.Set(Of Employee)(), Function(x) x.EmployeeID)
		End Sub
	End Class
End Namespace