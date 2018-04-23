Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim menu As New DXPopupMenu()
			menu.Items.Add(New DXMenuItem("Test1"))
			menu.Items.Add(New DXMenuItem("Test2"))
			menu.Items.Add(New DXMenuItem("Test3"))
			dropDownButton1.DropDownControl = menu
			dropDownButton2.DropDownControl = New MyPopupControl(New XtraUserControl1())
			Dim container As New PopupContainerControl()
			Dim uc As New XtraUserControl1()
			uc.Dock = DockStyle.Fill
			container.Controls.Add(uc)
			popupContainerEdit1.Properties.PopupControl = container
		End Sub
	End Class
End Namespace