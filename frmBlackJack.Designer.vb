<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlackJack
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlackJack))
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnStand = New System.Windows.Forms.Button()
        Me.lstPlayerHand = New System.Windows.Forms.ListBox()
        Me.lstDealerHand = New System.Windows.Forms.ListBox()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblDealerScore = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHit
        '
        Me.btnHit.Image = CType(resources.GetObject("btnHit.Image"), System.Drawing.Image)
        Me.btnHit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHit.Location = New System.Drawing.Point(174, 115)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(67, 34)
        Me.btnHit.TabIndex = 0
        Me.btnHit.Text = "Hit"
        Me.btnHit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnStand
        '
        Me.btnStand.Image = CType(resources.GetObject("btnStand.Image"), System.Drawing.Image)
        Me.btnStand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStand.Location = New System.Drawing.Point(174, 156)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(67, 36)
        Me.btnStand.TabIndex = 1
        Me.btnStand.Text = "Stop"
        Me.btnStand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'lstPlayerHand
        '
        Me.lstPlayerHand.FormattingEnabled = True
        Me.lstPlayerHand.Location = New System.Drawing.Point(4, 172)
        Me.lstPlayerHand.Name = "lstPlayerHand"
        Me.lstPlayerHand.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayerHand.TabIndex = 2
        '
        'lstDealerHand
        '
        Me.lstDealerHand.FormattingEnabled = True
        Me.lstDealerHand.Location = New System.Drawing.Point(4, 54)
        Me.lstDealerHand.Name = "lstDealerHand"
        Me.lstDealerHand.Size = New System.Drawing.Size(120, 95)
        Me.lstDealerHand.TabIndex = 3
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.ForeColor = System.Drawing.Color.White
        Me.lblPlayerScore.Location = New System.Drawing.Point(124, 205)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(39, 13)
        Me.lblPlayerScore.TabIndex = 4
        Me.lblPlayerScore.Text = "Label1"
        '
        'lblDealerScore
        '
        Me.lblDealerScore.AutoSize = True
        Me.lblDealerScore.ForeColor = System.Drawing.Color.White
        Me.lblDealerScore.Location = New System.Drawing.Point(125, 75)
        Me.lblDealerScore.Name = "lblDealerScore"
        Me.lblDealerScore.Size = New System.Drawing.Size(39, 13)
        Me.lblDealerScore.TabIndex = 5
        Me.lblDealerScore.Text = "Label2"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(1, 272)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(39, 13)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Label1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(253, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripLabel1.Text = "Nuova partita"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dealer cards"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Player cards"
        '
        'frmBlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(253, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblDealerScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lstDealerHand)
        Me.Controls.Add(Me.lstPlayerHand)
        Me.Controls.Add(Me.btnStand)
        Me.Controls.Add(Me.btnHit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBlackJack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHit As Button
    Friend WithEvents btnStand As Button
    Friend WithEvents lstPlayerHand As ListBox
    Friend WithEvents lstDealerHand As ListBox
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblDealerScore As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
