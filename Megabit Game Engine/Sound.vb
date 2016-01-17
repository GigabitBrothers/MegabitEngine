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

Public Class Sound
    Private Shared SND As New irrklang.ISoundEngine(irrklang.SoundOutputDriver.AutoDetect, irrklang.SoundEngineOptionFlag.MultiThreaded)

    Public Shared Sub Listener_Sync()

        SND.SetListenerPosition(playerlocation.X, playerlocation.Y, playerlocation.Z, lookpoint.X, lookpoint.Y, lookpoint.Z)

    End Sub

End Class
