Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Common.Utils
Imports Common.DataModel
Imports Common.DataModel.EntityFramework
Imports Scaffolding.DetailCollections.Model
Namespace DepartmentContextDataModel
    ''' <summary>
    ''' A DepartmentContextUnitOfWork instance that represents the run-time implementation of the IDepartmentContextUnitOfWork interface.
    ''' </summary>
    Public Class DepartmentContextUnitOfWork
        Inherits DbUnitOfWork(Of DepartmentContext)
        Implements IDepartmentContextUnitOfWork
        ''' <summary>
        ''' Initializes a new instance of the DepartmentContextUnitOfWork class.
        ''' </summary>
        ''' <param name="context">An underlying DbContext.</param>
        Public Sub New(ByVal context As DepartmentContext)
            MyBase.New(context)
        End Sub
        Private ReadOnly Property Courses As IRepository(Of Course, Integer) Implements IDepartmentContextUnitOfWork.Courses
            Get
                Return GetRepository(Function(x) x.[Set](Of Course)(), Function(x) x.CourseID)
            End Get
        End Property
        Private ReadOnly Property Departments As IRepository(Of Department, Integer) Implements IDepartmentContextUnitOfWork.Departments
            Get
                Return GetRepository(Function(x) x.[Set](Of Department)(), Function(x) x.DepartmentID)
            End Get
        End Property
        Private ReadOnly Property Employees As IRepository(Of Employee, Integer) Implements IDepartmentContextUnitOfWork.Employees
            Get
                Return GetRepository(Function(x) x.[Set](Of Employee)(), Function(x) x.EmployeeID)
            End Get
        End Property
    End Class
End Namespace
