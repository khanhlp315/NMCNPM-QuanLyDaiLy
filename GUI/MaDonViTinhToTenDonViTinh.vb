﻿Imports System.Globalization
Imports BUS


Public Class MaDonViTinhToTenDonViTinh
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Return DonViTinhBUS.SelectDonViTinhByMaDonViTinh(value.ToString()).TenDonViTinh
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException
    End Function
End Class