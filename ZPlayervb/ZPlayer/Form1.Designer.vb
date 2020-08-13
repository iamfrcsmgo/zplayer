<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZPlayer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZPlayer))
        Me.ajouter = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Options = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.restaurer = New System.Windows.Forms.Button()
        Me.theme = New System.Windows.Forms.Button()
        Me.transparence = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Playlist = New System.Windows.Forms.ListBox()
        Me.addplaylist = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.plusecran = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.heure = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.naviguer = New System.Windows.Forms.Button()
        Me.precedent = New System.Windows.Forms.Button()
        Me.suivant = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ajouter
        '
        Me.ajouter.Location = New System.Drawing.Point(627, 12)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(76, 23)
        Me.ajouter.TabIndex = 0
        Me.ajouter.Text = "..."
        Me.ajouter.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(12, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(609, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Options
        '
        Me.Options.Location = New System.Drawing.Point(12, 41)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(691, 25)
        Me.Options.TabIndex = 2
        Me.Options.Text = "Options"
        Me.Options.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(13, 70)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(690, 504)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'restaurer
        '
        Me.restaurer.Location = New System.Drawing.Point(619, 575)
        Me.restaurer.Name = "restaurer"
        Me.restaurer.Size = New System.Drawing.Size(84, 29)
        Me.restaurer.TabIndex = 4
        Me.restaurer.Text = "Restaurer"
        Me.restaurer.UseVisualStyleBackColor = True
        '
        'theme
        '
        Me.theme.Location = New System.Drawing.Point(12, 575)
        Me.theme.Name = "theme"
        Me.theme.Size = New System.Drawing.Size(84, 29)
        Me.theme.TabIndex = 5
        Me.theme.Text = "Thème"
        Me.theme.UseVisualStyleBackColor = True
        '
        'transparence
        '
        Me.transparence.AutoSize = True
        Me.transparence.Location = New System.Drawing.Point(286, 580)
        Me.transparence.Name = "transparence"
        Me.transparence.Size = New System.Drawing.Size(119, 21)
        Me.transparence.TabIndex = 6
        Me.transparence.Text = "Transparence"
        Me.transparence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.transparence.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Fichier MP3|* .mp3|Fichier MP4|* .mp4|Tous les fichiers|*.*"
        '
        'Playlist
        '
        Me.Playlist.FormattingEnabled = True
        Me.Playlist.ItemHeight = 16
        Me.Playlist.Location = New System.Drawing.Point(709, 13)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Size = New System.Drawing.Size(373, 580)
        Me.Playlist.TabIndex = 8
        '
        'addplaylist
        '
        Me.addplaylist.Location = New System.Drawing.Point(707, 599)
        Me.addplaylist.Name = "addplaylist"
        Me.addplaylist.Size = New System.Drawing.Size(142, 29)
        Me.addplaylist.TabIndex = 9
        Me.addplaylist.Text = "Ajouter à la playlist"
        Me.addplaylist.UseVisualStyleBackColor = True
        '
        'Supprimer
        '
        Me.Supprimer.Location = New System.Drawing.Point(998, 599)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(84, 29)
        Me.Supprimer.TabIndex = 10
        Me.Supprimer.Text = "Supprimer"
        Me.Supprimer.UseVisualStyleBackColor = True
        '
        'plusecran
        '
        Me.plusecran.Location = New System.Drawing.Point(344, 540)
        Me.plusecran.Name = "plusecran"
        Me.plusecran.Size = New System.Drawing.Size(359, 29)
        Me.plusecran.TabIndex = 11
        Me.plusecran.Text = "Cliquer 2 fois sur lecteur pour le mettre en plein écran"
        Me.plusecran.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 610)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(658, 301)
        Me.WebBrowser1.TabIndex = 12
        Me.WebBrowser1.Url = New System.Uri("https://www.youtube.com/", System.UriKind.Absolute)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(707, 692)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(294, 22)
        Me.TextBox2.TabIndex = 13
        '
        'heure
        '
        Me.heure.AutoSize = True
        Me.heure.Font = New System.Drawing.Font("News701 BT", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heure.Location = New System.Drawing.Point(701, 631)
        Me.heure.Name = "heure"
        Me.heure.Size = New System.Drawing.Size(141, 46)
        Me.heure.TabIndex = 14
        Me.heure.Text = "Heure"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'naviguer
        '
        Me.naviguer.BackColor = System.Drawing.SystemColors.Window
        Me.naviguer.Image = CType(resources.GetObject("naviguer.Image"), System.Drawing.Image)
        Me.naviguer.Location = New System.Drawing.Point(1007, 678)
        Me.naviguer.Name = "naviguer"
        Me.naviguer.Size = New System.Drawing.Size(75, 51)
        Me.naviguer.TabIndex = 15
        Me.naviguer.UseVisualStyleBackColor = False
        '
        'precedent
        '
        Me.precedent.BackColor = System.Drawing.SystemColors.Window
        Me.precedent.Image = CType(resources.GetObject("precedent.Image"), System.Drawing.Image)
        Me.precedent.Location = New System.Drawing.Point(709, 735)
        Me.precedent.Name = "precedent"
        Me.precedent.Size = New System.Drawing.Size(75, 51)
        Me.precedent.TabIndex = 16
        Me.precedent.UseVisualStyleBackColor = False
        '
        'suivant
        '
        Me.suivant.BackColor = System.Drawing.SystemColors.Window
        Me.suivant.Image = CType(resources.GetObject("suivant.Image"), System.Drawing.Image)
        Me.suivant.Location = New System.Drawing.Point(1007, 735)
        Me.suivant.Name = "suivant"
        Me.suivant.Size = New System.Drawing.Size(75, 51)
        Me.suivant.TabIndex = 17
        Me.suivant.UseVisualStyleBackColor = False
        '
        'ZPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 912)
        Me.Controls.Add(Me.suivant)
        Me.Controls.Add(Me.precedent)
        Me.Controls.Add(Me.naviguer)
        Me.Controls.Add(Me.heure)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.plusecran)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.addplaylist)
        Me.Controls.Add(Me.Playlist)
        Me.Controls.Add(Me.transparence)
        Me.Controls.Add(Me.theme)
        Me.Controls.Add(Me.restaurer)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ajouter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ZPlayer"
        Me.Text = "ZPlayer"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Options As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents restaurer As System.Windows.Forms.Button
    Friend WithEvents theme As System.Windows.Forms.Button
    Friend WithEvents transparence As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Playlist As System.Windows.Forms.ListBox
    Friend WithEvents addplaylist As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents plusecran As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents heure As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents naviguer As System.Windows.Forms.Button
    Friend WithEvents precedent As System.Windows.Forms.Button
    Friend WithEvents suivant As System.Windows.Forms.Button

End Class
