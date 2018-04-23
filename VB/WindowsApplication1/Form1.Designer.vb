Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.dropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
			Me.dropDownButton2 = New DevExpress.XtraEditors.DropDownButton()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dropDownButton1
			' 
			Me.dropDownButton1.Location = New System.Drawing.Point(12, 12)
			Me.dropDownButton1.Name = "dropDownButton1"
			Me.dropDownButton1.Size = New System.Drawing.Size(124, 23)
			Me.dropDownButton1.TabIndex = 1
			Me.dropDownButton1.Text = "DXPopupMenu"
			' 
			' dropDownButton2
			' 
			Me.dropDownButton2.Location = New System.Drawing.Point(168, 12)
			Me.dropDownButton2.Name = "dropDownButton2"
			Me.dropDownButton2.Size = New System.Drawing.Size(327, 23)
			Me.dropDownButton2.TabIndex = 2
			Me.dropDownButton2.Text = "CustomControl"
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(12, 189)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.ActionButtonIndex = 1
			Me.popupContainerEdit1.Properties.AutoHeight = False
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "PopupContainerEdit", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down, "", 20, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			Me.popupContainerEdit1.Size = New System.Drawing.Size(255, 28)
			Me.popupContainerEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(516, 368)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Controls.Add(Me.dropDownButton2)
			Me.Controls.Add(Me.dropDownButton1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dropDownButton1 As DevExpress.XtraEditors.DropDownButton
		Private dropDownButton2 As DevExpress.XtraEditors.DropDownButton
		Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit

	End Class
End Namespace

