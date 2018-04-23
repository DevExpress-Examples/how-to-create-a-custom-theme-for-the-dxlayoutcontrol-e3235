Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace SilverlightApplication27
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AddHandler Loaded, AddressOf MainPage_Loaded
		End Sub

		Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim theme As New Theme("testTheme", New Uri("/SilverlightApplication27;component/DevExpress.Xpf.LayoutControl/Office2007.Silverlight.xaml", UriKind.Relative)) With {.IsStandard = False, .FullName = "Test Theme"}
			ThemeManager.ApplicationTheme = theme
		End Sub
	End Class
End Namespace
