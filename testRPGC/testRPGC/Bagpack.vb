Public Class Bagpack
  ReadOnly _txtRGB As New SystemColorConsole
  Public _bag(10) As String
  Public Sub Perechen(ByVal _b1 As String, ByVal _b2 As String, ByVal _b3 As String, ByVal _b4 As String, ByVal _b5 As String, ByVal _b6 As String, ByVal _b7 As String, ByVal _b8 As String, ByVal _b9 As String, ByVal _b10 As String)
    _bag(1) = _b1
    _bag(2) = _b2
    _bag(3) = _b3
    _bag(4) = _b4
    _bag(5) = _b5
    _bag(6) = _b6
    _bag(7) = _b7
    _bag(8) = _b8
    _bag(9) = _b9
    _bag(10) = _b10
  End Sub
  Public Sub Inventary(ByVal _equip1 As String, ByVal _equip2 As String, ByVal _equip3 As String, ByVal _equip4 As String, ByVal _equip5 As String, ByVal _money As Integer)
    _txtRGB.TxtRGB("DarkGray", "Black", "    Оружие| ", False)
    _txtRGB.TxtRGB("White", "Black", _equip1, True)
    _txtRGB.TxtRGB("DarkGray", "Black", "    Голова| ", False)
    _txtRGB.TxtRGB("White", "Black", _equip2, True)
    _txtRGB.TxtRGB("DarkGray", "Black", "      Тело| ", False)
    _txtRGB.TxtRGB("White", "Black", _equip3, True)
    _txtRGB.TxtRGB("DarkGray", "Black", "  Перчатки| ", False)
    _txtRGB.TxtRGB("White", "Black", _equip4, True)
    _txtRGB.TxtRGB("DarkGray", "Black", "     Обувь| ", False)
    _txtRGB.TxtRGB("White", "Black", _equip5, True)
    _txtRGB.TxtRGB("Red", "Black", "  ________________________________________________________________________", True)
    Console.Write("    ")
    Visbag(_bag(1))
    Console.Write(vbTab & vbTab)
    Visbag(_bag(2))
    Console.WriteLine()
    Console.Write("    ")
    Visbag(_bag(3))
    Console.Write(vbTab & vbTab)
    Visbag(_bag(4))
    Console.WriteLine()
    Console.Write("    ")
    Visbag(_bag(5))
    Console.Write(vbTab & vbTab)
    Visbag(_bag(6))
    Console.WriteLine()
    Console.Write("    ")
    Visbag(_bag(7))
    Console.Write(vbTab & vbTab)
    Visbag(_bag(8))
    Console.WriteLine()
    Console.Write("    ")
    Visbag(_bag(9))
    Console.Write(vbTab & vbTab)
    Visbag(_bag(10))
    Console.WriteLine()
    _txtRGB.TxtRGB("Red", "Black", "  ________________________________________________________________________", True)
    Console.Write("  | ")
    _txtRGB.TxtRGB("Yellow", "Black", " Монет: " & _money, True)
    Console.WriteLine("  └  Флаконов жизни: " & _botleLive & "  Флаконов маны: " & _botleMana)
  End Sub

  Private Sub Visbag(ByVal _bagchek As String)
    If _bagchek = "|Пусто|" Then
      _txtRGB.TxtRGB("DarkGray", "Black", " |Пусто| ", False)
    Else
      Select Case _bagchek
        Case " "

        Case "Ржавый кованый меч"
          _txtRGB.TxtRGB("White", "Black", " |Ржавый кованый меч| ", False)
        Case "Ржавый двуручный меч"
          _txtRGB.TxtRGB("White", "Black", " |Ржавый двуручный меч| ", False)
        Case "Ржавый стальной кинжал"
          _txtRGB.TxtRGB("White", "Black", " |Ржавый стальной кинжал| ", False)
        Case "Ржавый короткий кинжал"
          _txtRGB.TxtRGB("White", "Black", " |Ржавый короткий кинжал| ", False)
        Case "Стальной меч"
          _txtRGB.TxtRGB("White", "Black", " |Стальной меч| ", False)
        Case "Гнутый двуручный меч"
          _txtRGB.TxtRGB("White", "Black", " |Гнутый двуручный меч| ", False)
        Case "Заляпаный тесак"
          _txtRGB.TxtRGB("White", "Black", " |Заляпаный тесак| ", False)
        Case "Нож для мяса"
          _txtRGB.TxtRGB("White", "Black", " |Нож для мяса| ", False)

      End Select
    End If
  End Sub
End Class


'_items(2, 1)._sellW = 100
'_items(2, 2)._sellW = 120
'_items(2, 3)._sellW = 90
'_items(2, 4)._sellW = 90
'_items(2, 5)._sellW = 250
'_items(2, 6)._sellW = 115
'_items(2, 7)._sellW = 150
'_items(2, 8)._sellW = 50