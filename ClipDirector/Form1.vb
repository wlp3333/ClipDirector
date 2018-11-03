Public Class Form1
    'Define the string variables
    Dim str1, str2, str3, str4, str5, str6 As String
    'Store commands
    Private Sub btn_str_1_Click(sender As Object, e As EventArgs) Handles btn_str_1.Click
        str1 = My.Computer.Clipboard.GetText()
        txt_1.Text = str1
        lbl_1.Text = CType(str1.Length, String)
    End Sub
    Private Sub btn_str_2_Click(sender As Object, e As EventArgs) Handles btn_str_2.Click
        str2 = My.Computer.Clipboard.GetText()
        txt_2.Text = str2
        lbl_2.Text = CType(str2.Length, String)
    End Sub
    Private Sub btn_str_3_Click(sender As Object, e As EventArgs) Handles btn_str_3.Click
        str3 = My.Computer.Clipboard.GetText()
        txt_3.Text = str3
        lbl_3.Text = CType(str3.Length, String)
    End Sub
    Private Sub btn_str_4_Click(sender As Object, e As EventArgs) Handles btn_str_4.Click
        str4 = My.Computer.Clipboard.GetText()
        txt_4.Text = str4
        lbl_4.Text = CType(str4.Length, String)
    End Sub
    Private Sub btn_str_5_Click(sender As Object, e As EventArgs) Handles btn_str_5.Click
        str5 = My.Computer.Clipboard.GetText()
        txt_5.Text = str5
        lbl_5.Text = CType(str5.Length, String)
    End Sub
    'Recall commands
    Private Sub btn_rec_1_Click(sender As Object, e As EventArgs) Handles btn_rec_1.Click
        str1 = txt_1.Text
        If str1.Length > 0 Then
            My.Computer.Clipboard.SetText(str1)
        End If
        If str1.Length = 0 Then
            lbl_1.Text = "#"
        End If
    End Sub
    Private Sub btn_rec_2_Click(sender As Object, e As EventArgs) Handles btn_rec_2.Click
        str2 = txt_2.Text
        If str2.Length > 0 Then
            My.Computer.Clipboard.SetText(str2)
        End If
        If str2.Length = 0 Then
            lbl_2.Text = "#"
        End If
    End Sub
    Private Sub btn_rec_3_Click(sender As Object, e As EventArgs) Handles btn_rec_3.Click
        str3 = txt_3.Text
        If str3.Length > 0 Then
            My.Computer.Clipboard.SetText(str3)
        End If
        If str3.Length = 0 Then
            lbl_3.Text = "#"
        End If
    End Sub
    Private Sub btn_rec_4_Click(sender As Object, e As EventArgs) Handles btn_rec_4.Click
        str4 = txt_4.Text
        If str4.Length > 0 Then
            My.Computer.Clipboard.SetText(str4)
        End If
        If str4.Length = 0 Then
            lbl_4.Text = "#"
        End If
    End Sub
    Private Sub btn_rec_5_Click(sender As Object, e As EventArgs) Handles btn_rec_5.Click
        str5 = txt_5.Text
        If str5.Length > 0 Then
            My.Computer.Clipboard.SetText(str5)
        End If
        If str5.Length = 0 Then
            lbl_5.Text = "#"
        End If
    End Sub
    'Clear commands
    Private Sub btn_clr_1_Click(sender As Object, e As EventArgs) Handles btn_clr_1.Click
        str1 = ""
        txt_1.Text = ""
        lbl_1.Text = "#"
    End Sub
    Private Sub btn_clr_2_Click(sender As Object, e As EventArgs) Handles btn_clr_2.Click
        str2 = ""
        txt_2.Text = ""
        lbl_2.Text = "#"
    End Sub
    Private Sub btn_clr_3_Click(sender As Object, e As EventArgs) Handles btn_clr_3.Click
        str3 = ""
        txt_3.Text = ""
        lbl_3.Text = "#"
    End Sub
    Private Sub btn_clr_4_Click(sender As Object, e As EventArgs) Handles btn_clr_4.Click
        str4 = ""
        txt_4.Text = ""
        lbl_4.Text = "#"
    End Sub
    Private Sub btn_clr_5_Click(sender As Object, e As EventArgs) Handles btn_clr_5.Click
        str5 = ""
        txt_5.Text = ""
        lbl_5.Text = "#"
    End Sub
    'Unique commands
    Private Sub btn_dc_Click(sender As Object, e As EventArgs) Handles btn_dc.Click
        str6 = My.Computer.Clipboard.GetText()
        txt_6.Text = str6
        lbl_6.Text = CType(str6.Length, String)
    End Sub
    Private Sub btn_pur_Click(sender As Object, e As EventArgs) Handles btn_pur.Click
        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        str5 = ""
        str6 = ""
        txt_1.Text = ""
        txt_2.Text = ""
        txt_3.Text = ""
        txt_4.Text = ""
        txt_5.Text = ""
        txt_6.Text = ""
        lbl_1.Text = "#"
        lbl_2.Text = "#"
        lbl_3.Text = "#"
        lbl_4.Text = "#"
        lbl_5.Text = "#"
        lbl_6.Text = "#"
    End Sub
End Class