﻿
Partial Class index
    Inherits System.Web.UI.Page
    'clear out all the user input
    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        HourWageTextBox.Text = ""
        NoOfHoursTextBox.Text = ""
        PreTaxTextBox.Text = ""
        AfterTaxTextBox.Text = ""
    End Sub

    'handle the calculating net pay for the employee
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class