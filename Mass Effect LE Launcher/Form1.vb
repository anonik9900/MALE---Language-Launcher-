Public Class Form1


    Private Declare Auto Function GetPrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Friend Function IniRead(ByVal Filename As String, ByVal Section As String, ByVal Key As String, Optional ByVal lpDefault As String = "", Optional ByVal bRaiseError As Boolean = False) As String

        Dim RetVal As String = New String(" ", 255)

        Dim LenResult As Integer

        Dim ErrString As String

        LenResult = GetPrivateProfileString(Section, Key, lpDefault, RetVal, RetVal.Length, Filename)

        If LenResult = 0 AndAlso bRaiseError Then

            If Not (System.IO.File.Exists(Filename)) Then

                ErrString = "Impossibile aprire il file INI" & Filename

            Else

                ErrString = "La sezione o la chiave sono errate oppure l’accesso al file non è consentito"

            End If

            Throw New Exception(ErrString)

        End If

        Return RetVal.Substring(0, LenResult)

    End Function

    Friend Function IniWrite(ByVal Filename As String, ByVal Section As String, ByVal Key As String, ByVal Value As String, Optional ByVal bRaiseError As Boolean = False) As Boolean

        Dim LenResult As Integer

        Dim ErrString As String

        LenResult = WritePrivateProfileString(Section, Key, Value, Filename)

        If LenResult = 0 And bRaiseError Then

            If Not (System.IO.File.Exists(Filename)) Then

                ErrString = "Impossibile aprire il file INI" & Filename

            Else

                ErrString = "Accesso al file non consentito"

            End If

            Throw New Exception(ErrString)

        End If

        Return IIf(LenResult = 0, False, True)

        End

    End Function




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub



    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click






        showForm1()








    End Sub



    Dim selectedItem1, selectedItem2, selectedItem3 As Object



    


    Private Sub showForm1()
        selectedItem1 = ComboBox1.SelectedItem
 
        If selectedItem1 Is Nothing Then
            MsgBox("Error: Null Value Selected")
            Exit Sub
        End If

        If ((selectedItem1.ToString() = "Italian")) Then
            MsgBox("Lingua Selezionata: Italiano")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-ita.exe")

        ElseIf ((selectedItem1.ToString() = "English")) Then
            MsgBox("Language Selected: English")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-eng.exe")

        ElseIf ((selectedItem1.ToString() = "French")) Then
            MsgBox("Langue sélectionnée : Français")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-fre.exe")

        ElseIf ((selectedItem1.ToString() = "German")) Then
            MsgBox("Ausgewählte Sprache: Deutsch")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-deu.exe")

        ElseIf ((selectedItem1.ToString() = "Spanish")) Then
            MsgBox("Idioma seleccionado: Español")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-esn.exe")

        ElseIf ((selectedItem1.ToString() = "Polish")) Then
            MsgBox("Wybrany język: Polski")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-pol.exe")

        ElseIf ((selectedItem1.ToString() = "Russian")) Then
            MsgBox("Выбранный язык: Русский")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-rus.exe")

        ElseIf ((selectedItem1.ToString() = "Japanese")) Then
            MsgBox("選択した言語: 日本語")
            System.Diagnostics.Process.Start("C:\Games\Mass Effect Legendary Edition\Game\Launcher\lang-launcher\male-jpn.exe")

        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' your code to initialize items of ComboBox1, ComboBox2, ComboBox3
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        System.Diagnostics.Process.Start("chrome.exe", "https://github.com/anonik9900")
    End Sub
End Class
