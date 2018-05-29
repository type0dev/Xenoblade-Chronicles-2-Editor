﻿''' <summary>
''' Information required to read an XC2 save file.
''' </summary>
Public Class XC2Data
    Public Shared PlayerInfoOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
        {XC2DataType.Money, New HexDataInfo With {.Offset = &H10, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Magic, New HexDataInfo With {.Offset = &H0, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
    }

    Public Shared CoreOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
        {XC2DataType.CommonItemAmount, New HexDataInfo With {.Offset = &HF627A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToCoreDecimal}},
        {XC2DataType.RareItemAmount, New HexDataInfo With {.Offset = &HF6286, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToCoreDecimal}},
        {XC2DataType.LegendaryItemAmount, New HexDataInfo With {.Offset = &H6292, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToCoreDecimal}}
    }

    Public Shared BladeInfoOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
        {XC2DataType.Trust, New HexDataInfo With {.Offset = &H5A70, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
    }

    Public Shared DriverInfoOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
       {XC2DataType.Rex_Bravery, New HexDataInfo With {.Offset = &H40, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Truth, New HexDataInfo With {.Offset = &H48, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Comp, New HexDataInfo With {.Offset = &H50, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Justice, New HexDataInfo With {.Offset = &H58, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Exp, New HexDataInfo With {.Offset = &HEC, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_HPMax, New HexDataInfo With {.Offset = &HD2, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Strength, New HexDataInfo With {.Offset = &HD4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Ether, New HexDataInfo With {.Offset = &HD6, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Dex, New HexDataInfo With {.Offset = &HD8, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Luck, New HexDataInfo With {.Offset = &HDC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Agility, New HexDataInfo With {.Offset = &HDA, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Skill_Points, New HexDataInfo With {.Offset = &HF4, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Rex_Total_Skill_Points, New HexDataInfo With {.Offset = &HF8, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Bravery, New HexDataInfo With {.Offset = &H5E0, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Truth, New HexDataInfo With {.Offset = &H5E8, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Comp, New HexDataInfo With {.Offset = &H5F0, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Justice, New HexDataInfo With {.Offset = &H5F8, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_HPMax, New HexDataInfo With {.Offset = &H672, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Stregth, New HexDataInfo With {.Offset = &H674, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Ether, New HexDataInfo With {.Offset = &H676, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Dexterity, New HexDataInfo With {.Offset = &H678, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Agility, New HexDataInfo With {.Offset = &H67A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Luck, New HexDataInfo With {.Offset = &H67C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Exp, New HexDataInfo With {.Offset = &H68C, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Skill_Points, New HexDataInfo With {.Offset = &H694, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Nia_Total_Skill_Points, New HexDataInfo With {.Offset = &H698, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Bravery, New HexDataInfo With {.Offset = &H1120, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Truth, New HexDataInfo With {.Offset = &H1128, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Comp, New HexDataInfo With {.Offset = &H1130, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Justice, New HexDataInfo With {.Offset = &H1138, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_HPMax, New HexDataInfo With {.Offset = &H1182, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Stregth, New HexDataInfo With {.Offset = &H1184, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Ether, New HexDataInfo With {.Offset = &H11B6, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Dexterity, New HexDataInfo With {.Offset = &H11B8, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Agility, New HexDataInfo With {.Offset = &H11BA, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Luck, New HexDataInfo With {.Offset = &H11BC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Exp, New HexDataInfo With {.Offset = &H11CC, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Skill_Points, New HexDataInfo With {.Offset = &H11D4, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Tora_Total_Skill_Points, New HexDataInfo With {.Offset = &H11D8, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Bravery, New HexDataInfo With {.Offset = &HB80, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Truth, New HexDataInfo With {.Offset = &HB88, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Comp, New HexDataInfo With {.Offset = &HB90, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Justice, New HexDataInfo With {.Offset = &HB98, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_HPMax, New HexDataInfo With {.Offset = &HC12, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Stregth, New HexDataInfo With {.Offset = &HC14, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Ether, New HexDataInfo With {.Offset = &HC16, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Dexterity, New HexDataInfo With {.Offset = &HC18, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Agility, New HexDataInfo With {.Offset = &HC1A, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Luck, New HexDataInfo With {.Offset = &HC1C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Exp, New HexDataInfo With {.Offset = &HC2C, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Skill_Points, New HexDataInfo With {.Offset = &HC34, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Zeke_Total_Skill_Points, New HexDataInfo With {.Offset = &HC38, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Bravery, New HexDataInfo With {.Offset = &H1C60, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Truth, New HexDataInfo With {.Offset = &H1C68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Comp, New HexDataInfo With {.Offset = &H1C70, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Justice, New HexDataInfo With {.Offset = &H1C78, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_HPMax, New HexDataInfo With {.Offset = &H1CF2, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Stregth, New HexDataInfo With {.Offset = &H1CF4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Ether, New HexDataInfo With {.Offset = &HC1CF6, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Dexterity, New HexDataInfo With {.Offset = &H1CF8, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Agility, New HexDataInfo With {.Offset = &H1CFA, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Luck, New HexDataInfo With {.Offset = &H1CFC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Exp, New HexDataInfo With {.Offset = &H1D0C, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Skill_Points, New HexDataInfo With {.Offset = &H1D14, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
       {XC2DataType.Morag_Total_Skill_Points, New HexDataInfo With {.Offset = &H1D18, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
       }


End Class
