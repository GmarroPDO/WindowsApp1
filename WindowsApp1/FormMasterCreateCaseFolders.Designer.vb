<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CreateMasterCaseFolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CreateMasterCaseFolder))
        Me.RadioButton_ADO = New System.Windows.Forms.RadioButton()
        Me.RadioButton_PDO = New System.Windows.Forms.RadioButton()
        Me.TextBox_DocketNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_ClientsLastName = New System.Windows.Forms.TextBox()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Button_Apply = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.CaseTypeGB = New System.Windows.Forms.GroupBox()
        Me.rbCTMentalHealth = New System.Windows.Forms.RadioButton()
        Me.rbCTJuvenile = New System.Windows.Forms.RadioButton()
        Me.rbCTIndictments = New System.Windows.Forms.RadioButton()
        Me.rbCTCriminal = New System.Windows.Forms.RadioButton()
        Me.YearCB = New System.Windows.Forms.ComboBox()
        Me.GBYear = New System.Windows.Forms.GroupBox()
        Me.rbCTTraffic = New System.Windows.Forms.RadioButton()
        Me.rbCTViolations = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.CaseTypeGB.SuspendLayout()
        Me.GBYear.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton_ADO
        '
        Me.RadioButton_ADO.AutoSize = True
        Me.RadioButton_ADO.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_ADO.Name = "RadioButton_ADO"
        Me.RadioButton_ADO.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_ADO.TabIndex = 0
        Me.RadioButton_ADO.Text = "ADO"
        Me.RadioButton_ADO.UseVisualStyleBackColor = True
        '
        'RadioButton_PDO
        '
        Me.RadioButton_PDO.AutoSize = True
        Me.RadioButton_PDO.Checked = True
        Me.RadioButton_PDO.Location = New System.Drawing.Point(54, 19)
        Me.RadioButton_PDO.Name = "RadioButton_PDO"
        Me.RadioButton_PDO.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_PDO.TabIndex = 1
        Me.RadioButton_PDO.TabStop = True
        Me.RadioButton_PDO.Text = "PDO"
        Me.RadioButton_PDO.UseVisualStyleBackColor = True
        '
        'TextBox_DocketNumber
        '
        Me.TextBox_DocketNumber.Location = New System.Drawing.Point(18, 19)
        Me.TextBox_DocketNumber.Name = "TextBox_DocketNumber"
        Me.TextBox_DocketNumber.Size = New System.Drawing.Size(199, 20)
        Me.TextBox_DocketNumber.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_PDO)
        Me.GroupBox1.Controls.Add(Me.RadioButton_ADO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 48)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_DocketNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 56)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Docket Number"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox_ClientsLastName)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 56)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Client's Last Name"
        '
        'TextBox_ClientsLastName
        '
        Me.TextBox_ClientsLastName.Location = New System.Drawing.Point(18, 19)
        Me.TextBox_ClientsLastName.Name = "TextBox_ClientsLastName"
        Me.TextBox_ClientsLastName.Size = New System.Drawing.Size(199, 20)
        Me.TextBox_ClientsLastName.TabIndex = 2
        '
        'Button_OK
        '
        Me.Button_OK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button_OK.Location = New System.Drawing.Point(22, 299)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(48, 37)
        Me.Button_OK.TabIndex = 7
        Me.Button_OK.Text = "OK"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Button_Apply
        '
        Me.Button_Apply.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button_Apply.Location = New System.Drawing.Point(76, 299)
        Me.Button_Apply.Name = "Button_Apply"
        Me.Button_Apply.Size = New System.Drawing.Size(48, 37)
        Me.Button_Apply.TabIndex = 8
        Me.Button_Apply.Text = "Apply"
        Me.Button_Apply.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button_Cancel.Location = New System.Drawing.Point(184, 299)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(48, 37)
        Me.Button_Cancel.TabIndex = 9
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Reset
        '
        Me.Button_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Reset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button_Reset.Location = New System.Drawing.Point(130, 299)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(48, 37)
        Me.Button_Reset.TabIndex = 10
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'CaseTypeGB
        '
        Me.CaseTypeGB.Controls.Add(Me.rbCTViolations)
        Me.CaseTypeGB.Controls.Add(Me.rbCTTraffic)
        Me.CaseTypeGB.Controls.Add(Me.rbCTMentalHealth)
        Me.CaseTypeGB.Controls.Add(Me.rbCTJuvenile)
        Me.CaseTypeGB.Controls.Add(Me.rbCTIndictments)
        Me.CaseTypeGB.Controls.Add(Me.rbCTCriminal)
        Me.CaseTypeGB.Location = New System.Drawing.Point(139, 12)
        Me.CaseTypeGB.Name = "CaseTypeGB"
        Me.CaseTypeGB.Size = New System.Drawing.Size(107, 148)
        Me.CaseTypeGB.TabIndex = 11
        Me.CaseTypeGB.TabStop = False
        Me.CaseTypeGB.Text = "Case Type"
        '
        'rbCTMentalHealth
        '
        Me.rbCTMentalHealth.AutoSize = True
        Me.rbCTMentalHealth.Location = New System.Drawing.Point(11, 72)
        Me.rbCTMentalHealth.Name = "rbCTMentalHealth"
        Me.rbCTMentalHealth.Size = New System.Drawing.Size(91, 17)
        Me.rbCTMentalHealth.TabIndex = 3
        Me.rbCTMentalHealth.Text = "Mental Health"
        Me.rbCTMentalHealth.UseVisualStyleBackColor = True
        '
        'rbCTJuvenile
        '
        Me.rbCTJuvenile.AutoSize = True
        Me.rbCTJuvenile.Location = New System.Drawing.Point(11, 54)
        Me.rbCTJuvenile.Name = "rbCTJuvenile"
        Me.rbCTJuvenile.Size = New System.Drawing.Size(64, 17)
        Me.rbCTJuvenile.TabIndex = 2
        Me.rbCTJuvenile.TabStop = True
        Me.rbCTJuvenile.Text = "Juvenile"
        Me.rbCTJuvenile.UseVisualStyleBackColor = True
        '
        'rbCTIndictments
        '
        Me.rbCTIndictments.AutoSize = True
        Me.rbCTIndictments.Location = New System.Drawing.Point(11, 36)
        Me.rbCTIndictments.Name = "rbCTIndictments"
        Me.rbCTIndictments.Size = New System.Drawing.Size(79, 17)
        Me.rbCTIndictments.TabIndex = 1
        Me.rbCTIndictments.Text = "Indictments"
        Me.rbCTIndictments.UseVisualStyleBackColor = True
        '
        'rbCTCriminal
        '
        Me.rbCTCriminal.AutoSize = True
        Me.rbCTCriminal.Checked = True
        Me.rbCTCriminal.Location = New System.Drawing.Point(11, 18)
        Me.rbCTCriminal.Name = "rbCTCriminal"
        Me.rbCTCriminal.Size = New System.Drawing.Size(61, 17)
        Me.rbCTCriminal.TabIndex = 0
        Me.rbCTCriminal.TabStop = True
        Me.rbCTCriminal.Text = "Criminal"
        Me.rbCTCriminal.UseVisualStyleBackColor = True
        '
        'YearCB
        '
        Me.YearCB.AllowDrop = True
        Me.YearCB.DisplayMember = "2019"
        Me.YearCB.FormatString = "d"
        Me.YearCB.FormattingEnabled = True
        Me.YearCB.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022"})
        Me.YearCB.Location = New System.Drawing.Point(18, 15)
        Me.YearCB.Name = "YearCB"
        Me.YearCB.Size = New System.Drawing.Size(79, 21)
        Me.YearCB.Sorted = True
        Me.YearCB.TabIndex = 12
        Me.YearCB.ValueMember = "2019"
        '
        'GBYear
        '
        Me.GBYear.Controls.Add(Me.YearCB)
        Me.GBYear.Location = New System.Drawing.Point(12, 84)
        Me.GBYear.Name = "GBYear"
        Me.GBYear.Size = New System.Drawing.Size(112, 48)
        Me.GBYear.TabIndex = 13
        Me.GBYear.TabStop = False
        Me.GBYear.Text = "Year"
        '
        'rbCTTraffic
        '
        Me.rbCTTraffic.AutoSize = True
        Me.rbCTTraffic.Location = New System.Drawing.Point(11, 95)
        Me.rbCTTraffic.Name = "rbCTTraffic"
        Me.rbCTTraffic.Size = New System.Drawing.Size(55, 17)
        Me.rbCTTraffic.TabIndex = 4
        Me.rbCTTraffic.Text = "Traffic"
        Me.rbCTTraffic.UseVisualStyleBackColor = True
        '
        'rbCTViolations
        '
        Me.rbCTViolations.AutoSize = True
        Me.rbCTViolations.Location = New System.Drawing.Point(11, 118)
        Me.rbCTViolations.Name = "rbCTViolations"
        Me.rbCTViolations.Size = New System.Drawing.Size(70, 17)
        Me.rbCTViolations.TabIndex = 5
        Me.rbCTViolations.Text = "Violations"
        Me.rbCTViolations.UseVisualStyleBackColor = True
        '
        'Form_CreateMasterCaseFolder
        '
        Me.AcceptButton = Me.Button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(265, 354)
        Me.Controls.Add(Me.GBYear)
        Me.Controls.Add(Me.CaseTypeGB)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Apply)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_CreateMasterCaseFolder"
        Me.Text = "MCF Creation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.CaseTypeGB.ResumeLayout(False)
        Me.CaseTypeGB.PerformLayout()
        Me.GBYear.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadioButton_ADO As RadioButton
    Friend WithEvents RadioButton_PDO As RadioButton
    Friend WithEvents TextBox_DocketNumber As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox_ClientsLastName As TextBox
    Friend WithEvents Button_OK As Button
    Friend WithEvents Button_Apply As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Reset As Button
    Friend WithEvents CaseTypeGB As GroupBox
    Friend WithEvents rbCTMentalHealth As RadioButton
    Friend WithEvents rbCTJuvenile As RadioButton
    Friend WithEvents rbCTIndictments As RadioButton
    Friend WithEvents rbCTCriminal As RadioButton
    Friend WithEvents YearCB As ComboBox
    Friend WithEvents GBYear As GroupBox
    Friend WithEvents rbCTViolations As RadioButton
    Friend WithEvents rbCTTraffic As RadioButton
End Class
