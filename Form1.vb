Imports System.Drawing.Text
Imports System.IO

Public Class frmBlocNotas
    Private rutaArchivoActual As String = ""
    Private esModificado As Boolean = False
    Private WithEvents timerReloj As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearIconosBarra()
        CargarFuentesYTamanos()
        ConfigurarReloj()
        ActualizarTitulo()
        ActualizarBarraEstado()
    End Sub

    Private Sub CrearIconosBarra()
        ' Icono Nuevo (Hoja de papel con esquina doblada)
        Dim bmpNuevo As New Bitmap(16, 16)
        Using g As Graphics = Graphics.FromImage(bmpNuevo)
            g.Clear(Color.Transparent)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Dim pts() As Point = {
                New Point(3, 1),
                New Point(10, 1),
                New Point(13, 4),
                New Point(13, 14),
                New Point(3, 14)
            }
            g.FillPolygon(Brushes.White, pts)
            g.DrawPolygon(Pens.DodgerBlue, pts)
            g.DrawLine(Pens.SteelBlue, 5, 6, 11, 6)
            g.DrawLine(Pens.SteelBlue, 5, 8, 11, 8)
            g.DrawLine(Pens.SteelBlue, 5, 10, 9, 10)
        End Using
        tsbNuevo.Image = bmpNuevo
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsbNuevo.Text = "Nuevo"

        ' Icono Abrir (Carpeta abierta dorada)
        Dim bmpAbrir As New Bitmap(16, 16)
        Using g As Graphics = Graphics.FromImage(bmpAbrir)
            g.Clear(Color.Transparent)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.FillRectangle(Brushes.DarkGoldenrod, 1, 3, 6, 3)
            g.FillRectangle(Brushes.Gold, 1, 5, 14, 9)
            g.DrawRectangle(Pens.DarkGoldenrod, 1, 5, 14, 9)
            Dim frontPts() As Point = {
                New Point(1, 7),
                New Point(4, 14),
                New Point(15, 14),
                New Point(13, 7)
            }
            g.FillPolygon(Brushes.Orange, frontPts)
            g.DrawPolygon(Pens.DarkGoldenrod, frontPts)
        End Using
        tsbAbrir.Image = bmpAbrir
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsbAbrir.Text = "Abrir"

        ' Icono Guardar (Disquete azul)
        Dim bmpGuardar As New Bitmap(16, 16)
        Using g As Graphics = Graphics.FromImage(bmpGuardar)
            g.Clear(Color.Transparent)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.FillRectangle(Brushes.RoyalBlue, 2, 2, 12, 12)
            g.DrawRectangle(Pens.MidnightBlue, 2, 2, 12, 12)
            g.FillRectangle(Brushes.White, 4, 7, 8, 7)
            g.FillRectangle(Brushes.LightGray, 4, 2, 6, 4)
            g.FillRectangle(Brushes.DarkBlue, 7, 3, 2, 2)
        End Using
        tsbGuardar.Image = bmpGuardar
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsbGuardar.Text = "Guardar"

        ' Icono Color (Letra A con barra de color abajo)
        Dim bmpColor As New Bitmap(16, 16)
        Using g As Graphics = Graphics.FromImage(bmpColor)
            g.Clear(Color.Transparent)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Using f As New Font("Segoe UI", 9, FontStyle.Bold)
                g.DrawString("A", f, Brushes.Black, 1, -1)
            End Using
            g.FillRectangle(Brushes.Red, 2, 12, 12, 3)
        End Using
        ToolStripButton1.Image = bmpColor
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        ToolStripButton1.Text = "Color"

        ' Configurar estilo de N, K, S
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbNegrita.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbCursiva.Font = New Font("Segoe UI", 9, FontStyle.Italic)
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbSubrayado.Font = New Font("Segoe UI", 9, FontStyle.Underline)
    End Sub

    Private Sub ConfigurarReloj()
        timerReloj.Interval = 1000
        timerReloj.Start()
        ActualizarFechaHora()
    End Sub

    Private Sub timerReloj_Tick(sender As Object, e As EventArgs) Handles timerReloj.Tick
        ActualizarFechaHora()
    End Sub

    Private Sub ActualizarFechaHora()
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub CargarFuentesYTamanos()
        ' Cargar fuentes del sistema en el ComboBox
        tscbFuente.Items.Clear()
        Dim instaladorFuentes As New InstalledFontCollection()
        For Each familia As FontFamily In instaladorFuentes.Families
            tscbFuente.Items.Add(familia.Name)
        Next
        If tscbFuente.Items.Contains("Segoe UI") Then
            tscbFuente.SelectedItem = "Segoe UI"
        ElseIf tscbFuente.Items.Count > 0 Then
            tscbFuente.SelectedIndex = 0
        End If

        ' Cargar tamaños estándar
        tscbTamano.Items.Clear()
        Dim tamanos() As Integer = {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 28, 36, 48, 72}
        For Each t As Integer In tamanos
            tscbTamano.Items.Add(t.ToString())
        Next
        tscbTamano.SelectedItem = "12"
    End Sub

    Private Sub frmBlocNotas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmarGuardadoSiModificado() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        esModificado = True
        ActualizarTitulo()
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarPosicionCursor()
    End Sub

    Private Sub ActualizarTitulo()
        Dim nombreArchivo As String = If(String.IsNullOrEmpty(rutaArchivoActual), "Sin título", Path.GetFileName(rutaArchivoActual))
        Dim indicadorModificado As String = If(esModificado, "*", "")
        Me.Text = $"{indicadorModificado}{nombreArchivo} - Bloc de Notas"
    End Sub

    Private Sub ActualizarBarraEstado()
        Dim totalChars As Integer = rtbDocumento.TextLength
        Dim palabras() As String = rtbDocumento.Text.Split(New Char() {" "c, vbCr, vbLf, vbTab}, StringSplitOptions.RemoveEmptyEntries)
        stsCaracteres.Text = $"Caracteres: {totalChars} | Palabras: {palabras.Length}"
        stsEstado.Text = "Listo"
        ActualizarPosicionCursor()
    End Sub

    Private Sub ActualizarPosicionCursor()
        Dim index As Integer = rtbDocumento.SelectionStart
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(index) + 1
        Dim primerIndexLinea As Integer = rtbDocumento.GetFirstCharIndexFromLine(linea - 1)
        Dim columna As Integer = index - primerIndexLinea + 1
        stsPosicion.Text = $"Lín {linea}, Col {columna}"
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

    ' Operaciones de Archivo
    Private Sub LimpiarDocumento()
        If Not ConfirmarGuardadoSiModificado() Then Return

        rtbDocumento.Clear()
        rutaArchivoActual = ""
        esModificado = False
        ActualizarTitulo()
        ActualizarBarraEstado()
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
                    ActualizarBarraEstado()
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

    ' Eventos Archivo
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

    Private Sub MnuSalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuSalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Eventos Edición
    Private Sub MnuDeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuDeshacerToolStripMenuItem.Click
        If rtbDocumento.CanUndo Then
            rtbDocumento.Undo()
        End If
    End Sub

    Private Sub MnuRehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuRehacerToolStripMenuItem.Click
        If rtbDocumento.CanRedo Then
            rtbDocumento.Redo()
        End If
    End Sub

    Private Sub MnuCortar_Click(sender As Object, e As EventArgs) Handles MnuCortarToolStripMenuItem.Click, CtxCortarToolStripMenuItem.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub MnuCopiar_Click(sender As Object, e As EventArgs) Handles MnuCopiarToolStripMenuItem.Click, CtxCopiarToolStripMenuItem.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub MnuPegar_Click(sender As Object, e As EventArgs) Handles MnuPegarToolStripMenuItem.Click, CtxPegarToolStripMenuItem.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub MnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles MnuSeleccionarTodoToolStripMenuItem.Click, CtxSeleccionarTodoToolStripMenuItem.Click
        rtbDocumento.SelectAll()
    End Sub

    ' Eventos Herramientas
    Private Sub MnuBuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuBuscarToolStripMenuItem.Click
        Dim textoBusqueda As String = InputBox("Ingrese la palabra o texto a buscar:", "Buscar texto en el documento", "")
        If Not String.IsNullOrEmpty(textoBusqueda) Then
            Dim inicio As Integer = rtbDocumento.Find(textoBusqueda, rtbDocumento.SelectionStart + rtbDocumento.SelectionLength, RichTextBoxFinds.None)
            If inicio <> -1 Then
                rtbDocumento.Select(inicio, textoBusqueda.Length)
                rtbDocumento.Focus()
            Else
                inicio = rtbDocumento.Find(textoBusqueda, 0, RichTextBoxFinds.None)
                If inicio <> -1 Then
                    rtbDocumento.Select(inicio, textoBusqueda.Length)
                    rtbDocumento.Focus()
                Else
                    MessageBox.Show($"No se encontró '{textoBusqueda}' en el documento.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    ' Eventos Formato Rápido
    Private Sub CambiarEstiloFuente(estilo As FontStyle)
        If rtbDocumento.SelectionFont IsNot Nothing Then
            Dim fuenteActual As Font = rtbDocumento.SelectionFont
            Dim nuevoEstilo As FontStyle

            If fuenteActual.Style.HasFlag(estilo) Then
                nuevoEstilo = fuenteActual.Style And Not estilo
            Else
                nuevoEstilo = fuenteActual.Style Or estilo
            End If

            rtbDocumento.SelectionFont = New Font(fuenteActual.FontFamily, fuenteActual.Size, nuevoEstilo)
        End If
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        CambiarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        CambiarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        CambiarEstiloFuente(FontStyle.Underline)
    End Sub

    ' Eventos Formato Avanzado
    Private Sub MnuFuente_Click(sender As Object, e As EventArgs) Handles MnuFuenteToolStripMenuItem.Click, CtxFuenteToolStripMenuItem.Click
        Using fd As New FontDialog()
            If rtbDocumento.SelectionFont IsNot Nothing Then
                fd.Font = rtbDocumento.SelectionFont
            End If
            If fd.ShowDialog() = DialogResult.OK Then
                rtbDocumento.SelectionFont = fd.Font
            End If
        End Using
    End Sub

    Private Sub MnuColor_Click(sender As Object, e As EventArgs) Handles MnuColorToolStripMenuItem.Click, ToolStripButton1.Click
        Using cd As New ColorDialog()
            cd.Color = rtbDocumento.SelectionColor
            If cd.ShowDialog() = DialogResult.OK Then
                rtbDocumento.SelectionColor = cd.Color
            End If
        End Using
    End Sub

    Private Sub MnuAjusteLineaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MnuAjusteLineaToolStripMenuItem.Click
        MnuAjusteLineaToolStripMenuItem.Checked = Not MnuAjusteLineaToolStripMenuItem.Checked
        rtbDocumento.WordWrap = MnuAjusteLineaToolStripMenuItem.Checked
    End Sub

    ' Eventos Desplegables de Fuente y Tamaño
    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFuente.SelectedIndexChanged
        If tscbFuente.SelectedItem IsNot Nothing AndAlso rtbDocumento.SelectionFont IsNot Nothing Then
            Dim nombreFamilia As String = tscbFuente.SelectedItem.ToString()
            Dim fuenteActual As Font = rtbDocumento.SelectionFont
            Try
                rtbDocumento.SelectionFont = New Font(nombreFamilia, fuenteActual.Size, fuenteActual.Style)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTamano.SelectedIndexChanged
        If tscbTamano.SelectedItem IsNot Nothing AndAlso rtbDocumento.SelectionFont IsNot Nothing Then
            Dim nuevoTamano As Single
            If Single.TryParse(tscbTamano.SelectedItem.ToString(), nuevoTamano) Then
                Dim fuenteActual As Font = rtbDocumento.SelectionFont
                rtbDocumento.SelectionFont = New Font(fuenteActual.FontFamily, nuevoTamano, fuenteActual.Style)
            End If
        End If
    End Sub

    ' Evento Ayuda - Acerca de
    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show(
            "TextEdit VB - Editor de Texto de Escritorio" & vbCrLf &
            "Versión 1.0" & vbCrLf & vbCrLf &
            "Desarrollado para el proyecto de curso de Programación de Aplicaciones de Escritorio.",
            "Acerca de TextEdit VB",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub
End Class
