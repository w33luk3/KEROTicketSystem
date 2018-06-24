Imports System.Configuration
Imports System.Collections.Specialized
Public Class settingsForm
    Public StartSmall As String
    Public AlywaysOnTop As String

    Private Sub ontopCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ontopCheckBox.CheckedChanged

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If ontopCheckBox.Checked = True Then
            My.Settings.AlwaysOnTop = "True"
        Else
            My.Settings.AlwaysOnTop = "False"
        End If


        If startDockedCheckBox.Checked = True Then
            My.Settings.StartSmall = "True"
        Else
            My.Settings.StartSmall = "False"
        End If


        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub settingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StartSmall = "True" Then
            startDockedCheckBox.Checked = True
        Else
            startDockedCheckBox.Checked = False
        End If

        If My.Settings.AlwaysOnTop = "True" Then
            ontopCheckBox.Checked = True
        Else
            ontopCheckBox.Checked = False
        End If
    End Sub
End Class