<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInscri
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Incrinom = New System.Windows.Forms.GroupBox()
        Me.nomjoueur = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newgame = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.score = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lesoptionsbouttons = New System.Windows.Forms.Button()
        Me.Incrinom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Incrinom
        '
        Me.Incrinom.Controls.Add(Me.nomjoueur)
        Me.Incrinom.Controls.Add(Me.Label1)
        Me.Incrinom.Location = New System.Drawing.Point(72, 67)
        Me.Incrinom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Incrinom.Name = "Incrinom"
        Me.Incrinom.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Incrinom.Size = New System.Drawing.Size(614, 191)
        Me.Incrinom.TabIndex = 0
        Me.Incrinom.TabStop = False
        '
        'nomjoueur
        '
        Me.nomjoueur.FormattingEnabled = True
        Me.nomjoueur.Location = New System.Drawing.Point(211, 107)
        Me.nomjoueur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nomjoueur.Name = "nomjoueur"
        Me.nomjoueur.Size = New System.Drawing.Size(189, 24)
        Me.nomjoueur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inserez le nom du joueur"
        '
        'newgame
        '
        Me.newgame.Location = New System.Drawing.Point(24, 352)
        Me.newgame.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.newgame.Name = "newgame"
        Me.newgame.Size = New System.Drawing.Size(148, 50)
        Me.newgame.TabIndex = 2
        Me.newgame.Text = "Nouvelle Partie"
        Me.newgame.UseVisualStyleBackColor = True
        '
        'quitter
        '
        Me.quitter.Location = New System.Drawing.Point(629, 352)
        Me.quitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(147, 50)
        Me.quitter.TabIndex = 3
        Me.quitter.Text = "Quitter"
        Me.quitter.UseVisualStyleBackColor = True
        '
        'score
        '
        Me.score.Location = New System.Drawing.Point(225, 352)
        Me.score.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(136, 50)
        Me.score.TabIndex = 4
        Me.score.Text = "Score"
        Me.score.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'lesoptionsbouttons
        '
        Me.lesoptionsbouttons.Location = New System.Drawing.Point(421, 352)
        Me.lesoptionsbouttons.Name = "lesoptionsbouttons"
        Me.lesoptionsbouttons.Size = New System.Drawing.Size(151, 50)
        Me.lesoptionsbouttons.TabIndex = 5
        Me.lesoptionsbouttons.Text = "Options"
        Me.lesoptionsbouttons.UseVisualStyleBackColor = True
        '
        'FormInscri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lesoptionsbouttons)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.quitter)
        Me.Controls.Add(Me.newgame)
        Me.Controls.Add(Me.Incrinom)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormInscri"
        Me.Text = "Form1"
        Me.Incrinom.ResumeLayout(False)
        Me.Incrinom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Incrinom As GroupBox
    Friend WithEvents nomjoueur As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newgame As Button
    Friend WithEvents quitter As Button
    Friend WithEvents score As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lesoptionsbouttons As Button
End Class
