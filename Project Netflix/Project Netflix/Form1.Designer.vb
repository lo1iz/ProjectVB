<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Netflix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Netflix))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBoxRT = New System.Windows.Forms.TextBox()
        Me.Runtime = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ComboBoxRate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGenre = New System.Windows.Forms.ComboBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.Rate = New System.Windows.Forms.Label()
        Me.Genre = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.Label()
        Me.Banner = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.ItemSize = New System.Drawing.Size(50, 25)
        Me.TabControl1.Location = New System.Drawing.Point(38, 111)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(549, 395)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(541, 362)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Introduction"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 264)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(116, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมวิเคราะห์ข้อมูลเพื่อตัดสินใจ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ในการสร้างภาพยนตร์บน Netflix"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.AutoScrollMinSize = New System.Drawing.Size(0, 750)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(541, 362)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Visaulization"
        '
        'Label8
        '
        Me.Label8.Image = Global.Project_Netflix.My.Resources.Resources.runtime
        Me.Label8.Location = New System.Drawing.Point(7, 749)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(506, 276)
        Me.Label8.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(62, 707)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(387, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ตัวอย่างข้อมูลจำนวนภาพยนตร์แยกตามความยาว"
        '
        'Label6
        '
        Me.Label6.Image = Global.Project_Netflix.My.Resources.Resources.ratedchart
        Me.Label6.Location = New System.Drawing.Point(7, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(506, 276)
        Me.Label6.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(105, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ตัวอย่างข้อมูลจำนวนภาพยนตร์แยกตามเรท"
        '
        'Label4
        '
        Me.Label4.Image = Global.Project_Netflix.My.Resources.Resources.movie
        Me.Label4.Location = New System.Drawing.Point(7, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(506, 276)
        Me.Label4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(71, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ตัวอย่างข้อมูลจำนวนภาพยนตร์แยกตามประเภท"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBoxRT)
        Me.TabPage3.Controls.Add(Me.Runtime)
        Me.TabPage3.Controls.Add(Me.ButtonReset)
        Me.TabPage3.Controls.Add(Me.ButtonOK)
        Me.TabPage3.Controls.Add(Me.ComboBoxRate)
        Me.TabPage3.Controls.Add(Me.ComboBoxGenre)
        Me.TabPage3.Controls.Add(Me.ComboBoxType)
        Me.TabPage3.Controls.Add(Me.Rate)
        Me.TabPage3.Controls.Add(Me.Genre)
        Me.TabPage3.Controls.Add(Me.Type)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(541, 362)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Predict"
        '
        'TextBoxRT
        '
        Me.TextBoxRT.Enabled = False
        Me.TextBoxRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBoxRT.Location = New System.Drawing.Point(203, 225)
        Me.TextBoxRT.Name = "TextBoxRT"
        Me.TextBoxRT.Size = New System.Drawing.Size(233, 27)
        Me.TextBoxRT.TabIndex = 12
        '
        'Runtime
        '
        Me.Runtime.AutoSize = True
        Me.Runtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Runtime.Location = New System.Drawing.Point(69, 218)
        Me.Runtime.Name = "Runtime"
        Me.Runtime.Size = New System.Drawing.Size(102, 29)
        Me.Runtime.TabIndex = 11
        Me.Runtime.Text = "Runtime"
        '
        'ButtonReset
        '
        Me.ButtonReset.Enabled = False
        Me.ButtonReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonReset.Location = New System.Drawing.Point(294, 285)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(142, 57)
        Me.ButtonReset.TabIndex = 10
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Enabled = False
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ButtonOK.Location = New System.Drawing.Point(108, 285)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(142, 57)
        Me.ButtonOK.TabIndex = 9
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ComboBoxRate
        '
        Me.ComboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxRate.FormattingEnabled = True
        Me.ComboBoxRate.Items.AddRange(New Object() {"G", "PASSED", "PG", "PG-13", "R", "TV-14", "TV-G", "TV-MA", "TV-PG", "TV-Y", "TY-Y7"})
        Me.ComboBoxRate.Location = New System.Drawing.Point(203, 174)
        Me.ComboBoxRate.Name = "ComboBoxRate"
        Me.ComboBoxRate.Size = New System.Drawing.Size(233, 28)
        Me.ComboBoxRate.TabIndex = 8
        '
        'ComboBoxGenre
        '
        Me.ComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxGenre.FormattingEnabled = True
        Me.ComboBoxGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Musical", "Mystery", "Reality-TV", "Thriller"})
        Me.ComboBoxGenre.Location = New System.Drawing.Point(203, 123)
        Me.ComboBoxGenre.Name = "ComboBoxGenre"
        Me.ComboBoxGenre.Size = New System.Drawing.Size(233, 28)
        Me.ComboBoxGenre.TabIndex = 7
        '
        'ComboBoxType
        '
        Me.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Items.AddRange(New Object() {"Movie", "Series"})
        Me.ComboBoxType.Location = New System.Drawing.Point(203, 67)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(233, 28)
        Me.ComboBoxType.TabIndex = 6
        '
        'Rate
        '
        Me.Rate.AutoSize = True
        Me.Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Rate.Location = New System.Drawing.Point(108, 173)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(63, 29)
        Me.Rate.TabIndex = 2
        Me.Rate.Text = "Rate"
        '
        'Genre
        '
        Me.Genre.AutoSize = True
        Me.Genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Genre.Location = New System.Drawing.Point(91, 119)
        Me.Genre.Name = "Genre"
        Me.Genre.Size = New System.Drawing.Size(80, 29)
        Me.Genre.TabIndex = 1
        Me.Genre.Text = "Genre"
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Type.Location = New System.Drawing.Point(103, 62)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(68, 29)
        Me.Type.TabIndex = 0
        Me.Type.Text = "Type"
        '
        'Banner
        '
        Me.Banner.AutoSize = True
        Me.Banner.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!)
        Me.Banner.ForeColor = System.Drawing.Color.Red
        Me.Banner.Location = New System.Drawing.Point(144, 9)
        Me.Banner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Banner.Name = "Banner"
        Me.Banner.Size = New System.Drawing.Size(346, 85)
        Me.Banner.TabIndex = 1
        Me.Banner.Text = "NETFLIX"
        '
        'Netflix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(629, 545)
        Me.Controls.Add(Me.Banner)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Netflix"
        Me.Text = "Netflix"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Banner As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Rate As Label
    Friend WithEvents Genre As Label
    Friend WithEvents Type As Label
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ComboBoxRate As ComboBox
    Friend WithEvents ComboBoxGenre As ComboBox
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents Runtime As Label
    Friend WithEvents TextBoxRT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class