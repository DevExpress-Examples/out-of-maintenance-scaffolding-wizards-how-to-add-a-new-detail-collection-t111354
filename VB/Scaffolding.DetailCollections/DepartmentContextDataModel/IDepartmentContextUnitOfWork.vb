﻿Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Scaffolding.DetailCollections.Common.Utils
Imports Scaffolding.DetailCollections.Common.DataModel
Imports Scaffolding.DetailCollections.Common.DataModel.EntityFramework
Imports Scaffolding.DetailCollections.Model

Namespace Scaffolding.DetailCollections.DepartmentContextDataModel
    ''' <summary>
    ''' IDepartmentContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    ''' </summary>
    Public Interface IDepartmentContextUnitOfWork
        Inherits IUnitOfWork

        ''' <summary>
        ''' The Course entities repository.
        ''' </summary>
        ReadOnly Property Courses() As IRepository(Of Course, Integer)

        ''' <summary>
        ''' The Department entities repository.
        ''' </summary>
        ReadOnly Property Departments() As IRepository(Of Department, Integer)

        ''' <summary>
        ''' The Employee entities repository.
        ''' </summary>
        ReadOnly Property Employees() As IRepository(Of Employee, Integer)
    End Interface
End Namespace
