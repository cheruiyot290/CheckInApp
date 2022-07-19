Public Class Form1
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        NumericUpDown1.Value = DateTimePicker1.Value.Day - DateTimePicker2.Value.Day
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As VariantType
        iExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        Dim TheOutput As String = String.Format(txtAddress.Text, txtAmountPaid.Text, txtBalance.Text, txtCompany.Text, txtDiscount.Text, txtFirstName.Text, txtFolioNo.Text, txtIDNo.Text, txtLastName.Text, txtNotes.Text, txtOthCharges.Text, txtPlateNo.Text, txtRate.Text, txtRcardNo.Text, txtRoomNo.Text, txtSubTotal.Text, txtToCharges.Text, txtTotal.Text, txtVehicleModel.Text)
        e.Graphics.DrawString(TheOutput, font, Brushes.Black, 200, 200)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged


    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtBalance.Text = Val(txtTotal.Text) - Val(txtAmountPaid.Text)
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged

    End Sub

    Private Sub txtToCharges_TextChanged(sender As Object, e As EventArgs) Handles txtToCharges.TextChanged
        txtSubTotal.Text = Val(txtToCharges.Text) + Val(txtOthCharges.Text)
    End Sub

    Private Sub txtOthCharges_TextChanged(sender As Object, e As EventArgs) Handles txtOthCharges.TextChanged
        txtSubTotal.Text = Val(txtToCharges.Text) + Val(txtOthCharges.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        NumericUpDown1.Value = DateTimePicker1.Value.Day - DateTimePicker2.Value.Day
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged

    End Sub

    Private Sub txtFolioNo_TextChanged(sender As Object, e As EventArgs) Handles txtFolioNo.TextChanged

    End Sub
End Class
