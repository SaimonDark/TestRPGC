Public Class Bagpack
  ReadOnly _txtRGB As New SystemColorConsole
  Public _equipbag(5), _chekbagitem As String
  Public _getbag As Integer
  Public Sub Perechen()
    '_statsGet(1) = _statshero(1) 'Сила
    '_statsGet(2) = _statshero(2) 'Интеллект
    '_statsGet(3) = _statshero(3) 'Защита
    '_statsGet(4) = _statshero(4) 'Ловкость
    '_statsGet(5) = _statshero(5) 'Точность
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
      _txtRGB.TxtRGB("DarkGray", "Black", "    Оружие│ ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(1) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "    Голова│ ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(2) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "      Тело│ ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(3) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "  Перчатки│ ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(4) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "     Обувь│ ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(5) & "         ", True)
      _txtRGB.TxtRGB("Red", "Black", "  ________________________________________________________________________", True)
      Console.Write("    ")
      Visbag(_bagitem(1))
      Console.Write(vbTab & vbTab)
      Visbag(_bagitem(2))
      Console.WriteLine()
      Console.Write("    ")
      Visbag(_bagitem(3))
      Console.Write(vbTab & vbTab)
      Visbag(_bagitem(4))
      Console.WriteLine()
      Console.Write("    ")
      Visbag(_bagitem(5))
      Console.Write(vbTab & vbTab)
      Visbag(_bagitem(6))
      Console.WriteLine()
      Console.Write("    ")
      Visbag(_bagitem(7))
      Console.Write(vbTab & vbTab)
      Visbag(_bagitem(8))
      Console.WriteLine()
      Console.Write("    ")
      Visbag(_bagitem(9))
      Console.Write(vbTab & vbTab)
      Visbag(_bagitem(10))
      Console.WriteLine()
      _txtRGB.TxtRGB("Red", "Black", "  ________________________________________________________________________", True)
      Console.Write("  │ ")
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
          GetItem()
      End Select
    End While

  End Sub

  Private Sub GetItem()  'Метод замены предметов.
    Dim _getGetItem As String
    _getGetItem = 0
    While _getGetItem <> 7
      Console.SetCursorPosition(0, 6)
      _txtRGB.TxtRGB("DarkGray", "Black", "    Оружие│ 1. ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(1) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "    Голова│ 2. ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(2) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "      Тело│ 3. ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(3) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "  Перчатки│ 4. ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(4) & "         ", True)
      _txtRGB.TxtRGB("DarkGray", "Black", "     Обувь│ 5. ", False)
      _txtRGB.TxtRGB("White", "Black", _equipbag(5) & "         ", True)
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
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Console.WriteLine("                                                                          ")
      Dim infogetnatbag As ConsoleKeyInfo = Console.ReadKey()
      Try
        _getGetItem = infogetnatbag.Key - 48
        Select Case _getGetItem
          Case 1
            CheckGetItem(1)
            _getGetItem = 7
          Case 2
            CheckGetItem(2)
            _getGetItem = 7
          Case 3
            CheckGetItem(3)
            _getGetItem = 7
          Case 4
            CheckGetItem(4)
            _getGetItem = 7
          Case 5
            CheckGetItem(5)
            _getGetItem = 7
        End Select
      Catch ex As Exception
      End Try
    End While
  End Sub

  'Замена предмета
  Private Sub CheckGetItem(ByVal _itemchekget As Integer)
    Dim _getChekGetItem As String
    _getChekGetItem = 0
    While _getChekGetItem <> 12
      Console.SetCursorPosition(0, 12)
      Console.Write("   1.")
      Visbag(_bagitem(1))
      Console.Write(vbTab & vbTab & "2.")
      Visbag(_bagitem(2))
      Console.WriteLine()
      Console.Write("   3.")
      Visbag(_bagitem(3))
      Console.Write(vbTab & vbTab & "4.")
      Visbag(_bagitem(4))
      Console.WriteLine()
      Console.Write("   5.")
      Visbag(_bagitem(5))
      Console.Write(vbTab & vbTab & "6.")
      Visbag(_bagitem(6))
      Console.WriteLine()
      Console.Write("   7.")
      Visbag(_bagitem(7))
      Console.Write(vbTab & vbTab & "8.")
      Visbag(_bagitem(8))
      Console.WriteLine()
      Console.Write("   9.")
      Visbag(_bagitem(9))
      Console.Write(vbTab & vbTab & "0.")
      Visbag(_bagitem(10))
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
      Dim infogetchecknatbag As ConsoleKeyInfo = Console.ReadKey()
      Try
        _getChekGetItem = infogetchecknatbag.Key - 48
        Select Case _getChekGetItem
          Case 1
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(1)
                _bagitem(1) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(1)
                _bagitem(1) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(1)
                _bagitem(1) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(1)
                _bagitem(1) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(1)
                _bagitem(1) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 2
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(2)
                _bagitem(2) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(2)
                _bagitem(2) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(2)
                _bagitem(2) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(2)
                _bagitem(2) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(2)
                _bagitem(2) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 3
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(3)
                _bagitem(3) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(3)
                _bagitem(3) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(3)
                _bagitem(3) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(3)
                _bagitem(3) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(3)
                _bagitem(3) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 4
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(4)
                _bagitem(4) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(4)
                _bagitem(4) = _equipbag(2)
                _equipbag(2) = _chekbagitem

              Case 3
                _chekbagitem = _bagitem(4)
                _bagitem(4) = _equipbag(3)
                _equipbag(3) = _chekbagitem

              Case 4
                _chekbagitem = _bagitem(4)
                _bagitem(4) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(4)
                _bagitem(4) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 5
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(5)
                _bagitem(5) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(5)
                _bagitem(5) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(5)
                _bagitem(5) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(5)
                _bagitem(5) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(5)
                _bagitem(5) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 6
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(6)
                _bagitem(6) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(6)
                _bagitem(6) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(6)
                _bagitem(6) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(6)
                _bagitem(6) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(6)
                _bagitem(6) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 7
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(7)
                _bagitem(7) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(7)
                _bagitem(7) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(7)
                _bagitem(7) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(7)
                _bagitem(7) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(7)
                _bagitem(7) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 8
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(8)
                _bagitem(8) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(8)
                _bagitem(8) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(8)
                _bagitem(8) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(8)
                _bagitem(8) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(8)
                _bagitem(8) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 9
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(9)
                _bagitem(9) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(9)
                _bagitem(9) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(9)
                _bagitem(9) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(9)
                _bagitem(9) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(9)
                _bagitem(9) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
          Case 0
            Select Case _itemchekget
              Case 1
                _chekbagitem = _bagitem(10)
                _bagitem(10) = _equipbag(1)
                _equipbag(1) = _chekbagitem
              Case 2
                _chekbagitem = _bagitem(10)
                _bagitem(10) = _equipbag(2)
                _equipbag(2) = _chekbagitem
              Case 3
                _chekbagitem = _bagitem(10)
                _bagitem(10) = _equipbag(3)
                _equipbag(3) = _chekbagitem
              Case 4
                _chekbagitem = _bagitem(10)
                _bagitem(10) = _equipbag(4)
                _equipbag(4) = _chekbagitem
              Case 5
                _chekbagitem = _bagitem(10)
                _bagitem(10) = _equipbag(5)
                _equipbag(5) = _chekbagitem
            End Select
        End Select
        DelletItem(_bagitem(_getChekGetItem))
        StayItem(_equipbag(_itemchekget))
        _chekbagitem = Nothing
        _getChekGetItem = 12
      Catch ex As Exception
      End Try
    End While
    Console.SetCursorPosition(0, 6)
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
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    Console.WriteLine("                                                                          ")
    _equip(1) = _equipbag(1)
    _equip(2) = _equipbag(2)
    _equip(3) = _equipbag(3)
    _equip(4) = _equipbag(4)
    _equip(5) = _equipbag(5)
  End Sub

  'Метод осмотра описания предмета.
  Public Sub SeenItem()
    Dim _getseenitem As String
    _getseenitem = 0
    While _getseenitem <> 12
      Console.SetCursorPosition(0, 12)
      Console.Write("   1.")
      Visbag(_bagitem(1))
      Console.Write(vbTab & vbTab & "2.")
      Visbag(_bagitem(2))
      Console.WriteLine()
      Console.Write("   3.")
      Visbag(_bagitem(3))
      Console.Write(vbTab & vbTab & "4.")
      Visbag(_bagitem(4))
      Console.WriteLine()
      Console.Write("   5.")
      Visbag(_bagitem(5))
      Console.Write(vbTab & vbTab & "6.")
      Visbag(_bagitem(6))
      Console.WriteLine()
      Console.Write("   7.")
      Visbag(_bagitem(7))
      Console.Write(vbTab & vbTab & "8.")
      Visbag(_bagitem(8))
      Console.WriteLine()
      Console.Write("   9.")
      Visbag(_bagitem(9))
      Console.Write(vbTab & vbTab & "0.")
      Visbag(_bagitem(10))
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
            Vivodinf(_bagitem(1))
            Console.ReadLine()
            _getseenitem = 12
          Case 2
            Vivodinf(_bagitem(2))
            Console.ReadLine()
            _getseenitem = 12
          Case 3
            Vivodinf(_bagitem(3))
            Console.ReadLine()
            _getseenitem = 12
          Case 4
            Vivodinf(_bagitem(4))
            Console.ReadLine()
            _getseenitem = 12
          Case 5
            Vivodinf(_bagitem(5))
            Console.ReadLine()
            _getseenitem = 12
          Case 6
            Vivodinf(_bagitem(6))
            Console.ReadLine()
            _getseenitem = 12
          Case 7
            Vivodinf(_bagitem(7))
            Console.ReadLine()
            _getseenitem = 12
          Case 8
            Vivodinf(_bagitem(8))
            Console.ReadLine()
            _getseenitem = 12
          Case 9
            Vivodinf(_bagitem(9))
            Console.ReadLine()
            _getseenitem = 12
          Case 0
            Vivodinf(_bagitem(10))
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
        _txtRGB.TxtRGB("White", "Black", "   │Ржавый кованый меч│     ", True)
      Case "Ржавый двуручный меч"
        _txtRGB.TxtRGB("White", "Black", "   │Ржавый двуручный меч│     ", True)

      Case "Ржавый стальной кинжал"
        _txtRGB.TxtRGB("White", "Black", "   │Ржавый стальной кинжал│     ", True)

      Case "Ржавый короткий кинжал"
        _txtRGB.TxtRGB("White", "Black", "   │Ржавый короткий кинжал│     ", True)

      Case "Стальной меч"
        _txtRGB.TxtRGB("White", "Black", "   │Стальной меч│     ", True)

      Case "Гнутый двуручный меч"
        _txtRGB.TxtRGB("White", "Black", "   │Гнутый двуручный меч│     ", True)

      Case "Заляпаный тесак"
        _txtRGB.TxtRGB("White", "Black", "   │Заляпаный тесак│     ", True)

      Case "Нож для мяса"
        _txtRGB.TxtRGB("White", "Black", "   │Нож для мяса│     ", True)

      Case "Острый нож"
        _txtRGB.TxtRGB("White", "Black", "   │Острый нож│     ", True)

      Case "Медный кинжал"
        _txtRGB.TxtRGB("White", "Black", "   │Медный кинжал│     ", True)

      Case "Ветхий скипетр"
        _txtRGB.TxtRGB("White", "Black", "   │Ветхий скипетр│     ", True)

      Case "Треснутая палочка"
        _txtRGB.TxtRGB("White", "Black", "   │Треснутая палочка│     ", True)

      Case "Треснутый посох"
        _txtRGB.TxtRGB("White", "Black", "   │Треснутый посох│     ", True)

      Case "Жезл новичка"
        _txtRGB.TxtRGB("White", "Black", "   │Жезл новичка│     ", True)

      Case "Старый посох"
        _txtRGB.TxtRGB("White", "Black", "   │Старый посох│     ", True)

      Case "Медный жезл"
        _txtRGB.TxtRGB("White", "Black", "   │Медный жезл│     ", True)

      Case "Палочка ученика"
        _txtRGB.TxtRGB("White", "Black", "   │Палочка ученика│     ", True)

      Case "Палочка из бурейника"
        _txtRGB.TxtRGB("White", "Black", "   │Палочка из бурейника│     ", True)

      Case "Поддержанный посох"
        _txtRGB.TxtRGB("White", "Black", "   │Поддержанный посох│     ", True)

      Case "Фальшивый скипетр"
        _txtRGB.TxtRGB("White", "Black", "   │Фальшивый скипетр│     ", True)

      Case "Лук лесника"
        _txtRGB.TxtRGB("White", "Black", "   │Лук лесника│     ", False)

      Case "Лук ученика"
        _txtRGB.TxtRGB("White", "Black", "   │Лук ученика│     ", False)

      Case "Лук из бурейника"
        _txtRGB.TxtRGB("White", "Black", "   │Лук из бурейника│     ", False)

      Case "Треснутый лук"
        _txtRGB.TxtRGB("White", "Black", "   │Треснутый лук│     ", False)

      Case "Старый арбалет"
        _txtRGB.TxtRGB("White", "Black", "   │Старый арбалет│     ", False)

      Case "Старый лук"
        _txtRGB.TxtRGB("White", "Black", "   │Старый лук│     ", False)

      Case "Прогнивший лук"
        _txtRGB.TxtRGB("White", "Black", "   │Прогнувшийся лук│     ", False)

      Case "Треснутый арбалет"
        _txtRGB.TxtRGB("White", "Black", "   │Треснутый арбалет│     ", False)

      Case "Самодельный лук"
        _txtRGB.TxtRGB("White", "Black", "   │Самодельный лук│     ", False)

      Case "Большой скрипучий лук"
        _txtRGB.TxtRGB("White", "Black", "   │Большой срипучий лук│     ", False)

      Case "Короткие кинжалы"
        _txtRGB.TxtRGB("White", "Black", "   │Короткий кинжал│     ", False)

      Case "Короткий ржавый меч"
        _txtRGB.TxtRGB("White", "Black", "   │Короткий ржавый меч│     ", False)

      Case "Короткий лук"
        _txtRGB.TxtRGB("White", "Black", "   │Короткий лук│     ", False)

      Case "Обрубок двуручного меча"
        _txtRGB.TxtRGB("White", "Black", "   │Обрубок двуручного меча│     ", False)

      Case "Ядовитый сломаный дротик"
        _txtRGB.TxtRGB("White", "Black", "   │Ядовитый сломаный дротик│     ", False)

      Case "Сломаная рапира"
        _txtRGB.TxtRGB("White", "Black", "   │Сломаная рапира│     ", False)

      Case "Обрубок тесака"
        _txtRGB.TxtRGB("White", "Black", "   │Обрубок тесака│     ", False)

      Case "Тупой нож"
        _txtRGB.TxtRGB("White", "Black", "   │Тупой нож│     ", False)

      Case "Гнущийся лук"
        _txtRGB.TxtRGB("White", "Black", "   │Гнущийся лук│     ", False)

      Case "Прочный кинжал"
        _txtRGB.TxtRGB("White", "Black", "   │Прочный кинжал│     ", False)

             '-------------------------------------------------------------------
      Case "Потрёпаная стёганка"
        _txtRGB.TxtRGB("White", "Black", "|Потрёпаная стёганка|", False)

      Case "Стёртые сапоги"
        _txtRGB.TxtRGB("White", "Black", "|Стёртые сапоги|", False)

      Case "Погнутые доспехи"
        _txtRGB.TxtRGB("White", "Black", "|Погнутые доспехи|", False)

      Case "Кожаные доспехи"
        _txtRGB.TxtRGB("White", "Black", "|Кожаные доспехи|", False)

      Case "Пробитый кушак"
        _txtRGB.TxtRGB("White", "Black", "|Пробитый кушак|", False)

      Case "Ржавый шлем"
        _txtRGB.TxtRGB("White", "Black", "|Ржавый шлем|", False)

      Case "Треснутое забрало"
        _txtRGB.TxtRGB("White", "Black", "|Треснутое забрало|", False)

      Case "Перчатки из тины"
        _txtRGB.TxtRGB("White", "Black", "|Перчатки из тины|", False)

      Case "Старые варежки"
        _txtRGB.TxtRGB("White", "Black", "|Старые варежки| ", False)

      Case "Прогнившие наручи"
        _txtRGB.TxtRGB("White", "Black", "|Прогнившие наручи| ", False)

      Case "Медные наручи"
        _txtRGB.TxtRGB("White", "Black", "|Медные наручи| ", False)

      Case "Медный доспех"
        _txtRGB.TxtRGB("White", "Black", "|Медный доспех| ", False)

      Case "Прочные ботинки"
        _txtRGB.TxtRGB("White", "Black", "|Прочные ботинки| ", False)

      Case "Ветхие  сапоги"
        _txtRGB.TxtRGB("White", "Black", "|Ветхие  сапоги| ", False)

      Case "Халат"
        _txtRGB.TxtRGB("White", "Black", "|Халат| ", False)

      Case "Старый балахон"
        _txtRGB.TxtRGB("White", "Black", "|Старый балахон| ", False)

      Case "Потрёпаный плащ"
        _txtRGB.TxtRGB("White", "Black", "|Потрёпаный плащ| ", False)

      Case "Изношенная мантия"
        _txtRGB.TxtRGB("White", "Black", "|Изношенная мантия| ", False)

      Case "Кожаные сандали"
        _txtRGB.TxtRGB("White", "Black", "|Кожаные сандали| ", False)

      Case "Потрёпаный колпак"
        _txtRGB.TxtRGB("White", "Black", "|Потрёпаный колпак| ", False)

      Case "Ветхое одеяние"
        _txtRGB.TxtRGB("White", "Black", "|Ветхое одеяние| ", False)

      Case "Исхудалые ботинки"
        _txtRGB.TxtRGB("White", "Black", "|Исхудалые ботинки| ", False)

      Case "Старые ритуальные перчатки"
        _txtRGB.TxtRGB("White", "Black", "|Старые ритуальные перчатки| ", False)

      Case "Дырявое пончо"
        _txtRGB.TxtRGB("White", "Black", "|Дырявое пончо| ", False)

      Case "Крепкие одеяния"
        _txtRGB.TxtRGB("White", "Black", "|Крепкие одеяния| ", False)

    End Select

  End Sub

  'Отображение предметов в ячейках инвентаря
  Private Sub Visbag(ByVal _bagchek As String)
    If _bagchek = "|Пусто|" Then
      _txtRGB.TxtRGB("DarkGray", "Black", " |Пусто| ", False)
    Else
      Select Case _bagchek
        Case "Ржавый кованый меч"
          _txtRGB.TxtRGB("White", "Black", " │Ржавый кованый меч│ ", False)
        Case "Ржавый двуручный меч"
          _txtRGB.TxtRGB("White", "Black", " │Ржавый двуручный меч│ ", False)
        Case "Ржавый стальной кинжал"
          _txtRGB.TxtRGB("White", "Black", " │Ржавый стальной кинжал│ ", False)
        Case "Ржавый короткий кинжал"
          _txtRGB.TxtRGB("White", "Black", " │Ржавый короткий кинжал│ ", False)
        Case "Стальной меч"
          _txtRGB.TxtRGB("White", "Black", " │Стальной меч│ ", False)
        Case "Гнутый двуручный меч"
          _txtRGB.TxtRGB("White", "Black", " │Гнутый двуручный меч│ ", False)
        Case "Заляпаный тесак"
          _txtRGB.TxtRGB("White", "Black", " │Заляпаный тесак│ ", False)
        Case "Нож для мяса"
          _txtRGB.TxtRGB("White", "Black", " │Нож для мяса│ ", False)
        Case "Острый нож"
          _txtRGB.TxtRGB("White", "Black", " │Острый нож│ ", False)
        Case "Медный кинжал"
          _txtRGB.TxtRGB("White", "Black", " │Медный кинжал│ ", False)
        Case "Ветхий скипетр"
          _txtRGB.TxtRGB("White", "Black", " │Ветхий скипетр│ ", False)
        Case "Треснутая палочка"
          _txtRGB.TxtRGB("White", "Black", " │Треснутая палочка│ ", False)
        Case "Треснутый посох"
          _txtRGB.TxtRGB("White", "Black", " │Треснутый посох│ ", False)
        Case "Жезл новичка"
          _txtRGB.TxtRGB("White", "Black", " │Жезл новичка│ ", False)
        Case "Старый посох"
          _txtRGB.TxtRGB("White", "Black", " │Старый посох│ ", False)
        Case "Медный жезл"
          _txtRGB.TxtRGB("White", "Black", " │Медный жезл│ ", False)
        Case "Палочка ученика"
          _txtRGB.TxtRGB("White", "Black", " │Палочка ученика│ ", False)
        Case "Палочка из бурейника"
          _txtRGB.TxtRGB("White", "Black", " │Палочка из бурейника│ ", False)
        Case "Поддержанный посох"
          _txtRGB.TxtRGB("White", "Black", " │Поддержанный посох│ ", False)
        Case "Фальшивый скипетр"
          _txtRGB.TxtRGB("White", "Black", " │Фальшивый скипетр│ ", False)
        Case "Лук лесника"
          _txtRGB.TxtRGB("White", "Black", " │Лук лесника│ ", False)
        Case "Лук ученика"
          _txtRGB.TxtRGB("White", "Black", " │Лук ученика│     ", False)
        Case "Лук из бурейника"
          _txtRGB.TxtRGB("White", "Black", " │Лук из бурейника│     ", False)
        Case "Треснутый лук"
          _txtRGB.TxtRGB("White", "Black", " │Треснутый лук│     ", False)
        Case "Старый арбалет"
          _txtRGB.TxtRGB("White", "Black", " │Старый арбалет│     ", False)
        Case "Старый лук"
          _txtRGB.TxtRGB("White", "Black", " │Старый лук│     ", False)
        Case "Прогнивший лук"
          _txtRGB.TxtRGB("White", "Black", " │Прогнувшийся лук│     ", False)
        Case "Треснутый арбалет"
          _txtRGB.TxtRGB("White", "Black", " │Треснутый арбалет│     ", False)
        Case "Самодельный лук"
          _txtRGB.TxtRGB("White", "Black", " │Самодельный лук│     ", False)
        Case "Большой скрипучий лук"
          _txtRGB.TxtRGB("White", "Black", " │Большой срипучий лук│     ", False)
        Case "Короткие кинжалы"
          _txtRGB.TxtRGB("White", "Black", " │Короткий кинжал│     ", False)
        Case "Короткий ржавый меч"
          _txtRGB.TxtRGB("White", "Black", " │Короткий ржавый меч│     ", False)
        Case "Короткий лук"
          _txtRGB.TxtRGB("White", "Black", " │Короткий лук│     ", False)
        Case "Обрубок двуручного меча"
          _txtRGB.TxtRGB("White", "Black", " │Обрубок двуручного меча│     ", False)
        Case "Ядовитый сломаный дротик"
          _txtRGB.TxtRGB("White", "Black", " │Ядовитый сломаный дротик│     ", False)
        Case "Сломаная рапира"
          _txtRGB.TxtRGB("White", "Black", " │Сломаная рапира│     ", False)
        Case "Обрубок тесака"
          _txtRGB.TxtRGB("White", "Black", " │Обрубок тесака│     ", False)
        Case "Тупой нож"
          _txtRGB.TxtRGB("White", "Black", " │Тупой нож│     ", False)
        Case "Гнущийся лук"
          _txtRGB.TxtRGB("White", "Black", " │Гнущийся лук│     ", False)
        Case "Прочный кинжал"
          _txtRGB.TxtRGB("White", "Black", " │Прочный кинжал│     ", False)
          '-------------------------------------------------------------------
        Case "Потрёпаная стёганка"
          _txtRGB.TxtRGB("White", "Black", " |Потрёпаная стёганка|", False)
        Case "Стёртые сапоги"
          _txtRGB.TxtRGB("White", "Black", " |Стёртые сапоги|", False)
        Case "Погнутые доспехи"
          _txtRGB.TxtRGB("White", "Black", " |Погнутые доспехи|", False)
        Case "Кожаные доспехи"
          _txtRGB.TxtRGB("White", "Black", " |Кожаные доспехи|", False)
        Case "Пробитый кушак"
          _txtRGB.TxtRGB("White", "Black", " |Пробитый кушак|", False)
        Case "Ржавый шлем"
          _txtRGB.TxtRGB("White", "Black", " |Ржавый шлем|", False)
        Case "Треснутое забрало"
          _txtRGB.TxtRGB("White", "Black", " |Треснутое забрало|", False)
        Case "Перчатки из тины"
          _txtRGB.TxtRGB("White", "Black", " |Перчатки из тины|", False)
        Case "Старые варежки"
          _txtRGB.TxtRGB("White", "Black", " |Старые варежки| ", False)
        Case "Прогнившие наручи"
          _txtRGB.TxtRGB("White", "Black", " |Прогнившие наручи| ", False)
        Case "Медные наручи"
          _txtRGB.TxtRGB("White", "Black", " |Медные наручи| ", False)
        Case "Медный доспех"
          _txtRGB.TxtRGB("White", "Black", " |Медный доспех| ", False)
        Case "Прочные ботинки"
          _txtRGB.TxtRGB("White", "Black", " |Прочные ботинки| ", False)
        Case "Ветхие  сапоги"
          _txtRGB.TxtRGB("White", "Black", " |Ветхие  сапоги| ", False)
        Case "Халат"
          _txtRGB.TxtRGB("White", "Black", " |Халат| ", False)
        Case "Старый балахон"
          _txtRGB.TxtRGB("White", "Black", " |Старый балахон| ", False)
        Case "Потрёпаный плащ"
          _txtRGB.TxtRGB("White", "Black", " |Потрёпаный плащ| ", False)
        Case "Изношенная мантия"
          _txtRGB.TxtRGB("White", "Black", " |Изношенная мантия| ", False)
        Case "Кожаные сандали"
          _txtRGB.TxtRGB("White", "Black", " |Кожаные сандали| ", False)
        Case "Потрёпаный колпак"
          _txtRGB.TxtRGB("White", "Black", " |Потрёпаный колпак| ", False)
        Case "Ветхое одеяние"
          _txtRGB.TxtRGB("White", "Black", " |Ветхое одеяние| ", False)
        Case "Исхудалые ботинки"
          _txtRGB.TxtRGB("White", "Black", " |Исхудалые ботинки| ", False)
        Case "Старые ритуальные перчатки"
          _txtRGB.TxtRGB("White", "Black", " |Старые ритуальные перчатки| ", False)
        Case "Дырявое пончо"
          _txtRGB.TxtRGB("White", "Black", " |Дырявое пончо| ", False)
        Case "Крепкие одеяния"
          _txtRGB.TxtRGB("White", "Black", " |Крепкие одеяния| ", False)
      End Select
    End If
  End Sub
  '_statsGet(1) = _statshero(1) 'Сила
  '_statsGet(2) = _statshero(2) 'Интеллект
  '_statsGet(3) = _statshero(3) 'Защита
  '_statsGet(4) = _statshero(4) 'Ловкость
  '_statsGet(5) = _statshero(5) 'Точность
  Private Sub DelletItem(ByVal _delItem As String)
    Select Case _delItem
      '------------Воин-------------
      Case "Ржавый кованый меч"
        _statshero(1) -= 10
      Case "Ржавый двуручный меч"
        _statshero(1) -= 12
      Case "Ржавый стальной кинжал"
        _statshero(1) -= 9
      Case "Ржавый короткий кинжал"
        _statshero(1) -= 8
      Case "Стальной меч"
        _statshero(1) -= 25
      Case "Гнутый двуручный меч"
        _statshero(1) -= 15
      Case "Заляпаный тесак"
        _statshero(1) -= 24
      Case "Нож для мяса"
        _statshero(1) -= 9
      Case "Острый нож"
        _statshero(1) -= 10
      Case "Медный кинжал"
        _statshero(1) -= 17
        '-----------------------------
      Case "Потрёпаная стёганка"
        _statshero(3) -= 5
        _statshero(4) -= 5
      Case "Стёртые сапоги"

      Case "Погнутые доспехи"

      Case "Кожаные доспехи"

      Case "Пробитый кушак"

      Case "Ржавый шлем"

      Case "Треснутое забрало"

      Case "Перчатки из тины"
        _statshero(5) -= 1
        _statshero(4) -= 5
      Case "Старые варежки"

      Case "Прогнившие наручи"

      Case "Медные наручи"

      Case "Медный доспех"

      Case "Прочные ботинки"

      Case "Ветхие  сапоги"


         '------------Маг-------------
      Case "Старый посох"
        _statshero(2) -= 10
      Case "Ветхий скипетр"
        _statshero(2) -= 11
      Case "Треснутая палочка"
        _statshero(2) -= 9
      Case "Треснутый посох"
        _statshero(2) -= 13
      Case "Жезл новичка"
        _statshero(2) -= 11
      Case "Медный жезл"
        _statshero(2) -= 15
      Case "Палочка ученика"
        _statshero(2) -= 13
      Case "Палочка из бурейника"
        _statshero(2) -= 14
      Case "Поддержанный посох"
        _statshero(2) -= 24
      Case "Фальшивый скипетр"
        _statshero(2) -= 8
        '--------------------------
      Case "Халат"
        _statshero(3) -= 5
        _statshero(4) -= 5
      Case "Старый балахон"

      Case "Потрёпаный плащ"

      Case "Изношенная мантия"

      Case "Кожаные сандали"

      Case "Потрёпаный колпак"

      Case "Ветхое одеяние"

      Case "Исхудалые ботинки"

      Case "Старые ритуальные перчатки"

      Case "Дырявое пончо"

      Case "Крепкие одеяния"

        '------------Лучник--------
      Case "Лук лесника"
        _statshero(4) -= 5
        _statshero(5) -= 2
      Case "Лук ученика"
        _statshero(4) -= 17
        _statshero(5) -= 3
      Case "Лук из бурейника"
        _statshero(4) -= 14
        _statshero(5) -= 4
      Case "Треснутый лук"
        _statshero(4) -= 5
        _statshero(5) -= 1
      Case "Старый арбалет"
        _statshero(4) -= 22
        _statshero(5) -= 5
      Case "Старый лук"
        _statshero(4) -= 12
        _statshero(5) -= 5
      Case "Прогнивший лук"
        _statshero(4) -= 8
        _statshero(5) -= 3
      Case "Треснутый арбалет"
        _statshero(4) -= 3
        _statshero(5) -= 2
      Case "Самодельный лук"
        _statshero(4) -= 5
        _statshero(5) -= 1
      Case "Большой скрипучий лук"
        _statshero(4) -= 12
        _statshero(5) -= 4
        '-----------Плут-----------
      Case "Короткие кинжалы"
        _statshero(3) -= 5
        _statshero(5) -= 1
      Case "Короткий ржавый меч"
        _statshero(3) -= 4
        _statshero(5) -= 3
      Case "Короткий лук"
        _statshero(3) -= 2
        _statshero(5) -= 2
      Case "Обрубок двуручного меча"
        _statshero(3) -= 15
        _statshero(5) -= 4
      Case "Ядовитый сломаный дротик"
        _statshero(3) -= 16
        _statshero(5) -= 4
      Case "Сломаная рапира"
        _statshero(3) -= 5
        _statshero(5) -= 1
      Case "Обрубок тесака"
        _statshero(3) -= 14
        _statshero(5) -= 4
      Case "Тупой нож"
        _statshero(3) -= 17
        _statshero(5) -= 4
      Case "Гнущийся лук"
        _statshero(3) -= 12
        _statshero(5) -= 2
      Case "Прочный кинжал"
        _statshero(3) -= 23
        _statshero(5) -= 5
    End Select
  End Sub

  Private Sub StayItem(ByVal _STItem As String)
    Select Case _STItem
      '------------Воин-------------
      Case "Ржавый кованый меч"
        _statshero(1) += 10
      Case "Ржавый двуручный меч"
        _statshero(1) += 12
      Case "Ржавый стальной кинжал"
        _statshero(1) += 9
      Case "Ржавый короткий кинжал"
        _statshero(1) += 8
      Case "Стальной меч"
        _statshero(1) += 25
      Case "Гнутый двуручный меч"
        _statshero(1) += 15
      Case "Заляпаный тесак"
        _statshero(1) += 24
      Case "Нож для мяса"
        _statshero(1) += 9
      Case "Острый нож"
        _statshero(1) += 10
      Case "Медный кинжал"
        _statshero(1) += 17
       '-----------------------------
      Case "Потрёпаная стёганка"
        _statshero(3) += 5
        _statshero(4) += 5
      Case "Стёртые сапоги"

      Case "Погнутые доспехи"

      Case "Кожаные доспехи"

      Case "Пробитый кушак"

      Case "Ржавый шлем"

      Case "Треснутое забрало"

      Case "Перчатки из тины"
        _statshero(5) += 1
        _statshero(4) += 5
      Case "Старые варежки"

      Case "Прогнившие наручи"

      Case "Медные наручи"

      Case "Медный доспех"

      Case "Прочные ботинки"

      Case "Ветхие  сапоги"


         '------------Маг-------------
      Case "Старый посох"
        _statshero(2) += 10
      Case "Ветхий скипетр"
        _statshero(2) += 11
      Case "Треснутая палочка"
        _statshero(2) += 9
      Case "Треснутый посох"
        _statshero(2) += 13
      Case "Жезл новичка"
        _statshero(2) += 11
      Case "Медный жезл"
        _statshero(2) += 15
      Case "Палочка ученика"
        _statshero(2) += 13
      Case "Палочка из бурейника"
        _statshero(2) += 14
      Case "Поддержанный посох"
        _statshero(2) += 24
      Case "Фальшивый скипетр"
        _statshero(2) += 8
       '--------------------------
      Case "Халат"
        _statshero(3) += 5
        _statshero(4) += 5
      Case "Старый балахон"

      Case "Потрёпаный плащ"

      Case "Изношенная мантия"

      Case "Кожаные сандали"

      Case "Потрёпаный колпак"

      Case "Ветхое одеяние"

      Case "Исхудалые ботинки"

      Case "Старые ритуальные перчатки"

      Case "Дырявое пончо"

      Case "Крепкие одеяния"

        '------------Лучник--------
      Case "Лук лесника"
        _statshero(4) += 5
        _statshero(5) += 2
      Case "Лук ученика"
        _statshero(4) += 17
        _statshero(5) += 3
      Case "Лук из бурейника"
        _statshero(4) += 14
        _statshero(5) += 4
      Case "Треснутый лук"
        _statshero(4) += 5
        _statshero(5) += 1
      Case "Старый арбалет"
        _statshero(4) += 22
        _statshero(5) += 5
      Case "Старый лук"
        _statshero(4) += 12
        _statshero(5) += 5
      Case "Прогнивший лук"
        _statshero(4) += 8
        _statshero(5) += 3
      Case "Треснутый арбалет"
        _statshero(4) += 3
        _statshero(5) += 2
      Case "Самодельный лук"
        _statshero(4) += 5
        _statshero(5) += 1
      Case "Большой скрипучий лук"
        _statshero(4) += 12
        _statshero(5) += 4
        '-----------Плут-----------
      Case "Короткие кинжалы"
        _statshero(3) += 5
        _statshero(5) += 1
      Case "Короткий ржавый меч"
        _statshero(3) += 4
        _statshero(5) += 3
      Case "Короткий лук"
        _statshero(3) += 2
        _statshero(5) += 2
      Case "Обрубок двуручного меча"
        _statshero(3) += 15
        _statshero(5) += 4
      Case "Ядовитый сломаный дротик"
        _statshero(3) += 16
        _statshero(5) += 4
      Case "Сломаная рапира"
        _statshero(3) += 5
        _statshero(5) += 1
      Case "Обрубок тесака"
        _statshero(3) += 14
        _statshero(5) += 4
      Case "Тупой нож"
        _statshero(3) += 17
        _statshero(5) += 4
      Case "Гнущийся лук"
        _statshero(3) += 12
        _statshero(5) += 2
      Case "Прочный кинжал"
        _statshero(3) += 23
        _statshero(5) += 5
    End Select
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