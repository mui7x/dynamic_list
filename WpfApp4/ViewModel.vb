Imports ReactiveUI
Imports System.Collections.ObjectModel
Imports System.Reactive
Imports System.Reactive.Linq
Imports System.Windows.Threading
Public Class ViewModel
    Inherits ReactiveObject

    Private _items As ObservableCollection(Of String)

    Public ReadOnly Property Items As ObservableCollection(Of String)
        Get
            Return _items
        End Get
    End Property

    Public Sub New()
        _items = New ObservableCollection(Of String)
        BindingOperations.EnableCollectionSynchronization(_items, New Object())
        For i As Integer = 0 To 10
            _items.Add(DateTime.Now.ToString("yyyyMMddHHmmss"))
        Next


        ' Add items to the list every second
        Observable.Timer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1)) _
            .Subscribe(Sub(x)
                           _items(0) = DateTime.Now.ToString("yyyyMMddHHmmss")
                       End Sub)
    End Sub
End Class
