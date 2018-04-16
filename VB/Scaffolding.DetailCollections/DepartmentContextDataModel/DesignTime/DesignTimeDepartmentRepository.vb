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
	Public Class DesignTimeDepartmentRepository
		Inherits DesignTimeRepository(Of Department, Integer)
		Implements IDepartmentRepository
		Public Sub New()
			MyBase.New(Function(x) x.DepartmentID)
		End Sub
	End Class
End Namespace