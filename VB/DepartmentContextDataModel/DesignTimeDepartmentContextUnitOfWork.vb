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
    ''' A DepartmentContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IDepartmentContextUnitOfWork interface.
    ''' </summary>
    Public Class DepartmentContextDesignTimeUnitOfWork
        Inherits DesignTimeUnitOfWork
        Implements IDepartmentContextUnitOfWork
        ''' <summary>
        ''' Initializes a new instance of the DepartmentContextDesignTimeUnitOfWork class.
        ''' </summary>
        Public Sub New()
        End Sub
        Private ReadOnly Property Courses As IRepository(Of Course, Integer) Implements IDepartmentContextUnitOfWork.Courses
            Get
                Return GetRepository(Function(x As Course) x.CourseID)
            End Get
        End Property
        Private ReadOnly Property Departments As IRepository(Of Department, Integer) Implements IDepartmentContextUnitOfWork.Departments
            Get
                Return GetRepository(Function(x As Department) x.DepartmentID)
            End Get
        End Property
        Private ReadOnly Property Employees As IRepository(Of Employee, Integer) Implements IDepartmentContextUnitOfWork.Employees
            Get
                Return GetRepository(Function(x As Employee) x.EmployeeID)
            End Get
        End Property
    End Class
End Namespace
