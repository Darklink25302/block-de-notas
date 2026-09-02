Imports System.IO

Public Class frmBlocNotas
    Private rutaArchivoActual As String = ""
    Private esModificado As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTitulo()
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        esModificado = True
        ActualizarTitulo()
    End Sub

    Private Sub ActualizarTitulo()
        Dim nombreArchivo As String = If(String.IsNullOrEmpty(rutaArchivoActual), "Sin título", Path.GetFileName(rutaArchivoActual))
        Dim indicadorModificado As String = If(esModificado, "*", "")
        Me.Text = $"{indicadorModificado}{nombreArchivo} - Bloc de Notas"
    End Sub

    Private Function ConfirmarGuardadoSiModificado() As Boolean
        If esModificado Then
            Dim resultado As DialogResult = MessageBox.Show(
                "¿Deseas guardar los cambios en el documento actual?",
                "Bloc de Notas",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            )

            If resultado = DialogResult.Yes Then
                Return GuardarDocumento()
            ElseIf resultado = DialogResult.Cancel Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub LimpiarDocumento()
        If Not ConfirmarGuardadoSiModificado() Then Return

        rtbDocumento.Clear()
        rutaArchivoActual = ""
        esModificado = False
        ActualizarTitulo()
    End Sub

    Private Sub AbrirDocumento()
        If Not ConfirmarGuardadoSiModificado() Then Return

        Using ofd As New OpenFileDialog()
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            ofd.Title = "Abrir archivo"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    rtbDocumento.Text = File.ReadAllText(ofd.FileName)
                    rutaArchivoActual = ofd.FileName
                    esModificado = False
                    ActualizarTitulo()
                Catch ex As Exception
                    MessageBox.Show("Error al abrir el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Function GuardarDocumento() As Boolean
        If String.IsNullOrEmpty(rutaArchivoActual) Then
            Return GuardarComoDocumento()
        Else
            Try
                File.WriteAllText(rutaArchivoActual, rtbDocumento.Text)
                esModificado = False
                ActualizarTitulo()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error al guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
    End Function

    Private Function GuardarComoDocumento() As Boolean
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            sfd.Title = "Guardar como"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(sfd.FileName, rtbDocumento.Text)
                    rutaArchivoActual = sfd.FileName
                    esModificado = False
                    ActualizarTitulo()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error al guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            Else
                Return False
            End If
        End Using
    End Function

    ' Los controladores usan únicamente Handles para evitar doble llamada
    Private Sub MnuNuevo_Click(sender As Object, e As EventArgs) Handles MnuNuevoToolStripMenuItem.Click, tsbNuevo.Click
        LimpiarDocumento()
    End Sub

    Private Sub MnuAbrir_Click(sender As Object, e As EventArgs) Handles MnuAbrirToolStripMenuItem.Click, tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub MnuGuardar_Click(sender As Object, e As EventArgs) Handles MnuGuardarToolStripMenuItem.Click, tsbGuardar.Click
        GuardarDocumento()
    End Sub

    Private Sub MnuGuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuGuardarComoToolStripMenuItem.Click
        GuardarComoDocumento()
    End Sub
End Class
