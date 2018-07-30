<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GoWeb = New System.Windows.Forms.Label()
        Me.Box11 = New System.Windows.Forms.ListBox()
        Me.Box2 = New System.Windows.Forms.ListBox()
        Me.Box22 = New System.Windows.Forms.ListBox()
        Me.BoxTxt1 = New System.Windows.Forms.TextBox()
        Me.TipTxt1 = New System.Windows.Forms.TextBox()
        Me.BoxTxt2 = New System.Windows.Forms.TextBox()
        Me.TipTxt2 = New System.Windows.Forms.TextBox()
        Me.TimTxt2 = New System.Windows.Forms.TextBox()
        Me.NowTxt2 = New System.Windows.Forms.TextBox()
        Me.TimTxt1 = New System.Windows.Forms.TextBox()
        Me.NowTxt1 = New System.Windows.Forms.TextBox()
        Me.VolCtrl1 = New System.Windows.Forms.VScrollBar()
        Me.Speaker1 = New System.Windows.Forms.Label()
        Me.Rpt1 = New System.Windows.Forms.Label()
        Me.One1 = New System.Windows.Forms.Label()
        Me.Lst1 = New System.Windows.Forms.Label()
        Me.Sol1 = New System.Windows.Forms.Label()
        Me.Speed1 = New System.Windows.Forms.NumericUpDown()
        Me.Speaker2 = New System.Windows.Forms.Label()
        Me.Rpt2 = New System.Windows.Forms.Label()
        Me.One2 = New System.Windows.Forms.Label()
        Me.VolCtrl2 = New System.Windows.Forms.VScrollBar()
        Me.Speed2 = New System.Windows.Forms.NumericUpDown()
        Me.Lst2 = New System.Windows.Forms.Label()
        Me.Sol2 = New System.Windows.Forms.Label()
        Me.Poz2 = New System.Windows.Forms.Label()
        Me.Poz1 = New System.Windows.Forms.Label()
        Me.NowTime = New System.Windows.Forms.Label()
        Me.BackCtrl = New System.Windows.Forms.NumericUpDown()
        Me.BckTime = New System.Windows.Forms.Label()
        Me.WaitCtrl = New System.Windows.Forms.NumericUpDown()
        Me.SysTime = New System.Windows.Forms.Label()
        Me.PlyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Pict2 = New System.Windows.Forms.PictureBox()
        Me.Pict1 = New System.Windows.Forms.PictureBox()
        Me.Pict0 = New System.Windows.Forms.PictureBox()
        Me.Bell = New System.Windows.Forms.PictureBox()
        Me.Paso = New System.Windows.Forms.PictureBox()
        Me.FolderOpen = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Box1 = New System.Windows.Forms.ListBox()
        Me.Edit1 = New System.Windows.Forms.TextBox()
        Me.Edit2 = New System.Windows.Forms.TextBox()
        CType(Me.Speed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Speed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoWeb
        '
        Me.GoWeb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GoWeb.AutoSize = True
        Me.GoWeb.BackColor = System.Drawing.Color.Green
        Me.GoWeb.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.GoWeb.ForeColor = System.Drawing.Color.White
        Me.GoWeb.Location = New System.Drawing.Point(392, 187)
        Me.GoWeb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GoWeb.Name = "GoWeb"
        Me.GoWeb.Size = New System.Drawing.Size(25, 19)
        Me.GoWeb.TabIndex = 0
        Me.GoWeb.Text = "ü"
        '
        'Box11
        '
        Me.Box11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Box11.FormattingEnabled = True
        Me.Box11.Location = New System.Drawing.Point(356, 213)
        Me.Box11.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Box11.Name = "Box11"
        Me.Box11.Size = New System.Drawing.Size(45, 212)
        Me.Box11.TabIndex = 2
        Me.Box11.Visible = False
        '
        'Box2
        '
        Me.Box2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Box2.BackColor = System.Drawing.Color.Black
        Me.Box2.ForeColor = System.Drawing.Color.White
        Me.Box2.FormattingEnabled = True
        Me.Box2.HorizontalScrollbar = True
        Me.Box2.Location = New System.Drawing.Point(428, 226)
        Me.Box2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(311, 212)
        Me.Box2.TabIndex = 3
        '
        'Box22
        '
        Me.Box22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Box22.FormattingEnabled = True
        Me.Box22.Location = New System.Drawing.Point(736, 213)
        Me.Box22.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Box22.Name = "Box22"
        Me.Box22.Size = New System.Drawing.Size(55, 212)
        Me.Box22.TabIndex = 4
        Me.Box22.Visible = False
        '
        'BoxTxt1
        '
        Me.BoxTxt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BoxTxt1.BackColor = System.Drawing.Color.Black
        Me.BoxTxt1.ForeColor = System.Drawing.Color.White
        Me.BoxTxt1.Location = New System.Drawing.Point(2, 186)
        Me.BoxTxt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BoxTxt1.Name = "BoxTxt1"
        Me.BoxTxt1.Size = New System.Drawing.Size(288, 20)
        Me.BoxTxt1.TabIndex = 5
        Me.BoxTxt1.TabStop = False
        Me.BoxTxt1.Text = "Add & Select Song"
        '
        'TipTxt1
        '
        Me.TipTxt1.BackColor = System.Drawing.Color.Black
        Me.TipTxt1.ForeColor = System.Drawing.Color.White
        Me.TipTxt1.Location = New System.Drawing.Point(294, 187)
        Me.TipTxt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TipTxt1.Name = "TipTxt1"
        Me.TipTxt1.Size = New System.Drawing.Size(94, 20)
        Me.TipTxt1.TabIndex = 6
        Me.TipTxt1.TabStop = False
        Me.TipTxt1.Text = "TipTxt1"
        Me.TipTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoxTxt2
        '
        Me.BoxTxt2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BoxTxt2.BackColor = System.Drawing.Color.Black
        Me.BoxTxt2.ForeColor = System.Drawing.Color.White
        Me.BoxTxt2.Location = New System.Drawing.Point(421, 186)
        Me.BoxTxt2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BoxTxt2.Name = "BoxTxt2"
        Me.BoxTxt2.Size = New System.Drawing.Size(300, 20)
        Me.BoxTxt2.TabIndex = 7
        Me.BoxTxt2.TabStop = False
        Me.BoxTxt2.Text = "Add & Select Song"
        '
        'TipTxt2
        '
        Me.TipTxt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipTxt2.BackColor = System.Drawing.Color.Black
        Me.TipTxt2.ForeColor = System.Drawing.Color.White
        Me.TipTxt2.Location = New System.Drawing.Point(725, 185)
        Me.TipTxt2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TipTxt2.Name = "TipTxt2"
        Me.TipTxt2.Size = New System.Drawing.Size(72, 20)
        Me.TipTxt2.TabIndex = 8
        Me.TipTxt2.TabStop = False
        Me.TipTxt2.Text = "TipTxt2"
        Me.TipTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimTxt2
        '
        Me.TimTxt2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimTxt2.BackColor = System.Drawing.Color.Black
        Me.TimTxt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TimTxt2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.TimTxt2.Location = New System.Drawing.Point(743, 3)
        Me.TimTxt2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TimTxt2.Name = "TimTxt2"
        Me.TimTxt2.Size = New System.Drawing.Size(50, 20)
        Me.TimTxt2.TabIndex = 12
        Me.TimTxt2.TabStop = False
        Me.TimTxt2.Text = "00:00:00"
        Me.TimTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NowTxt2
        '
        Me.NowTxt2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NowTxt2.BackColor = System.Drawing.Color.Black
        Me.NowTxt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NowTxt2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.NowTxt2.Location = New System.Drawing.Point(478, 1)
        Me.NowTxt2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NowTxt2.Name = "NowTxt2"
        Me.NowTxt2.Size = New System.Drawing.Size(261, 20)
        Me.NowTxt2.TabIndex = 11
        Me.NowTxt2.TabStop = False
        Me.NowTxt2.Text = "Dance Player <Dóka Tamás>"
        '
        'TimTxt1
        '
        Me.TimTxt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TimTxt1.BackColor = System.Drawing.Color.Black
        Me.TimTxt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TimTxt1.ForeColor = System.Drawing.Color.Salmon
        Me.TimTxt1.Location = New System.Drawing.Point(267, 3)
        Me.TimTxt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TimTxt1.Name = "TimTxt1"
        Me.TimTxt1.Size = New System.Drawing.Size(56, 20)
        Me.TimTxt1.TabIndex = 10
        Me.TimTxt1.TabStop = False
        Me.TimTxt1.Text = "00:00:00"
        Me.TimTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NowTxt1
        '
        Me.NowTxt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NowTxt1.BackColor = System.Drawing.Color.Black
        Me.NowTxt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.NowTxt1.ForeColor = System.Drawing.Color.Salmon
        Me.NowTxt1.Location = New System.Drawing.Point(2, 3)
        Me.NowTxt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.NowTxt1.Name = "NowTxt1"
        Me.NowTxt1.Size = New System.Drawing.Size(263, 20)
        Me.NowTxt1.TabIndex = 9
        Me.NowTxt1.TabStop = False
        Me.NowTxt1.Text = "Dance Player (2018)"
        '
        'VolCtrl1
        '
        Me.VolCtrl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VolCtrl1.LargeChange = 1
        Me.VolCtrl1.Location = New System.Drawing.Point(2, 26)
        Me.VolCtrl1.Name = "VolCtrl1"
        Me.VolCtrl1.Size = New System.Drawing.Size(16, 153)
        Me.VolCtrl1.TabIndex = 93
        Me.VolCtrl1.Value = 50
        '
        'Speaker1
        '
        Me.Speaker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Speaker1.AutoSize = True
        Me.Speaker1.BackColor = System.Drawing.Color.Black
        Me.Speaker1.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Speaker1.ForeColor = System.Drawing.Color.Salmon
        Me.Speaker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Speaker1.Location = New System.Drawing.Point(80, 26)
        Me.Speaker1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Speaker1.Name = "Speaker1"
        Me.Speaker1.Size = New System.Drawing.Size(20, 24)
        Me.Speaker1.TabIndex = 109
        Me.Speaker1.Text = "X"
        Me.Speaker1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rpt1
        '
        Me.Rpt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rpt1.AutoSize = True
        Me.Rpt1.BackColor = System.Drawing.Color.Black
        Me.Rpt1.Font = New System.Drawing.Font("Webdings", 14.25!)
        Me.Rpt1.ForeColor = System.Drawing.Color.Lime
        Me.Rpt1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Rpt1.Location = New System.Drawing.Point(44, 67)
        Me.Rpt1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.Size = New System.Drawing.Size(29, 24)
        Me.Rpt1.TabIndex = 111
        Me.Rpt1.Text = "q"
        Me.Rpt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'One1
        '
        Me.One1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.One1.AutoSize = True
        Me.One1.BackColor = System.Drawing.Color.Black
        Me.One1.Font = New System.Drawing.Font("Wingdings 2", 18.0!)
        Me.One1.ForeColor = System.Drawing.Color.Salmon
        Me.One1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.One1.Location = New System.Drawing.Point(79, 67)
        Me.One1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.One1.Name = "One1"
        Me.One1.Size = New System.Drawing.Size(33, 25)
        Me.One1.TabIndex = 112
        Me.One1.Text = "u"
        Me.One1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lst1
        '
        Me.Lst1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lst1.AutoSize = True
        Me.Lst1.BackColor = System.Drawing.Color.Black
        Me.Lst1.Font = New System.Drawing.Font("Wingdings 2", 18.0!)
        Me.Lst1.ForeColor = System.Drawing.Color.Lime
        Me.Lst1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lst1.Location = New System.Drawing.Point(40, 106)
        Me.Lst1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lst1.Name = "Lst1"
        Me.Lst1.Size = New System.Drawing.Size(33, 25)
        Me.Lst1.TabIndex = 114
        Me.Lst1.Text = "1"
        Me.Lst1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sol1
        '
        Me.Sol1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sol1.AutoSize = True
        Me.Sol1.BackColor = System.Drawing.Color.Black
        Me.Sol1.Font = New System.Drawing.Font("Webdings", 14.25!)
        Me.Sol1.ForeColor = System.Drawing.Color.Salmon
        Me.Sol1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Sol1.Location = New System.Drawing.Point(80, 107)
        Me.Sol1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sol1.Name = "Sol1"
        Me.Sol1.Size = New System.Drawing.Size(29, 24)
        Me.Sol1.TabIndex = 115
        Me.Sol1.Text = "¦"
        Me.Sol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Speed1
        '
        Me.Speed1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Speed1.BackColor = System.Drawing.Color.Black
        Me.Speed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Speed1.ForeColor = System.Drawing.Color.Salmon
        Me.Speed1.Location = New System.Drawing.Point(30, 148)
        Me.Speed1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Speed1.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.Speed1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Speed1.Name = "Speed1"
        Me.Speed1.Size = New System.Drawing.Size(70, 31)
        Me.Speed1.TabIndex = 116
        Me.Speed1.TabStop = False
        Me.Speed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Speed1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Speaker2
        '
        Me.Speaker2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Speaker2.AutoSize = True
        Me.Speaker2.BackColor = System.Drawing.Color.Black
        Me.Speaker2.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Speaker2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Speaker2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Speaker2.Location = New System.Drawing.Point(700, 27)
        Me.Speaker2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Speaker2.Name = "Speaker2"
        Me.Speaker2.Size = New System.Drawing.Size(20, 24)
        Me.Speaker2.TabIndex = 121
        Me.Speaker2.Text = "W"
        Me.Speaker2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rpt2
        '
        Me.Rpt2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rpt2.AutoSize = True
        Me.Rpt2.BackColor = System.Drawing.Color.Black
        Me.Rpt2.Font = New System.Drawing.Font("Webdings", 14.25!)
        Me.Rpt2.ForeColor = System.Drawing.Color.Lime
        Me.Rpt2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Rpt2.Location = New System.Drawing.Point(691, 68)
        Me.Rpt2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Rpt2.Name = "Rpt2"
        Me.Rpt2.Size = New System.Drawing.Size(29, 24)
        Me.Rpt2.TabIndex = 124
        Me.Rpt2.Text = "q"
        Me.Rpt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'One2
        '
        Me.One2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.One2.AutoSize = True
        Me.One2.BackColor = System.Drawing.Color.Black
        Me.One2.Font = New System.Drawing.Font("Wingdings 2", 18.0!)
        Me.One2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.One2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.One2.Location = New System.Drawing.Point(731, 70)
        Me.One2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.One2.Name = "One2"
        Me.One2.Size = New System.Drawing.Size(33, 25)
        Me.One2.TabIndex = 125
        Me.One2.Text = "u"
        Me.One2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VolCtrl2
        '
        Me.VolCtrl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VolCtrl2.LargeChange = 1
        Me.VolCtrl2.Location = New System.Drawing.Point(775, 26)
        Me.VolCtrl2.Name = "VolCtrl2"
        Me.VolCtrl2.Size = New System.Drawing.Size(16, 153)
        Me.VolCtrl2.TabIndex = 126
        Me.VolCtrl2.Value = 50
        '
        'Speed2
        '
        Me.Speed2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Speed2.BackColor = System.Drawing.Color.Black
        Me.Speed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Speed2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Speed2.Location = New System.Drawing.Point(703, 148)
        Me.Speed2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Speed2.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.Speed2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Speed2.Name = "Speed2"
        Me.Speed2.Size = New System.Drawing.Size(70, 31)
        Me.Speed2.TabIndex = 127
        Me.Speed2.TabStop = False
        Me.Speed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Speed2.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Lst2
        '
        Me.Lst2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lst2.AutoSize = True
        Me.Lst2.BackColor = System.Drawing.Color.Black
        Me.Lst2.Font = New System.Drawing.Font("Wingdings 2", 18.0!)
        Me.Lst2.ForeColor = System.Drawing.Color.Lime
        Me.Lst2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lst2.Location = New System.Drawing.Point(687, 107)
        Me.Lst2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lst2.Name = "Lst2"
        Me.Lst2.Size = New System.Drawing.Size(33, 25)
        Me.Lst2.TabIndex = 128
        Me.Lst2.Text = "1"
        Me.Lst2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sol2
        '
        Me.Sol2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sol2.AutoSize = True
        Me.Sol2.BackColor = System.Drawing.Color.Black
        Me.Sol2.Font = New System.Drawing.Font("Webdings", 14.25!)
        Me.Sol2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Sol2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Sol2.Location = New System.Drawing.Point(732, 109)
        Me.Sol2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sol2.Name = "Sol2"
        Me.Sol2.Size = New System.Drawing.Size(29, 24)
        Me.Sol2.TabIndex = 129
        Me.Sol2.Text = "¦"
        Me.Sol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Poz2
        '
        Me.Poz2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Poz2.AutoSize = True
        Me.Poz2.BackColor = System.Drawing.Color.Black
        Me.Poz2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Poz2.Font = New System.Drawing.Font("Webdings", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Poz2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Poz2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Poz2.Location = New System.Drawing.Point(461, 209)
        Me.Poz2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Poz2.Name = "Poz2"
        Me.Poz2.Size = New System.Drawing.Size(17, 16)
        Me.Poz2.TabIndex = 131
        Me.Poz2.Text = "n"
        Me.Poz2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Poz1
        '
        Me.Poz1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Poz1.AutoSize = True
        Me.Poz1.BackColor = System.Drawing.Color.Black
        Me.Poz1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Poz1.Font = New System.Drawing.Font("Webdings", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Poz1.ForeColor = System.Drawing.Color.Salmon
        Me.Poz1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Poz1.Location = New System.Drawing.Point(42, 207)
        Me.Poz1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Poz1.Name = "Poz1"
        Me.Poz1.Size = New System.Drawing.Size(17, 16)
        Me.Poz1.TabIndex = 132
        Me.Poz1.Text = "n"
        Me.Poz1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NowTime
        '
        Me.NowTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NowTime.AutoSize = True
        Me.NowTime.BackColor = System.Drawing.Color.Black
        Me.NowTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.NowTime.ForeColor = System.Drawing.Color.Lime
        Me.NowTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NowTime.Location = New System.Drawing.Point(314, 27)
        Me.NowTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NowTime.Name = "NowTime"
        Me.NowTime.Size = New System.Drawing.Size(164, 42)
        Me.NowTime.TabIndex = 133
        Me.NowTime.Text = "00:00:00"
        Me.NowTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BackCtrl
        '
        Me.BackCtrl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BackCtrl.BackColor = System.Drawing.Color.Black
        Me.BackCtrl.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BackCtrl.ForeColor = System.Drawing.Color.Cyan
        Me.BackCtrl.Location = New System.Drawing.Point(300, 83)
        Me.BackCtrl.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BackCtrl.Maximum = New Decimal(New Integer() {3599, 0, 0, 0})
        Me.BackCtrl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BackCtrl.Name = "BackCtrl"
        Me.BackCtrl.Size = New System.Drawing.Size(19, 38)
        Me.BackCtrl.TabIndex = 134
        Me.BackCtrl.TabStop = False
        Me.BackCtrl.Value = New Decimal(New Integer() {80, 0, 0, 0})
        Me.BackCtrl.Visible = False
        '
        'BckTime
        '
        Me.BckTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BckTime.AutoSize = True
        Me.BckTime.BackColor = System.Drawing.Color.Black
        Me.BckTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.BckTime.ForeColor = System.Drawing.Color.Aqua
        Me.BckTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BckTime.Location = New System.Drawing.Point(349, 83)
        Me.BckTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BckTime.Name = "BckTime"
        Me.BckTime.Size = New System.Drawing.Size(112, 42)
        Me.BckTime.TabIndex = 135
        Me.BckTime.Text = "01:20"
        Me.BckTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BckTime.Visible = False
        '
        'WaitCtrl
        '
        Me.WaitCtrl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WaitCtrl.BackColor = System.Drawing.Color.Black
        Me.WaitCtrl.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold)
        Me.WaitCtrl.ForeColor = System.Drawing.Color.Yellow
        Me.WaitCtrl.Location = New System.Drawing.Point(478, 87)
        Me.WaitCtrl.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.WaitCtrl.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.WaitCtrl.Name = "WaitCtrl"
        Me.WaitCtrl.Size = New System.Drawing.Size(56, 38)
        Me.WaitCtrl.TabIndex = 136
        Me.WaitCtrl.TabStop = False
        Me.WaitCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WaitCtrl.Value = New Decimal(New Integer() {30, 0, 0, 0})
        Me.WaitCtrl.Visible = False
        '
        'SysTime
        '
        Me.SysTime.AutoSize = True
        Me.SysTime.BackColor = System.Drawing.Color.Black
        Me.SysTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SysTime.ForeColor = System.Drawing.Color.Plum
        Me.SysTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SysTime.Location = New System.Drawing.Point(340, 151)
        Me.SysTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SysTime.Name = "SysTime"
        Me.SysTime.Size = New System.Drawing.Size(120, 31)
        Me.SysTime.TabIndex = 137
        Me.SysTime.Text = "00:00:00"
        '
        'PlyTimer
        '
        Me.PlyTimer.Interval = 1000
        '
        'Pict2
        '
        Me.Pict2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pict2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pict2.Image = Global.DancePlay3.My.Resources.Resources.Arm00
        Me.Pict2.Location = New System.Drawing.Point(493, 27)
        Me.Pict2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Pict2.Name = "Pict2"
        Me.Pict2.Size = New System.Drawing.Size(87, 43)
        Me.Pict2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict2.TabIndex = 138
        Me.Pict2.TabStop = False
        '
        'Pict1
        '
        Me.Pict1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pict1.Image = Global.DancePlay3.My.Resources.Resources.Arm00
        Me.Pict1.Location = New System.Drawing.Point(179, 31)
        Me.Pict1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Pict1.Name = "Pict1"
        Me.Pict1.Size = New System.Drawing.Size(77, 39)
        Me.Pict1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict1.TabIndex = 139
        Me.Pict1.TabStop = False
        '
        'Pict0
        '
        Me.Pict0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pict0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pict0.Image = Global.DancePlay3.My.Resources.Resources.Dncrs
        Me.Pict0.Location = New System.Drawing.Point(356, 24)
        Me.Pict0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Pict0.Name = "Pict0"
        Me.Pict0.Size = New System.Drawing.Size(53, 46)
        Me.Pict0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict0.TabIndex = 140
        Me.Pict0.TabStop = False
        '
        'Bell
        '
        Me.Bell.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bell.Image = Global.DancePlay3.My.Resources.Resources.Bell
        Me.Bell.Location = New System.Drawing.Point(478, 145)
        Me.Bell.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Bell.Name = "Bell"
        Me.Bell.Size = New System.Drawing.Size(28, 31)
        Me.Bell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bell.TabIndex = 141
        Me.Bell.TabStop = False
        Me.Bell.Visible = False
        '
        'Paso
        '
        Me.Paso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Paso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paso.Image = Global.DancePlay3.My.Resources.Resources.Brake
        Me.Paso.Location = New System.Drawing.Point(300, 145)
        Me.Paso.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Paso.Name = "Paso"
        Me.Paso.Size = New System.Drawing.Size(25, 31)
        Me.Paso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Paso.TabIndex = 142
        Me.Paso.TabStop = False
        Me.Paso.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All|*.*|MP3|*.mp3"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Add Songs"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "PlayList|*.m3u"
        Me.SaveFileDialog1.ShowHelp = True
        Me.SaveFileDialog1.Title = "Save PlayList"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "PlayList|*.m3u"
        Me.OpenFileDialog2.InitialDirectory = "."
        Me.OpenFileDialog2.Multiselect = True
        Me.OpenFileDialog2.Title = "Add a PlayList"
        '
        'Box1
        '
        Me.Box1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Box1.BackColor = System.Drawing.Color.Black
        Me.Box1.ForeColor = System.Drawing.Color.White
        Me.Box1.FormattingEnabled = True
        Me.Box1.HorizontalScrollbar = True
        Me.Box1.Location = New System.Drawing.Point(4, 226)
        Me.Box1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(348, 212)
        Me.Box1.TabIndex = 1
        '
        'Edit1
        '
        Me.Edit1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Edit1.BackColor = System.Drawing.Color.White
        Me.Edit1.ForeColor = System.Drawing.Color.Black
        Me.Edit1.Location = New System.Drawing.Point(2, 173)
        Me.Edit1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Edit1.Name = "Edit1"
        Me.Edit1.Size = New System.Drawing.Size(288, 20)
        Me.Edit1.TabIndex = 143
        Me.Edit1.TabStop = False
        Me.Edit1.Text = "Edit1"
        Me.Edit1.Visible = False
        '
        'Edit2
        '
        Me.Edit2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Edit2.BackColor = System.Drawing.Color.White
        Me.Edit2.ForeColor = System.Drawing.Color.Black
        Me.Edit2.Location = New System.Drawing.Point(421, 173)
        Me.Edit2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Edit2.Name = "Edit2"
        Me.Edit2.Size = New System.Drawing.Size(288, 20)
        Me.Edit2.TabIndex = 144
        Me.Edit2.TabStop = False
        Me.Edit2.Text = "Edit2"
        Me.Edit2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DancePlay3.My.Resources.Resources.DPlayer
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Edit2)
        Me.Controls.Add(Me.Edit1)
        Me.Controls.Add(Me.Paso)
        Me.Controls.Add(Me.Bell)
        Me.Controls.Add(Me.Pict0)
        Me.Controls.Add(Me.Pict1)
        Me.Controls.Add(Me.Pict2)
        Me.Controls.Add(Me.SysTime)
        Me.Controls.Add(Me.WaitCtrl)
        Me.Controls.Add(Me.BckTime)
        Me.Controls.Add(Me.BackCtrl)
        Me.Controls.Add(Me.NowTime)
        Me.Controls.Add(Me.Poz1)
        Me.Controls.Add(Me.Poz2)
        Me.Controls.Add(Me.Sol2)
        Me.Controls.Add(Me.Lst2)
        Me.Controls.Add(Me.Speed2)
        Me.Controls.Add(Me.One2)
        Me.Controls.Add(Me.Rpt2)
        Me.Controls.Add(Me.Speaker2)
        Me.Controls.Add(Me.Speed1)
        Me.Controls.Add(Me.Sol1)
        Me.Controls.Add(Me.Lst1)
        Me.Controls.Add(Me.One1)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.Speaker1)
        Me.Controls.Add(Me.VolCtrl1)
        Me.Controls.Add(Me.TimTxt2)
        Me.Controls.Add(Me.NowTxt2)
        Me.Controls.Add(Me.TimTxt1)
        Me.Controls.Add(Me.NowTxt1)
        Me.Controls.Add(Me.TipTxt2)
        Me.Controls.Add(Me.BoxTxt2)
        Me.Controls.Add(Me.TipTxt1)
        Me.Controls.Add(Me.BoxTxt1)
        Me.Controls.Add(Me.Box22)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.Box11)
        Me.Controls.Add(Me.Box1)
        Me.Controls.Add(Me.GoWeb)
        Me.Controls.Add(Me.VolCtrl2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Dance Play"
        CType(Me.Speed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Speed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoWeb As Label
    Friend WithEvents Box11 As ListBox
    Friend WithEvents Box2 As ListBox
    Friend WithEvents Box22 As ListBox
    Friend WithEvents BoxTxt1 As TextBox
    Friend WithEvents TipTxt1 As TextBox
    Friend WithEvents BoxTxt2 As TextBox
    Friend WithEvents TipTxt2 As TextBox
    Friend WithEvents TimTxt2 As TextBox
    Friend WithEvents NowTxt2 As TextBox
    Friend WithEvents TimTxt1 As TextBox
    Friend WithEvents NowTxt1 As TextBox
    Friend WithEvents VolCtrl1 As VScrollBar
    Friend WithEvents Speaker1 As Label
    Friend WithEvents Rpt1 As Label
    Friend WithEvents One1 As Label
    Friend WithEvents Lst1 As Label
    Friend WithEvents Sol1 As Label
    Friend WithEvents Speed1 As NumericUpDown
    Friend WithEvents Speaker2 As Label
    Friend WithEvents Rpt2 As Label
    Friend WithEvents One2 As Label
    Friend WithEvents VolCtrl2 As VScrollBar
    Friend WithEvents Speed2 As NumericUpDown
    Friend WithEvents Lst2 As Label
    Friend WithEvents Sol2 As Label
    Friend WithEvents Poz2 As Label
    Friend WithEvents Poz1 As Label
    Friend WithEvents NowTime As Label
    Friend WithEvents BackCtrl As NumericUpDown
    Friend WithEvents BckTime As Label
    Friend WithEvents WaitCtrl As NumericUpDown
    Friend WithEvents SysTime As Label
    Friend WithEvents PlyTimer As Timer
    Friend WithEvents Pict2 As PictureBox
    Friend WithEvents Pict1 As PictureBox
    Friend WithEvents Pict0 As PictureBox
    Friend WithEvents Bell As PictureBox
    Friend WithEvents Paso As PictureBox
    Friend WithEvents FolderOpen As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Box1 As ListBox
    Friend WithEvents Edit1 As TextBox
    Friend WithEvents Edit2 As TextBox
End Class
