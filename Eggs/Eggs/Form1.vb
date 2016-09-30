Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the fields.
        txtEggs1.Clear()
        txtEggs2.Clear()
        txtEggs3.Clear()
        txtEggs4.Clear()
        txtEggs5.Clear()
        lblDozen.Text = ("")
        lblRemainder.Text = ("")
        lblTotalPrice.Text = ("")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim numEggs, remainderEggs, dozenEggs, dozenPrice As Integer
        Dim singleEggPriceTotal, dozenEggPriceTotal, totalPrice, singlePrice As Double
        Try
            numEggs = CInt(txtEggs1.Text) + (txtEggs2.Text) + (txtEggs3.Text) + (txtEggs4.Text) + (txtEggs5.Text)

            dozenEggs = CInt(Math.Floor(Math.Abs(numEggs / 12)))
            lblDozen.Text = CStr(dozenEggs)

            remainderEggs = numEggs Mod 12
            lblRemainder.Text = CStr(remainderEggs)

            dozenPrice = 2.0
            singlePrice = 0.25

            dozenEggPriceTotal = dozenEggs * dozenPrice
            singleEggPriceTotal = remainderEggs * singlePrice
            totalPrice = dozenEggPriceTotal + singleEggPriceTotal
            lblTotalPrice.Text = CStr(totalPrice)
        Catch
            MessageBox.Show("All textboxes must have a value")
        End Try

    End Sub
End Class
