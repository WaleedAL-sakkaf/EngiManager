<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form0
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DaliyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New AL_Waleed.DatabaseDataSet
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.PartsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartsTableAdapter = New AL_Waleed.DatabaseDataSetTableAdapters.partsTableAdapter
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.DaliyTableAdapter = New AL_Waleed.DatabaseDataSetTableAdapters.daliyTableAdapter
        Me.الاسمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سعرالتركيبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اسمالقطعةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سعرالقطعةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.صافيالربحDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaliyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(252, 397)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(128, 20)
        Me.TextBox7.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(564, 250)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(223, 20)
        Me.DateTimePicker1.TabIndex = 59
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 4
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(642, 457)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 40)
        Me.Button6.TabIndex = 58
        Me.Button6.Text = "حذف الجهاز"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 4
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(734, 457)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 40)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "اضافة الجهاز"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.الاسمDataGridViewTextBoxColumn, Me.سعرالتركيبDataGridViewTextBoxColumn, Me.اسمالقطعةDataGridViewTextBoxColumn, Me.سعرالقطعةDataGridViewTextBoxColumn, Me.صافيالربحDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DaliyBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(484, 277)
        Me.DataGridView1.TabIndex = 56
        '
        'DaliyBindingSource
        '
        Me.DaliyBindingSource.DataMember = "daliy"
        Me.DaliyBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(564, 405)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(223, 20)
        Me.TextBox6.TabIndex = 52
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(564, 351)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(223, 20)
        Me.TextBox5.TabIndex = 51
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(564, 302)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(223, 20)
        Me.TextBox4.TabIndex = 53
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(564, 153)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(223, 20)
        Me.TextBox2.TabIndex = 54
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(564, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 20)
        Me.TextBox1.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(838, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "الخلل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(820, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "رقم الزبون"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(838, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 21)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "السعر"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(830, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 21)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "التاريخ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(820, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "نوع الجهاز"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(179, 421)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 21)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "سعر القطعة"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(386, 421)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 21)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "سعر التركيب"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(179, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 21)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "اسم القطعة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(830, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "الموديل"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(386, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 21)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "اسم الجوال "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(820, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "اسم الزبون"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 39)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "دخل المبيعات اليومي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bold Italic Art", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(557, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 39)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = " ادخال معلومات الجهاز"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 4
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(162, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 28)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "اضافة "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(218, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "00"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 4
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(549, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "طباعة"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"IPhone", "Samsung", "Redmi", "Huawi", "LT", "Spurt", "Ipad", "China"})
        Me.ComboBox1.Location = New System.Drawing.Point(564, 204)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 21)
        Me.ComboBox1.TabIndex = 65
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(468, 423)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(42, 20)
        Me.TextBox3.TabIndex = 66
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(469, 399)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 21)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "النسبه"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(252, 423)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(128, 20)
        Me.TextBox9.TabIndex = 61
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PartsBindingSource
        Me.ComboBox2.DisplayMember = "الاسم"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(52, 395)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 67
        '
        'PartsBindingSource
        '
        Me.PartsBindingSource.DataMember = "parts"
        Me.PartsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'PartsTableAdapter
        '
        Me.PartsTableAdapter.ClearBeforeFill = True
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(52, 423)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(121, 20)
        Me.TextBox10.TabIndex = 60
        '
        'DaliyTableAdapter
        '
        Me.DaliyTableAdapter.ClearBeforeFill = True
        '
        'الاسمDataGridViewTextBoxColumn
        '
        Me.الاسمDataGridViewTextBoxColumn.DataPropertyName = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.HeaderText = "الاسم"
        Me.الاسمDataGridViewTextBoxColumn.Name = "الاسمDataGridViewTextBoxColumn"
        '
        'سعرالتركيبDataGridViewTextBoxColumn
        '
        Me.سعرالتركيبDataGridViewTextBoxColumn.DataPropertyName = "سعر التركيب"
        DataGridViewCellStyle2.Format = "C0"
        Me.سعرالتركيبDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.سعرالتركيبDataGridViewTextBoxColumn.HeaderText = "سعر التركيب"
        Me.سعرالتركيبDataGridViewTextBoxColumn.Name = "سعرالتركيبDataGridViewTextBoxColumn"
        Me.سعرالتركيبDataGridViewTextBoxColumn.Width = 80
        '
        'اسمالقطعةDataGridViewTextBoxColumn
        '
        Me.اسمالقطعةDataGridViewTextBoxColumn.DataPropertyName = "اسم القطعة"
        Me.اسمالقطعةDataGridViewTextBoxColumn.HeaderText = "اسم القطعة"
        Me.اسمالقطعةDataGridViewTextBoxColumn.Name = "اسمالقطعةDataGridViewTextBoxColumn"
        '
        'سعرالقطعةDataGridViewTextBoxColumn
        '
        Me.سعرالقطعةDataGridViewTextBoxColumn.DataPropertyName = "سعر القطعة"
        DataGridViewCellStyle3.Format = "C0"
        Me.سعرالقطعةDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.سعرالقطعةDataGridViewTextBoxColumn.HeaderText = "سعر القطعة"
        Me.سعرالقطعةDataGridViewTextBoxColumn.Name = "سعرالقطعةDataGridViewTextBoxColumn"
        Me.سعرالقطعةDataGridViewTextBoxColumn.Width = 80
        '
        'صافيالربحDataGridViewTextBoxColumn
        '
        Me.صافيالربحDataGridViewTextBoxColumn.DataPropertyName = "صافي الربح"
        DataGridViewCellStyle4.Format = "C0"
        Me.صافيالربحDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.صافيالربحDataGridViewTextBoxColumn.HeaderText = "صافي الربح"
        Me.صافيالربحDataGridViewTextBoxColumn.Name = "صافيالربحDataGridViewTextBoxColumn"
        Me.صافيالربحDataGridViewTextBoxColumn.Width = 80
        '
        'Form0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 530)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form0"
        Me.Text = "Form0"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaliyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DatabaseDataSet As AL_Waleed.DatabaseDataSet
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PartsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartsTableAdapter As AL_Waleed.DatabaseDataSetTableAdapters.partsTableAdapter
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents DaliyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaliyTableAdapter As AL_Waleed.DatabaseDataSetTableAdapters.daliyTableAdapter
    Friend WithEvents الاسمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سعرالتركيبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اسمالقطعةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سعرالقطعةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents صافيالربحDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
