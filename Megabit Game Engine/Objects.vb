Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports System.Threading
Imports MegabitEngine.HUD
Imports MegabitEngine.Core
Imports MegabitEngine.Stage
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Objects

    Public Shared Sub Interactive_Logic()

        Door_Logic()

    End Sub

    Private Shared Sub Door_Logic()

        If door_trig1 = True Then
            If door_rotating = True Then

                If dr_rotdir = "opening" Then
                    'Setting location data ---------------------------------
                    If dr_val1(1) < 1.71875 Then
                        dr_val1(1) += 0.0286458333333333
                    End If
                    If dr_val2(1) < 1.875 Then
                        dr_val2(1) += 0.03125
                    End If
                    If dr_val3(1) < 0.15625 Then
                        dr_val3(1) += 0.0026041666666667
                    End If
                    If dr_val4(1) < 2.03125 Then
                        dr_val4(1) += 0.0338541666666667
                    End If
                    '-------------------------------------------------------
                End If

                If dr_rotdir = "closing" Then
                    'Setting location data ---------------------------------
                    If dr_val1(1) > 0 Then
                        dr_val1(1) -= 0.0286458333333333
                    End If
                    If dr_val2(1) > 0 Then
                        dr_val2(1) -= 0.03125
                    End If
                    If dr_val3(1) > 0 Then
                        dr_val3(1) -= 0.0026041666666667
                    End If
                    If dr_val4(1) > 0 Then
                        dr_val4(1) -= 0.0338541666666667
                    End If
                    '-------------------------------------------------------
                End If
            End If
        End If
    End Sub

End Class
