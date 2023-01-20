<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scoreEnregistrement
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
        Me.Nomjoueur = New System.Windows.Forms.ListBox()
        Me.nbcasetotale = New System.Windows.Forms.ListBox()
        Me.Nbpartie = New System.Windows.Forms.ListBox()
        Me.Tempstotale = New System.Windows.Forms.ListBox()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Nomjoueur
        '
        Me.Nomjoueur.FormattingEnabled = True
        Me.Nomjoueur.ItemHeight = 16
        Me.Nomjoueur.Location = New System.Drawing.Point(75, 132)
        Me.Nomjoueur.Margin = New System.Windows.Forms.Padding(4)
        Me.Nomjoueur.Name = "Nomjoueur"
        Me.Nomjoueur.Size = New System.Drawing.Size(159, 116)
        Me.Nomjoueur.TabIndex = 1
        '
        'nbcasetotale
        '
        Me.nbcasetotale.FormattingEnabled = True
        Me.nbcasetotale.ItemHeight = 16
        Me.nbcasetotale.Location = New System.Drawing.Point(297, 132)
        Me.nbcasetotale.Margin = New System.Windows.Forms.Padding(4)
        Me.nbcasetotale.Name = "nbcasetotale"
        Me.nbcasetotale.Size = New System.Drawing.Size(159, 116)
        Me.nbcasetotale.TabIndex = 2
        '
        'Nbpartie
        '
        Me.Nbpartie.FormattingEnabled = True
        Me.Nbpartie.ItemHeight = 16
        Me.Nbpartie.Location = New System.Drawing.Point(551, 132)
        Me.Nbpartie.Margin = New System.Windows.Forms.Padding(4)
        Me.Nbpartie.Name = "Nbpartie"
        Me.Nbpartie.Size = New System.Drawing.Size(159, 116)
        Me.Nbpartie.TabIndex = 3
        '
        'Tempstotale
        '
        Me.Tempstotale.FormattingEnabled = True
        Me.Tempstotale.ItemHeight = 16
        Me.Tempstotale.Location = New System.Drawing.Point(811, 132)
        Me.Tempstotale.Margin = New System.Windows.Forms.Padding(4)
        Me.Tempstotale.Name = "Tempstotale"
        Me.Tempstotale.Size = New System.Drawing.Size(159, 116)
        Me.Tempstotale.TabIndex = 4
        '
        'Retour
        '
        Me.Retour.Location = New System.Drawing.Point(747, 379)
        Me.Retour.Margin = New System.Windows.Forms.Padding(4)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(133, 77)
        Me.Retour.TabIndex = 5
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 356)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 47)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ordre croissant "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "NbCase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(596, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nb Partie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(868, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Temps"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(220, 442)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 47)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Ordre décroissant "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(439, 406)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(237, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'scoreEnregistrement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.Tempstotale)
        Me.Controls.Add(Me.Nbpartie)
        Me.Controls.Add(Me.nbcasetotale)
        Me.Controls.Add(Me.Nomjoueur)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "scoreEnregistrement"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nomjoueur As ListBox
    Friend WithEvents nbcasetotale As ListBox
    Friend WithEvents Nbpartie As ListBox
    Friend WithEvents Tempstotale As ListBox
    Friend WithEvents Retour As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
