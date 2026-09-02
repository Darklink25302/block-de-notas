<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        mnuPrincipal = New MenuStrip()
        tsPrincipal = New ToolStrip()
        stsInferior = New StatusStrip()
        rtbDocumento = New RichTextBox()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        MnuDeshacerToolStripMenuItem = New ToolStripMenuItem()
        MnuRehacerToolStripMenuItem = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        HerramientasToolStripMenuItem = New ToolStripMenuItem()
        MnuBuscarToolStripMenuItem = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        MnuNuevoToolStripMenuItem = New ToolStripMenuItem()
        MnuAbrirToolStripMenuItem = New ToolStripMenuItem()
        MnuGuardarToolStripMenuItem = New ToolStripMenuItem()
        MnuGuardarComoToolStripMenuItem = New ToolStripMenuItem()
        MnuSalirToolStripMenuItem = New ToolStripMenuItem()
        MnuCortarToolStripMenuItem = New ToolStripMenuItem()
        MnuCopiarToolStripMenuItem = New ToolStripMenuItem()
        MnuPegarToolStripMenuItem = New ToolStripMenuItem()
        MnuSeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        MnuFuenteToolStripMenuItem = New ToolStripMenuItem()
        MnuColorToolStripMenuItem = New ToolStripMenuItem()
        MnuAjusteLineaToolStripMenuItem = New ToolStripMenuItem()
        mnuAcercaDe = New ToolStripMenuItem()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSubrayado = New ToolStripButton()
        ToolStripButton1 = New ToolStripButton()
        tscbFuente = New ToolStripComboBox()
        tscbTamano = New ToolStripComboBox()
        cmsTexto = New ContextMenuStrip(components)
        CtxCortarToolStripMenuItem = New ToolStripMenuItem()
        CtxCopiarToolStripMenuItem = New ToolStripMenuItem()
        CtxPegarToolStripMenuItem = New ToolStripMenuItem()
        CtxSeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        CtxFuenteToolStripMenuItem = New ToolStripMenuItem()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        stsInferior.SuspendLayout()
        cmsTexto.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdicionToolStripMenuItem, FormatoToolStripMenuItem, HerramientasToolStripMenuItem, VerToolStripMenuItem, AyudaToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(800, 24)
        mnuPrincipal.TabIndex = 0
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, tsbNegrita, tsbCursiva, tsbSubrayado, ToolStripButton1, tscbFuente, tscbTamano})
        tsPrincipal.Location = New Point(0, 24)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(800, 25)
        tsPrincipal.TabIndex = 1
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' stsInferior
        ' 
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsFechaHora})
        stsInferior.Location = New Point(0, 428)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(800, 22)
        stsInferior.TabIndex = 2
        stsInferior.Text = "StatusStrip1"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.AcceptsTab = True
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 49)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(800, 379)
        rtbDocumento.TabIndex = 3
        rtbDocumento.Text = ""
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MnuNuevoToolStripMenuItem, MnuAbrirToolStripMenuItem, MnuGuardarToolStripMenuItem, MnuGuardarComoToolStripMenuItem, MnuSalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(58, 20)
        ArchivoToolStripMenuItem.Text = "archivo"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MnuDeshacerToolStripMenuItem, MnuRehacerToolStripMenuItem, MnuCortarToolStripMenuItem, MnuCopiarToolStripMenuItem, MnuPegarToolStripMenuItem, MnuSeleccionarTodoToolStripMenuItem})
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(58, 20)
        EdicionToolStripMenuItem.Text = "edicion"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MnuBuscarToolStripMenuItem})
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(90, 20)
        HerramientasToolStripMenuItem.Text = "herramientas"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MnuFuenteToolStripMenuItem, MnuColorToolStripMenuItem, MnuAjusteLineaToolStripMenuItem})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(62, 20)
        FormatoToolStripMenuItem.Text = "formato"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(35, 20)
        VerToolStripMenuItem.Text = "ver"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAcercaDe})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(51, 20)
        AyudaToolStripMenuItem.Text = "ayuda"
        ' 
        ' MnuNuevoToolStripMenuItem
        ' 
        MnuNuevoToolStripMenuItem.Name = "MnuNuevoToolStripMenuItem"
        MnuNuevoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        MnuNuevoToolStripMenuItem.Size = New Size(180, 22)
        MnuNuevoToolStripMenuItem.Text = "&Nuevo"
        ' 
        ' MnuAbrirToolStripMenuItem
        ' 
        MnuAbrirToolStripMenuItem.Name = "MnuAbrirToolStripMenuItem"
        MnuAbrirToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        MnuAbrirToolStripMenuItem.Size = New Size(180, 22)
        MnuAbrirToolStripMenuItem.Text = "&Abrir..."
        ' 
        ' MnuGuardarToolStripMenuItem
        ' 
        MnuGuardarToolStripMenuItem.Name = "MnuGuardarToolStripMenuItem"
        MnuGuardarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        MnuGuardarToolStripMenuItem.Size = New Size(180, 22)
        MnuGuardarToolStripMenuItem.Text = "&Guardar"
        ' 
        ' MnuGuardarComoToolStripMenuItem
        ' 
        MnuGuardarComoToolStripMenuItem.Name = "MnuGuardarComoToolStripMenuItem"
        MnuGuardarComoToolStripMenuItem.Size = New Size(180, 22)
        MnuGuardarComoToolStripMenuItem.Text = "Guardar &como..."
        ' 
        ' MnuSalirToolStripMenuItem
        ' 
        MnuSalirToolStripMenuItem.Name = "MnuSalirToolStripMenuItem"
        MnuSalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        MnuSalirToolStripMenuItem.Size = New Size(180, 22)
        MnuSalirToolStripMenuItem.Text = "&Salir"
        ' 
        ' MnuDeshacerToolStripMenuItem
        ' 
        MnuDeshacerToolStripMenuItem.Name = "MnuDeshacerToolStripMenuItem"
        MnuDeshacerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        MnuDeshacerToolStripMenuItem.Size = New Size(204, 22)
        MnuDeshacerToolStripMenuItem.Text = "Deshacer"
        ' 
        ' MnuRehacerToolStripMenuItem
        ' 
        MnuRehacerToolStripMenuItem.Name = "MnuRehacerToolStripMenuItem"
        MnuRehacerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        MnuRehacerToolStripMenuItem.Size = New Size(204, 22)
        MnuRehacerToolStripMenuItem.Text = "Rehacer"
        ' 
        ' MnuBuscarToolStripMenuItem
        ' 
        MnuBuscarToolStripMenuItem.Name = "MnuBuscarToolStripMenuItem"
        MnuBuscarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F
        MnuBuscarToolStripMenuItem.Size = New Size(180, 22)
        MnuBuscarToolStripMenuItem.Text = "Buscar..."
        ' 
        ' MnuCortarToolStripMenuItem
        ' 
        MnuCortarToolStripMenuItem.Name = "MnuCortarToolStripMenuItem"
        MnuCortarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        MnuCortarToolStripMenuItem.Size = New Size(204, 22)
        MnuCortarToolStripMenuItem.Text = "Cortar"
        ' 
        ' MnuCopiarToolStripMenuItem
        ' 
        MnuCopiarToolStripMenuItem.Name = "MnuCopiarToolStripMenuItem"
        MnuCopiarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        MnuCopiarToolStripMenuItem.Size = New Size(204, 22)
        MnuCopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' MnuPegarToolStripMenuItem
        ' 
        MnuPegarToolStripMenuItem.Name = "MnuPegarToolStripMenuItem"
        MnuPegarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        MnuPegarToolStripMenuItem.Size = New Size(204, 22)
        MnuPegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' MnuSeleccionarTodoToolStripMenuItem
        ' 
        MnuSeleccionarTodoToolStripMenuItem.Name = "MnuSeleccionarTodoToolStripMenuItem"
        MnuSeleccionarTodoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        MnuSeleccionarTodoToolStripMenuItem.Size = New Size(204, 22)
        MnuSeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' MnuFuenteToolStripMenuItem
        ' 
        MnuFuenteToolStripMenuItem.Name = "MnuFuenteToolStripMenuItem"
        MnuFuenteToolStripMenuItem.Size = New Size(180, 22)
        MnuFuenteToolStripMenuItem.Text = "Fuente"
        ' 
        ' MnuColorToolStripMenuItem
        ' 
        MnuColorToolStripMenuItem.Name = "MnuColorToolStripMenuItem"
        MnuColorToolStripMenuItem.Size = New Size(180, 22)
        MnuColorToolStripMenuItem.Text = "Color"
        ' 
        ' MnuAjusteLineaToolStripMenuItem
        ' 
        MnuAjusteLineaToolStripMenuItem.Checked = True
        MnuAjusteLineaToolStripMenuItem.CheckOnClick = True
        MnuAjusteLineaToolStripMenuItem.CheckState = CheckState.Checked
        MnuAjusteLineaToolStripMenuItem.Name = "MnuAjusteLineaToolStripMenuItem"
        MnuAjusteLineaToolStripMenuItem.Size = New Size(180, 22)
        MnuAjusteLineaToolStripMenuItem.Text = " Ajuste de línea"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New Size(180, 22)
        mnuAcercaDe.Text = "Acerca de"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(23, 22)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(23, 22)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(23, 22)
        tsbGuardar.Text = "Guardar"
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbNegrita.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(23, 22)
        tsbNegrita.Text = "N"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbCursiva.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(23, 22)
        tsbCursiva.Text = "K"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbSubrayado.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(23, 22)
        tsbSubrayado.Text = "S"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripButton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripButton1.ForeColor = Color.Red
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "A"
        ToolStripButton1.ToolTipText = "Color de texto"
        ' 
        ' tscbFuente
        ' 
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(121, 25)
        ' 
        ' tscbTamano
        ' 
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(121, 25)
        ' 
        ' cmsTexto
        ' 
        cmsTexto.Items.AddRange(New ToolStripItem() {CtxCortarToolStripMenuItem, CtxCopiarToolStripMenuItem, CtxPegarToolStripMenuItem, CtxSeleccionarTodoToolStripMenuItem, CtxFuenteToolStripMenuItem})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(177, 114)
        ' 
        ' CtxCortarToolStripMenuItem
        ' 
        CtxCortarToolStripMenuItem.Name = "CtxCortarToolStripMenuItem"
        CtxCortarToolStripMenuItem.Size = New Size(176, 22)
        CtxCortarToolStripMenuItem.Text = "ctxCortar"
        ' 
        ' CtxCopiarToolStripMenuItem
        ' 
        CtxCopiarToolStripMenuItem.Name = "CtxCopiarToolStripMenuItem"
        CtxCopiarToolStripMenuItem.Size = New Size(176, 22)
        CtxCopiarToolStripMenuItem.Text = "ctxCopiar"
        ' 
        ' CtxPegarToolStripMenuItem
        ' 
        CtxPegarToolStripMenuItem.Name = "CtxPegarToolStripMenuItem"
        CtxPegarToolStripMenuItem.Size = New Size(176, 22)
        CtxPegarToolStripMenuItem.Text = " ctxPegar"
        ' 
        ' CtxSeleccionarTodoToolStripMenuItem
        ' 
        CtxSeleccionarTodoToolStripMenuItem.Name = "CtxSeleccionarTodoToolStripMenuItem"
        CtxSeleccionarTodoToolStripMenuItem.Size = New Size(176, 22)
        CtxSeleccionarTodoToolStripMenuItem.Text = "ctxSeleccionarTodo"
        ' 
        ' CtxFuenteToolStripMenuItem
        ' 
        CtxFuenteToolStripMenuItem.Name = "CtxFuenteToolStripMenuItem"
        CtxFuenteToolStripMenuItem.Size = New Size(176, 22)
        CtxFuenteToolStripMenuItem.Text = "ctxFuente"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(631, 17)
        stsEstado.Spring = True
        stsEstado.Tag = " "
        stsEstado.Text = "Listo"
        stsEstado.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(80, 17)
        stsPosicion.Text = "Línea: 1 Col: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(74, 17)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(0, 17)
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(rtbDocumento)
        Controls.Add(stsInferior)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        cmsTexto.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuDeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuRehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuBuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuAbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuGuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuGuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuSalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuCortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuCopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuPegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuSeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuAjusteLineaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As ToolStripMenuItem
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tscbFuente As ToolStripComboBox
    Friend WithEvents tscbTamano As ToolStripComboBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents CtxCortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CtxCopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CtxPegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CtxSeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CtxFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel

End Class
