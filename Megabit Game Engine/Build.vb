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

Public Class Build

    Public Shared Sub Wall(ByVal facedirection As Integer, ByVal width As Double, ByVal height As Double, ByVal posX As Double, ByVal posY As Double, ByVal posZ As Double)

        If facedirection = 3 Then

            GL.Begin(BeginMode.Quads)
            GL.Normal3(posX + width / 2.0, posY + height / 2.0, posZ - 1.0)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + height, posZ)
            GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + width, posY + height, posZ)
            GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + width, posY, posZ)
            GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, posY, posZ)
            GL.End()

            'Calculate Bounding Box -----
            If playerlocation.Z < posZ + 1.45 Then
                If playerlocation.Z > posZ - 1.45 Then
                    If playerlocation.X < posX + width + 1.45 Then
                        If playerlocation.Y > posY - 0.75 Then
                            If playerlocation.Y < posY + height + 0.75 Then
                                If playerlocation.X > posX - 1.45 Then
                                    cbnd(14) = posZ
                                    cbnd(15) = posZ + 1.45
                                    cbnd(16) = posZ - 1.45
                                    cbnd(17) = posX - 1.45
                                    cbnd(18) = posX + (width + 1.45)
                                    cbnd(19) = posY - 1.45
                                    cbnd(20) = posY + (height + 1.45)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            '----------------------------

        End If


        If facedirection = 1 Then

            GL.Begin(BeginMode.Quads)
            GL.Normal3(posX + width / 2.0, posY + height / 2.0, posZ + 1.0)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + height, posZ)
            GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + width, posY + height, posZ)
            GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + width, posY, posZ)
            GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, posY, posZ)
            GL.End()

            'Calculate Bounding Box -----
            If playerlocation.Z < posZ + 1.45 Then
                If playerlocation.Z > posZ - 1.45 Then
                    If playerlocation.X < posX + width + 1.45 Then
                        If playerlocation.Y > posY - 0.75 Then
                            If playerlocation.Y < posY + height + 0.75 Then
                                If playerlocation.X > posX - 1.45 Then
                                    cbnd(21) = posZ
                                    cbnd(22) = posZ + 1.45
                                    cbnd(23) = posZ - 1.45
                                    cbnd(24) = posX - 1.45
                                    cbnd(25) = posX + (width + 1.45)
                                    cbnd(26) = posY - 0.75
                                    cbnd(27) = posY + (height + 0.75)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            '----------------------------

        End If

        If facedirection = 2 Then

            GL.Begin(BeginMode.Quads)
            GL.Normal3(posX + 1.0, posY + height / 2.0, posZ + width / 2.0)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + height, posZ)
            GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + height, posZ + width)
            GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ + width)
            GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, posY, posZ)
            GL.End()

            'Calculate Bounding Box -----
            If playerlocation.Z <= posZ + width - 1.45 Then
                If playerlocation.Y > posY - 0.75 Then
                    If playerlocation.Y < posY + height + 1.75 Then
                        If playerlocation.Z > posZ + 1.45 Then
                            cbnd(7) = posX
                            cbnd(8) = posX - 1.45
                            cbnd(9) = posX + 1.45
                            cbnd(10) = posZ
                            cbnd(11) = posZ + (width + 1.45)
                            cbnd(12) = posY - 0.75
                            cbnd(13) = posY + (height + 1.45)
                        End If
                    End If
                End If
            End If

        End If

        '----------------------------

        If facedirection = 4 Then

            GL.Begin(BeginMode.Quads)
            GL.Normal3(posX - 1.0, posY + height / 2.0, posZ + -width / 2.0)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + height, posZ)
            GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + height, posZ + -width)
            GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ + -width)
            GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, posY, posZ)
            GL.End()



            'Calculate Bounding Box -----
            If playerlocation.Z > posZ + -width - 1.45 Then
                If playerlocation.Y > posY - 0.75 Then
                    If playerlocation.Y < posY + height + 0.75 Then
                        If playerlocation.Z < posZ + 1.45 Then
                            cbnd(0) = posX
                            cbnd(1) = posX + 1.45
                            cbnd(2) = posY - 1.45
                            cbnd(3) = posY + (height + 1.45)
                            cbnd(4) = posZ + 1.45
                            cbnd(5) = posZ + (-width - 1.45)
                            cbnd(6) = posX - 1.45
                        End If
                    End If
                End If
            End If
            '----------------------------

        End If

    End Sub

    Public Shared Sub Floor(ByVal width As Double, ByVal height As Double, ByVal posX As Double, ByVal posY As Double, ByVal posZ As Double)

        GL.Begin(BeginMode.Quads)
        GL.Normal3(posX + width / 2.0, posY + 1.0, posZ + height / 2.0)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + width, posY, posZ + height)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY, posZ + height)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + width, posY, posZ)
        GL.End()

        If playerlocation.Y < posY Then
            'Calculate Bounding Box -----
            cbnd(48) = posY
            If posY = groundlevel - 0.5 Then
                cbnd(49) = posY - 0.375
            Else
                cbnd(49) = posY - 1.45
            End If
            cbnd(40) = posX
            cbnd(41) = posX + width
            cbnd(42) = posZ
            cbnd(43) = posZ + height
            cbnd(44) = posY + 1.45
            '----------------------------
        End If

        If playerlocation.Y > posY Then
            If playerlocation.X >= posX And playerlocation.X <= posX + width Then
                If playerlocation.Z >= posZ And playerlocation.Z <= posZ + height Then
                    groundlevel = posY + 2
                End If
            End If
        End If


    End Sub

    Public Shared Sub Roof(ByVal width As Double, ByVal height As Double, ByVal posX As Double, ByVal posY As Double, ByVal posZ As Double)

        GL.Begin(BeginMode.Quads)
        GL.Normal3(posX + width / 2.0, posY - 1.0, posZ + height / 2.0)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + width, posY, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ + height)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + width, posY, posZ + height)
        GL.End()

        'Calculate Bounding Box -----
        cbnd(28) = posY
        If posY = groundlevel - 0.5 Then
            cbnd(29) = posY - 0.375
        Else
            cbnd(29) = posY - 1.45
        End If
        cbnd(30) = posX
        cbnd(31) = posX + width
        cbnd(32) = posZ
        cbnd(33) = posZ + height
        cbnd(34) = posY + 1.45
        '----------------------------

        If posY >= 3 Then
            If playerlocation.Y > posY Then
                If playerlocation.X >= cbnd(30) And playerlocation.X <= cbnd(31) Then
                    If playerlocation.Z >= cbnd(32) And playerlocation.Z <= cbnd(33) Then
                        groundlevel = cbnd(28) + 2
                    End If
                End If
            End If
        End If

    End Sub

    Public Shared Sub Rail(ByVal posX As Double, ByVal posY As Double, ByVal posZ As Double, Optional stexture As String = "devrail")

        'Rail Specifications --------------------
        Dim width As Double = 2.1875
        Dim height As Double = 1.25
        Dim raildepth As Double = 0.3125
        Dim barwidth As Double = 0.15625
        '----------------------------------------

        If playerlocation.Z < (posZ + width) Then
            If playerlocation.Z > (posZ - 1.45) Then
                If playerlocation.Y <= (posY + height) + 1.45 Then
                    If playerlocation.Y >= (posY - 0.75) Then
                        'Calculate Bounding Box -----
                        cbnd(100) = (posZ + width) + 1.45
                        cbnd(101) = (posZ - 1.45)
                        cbnd(102) = (posY + height) + 1.45
                        cbnd(103) = (posY - 0.75)
                        cbnd(104) = (posX + raildepth) + 1.45
                        cbnd(105) = posX - 1.45
                        cbnd(106) = posX
                        cbnd(107) = (posX + raildepth)
                        '----------------------------
                    End If
                End If
            End If
        End If

        'Bottom Bar Render Code ------------------------------------------------------------------
        Paint.Material(stexture + "pt1")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY, posZ + width)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY + barwidth, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, posY + barwidth, posZ + width)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.Normal3((posX + raildepth) + 1.0, posY + barwidth / 2.0, posZ + width / 2.0)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + barwidth, posZ + width)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + raildepth, posY + barwidth, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + raildepth, posY, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, posY, posZ + width)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + barwidth, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + barwidth, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, posY, posZ)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + barwidth, posZ + width)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + barwidth, posZ + width)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ + width)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, posY, posZ + width)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY, posZ + width)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, posY, posZ + width)
        GL.End()

        Paint.Material(stexture + "pt2")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + barwidth, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + barwidth, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY + barwidth, posZ + width)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, posY + barwidth, posZ + width)
        GL.End()
        '-----------------------------------------------------------------------------------------

        'Top Bar Render Code ---------------------------------------------------------------------
        Paint.Material(stexture + "pt1")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + height, posZ + width)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + height, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, posZ + width)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + height, posZ + width)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + raildepth, posY + height, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, posZ + width)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + height, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + height, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, posZ)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, posZ)
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + height, posZ + width)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + height, posZ + width)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, posZ + width)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, posZ + width)
        GL.End()

        Paint.Material(stexture + "pt2")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, posZ + width)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, posZ + width)
        GL.End()

        Paint.Material(stexture + "pt1")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, posY + height, posZ)
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + height, posZ)
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, posY + height, posZ + width)
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, posY + height, posZ + width)
        GL.End()
        '-----------------------------------------------------------------------------------------

        'Column Render Code ----------------------------------------------------------------------
        Paint.Material(stexture + "pt1")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth + 0) * 2) - 0) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 2) - 0))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 2) - 0))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 2) - 0) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 5) - 0) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 5) - 0))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 5) - 0))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 5) - 0) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 8) - 0) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 8) - 0))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 8) - 0))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 8) - 0) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 11)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 11)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 11)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 11)) + (barwidth))
        GL.End()

        '1----

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 2)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 2)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 2)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 2)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 5)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 5)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 5)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 5)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 8)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 8)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 8)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 8)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 11)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 11)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 11)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 11)) + (barwidth))
        GL.End()

        '2----

        Paint.Material(stexture + "pt2")
        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 2)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 2)) + (barwidth))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 2)) + (barwidth))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 2)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 5)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 5)) + (barwidth))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 5)) + (barwidth))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 5)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 8)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 8)) + (barwidth))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 8)) + (barwidth))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 8)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 11)) + (barwidth))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 11)) + (barwidth))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 11)) + (barwidth))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 11)) + (barwidth))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 2)))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 2)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 2)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 2)))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 5)))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 5)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 5)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 5)))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 8)))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 8)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 8)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 8)))
        GL.End()

        GL.Begin(BeginMode.Quads)
        GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + raildepth, (posY + height) - barwidth, (posZ + ((barwidth) * 11)))
        GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, (posY + height) - barwidth, (posZ + ((barwidth) * 11)))
        GL.TexCoord2(width / 1.25, height / 1.25) : GL.Vertex3(posX, (posY + barwidth), (posZ + ((barwidth) * 11)))
        GL.TexCoord2(0.0, height / 1.25) : GL.Vertex3(posX + raildepth, (posY + barwidth), (posZ + ((barwidth) * 11)))
        GL.End()
    End Sub

    Public Shared Sub Stairs(ByVal direction As String, ByVal width As Double, ByVal length As Double, ByVal posX As Double, ByVal posY As Double, ByVal posZ As Double, Optional stexture As String = "devstairs")

        If direction = "east" Then

            'GL.Begin(BeginMode.Quads)
            'GL.Normal3(posX + 1.0, posY + Height / 2.0, posZ + width / 2.0)
            'GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + Height, posZ)
            'GL.TexCoord2(width / 1.25, 0.0) : GL.Vertex3(posX, posY + Height, posZ + width)
            'GL.TexCoord2(width / 1.25, Height / 1.25) : GL.Vertex3(posX, posY, posZ + width)
            'GL.TexCoord2(0.0, Height / 1.25) : GL.Vertex3(posX, posY, posZ)
            'GL.End()

        End If

    End Sub

    Public Shared Sub Door(ByVal hingeorgin As String, ByVal swingdirection As String, ByVal posX As Double, ByVal posY As Double, ByVal posZ As Double)

        If hingeorgin = "left_vertical" Then

            If swingdirection = "in" Then
                Paint.Material(5)
                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY + 3.4375, posZ - dr_val2(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY, posZ - dr_val2(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ)
                GL.End()

                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY + 3.4375, posZ + 0.15625 - dr_val3(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY + 3.4375, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX - dr_val3(1), posY, posZ + 0.15625 - dr_val3(1))
                GL.End()

                Paint.Material(6)
                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY + 3.4375, posZ - dr_val2(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY + 3.4375, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY, posZ - dr_val2(1))
                GL.End()

                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY + 3.4375, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX - dr_val3(1), posY, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ)
                GL.End()
                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY + 3.4375, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY + 3.4375, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY + 3.4375, posZ - dr_val2(1))
                GL.End()

                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY, posZ)
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY, posZ - dr_val2(1))
                GL.End()
            End If

            If swingdirection = "out" Then
                Paint.Material(5)
                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY + 3.4375, posZ + dr_val2(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY, posZ + dr_val2(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ)
                GL.End()

                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY + 3.4375, (posZ + 0.15625 - dr_val3(1)))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY + 3.4375, ((posZ + 0.15625) - dr_val3(1)) + dr_val2(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY, ((posZ + 0.15625) - dr_val3(1)) + dr_val2(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX - dr_val3(1), posY, (posZ + 0.15625 - dr_val3(1)))
                GL.End()

                Paint.Material(6)
                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY + 3.4375, posZ - dr_val2(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY + 3.4375, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY, posZ - dr_val2(1))
                GL.End()

                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY + 3.4375, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX - dr_val3(1), posY, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ)
                GL.End()
                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY + 3.4375, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY + 3.4375, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY + 3.4375, posZ - dr_val2(1))
                GL.End()

                GL.Begin(BeginMode.Quads)
                GL.TexCoord2(0.0, 0.0) : GL.Vertex3((posX - 1.875) + dr_val1(1), posY, (posZ + 0.15625) - dr_val4(1))
                GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX - dr_val3(1), posY, (posZ + 0.15625) - dr_val3(1))
                GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY, posZ)
                GL.TexCoord2(0.0, 1.0) : GL.Vertex3((posX - 1.875) + dr_val2(1), posY, posZ - dr_val2(1))
                GL.End()
            End If


        End If

        If hingeorgin = "right_vertical" Then

            Paint.Material(5)
            GL.Begin(BeginMode.Quads)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
            GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX + 1.875, posY + 3.4375, posZ)
            GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX + 1.875, posY, posZ)
            GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ)
            GL.End()

            GL.Begin(BeginMode.Quads)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ + 0.15625)
            GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX + 1.875, posY + 3.4375, posZ + 0.15625)
            GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX + 1.875, posY, posZ + 0.15625)
            GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ + 0.15625)
            GL.End()

            Paint.Material(6)
            GL.Begin(BeginMode.Quads)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + 1.875, posY + 3.4375, posZ)
            GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX + 1.875, posY + 3.4375, posZ + 0.15625)
            GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX + 1.875, posY, posZ + 0.15625)
            GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX + 1.875, posY, posZ)
            GL.End()

            GL.Begin(BeginMode.Quads)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
            GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ + 0.15625)
            GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY, posZ + 0.15625)
            GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX, posY, posZ)
            GL.End()

            GL.Begin(BeginMode.Quads)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + 1.875, posY + 3.4375, posZ + 0.15625)
            GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX, posY + 3.4375, posZ + 0.15625)
            GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY + 3.4375, posZ)
            GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX + 1.875, posY + 3.4375, posZ)
            GL.End()

            GL.Begin(BeginMode.Quads)
            GL.TexCoord2(0.0, 0.0) : GL.Vertex3(posX + 1.875, posY, posZ + 0.15625)
            GL.TexCoord2(1.0, 0.0) : GL.Vertex3(posX, posY, posZ + 0.15625)
            GL.TexCoord2(1.0, 1.0) : GL.Vertex3(posX, posY, posZ)
            GL.TexCoord2(0.0, 1.0) : GL.Vertex3(posX + 1.875, posY, posZ)
            GL.End()

            'hello

        End If

    End Sub

End Class
