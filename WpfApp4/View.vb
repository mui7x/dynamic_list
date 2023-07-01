
Public Class View
    Inherits Window
    Public Sub New()
        InitializeComponent()
        DataContext = New ViewModel()
    End Sub
End Class
