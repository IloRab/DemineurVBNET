<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Demineur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.abandon = New System.Windows.Forms.Button()
        Me.nomjoueur = New System.Windows.Forms.Label()
        Me.LabelChro = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.interfacedejeu = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pause = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'abandon
        '
        Me.abandon.Location = New System.Drawing.Point(27, 406)
        Me.abandon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.abandon.Name = "abandon"
        Me.abandon.Size = New System.Drawing.Size(221, 71)
        Me.abandon.TabIndex = 0
        Me.abandon.Text = "Abandonner "
        Me.abandon.UseVisualStyleBackColor = True
        '
        'nomjoueur
        '
        Me.nomjoueur.AutoSize = True
        Me.nomjoueur.Location = New System.Drawing.Point(79, 33)
        Me.nomjoueur.Name = "nomjoueur"
        Me.nomjoueur.Size = New System.Drawing.Size(48, 16)
        Me.nomjoueur.TabIndex = 1
        Me.nomjoueur.Text = "Label1"
        '
        'LabelChro
        '
        Me.LabelChro.AutoSize = True
        Me.LabelChro.Location = New System.Drawing.Point(69, 42)
        Me.LabelChro.Name = "LabelChro"
        Me.LabelChro.Size = New System.Drawing.Size(58, 16)
        Me.LabelChro.TabIndex = 2
        Me.LabelChro.Text = "LeTemp"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelChro)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 152)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(221, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temp restant"
        '
        'interfacedejeu
        '
        Me.interfacedejeu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.interfacedejeu.Location = New System.Drawing.Point(333, 38)
        Me.interfacedejeu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.interfacedejeu.Name = "interfacedejeu"
        Me.interfacedejeu.Size = New System.Drawing.Size(11, 10)
        Me.interfacedejeu.TabIndex = 2
        '
        'Timer1
        '
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(78, 293)
        Me.Pause.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(103, 64)
        Me.Pause.TabIndex = 5
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nomjoueur)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(221, 78)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Joueur"
        '
        'Demineur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 613)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.interfacedejeu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.abandon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Demineur"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents abandon As Button
    Friend WithEvents nomjoueur As Label
    Friend WithEvents LabelChro As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents interfacedejeu As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pause As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
