Option Strict On ' Forces explicit  data conversion
Option Explicit On ' This forces a variable to be previously declared
Option Infer Off ' Ensure that a variable's data type is stated

Public Class frmSRC_Election
    Private intAPK As Integer
    Private intDFC As Integer
    Private intSWC As Integer
    Private intAPB As Integer
    Private intVotes(4) As Integer
    Private intTotal As Integer
    Private dblAverage As Double
    Private intHighest As Integer
    Private intLowest As Integer
    Private strHighest As String
    Private strLowest As String
    Private strCampus() As String = {Nothing, "APK", "SWC", "APB", "DFC"}
    Private Sub frmSRC_Election_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCampus_Click(sender As Object, e As EventArgs) Handles btnCampus.Click
        Dim strChoice As String

        strChoice = InputBox("Which campus are you inputing for? ").ToUpper()

        Select Case strChoice
            Case "APK"
                intAPK = CInt(InputBox("How many votes from APK campus? "))
                intVotes(1) = intAPK
            Case "SWC"
                intSWC = CInt(InputBox("How many votes from SWC campus? "))
                intVotes(2) = intSWC
            Case "APB"
                intAPB = CInt(InputBox("How many votes from APB campus? "))
                intVotes(3) = intAPB
            Case "DFC"
                intDFC = CInt(InputBox("How many votes from DFC campus? "))
                intVotes(4) = intDFC
        End Select



    End Sub

    Private Sub btnCalcTotal_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click
        For i As Integer = 1 To 4
            intTotal += intVotes(i)
        Next i

        txtTotal.Text = CStr("Total Votes: " & intTotal)
    End Sub

    Private Sub btnCalcAverage_Click(sender As Object, e As EventArgs) Handles btnCalcAverage.Click
        dblAverage = intTotal / 4

        txtAverage.Text = CStr("Average Votes: " & Format(dblAverage, "0.00"))
    End Sub

    Private Sub btnCalcHighest_Click(sender As Object, e As EventArgs) Handles btnCalcHighest.Click
        intHighest = intVotes(1)
        strHighest = strCampus(1)

        For i As Integer = 1 To 4
            If (intHighest < intVotes(i)) Then
                intHighest = intVotes(i)
                strHighest = strCampus(i)
            End If
        Next i

        txtHighest.Text = CStr("Highest Votes: " & strHighest)
    End Sub

    Private Sub btnCalcLowest_Click(sender As Object, e As EventArgs) Handles btnCalcLowest.Click
        intLowest = intVotes(1)
        strLowest = strCampus(1)

        For i As Integer = 1 To 4
            If (intLowest > intVotes(i)) Then
                intLowest = intVotes(i)
                strLowest = strCampus(i)
            End If
        Next i

        txtLowest.Text = CStr("Lowest Votes: " & strLowest)

    End Sub
End Class
