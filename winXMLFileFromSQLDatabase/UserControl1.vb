Public Class UserControl1
    Public Event AllRight_Click(ByVal sender As Object, ByVal e As EventArgs)
    Public Event OneRight_Click(ByVal sender As Object, ByVal e As EventArgs)
    Public Event OneLeft_Click(ByVal sender As Object, ByVal e As EventArgs)
    Public Event AllLeft_Click(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub btnAllRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllRight.Click
        RaiseEvent AllRight_Click(sender, e)
    End Sub

    Private Sub btnOneRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneRight.Click
        RaiseEvent OneRight_Click(sender, e)
    End Sub

    Private Sub btnOneLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneLeft.Click
        RaiseEvent OneLeft_Click(sender, e)
    End Sub

    Private Sub btnAllLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllLeft.Click
        RaiseEvent AllLeft_Click(sender, e)
    End Sub
End Class
