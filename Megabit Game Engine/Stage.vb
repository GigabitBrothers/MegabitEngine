Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports MegabitEngine.Core
Imports MegabitEngine.Paint
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Stage

    Public Shared Async Sub Load(ByVal Path As String)

        Dim result As String = ""
        Dim fileRead As StreamReader = New StreamReader(Path & ".mbw")
        result = fileRead.ReadToEnd
        fileRead.Close()
        Dim resultLines() As String = result.Split(vbLf)
        For Each line As String In resultLines
            Dim parameters() As String = line.Split(Microsoft.VisualBasic.ChrW(32))
            Select Case (parameters(0))

                Case "(flr)"

                    Dim w As Single = Single.Parse(parameters(1))
                    Dim h As Single = Single.Parse(parameters(2))
                    Dim x As Single = Single.Parse(parameters(3))
                    Dim y As Single = Single.Parse(parameters(4))
                    Dim z As Single = Single.Parse(parameters(5))
                    Dim t As Integer = Integer.Parse(parameters(6))

                    Paint.Material(t)
                    Build.Floor(w, h, x, y, z)

                Case "(rf)"

                    Dim w As Single = Single.Parse(parameters(1))
                    Dim h As Single = Single.Parse(parameters(2))
                    Dim x As Single = Single.Parse(parameters(3))
                    Dim y As Single = Single.Parse(parameters(4))
                    Dim z As Single = Single.Parse(parameters(5))
                    Dim t As Integer = Integer.Parse(parameters(6))

                    Paint.Material(t)
                    Build.Roof(w, h, x, y, z)

                Case "(wll)"

                    Dim d As Integer = Integer.Parse(parameters(1))
                    Dim w As Single = Single.Parse(parameters(2))
                    Dim h As Single = Single.Parse(parameters(3))
                    Dim x As Single = Single.Parse(parameters(4))
                    Dim y As Single = Single.Parse(parameters(5))
                    Dim z As Single = Single.Parse(parameters(6))
                    Dim t As Integer = Integer.Parse(parameters(7))

                    Paint.Material(t)
                    Build.Wall(d, w, h, x, y, z)

            End Select

        Next

        Build.Door("left_vertical", "out", 10, 1.25, 30)
        
    End Sub

End Class
