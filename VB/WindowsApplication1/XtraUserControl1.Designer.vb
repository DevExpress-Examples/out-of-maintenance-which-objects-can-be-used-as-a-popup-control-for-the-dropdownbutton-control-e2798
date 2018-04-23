Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraUserControl1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton5 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton6 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton7 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton8 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton9 = New DevExpress.XtraEditors.SimpleButton()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 3
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton9, 2, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton8, 1, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton7, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton6, 2, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton5, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton4, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton3, 2, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton2, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.simpleButton1, 0, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 3
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(255, 164)
			Me.tableLayoutPanel1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton1.Location = New System.Drawing.Point(3, 3)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(78, 48)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton2.Location = New System.Drawing.Point(87, 3)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(78, 48)
			Me.simpleButton2.TabIndex = 1
			Me.simpleButton2.Text = "simpleButton2"
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton3.Location = New System.Drawing.Point(171, 3)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(81, 48)
			Me.simpleButton3.TabIndex = 2
			Me.simpleButton3.Text = "simpleButton3"
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton4.Location = New System.Drawing.Point(3, 57)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(78, 48)
			Me.simpleButton4.TabIndex = 3
			Me.simpleButton4.Text = "simpleButton4"
			' 
			' simpleButton5
			' 
			Me.simpleButton5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton5.Location = New System.Drawing.Point(87, 57)
			Me.simpleButton5.Name = "simpleButton5"
			Me.simpleButton5.Size = New System.Drawing.Size(78, 48)
			Me.simpleButton5.TabIndex = 4
			Me.simpleButton5.Text = "simpleButton5"
			' 
			' simpleButton6
			' 
			Me.simpleButton6.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton6.Location = New System.Drawing.Point(171, 57)
			Me.simpleButton6.Name = "simpleButton6"
			Me.simpleButton6.Size = New System.Drawing.Size(81, 48)
			Me.simpleButton6.TabIndex = 5
			Me.simpleButton6.Text = "simpleButton6"
			' 
			' simpleButton7
			' 
			Me.simpleButton7.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton7.Location = New System.Drawing.Point(3, 111)
			Me.simpleButton7.Name = "simpleButton7"
			Me.simpleButton7.Size = New System.Drawing.Size(78, 50)
			Me.simpleButton7.TabIndex = 6
			Me.simpleButton7.Text = "simpleButton7"
			' 
			' simpleButton8
			' 
			Me.simpleButton8.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton8.Location = New System.Drawing.Point(87, 111)
			Me.simpleButton8.Name = "simpleButton8"
			Me.simpleButton8.Size = New System.Drawing.Size(78, 50)
			Me.simpleButton8.TabIndex = 7
			Me.simpleButton8.Text = "simpleButton8"
			' 
			' simpleButton9
			' 
			Me.simpleButton9.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton9.Location = New System.Drawing.Point(171, 111)
			Me.simpleButton9.Name = "simpleButton9"
			Me.simpleButton9.Size = New System.Drawing.Size(81, 50)
			Me.simpleButton9.TabIndex = 8
			Me.simpleButton9.Text = "simpleButton9"
			' 
			' XtraUserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "XtraUserControl1"
			Me.Size = New System.Drawing.Size(255, 164)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private simpleButton9 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton8 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton7 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton6 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton5 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace
