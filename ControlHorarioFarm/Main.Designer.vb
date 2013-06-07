<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonConfig = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ButtonMarcar = New System.Windows.Forms.Button()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.ComboBoxTurnos = New System.Windows.Forms.ComboBox()
        Me.DataGridViewReg = New System.Windows.Forms.DataGridView()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.DataGridViewReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelTipo)
        Me.SplitContainer.Panel1.Controls.Add(Me.ComboBoxTipo)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxPass)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelPassword)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonConfig)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonCerrar)
        Me.SplitContainer.Panel1.Controls.Add(Me.ButtonMarcar)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelTurno)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelNombre)
        Me.SplitContainer.Panel1.Controls.Add(Me.TextBoxNombre)
        Me.SplitContainer.Panel1.Controls.Add(Me.LabelHora)
        Me.SplitContainer.Panel1.Controls.Add(Me.ComboBoxTurnos)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.DataGridViewReg)
        Me.SplitContainer.Size = New System.Drawing.Size(560, 378)
        Me.SplitContainer.SplitterDistance = 163
        Me.SplitContainer.TabIndex = 0
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipo.Location = New System.Drawing.Point(389, 83)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(36, 13)
        Me.LabelTipo.TabIndex = 11
        Me.LabelTipo.Text = "Tipo:"
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(392, 99)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(158, 28)
        Me.ComboBoxTipo.TabIndex = 7
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPass.Location = New System.Drawing.Point(12, 101)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(199, 26)
        Me.TextBoxPass.TabIndex = 1
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(12, 83)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(75, 13)
        Me.LabelPassword.TabIndex = 9
        Me.LabelPassword.Text = "Contraseña:"
        '
        'ButtonConfig
        '
        Me.ButtonConfig.Image = Global.ControlHorarioFarm.My.Resources.Resources.settings
        Me.ButtonConfig.Location = New System.Drawing.Point(339, 106)
        Me.ButtonConfig.Name = "ButtonConfig"
        Me.ButtonConfig.Size = New System.Drawing.Size(44, 44)
        Me.ButtonConfig.TabIndex = 5
        Me.ButtonConfig.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrar.Location = New System.Drawing.Point(217, 106)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(116, 44)
        Me.ButtonCerrar.TabIndex = 4
        Me.ButtonCerrar.Text = "&Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'ButtonMarcar
        '
        Me.ButtonMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMarcar.Location = New System.Drawing.Point(217, 46)
        Me.ButtonMarcar.Name = "ButtonMarcar"
        Me.ButtonMarcar.Size = New System.Drawing.Size(166, 54)
        Me.ButtonMarcar.TabIndex = 3
        Me.ButtonMarcar.Text = "&Marcar"
        Me.ButtonMarcar.UseVisualStyleBackColor = True
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTurno.Location = New System.Drawing.Point(389, 27)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(44, 13)
        Me.LabelTurno.TabIndex = 10
        Me.LabelTurno.Text = "Turno:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(12, 27)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(54, 13)
        Me.LabelNombre.TabIndex = 8
        Me.LabelNombre.Text = "Nombre:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(12, 48)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(199, 26)
        Me.TextBoxNombre.TabIndex = 0
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(223, 9)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(151, 37)
        Me.LabelHora.TabIndex = 12
        Me.LabelHora.Text = "00:00:00"
        '
        'ComboBoxTurnos
        '
        Me.ComboBoxTurnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTurnos.FormattingEnabled = True
        Me.ComboBoxTurnos.Location = New System.Drawing.Point(392, 46)
        Me.ComboBoxTurnos.Name = "ComboBoxTurnos"
        Me.ComboBoxTurnos.Size = New System.Drawing.Size(158, 28)
        Me.ComboBoxTurnos.TabIndex = 6
        '
        'DataGridViewReg
        '
        Me.DataGridViewReg.AllowUserToAddRows = False
        Me.DataGridViewReg.AllowUserToDeleteRows = False
        Me.DataGridViewReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Hora, Me.Sucursal, Me.Turno, Me.TurnoID})
        Me.DataGridViewReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewReg.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewReg.Name = "DataGridViewReg"
        Me.DataGridViewReg.ReadOnly = True
        Me.DataGridViewReg.Size = New System.Drawing.Size(560, 211)
        Me.DataGridViewReg.TabIndex = 0
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 50
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Width = 140
        '
        'Sucursal
        '
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        '
        'Turno
        '
        Me.Turno.HeaderText = "Turno"
        Me.Turno.Name = "Turno"
        Me.Turno.ReadOnly = True
        Me.Turno.Width = 150
        '
        'TurnoID
        '
        Me.TurnoID.HeaderText = "Turno ID"
        Me.TurnoID.Name = "TurnoID"
        Me.TurnoID.ReadOnly = True
        Me.TurnoID.Width = 60
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 378)
        Me.Controls.Add(Me.SplitContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Control Horarios Farmacias"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.DataGridViewReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboBoxTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTurno As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents LabelHora As System.Windows.Forms.Label
    Friend WithEvents DataGridViewReg As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonConfig As System.Windows.Forms.Button
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents ButtonMarcar As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents TextBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents LabelTipo As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnoID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
