<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ClinicaDBDataSet = New Clinica.ClinicaDBDataSet()
        Me.ClinicaDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID = New System.Windows.Forms.Label()
        Me.apellidos = New System.Windows.Forms.Label()
        Me.Nombres = New System.Windows.Forms.Label()
        Me.tel = New System.Windows.Forms.Label()
        Me.dirección = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Txt_id = New System.Windows.Forms.TextBox()
        Me.Txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Txt_telefono = New System.Windows.Forms.TextBox()
        Me.Txt_eml = New System.Windows.Forms.TextBox()
        Me.Btn_opcionesb = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Txt_direccion = New System.Windows.Forms.TextBox()
        Me.emal = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Txb_buscar = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ClinicaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.telefono.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(0, -6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(988, 90)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 84)
        Me.Button1.TabIndex = 45
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(322, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(249, 20)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Datos Generales del Paciente"
        '
        'ClinicaDBDataSet
        '
        Me.ClinicaDBDataSet.DataSetName = "ClinicaDBDataSet"
        Me.ClinicaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClinicaDBDataSetBindingSource
        '
        Me.ClinicaDBDataSetBindingSource.DataSource = Me.ClinicaDBDataSet
        Me.ClinicaDBDataSetBindingSource.Position = 0
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ID.Location = New System.Drawing.Point(95, 73)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(30, 20)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID:"
        '
        'apellidos
        '
        Me.apellidos.AutoSize = True
        Me.apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.apellidos.Location = New System.Drawing.Point(44, 137)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(77, 20)
        Me.apellidos.TabIndex = 1
        Me.apellidos.Text = "Apellidos:"
        '
        'Nombres
        '
        Me.Nombres.AutoSize = True
        Me.Nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombres.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Nombres.Location = New System.Drawing.Point(475, 61)
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(77, 20)
        Me.Nombres.TabIndex = 3
        Me.Nombres.Text = "Nombres:"
        '
        'tel
        '
        Me.tel.AutoSize = True
        Me.tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.tel.Location = New System.Drawing.Point(475, 137)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(75, 20)
        Me.tel.TabIndex = 4
        Me.tel.Text = "Teléfono:"
        '
        'dirección
        '
        Me.dirección.AutoSize = True
        Me.dirección.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dirección.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.dirección.Location = New System.Drawing.Point(46, 202)
        Me.dirección.Name = "dirección"
        Me.dirección.Size = New System.Drawing.Size(79, 20)
        Me.dirección.TabIndex = 6
        Me.dirección.Text = "Dirección:"
        '
        'Txt_email
        '
        Me.Txt_email.AutoSize = True
        Me.Txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_email.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Txt_email.Location = New System.Drawing.Point(491, 202)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(0, 20)
        Me.Txt_email.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(514, 276)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 17)
        Me.Label24.TabIndex = 11
        '
        'bt_guardar
        '
        Me.bt_guardar.BackColor = System.Drawing.Color.RoyalBlue
        Me.bt_guardar.ForeColor = System.Drawing.Color.Transparent
        Me.bt_guardar.Location = New System.Drawing.Point(151, 355)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(90, 34)
        Me.bt_guardar.TabIndex = 23
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.Red
        Me.bt_eliminar.Location = New System.Drawing.Point(346, 355)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(90, 34)
        Me.bt_eliminar.TabIndex = 24
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(99, 524)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.Size = New System.Drawing.Size(776, 316)
        Me.DataGridView1.TabIndex = 34
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(111, 354)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(309, 355)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'txt_nombres
        '
        Me.txt_nombres.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombres.Location = New System.Drawing.Point(557, 56)
        Me.txt_nombres.Multiline = True
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(297, 32)
        Me.txt_nombres.TabIndex = 2
        '
        'Txt_id
        '
        Me.Txt_id.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id.Location = New System.Drawing.Point(151, 61)
        Me.Txt_id.Multiline = True
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(248, 32)
        Me.Txt_id.TabIndex = 1
        Me.Txt_id.Tag = ""
        '
        'Txt_apellidos
        '
        Me.Txt_apellidos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Txt_apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_apellidos.Location = New System.Drawing.Point(151, 125)
        Me.Txt_apellidos.Multiline = True
        Me.Txt_apellidos.Name = "Txt_apellidos"
        Me.Txt_apellidos.Size = New System.Drawing.Size(248, 32)
        Me.Txt_apellidos.TabIndex = 3
        '
        'Txt_telefono
        '
        Me.Txt_telefono.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Txt_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_telefono.Location = New System.Drawing.Point(557, 125)
        Me.Txt_telefono.Multiline = True
        Me.Txt_telefono.Name = "Txt_telefono"
        Me.Txt_telefono.Size = New System.Drawing.Size(299, 32)
        Me.Txt_telefono.TabIndex = 4
        '
        'Txt_eml
        '
        Me.Txt_eml.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Txt_eml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_eml.Location = New System.Drawing.Point(557, 202)
        Me.Txt_eml.Multiline = True
        Me.Txt_eml.Name = "Txt_eml"
        Me.Txt_eml.Size = New System.Drawing.Size(298, 32)
        Me.Txt_eml.TabIndex = 6
        '
        'Btn_opcionesb
        '
        Me.Btn_opcionesb.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_opcionesb.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_opcionesb.Location = New System.Drawing.Point(711, 354)
        Me.Btn_opcionesb.Name = "Btn_opcionesb"
        Me.Btn_opcionesb.Size = New System.Drawing.Size(164, 34)
        Me.Btn_opcionesb.TabIndex = 61
        Me.Btn_opcionesb.Text = "Menu de opciones"
        Me.Btn_opcionesb.UseVisualStyleBackColor = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(978, 13)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(13, 888)
        Me.VScrollBar1.TabIndex = 62
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_direccion.Location = New System.Drawing.Point(151, 199)
        Me.Txt_direccion.Multiline = True
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(248, 30)
        Me.Txt_direccion.TabIndex = 5
        '
        'emal
        '
        Me.emal.AutoSize = True
        Me.emal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.emal.Location = New System.Drawing.Point(491, 202)
        Me.emal.Name = "emal"
        Me.emal.Size = New System.Drawing.Size(52, 20)
        Me.emal.TabIndex = 64
        Me.emal.Text = "Email:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(666, 354)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'Txb_buscar
        '
        Me.Txb_buscar.Location = New System.Drawing.Point(178, 463)
        Me.Txb_buscar.Multiline = True
        Me.Txb_buscar.Name = "Txb_buscar"
        Me.Txb_buscar.Size = New System.Drawing.Size(454, 34)
        Me.Txb_buscar.TabIndex = 7
        '
        'buscar
        '
        Me.buscar.AutoSize = True
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.buscar.Location = New System.Drawing.Point(107, 463)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(70, 20)
        Me.buscar.TabIndex = 67
        Me.buscar.Text = "Buscar:"
        '
        'telefono
        '
        Me.telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.telefono.Controls.Add(Me.btn_buscar)
        Me.telefono.Controls.Add(Me.buscar)
        Me.telefono.Controls.Add(Me.Txb_buscar)
        Me.telefono.Controls.Add(Me.PictureBox2)
        Me.telefono.Controls.Add(Me.emal)
        Me.telefono.Controls.Add(Me.Txt_direccion)
        Me.telefono.Controls.Add(Me.VScrollBar1)
        Me.telefono.Controls.Add(Me.Btn_opcionesb)
        Me.telefono.Controls.Add(Me.Txt_eml)
        Me.telefono.Controls.Add(Me.Txt_telefono)
        Me.telefono.Controls.Add(Me.Txt_apellidos)
        Me.telefono.Controls.Add(Me.Txt_id)
        Me.telefono.Controls.Add(Me.txt_nombres)
        Me.telefono.Controls.Add(Me.PictureBox5)
        Me.telefono.Controls.Add(Me.PictureBox4)
        Me.telefono.Controls.Add(Me.DataGridView1)
        Me.telefono.Controls.Add(Me.bt_eliminar)
        Me.telefono.Controls.Add(Me.bt_guardar)
        Me.telefono.Controls.Add(Me.Label24)
        Me.telefono.Controls.Add(Me.Txt_email)
        Me.telefono.Controls.Add(Me.dirección)
        Me.telefono.Controls.Add(Me.tel)
        Me.telefono.Controls.Add(Me.Nombres)
        Me.telefono.Controls.Add(Me.apellidos)
        Me.telefono.Controls.Add(Me.ID)
        Me.telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono.Location = New System.Drawing.Point(0, 84)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(994, 921)
        Me.telefono.TabIndex = 1
        Me.telefono.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_buscar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_buscar.Location = New System.Drawing.Point(638, 463)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 34)
        Me.btn_buscar.TabIndex = 68
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(990, 994)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form1"
        Me.Text = "FrmPricipal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ClinicaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.telefono.ResumeLayout(False)
        Me.telefono.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ClinicaDBDataSetBindingSource As BindingSource
    Friend WithEvents ClinicaDBDataSet As ClinicaDBDataSet
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ID As Label
    Friend WithEvents apellidos As Label
    Friend WithEvents Nombres As Label
    Friend WithEvents tel As Label
    Friend WithEvents dirección As Label
    Friend WithEvents Txt_email As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents bt_guardar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Txt_id As TextBox
    Friend WithEvents Txt_apellidos As TextBox
    Friend WithEvents Txt_telefono As TextBox
    Friend WithEvents Txt_eml As TextBox
    Friend WithEvents Btn_opcionesb As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Txt_direccion As TextBox
    Friend WithEvents emal As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Txb_buscar As TextBox
    Friend WithEvents buscar As Label
    Friend WithEvents telefono As GroupBox
    Friend WithEvents btn_buscar As Button
End Class
