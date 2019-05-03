<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.label2 = New System.Windows.Forms.Label()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.Name = "label2"
        '
        'linkLabel1
        '
        resources.ApplyResources(Me.linkLabel1, "linkLabel1")
        Me.linkLabel1.LinkColor = System.Drawing.Color.Black
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.TabStop = True
        '
        'button1
        '
        resources.ApplyResources(Me.button1, "button1")
        Me.button1.Name = "button1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        resources.ApplyResources(Me.textBox2, "textBox2")
        Me.textBox2.Name = "textBox2"
        Me.textBox2.UseSystemPasswordChar = True
        '
        'label3
        '
        resources.ApplyResources(Me.label3, "label3")
        Me.label3.Name = "label3"
        '
        'textBox1
        '
        resources.ApplyResources(Me.textBox1, "textBox1")
        Me.textBox1.Name = "textBox1"
        '
        'label1
        '
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.Name = "label1"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Taller_2.My.Resources.Resources.nba
        resources.ApplyResources(Me.pictureBox1, "pictureBox1")
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.TabStop = False
        '
        'Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents button1 As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
End Class
