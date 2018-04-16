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
	Public Class DesignTimeEmployeeRepository
		Inherits DesignTimeRepository(Of Employee, Integer)
		Implements IEmployeeRepository
		Public Sub New()
			MyBase.New(Function(x) x.EmployeeID)
		End Sub
	End Class
End Namespace