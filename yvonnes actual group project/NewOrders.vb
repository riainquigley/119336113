Public Class FrmNewOrders
    Private Sub GrpSelect_Enter(sender As Object, e As EventArgs) Handles GrpSelect.Enter
        CboShoes.Items.Add("Classic")
        CboShoes.Items.Add("Retro")
        CboShoes.Items.Add("Vintage")
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        GrpSelect.Visible = True
        LblOrders.Visible = True
    End Sub

    Private Sub FrmNewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class