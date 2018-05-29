''' <summary>
''' Functions that can be used to convert hex strings to dec values
''' </summary>
Public Class FieldConversions
    ''' <summary>
    ''' Simply returns the value provided, no conversion necessary.
    ''' </summary>
    Public Shared ToSimpleDecimal As Func(Of Integer, Integer) = Function(hexValue As Integer)
                                                                     Return hexValue
                                                                 End Function

    ''' <summary>
    ''' Simply returns the value provided, no conversion necessary.
    ''' </summary>
    Public Shared FromSimpleDecimal As Func(Of Integer, Integer) = Function(decimalValue As Integer)
                                                                       Return decimalValue
                                                                   End Function

    ''' <summary>
    ''' Returns the hex provided as the equivalent decimal value that the user would see in-game.
    ''' </summary>
    Public Shared ToCoreDecimal As Func(Of Integer, Integer) = Function(hexValue As Integer)
                                                                   Return (hexValue - 1) / 8
                                                               End Function

    ''' <summary>
    ''' Returns the decimal provided as the equivalent representation that would occur in the save file.
    ''' </summary>
    Public Shared FromCoreDecimal As Func(Of Integer, Integer) = Function(decimalValue As Integer)
                                                                     Return (decimalValue * 8) + 1
                                                                 End Function
End Class
