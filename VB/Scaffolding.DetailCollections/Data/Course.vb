Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace Scaffolding.DetailCollections.Model
	Public Class Course
		Private privateCourseID As Integer
		Public Property CourseID() As Integer
			Get
				Return privateCourseID
			End Get
			Set(ByVal value As Integer)
				privateCourseID = value
			End Set
		End Property
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateDepartmentID As Integer
		Public Property DepartmentID() As Integer
			Get
				Return privateDepartmentID
			End Get
			Set(ByVal value As Integer)
				privateDepartmentID = value
			End Set
		End Property
		Private privateDepartment As Department
		Public Overridable Property Department() As Department
			Get
				Return privateDepartment
			End Get
			Set(ByVal value As Department)
				privateDepartment = value
			End Set
		End Property
	End Class
End Namespace