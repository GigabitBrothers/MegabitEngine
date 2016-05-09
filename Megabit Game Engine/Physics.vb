Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports System.Threading
Imports MegabitEngine.Core
Imports MegabitEngine.Build
Imports System.Drawing.Point
Imports MegabitEngine.Motion
Imports System.Windows.Forms
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Physics

    Public Shared Sub Initiate_Threads()

        gravityloop.Start()
        collisionloop.Start()
        'collisionloop.Priority = Threading.ThreadPriority.Highest
        'gravityloop.Priority = Threading.ThreadPriority.AboveNormal

    End Sub

    Public Shared Sub Detect_Collisions()

        If noclip = False Then

            If playerlocation.X < cbnd(106) Then
                If playerlocation.Z <= cbnd(100) Then
                    If playerlocation.Z > cbnd(101) Then
                        If playerlocation.Y <= cbnd(102) Then
                            If playerlocation.Y >= cbnd(103) Then
                                If playerlocation.X > cbnd(105) Then
                                    playerlocation.X = cbnd(105)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X > cbnd(107) Then
                If playerlocation.Z <= cbnd(100) Then
                    If playerlocation.Z > cbnd(101) Then
                        If playerlocation.Y <= cbnd(102) Then
                            If playerlocation.Y >= cbnd(103) Then
                                If playerlocation.X < cbnd(104) Then
                                    playerlocation.X = cbnd(104)
                                End If
                            End If
                        End If
                    End If
                End If
            End If


            If playerlocation.X < cbnd(7) And playerlocation.Z < cbnd(11) Then
                If playerlocation.Y > cbnd(12) Then
                    If playerlocation.Y < cbnd(13) Then
                        If playerlocation.X > cbnd(8) Then
                            If playerlocation.Z > cbnd(10) Then
                                playerlocation.X = cbnd(8)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X > cbnd(7) And playerlocation.Z <= cbnd(11) Then
                If playerlocation.Y > cbnd(12) Then
                    If playerlocation.Y < cbnd(13) Then
                        If playerlocation.X <= cbnd(9) Then
                            If playerlocation.Z > cbnd(10) Then
                                playerlocation.X = cbnd(9)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z > cbnd(14) And playerlocation.X < cbnd(18) Then
                If playerlocation.Y > cbnd(19) Then
                    If playerlocation.Y < cbnd(20) Then
                        If playerlocation.Z <= cbnd(15) Then
                            If playerlocation.X > cbnd(17) Then
                                playerlocation.Z = cbnd(15)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z < cbnd(14) And playerlocation.X < cbnd(18) Then
                If playerlocation.Y > cbnd(19) Then
                    If playerlocation.Y < cbnd(20) Then
                        If playerlocation.Z >= cbnd(16) Then
                            If playerlocation.X > cbnd(17) Then
                                playerlocation.Z = cbnd(16)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z > cbnd(21) And playerlocation.X < cbnd(25) Then
                If playerlocation.Y > cbnd(26) Then
                    If playerlocation.Y < cbnd(27) Then
                        If playerlocation.Z <= cbnd(22) Then
                            If playerlocation.X > cbnd(24) Then
                                playerlocation.Z = cbnd(22)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z < cbnd(21) And playerlocation.X < cbnd(25) Then
                If playerlocation.Y > cbnd(26) Then
                    If playerlocation.Y < cbnd(27) Then
                        If playerlocation.Z >= cbnd(23) Then
                            If playerlocation.X > cbnd(24) Then
                                playerlocation.Z = cbnd(23)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Y < cbnd(28) Then
                If playerlocation.X >= cbnd(30) And playerlocation.X <= cbnd(31) Then
                    If playerlocation.Z >= cbnd(32) And playerlocation.Z <= cbnd(33) Then
                        If playerlocation.Y > cbnd(29) Then
                            playerlocation.Y = cbnd(29)
                        End If
                    End If
                End If
            End If

            If playerlocation.Y < cbnd(48) Then
                If playerlocation.X >= cbnd(40) And playerlocation.X <= cbnd(41) Then
                    If playerlocation.Z >= cbnd(42) And playerlocation.Z <= cbnd(43) Then
                        If playerlocation.Y > cbnd(49) Then
                            playerlocation.Y = cbnd(49)
                        End If
                    End If
                End If
            End If

            If playerlocation.X > cbnd(0) And playerlocation.Z <= cbnd(4) Then
                If playerlocation.Y < cbnd(3) Then
                    If playerlocation.Y > cbnd(2) Then
                        If playerlocation.X <= cbnd(1) Then
                            If playerlocation.Z > cbnd(5) Then
                                playerlocation.X = cbnd(1)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X < cbnd(0) And playerlocation.Z <= cbnd(4) Then
                If playerlocation.Y < cbnd(3) Then
                    If playerlocation.Y > cbnd(2) Then
                        If playerlocation.X >= cbnd(6) Then
                            If playerlocation.Z > cbnd(5) Then
                                playerlocation.X = cbnd(6)
                            End If
                        End If
                    End If
                End If
            End If

        End If

    End Sub

    Public Shared Sub Check_Collisions()

        If noclip = False Then

            If playerlocation.X < cbnd(106) Then
                If playerlocation.Z <= cbnd(100) Then
                    If playerlocation.Z > cbnd(101) Then
                        If playerlocation.Y <= cbnd(102) Then
                            If playerlocation.Y >= cbnd(103) Then
                                If playerlocation.X > cbnd(105) Then
                                    playerlocation.X = cbnd(105)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X > cbnd(107) Then
                If playerlocation.Z <= cbnd(100) Then
                    If playerlocation.Z > cbnd(101) Then
                        If playerlocation.Y <= cbnd(102) Then
                            If playerlocation.Y >= cbnd(103) Then
                                If playerlocation.X < cbnd(104) Then
                                    playerlocation.X = cbnd(104)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X < cbnd(7) And playerlocation.Z < cbnd(11) Then
                If playerlocation.Y > cbnd(12) Then
                    If playerlocation.Y < cbnd(13) Then
                        If playerlocation.X > cbnd(8) Then
                            If playerlocation.Z > cbnd(10) Then
                                playerlocation.X = cbnd(8)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X > cbnd(7) And playerlocation.Z <= cbnd(11) Then
                If playerlocation.Y > cbnd(12) Then
                    If playerlocation.Y < cbnd(13) Then
                        If playerlocation.X <= cbnd(9) Then
                            If playerlocation.Z > cbnd(10) Then
                                playerlocation.X = cbnd(9)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z > cbnd(14) And playerlocation.X < cbnd(18) Then
                If playerlocation.Y > cbnd(19) Then
                    If playerlocation.Y < cbnd(20) Then
                        If playerlocation.Z <= cbnd(15) Then
                            If playerlocation.X > cbnd(17) Then
                                playerlocation.Z = cbnd(15)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z < cbnd(14) And playerlocation.X < cbnd(18) Then
                If playerlocation.Y > cbnd(19) Then
                    If playerlocation.Y < cbnd(20) Then
                        If playerlocation.Z >= cbnd(16) Then
                            If playerlocation.X > cbnd(17) Then
                                playerlocation.Z = cbnd(16)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z > cbnd(21) And playerlocation.X < cbnd(25) Then
                If playerlocation.Y > cbnd(26) Then
                    If playerlocation.Y < cbnd(27) Then
                        If playerlocation.Z <= cbnd(22) Then
                            If playerlocation.X > cbnd(24) Then
                                playerlocation.Z = cbnd(22)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Z < cbnd(21) And playerlocation.X < cbnd(25) Then
                If playerlocation.Y > cbnd(26) Then
                    If playerlocation.Y < cbnd(27) Then
                        If playerlocation.Z >= cbnd(23) Then
                            If playerlocation.X > cbnd(24) Then
                                playerlocation.Z = cbnd(23)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.Y < cbnd(28) Then
                If playerlocation.X >= cbnd(30) And playerlocation.X <= cbnd(31) Then
                    If playerlocation.Z >= cbnd(32) And playerlocation.Z <= cbnd(33) Then
                        If playerlocation.Y > cbnd(29) Then
                            playerlocation.Y = cbnd(29)
                        End If
                    End If
                End If
            End If

            If playerlocation.Y < cbnd(48) Then
                If playerlocation.X >= cbnd(40) And playerlocation.X <= cbnd(41) Then
                    If playerlocation.Z >= cbnd(42) And playerlocation.Z <= cbnd(43) Then
                        If playerlocation.Y > cbnd(49) Then
                            playerlocation.Y = cbnd(49)
                        End If
                    End If
                End If
            End If

            If playerlocation.X > cbnd(0) And playerlocation.Z <= cbnd(4) Then
                If playerlocation.Y < cbnd(3) Then
                    If playerlocation.Y > cbnd(2) Then
                        If playerlocation.X <= cbnd(1) Then
                            If playerlocation.Z > cbnd(5) Then
                                playerlocation.X = cbnd(1)
                            End If
                        End If
                    End If
                End If
            End If

            If playerlocation.X < cbnd(0) And playerlocation.Z <= cbnd(4) Then
                If playerlocation.Y < cbnd(3) Then
                    If playerlocation.Y > cbnd(2) Then
                        If playerlocation.X >= cbnd(6) Then
                            If playerlocation.Z > cbnd(5) Then
                                playerlocation.X = cbnd(6)
                            End If
                        End If
                    End If
                End If
            End If

        End If

    End Sub

    Public Shared Sub Gravity()

        'Since Gravity is meant to only work while clipped, we have to check to make sure we are ---
        If noclip = False Then

            'Checks to see if player is on ground or not ---------
            If playerlocation.Y > groundlevel Then
                midair = True
            End If

            If playerlocation.Y <= groundlevel Then
                midair = False
            End If
            '-----------------------------------------------------

            'Main Gravity/Fall function --------------------------
            If jumping = False And crouching = False Then

                If playerlocation.Y > groundlevel Then

                    If playerlocation.Y < groundlevel + 2 Then
                        playerlocation.Y -= 0.1!
                        midair = True
                    End If

                    If playerlocation.Y > groundlevel + 2 Then
                        longfall = True
                        midair = True
                    End If

                End If

                If longfall = True Then

                    If currentvelocity_gravity < terminalvelocity_gravity Then
                        currentvelocity_gravity += 0.01!
                    End If

                    playerlocation.Y -= currentvelocity_gravity

                End If

                If playerlocation.Y <= groundlevel Then

                    allowjump = True
                    allowcrouch = True
                    midair = False
                    currentvelocity_gravity = 0.0!
                    playerlocation.Y = groundlevel

                    If longfall = True Then
                        longfall = False
                    End If
                End If

            End If
            '-----------------------------------------------------


            'Player Jump function --------------------------------
            If jumping = True Then

                allowjump = False
                midair = True

                If begin_jump = True Then
                    jump_time_elapsed += 75
                End If

                If jump_time_elapsed < 1000 Then
                    playerlocation.Y += jumpspeed
                    jumpspeed += 0.00325!
                End If

                If jump_time_elapsed >= 1000 Then
                    begin_jump = False
                    jumping = False
                    jumpspeed -= 0.025!
                    hasjumped = True
                    jump_time_elapsed = 0
                    jumpspeed = defaultjumpspeed
                End If

            End If
            '-----------------------------------------------------


            'X/Z Movement Momentum function ----------------------
            If midair = True Then
                walkspeed += 0.002365!
            End If

            If midair = False Then
                walkspeed = defaultwalkspeed
            End If
            '-----------------------------------------------------

        End If
        '-------------------------------------------------------------------------------------------

    End Sub

End Class
