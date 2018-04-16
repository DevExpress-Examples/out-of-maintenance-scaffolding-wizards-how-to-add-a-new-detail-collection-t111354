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
	Public Class DepartmentRepository
		Inherits DbRepository(Of Department, Integer, DepartmentContext)
		Implements IDepartmentRepository
		Public Sub New(ByVal unitOfWork As DbUnitOfWork(Of DepartmentContext))
			MyBase.New(unitOfWork, Function(context) context.Set(Of Department)(), Function(x) x.DepartmentID)
		End Sub
	End Class
End Namespace