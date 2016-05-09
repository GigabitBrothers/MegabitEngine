Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports MegabitEngine.Objects
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Core

    Inherits GameWindow

    Public Sub New()

        MyBase.New(Window_Width, Window_Height, New OpenTK.Graphics.GraphicsMode(32, 24, 0, 2), Window_Title)

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)

        MyBase.OnLoad(e)
        screen_height = Bounds.Height
        screen_width = Bounds.Width
        screen_xbound = Bounds.Left
        screen_ybound = Bounds.Top
        Camera.Prepare()
        AddHandler Mouse.Move, AddressOf Me.OnMouseMove
        Me.WindowState = OpenTK.WindowState.Maximized


    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)

        MyBase.OnResize(e)
        CR_X = ClientRectangle.X
        CR_Y = ClientRectangle.Y
        CR_Width = ClientRectangle.Width
        CR_Height = ClientRectangle.Height
        Camera.Resize_Event()

    End Sub

    Protected Overrides Sub OnRenderFrame(ByVal e As FrameEventArgs)

        MyBase.OnRenderFrame(e)
        Camera.Render_Event()
        Stage.Load(Current_Map)
        HUDTest()
        SwapBuffers()

    End Sub

    Public Sub HUDTest()

        GL.MatrixMode(MatrixMode.Projection)
        GL.PushMatrix()
        GL.LoadIdentity()
        GL.Ortho(-screen_width, screen_width, -screen_height, screen_height, -1, 1)
        GL.MatrixMode(MatrixMode.Modelview)
        GL.PushMatrix()
        GL.LoadIdentity()
        GL.Clear(ClearBufferMask.DepthBufferBit)

        GL.BindTexture(TextureTarget.Texture2D, textures(7))

        GL.Begin(BeginMode.TriangleFan)

        GL.Vertex3(-1.0F, -0.5F, -4.0F)
        GL.Vertex3(1.0F, -0.5F, -4.0F)
        GL.Vertex3(0.0F, 0.5F, -4.0F)

        GL.Vertex3(-1.5F, 0.0F, -4.0F)
        GL.Vertex3(-1.8F, -1.0F, -4.0F)
        GL.Vertex3(0.2F, -1.5F, -4.0F)

        GL.Vertex3(1.0F, -0.5F, -4.0F)

        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0, 0) : GL.Vertex2(-25, 35)
        GL.TexCoord2(1, 0) : GL.Vertex2(25, 35)
        GL.TexCoord2(1, 1) : GL.Vertex2(25, -35)
        GL.TexCoord2(0, 1) : GL.Vertex2(-25, -35)
        GL.End()

        GL.BindTexture(TextureTarget.Texture2D, textures(8))

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0, 0) : GL.Vertex2(25, 81)
        GL.TexCoord2(1, 0) : GL.Vertex2(60, 81)
        GL.TexCoord2(1, 1) : GL.Vertex2(60, 36)
        GL.TexCoord2(0, 1) : GL.Vertex2(25, 36)
        GL.End()

        GL.BindTexture(TextureTarget.Texture2D, textures(9))

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0, 0) : GL.Vertex2((-screen_width + 10), (-screen_height + 0) + 225)
        GL.TexCoord2(1, 0) : GL.Vertex2((-screen_width + 10) + 500, (-screen_height + 11) + 225)
        GL.TexCoord2(1, 1) : GL.Vertex2((-screen_width + 10) + 500, (-screen_height + 9))
        GL.TexCoord2(0, 1) : GL.Vertex2((-screen_width + 10), (-screen_height + 11))
        GL.End()

        GL.MatrixMode(MatrixMode.Projection)
        GL.PopMatrix()
        GL.MatrixMode(MatrixMode.Modelview)
        GL.PopMatrix()

    End Sub

    Protected Overrides Sub OnUpdateFrame(ByVal e As FrameEventArgs)

        ' ----- IGNORE THIS SECTION FOR NOW -----
        Gravity()
        Controls()
        Objects.Interactive_Logic()
        Camera.Apply()
        'Me.Title = playerlocation.Y
        '----------------------------------------

    End Sub

    Private Overloads Sub OnMouseMove(ByVal sender As Object, ByVal e As MouseMoveEventArgs)

        If mousereset = True Then
            mouseDelta = New Vector2(e.XDelta, e.YDelta)
            mousereset = False
        End If

    End Sub

    Public Sub Controls()

        If Keyboard(Input.Key.Escape) Then
            Me.Close()
            Ignition.Quit()
        End If

        If Keyboard(Input.Key.W) Then
            Forward()
        End If

        If Keyboard(Input.Key.S) Then
            Backward()
        End If

        If Keyboard(Input.Key.A) Then
            Move_Left()
        End If

        If Keyboard(Input.Key.D) Then
            Move_Right()
        End If
        If Keyboard(Input.Key.V) Then
            If door_trig1 = True Then
                door_rotating = True
                dr_rotdir = "opening"
            End If
        End If

        If Keyboard(Input.Key.B) Then
            door_rotating = True
            dr_rotdir = "closing"
        End If

        If Keyboard(Input.Key.LControl) Then
            Crouch(1)
        Else
            Crouch(0)
        End If

        If Keyboard(Input.Key.Space) Then
            Jump(1)
        Else
            Jump(0)
        End If

    End Sub

End Class