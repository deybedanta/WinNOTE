
Public Class Form1
    Dim cnt As Integer
    Dim cnt1 As Integer
    Dim cnt2 As Integer
    Dim cnt3 As Integer
    Dim Amoled As New Color
    Dim defaultDark As New Color
    Dim deepSlate As New Color
    Dim trueDark As New Color

    Private Sub SaveCtrlSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCtrlSToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        MsgBox("Do you want to save your changes?", MsgBoxStyle.YesNoCancel)
        TextBox1.Text = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub FontFaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontFaceToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub AboutNotepadCloneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutNotepadCloneToolStripMenuItem.Click
        MessageBox.Show("WinNOTE 1.1 - A Free Dark Mode Text Editor" & vbCrLf & "Developed by Bedanta Dey" & vbCrLf & "https://sites.google.com/view/winnote" & vbCrLf & "https://github.com/BedantaDeyCH", "About WinNOTE", MessageBoxButtons.OK)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Visit: https://sites.google.com/view/winnote for information on the software.", "Help & Info", MessageBoxButtons.OK)
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub FormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub

    Private Sub PageColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub TrueDarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrueDarkToolStripMenuItem.Click
        trueDark = ColorTranslator.FromHtml("#9A9A9A")
        Select Case cnt
            Case 1
                TextBox1.BackColor = trueDark
                cnt = 0
            Case 0
                TextBox1.BackColor = trueDark
                cnt = 1
        End Select

    End Sub

    Private Sub DeepSlateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeepSlateToolStripMenuItem.Click
        deepSlate = ColorTranslator.FromHtml("#3D3B3B")
        Select Case cnt1
            Case 1
                TextBox1.BackColor = deepSlate
                cnt1 = 0
            Case 0
                TextBox1.BackColor = deepSlate
                cnt1 = 1
        End Select
    End Sub

    Private Sub DefaultDarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultDarkToolStripMenuItem.Click
        defaultDark = ColorTranslator.FromHtml("#404040")
        Select Case cnt2
            Case 1
                TextBox1.BackColor = defaultDark
                cnt2 = 0
            Case 0
                TextBox1.BackColor = defaultDark
                cnt2 = 1
        End Select
    End Sub

    Private Sub JazzyAmoledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JazzyAmoledToolStripMenuItem.Click
        Amoled = ColorTranslator.FromHtml("#000000")
        Select Case cnt3
            Case 1
                TextBox1.BackColor = Amoled
                cnt3 = 0
            Case 0
                TextBox1.BackColor = Amoled
                cnt3 = 1
        End Select
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangelogToolStripMenuItem.Click
        MessageBox.Show("WinNote Version 1.1" & vbCrLf & "- Added Note Mode! (You can now change your page color using a list of modes!" & vbCrLf & "- Added a 'What's New' button" & vbCrLf & "- Updated help to redirect to the website.", "What's New?", MessageBoxButtons.OK)
    End Sub
End Class
