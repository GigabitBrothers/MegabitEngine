Imports OpenTK
Imports System
Imports System.IO
Imports OpenTK.Input
Imports System.Drawing
Imports MegabitEngine.Core
Imports System.Drawing.Point
Imports System.Windows.Forms
Imports MegabitEngine.Motion
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports MegabitEngine.Variables

Public Class Paint

    Public Shared Sub InitMaterials()
        FilePaths()
    End Sub

    Private Shared Sub FilePaths()

        GL.GenTextures(textures.Length, textures)
        UnpackMaterial(textures(0), "engine/sdk/dev_mat/floor.png")
        UnpackMaterial(textures(1), "engine/sdk/dev_mat/roof.png")
        UnpackMaterial(textures(2), "engine/sdk/dev_mat/wall.png")
        UnpackMaterial(textures(3), "engine/sdk/dev_mat/railpc1.png")
        UnpackMaterial(textures(4), "engine/sdk/dev_mat/spwnmarker.png")
        UnpackMaterial(textures(5), "engine/sdk/dev_mat/doorpt1.png")
        UnpackMaterial(textures(6), "engine/sdk/dev_mat/doorpt2.png")
        UnpackMaterial(textures(7), "engine/sdk/dev_mat/dev_cross.png")
        UnpackMaterial(textures(8), "engine/sdk/dev_mat/dev_cross_mystery.png")
        UnpackMaterial(textures(9), "engine/sdk/dev_mat/dev_hudtest2.png")
        UnpackMaterial(textures(10), "engine/sdk/dev_mat/railpc2.png")
        UnpackMaterial(textures(11), "engine/sdk/dev_mat/sndsideback.png")
        UnpackMaterial(textures(12), "engine/sdk/dev_mat/sndtopbottom.png")
        UnpackMaterial(textures(13), "engine/sdk/dev_mat/sndfront.png")
        UnpackMaterial(textures(14), "engine/sdk/dev_mat/nope.png")
        UnpackMaterial(textures(15), "engine/sdk/dev_mat/alt.png")

    End Sub

    Private Shared Sub UnpackMaterial(ByVal textureId As Integer, ByVal filename As String)

        If System.IO.File.Exists(filename) Then
            Dim maxAniso As Single

            Dim bmp As New Bitmap(filename)

            Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height),
                                                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                                                    System.Drawing.Imaging.PixelFormat.Format32bppArgb)

            GL.BindTexture(TextureTarget.Texture2D, textureId)
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                          bmp.Width, bmp.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                          PixelType.UnsignedByte, data.Scan0)

            bmp.UnlockBits(data)

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D)
            GL.GetFloat(CType(ExtTextureFilterAnisotropic.MaxTextureMaxAnisotropyExt, GetPName), maxAniso)
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, TextureMagFilter.Linear)
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, TextureMinFilter.LinearMipmapLinear)
            GL.TexParameter(TextureTarget.Texture2D, CType(ExtTextureFilterAnisotropic.TextureMaxAnisotropyExt, TextureParameterName), maxAniso)
        End If

        If System.IO.File.Exists(filename) = False Then
            Dim maxAniso As Single

            Dim bmp As New Bitmap("engine/sdk/dev_mat/missing.png")

            Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height),
                                                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                                                    System.Drawing.Imaging.PixelFormat.Format32bppArgb)

            GL.BindTexture(TextureTarget.Texture2D, textureId)
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                          bmp.Width, bmp.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                          PixelType.UnsignedByte, data.Scan0)

            bmp.UnlockBits(data)

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D)
            GL.GetFloat(CType(ExtTextureFilterAnisotropic.MaxTextureMaxAnisotropyExt, GetPName), maxAniso)
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, TextureMagFilter.Linear)
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, TextureMinFilter.LinearMipmapLinear)
            GL.TexParameter(TextureTarget.Texture2D, CType(ExtTextureFilterAnisotropic.TextureMaxAnisotropyExt, TextureParameterName), maxAniso)
        End If

    End Sub

    Public Shared Sub Material(ByVal materialid As Integer)

        GL.BindTexture(TextureTarget.Texture2D, textures(materialid))

    End Sub

End Class
