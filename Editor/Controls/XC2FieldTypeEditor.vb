Imports System.ComponentModel

''' <summary>
''' A dropdown and field combo.
''' </summary>
Public Class XC2FieldTypeEditor
    Inherits UserControl
    Implements INotifyPropertyChanged

    Private Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public ReadFromFile As Func(Of HexDataInfo, Integer) = Nothing
    Public SaveToFile As Action(Of HexDataInfo, Integer) = Nothing

    ''' <summary>
    ''' Field type label
    ''' </summary>
    Public Property FieldTypeLabel As String
        Get
            Return _fieldTypeLabel
        End Get
        Set(value As String)
            _fieldTypeLabel = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(FieldTypeLabel)))
        End Set
    End Property
    Private _fieldTypeLabel As String = Nothing

    ''' <summary>
    ''' Field value label
    ''' </summary>
    Public Property FieldValueLabel As String
        Get
            Return _fieldValueLabel
        End Get
        Set(value As String)
            _fieldValueLabel = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(FieldValueLabel)))
        End Set
    End Property
    Private _fieldValueLabel As String = "Value"

    ''' <summary>
    ''' Whether a file is loaded and that file can be edited.
    ''' </summary>
    Public Property CanEdit As Boolean
        Get
            Return _canEdit
        End Get
        Set(value As Boolean)
            _canEdit = value
            LoadValueFromFile(TypeDropdown, EventArgs.Empty)
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(CanEdit)))
        End Set
    End Property
    Private _canEdit As Boolean = False

    ''' <summary>
    ''' The player info value being edited.
    ''' </summary>
    Public Property CurrentValue As String
        Get
            Return _currentValue
        End Get
        Set(value As String)
            _currentValue = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(CurrentValue)))
        End Set
    End Property
    Private _currentValue As String = Nothing

    ''' <summary>
    ''' The values that can be selected from the dropdown.
    ''' </summary>
    Public Property DataSource As Dictionary(Of XC2DataType, HexDataInfo)
        Get
            Return _dataSource
        End Get
        Set(value As Dictionary(Of XC2DataType, HexDataInfo))
            _dataSource = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(DataSource)))
        End Set
    End Property
    Private _dataSource As Dictionary(Of XC2DataType, HexDataInfo) = Nothing

    ''' <summary>
    ''' Sets the data properties of this control.
    ''' </summary>
    Public Sub Configure(ds As Dictionary(Of XC2DataType, HexDataInfo), label As String, readFn As Func(Of HexDataInfo, Integer), saveFn As Action(Of HexDataInfo, Integer))
        DataSource = ds
        TypeDropdown.DataSource = DataSource.Keys.ToList()
        FieldTypeLabel = label
        ReadFromFile = readFn
        SaveToFile = saveFn
    End Sub

    ''' <summary>
    ''' Handles this control loading.
    ''' </summary>
    Private Sub OnInitialLoad(sender As XC2FieldTypeEditor, e As EventArgs) Handles MyBase.Load
        TypeDropdown.DataBindings.Add(New Binding(NameOf(ComboBox.Enabled), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        ValueDropdown.DataBindings.Add(New Binding(NameOf(TextBox.Text), Me, NameOf(CurrentValue), True, DataSourceUpdateMode.OnPropertyChanged))
        ValueDropdown.DataBindings.Add(New Binding(NameOf(TextBox.Enabled), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        TypeLabel.DataBindings.Add(New Binding(NameOf(Label.Text), Me, NameOf(FieldTypeLabel), True, DataSourceUpdateMode.OnPropertyChanged))
        ValueLabel.DataBindings.Add(New Binding(NameOf(Label.Text), Me, NameOf(FieldValueLabel), True, DataSourceUpdateMode.OnPropertyChanged))

        UpdateBtn.DataBindings.Add(New Binding(NameOf(Button.Enabled), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    ''' <summary>
    ''' Loads the field from the save file data.
    ''' </summary>
    Private Sub LoadValueFromFile(cbox As ComboBox, e As EventArgs) Handles TypeDropdown.SelectedIndexChanged
        If CanEdit Then
            Dim selectedFieldType = TypeDropdown.SelectedValue
            Dim fieldInfo = DataSource(selectedFieldType)
            CurrentValue = ReadFromFile(fieldInfo)
        End If
    End Sub

    ''' <summary>
    ''' Saves the value on the UI back to the save file data.
    ''' </summary>
    Private Sub SaveValueToFile(btn As Button, e As EventArgs) Handles UpdateBtn.Click
        Dim selectedFieldType = TypeDropdown.SelectedValue
        Dim fieldInfo = DataSource(selectedFieldType)
        Dim parsedVal = Convert.ToInt32(CurrentValue)
        SaveToFile(fieldInfo, parsedVal)
    End Sub

    ''' <summary>
    ''' Tell the UI to update after a value was programatically changed. If this is not called, the UI will not know a value has updated.
    ''' </summary>
    Private Sub RaisePropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub
End Class
