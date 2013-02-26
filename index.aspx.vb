
Partial Class index
    Inherits System.Web.UI.Page
    'clear out all the user input
    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        HourWageTextBox.Text = ""
        NoOfHoursTextBox.Text = ""
        PreTaxTextBox.Text = ""
        AfterTaxTextBox.Text = ""
        resultLabel.Text = "Please enter the number"

    End Sub

    'handle the calculating net pay for the employee
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        'define the variables
        Dim wage As Decimal = HourWageTextBox.Text
        Dim hours As Integer = NoOfHoursTextBox.Text
        Dim preTax As Decimal = PreTaxTextBox.Text
        Dim afterTax As Decimal = AfterTaxTextBox.Text

        'the procedure to calculate the netpay
        Dim grossPay As Decimal
        Dim taxableIncome As Decimal
        Dim taxes As Decimal
        Dim incomeAfterTax As Decimal
        Dim netPay As Decimal

        grossPay = hours * wage
        taxableIncome = grossPay - preTax
        taxes = taxableIncome * (18 / 100)
        incomeAfterTax = grossPay - taxes
        netPay = incomeAfterTax - afterTax


        'display result in the result label
        resultLabel.Text = "Your net payment is $" & netPay.ToString("#,####.##")

    End Sub
End Class
