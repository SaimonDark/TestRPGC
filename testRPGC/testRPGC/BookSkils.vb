Public Class BookSkils
    ReadOnly _txtRGB As New SystemColorConsole

  Public Sub Skils(ByVal _skill As String, ByVal _damage As Single, ByVal _lvl As Integer, ByVal _perkstat As Single) 'Вывод информации об умении.

    Select Case _lvl
      Case 0
        _txtRGB.TxtRGB("DarkGray", "Black", "  |" & _skill, True)
      Case Else
        _txtRGB.TxtRGB("White", "Black", "  |" & _skill & "  Уровень: " & _lvl & "   Урон: " & _damage & If(_perkstat > 0, " +" & _perkstat, " "), True)
    End Select
  End Sub



End Class
