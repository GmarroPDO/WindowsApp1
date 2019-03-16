Public Class Form_CreateMasterCaseFolder

    Private Enum Casetypes
        Criminal = 0
        Indictments = 1
        Juvenile = 2
        MentalHealth = 3
        Traffic = 4
        Violations = 5

    End Enum

    Private Const ADONetworkPath As String = "\\ado-file-srv\media\Master Case Folders"
    Private Const errCF = "Error creating folder: "
    Private Const PDONetworkpath As String = "\\pdo-media-srv\media\Master Case Folders"

    Private ClientsLastName As String
    Private DocketNumber As String
    Private MCFolderBasePath As String

    Private MCFSubFolders() As String

    ' it's important that the order here does not change and matches the values in enum Casetypes
    Private MCFTopLevelNames() As String =
        {
            "Criminal",
            "Indictments",
            "Juvenile",
            "Mental Health",
            "Traffic",
            "Violations"
        }

    Private MCFSubFolders_Criminal() As String =
        {
            "\eTablet_ Redacted_Material_For_client",
            "\Media\Media_Court",
            "\Media\Media_DA-OtherParties",
            "\Media\Media_Investigations"
        }

    Private MCFSubFolders_Indictments() As String =
        {
            "\eTablet_ Redacted_Material_For_client",
            "\Media\Media_Court",
            "\Media\Media_DA-OtherParties",
            "\Media\Media_Investigations"
        }

    Private MCFSubFolders_Juvenile() As String =
        {
            "\eTablet_ Redacted_Material_For_client",
            "\Media\Media_Court",
            "\Media\Media_DA-OtherParties",
            "\Media\Media_Investigations"
        }

    Private MCFSubFolders_MentalHealth() As String =
        {
            "\eTablet_ Redacted_Material_For_client",
            "\Media\Media_Court",
            "\Media\DA-OtherParties",
            "\Media\Media_Investigations"
        }

    Private MCFSubFolders_Traffic() As String =
        {
            "\eTablet_ Redacted_Material_For_client",
            "\Media\Media_Court",
            "\Media\DA-OtherParties",
            "\Media\Media_Investigations"
        }

    Private MCFSubFolders_Violations() As String =
        {
            "\eTablet_ Redacted_Material_For_client",
            "\Media\Media_Court",
            "\Media\DA-OtherParties",
            "\Media\Media_Investigations"
        }


    Private PDO As Boolean

    Private Sub Button_Apply_Click(sender As Object, e As EventArgs) Handles Button_Apply.Click
        CreateMCFFolders(MCFolderBasePath)
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        CreateMCFFolders(MCFolderBasePath)
        Application.Exit()
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        InitializeResetControls()
    End Sub

    Private Sub CaseType_Enter(sender As Object, e As EventArgs) Handles CaseTypeGB.Enter

    End Sub

    Private Function CreateMCFFolders(ByVal MCFolderBasePath As String)
        Dim fullMCFPath As String
        Dim returnCode As Long = 0
        Dim words As String()
        Dim word As String
        Dim lcldocket As String
        Dim lclclientname As String
        Dim i As Integer
        Dim casetype As Casetypes
        Dim errorstr As String
        '
        ' Validate folder names
        '
        If TextBox_ClientsLastName.TextLength.Equals(0) Or TextBox_DocketNumber.TextLength.Equals(0) Then
            errorstr = errCF + vbCrLf + vbCrLf + " Both Docket Number and Client's last name need to be filled in"
            MsgBox(errorstr)
            Return (-1)
        End If

        words = TextBox_DocketNumber.Text.Trim.Split(New Char() {" "c})
        lcldocket = ""
        i = 1
        For Each word In words

            lcldocket += StrConv(word, vbProperCase)
            If (i - words.Count) Then
                lcldocket += "-"
            End If
            i += 1
        Next

        words = TextBox_ClientsLastName.Text.Trim.Split(New Char() {" "c})
        lclclientname = ""
        i = 1
        For Each word In words
            lclclientname += StrConv(word, vbProperCase)
            If (i - words.Count) Then
                lclclientname += "-"
            End If
            i += 1
        Next

        fullMCFPath = MCFolderBasePath + "\" + lcldocket + "_" + lclclientname

        If rbCTCriminal.Checked Then
            casetype = Casetypes.Criminal
            MCFSubFolders = MCFSubFolders_Criminal

        ElseIf rbCTIndictments.Checked Then

            casetype = Casetypes.Indictments
            MCFSubFolders = MCFSubFolders_Indictments

        ElseIf rbCTJuvenile.Checked Then
            casetype = Casetypes.Juvenile
            MCFSubFolders = MCFSubFolders_Juvenile

        ElseIf rbCTMentalHealth.Checked Then
            casetype = Casetypes.MentalHealth
            MCFSubFolders = MCFSubFolders_MentalHealth
        ElseIf rbCTTraffic.Checked Then
            casetype = Casetypes.Traffic
            MCFSubFolders = MCFSubFolders_Traffic
        ElseIf rbCTViolations.Checked Then
            casetype = Casetypes.Violations
            MCFSubFolders = MCFSubFolders_Violations
        Else
            MsgBox("Should not happen- no radio button selected")
        End If

        Dim mcfDocketNameBase As String

        mcfDocketNameBase = CreateMCTFolderTree(casetype, lcldocket, lclclientname, YearCB.SelectedItem, MCFSubFolders, MCFolderBasePath)
        Dim cmd As String = "explorer.exe " + mcfDocketNameBase


        'Shell(cmd, vbNormalFocus)

        'this

        Return (returnCode)
    End Function

    Private Function CreateMCTFolderTree(ByVal caseType As Casetypes,
                                    ByVal docketNumber As String,
                                    ByVal lastName As String,
                                    ByVal year As String,
                                    ByVal subfloderArray As String(),
                                    ByVal MCTfolderbasepath As String
                                    )
        Dim subfolder As String
        Dim folderToCreate As String
        Dim errorstr As String
        Dim returnCode As Long = 0
        Dim fullPathName As String

        fullPathName = MCTfolderbasepath + "\" + MCFTopLevelNames(caseType)

        If ((caseType = Casetypes.Criminal) Or (caseType = Casetypes.Juvenile)) Then
            fullPathName += "\" + year
        End If

        For Each subfolder In subfloderArray
            folderToCreate = fullPathName + "\" + docketNumber + "_" + lastName + subfolder
            Try
                My.Computer.FileSystem.CreateDirectory(folderToCreate)
            Catch ex As Exception
                errorstr = errCF + vbCrLf + vbCrLf + folderToCreate + vbCrLf + vbCrLf + ex.Message
                MsgBox(errorstr)
                returnCode = ex.HResult
                Exit For
            Finally
            End Try
        Next
        CreateMCTFolderTree = fullPathName + "\" + docketNumber + "_" + lastName
    End Function

    Private Sub Form_CreateMasterCaseFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeResetControls()
    End Sub

    Private Sub InitializeResetControls()
        RadioButton_PDO.Checked = True
        RadioButton_ADO.Checked = False
        rbCTCriminal.Checked = True
        TextBox_DocketNumber.Text = ""
        TextBox_ClientsLastName.Text = ""
        YearCB.SelectedItem = Now.Year.ToString
        YearCB.Visible = True
        YearCB.DropDownStyle = ComboBoxStyle.DropDown
    End Sub

    Private Sub RadioButton_ADO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_ADO.CheckedChanged
        If sender.checked Then
            MCFolderBasePath = ADONetworkPath
        End If

    End Sub

    Private Sub RadioButton_PDO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_PDO.CheckedChanged
        If sender.checked Then
            MCFolderBasePath = PDONetworkpath
        End If
    End Sub

    Private Sub rbCTCriminal_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTCriminal.CheckedChanged
        YearCB.Visible = True
        GBYear.Visible = True
    End Sub

    Private Sub rbCTIndictments_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTIndictments.CheckedChanged
        YearCB.Visible = False
        GBYear.Visible = False
    End Sub

    Private Sub rbCTMentalHealth_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTMentalHealth.CheckedChanged
        YearCB.Visible = False
        GBYear.Visible = False
    End Sub

    Private Sub rbCTJuvenile_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTJuvenile.CheckedChanged
        YearCB.Visible = True
        GBYear.Visible = True
    End Sub

    Private Sub YearCB_SelectedValueChanged(sender As Object, e As EventArgs) Handles YearCB.SelectedValueChanged

    End Sub

    Private Sub rbCTTraffic_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTTraffic.CheckedChanged
        YearCB.Visible = False
        GBYear.Visible = False
    End Sub

    Private Sub rbCTViolations_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTViolations.CheckedChanged
        YearCB.Visible = False
        GBYear.Visible = False
    End Sub



End Class