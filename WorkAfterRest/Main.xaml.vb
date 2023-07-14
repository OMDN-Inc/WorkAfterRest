Imports System.Windows.Threading

Public Class Main
    Private WithEvents timer As DispatcherTimer
    Private Num As Int32
    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
        ' 在每个Tick事件中执行需要定期执行的代码
        Num = Num + 1
        LabelU.Content = Num & "%"
        If Num > 100 Then
            Num = 0
        End If
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Key = Key.Escape Then
            Close()
        End If
    End Sub



    Private Sub Main11_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        timer = New DispatcherTimer()
        timer.Interval = TimeSpan.FromSeconds(3) ' 设置定时器间隔，这里以1秒为例
        timer.Start() ' 启动定时器
    End Sub

    Private Sub MainWindow_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Closed
        timer.Stop() ' 停止定时器
    End Sub
End Class
