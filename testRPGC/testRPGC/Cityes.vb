Imports testRPGC.Enemy

Public Class Cityes
  ReadOnly _txtRGB As New SystemColorConsole
  Public _hero As New Hero
  Public _map As New Map
  Public viaponRand(3) As Integer
  Structure Predmets
    Public _nameweapons, _nameprotection, _nameitems, _nameelitw, _nameelitp As String
    Public _infoWeapons, _infoprotection As String
    Public _sellW, _sellP, _sellI As Integer
  End Structure
  Public _items(10, 50) As Predmets
  Public _bag(10) As String

  Public Sub VivodCity2()
    Dim citylive, personslive, sayPerson As Integer
    While citylive <> 5
      Console.SetCursorPosition(0, 6)
      _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
      Console.WriteLine("     _______________                                             ")
      Console.WriteLine("    ║ 1. Осмотреть город                                         ")
      Console.WriteLine("    │ 2. Изучить историю                                         ")
      Console.WriteLine("    │ 3. Обратиться к жителям                                    ")
      Console.WriteLine("    │ 4. Доска гильдии авантюристов                              ")
      Console.WriteLine("    │ 5. Уйти                                                    ")
      Console.WriteLine("    └                                                            ")
      Console.ForegroundColor = ConsoleColor.Black
      Console.CursorVisible = False
      Dim infos As ConsoleKeyInfo = Console.ReadKey()
      Try
        citylive = infos.Key - 48
      Catch ex As Exception

      End Try
      Select Case citylive
        Case 1
          'Добавить карту.

        Case 2
           'Добавить раздел с сюжетом.

        Case 3
          While personslive <> 5
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Жители                                       ")
            Console.WriteLine("    ║ 1. Зельевар                                                ")
            Console.WriteLine("    │ 2. Печальный ремесленник                                   ")
            Console.WriteLine("    │ 3. Кузнец                                                  ")
            Console.WriteLine("    │ 4. Торговец                                                ")
            Console.WriteLine("    │ 5. Уйти                                                    ")
            Console.WriteLine("    └                                                            ")
            Console.ForegroundColor = ConsoleColor.Black
            Console.CursorVisible = False
            Dim infop As ConsoleKeyInfo = Console.ReadKey()
            Try
              personslive = infop.Key - 48
            Catch ex As Exception

            End Try
            Select Case personslive
              Case 1 'Зельевар
                While sayPerson <> 5
                  Personstat("Зельевар", 2)
                  Console.ForegroundColor = ConsoleColor.Black
                  Console.CursorVisible = False
                  Dim infoz As ConsoleKeyInfo = Console.ReadKey()
                  Try
                    sayPerson = infoz.Key - 48
                  Catch ex As Exception

                  End Try
                  Select Case sayPerson
                    Case 1
                      'Добавить раздел сюжета
                    Case 2 'Продажа флакона здоровья.
                      If _money > 15 Then Liveflac(2)
                    Case 3 'Продажа флакона маны.
                      If _money > 20 Then Manaflac(2)
                    Case 4
                      'Добавить раздел сюжета
                  End Select
                End While
                sayPerson = 0
              Case 2 'Печальный ремесленник
                While sayPerson <> 3
                  Personstat("Ремесленник", 2)
                  Console.ForegroundColor = ConsoleColor.Black
                  Console.CursorVisible = False
                  Dim infor As ConsoleKeyInfo = Console.ReadKey()
                  Try
                    sayPerson = infor.Key - 48
                  Catch ex As Exception

                  End Try
                  Select Case sayPerson
                    Case 1
                      'Добавить раздел сюжета
                    Case 2
                      'Добавить раздел сюжета
                  End Select
                End While
                sayPerson = 0
              Case 3 'Кузнец
                While sayPerson <> 5
                  Personstat("Кузнец", 2)
                  Console.ForegroundColor = ConsoleColor.Black
                  Console.CursorVisible = False
                  Dim infok As ConsoleKeyInfo = Console.ReadKey()
                  Try
                    sayPerson = infok.Key - 48
                  Catch ex As Exception

                  End Try
                  Select Case sayPerson
                    Case 1
                      'Добавить раздел сюжета
                    Case 2
                      'Добавить раздел сюжета
                    Case 3
                      Blacksmith(1, 2)
                    Case 4
                      Blacksmith(2, 2)
                  End Select
                End While
                sayPerson = 0
              Case 4 'Торговец
                While sayPerson <> 4
                  Personstat("Торговец", 2)
                  Console.ForegroundColor = ConsoleColor.Black
                  Console.CursorVisible = False
                  Dim infot As ConsoleKeyInfo = Console.ReadKey()
                  Try
                    sayPerson = infot.Key - 48
                  Catch ex As Exception

                  End Try
                  Select Case sayPerson
                    Case 1
                      'Добавить раздел сюжета
                    Case 2
                      'Добавить раздел сюжета
                    Case 3
                      Torg(2)
                  End Select
                End While
                sayPerson = 0
            End Select
          End While
          personslive = 0
        Case 4
          'Необязательные квесты
          CvestState(2)
      End Select
    End While

  End Sub
  Public Sub CvestState(ByVal _cityesStatus As Integer) 'Доделать доску!
    Dim Deskcvest As Integer
    While Deskcvest <> 5
      Select Case _cityesStatus
        Case 2
          Console.SetCursorPosition(0, 7)
          Console.WriteLine("     _______________Доска гильдии авантюристов                                       ")
          If _cvest(2) = 0 Then Console.WriteLine("    ║ 1. Победить голодного большого тролля в заброшенной башне.                                                ")
          If _cvest(2) = 2 Then _txtRGB.TxtRGB("Gray", "Black", "    ║ 1. Победить голодного большого тролля в заброшенной башне.                                                ", True)
          Console.WriteLine("    │                                                               ")
          Console.WriteLine("    │                                                                            ")
          Console.WriteLine("    │                                                                           ")
          Console.WriteLine("    │ 5. Уйти                                                    ")
          Console.WriteLine("    └                                                            ")
      End Select

      Console.ForegroundColor = ConsoleColor.Black
      Console.CursorVisible = False
      Dim infop As ConsoleKeyInfo = Console.ReadKey()
      Try
        Deskcvest = infop.Key - 48
      Catch ex As Exception

      End Try
      Select Case Deskcvest
        Case 1
          If _cvest(2) = 0 Then
            Console.SetCursorPosition(0, 7)
            Console.WriteLine("     _______________Доска гильдии авантюристов                                       ")
            Console.WriteLine("    ║ Скорее отправляйтесь сразить его!                                                                            ")
            Console.WriteLine("    │                                                                                                             ")
            Console.WriteLine("    │                                                                                                              ")
            Console.WriteLine("    │                                                                                                          ")
            Console.WriteLine("    │                                                                                                          ")
            Console.WriteLine("    └                                                                                                          ")
            Console.ReadLine()
            _cvest(2) = 1
          Else _cvest(2) = 2
            Console.SetCursorPosition(0, 7)
            Console.WriteLine("     _______________Доска гильдии авантюристов                                       ")
            Console.WriteLine("    ║ Ты показал этому монстру где раки зимуют!                                                                           ")
            Console.WriteLine("    │                                                                                                             ")
            Console.WriteLine("    │                                                                                                              ")
            Console.WriteLine("    │                                                                                                          ")
            Console.WriteLine("    │                                                                                                          ")
            Console.WriteLine("    └                                                                                                          ")
            Console.ReadLine()
            _cvest(2) = 2
          End If
        Case 2


      End Select
    End While
  End Sub
  Public Sub Personstat(ByVal _namePers As String, ByVal _location As Integer)
    Select Case _location
      Case 2
        Select Case _namePers
          Case "Зельевар"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Зельевар                               ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Купить флакон здоровья - 15 монет                 ")
            Console.WriteLine("    │ 3. Купить флакон маны - 20 монет                     ")
            Console.WriteLine("    │ 4. Поговорить                                        ")
            Console.WriteLine("    │ 5. Уйти                                              ")
            Console.WriteLine("    └                                                      ")
          Case "Ремесленник"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Печальный ремесленник                           ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Поговорить                                        ")
            Console.WriteLine("    │ 3. Уйти                                              ")
            Console.WriteLine("    └                                                      ")
            Console.WriteLine("                                                         ")
            Console.WriteLine("                                                         ")
          Case "Кузнец"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Кузнец                           ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Поговорить                                        ")
            Console.WriteLine("    │ 3. Ковать оружие                                           ")
            Console.WriteLine("    │ 4. Ковать броню                                             ")
            Console.WriteLine("    │ 5. Выход                                                   ")
            Console.WriteLine("    └                                                     ")
          Case "Торговец"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Торговец                                            ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Поговорить                                        ")
            Console.WriteLine("    │ 3. Торговать                                         ")
            Console.WriteLine("    │ 4. Уйти                                              ")
            Console.WriteLine("    └                                                      ")
            Console.WriteLine("                                                           ")
        End Select

    End Select
  End Sub

  Public Sub OsmotrPers(ByVal _namePers As String, ByVal _location As Integer)
    Select Case _location
      Case 2
        Select Case _namePers
          Case "Зельевар"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Зельевар              ")
            Console.WriteLine("    ║                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    └                                     ")
            Console.ReadLine()
          Case "Ремесленник"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Печальный ремесленник          ")
            Console.WriteLine("    ║                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    └                                     ")
            Console.ReadLine()
          Case "Кузнец"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Кузнец          ")
            Console.WriteLine("    ║                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    └                                     ")
            Console.ReadLine()
          Case "Торговец"
            Console.SetCursorPosition(0, 6)
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Торговец          ")
            Console.WriteLine("    ║                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    │                                     ")
            Console.WriteLine("    └                                     ")
            Console.ReadLine()
        End Select

    End Select
  End Sub

  Public Sub Torg(ByVal _number As Integer)
    Dim torgtime As String
    torgtime = 0
    While torgtime <> 5
      Select Case _number
        Case 2
          Console.SetCursorPosition(0, 6)
          _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
          Console.WriteLine("     _______________Торговец          ")
          Console.WriteLine("    ║ 1. Оружие                                                                      ")
          Console.WriteLine("    │ 2. Броня                                                                   ")
          Console.WriteLine("    │ 3. Редкости                                                                      ")
          Console.WriteLine("    │ 4. Продать                                                                     ")
          Console.WriteLine("    │ 5. Уйти                                                                        ")
          Console.WriteLine("    └                                                                                ")
          Console.WriteLine("                                        ")
          Console.WriteLine("                                        ")
          Console.WriteLine("                                        ")
          Console.ForegroundColor = ConsoleColor.Black
          Console.CursorVisible = False
          Dim infotorg As ConsoleKeyInfo = Console.ReadKey()
          Try
            torgtime = infotorg.Key - 48
          Catch ex As Exception

          End Try
          Select Case torgtime
            Case 1
              Torggorod(1, 2)
            Case 2
              Torggorod(2, 2)
            Case 3
              Torggorod(3, 2)
            Case 4
              Sell()
          End Select
      End Select
    End While
    'torgtime = 0
  End Sub
  'Покупка
  Private Sub Torggorod(ByVal _punkt As Integer, ByVal _citynumber As Integer)
    Dim byitems As String
    byitems = 0
    Select Case _citynumber
      Case 2
        Console.SetCursorPosition(0, 6)
        _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
        Console.WriteLine("     _______________Торговец          ")
    End Select
    If _bag(1) <> "|Пусто|" And _bag(2) <> "|Пусто|" And _bag(3) <> "|Пусто|" And _bag(4) <> "|Пусто|" And _bag(5) <> "|Пусто|" And _bag(6) <> "|Пусто|" And _bag(7) <> "|Пусто|" And _bag(8) <> "|Пусто|" And _bag(9) <> "|Пусто|" And _bag(10) <> "|Пусто|" Then
      Console.SetCursorPosition(0, 8)
      Console.WriteLine("    ║ Прости друг, но я тебе нечего не           ")
      Console.WriteLine("    │ продам, тебе некуда складывать вещи.         ")
      Console.WriteLine("    └                                    ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.ReadLine()
    Else
      Select Case _punkt 'Покупка предметов
        Case 1 'Оружие
          While byitems <> 5
            Console.ForegroundColor = ConsoleColor.White
            Dim viRand = New Random(DateTime.Now.Millisecond)
            Console.SetCursorPosition(0, 8)
            viaponRand(1) = viRand.Next(1, 41)
            Console.WriteLine("    ║ 1. " & _items(_citynumber, viaponRand(1))._nameweapons & "  " & _items(_citynumber, viaponRand(1))._sellW & "            ")
            Console.WriteLine("    │ " & _items(_citynumber, viaponRand(1))._infoWeapons)
            viaponRand(2) = viRand.Next(1, 41)
            Console.WriteLine("    │ 2. " & _items(_citynumber, viaponRand(2))._nameweapons & "  " & _items(_citynumber, viaponRand(2))._sellW & "            ")
            Console.WriteLine("    │ " & _items(_citynumber, viaponRand(2))._infoWeapons)
            viaponRand(3) = viRand.Next(1, 41)
            Console.WriteLine("    │ 3. " & _items(_citynumber, viaponRand(3))._nameweapons & "  " & _items(_citynumber, viaponRand(3))._sellW & "            ")
            Console.WriteLine("    │ " & _items(_citynumber, viaponRand(3))._infoWeapons)
            Console.WriteLine("    │ 4. Обновить                          ")
            Console.WriteLine("    │ 5. Уйти                             ")
            Console.WriteLine("    └                                     ")
            Console.ForegroundColor = ConsoleColor.Black
            Console.CursorVisible = False
            Dim infotorgviapon As ConsoleKeyInfo = Console.ReadKey()
            Try
              byitems = infotorgviapon.Key - 48
            Catch ex As Exception

            End Try
            Select Case byitems
              Case 1 'Первый слот
                If _money >= _items(_citynumber, viaponRand(1))._sellW Then
                  Try
                    For _bye = 1 To 10
                      If _bag(_bye) = "|Пусто|" Then
                        _bag(_bye) = _items(_citynumber, viaponRand(1))._nameweapons
                        _money -= _items(_citynumber, viaponRand(1))._sellW
                        Exit For
                      End If
                    Next
                    Console.SetCursorPosition(0, 8)
                    Console.WriteLine("    ║ Покупка совершена.                  ")
                    Console.WriteLine("    └                                     ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.ReadLine()
                    byitems = 5
                  Catch ex As Exception

                  End Try
                Else
                  Console.SetCursorPosition(0, 8)
                  Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
                  Console.WriteLine("    │ денег для этого предмета.           ")
                  Console.WriteLine("    └                                   ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                End If


              Case 2 'Вторый слот
                If _money >= _items(_citynumber, viaponRand(2))._sellW Then
                  Try
                    For _bye = 1 To 10
                      If _bag(_bye) = "|Пусто|" Then
                        _bag(_bye) = _items(_citynumber, viaponRand(2))._nameweapons
                        _money -= _items(_citynumber, viaponRand(2))._sellW
                        Exit For
                      End If
                    Next
                    Console.SetCursorPosition(0, 8)
                    Console.WriteLine("    ║ Покупка совершена.                  ")
                    Console.WriteLine("    └                                     ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.ReadLine()
                    byitems = 5
                  Catch ex As Exception

                  End Try
                Else
                  Console.SetCursorPosition(0, 8)
                  Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
                  Console.WriteLine("    │ денег для этого предмета.           ")
                  Console.WriteLine("    └                                   ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                End If


              Case 3 'Третий слот
                If _money >= _items(_citynumber, viaponRand(3))._sellW Then
                  Try
                    For _bye = 1 To 10
                      If _bag(_bye) = "|Пусто|" Then
                        _bag(_bye) = _items(_citynumber, viaponRand(3))._nameweapons
                        _money -= _items(_citynumber, viaponRand(3))._sellW
                        Exit For
                      End If
                    Next
                    Console.SetCursorPosition(0, 8)
                    Console.WriteLine("    ║ Покупка совершена.                  ")
                    Console.WriteLine("    └                                     ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.ReadLine()
                    byitems = 5
                  Catch ex As Exception

                  End Try
                Else
                  Console.SetCursorPosition(0, 8)
                  Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
                  Console.WriteLine("    │ денег для этого предмета.           ")
                  Console.WriteLine("    └                                   ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                End If
              Case 4 'Обновление списка

            End Select
          End While

        Case 2 'Броня
          While byitems <> 5
            Console.ForegroundColor = ConsoleColor.White
            Dim viRand = New Random(DateTime.Now.Millisecond)
            Console.SetCursorPosition(0, 8)
            viaponRand(1) = viRand.Next(1, 26)
            Console.WriteLine("    ║ 1. " & _items(_citynumber, viaponRand(1))._nameprotection & "  " & _items(_citynumber, viaponRand(1))._sellP & "            ")
            Console.WriteLine("    │ " & _items(_citynumber, viaponRand(1))._infoprotection)
            viaponRand(2) = viRand.Next(1, 26)
            Console.WriteLine("    │ 2. " & _items(_citynumber, viaponRand(2))._nameprotection & "  " & _items(_citynumber, viaponRand(2))._sellP & "            ")
            Console.WriteLine("    │ " & _items(_citynumber, viaponRand(2))._infoprotection)
            viaponRand(3) = viRand.Next(1, 26)
            Console.WriteLine("    │ 3. " & _items(_citynumber, viaponRand(3))._nameprotection & "  " & _items(_citynumber, viaponRand(3))._sellP & "            ")
            Console.WriteLine("    │ " & _items(_citynumber, viaponRand(3))._infoprotection)
            Console.WriteLine("    │ 4. Обновить                          ")
            Console.WriteLine("    │ 5. Уйти                             ")
            Console.WriteLine("    └                                     ")
            Console.ForegroundColor = ConsoleColor.Black
            Console.CursorVisible = False
            Dim infotorgviapon As ConsoleKeyInfo = Console.ReadKey()
            Try
              byitems = infotorgviapon.Key - 48
            Catch ex As Exception

            End Try
            Select Case byitems
              Case 1 'Первый слот
                If _money >= _items(_citynumber, viaponRand(1))._sellP Then
                  Try
                    For _bye = 1 To 10
                      If _bag(_bye) = "|Пусто|" Then
                        _bag(_bye) = _items(_citynumber, viaponRand(1))._nameprotection
                        _money -= _items(_citynumber, viaponRand(1))._sellP
                        Exit For
                      End If
                    Next
                    Console.SetCursorPosition(0, 8)
                    Console.WriteLine("    ║ Покупка совершена.                  ")
                    Console.WriteLine("    └                                     ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.ReadLine()
                    byitems = 5
                  Catch ex As Exception

                  End Try
                Else
                  Console.SetCursorPosition(0, 8)
                  Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
                  Console.WriteLine("    │ денег для этого предмета.           ")
                  Console.WriteLine("    └                                   ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                End If


              Case 2 'Вторый слот
                If _money >= _items(_citynumber, viaponRand(2))._sellP Then
                  Try
                    For _bye = 1 To 10
                      If _bag(_bye) = "|Пусто|" Then
                        _bag(_bye) = _items(_citynumber, viaponRand(2))._nameprotection
                        _money -= _items(_citynumber, viaponRand(2))._sellP
                        Exit For
                      End If
                    Next
                    Console.SetCursorPosition(0, 8)
                    Console.WriteLine("    ║ Покупка совершена.                  ")
                    Console.WriteLine("    └                                     ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.ReadLine()
                    byitems = 5
                  Catch ex As Exception

                  End Try
                Else
                  Console.SetCursorPosition(0, 8)
                  Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
                  Console.WriteLine("    │ денег для этого предмета.           ")
                  Console.WriteLine("    └                                   ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                End If


              Case 3 'Третий слот
                If _money >= _items(_citynumber, viaponRand(3))._sellP Then
                  Try
                    For _bye = 1 To 10
                      If _bag(_bye) = "|Пусто|" Then
                        _bag(_bye) = _items(_citynumber, viaponRand(3))._nameprotection
                        _money -= _items(_citynumber, viaponRand(3))._sellP
                        Exit For
                      End If
                    Next
                    Console.SetCursorPosition(0, 8)
                    Console.WriteLine("    ║ Покупка совершена.                  ")
                    Console.WriteLine("    └                                     ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.WriteLine("                                        ")
                    Console.ReadLine()
                    byitems = 5
                  Catch ex As Exception

                  End Try
                Else
                  Console.SetCursorPosition(0, 8)
                  Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
                  Console.WriteLine("    │ денег для этого предмета.           ")
                  Console.WriteLine("    └                                   ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                End If
              Case 4 'Обновление списка

            End Select
          End While
        Case 3


      End Select
    End If
  End Sub
  'Основной метод Продажи
  Private Sub Sell()
    Dim payitems As String
    payitems = 0
    If _bag(1) = "|Пусто|" And _bag(2) = "|Пусто|" And _bag(3) = "|Пусто|" And _bag(4) = "|Пусто|" And _bag(5) = "|Пусто|" And _bag(6) = "|Пусто|" And _bag(7) = "|Пусто|" And _bag(8) = "|Пусто|" And _bag(9) = "|Пусто|" And _bag(10) = "|Пусто|" Then
      Console.SetCursorPosition(0, 8)
      Console.WriteLine("    ║ Прости, но тебе нечего мне продать           ")
      Console.WriteLine("    └                                              ")
      Console.WriteLine("                                                   ")
      Console.WriteLine("                                                   ")
      Console.WriteLine("                                                   ")
      Console.WriteLine("                                                   ")
      Console.ReadLine()
    Else
      While payitems <> 11
        Console.SetCursorPosition(0, 8)
        Console.WriteLine("    ║                                                   ")
        Console.WriteLine("    │                                                   ")
        Console.WriteLine("    │                                                   ")
        Console.WriteLine("    │                                                   ")
        Console.WriteLine("    │                                                   ")
        Console.WriteLine("    └                                                   ")
        Console.SetCursorPosition(0, 6)
        _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
        Console.WriteLine("     _______________Торговец                            ")
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
        Console.ForegroundColor = ConsoleColor.Black
        Console.CursorVisible = False
        Dim infopay As ConsoleKeyInfo = Console.ReadKey()
        Try
          payitems = infopay.Key - 48
        Catch ex As Exception

        End Try

        Try
          Select Case payitems
            Case 1
              Vispay(_bag(1))
              _bag(1) = "|Пусто|"
            Case 2
              Vispay(_bag(2))
              _bag(2) = "|Пусто|"
            Case 3
              Vispay(_bag(3))
              _bag(3) = "|Пусто|"
            Case 4
              Vispay(_bag(4))
              _bag(4) = "|Пусто|"
            Case 5
              Vispay(_bag(5))
              _bag(5) = "|Пусто|"
            Case 6
              Vispay(_bag(6))
              _bag(6) = "|Пусто|"
            Case 7
              Vispay(_bag(7))
              _bag(7) = "|Пусто|"
            Case 8
              Vispay(_bag(8))
              _bag(8) = "|Пусто|"
            Case 9
              Vispay(_bag(9))
              _bag(9) = "|Пусто|"
            Case 0
              Vispay(_bag(10))
              _bag(10) = "|Пусто|"
            Case 13

          End Select
          Console.SetCursorPosition(0, 8)
          Console.WriteLine("    ║ Продажа совершена.                                                  ")
          Console.WriteLine("    └                                                                     ")
          Console.WriteLine("                                                                          ")
          Console.WriteLine("                                                                          ")
          Console.WriteLine("                                                                          ")
          Console.WriteLine("                                                                          ")
          Console.ReadLine()
          payitems = 11
        Catch ex As Exception

        End Try

      End While
    End If

  End Sub

  'Кузнечное дело
  Public Sub Blacksmith(ByVal _punkt As Integer, ByVal _citynumber As Integer)
    Select Case _citynumber
      Case 2
        Console.SetCursorPosition(0, 6)
        _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
        Console.WriteLine("     _______________Кузнец          ")
    End Select
    If _bag(1) <> "|Пусто|" And _bag(2) <> "|Пусто|" And _bag(3) <> "|Пусто|" And _bag(4) <> "|Пусто|" And _bag(5) <> "|Пусто|" And _bag(6) <> "|Пусто|" And _bag(7) <> "|Пусто|" And _bag(8) <> "|Пусто|" And _bag(9) <> "|Пусто|" And _bag(10) <> "|Пусто|" Then
      Console.SetCursorPosition(0, 8)
      Console.WriteLine("    ║ Извини, но разве я могу сделать то,           ")
      Console.WriteLine("    │ чего не имеет веса? Посмотри, у тебя нет места.         ")
      Console.WriteLine("    └                                    ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.ReadLine()
    Else
      Select Case _punkt
        Case 1 'Куёт оружие
          If _money >= 1500 Then
            Try
              For _bye = 1 To 10
                Dim viRand = New Random(DateTime.Now.Millisecond)
                viaponRand(1) = viRand.Next(1, 17)
                If _bag(_bye) = "|Пусто|" Then
                  _bag(_bye) = _items(_citynumber, viaponRand(1))._nameelitw
                  _money -= 1500
                  Exit For
                End If
              Next
              Console.SetCursorPosition(0, 8)
              Console.WriteLine("    ║ Я выковал тебе " & _items(_citynumber, viaponRand(1))._nameelitw & "                  ")
              Console.WriteLine("    └                                     ")
              Console.WriteLine("                                        ")
              Console.WriteLine("                                        ")
              Console.WriteLine("                                        ")
              Console.WriteLine("                                        ")
              Console.ReadLine()
            Catch ex As Exception

            End Try
          Else
            Console.SetCursorPosition(0, 8)
            Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
            Console.WriteLine("    │ денег для мои услуг. Копи больше.    ")
            Console.WriteLine("    └                                   ")
            Console.WriteLine("                                        ")
            Console.WriteLine("                                        ")
            Console.WriteLine("                                        ")
            Console.ReadLine()
          End If
        Case 2 'Куёт броню
          If _money >= 2000 Then
            Try
              For _bye = 1 To 10
                Dim viRand = New Random(DateTime.Now.Millisecond)
                viaponRand(1) = viRand.Next(1, 7)
                If _bag(_bye) = "|Пусто|" Then
                  _bag(_bye) = _items(_citynumber, viaponRand(1))._nameelitp
                  _money -= 2000
                  Exit For
                End If
              Next
              Console.SetCursorPosition(0, 8)
              Console.WriteLine("    ║ Я выковал тебе " & _items(_citynumber, viaponRand(1))._nameelitp & "                  ")
              Console.WriteLine("    └                                     ")
              Console.WriteLine("                                        ")
              Console.WriteLine("                                        ")
              Console.WriteLine("                                        ")
              Console.WriteLine("                                        ")
              Console.ReadLine()
            Catch ex As Exception

            End Try
          Else
            Console.SetCursorPosition(0, 8)
            Console.WriteLine("    ║ Прости друг, но у тебя недостаточно ")
            Console.WriteLine("    │ денег для мои услуг. Копи больше.    ")
            Console.WriteLine("    └                                   ")
            Console.WriteLine("                                        ")
            Console.WriteLine("                                        ")
            Console.WriteLine("                                        ")
            Console.ReadLine()
          End If
      End Select
    End If


  End Sub

  'Продажа предметов
  Private Sub Vispay(ByVal _item As String) 'Расчёт продажи предметов
    Try
      Select Case _item
        Case "Ржавый кованый меч"
          _money += Int(_items(2, 1)._sellW / 4)
        Case "Ржавый двуручный меч"
          _money += Int(_items(2, 2)._sellW / 4)
        Case "Ржавый стальной кинжал"
          _money += Int(_items(2, 3)._sellW / 4)
        Case "Ржавый короткий кинжал"
          _money += Int(_items(2, 4)._sellW / 4)
        Case "Стальной меч"
          _money += Int(_items(2, 5)._sellW / 4)
        Case "Гнутый двуручный меч"
          _money += Int(_items(2, 6)._sellW / 4)
        Case "Заляпаный тесак"
          _money += Int(_items(2, 7)._sellW / 4)
        Case "Нож для мяса"
          _money += Int(_items(2, 8)._sellW / 4)
        Case "Острый нож"
          _money += Int(_items(2, 9)._sellW / 4)
        Case "Медный кинжал"
          _money += Int(_items(2, 10)._sellW / 4)
        Case "Ветхий скипетр"
          _money += Int(_items(2, 11)._sellW / 4)
        Case "Треснутая палочка"
          _money += Int(_items(2, 12)._sellW / 4)
        Case "Треснутый посох"
          _money += Int(_items(2, 13)._sellW / 4)
        Case "Жезл новичка"
          _money += Int(_items(2, 14)._sellW / 4)
        Case "Старый посох"
          _money += Int(_items(2, 15)._sellW / 4)
        Case "Медный жезл"
          _money += Int(_items(2, 16)._sellW / 4)
        Case "Палочка ученика"
          _money += Int(_items(2, 17)._sellW / 4)
        Case "Палочка из бурейника"
          _money += Int(_items(2, 18)._sellW / 4)
        Case "Поддержанный посох"
          _money += Int(_items(2, 19)._sellW / 4)
        Case "Фальшивый скипетр"
          _money += Int(_items(2, 20)._sellW / 4)
        Case "Лук лесника"
          _money += Int(_items(2, 21)._sellW / 4)
        Case "Лук ученика"
          _money += Int(_items(2, 22)._sellW / 4)
        Case "Лук из бурейника"
          _money += Int(_items(2, 23)._sellW / 4)
        Case "Треснутый лук"
          _money += Int(_items(2, 24)._sellW / 4)
        Case "Старый арбалет"
          _money += Int(_items(2, 25)._sellW / 4)
        Case "Старый лук"
          _money += Int(_items(2, 26)._sellW / 4)
        Case "Прогнивший лук"
          _money += Int(_items(2, 27)._sellW / 4)
        Case "Треснутый арбалет"
          _money += Int(_items(2, 28)._sellW / 4)
        Case "Самодельный лук"
          _money += Int(_items(2, 29)._sellW / 4)
        Case "Большой скрипучий лук"
          _money += Int(_items(2, 30)._sellW / 4)
        Case "Короткие кинжалы"
          _money += Int(_items(2, 31)._sellW / 4)
        Case "Короткий ржавый меч"
          _money += Int(_items(2, 32)._sellW / 4)
        Case "Короткий лук"
          _money += Int(_items(2, 33)._sellW / 4)
        Case "Обрубок двуручного меча"
          _money += Int(_items(2, 34)._sellW / 4)
        Case "Ядовитый сломаный дротик"
          _money += Int(_items(2, 35)._sellW / 4)
        Case "Сломаная рапира"
          _money += Int(_items(2, 36)._sellW / 4)
        Case "Обрубок тесака"
          _money += Int(_items(2, 37)._sellW / 4)
        Case "Тупой нож"
          _money += Int(_items(2, 38)._sellW / 4)
        Case "Гнущийся лук"
          _money += Int(_items(2, 39)._sellW / 4)
        Case "Прочный кинжал"
          _money += Int(_items(2, 40)._sellW / 4)

          '--------------------------------------------------
        Case "Потрёпаная стёганка"
          _money += Int(_items(2, 1)._sellW / 4)
        Case "Стёртые сапоги"
          _money += Int(_items(2, 2)._sellW / 4)
        Case "Погнутые доспехи"
          _money += Int(_items(2, 3)._sellW / 4)
        Case "Кожаные доспехи"
          _money += Int(_items(2, 4)._sellW / 4)
        Case "Пробитый кушак"
          _money += Int(_items(2, 5)._sellW / 4)
        Case "Ржавый шлем"
          _money += Int(_items(2, 6)._sellW / 4)
        Case "Треснутое забрало"
          _money += Int(_items(2, 7)._sellW / 4)
        Case "Перчатки из тины"
          _money += Int(_items(2, 8)._sellW / 4)
        Case "Старые варежки"
          _money += Int(_items(2, 9)._sellW / 4)
        Case "Прогнившие наручи"
          _money += Int(_items(2, 10)._sellW / 4)
        Case "Медные наручи"
          _money += Int(_items(2, 11)._sellW / 4)
        Case "Медный доспех"
          _money += Int(_items(2, 12)._sellW / 4)
        Case "Прочные ботинки"
          _money += Int(_items(2, 13)._sellW / 4)
        Case "Ветхие  сапоги"
          _money += Int(_items(2, 14)._sellW / 4)
        Case "Халат"
          _money += Int(_items(2, 15)._sellW / 4)
        Case "Старый балахон"
          _money += Int(_items(2, 16)._sellW / 4)
        Case "Потрёпаный плащ"
          _money += Int(_items(2, 17)._sellW / 4)
        Case "Изношенная мантия"
          _money += Int(_items(2, 18)._sellW / 4)
        Case "Кожаные сандали"
          _money += Int(_items(2, 19)._sellW / 4)
        Case "Потрёпаный колпак"
          _money += Int(_items(2, 20)._sellW / 4)
        Case "Ветхое одеяние"
          _money += Int(_items(2, 21)._sellW / 4)
        Case "Исхудалые ботинки"
          _money += Int(_items(2, 22)._sellW / 4)
        Case "Старые ритуальные перчатки"
          _money += Int(_items(2, 23)._sellW / 4)
        Case "Дырявое пончо"
          _money += Int(_items(2, 24)._sellW / 4)
        Case "Крепкие одеяния"
          _money += Int(_items(2, 25)._sellW / 4)
        Case "Кованный благородный меч"
          _money += 250
        Case "Кованный прочный нож"
          _money += 250
        Case "Безупречный двуручный меч"
          _money += 250
        Case "Безупречный острый тесак"
          _money += 250
        Case "Кованный прочный жезл"
          _money += 250
        Case "Кованный прелестный скипетр"
          _money += 250
        Case "Безупречная палочка"
          _money += 250
        Case "Безупречный посох"
          _money += 250
        Case "Кованный гибкий лук"
          _money += 250
        Case "Безупречный арбалет"
          _money += 250
        Case "Безупречный большой лук"
          _money += 250
        Case "Кованный широкий арбалет"
          _money += 250
        Case "Кованый острый кинжал"
          _money += 250
        Case "Безупречные ядовитые кинжалы"
          _money += 250
        Case "Безупречный дротик"
          _money += 250
        Case "Кованый прочный дротик"
          _money += 250
        Case "Безупречный прочный доспех"
          _money += 100
        Case "Кованный шлем"
          _money += 100
        Case "Прочные бронированные сапоги"
          _money += 100
        Case "Безупречный халат"
          _money += 100
        Case "Прочный волшебный плащ"
          _money += 100
        Case "Волшебный магический колпак"
          _money += 100

      End Select
    Catch ex As Exception
      '_txtRGB.TxtRGB("Red", "Black", "/////////////////////////////////////////////////////////////", False)
    End Try

  End Sub
  Private Sub Visbag(ByVal _bagchek As String) 'Вывод продажи предметов
    If _bagchek = "|Пусто|" Then
      _txtRGB.TxtRGB("DarkGray", "Black", " |Пусто|                ", False)
    Else
      Select Case _bagchek
        Case "Ржавый кованый меч"
          _txtRGB.TxtRGB("White", "Black", "|Ржавый кованый меч|" & Int(_items(2, 1)._sellW / 4), False)
        Case "Ржавый двуручный меч"
          _txtRGB.TxtRGB("White", "Black", "|Ржавый двуручный меч|" & Int(_items(2, 2)._sellW / 4), False)
        Case "Ржавый стальной кинжал"
          _txtRGB.TxtRGB("White", "Black", "|Ржавый стальной кинжал|" & Int(_items(2, 3)._sellW / 4), False)
        Case "Ржавый короткий кинжал"
          _txtRGB.TxtRGB("White", "Black", "|Ржавый короткий кинжал|" & Int(_items(2, 4)._sellW / 4), False)
        Case "Стальной меч"
          _txtRGB.TxtRGB("White", "Black", "|Стальной меч|" & Int(_items(2, 5)._sellW / 4), False)
        Case "Гнутый двуручный меч"
          _txtRGB.TxtRGB("White", "Black", "|Гнутый двуручный меч|" & Int(_items(2, 6)._sellW / 4), False)
        Case "Заляпаный тесак"
          _txtRGB.TxtRGB("White", "Black", "|Заляпаный тесак|" & Int(_items(2, 7)._sellW / 4), False)
        Case "Нож для мяса"
          _txtRGB.TxtRGB("White", "Black", "|Нож для мяса|" & Int(_items(2, 8)._sellW / 4), False)
        Case "Острый нож"
          _txtRGB.TxtRGB("White", "Black", "|Острый нож| " & Int(_items(2, 9)._sellW / 4), False)
        Case "Медный кинжал"
          _txtRGB.TxtRGB("White", "Black", "|Медный кинжал| " & Int(_items(2, 10)._sellW / 4), False)
        Case "Ветхий скипетр"
          _txtRGB.TxtRGB("White", "Black", "|Ветхий скипетр| " & Int(_items(2, 11)._sellW / 4), False)
        Case "Треснутая палочка"
          _txtRGB.TxtRGB("White", "Black", "|Треснутая палочка| " & Int(_items(2, 12)._sellW / 4), False)
        Case "Треснутый посох"
          _txtRGB.TxtRGB("White", "Black", "|Треснутый посох| " & Int(_items(2, 13)._sellW / 4), False)
        Case "Жезл новичка"
          _txtRGB.TxtRGB("White", "Black", "|Жезл новичка| " & Int(_items(2, 14)._sellW / 4), False)
        Case "Старый посох"
          _txtRGB.TxtRGB("White", "Black", "|Старый посох| " & Int(_items(2, 15)._sellW / 4), False)
        Case "Медный жезл"
          _txtRGB.TxtRGB("White", "Black", "|Медный жезл| " & Int(_items(2, 16)._sellW / 4), False)
        Case "Палочка ученика"
          _txtRGB.TxtRGB("White", "Black", "|Палочка ученика| " & Int(_items(2, 17)._sellW / 4), False)
        Case "Палочка из бурейника"
          _txtRGB.TxtRGB("White", "Black", "|Палочка из бурейника| " & Int(_items(2, 18)._sellW / 4), False)
        Case "Поддержанный посох"
          _txtRGB.TxtRGB("White", "Black", "|Поддержанный посох| " & Int(_items(2, 19)._sellW / 4), False)
        Case "Фальшивый скипетр"
          _txtRGB.TxtRGB("White", "Black", "|Фальшивый скипетр| " & Int(_items(2, 20)._sellW / 4), False)
        Case "Лук лесника"
          _txtRGB.TxtRGB("White", "Black", "|Лук лесника| " & Int(_items(2, 21)._sellW / 4), False)
        Case "Лук ученика"
          _txtRGB.TxtRGB("White", "Black", "|Лук ученика| " & Int(_items(2, 22)._sellW / 4), False)
        Case "Лук из бурейника"
          _txtRGB.TxtRGB("White", "Black", "|Лук из бурейника| " & Int(_items(2, 23)._sellW / 4), False)
        Case "Треснутый лук"
          _txtRGB.TxtRGB("White", "Black", "|Треснутый лук| " & Int(_items(2, 24)._sellW / 4), False)
        Case "Старый арбалет"
          _txtRGB.TxtRGB("White", "Black", "|Старый арбалет| " & Int(_items(2, 25)._sellW / 4), False)
        Case "Старый лук"
          _txtRGB.TxtRGB("White", "Black", "|Старый лук| " & Int(_items(2, 26)._sellW / 4), False)
        Case "Прогнивший лук"
          _txtRGB.TxtRGB("White", "Black", "|Прогнувшийся лук| " & Int(_items(2, 27)._sellW / 4), False)
        Case "Треснутый арбалет"
          _txtRGB.TxtRGB("White", "Black", "|Треснутый арбалет| " & Int(_items(2, 28)._sellW / 4), False)
        Case "Самодельный лук"
          _txtRGB.TxtRGB("White", "Black", "|Самодельный лук| " & Int(_items(2, 29)._sellW / 4), False)
        Case "Большой скрипучий лук"
          _txtRGB.TxtRGB("White", "Black", "|Большой срипучий лук| " & Int(_items(2, 30)._sellW / 4), False)
        Case "Короткие кинжалы"
          _txtRGB.TxtRGB("White", "Black", "|Короткий кинжал| " & Int(_items(2, 31)._sellW / 4), False)
        Case "Короткий ржавый меч"
          _txtRGB.TxtRGB("White", "Black", "|Короткий ржавый меч| " & Int(_items(2, 32)._sellW / 4), False)
        Case "Короткий лук"
          _txtRGB.TxtRGB("White", "Black", "|Короткий лук| " & Int(_items(2, 33)._sellW / 4), False)
        Case "Обрубок двуручного меча"
          _txtRGB.TxtRGB("White", "Black", "|Обрубок двуручного меча| " & Int(_items(2, 34)._sellW / 4), False)
        Case "Ядовитый сломаный дротик"
          _txtRGB.TxtRGB("White", "Black", "|Ядовитый сломаный дротик| " & Int(_items(2, 35)._sellW / 4), False)
        Case "Сломаная рапира"
          _txtRGB.TxtRGB("White", "Black", "|Сломаная рапира| " & Int(_items(2, 36)._sellW / 4), False)
        Case "Обрубок тесака"
          _txtRGB.TxtRGB("White", "Black", "|Обрубок тесака| " & Int(_items(2, 37)._sellW / 4), False)
        Case "Тупой нож"
          _txtRGB.TxtRGB("White", "Black", "|Тупой нож| " & Int(_items(2, 38)._sellW / 4), False)
        Case "Гнущийся лук"
          _txtRGB.TxtRGB("White", "Black", "|Гнущийся лук| " & Int(_items(2, 39)._sellW / 4), False)
        Case "Прочный кинжал"
          _txtRGB.TxtRGB("White", "Black", "|Прочный кинжал| " & Int(_items(2, 40)._sellW / 4), False)
          '----------------------------------------------------
        Case "Потрёпаная стёганка"
          _txtRGB.TxtRGB("White", "Black", "|Потрёпаная стёганка|" & Int(_items(2, 1)._sellP / 4), False)
        Case "Стёртые сапоги"
          _txtRGB.TxtRGB("White", "Black", "|Стёртые сапоги|" & Int(_items(2, 2)._sellP / 4), False)
        Case "Погнутые доспехи"
          _txtRGB.TxtRGB("White", "Black", "|Погнутые доспехи|" & Int(_items(2, 3)._sellP / 4), False)
        Case "Кожаные доспехи"
          _txtRGB.TxtRGB("White", "Black", "|Кожаные доспехи|" & Int(_items(2, 4)._sellP / 4), False)
        Case "Пробитый кушак"
          _txtRGB.TxtRGB("White", "Black", "|Пробитый кушак|" & Int(_items(2, 5)._sellP / 4), False)
        Case "Ржавый шлем"
          _txtRGB.TxtRGB("White", "Black", "|Ржавый шлем|" & Int(_items(2, 6)._sellP / 4), False)
        Case "Треснутое забрало"
          _txtRGB.TxtRGB("White", "Black", "|Треснутое забрало|" & Int(_items(2, 7)._sellP / 4), False)
        Case "Перчатки из тины"
          _txtRGB.TxtRGB("White", "Black", "|Перчатки из тины|" & Int(_items(2, 8)._sellP / 4), False)
        Case "Старые варежки"
          _txtRGB.TxtRGB("White", "Black", "|Старые варежки| " & Int(_items(2, 9)._sellP / 4), False)
        Case "Прогнившие наручи"
          _txtRGB.TxtRGB("White", "Black", "|Прогнившие наручи| " & Int(_items(2, 10)._sellP / 4), False)
        Case "Медные наручи"
          _txtRGB.TxtRGB("White", "Black", "|Медные наручи| " & Int(_items(2, 11)._sellP / 4), False)
        Case "Медный доспех"
          _txtRGB.TxtRGB("White", "Black", "|Медный доспех| " & Int(_items(2, 12)._sellP / 4), False)
        Case "Прочные ботинки"
          _txtRGB.TxtRGB("White", "Black", "|Прочные ботинки| " & Int(_items(2, 13)._sellP / 4), False)
        Case "Ветхие  сапоги"
          _txtRGB.TxtRGB("White", "Black", "|Ветхие  сапоги| " & Int(_items(2, 14)._sellP / 4), False)
        Case "Халат"
          _txtRGB.TxtRGB("White", "Black", "|Халат| " & Int(_items(2, 15)._sellP / 4), False)
        Case "Старый балахон"
          _txtRGB.TxtRGB("White", "Black", "|Старый балахон| " & Int(_items(2, 16)._sellP / 4), False)
        Case "Потрёпаный плащ"
          _txtRGB.TxtRGB("White", "Black", "|Потрёпаный плащ| " & Int(_items(2, 17)._sellP / 4), False)
        Case "Изношенная мантия"
          _txtRGB.TxtRGB("White", "Black", "|Изношенная мантия| " & Int(_items(2, 18)._sellP / 4), False)
        Case "Кожаные сандали"
          _txtRGB.TxtRGB("White", "Black", "|Кожаные сандали| " & Int(_items(2, 19)._sellP / 4), False)
        Case "Потрёпаный колпак"
          _txtRGB.TxtRGB("White", "Black", "|Потрёпаный колпак| " & Int(_items(2, 20)._sellP / 4), False)
        Case "Ветхое одеяние"
          _txtRGB.TxtRGB("White", "Black", "|Ветхое одеяние| " & Int(_items(2, 21)._sellP / 4), False)
        Case "Исхудалые ботинки"
          _txtRGB.TxtRGB("White", "Black", "|Исхудалые ботинки| " & Int(_items(2, 22)._sellP / 4), False)
        Case "Старые ритуальные перчатки"
          _txtRGB.TxtRGB("White", "Black", "|Старые ритуальные перчатки| " & Int(_items(2, 23)._sellP / 4), False)
        Case "Дырявое пончо"
          _txtRGB.TxtRGB("White", "Black", "|Дырявое пончо| " & Int(_items(2, 24)._sellP / 4), False)
        Case "Крепкие одеяния"
          _txtRGB.TxtRGB("White", "Black", "|Крепкие одеяния| " & Int(_items(2, 25)._sellP / 4), False)
        Case "Кованный благородный меч"
          _txtRGB.TxtRGB("White", "Black", "|Кованный благородный меч| 250", False)
        Case "Кованный прочный нож"
          _txtRGB.TxtRGB("White", "Black", "|Кованный прочный нож| 250", False)
        Case "Безупречный двуручный меч"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный двуручный меч| 250", False)
        Case "Безупречный острый тесак"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный острый тесак| 250", False)
        Case "Кованный прочный жезл"
          _txtRGB.TxtRGB("White", "Black", "|Кованный прочный жезл| 250", False)
        Case "Кованный прелестный скипетр"
          _txtRGB.TxtRGB("White", "Black", "|Кованный прелестный скипетр| 250", False)
        Case "Безупречная палочка"
          _txtRGB.TxtRGB("White", "Black", "|Безупречная палочка| 250", False)
        Case "Безупречный посох"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный посох| 250", False)
        Case "Кованный гибкий лук"
          _txtRGB.TxtRGB("White", "Black", "|Кованный гибкий лук| 250", False)
        Case "Безупречный арбалет"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный арбалет| 250", False)
        Case "Безупречный большой лук"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный большой лук| 250", False)
        Case "Кованный широкий арбалет"
          _txtRGB.TxtRGB("White", "Black", "|Кованный широкий арбалет| 250", False)
        Case "Кованый острый кинжал"
          _txtRGB.TxtRGB("White", "Black", "|Кованый острый кинжал| 250", False)
        Case "Безупречные ядовитые кинжалы"
          _txtRGB.TxtRGB("White", "Black", "Безупречные ядовитые кинжалы| 250", False)
        Case "Безупречный дротик"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный дротик| 250", False)
        Case "Кованый прочный дротик"
          _txtRGB.TxtRGB("White", "Black", "|Кованый прочный дротик| 250", False)
        Case "Безупречный прочный доспех"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный прочный доспех| 100", False)
        Case "Кованный шлем"
          _txtRGB.TxtRGB("White", "Black", "|Кованный шлем| 100", False)
        Case "Прочные бронированные сапоги"
          _txtRGB.TxtRGB("White", "Black", "|Прочные бронированные сапоги| 100", False)
        Case "Безупречный халат"
          _txtRGB.TxtRGB("White", "Black", "|Безупречный халат| 100", False)
        Case "Прочный волшебный плащ"
          _txtRGB.TxtRGB("White", "Black", "|Прочный волшебный плащ| 100", False)
        Case "Волшебный магический колпак"
          _txtRGB.TxtRGB("White", "Black", "|Волшебный магический колпак| 100", False)
      End Select
    End If
  End Sub
  'Предметы
  Public Sub New()
    'Предметы города в гнилистых лесах.
    'Оружие
    'Воин
    _items(2, 1)._nameweapons = "Ржавый кованый меч"
    _items(2, 2)._nameweapons = "Ржавый двуручный меч"
    _items(2, 3)._nameweapons = "Ржавый стальной кинжал"
    _items(2, 4)._nameweapons = "Ржавый короткий кинжал"
    _items(2, 5)._nameweapons = "Стальной меч"
    _items(2, 6)._nameweapons = "Гнутый двуручный меч"
    _items(2, 7)._nameweapons = "Заляпаный тесак"
    _items(2, 8)._nameweapons = "Нож для мяса"
    _items(2, 9)._nameweapons = "Острый нож"
    _items(2, 10)._nameweapons = "Медный кинжал"
    'Маг
    _items(2, 11)._nameweapons = "Ветхий скипетр"
    _items(2, 12)._nameweapons = "Треснутая палочка"
    _items(2, 13)._nameweapons = "Треснутый посох"
    _items(2, 14)._nameweapons = "Жезл новичка"
    _items(2, 15)._nameweapons = "Старый посох"
    _items(2, 16)._nameweapons = "Медный жезл"
    _items(2, 17)._nameweapons = "Палочка ученика"
    _items(2, 18)._nameweapons = "Палочка из бурейника"
    _items(2, 19)._nameweapons = "Поддержанный посох"
    _items(2, 20)._nameweapons = "Фальшивый скипетр"
    'Лучник
    _items(2, 21)._nameweapons = "Лук лесника"
    _items(2, 22)._nameweapons = "Лук ученика"
    _items(2, 23)._nameweapons = "Лук из бурейника"
    _items(2, 24)._nameweapons = "Треснутый лук"
    _items(2, 25)._nameweapons = "Старый арбалет"
    _items(2, 26)._nameweapons = "Старый лук"
    _items(2, 27)._nameweapons = "Прогнивший лук"
    _items(2, 28)._nameweapons = "Треснутый арбалет"
    _items(2, 29)._nameweapons = "Самодельный лук"
    _items(2, 30)._nameweapons = "Большой скрипучий лук"
    'Плут
    _items(2, 31)._nameweapons = "Короткие кинжалы"
    _items(2, 32)._nameweapons = "Короткий ржавый меч"
    _items(2, 33)._nameweapons = "Короткий лук"
    _items(2, 34)._nameweapons = "Обрубок двуручного меча"
    _items(2, 35)._nameweapons = "Ядовитый сломаный дротик"
    _items(2, 36)._nameweapons = "Сломаная рапира"
    _items(2, 37)._nameweapons = "Обрубок тесака"
    _items(2, 38)._nameweapons = "Тупой нож"
    _items(2, 39)._nameweapons = "Гнущийся лук"
    _items(2, 40)._nameweapons = "Прочный кинжал"

    'Редкие предметы - нет в списках экипировки и продажи!!!
    'Оружие
    _items(2, 1)._nameelitw = "Кованный благородный меч"
    _items(2, 2)._nameelitw = "Кованный прочный нож"
    _items(2, 3)._nameelitw = "Безупречный двуручный меч"
    _items(2, 4)._nameelitw = "Безупречный острый тесак"
    _items(2, 5)._nameelitw = "Кованный прочный жезл"
    _items(2, 6)._nameelitw = "Кованный прелестный скипетр"
    _items(2, 7)._nameelitw = "Безупречная палочка"
    _items(2, 8)._nameelitw = "Безупречный посох"
    _items(2, 9)._nameelitw = "Кованный гибкий лук"
    _items(2, 10)._nameelitw = "Безупречный арбалет"
    _items(2, 11)._nameelitw = "Безупречный большой лук"
    _items(2, 12)._nameelitw = "Кованный широкий арбалет"
    _items(2, 13)._nameelitw = "Кованый острый кинжал"
    _items(2, 14)._nameelitw = "Безупречные ядовитые кинжалы"
    _items(2, 15)._nameelitw = "Безупречный дротик"
    _items(2, 16)._nameelitw = "Кованый прочный дротик"
    'Доспехи
    _items(2, 1)._nameelitp = "Безупречный прочный доспех"
    _items(2, 2)._nameelitp = "Кованный шлем"
    _items(2, 3)._nameelitp = "Прочные бронированные сапоги"
    _items(2, 4)._nameelitp = "Безупречный халат"
    _items(2, 5)._nameelitp = "Прочный волшебный плащ"
    _items(2, 6)._nameelitp = "Волшебный магический колпак"



    'Доспехи
    '--------------Воин---------------
    _items(2, 1)._nameprotection = "Потрёпаная стёганка"
    _items(2, 2)._nameprotection = "Стёртые сапоги" 'Общий предмет
    _items(2, 3)._nameprotection = "Погнутые доспехи"
    _items(2, 4)._nameprotection = "Кожаные доспехи"
    _items(2, 5)._nameprotection = "Пробитый кушак"
    _items(2, 6)._nameprotection = "Ржавый шлем"
    _items(2, 7)._nameprotection = "Треснутое забрало"
    _items(2, 8)._nameprotection = "Перчатки из тины"  'Общий предмет
    _items(2, 9)._nameprotection = "Старые варежки"
    _items(2, 10)._nameprotection = "Прогнившие наручи"
    _items(2, 11)._nameprotection = "Медные наручи"
    _items(2, 12)._nameprotection = "Медный доспех"
    _items(2, 13)._nameprotection = "Прочные ботинки"
    _items(2, 14)._nameprotection = "Ветхие  сапоги"
    '-----------------Маг-----------------
    _items(2, 15)._nameprotection = "Халат"
    _items(2, 16)._nameprotection = "Старый балахон"
    _items(2, 17)._nameprotection = "Потрёпаный плащ"
    _items(2, 18)._nameprotection = "Изношенная мантия"
    _items(2, 19)._nameprotection = "Кожаные сандали"
    _items(2, 20)._nameprotection = "Потрёпаный колпак"
    _items(2, 21)._nameprotection = "Ветхое одеяние"
    _items(2, 22)._nameprotection = "Исхудалые ботинки"
    _items(2, 23)._nameprotection = "Старые ритуальные перчатки"
    _items(2, 24)._nameprotection = "Дырявое пончо"
    _items(2, 25)._nameprotection = "Крепкие одеяния"


    'Предметы

    'Цена
    'За оружие
    _items(2, 1)._sellW = 100
    _items(2, 2)._sellW = 120
    _items(2, 3)._sellW = 90
    _items(2, 4)._sellW = 90
    _items(2, 5)._sellW = 250
    _items(2, 6)._sellW = 115
    _items(2, 7)._sellW = 150
    _items(2, 8)._sellW = 50
    _items(2, 9)._sellW = 120
    _items(2, 10)._sellW = 70
    _items(2, 11)._sellW = 100
    _items(2, 12)._sellW = 120
    _items(2, 13)._sellW = 90
    _items(2, 14)._sellW = 90
    _items(2, 15)._sellW = 120
    _items(2, 16)._sellW = 115
    _items(2, 17)._sellW = 150
    _items(2, 18)._sellW = 50
    _items(2, 19)._sellW = 250
    _items(2, 20)._sellW = 70
    _items(2, 21)._sellW = 80
    _items(2, 22)._sellW = 110
    _items(2, 23)._sellW = 130
    _items(2, 24)._sellW = 85
    _items(2, 25)._sellW = 270
    _items(2, 26)._sellW = 130
    _items(2, 27)._sellW = 90
    _items(2, 28)._sellW = 60
    _items(2, 29)._sellW = 75
    _items(2, 30)._sellW = 130
    _items(2, 31)._sellW = 80
    _items(2, 32)._sellW = 70
    _items(2, 33)._sellW = 90
    _items(2, 34)._sellW = 140
    _items(2, 35)._sellW = 150
    _items(2, 36)._sellW = 50
    _items(2, 37)._sellW = 150
    _items(2, 38)._sellW = 165
    _items(2, 39)._sellW = 120
    _items(2, 40)._sellW = 265
    'За доспехи
    _items(2, 1)._sellP = 90
    _items(2, 2)._sellP = 80
    _items(2, 3)._sellP = 90
    _items(2, 4)._sellP = 130
    _items(2, 5)._sellP = 140
    _items(2, 6)._sellP = 90
    _items(2, 7)._sellP = 150
    _items(2, 8)._sellP = 80
    _items(2, 9)._sellP = 120
    _items(2, 10)._sellP = 70
    _items(2, 11)._sellP = 75
    _items(2, 12)._sellP = 90
    _items(2, 13)._sellP = 120
    _items(2, 14)._sellP = 90
    _items(2, 15)._sellP = 50
    _items(2, 16)._sellP = 115
    _items(2, 17)._sellP = 150
    _items(2, 18)._sellP = 60
    _items(2, 19)._sellP = 250
    _items(2, 20)._sellP = 70
    _items(2, 21)._sellP = 80
    _items(2, 22)._sellP = 110
    _items(2, 23)._sellP = 160
    _items(2, 24)._sellP = 85
    _items(2, 25)._sellP = 270

    'Информация
    'оружие
    _items(2, 1)._infoWeapons = "Сила +10                               "
    _items(2, 2)._infoWeapons = "Сила +12                               "
    _items(2, 3)._infoWeapons = "Сила +9                                "
    _items(2, 4)._infoWeapons = "Сила +8                                "
    _items(2, 5)._infoWeapons = "Сила +25                               "
    _items(2, 6)._infoWeapons = "Сила +15                               "
    _items(2, 7)._infoWeapons = "Сила +14                               "
    _items(2, 8)._infoWeapons = "Сила +9                                "
    _items(2, 9)._infoWeapons = "Сила +10                               "
    _items(2, 10)._infoWeapons = "Сила +17                               "
    _items(2, 11)._infoWeapons = "Интеллект +10                          "
    _items(2, 12)._infoWeapons = "Интеллект +11                          "
    _items(2, 13)._infoWeapons = "Интеллект +9                           "
    _items(2, 14)._infoWeapons = "Интеллект +13                          "
    _items(2, 15)._infoWeapons = "Интеллект +11                          "
    _items(2, 16)._infoWeapons = "Интеллект +15                          "
    _items(2, 17)._infoWeapons = "Интеллект +16                          "
    _items(2, 18)._infoWeapons = "Интеллект +14                          "
    _items(2, 19)._infoWeapons = "Интеллект +24                          "
    _items(2, 20)._infoWeapons = "Интеллект +8                           "
    _items(2, 21)._infoWeapons = "Ловкость +5 Точность +2                "
    _items(2, 22)._infoWeapons = "Ловкость +17 Точность +3               "
    _items(2, 23)._infoWeapons = "Ловкость +14 Точность +4               "
    _items(2, 24)._infoWeapons = "Ловкость +5 Точность +1                "
    _items(2, 25)._infoWeapons = "Ловкость +22 Точность +5               "
    _items(2, 26)._infoWeapons = "Ловкость +12 Точность +5               "
    _items(2, 27)._infoWeapons = "Ловкость +8 Точность +3                "
    _items(2, 28)._infoWeapons = "Ловкость +4 Точность +2                "
    _items(2, 29)._infoWeapons = "Ловкость +5 Точность +1                "
    _items(2, 30)._infoWeapons = "Ловкость +12 Точность +4               "
    _items(2, 31)._infoWeapons = "Защита +5 Точность +2                  "
    _items(2, 32)._infoWeapons = "Защита +4 Точность +3                  "
    _items(2, 33)._infoWeapons = "Защита +2 Точность +2                  "
    _items(2, 34)._infoWeapons = "Защита +15 Точность +4                 "
    _items(2, 35)._infoWeapons = "Защита +16 Точность +4                 "
    _items(2, 36)._infoWeapons = "Защита +5 Точность +1                  "
    _items(2, 37)._infoWeapons = "Защита +14 Точность +4                 "
    _items(2, 38)._infoWeapons = "Защита +17 Точность +4                 "
    _items(2, 39)._infoWeapons = "Защита +12 Точность +2                 "
    _items(2, 40)._infoWeapons = "Защита +23 Точность +5                 "
    'доспехи
    _items(2, 1)._infoprotection = "Защита +5 Ловкость +5                "
    _items(2, 2)._infoprotection = "                                     "
    _items(2, 3)._infoprotection = "Защита +3                            "
    _items(2, 4)._infoprotection = "Защита +2 Ловкость +1                "
    _items(2, 5)._infoprotection = "Точность +1                          "
    _items(2, 6)._infoprotection = "Защита +4 Точность +2                "
    _items(2, 7)._infoprotection = "Защита +5 Ловкость +3 Точность +1    "
    _items(2, 8)._infoprotection = "Ловкость +5 Точность +1              "
    _items(2, 9)._infoprotection = "Ловкость +4                          "
    _items(2, 10)._infoprotection = "Ловкость +3                          "
    _items(2, 11)._infoprotection = "Ловкость +6 Точность +2              "
    _items(2, 12)._infoprotection = "Защита +10 Ловкость +4               "
    _items(2, 13)._infoprotection = "Ловкость +7                          "
    _items(2, 14)._infoprotection = "Точность +2                          "
    _items(2, 15)._infoprotection = "Защита +5 Ловкость +5                "
    _items(2, 16)._infoprotection = "Защита +2                            "
    _items(2, 17)._infoprotection = "Защита +4 Ловкость +3                "
    _items(2, 18)._infoprotection = "Защита +6 Ловкость +4                "
    _items(2, 19)._infoprotection = "Защита +4 Интеллект +4               "
    _items(2, 20)._infoprotection = "Защита +4 Точность +3                "
    _items(2, 21)._infoprotection = "Ловкость +5                          "
    _items(2, 22)._infoprotection = "Ловкость +4                          "
    _items(2, 23)._infoprotection = "Защита +3 Ловкость +6                "
    _items(2, 24)._infoprotection = "Защита +4 Ловкость +3 Точность +4    "
    _items(2, 25)._infoprotection = "Защита +9 Ловкость +4 Точность +1    "

  End Sub
  'Операции проходящие внутри городов
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
  'Флаконы жизни
  Private Sub Liveflac(ByVal _local As Integer)
    If _local = 2 Then _money -= 15
    _botleLive += 1
    Console.SetCursorPosition(0, 6)
    _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
    Console.WriteLine("     _______________                                                   ")
    Console.WriteLine("    ║ Флаконы пополнились.                ")
    Console.WriteLine("    └                                     ")
    Console.WriteLine("                                        ")
    Console.WriteLine("                                        ")
    Console.WriteLine("                                        ")
    Console.WriteLine("                                        ")
    Console.ReadLine()
  End Sub

  Private Sub Manaflac(ByVal _local As Integer)
    If _local = 2 Then _money -= 20
    _botleMana += 1
    Console.SetCursorPosition(0, 6)
    _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
    Console.WriteLine("     _______________                                                   ")
    Console.WriteLine("    ║ Флаконы пополнились.                  ")
    Console.WriteLine("    └                                       ")
    Console.WriteLine("                                          ")
    Console.WriteLine("                                          ")
    Console.WriteLine("                                          ")
    Console.WriteLine("                                          ")
    Console.ReadLine()
  End Sub

End Class
