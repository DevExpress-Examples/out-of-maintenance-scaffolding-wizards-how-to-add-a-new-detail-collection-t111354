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
	Public Class DesignTimeCourseRepository
		Inherits DesignTimeRepository(Of Course, Integer)
		Implements ICourseRepository
		Public Sub New()
			MyBase.New(Function(x) x.CourseID)
		End Sub
	End Class
End Namespace