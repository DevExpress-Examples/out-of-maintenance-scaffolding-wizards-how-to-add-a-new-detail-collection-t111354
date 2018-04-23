Imports System.Data.Entity

Namespace Scaffolding.DetailCollections.Model
    Public Class DepartmentContextInitializer
        Inherits DropCreateDatabaseIfModelChanges(Of DepartmentContext)

        Protected Overrides Sub Seed(ByVal context As DepartmentContext)
            MyBase.Seed(context)

            Dim department1 As Department = New Department With {.Name = "Music"}
            Dim department2 As Department = New Department With {.Name = "Journalism"}
            Dim department3 As Department = New Department With {.Name = "Management"}
            context.Departments.Add(department1)
            context.Departments.Add(department2)
            context.Departments.Add(department3)

            context.Courses.AddRange( { _
                New Course With {.Title = "First", .Department = department1}, _
                New Course With {.Title = "Second", .Department = department1}, _
                New Course With {.Title = "Third", .Department = department1}, _
                New Course With {.Title = "First", .Department = department2}, _
                New Course With {.Title = "Second", .Department = department2}, _
                New Course With {.Title = "Third", .Department = department2}, _
                New Course With {.Title = "First", .Department = department3}, _
                New Course With {.Title = "Second", .Department = department3}, _
                New Course With {.Title = "Third", .Department = department3} _
            })

            context.Employees.AddRange( { _
                New Employee With {.Name = "Frankie West PhD", .Department = department1}, _
                New Employee With {.Name = "Jett Mitchell", .Department = department1}, _
                New Employee With {.Name = "Garrick Stiedemann DVM", .Department = department1}, _
                New Employee With {.Name = "Hettie Runte", .Department = department1}, _
                New Employee With {.Name = "Gabe Flatley", .Department = department2}, _
                New Employee With {.Name = "Zetta Beatty", .Department = department2}, _
                New Employee With {.Name = "Ms. Luis Jewess", .Department = department2}, _
                New Employee With {.Name = "Jefferey Legros III", .Department = department3}, _
                New Employee With {.Name = "Margaretta Roberts", .Department = department3} _
            })

            context.SaveChanges()
        End Sub
    End Class
End Namespace