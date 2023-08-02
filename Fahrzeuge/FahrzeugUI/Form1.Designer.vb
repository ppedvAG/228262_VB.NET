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
        Me.newButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.showSelectedButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.saveXMLButton = New System.Windows.Forms.Button()
        Me.loadXMLButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.fahrzeugeDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.modellTextBox = New System.Windows.Forms.TextBox()
        Me.herstellerTextBox = New System.Windows.Forms.TextBox()
        Me.farbeTextBox = New System.Windows.Forms.TextBox()
        Me.maxGeschwindigkeitNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.baujahrDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.fahrzeugeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.maxGeschwindigkeitNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newButton
        '
        Me.newButton.AutoSize = True
        Me.newButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.newButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newButton.Location = New System.Drawing.Point(117, 7)
        Me.newButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(233, 39)
        Me.newButton.TabIndex = 0
        Me.newButton.Text = "🚗 Neues Fahrzeug"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buttons:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.YellowGreen
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.newButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.showSelectedButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.deleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.saveButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.loadButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.saveXMLButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.loadXMLButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1590, 106)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'showSelectedButton
        '
        Me.showSelectedButton.AutoSize = True
        Me.showSelectedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.showSelectedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showSelectedButton.Location = New System.Drawing.Point(362, 7)
        Me.showSelectedButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.showSelectedButton.Name = "showSelectedButton"
        Me.showSelectedButton.Size = New System.Drawing.Size(321, 39)
        Me.showSelectedButton.TabIndex = 2
        Me.showSelectedButton.Text = "📯 Show selected Fahrzeug"
        Me.showSelectedButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.AutoSize = True
        Me.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(695, 7)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(146, 39)
        Me.deleteButton.TabIndex = 3
        Me.deleteButton.Text = "❌ Löschen"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.AutoSize = True
        Me.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(853, 7)
        Me.saveButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(165, 39)
        Me.saveButton.TabIndex = 4
        Me.saveButton.Text = "💾 Speichern"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'loadButton
        '
        Me.loadButton.AutoSize = True
        Me.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.loadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadButton.Location = New System.Drawing.Point(1030, 7)
        Me.loadButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(122, 39)
        Me.loadButton.TabIndex = 5
        Me.loadButton.Text = "📂 Laden"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'saveXMLButton
        '
        Me.saveXMLButton.AutoSize = True
        Me.saveXMLButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveXMLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveXMLButton.Location = New System.Drawing.Point(1164, 7)
        Me.saveXMLButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.saveXMLButton.Name = "saveXMLButton"
        Me.saveXMLButton.Size = New System.Drawing.Size(237, 39)
        Me.saveXMLButton.TabIndex = 6
        Me.saveXMLButton.Text = "💾 Speichern (XML)"
        Me.saveXMLButton.UseVisualStyleBackColor = True
        '
        'loadXMLButton
        '
        Me.loadXMLButton.AutoSize = True
        Me.loadXMLButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.loadXMLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadXMLButton.Location = New System.Drawing.Point(6, 60)
        Me.loadXMLButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.loadXMLButton.Name = "loadXMLButton"
        Me.loadXMLButton.Size = New System.Drawing.Size(194, 39)
        Me.loadXMLButton.TabIndex = 7
        Me.loadXMLButton.Text = "📂 Laden (XML)"
        Me.loadXMLButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 106)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.fahrzeugeDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1590, 566)
        Me.SplitContainer1.SplitterDistance = 849
        Me.SplitContainer1.TabIndex = 3
        '
        'fahrzeugeDataGridView
        '
        Me.fahrzeugeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fahrzeugeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fahrzeugeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.fahrzeugeDataGridView.Name = "fahrzeugeDataGridView"
        Me.fahrzeugeDataGridView.RowHeadersWidth = 82
        Me.fahrzeugeDataGridView.Size = New System.Drawing.Size(849, 566)
        Me.fahrzeugeDataGridView.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.modellTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.herstellerTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.farbeTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.maxGeschwindigkeitNumericUpDown, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.baujahrDateTimePicker, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(737, 566)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Modell"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hersteller"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Farbe"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Max. Geschwinigkeit"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 32)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Baujahr"
        '
        'modellTextBox
        '
        Me.modellTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.modellTextBox.Location = New System.Drawing.Point(240, 3)
        Me.modellTextBox.Name = "modellTextBox"
        Me.modellTextBox.Size = New System.Drawing.Size(494, 39)
        Me.modellTextBox.TabIndex = 5
        '
        'herstellerTextBox
        '
        Me.herstellerTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.herstellerTextBox.Location = New System.Drawing.Point(240, 48)
        Me.herstellerTextBox.Name = "herstellerTextBox"
        Me.herstellerTextBox.Size = New System.Drawing.Size(494, 39)
        Me.herstellerTextBox.TabIndex = 6
        '
        'farbeTextBox
        '
        Me.farbeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.farbeTextBox.Location = New System.Drawing.Point(240, 93)
        Me.farbeTextBox.Name = "farbeTextBox"
        Me.farbeTextBox.Size = New System.Drawing.Size(494, 39)
        Me.farbeTextBox.TabIndex = 7
        '
        'maxGeschwindigkeitNumericUpDown
        '
        Me.maxGeschwindigkeitNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxGeschwindigkeitNumericUpDown.Location = New System.Drawing.Point(240, 138)
        Me.maxGeschwindigkeitNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.maxGeschwindigkeitNumericUpDown.Name = "maxGeschwindigkeitNumericUpDown"
        Me.maxGeschwindigkeitNumericUpDown.Size = New System.Drawing.Size(494, 39)
        Me.maxGeschwindigkeitNumericUpDown.TabIndex = 8
        '
        'baujahrDateTimePicker
        '
        Me.baujahrDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.baujahrDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.baujahrDateTimePicker.Location = New System.Drawing.Point(240, 183)
        Me.baujahrDateTimePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.baujahrDateTimePicker.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.baujahrDateTimePicker.Name = "baujahrDateTimePicker"
        Me.baujahrDateTimePicker.Size = New System.Drawing.Size(494, 39)
        Me.baujahrDateTimePicker.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Textdatei|*.txt|Alles Dateien|*.*"
        Me.OpenFileDialog1.Title = "Tolle Datei"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(1590, 672)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.fahrzeugeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.maxGeschwindigkeitNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents showSelectedButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents fahrzeugeDataGridView As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents modellTextBox As TextBox
    Friend WithEvents herstellerTextBox As TextBox
    Friend WithEvents farbeTextBox As TextBox
    Friend WithEvents maxGeschwindigkeitNumericUpDown As NumericUpDown
    Friend WithEvents baujahrDateTimePicker As DateTimePicker
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents loadButton As Button
    Friend WithEvents saveXMLButton As Button
    Friend WithEvents loadXMLButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
