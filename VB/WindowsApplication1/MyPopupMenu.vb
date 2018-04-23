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
	Public Class MyPopupControl
		Implements IDXDropDownControl

		Public Sub New(ByVal customControl As Control)
			InitPopupForm(customControl)
		End Sub

		Private Sub InitPopupForm(ByVal customControl As Control)
			_Form = New Form()
			_Form.FormBorderStyle = FormBorderStyle.None
			_Form.BackColor = Color.Black
			AddHandler _Form.Deactivate, AddressOf _Form_Deactivate
			Dim gc As New GroupControl()
			gc.Dock = DockStyle.Fill
			gc.Text = "Custom popup window"
			_Form.Controls.Add(gc)
			customControl.Dock = DockStyle.Fill
			gc.Controls.Add(customControl)
		End Sub

		Private Sub _Form_Deactivate(ByVal sender As Object, ByVal e As EventArgs)
			_Form.Hide()
		End Sub


		Private _Form As Form
		Public Property Form() As Form
			Get
				Return _Form
			End Get
			Set(ByVal value As Form)
				_Form = value
			End Set
		End Property


		#Region "IDXDropDownControl Members"


		Private Sub Hide() Implements IDXDropDownControl.Hide
			Form.Hide()
		End Sub

		Private Sub Show(ByVal manager As IDXMenuManager, ByVal control As Control, ByVal pos As Point) Implements IDXDropDownControl.Show
			Form.Show()
			Form.Location = control.PointToScreen(pos)
		End Sub

		Private ReadOnly Property Visible() As Boolean Implements IDXDropDownControl.Visible
			Get
				Return Form.Visible
			End Get
		End Property

		#End Region
	End Class
End Namespace
