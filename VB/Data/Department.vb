Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace Scaffolding.DetailCollections.Model
	Public Class Department
		Public Sub New()
			Courses = New HashSet(Of Course)()
			Employees = New HashSet(Of Employee)()
		End Sub
		Private privateDepartmentID As Integer
		Public Property DepartmentID() As Integer
			Get
				Return privateDepartmentID
			End Get
			Set(ByVal value As Integer)
				privateDepartmentID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateCourses As ICollection(Of Course)
		Public Overridable Property Courses() As ICollection(Of Course)
			Get
				Return privateCourses
			End Get
			Set(ByVal value As ICollection(Of Course))
				privateCourses = value
			End Set
		End Property
		Private privateEmployees As ICollection(Of Employee)
		Public Overridable Property Employees() As ICollection(Of Employee)
			Get
				Return privateEmployees
			End Get
			Set(ByVal value As ICollection(Of Employee))
				privateEmployees = value
			End Set
		End Property
	End Class
End Namespace