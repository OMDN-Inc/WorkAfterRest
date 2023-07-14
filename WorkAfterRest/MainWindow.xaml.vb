Class MainWindow 


    Private Sub Exbutton1_Click(sender As Object, e As RoutedEventArgs) Handles Exbutton1.Click
        Dim main As New Main
        main.Show()
    End Sub

    Private Sub Labelx_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Labelx.MouseLeftButtonDown
        Try
            Process.Start("https://github.com/OMDN-Inc/WorkAfterRest")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Exbutton2_Click(sender As Object, e As RoutedEventArgs) Handles Exbutton2.Click
        Dim main11 As New Main11
        main11.Show()
    End Sub
End Class
