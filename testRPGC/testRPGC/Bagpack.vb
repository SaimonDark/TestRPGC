﻿Public Class Bagpack
  ReadOnly _txtRGB As New SystemColorConsole
  Public _bag(10), _equipbag(5) As String
  Public _getbag, _statsGet(5) As Integer
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
    _statsGet(1) = _statshero(1)
    _statsGet(2) = _statshero(2)
    _statsGet(3) = _statshero(3)
    _statsGet(4) = _statshero(4)
    _statsGet(5) = _statshero(5)
    _equipbag(1) = _equip(1)
    _equipbag(2) = _equip(2)
    _equipbag(3) = _equip(3)
    _equipbag(4) = _equip(4)
    _equipbag(5) = _equip(5)
  End Sub
  Public Sub Inventary(ByVal _money As Integer)
    _getbag = 0
    While _getbag <> 3
      Console.SetCursorPosition(0, 6)
      _txtRGB.TxtRGB("DarkGray", "Black", "    Оружие| ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(1), True)
      _txtRGB.TxtRGB("DarkGray", "Black", "    Голова| ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(2), True)
      _txtRGB.TxtRGB("DarkGray", "Black", "      Тело| ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(3), True)
      _txtRGB.TxtRGB("DarkGray", "Black", "  Перчатки| ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(4), True)
      _txtRGB.TxtRGB("DarkGray", "Black", "     Обувь| ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(5), True)
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
      Console.WriteLine()
      Console.WriteLine("    ║ 1. Осмотреть                                      ")
      Console.WriteLine("    │ 2. Поменять                                       ")
      Console.WriteLine("    │ 3. Выйти                                          ")
      Console.WriteLine("    └                                                   ")
      Dim infosetbag As ConsoleKeyInfo = Console.ReadKey()
      Try
        _getbag = infosetbag.Key - 48
      Catch ex As Exception

      End Try
      Select Case _getbag
        Case 1
          SeenItem()
        Case 2

      End Select
    End While

  End Sub
  Public Sub SeenItem() 'Метод осмотра описания предмета.
    Dim _getseenitem As String
    _getseenitem = 0
    While _getseenitem <> 12
      Console.SetCursorPosition(0, 12)
      Console.Write("   1.")
      Visbag(_bag(1))
      Console.Write(vbTab & vbTab & "2.")
      Visbag(_bag(2))
      Console.WriteLine()
      Console.Write("   3.")
      Visbag(_bag(3))
      Console.Write(vbTab & vbTab & "4.")
      Visbag(_bag(4))
      Console.WriteLine()
      Console.Write("   5.")
      Visbag(_bag(5))
      Console.Write(vbTab & vbTab & "6.")
      Visbag(_bag(6))
      Console.WriteLine()
      Console.Write("   7.")
      Visbag(_bag(7))
      Console.Write(vbTab & vbTab & "8.")
      Visbag(_bag(8))
      Console.WriteLine()
      Console.Write("   9.")
      Visbag(_bag(9))
      Console.Write(vbTab & vbTab & "0.")
      Visbag(_bag(10))
      Console.WriteLine()
      _txtRGB.TxtRGB("Red", "Black", "  ________________________________________________________________________", True)
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Dim infoseenatbag As ConsoleKeyInfo = Console.ReadKey()
      Try
        _getseenitem = infoseenatbag.Key - 48
        Select Case _getseenitem
          Case 1
            Vivodinf(_bag(1))
            Console.ReadLine()
            _getseenitem = 12
          Case 2
            Vivodinf(_bag(2))
            Console.ReadLine()
            _getseenitem = 12
          Case 3
            Vivodinf(_bag(3))
            Console.ReadLine()
            _getseenitem = 12
          Case 4
            Vivodinf(_bag(4))
            Console.ReadLine()
            _getseenitem = 12
          Case 5
            Vivodinf(_bag(5))
            Console.ReadLine()
            _getseenitem = 12
          Case 6
            Vivodinf(_bag(6))
            Console.ReadLine()
            _getseenitem = 12
          Case 7
            Vivodinf(_bag(7))
            Console.ReadLine()
            _getseenitem = 12
          Case 8
            Vivodinf(_bag(8))
            Console.ReadLine()
            _getseenitem = 12
          Case 9
            Vivodinf(_bag(9))
            Console.ReadLine()
            _getseenitem = 12
          Case 0
            Vivodinf(_bag(10))
            Console.ReadLine()
            _getseenitem = 12
        End Select
      Catch ex As Exception
      End Try
    End While

  End Sub

  'Метод отображения истории предмета
  Private Sub Vivodinf(ByVal _iteminfovivod As String)
    Console.SetCursorPosition(0, 12)
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.SetCursorPosition(0, 12)
    Select Case _iteminfovivod
      Case "Ржавый кованый меч"
        _txtRGB.TxtRGB("White", "Black", "   |Ржавый кованый меч|     ", True)
      Case "Ржавый двуручный меч"
        _txtRGB.TxtRGB("White", "Black", "   |Ржавый двуручный меч|     ", True)

      Case "Ржавый стальной кинжал"
        _txtRGB.TxtRGB("White", "Black", "   |Ржавый стальной кинжал|     ", True)

      Case "Ржавый короткий кинжал"
        _txtRGB.TxtRGB("White", "Black", "   |Ржавый короткий кинжал|     ", True)

      Case "Стальной меч"
        _txtRGB.TxtRGB("White", "Black", "   |Стальной меч|     ", True)

      Case "Гнутый двуручный меч"
        _txtRGB.TxtRGB("White", "Black", "   |Гнутый двуручный меч|     ", True)

      Case "Заляпаный тесак"
        _txtRGB.TxtRGB("White", "Black", "   |Заляпаный тесак|     ", True)

      Case "Нож для мяса"
        _txtRGB.TxtRGB("White", "Black", "   |Нож для мяса|     ", True)

      Case "Острый нож"
        _txtRGB.TxtRGB("White", "Black", "   |Острый нож|     ", True)

      Case "Медный кинжал"
        _txtRGB.TxtRGB("White", "Black", "   |Медный кинжал|     ", True)

      Case "Ветхий скипетр"
        _txtRGB.TxtRGB("White", "Black", "   |Ветхий скипетр|     ", True)

      Case "Треснутая палочка"
        _txtRGB.TxtRGB("White", "Black", "   |Треснутая палочка|     ", True)

      Case "Треснутый посох"
        _txtRGB.TxtRGB("White", "Black", "   |Треснутый посох|     ", True)

      Case "Жезл новичка"
        _txtRGB.TxtRGB("White", "Black", "   |Жезл новичка|     ", True)

      Case "Крепкий жезл"
        _txtRGB.TxtRGB("White", "Black", "   |Крепкий жезл|     ", True)

      Case "Медный жезл"
        _txtRGB.TxtRGB("White", "Black", "   |Медный жезл|     ", True)

      Case "Палочка новичка"
        _txtRGB.TxtRGB("White", "Black", "   |Палочка новичка|     ", True)

      Case "Палочка из бурейника"
        _txtRGB.TxtRGB("White", "Black", "   |Палочка из бурейника|     ", True)

      Case "Поддержанный посох"
        _txtRGB.TxtRGB("White", "Black", "   |Поддержанный посох|     ", True)

      Case "Фальшивый скипетр"
        _txtRGB.TxtRGB("White", "Black", "   |Фальшивый скипетр|     ", True)

    End Select

  End Sub

  'Отображение предметов в ячейках инвентаря
  Private Sub Visbag(ByVal _bagchek As String)
    If _bagchek = "|Пусто|" Then
      _txtRGB.TxtRGB("DarkGray", "Black", " |Пусто| ", False)
    Else
      Select Case _bagchek
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
        Case "Острый нож"
          _txtRGB.TxtRGB("White", "Black", " |Острый нож| ", False)
        Case "Медный кинжал"
          _txtRGB.TxtRGB("White", "Black", " |Медный кинжал| ", False)
        Case "Ветхий скипетр"
          _txtRGB.TxtRGB("White", "Black", " |Ветхий скипетр| ", False)
        Case "Треснутая палочка"
          _txtRGB.TxtRGB("White", "Black", " |Треснутая палочка| ", False)
        Case "Треснутый посох"
          _txtRGB.TxtRGB("White", "Black", " |Треснутый посох| ", False)
        Case "Жезл новичка"
          _txtRGB.TxtRGB("White", "Black", " |Жезл новичка| ", False)
        Case "Крепкий жезл"
          _txtRGB.TxtRGB("White", "Black", " |Крепкий жезл| ", False)
        Case "Медный жезл"
          _txtRGB.TxtRGB("White", "Black", " |Медный жезл| ", False)
        Case "Палочка новичка"
          _txtRGB.TxtRGB("White", "Black", " |Палочка новичка| ", False)
        Case "Палочка из бурейника"
          _txtRGB.TxtRGB("White", "Black", " |Палочка из бурейника| ", False)
        Case "Поддержанный посох"
          _txtRGB.TxtRGB("White", "Black", " |Поддержанный посох| ", False)
        Case "Фальшивый скипетр"
          _txtRGB.TxtRGB("White", "Black", " |Фальшивый скипетр| ", False)

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