<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinPool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinPool))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddMiningPoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveMiningPoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxBxNamePool = New System.Windows.Forms.TextBox()
        Me.TxBxAddrPool = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxBxMiniPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(5, 47)
        Me.ListView1.MaximumSize = New System.Drawing.Size(326, 306)
        Me.ListView1.MinimumSize = New System.Drawing.Size(326, 241)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(326, 306)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mining Pool"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Address of Pool"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Port of mining"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMiningPoolToolStripMenuItem, Me.RemoveMiningPoolToolStripMenuItem, Me.SaveReloadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 70)
        '
        'AddMiningPoolToolStripMenuItem
        '
        Me.AddMiningPoolToolStripMenuItem.Name = "AddMiningPoolToolStripMenuItem"
        Me.AddMiningPoolToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddMiningPoolToolStripMenuItem.Text = "Add Mining Pool"
        '
        'RemoveMiningPoolToolStripMenuItem
        '
        Me.RemoveMiningPoolToolStripMenuItem.Name = "RemoveMiningPoolToolStripMenuItem"
        Me.RemoveMiningPoolToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoveMiningPoolToolStripMenuItem.Text = "Remove Mining Pool"
        '
        'SaveReloadToolStripMenuItem
        '
        Me.SaveReloadToolStripMenuItem.Name = "SaveReloadToolStripMenuItem"
        Me.SaveReloadToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaveReloadToolStripMenuItem.Text = "Save && Reload"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.XGUI.My.Resources.Resources.x
        Me.PictureBox1.Location = New System.Drawing.Point(305, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-7, -18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(347, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name of Pool:"
        '
        'TxBxNamePool
        '
        Me.TxBxNamePool.BackColor = System.Drawing.Color.Black
        Me.TxBxNamePool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxBxNamePool.ForeColor = System.Drawing.Color.White
        Me.TxBxNamePool.Location = New System.Drawing.Point(93, 330)
        Me.TxBxNamePool.Name = "TxBxNamePool"
        Me.TxBxNamePool.Size = New System.Drawing.Size(100, 21)
        Me.TxBxNamePool.TabIndex = 5
        Me.TxBxNamePool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxBxAddrPool
        '
        Me.TxBxAddrPool.BackColor = System.Drawing.Color.Black
        Me.TxBxAddrPool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxBxAddrPool.ForeColor = System.Drawing.Color.White
        Me.TxBxAddrPool.Location = New System.Drawing.Point(92, 300)
        Me.TxBxAddrPool.Name = "TxBxAddrPool"
        Me.TxBxAddrPool.Size = New System.Drawing.Size(100, 21)
        Me.TxBxAddrPool.TabIndex = 7
        Me.TxBxAddrPool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Address of Pool:"
        '
        'TxBxMiniPort
        '
        Me.TxBxMiniPort.BackColor = System.Drawing.Color.Black
        Me.TxBxMiniPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxBxMiniPort.ForeColor = System.Drawing.Color.White
        Me.TxBxMiniPort.Location = New System.Drawing.Point(271, 300)
        Me.TxBxMiniPort.Name = "TxBxMiniPort"
        Me.TxBxMiniPort.Size = New System.Drawing.Size(60, 21)
        Me.TxBxMiniPort.TabIndex = 9
        Me.TxBxMiniPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Minig Port:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(256, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Add Pool"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MinPool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(338, 359)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxBxMiniPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxBxAddrPool)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxBxNamePool)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MinPool"
        Me.Text = "MinPool"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddMiningPoolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveMiningPoolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxBxNamePool As TextBox
    Friend WithEvents TxBxAddrPool As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxBxMiniPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
