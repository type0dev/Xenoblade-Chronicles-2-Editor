Imports System.ComponentModel
Imports System.IO

Public Class XC2MainForm
    Inherits Form
    Implements INotifyPropertyChanged

    Private Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Const FILE_DIALOG_FILTER = "Save files (*.sav)|*.sav|All files (*.*)|*.*"
    Private FilePath As String = Nothing
    Private FileBytes As Byte() = Nothing

    ''' <summary>
    ''' Whether a file is loaded and that file can be edited.
    ''' </summary>
    Public Property CanEdit As Boolean
        Get
            Return _canEdit
        End Get
        Set(value As Boolean)
            _canEdit = value
            RaisePropertyChanged(New PropertyChangedEventArgs("CanEdit"))
        End Set
    End Property
    Private _canEdit As Boolean = False

    ''' <summary>
    ''' Presents the user with an open file dialog, then loads the file they specify.
    ''' </summary>
    Private Sub OpenFile(btn As Button, e As EventArgs) Handles OpenFileBtn.Click
        Dim openDialog = New OpenFileDialog With {.Filter = FILE_DIALOG_FILTER}
        Dim dialogResult = openDialog.ShowDialog()

        If dialogResult = DialogResult.OK Then
            Try
                FilePath = openDialog.FileName
                FileBytes = File.ReadAllBytes(FilePath)
                CanEdit = True
            Catch ex As IOException
                ' Handle exception here...
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Saves the currently loaded file, overwriting the currently selected file.
    ''' </summary>
    Private Sub SaveFile(btn As Button, e As EventArgs) Handles SaveBtn.Click
        Dim dialogResult = MessageBox.Show("Are you sure you want to overwrite the currently loaded file?", "Save File", MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then
            File.WriteAllBytes(FilePath, FileBytes)
        End If
    End Sub

    ''' <summary>
    ''' Presents the user with a save file dialog, then saves the currently loaded copy of the save file to the location they specify.
    ''' </summary>
    Private Sub SaveFileAs(btn As Button, e As EventArgs) Handles SaveAsFileBtn.Click
        Dim saveDialog = New SaveFileDialog With {.Filter = FILE_DIALOG_FILTER}
        Dim dialogResult = saveDialog.ShowDialog()

        If dialogResult = DialogResult.OK Then
            FilePath = saveDialog.FileName
            File.WriteAllBytes(FilePath, FileBytes)
        End If
    End Sub

    ''' <summary>
    ''' Read bytes from file data in memory.
    ''' </summary>
    Private ReadFromFileBytes As Func(Of HexDataInfo, Integer) = Function(hexData)
                                                                     Return HexEditor.ReadAsDecimal(FileBytes, hexData)
                                                                 End Function

    ''' <summary>
    ''' Save bytes to file data in memory.
    ''' </summary>
    Private SetFileBytes As Action(Of HexDataInfo, Integer) = Sub(hexData, value)
                                                                  HexEditor.SaveDecimalValue(FileBytes, hexData, value)
                                                              End Sub

    ''' <summary>
    ''' Handles the initialization of the player info editor control.
    ''' </summary>
    Private Sub OnPlayerInfoEditorLoaded(sender As XC2FieldTypeEditor, e As EventArgs) Handles PlayerInfoEditor.Load

        PlayerInfoEditor.Configure(XC2Data.PlayerInfoOffsets, "General Player Info", ReadFromFileBytes, SetFileBytes)
        PlayerInfoEditor.DataBindings.Add(New Binding(NameOf(PlayerInfoEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        CoreEditor.Configure(XC2Data.CoreOffsets, "Cores", ReadFromFileBytes, SetFileBytes)
        CoreEditor.DataBindings.Add(New Binding(NameOf(CoreEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        BladeEditor.Configure(XC2Data.BladeInfoOffsets, "Blades", ReadFromFileBytes, SetFileBytes)
        BladeEditor.DataBindings.Add(New Binding(NameOf(BladeEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        DriverEditor.Configure(XC2Data.DriverInfoOffsets, "Drivers", ReadFromFileBytes, SetFileBytes)
        DriverEditor.DataBindings.Add(New Binding(NameOf(DriverEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        ArtWeaponPointEditor.Configure(XC2Data.ArtWeaponPointOffsets, "Driver Art WP", ReadFromFileBytes, SetFileBytes)
        ArtWeaponPointEditor.DataBindings.Add(New Binding(NameOf(ArtWeaponPointEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        MiniGameEditor.Configure(XC2Data.MiniGameOffset, "Mini Game", ReadFromFileBytes, SetFileBytes)
        MiniGameEditor.DataBindings.Add(New Binding(NameOf(MiniGameEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        WeaponCPEditor.Configure(XC2Data.WeaponChipOffset, "Weapon Chips", ReadFromFileBytes, SetFileBytes)
        WeaponCPEditor.DataBindings.Add(New Binding(NameOf(WeaponCPEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        TreasureEditor.Configure(XC2Data.TreasureBoxOffset, "Treasure Box", ReadFromFileBytes, SetFileBytes)
        TreasureEditor.DataBindings.Add(New Binding(NameOf(TreasureEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

    End Sub

    ''' <summary>
    ''' Tell the UI to update after a value was programatically changed. If this is not called, the UI will not know a value has updated.
    ''' </summary>
    Private Sub RaisePropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub

    Private Sub XC2MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OnPlayerInfoEditorLoaded(sender As Object, e As EventArgs) Handles PlayerInfoEditor.Load

    End Sub

    Private Sub BladeEditor_Load(sender As Object, e As EventArgs) Handles BladeEditor.Load, ArtWeaponPointEditor.Load

    End Sub

    Private Sub XC2FieldTypeEditor1_Load(sender As Object, e As EventArgs) Handles DriverEditor.Load

    End Sub

    Private Sub Blades_Click(sender As Object, e As EventArgs) Handles MiniGameButton.Click

        MiniGameButton.BackColor = Color.LightGray

        '''visable off for other editors'''
        If TreasureEditor.Visible = True Then
            TreasureEditor.Visible = False
        End If

        If ArtWeaponPointEditor.Visible = True Then
            ArtWeaponPointEditor.Visible = False
        End If

        If WeaponCPEditor.Visible = True Then
            WeaponCPEditor.Visible = False
        End If

        If MiniGameEditor.Visible = True Then
            MiniGameEditor.Visible = False
        Else
            MiniGameEditor.Visible = True

        End If
        If MiniGameEditor.Visible = True Then MiniGameButton.BackColor = Color.LightBlue Else MiniGameButton.BackColor = Color.LightGray

        '''turns color light blue off on other buttons'''
        WeaponCPButton.BackColor = Color.LightGray
        BladeButton.BackColor = Color.LightGray
        DriversButton.BackColor = Color.LightGray
        ArtsWPButton.BackColor = Color.LightGray
        TreasureButton.BackColor = Color.LightGray

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ArtsWPButton.Click

        ArtsWPButton.BackColor = Color.LightGray

        '''visable off for other editors'''
        If TreasureEditor.Visible = True Then
            TreasureEditor.Visible = False
        End If

        If DriverEditor.Visible = True Then
            DriverEditor.Visible = False
        End If

        If BladeEditor.Visible = True Then
            BladeEditor.Visible = False
        End If

        If MiniGameEditor.Visible = True Then
            MiniGameEditor.Visible = False
        End If

        If WeaponCPEditor.Visible = True Then
            WeaponCPEditor.Visible = False
        End If

        If ArtWeaponPointEditor.Visible = True Then
            ArtWeaponPointEditor.Visible = False
        Else
            ArtWeaponPointEditor.Visible = True

        End If

        If ArtWeaponPointEditor.Visible = True Then ArtsWPButton.BackColor = Color.LightBlue Else ArtsWPButton.BackColor = Color.LightGray

        '''turns color light blue off on other buttons'''
        WeaponCPButton.BackColor = Color.LightGray
        MiniGameButton.BackColor = Color.LightGray
        BladeButton.BackColor = Color.LightGray
        DriversButton.BackColor = Color.LightGray
        TreasureButton.BackColor = Color.LightGray

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CreditsButton.Click
        Credits.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DriversButton.Click

        DriversButton.BackColor = Color.LightGray

        '''visable off for other editors'''
        If TreasureEditor.Visible = True Then
            TreasureEditor.Visible = False
        End If

        If BladeEditor.Visible = True Then
            BladeEditor.Visible = False
        End If

        If MiniGameEditor.Visible = True Then
            MiniGameEditor.Visible = False
        End If

        If ArtWeaponPointEditor.Visible = True Then
            ArtWeaponPointEditor.Visible = False
        End If

        If WeaponCPEditor.Visible = True Then
            WeaponCPEditor.Visible = False
        End If

        If DriverEditor.Visible = True Then
            DriverEditor.Visible = False
        Else
            DriverEditor.Visible = True

        End If

        If DriverEditor.Visible = True Then DriversButton.BackColor = Color.LightBlue Else DriversButton.BackColor = Color.LightGray

        '''turns color light blue off on other buttons'''
        WeaponCPButton.BackColor = Color.LightGray
        MiniGameButton.BackColor = Color.LightGray
        BladeButton.BackColor = Color.LightGray
        ArtsWPButton.BackColor = Color.LightGray
        TreasureButton.BackColor = Color.LightGray

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BladeButton.Click

        BladeButton.BackColor = Color.LightGray

        '''visable off for other editors'''
        If TreasureEditor.Visible = True Then
            TreasureEditor.Visible = False
        End If

        If DriverEditor.Visible = True Then
            DriverEditor.Visible = False
        End If

        If MiniGameEditor.Visible = True Then
            MiniGameEditor.Visible = False
        End If

        If ArtWeaponPointEditor.Visible = True Then
            ArtWeaponPointEditor.Visible = False
        End If

        If WeaponCPEditor.Visible = True Then
            WeaponCPEditor.Visible = False
        End If

        If BladeEditor.Visible = True Then
            BladeEditor.Visible = False
        Else
            BladeEditor.Visible = True

        End If

        If BladeEditor.Visible = True Then BladeButton.BackColor = Color.LightBlue Else BladeButton.BackColor = Color.LightGray

        '''turns color light blue off on other buttons'''
        WeaponCPButton.BackColor = Color.LightGray
        MiniGameButton.BackColor = Color.LightGray
        ArtsWPButton.BackColor = Color.LightGray
        DriversButton.BackColor = Color.LightGray
        TreasureButton.BackColor = Color.LightGray

    End Sub

    Private Sub WeaponCPButton_Click(sender As Object, e As EventArgs) Handles WeaponCPButton.Click

        WeaponCPButton.BackColor = Color.LightGray

        '''visable off for other editors'''
        If TreasureEditor.Visible = True Then
            TreasureEditor.Visible = False
        End If

        If DriverEditor.Visible = True Then
            DriverEditor.Visible = False
        End If

        If BladeEditor.Visible = True Then
            BladeEditor.Visible = False
        End If

        If MiniGameEditor.Visible = True Then
            MiniGameEditor.Visible = False
        End If

        If ArtWeaponPointEditor.Visible = True Then
            ArtWeaponPointEditor.Visible = False
        End If

        '''Sets weapon editor visable on and off'''
        If WeaponCPEditor.Visible = True Then
            WeaponCPEditor.Visible = False
        Else
            WeaponCPEditor.Visible = True
        End If

        If WeaponCPEditor.Visible = True Then WeaponCPButton.BackColor = Color.LightBlue Else WeaponCPButton.BackColor = Color.LightGray

        '''turns color light blue off on other buttons'''
        MiniGameButton.BackColor = Color.LightGray
        BladeButton.BackColor = Color.LightGray
        ArtsWPButton.BackColor = Color.LightGray
        DriversButton.BackColor = Color.LightGray
        TreasureButton.BackColor = Color.LightGray

    End Sub

    Private Sub TreasureButton_Click(sender As Object, e As EventArgs) Handles TreasureButton.Click

        TreasureButton.BackColor = Color.LightGray

        If DriverEditor.Visible = True Then
            DriverEditor.Visible = False
        End If

        If BladeEditor.Visible = True Then
            BladeEditor.Visible = False
        End If

        If MiniGameEditor.Visible = True Then
            MiniGameEditor.Visible = False
        End If

        If ArtWeaponPointEditor.Visible = True Then
            ArtWeaponPointEditor.Visible = False
        End If

        '''Sets weapon editor visable on and off'''
        If TreasureEditor.Visible = True Then
            TreasureEditor.Visible = False
        Else
            TreasureEditor.Visible = True
        End If

        If TreasureEditor.Visible = True Then TreasureButton.BackColor = Color.LightBlue Else TreasureButton.BackColor = Color.LightGray

        '''turns color light blue off on other buttons'''
        WeaponCPButton.BackColor = Color.LightGray
        MiniGameButton.BackColor = Color.LightGray
        BladeButton.BackColor = Color.LightGray
        ArtsWPButton.BackColor = Color.LightGray
        DriversButton.BackColor = Color.LightGray
    End Sub
End Class


