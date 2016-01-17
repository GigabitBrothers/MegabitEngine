Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports MegabitEngine.Core
Imports MegabitEngine.Build
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Motion

    Public Shared Sub Forward()

        If noclip = False Then
            playerlocation.X = (playerlocation.X _
                        + (CType(Math.Cos(facing), Single) * walkspeed))
            playerlocation.Z = (playerlocation.Z _
                        + (CType(Math.Sin(facing), Single) * walkspeed))
            Check_Collisions()
        Else
            playerlocation.X = (playerlocation.X _
                        + (CType(Math.Cos(facing), Single) * walkspeed))
            playerlocation.Z = (playerlocation.Z _
                        + (CType(Math.Sin(facing), Single) * walkspeed))
            playerlocation.Y = (playerlocation.Y _
                        + (CType(Math.Sin(pitch), Single) * walkspeed))
        End If

    End Sub

    Public Shared Sub Backward()

        If noclip = False Then
            playerlocation.X = (playerlocation.X _
                        - (CType(Math.Cos(facing), Single) * walkspeed))
            playerlocation.Z = (playerlocation.Z _
                        - (CType(Math.Sin(facing), Single) * walkspeed))
            Check_Collisions()
        Else
            playerlocation.X = (playerlocation.X _
                        - (CType(Math.Cos(facing), Single) * walkspeed))
            playerlocation.Z = (playerlocation.Z _
                        - (CType(Math.Sin(facing), Single) * walkspeed))
            playerlocation.Y = (playerlocation.Y _
                        - (CType(Math.Sin(pitch), Single) * walkspeed))
        End If

    End Sub

    Public Shared Sub Move_Left()

        playerlocation.X = (playerlocation.X _
                        - (CType(Math.Cos((facing _
                            + (Math.PI / 2))), Single) * walkspeed))
        playerlocation.Z = (playerlocation.Z _
                    - (CType(Math.Sin((facing _
                        + (Math.PI / 2))), Single) * walkspeed))
        Check_Collisions()

    End Sub

    Public Shared Sub Move_Right()

        playerlocation.X = (playerlocation.X _
                                + (CType(Math.Cos((facing _
                                    + (Math.PI / 2))), Single) * walkspeed))
        playerlocation.Z = (playerlocation.Z _
                    + (CType(Math.Sin((facing _
                        + (Math.PI / 2))), Single) * walkspeed))
        Check_Collisions()

    End Sub

    Public Shared Sub Speed_Shift(ByVal shiftlvl As Integer)

        If shiftlvl = 0 Then
            walkspeed = defaultwalkspeed
        End If

        If shiftlvl = 1 Then
            walkspeed = defaultwalkspeed * 2
        End If

    End Sub

    Public Shared Sub Crouch(ByVal crstate As Integer)

        If noclip = False Then

            If crstate = 1 Then

                If allowcrouch = True Then

                    allowjump = False
                    crouching = True

                    If playerlocation.Y > groundlevel - 0.85 Then
                        playerlocation.Y -= 0.0625
                    End If

                End If

            End If

            Check_Collisions()

            If crstate = 0 Then

                If crouching = True Then

                    If playerlocation.Y < groundlevel Then
                        playerlocation.Y += 0.0625
                    End If

                    If playerlocation.Y = groundlevel Then
                        crouching = False
                        jptrig_ignore = False
                        allowjump = True
                    End If

                End If

            End If

        Else

            If crstate = 1 Then
                playerlocation.Y -= 0.1
                jptrig_ignore = True
            End If

        End If

    End Sub

    Public Shared Sub Jump(ByVal jpstate As Integer)

        If noclip = False Then

            If jpstate = 0 Then
                hasjumped = False
            End If

            If jpstate = 1 And jptrig_ignore = False Then
                allowcrouch = False
                If allowjump = True And hasjumped = False Then
                    allowcrouch = False
                    begin_jump = True
                    jumping = True
                End If
            End If

            Check_Collisions()

        Else

            If jpstate = 1 Then
                playerlocation.Y += 0.1
            End If

        End If

    End Sub

End Class
