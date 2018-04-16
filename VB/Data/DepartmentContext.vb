Imports Microsoft.VisualBasic
Imports System.Data.Entity

Namespace Scaffolding.DetailCollections.Model
	Public Class DepartmentContext
		Inherits DbContext
		Private privateDepartments As DbSet(Of Department)
		Public Property Departments() As DbSet(Of Department)
			Get
				Return privateDepartments
			End Get
			Set(ByVal value As DbSet(Of Department))
				privateDepartments = value
			End Set
		End Property
		Private privateCourses As DbSet(Of Course)
		Public Property Courses() As DbSet(Of Course)
			Get
				Return privateCourses
			End Get
			Set(ByVal value As DbSet(Of Course))
				privateCourses = value
			End Set
		End Property
		Private privateEmployees As DbSet(Of Employee)
		Public Property Employees() As DbSet(Of Employee)
			Get
				Return privateEmployees
			End Get
			Set(ByVal value As DbSet(Of Employee))
				privateEmployees = value
			End Set
		End Property
	End Class
End Namespace