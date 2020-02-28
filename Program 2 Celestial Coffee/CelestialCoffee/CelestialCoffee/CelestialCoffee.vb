Public Class CelestialCoffee


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare Regular and Decaf as Double
        Dim Regular As Double
        Dim Decaf As Double
        'Cast Values from Textboxes to doubles
        Regular = CDbl(txtRegular.Text * 5.99)
        Decaf = CDbl(txtDecaf.Text * 4.99)
        'Declare TAX as constant and Total as Double, then cast values to doubles with total price formula
        Const TAX As Double = 0.08875
        Dim Total As Double
        Total = CDbl((Regular + Decaf) * TAX + (Regular + Decaf))
        'When user clicks calculate, the total will display in text box and formated. Text boxes will clear for decaf and regular.

        txtRegular.Clear()
        txtDecaf.Clear()
        txtTotal.Text = FormatCurrency(Total, 2)




    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'When user clicks confirms after they input personal information, those boxes clear and confirmation message appears in text box.
        txtConfirmation.Text = "Thank you " & txtName.Text & " for your order! " & "We will ship your order to " & txtAddress.Text & ", " & txtCity.Text & ", " & txtState.Text & ", " & txtZip.Text & ", " & "within 3 - 5 business days. "
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtTotal.Clear()

    End Sub
End Class
