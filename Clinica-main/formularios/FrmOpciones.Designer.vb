﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Factrura = New System.Windows.Forms.Button()
        Me.Btn_Registro = New System.Windows.Forms.Button()
        Me.Btn_consultas = New System.Windows.Forms.Button()
        Me.Btn_Inicio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(174, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clínica Odontológica Egnio Araúz"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Btn_Factrura)
        Me.Panel1.Controls.Add(Me.Btn_Registro)
        Me.Panel1.Controls.Add(Me.Btn_consultas)
        Me.Panel1.Controls.Add(Me.Btn_Inicio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 427)
        Me.Panel1.TabIndex = 2
        '
        'Btn_Factrura
        '
        Me.Btn_Factrura.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Btn_Factrura.FlatAppearance.BorderSize = 0
        Me.Btn_Factrura.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Factrura.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_Factrura.Location = New System.Drawing.Point(0, 258)
        Me.Btn_Factrura.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Factrura.Name = "Btn_Factrura"
        Me.Btn_Factrura.Size = New System.Drawing.Size(136, 32)
        Me.Btn_Factrura.TabIndex = 3
        Me.Btn_Factrura.Text = "Factura"
        Me.Btn_Factrura.UseVisualStyleBackColor = False
        '
        'Btn_Registro
        '
        Me.Btn_Registro.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Btn_Registro.FlatAppearance.BorderSize = 0
        Me.Btn_Registro.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Registro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_Registro.Location = New System.Drawing.Point(0, 186)
        Me.Btn_Registro.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Registro.Name = "Btn_Registro"
        Me.Btn_Registro.Size = New System.Drawing.Size(136, 32)
        Me.Btn_Registro.TabIndex = 2
        Me.Btn_Registro.Text = "Registro"
        Me.Btn_Registro.UseVisualStyleBackColor = False
        '
        'Btn_consultas
        '
        Me.Btn_consultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Btn_consultas.FlatAppearance.BorderSize = 0
        Me.Btn_consultas.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_consultas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_consultas.Location = New System.Drawing.Point(0, 117)
        Me.Btn_consultas.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_consultas.Name = "Btn_consultas"
        Me.Btn_consultas.Size = New System.Drawing.Size(136, 32)
        Me.Btn_consultas.TabIndex = 1
        Me.Btn_consultas.Text = "Consultas"
        Me.Btn_consultas.UseVisualStyleBackColor = False
        '
        'Btn_Inicio
        '
        Me.Btn_Inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Btn_Inicio.FlatAppearance.BorderSize = 0
        Me.Btn_Inicio.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inicio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_Inicio.Location = New System.Drawing.Point(0, 47)
        Me.Btn_Inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Inicio.Name = "Btn_Inicio"
        Me.Btn_Inicio.Size = New System.Drawing.Size(136, 32)
        Me.Btn_Inicio.TabIndex = 0
        Me.Btn_Inicio.Text = "Inicio "
        Me.Btn_Inicio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 117)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 287)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(55, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Menu de opciones"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'FrmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 427)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmOpciones"
        Me.Text = "Opciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Inicio As Button
    Friend WithEvents Btn_Factrura As Button
    Friend WithEvents Btn_Registro As Button
    Friend WithEvents Btn_consultas As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
