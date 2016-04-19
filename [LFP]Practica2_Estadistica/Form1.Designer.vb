<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCerrarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGenerarArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuResultado = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAcerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevo, Me.MenuAbrir, Me.MenuGuardar, Me.MenuCerrar, Me.MenuCerrarTodo, Me.MenuSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MenuNuevo
        '
        Me.MenuNuevo.Name = "MenuNuevo"
        Me.MenuNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuNuevo.Size = New System.Drawing.Size(158, 22)
        Me.MenuNuevo.Text = "Nuevo"
        '
        'MenuAbrir
        '
        Me.MenuAbrir.Name = "MenuAbrir"
        Me.MenuAbrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MenuAbrir.Size = New System.Drawing.Size(158, 22)
        Me.MenuAbrir.Text = "Abrir"
        '
        'MenuGuardar
        '
        Me.MenuGuardar.Name = "MenuGuardar"
        Me.MenuGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.MenuGuardar.Size = New System.Drawing.Size(158, 22)
        Me.MenuGuardar.Text = "Guardar"
        '
        'MenuCerrar
        '
        Me.MenuCerrar.Name = "MenuCerrar"
        Me.MenuCerrar.Size = New System.Drawing.Size(158, 22)
        Me.MenuCerrar.Text = "Cerrar"
        '
        'MenuCerrarTodo
        '
        Me.MenuCerrarTodo.Name = "MenuCerrarTodo"
        Me.MenuCerrarTodo.Size = New System.Drawing.Size(158, 22)
        Me.MenuCerrarTodo.Text = "Cerrar Todo"
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(158, 22)
        Me.MenuSalir.Text = "Salir"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAnalisis, Me.MenuGenerarArchivo, Me.MenuResultado})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdiciónToolStripMenuItem.Text = "Edicion"
        '
        'MenuAnalisis
        '
        Me.MenuAnalisis.Name = "MenuAnalisis"
        Me.MenuAnalisis.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.MenuAnalisis.Size = New System.Drawing.Size(183, 22)
        Me.MenuAnalisis.Text = "Compilar"
        '
        'MenuGenerarArchivo
        '
        Me.MenuGenerarArchivo.Name = "MenuGenerarArchivo"
        Me.MenuGenerarArchivo.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.MenuGenerarArchivo.Size = New System.Drawing.Size(183, 22)
        Me.MenuGenerarArchivo.Text = "Generar Archivos"
        '
        'MenuResultado
        '
        Me.MenuResultado.Name = "MenuResultado"
        Me.MenuResultado.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.MenuResultado.Size = New System.Drawing.Size(183, 22)
        Me.MenuResultado.Text = "Ver Resultados"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuManual, Me.MenuAcerca})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'MenuManual
        '
        Me.MenuManual.Name = "MenuManual"
        Me.MenuManual.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.MenuManual.Size = New System.Drawing.Size(193, 22)
        Me.MenuManual.Text = "Manual De Usuario"
        '
        'MenuAcerca
        '
        Me.MenuAcerca.Name = "MenuAcerca"
        Me.MenuAcerca.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.MenuAcerca.Size = New System.Drawing.Size(193, 22)
        Me.MenuAcerca.Text = "Acerca De"
        '
        'TabControl
        '
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(634, 387)
        Me.TabControl.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 411)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadistica [Practica 2]"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCerrarTodo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGenerarArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuResultado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAcerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl As System.Windows.Forms.TabControl

End Class
