''' <summary>
''' Represents a section of data in the save file.
''' </summary>
Public Structure HexDataInfo
    Public Offset As Integer
    Public Size As Integer
    Public ToSaveFileValue As Func(Of Integer, Integer)
    Public ToHumanReadableValue As Func(Of Integer, Integer)
End Structure
