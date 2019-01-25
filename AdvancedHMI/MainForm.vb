Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub AnalogValueDisplay1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BasicLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnalogValueDisplay5_Click(sender As Object, e As EventArgs) Handles AnalogValueDisplay5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub EthernetIPforCLXCom1_DataReceived(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.DataReceived

    End Sub

    Private Sub AnalogValueDisplay2_Click(sender As Object, e As EventArgs) Handles AnalogValueDisplay2.Click

    End Sub

    Private Sub AnalogValueDisplay1_Click_1(sender As Object, e As EventArgs) Handles AnalogValueDisplay1.Click

    End Sub

    Private Sub AnalogValueDisplay3_Click(sender As Object, e As EventArgs) Handles AnalogValueDisplay3.Click

    End Sub

    Private Sub AnalogValueDisplay4_Click(sender As Object, e As EventArgs) Handles AnalogValueDisplay4.Click

    End Sub

    Private Sub AnalogValueDisplay6_Click(sender As Object, e As EventArgs) Handles AnalogValueDisplay6.Click

    End Sub

    Private Sub AnalogValueDisplay7_Click(sender As Object, e As EventArgs) Handles AnalogValueDisplay7.Click

    End Sub

    Private Sub ChartBySampling1_Click(sender As Object, e As EventArgs) Handles ChartBySampling1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
