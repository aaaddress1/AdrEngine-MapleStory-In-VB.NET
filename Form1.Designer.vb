<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArrayOfByteInputTb = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SkillIdInputTb = New System.Windows.Forms.TextBox()
        Me.SearchForSkill = New System.Windows.Forms.Button()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MsInfo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.AttackMs = New System.Windows.Forms.ToolStripButton()
        Me.KillMs = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListAddress = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ArrayOfByteInputTb)
        Me.GroupBox1.Controls.Add(Me.Search)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 40)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "極速更新"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "AOB"
        '
        'ArrayOfByteInputTb
        '
        Me.ArrayOfByteInputTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArrayOfByteInputTb.Location = New System.Drawing.Point(53, 12)
        Me.ArrayOfByteInputTb.Name = "ArrayOfByteInputTb"
        Me.ArrayOfByteInputTb.Size = New System.Drawing.Size(182, 22)
        Me.ArrayOfByteInputTb.TabIndex = 7
        Me.ArrayOfByteInputTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(241, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(54, 22)
        Me.Search.TabIndex = 5
        Me.Search.Text = "&Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Status.ForeColor = System.Drawing.Color.MediumBlue
        Me.Status.Location = New System.Drawing.Point(0, 279)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(411, 12)
        Me.Status.TabIndex = 8
        Me.Status.Text = "就緒."
        Me.Status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.SkillIdInputTb)
        Me.GroupBox2.Controls.Add(Me.SearchForSkill)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 40)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "技能關鍵位置速爆"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "技能ID"
        '
        'SkillIdInputTb
        '
        Me.SkillIdInputTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SkillIdInputTb.Location = New System.Drawing.Point(53, 12)
        Me.SkillIdInputTb.Name = "SkillIdInputTb"
        Me.SkillIdInputTb.Size = New System.Drawing.Size(182, 22)
        Me.SkillIdInputTb.TabIndex = 7
        Me.SkillIdInputTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SearchForSkill
        '
        Me.SearchForSkill.Location = New System.Drawing.Point(241, 12)
        Me.SearchForSkill.Name = "SearchForSkill"
        Me.SearchForSkill.Size = New System.Drawing.Size(54, 22)
        Me.SearchForSkill.TabIndex = 5
        Me.SearchForSkill.Text = "&Search"
        Me.SearchForSkill.UseVisualStyleBackColor = True
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsInfo, Me.ToolStripSeparator1, Me.ProgressBar, Me.AttackMs, Me.KillMs})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 162)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(411, 25)
        Me.ToolStrip.TabIndex = 11
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'MsInfo
        '
        Me.MsInfo.Image = CType(resources.GetObject("MsInfo.Image"), System.Drawing.Image)
        Me.MsInfo.Name = "MsInfo"
        Me.MsInfo.Size = New System.Drawing.Size(75, 22)
        Me.MsInfo.Text = "還未捕捉."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ProgressBar
        '
        Me.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(150, 22)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'AttackMs
        '
        Me.AttackMs.Image = CType(resources.GetObject("AttackMs.Image"), System.Drawing.Image)
        Me.AttackMs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AttackMs.Name = "AttackMs"
        Me.AttackMs.Size = New System.Drawing.Size(69, 22)
        Me.AttackMs.Text = "攻擊Ms"
        '
        'KillMs
        '
        Me.KillMs.Image = CType(resources.GetObject("KillMs.Image"), System.Drawing.Image)
        Me.KillMs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KillMs.Name = "KillMs"
        Me.KillMs.Size = New System.Drawing.Size(69, 22)
        Me.KillMs.Text = "關閉Ms"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ListAddress)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(312, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 92)
        Me.Panel1.TabIndex = 12
        '
        'ListAddress
        '
        Me.ListAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListAddress.FormattingEnabled = True
        Me.ListAddress.ItemHeight = 12
        Me.ListAddress.Location = New System.Drawing.Point(0, 12)
        Me.ListAddress.Name = "ListAddress"
        Me.ListAddress.Size = New System.Drawing.Size(99, 80)
        Me.ListAddress.Sorted = True
        Me.ListAddress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "地址列表"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 291)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adr Engine Ver 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArrayOfByteInputTb As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SkillIdInputTb As System.Windows.Forms.TextBox
    Friend WithEvents SearchForSkill As System.Windows.Forms.Button
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MsInfo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AttackMs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListAddress As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KillMs As System.Windows.Forms.ToolStripButton

End Class
