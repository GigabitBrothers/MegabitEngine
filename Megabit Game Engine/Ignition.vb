Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports MegabitEngine.Core
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Ignition

    Public Shared Sub Main()

        Engine_Flags()
        Start()

    End Sub

    Private Shared Sub Start()

        Dim Engine As Core = New Core
        Engine.Run(64, 64)

    End Sub

    Public Shared Sub Quit()

        gravityloop.Abort()
        Application.Exit()

    End Sub

    Private Shared Sub Engine_Flags()

        Window_Width = 1024
        Window_Height = 768
        Window_Title = "Megabit Engine (Codename Midnight) v0.1.25a"
        current_map = "engine\sdk\dev_map\engine_test"

    End Sub

End Class
