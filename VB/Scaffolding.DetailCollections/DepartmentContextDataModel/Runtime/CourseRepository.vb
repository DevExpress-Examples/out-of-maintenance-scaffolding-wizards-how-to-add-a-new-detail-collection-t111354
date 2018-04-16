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
	Public Class CourseRepository
		Inherits DbRepository(Of Course, Integer, DepartmentContext)
		Implements ICourseRepository
		Public Sub New(ByVal unitOfWork As DbUnitOfWork(Of DepartmentContext))
			MyBase.New(unitOfWork, Function(context) context.Set(Of Course)(), Function(x) x.CourseID)
		End Sub
	End Class
End Namespace