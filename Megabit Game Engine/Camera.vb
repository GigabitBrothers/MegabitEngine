Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Camera

    Public Shared Sub Prepare()

        '-------------------------------------------------
        cameraMatrix = Matrix4.Identity
        playerlocation = New Vector3(0.0, 2.0, 0.0)
        mouseDelta = New Vector2
        '-------------------------------------------------

        System.Windows.Forms.Cursor.Hide()
        Paint.InitMaterials()
        Physics.Initiate_Threads()
        GL_RenderFlags()
        Center_Mouse()

    End Sub

    Public Shared Sub Apply()

        Setup_Camera()

    End Sub

    Private Shared Sub GL_RenderFlags()

        GL.Enable(EnableCap.DepthTest)
        GL.Enable(EnableCap.Dither)
        GL.Enable(EnableCap.Texture2D)
        GL.Enable(EnableCap.AlphaTest)
        GL.Enable(EnableCap.Blend)
        GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha)
        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)

    End Sub

    Private Shared Sub Setup_Camera()

        '---------------------------------------------------
        If pitch <= -1.5 Then
            pitch = -1.5
        End If
        mouseSpeed(0) = (mouseSpeed(0) * 0.5!)
        mouseSpeed(1) = (mouseSpeed(1) * 0.5!)
        mouseSpeed(0) = (mouseSpeed(0) _
                    - (mouseDelta.X / 800.0!))
        mouseSpeed(1) = (mouseSpeed(1) _
                    - (mouseDelta.Y / 800.0!))
        If pitch >= 1 Then
            pitch = 1
        End If
        mouseDelta = New Vector2
        facing = (facing + mouseSpeed(0))
        pitch = (pitch - mouseSpeed(1))
        Dim lookatPoint As Vector3 = New Vector3(CType(Math.Cos(facing), Single), (pitch _
                - ((1 / 2) _
                * (pitch * pitch))), CType(Math.Sin(facing), Single))
        cameraMatrix = Matrix4.LookAt(playerlocation, (playerlocation + lookatPoint), up)
        lookpoint = lookatPoint
        If mousereset = False Then
            System.Windows.Forms.Cursor.Position = New Point((screen_xbound _
                + (screen_width / 2)), (screen_ybound _
                + (screen_height / 2)))
            mousereset = True
        End If
        '----------------------------------------------------

    End Sub

    Public Shared Sub Center_Mouse()

        System.Windows.Forms.Cursor.Position = New Point((screen_xbound _
                + (screen_width / 2)), (screen_ybound _
                + (screen_height / 2)))

    End Sub

    Public Shared Sub Render_Event()

        GL.MatrixMode(MatrixMode.Modelview)
        Optimize.Clear_Buffer()
        GL.LoadMatrix(cameraMatrix)

    End Sub

    Public Shared Sub Resize_Event()

        GL.Viewport(CR_X, CR_Y, CR_Width, CR_Height)
        Dim projection As Matrix4 = Matrix4.CreatePerspectiveFieldOfView((CType(Math.PI, Single) / 4), (CR_Width / CType(CR_Height, Single)), 1.0!, 64.0!)
        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadMatrix(projection)

    End Sub

End Class
