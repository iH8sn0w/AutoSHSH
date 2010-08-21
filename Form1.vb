Imports System.Management
Imports System
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Environment
Imports System.IO
Imports System.Windows.Forms.FileDialog
Imports System.Reflection
Public Class Win32_UsbDevice
    Public ECID As String
    Public Device As String
    Public CPID As String
    Function HighlightWords2(ByVal rtb As RichTextBox, ByVal sFindString2 As String, ByVal lColor2 As System.Drawing.Color) As Integer

        Dim iFoundPos2 As Integer 'Position of first character of match
        Dim iFindLength2 As Integer       'Length of string to find
        Dim iOriginalSelStart2 As Integer
        Dim iOriginalSelLength2 As Integer
        Dim iMatchCount2 As Integer      'Number of matches

        'Save the insertion points current location and length
        iOriginalSelStart2 = rtb.SelectionStart
        iOriginalSelLength2 = rtb.SelectionLength

        'Cache the length of the string to find
        iFindLength2 = Len(sFindString2)

        'Attempt to find the first match
        iFoundPos2 = rtb.Find(sFindString2, 0, RichTextBoxFinds.NoHighlight)
        While iFoundPos2 > 0
            iMatchCount2 = iMatchCount2 + 1

            console.SelectionStart = iFoundPos2
            'The SelLength property is set to 0 as soon as you change SelStart
            console.SelectionLength = iFindLength2
            'rtb.SelectionBackColor = lColor2

            console.Select(iFoundPos2 + 5, iFindLength2 - 1)
            CPID = console.SelectedText
            'MsgBox(CPID)
            'Attempt to find the next match
            iFoundPos2 = rtb.Find(sFindString2, iFoundPos2 + iFindLength2, RichTextBoxFinds.NoHighlight)
        End While

        'Restore the insertion point to its original location and length
        rtb.SelectionStart = iOriginalSelStart2
        rtb.SelectionLength = iOriginalSelLength2

        'Return the number of matches
        HighlightWords2 = iMatchCount2
    End Function
    Function HighlightWords(ByVal rtb As RichTextBox, ByVal sFindString As String, ByVal lColor As System.Drawing.Color) As Integer

        Dim iFoundPos As Integer 'Position of first character of match
        Dim iFindLength As Integer       'Length of string to find
        Dim iOriginalSelStart As Integer
        Dim iOriginalSelLength As Integer
        Dim iMatchCount As Integer      'Number of matches

        'Save the insertion points current location and length
        iOriginalSelStart = rtb.SelectionStart
        iOriginalSelLength = rtb.SelectionLength

        'Cache the length of the string to find
        iFindLength = Len(sFindString) + 16

        'Attempt to find the first match
        iFoundPos = rtb.Find(sFindString, 0, RichTextBoxFinds.NoHighlight)
        While iFoundPos > 0
            iMatchCount = iMatchCount + 1

            console.SelectionStart = iFoundPos
            'The SelLength property is set to 0 as soon as you change SelStart
            console.SelectionLength = iFindLength
            'rtb.SelectionBackColor = lColor

            console.Select(iFoundPos + 5, iFindLength - 5)
            ECID = console.SelectedText
            'Attempt to find the next match
            iFoundPos = rtb.Find(sFindString, iFoundPos + iFindLength, RichTextBoxFinds.NoHighlight)
        End While

        'Restore the insertion point to its original location and length
        rtb.SelectionStart = iOriginalSelStart
        rtb.SelectionLength = iOriginalSelLength

        'Return the number of matches
        HighlightWords = iMatchCount
    End Function
    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Searching for Recovery Mode..."
        Dim icountMatch2 As Integer = 0
        Dim icountMatch As Integer = 0
        Try

            Dim searcher As New ManagementObjectSearcher( _
           "SELECT * FROM Win32_PnPEntity")
            For Each queryObj As ManagementObject In searcher.Get()
                console.Text += (queryObj("DeviceID"))
            Next
            'Dim icountMatch As Integer = 0
            icountMatch = HighlightWords(console, "ECID:", System.Drawing.Color.Red)
            'MessageBox.Show(icountMatch.ToString & " matches Found")
            If console.Text.Contains("ECID") Then
                icountMatch2 = HighlightWords2(console, "CPID:", System.Drawing.Color.Red)
                'console.Text = " "
                If CPID = "8720" Then
                    Device = "IPOD_2G_3_1_3"
                ElseIf CPID = "8920" Then
                    Device = "IPHONE_3_1_3"
                ElseIf CPID = "8922" Then
                    Device = "IPOD_3G_3_1_3"
                ElseIf CPID = "8930" Then
                    Device = "IPAD_3_2"
                ElseIf CPID = "8900" Then
                    MsgBox("Unsupported! This device does not require SHSH blobs.")
                    Button1.Text = "Grab my SHSH Blobs Automatically"
                    Button1.Enabled = True
                    Exit Sub
                End If
                Button1.Text = "ECID Found! (" & ECID & ")"
                Delay(2)
                Button1.Text = "Select a save Location..."
                Dim Fetch As String
                save.ShowDialog()
                If save.FileName = "" Then
                    MsgBox("No File Name Specified!")
                    Button1.Text = "Grab my SHSH Blobs Automatically"
                    Button1.Enabled = True
                    Exit Sub
                Else
                    Button1.Text = "Sending Ticket to Cydia..."
                    Fetch = "umbrella.exe -d " & Device & " -e " & ECID & " -r CYDIA -f " & quote.Text & save.FileName & quote.Text
                    Delay(1)
                    Shell(Fetch, AppWinStyle.Hide)
                    Button1.Text = "Done!"
                    MsgBox("Done! If 3.1.3/3.2 is still being signed by Apple, then your SHSH blobs should be located in your save location (shortly) + Saved on Cydia." & (Chr(13)) & "You should now be able to always restore to 3.1.3/3.2!" & (Chr(13)) & "Special Thanks to semaphore for umbrella!")
                    Button1.Text = "Grab my SHSH Blobs Automatically"
                    Button1.Enabled = True
                    Exit Sub
                End If
            Else
                console.Text = " "
                Button1.Text = "ECID was not found!"
                MsgBox("Makesure you have your iDevice connected in Recovery Mode.", MsgBoxStyle.Information)
                Button1.Text = "Grab my SHSH Blobs Automatically"
                Button1.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button2.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start("http://ih8sn0w.com")
    End Sub
    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Cyan
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Blue

    End Sub

    Private Sub Win32_UsbDevice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("Done! If 3.1.3/3.2 is still being signed by Apple, then your SHSH blobs should be located in your save location + Saved on Cydia." & (Chr(13)) & "You should now be able to always restore to 3.1.3/3.2!" & (Chr(13)) & "Special Thanks to semaphore for umbrella!")
        MsgBox("Please note: An internet connection is required for this to work!" & (Chr(13)) & "*Also make sure only ONE device is connected in Recovery Mode!*", MsgBoxStyle.Information)
        Dim Answer = MsgBox("Do you have Java Runtime installed on this PC?", MsgBoxStyle.Critical + vbYesNo, "Do you have Java?")
        If Answer = vbYes Then
            'good
        Else
            MsgBox("When you press ""OK"", you will be redirected to a download. Makesure you install this before running the application!")
            Process.Start("http://javadl.sun.com/webapps/download/AutoDL?BundleId=38663")
            Application.Exit()
        End If
        Me.BringToFront()
    End Sub
End Class
