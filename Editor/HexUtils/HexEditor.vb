Public Class HexEditor
    ''' <summary>
    ''' Starts at the offset given, then converts each byte into a hex string.
    ''' </summary>
    ''' <param name="fileBytes">The data to read from.</param>
    ''' <param name="info">The offset to look for and the number of bytes to read.</param>
    ''' <returns>The read bytes, converted into a usable value for the end-user.</returns>
    Public Shared Function ReadAsDecimal(fileBytes As Byte(), info As HexDataInfo) As Integer
        Dim invertedHex = ReadHexData(fileBytes, info)
        Dim correctedHex As String = String.Empty
        For Each hexByte In invertedHex.Reverse()
            correctedHex += String.Format("{0:x2}", hexByte)
        Next

        Dim value = Convert.ToUInt32(correctedHex, 16)
        Return info.ToHumanReadableValue(value)
    End Function

    ''' <summary>
    ''' Starts at the offset given, then converts each byte into a hex string.
    ''' </summary>
    ''' <param name="fileBytes">The data to read from.</param>
    ''' <param name="info">The offset to look for and the number of bytes to read.</param>
    ''' <returns>Each byte read as a hexadecimal string.</returns>
    Public Shared Function ReadHexData(fileBytes As Byte(), info As HexDataInfo) As Byte()
        Return ReadHexDataAtOffset(fileBytes, info.Offset, info.Size)
    End Function

    ''' <summary>
    ''' Starts at the offset given, then converts each byte into a hex string.
    ''' </summary>
    ''' <param name="fileBytes">The data to read from.</param>
    ''' <param name="offset">The offset to start at.</param>
    ''' <param name="bytesToRead">The number of bytes to read.</param>
    ''' <returns>Each byte read as a hexadecimal string.</returns>
    Public Shared Function ReadHexDataAtOffset(fileBytes As Byte(), offset As Integer, bytesToRead As Integer) As Byte()
        Return fileBytes.Skip(offset).Take(bytesToRead).ToArray()
    End Function

    ''' <summary>
    ''' Modifies the provided data with the given value.
    ''' </summary>
    ''' <param name="fileBytes">The data to write to.</param>
    ''' <param name="info">The offset to look for.</param>
    ''' <param name="value">The number to save.</param>
    Public Shared Sub SaveDecimalValue(fileBytes As Byte(), info As HexDataInfo, value As Integer)
        Dim correctedDecimal = info.ToSaveFileValue(value)
        Dim hexString = String.Format("{0:x2}", correctedDecimal)
        Dim correctedLen = hexString.Length + (hexString.Length Mod 2)
        hexString = hexString.PadLeft(correctedLen, "0")

        Dim hexVals As New List(Of Byte)
        While hexString.Length > 0
            Dim charIndex = Math.Max(hexString.Length - 2, 0)
            Dim numCharsToRead = Math.Min(2, hexString.Length)
            Dim singleByteStr = hexString.Substring(charIndex, numCharsToRead)
            Dim asByte As Byte = Convert.ToByte(singleByteStr, 16)
            hexString = hexString.Substring(0, charIndex)
            hexVals.Add(asByte)
        End While

        SaveHexData(fileBytes, info, hexVals.ToArray())
    End Sub


    ''' <summary>
    ''' Modifies the provided byte array with the values provided.
    ''' </summary>
    ''' <param name="fileBytes">The data to write to.</param>
    ''' <param name="info">The offset to look for.</param>
    ''' <param name="bytesToSave">The bytes to save.</param>
    Public Shared Sub SaveHexData(fileBytes As Byte(), info As HexDataInfo, bytesToSave As Byte())
        SaveHexDataAtOffset(fileBytes, info.Offset, bytesToSave)
    End Sub

    ''' <summary>
    ''' Modifies the provided byte array with the values provided.
    ''' </summary>
    ''' <param name="fileBytes">The data to write to.</param>
    ''' <param name="offset">The offset to start at.</param>
    ''' <param name="bytesToSave">The bytes to save.</param>
    Public Shared Sub SaveHexDataAtOffset(fileBytes As Byte(), offset As Integer, bytesToSave As Byte())
        For i = 0 To bytesToSave.Length - 1
            fileBytes(offset + i) = bytesToSave(i)
        Next
    End Sub
End Class
