Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports System.Threading
Imports MegabitEngine.Core
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports MegabitEngine.Physics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Variables

    'Ignition:
    Public Shared Window_Title As String
    Public Shared Window_Width As Integer
    Public Shared Window_Height As Integer

    'Camera:
    Public Shared cameraMatrix As Matrix4
    Public Shared mouseSpeed() As Single = New Single((2) - 1) {}
    Public Shared mouseDelta As Vector2
    Public Shared playerlocation As Vector3
    Public Shared up As Vector3 = Vector3.UnitY
    Public Shared pitch As Single = 0.0!
    Public Shared facing As Single = 1.57!
    Public Shared pointer_delta As Size
    Public Shared mousereset As Boolean = False
    Public Shared lookpoint As Vector3
    Public Shared textures(2048) As Integer
    Public Shared noclip As Boolean = False

    'Physics:
    Public Shared cbnd(2048) As Double
    Public Shared jump_time_elapsed As Integer
    Public Shared terminalvelocity_gravity As Single = 6.4!
    Public Shared currentvelocity_gravity As Single = 0.0!
    Public Shared gravityloop As New Thread(AddressOf Gravity)
    Public Shared collisionloop As New Thread(AddressOf Detect_Collisions)

    'Build
    Public Shared groundlevel As Double
    Public Shared railzone As Boolean = False
    Public Shared railcld As Integer

    'Motion
    Public Shared defaultjumpspeed As Single = 0.1!
    Public Shared defaultwalkspeed As Single = 0.15!
    Public Shared walkspeed As Single = defaultwalkspeed
    Public Shared jumpspeed As Single = defaultjumpspeed
    Public Shared allowjump As Boolean = True
    Public Shared begin_jump As Boolean = False
    Public Shared jumping As Boolean = False
    Public Shared midair As Boolean = False
    Public Shared hasjumped As Boolean = False
    Public Shared jptrig_ignore As Boolean = False
    Public Shared allowcrouch As Boolean = True
    Public Shared crouching As Boolean = False
    Public Shared longfall As Boolean = False

    'Core:
    Public Shared CR_X As Integer
    Public Shared CR_Y As Integer
    Public Shared CR_Width As Integer
    Public Shared CR_Height As Integer
    Public Shared current_map As String
    Public Shared screen_width As Integer
    Public Shared screen_xbound As Integer
    Public Shared screen_ybound As Integer
    Public Shared screen_height As Integer

    'Objects
    Public Shared door_rotating As Boolean = False
    Public Shared dr_type As Integer
    Public Shared dr_axis As Integer
    Public Shared dr_swing As Integer
    Public Shared dr_val1(32) As Double
    Public Shared dr_val2(32) As Double
    Public Shared dr_val3(32) As Double
    Public Shared dr_val4(32) As Double

End Class
