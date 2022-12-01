Imports testRPGC.Enemy

Public Class Cityes
  ReadOnly _txtRGB As New SystemColorConsole
  Public _hero As New Hero
  Public _map As New Map
  Public viaponRand(3) As Integer
  Structure _predmets
    Public _nameweapons, _nameprotection, _nameitems As String
    Public _sellW, _sellP, _sellI As Integer
  End Structure
  Public _items(10, 10) As _predmets
  Public _bag(10) As String

  Public Sub VivodCity2()
    Dim citylive, personslive, sayPerson As Integer
    While citylive <> 5
      Console.SetCursorPosition(0, 4)
      Console.WriteLine()
      Console.WriteLine()
      _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
      Console.WriteLine("     _______________                                             ")
      Console.WriteLine("    ║ 1. Осмотреть город                                         ")
      Console.WriteLine("    │ 2. Изучить историю                                         ")
      Console.WriteLine("    │ 3. Обратиться к жителям                                    ")
      Console.WriteLine("    │ 4. Доска гильдии авантюристов                              ")
      Console.WriteLine("    │ 5. Уйти                                                    ")
      Console.WriteLine("    └                                                            ")

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
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Жители                                       ")
            Console.WriteLine("    ║ 1. Зельевар                                                ")
            Console.WriteLine("    │ 2. Печальный ремесленник                                   ")
            Console.WriteLine("    │ 3. Кузнец                                                  ")
            Console.WriteLine("    │ 4. Торговец                                                ")
            Console.WriteLine("    │ 5. Уйти                                                    ")
            Console.WriteLine("    └                                                            ")

            Dim infop As ConsoleKeyInfo = Console.ReadKey()
            Try
              personslive = infop.Key - 48
            Catch ex As Exception

            End Try
            Select Case personslive
              Case 1 'Зельевар
                While sayPerson <> 5
                  Personstat("Зельевар", 2)
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
                      If _money > 20 Then manaflac(2)
                    Case 4
                      'Добавить раздел сюжета
                  End Select
                End While
                sayPerson = 0
              Case 2 'Печальный ремесленник
                While sayPerson <> 3
                  Personstat("Ремесленник", 2)
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
                While sayPerson <> 4
                  Personstat("Кузнец", 2)
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

                  End Select
                End While
                sayPerson = 0
              Case 4 'Торговец
                While sayPerson <> 4
                  Personstat("Торговец", 2)
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

      End Select
    End While

  End Sub

  Public Sub Personstat(ByVal _namePers As String, ByVal _location As Integer)
    Select Case _location
      Case 2
        Select Case _namePers
          Case "Зельевар"
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Зельевар                               ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Купить флакон здоровья - 15 монет                 ")
            Console.WriteLine("    │ 3. Купить флакон маны - 20 монет                     ")
            Console.WriteLine("    │ 4. Поговорить                                        ")
            Console.WriteLine("    │ 5. Уйти                                              ")
            Console.WriteLine("    └                                                      ")
          Case "Ремесленник"
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Печальный ремесленник                           ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Поговорить                                        ")
            Console.WriteLine("    │ 3. Уйти                                              ")
            Console.WriteLine("    └                                                      ")
            Console.WriteLine("                                                         ")
            Console.WriteLine("                                                         ")
          Case "Кузнец"
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Кузнец                           ")
            Console.WriteLine("    ║ 1. Осмотреть                                         ")
            Console.WriteLine("    │ 2. Поговорить                                        ")
            Console.WriteLine("    │ 3. Ковать                                            ")
            Console.WriteLine("    │ 4. Выход                                             ")
            Console.WriteLine("    └                                                    ")
            Console.WriteLine("                                                         ")
          Case "Торговец"
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
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
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
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
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
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
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
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
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
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

  Public Sub Torg(ByVal _number As Integer) 'Доделать!
    Dim torgtime As String
    torgtime = 0
    While torgtime <> 5
      Select Case _number
        Case 2
          Console.SetCursorPosition(0, 4)
          Console.WriteLine()
          Console.WriteLine()
          _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
          Console.WriteLine("     _______________Торговец          ")
          Console.WriteLine("    ║ 1. Оружие                                                                      ")
          Console.WriteLine("    │ 2. Барахолка                                                                   ")
          Console.WriteLine("    │ 3. Броня                                                                       ")
          Console.WriteLine("    │ 4. Продать                                                                     ")
          Console.WriteLine("    │ 5. Уйти                                                                        ")
          Console.WriteLine("    └                                                                                ")
          Dim infotorg As ConsoleKeyInfo = Console.ReadKey()
          Try
            torgtime = infotorg.Key - 48
          Catch ex As Exception

          End Try
          Select Case torgtime
            Case 1
              Torggorod2(1)
            Case 2
              Torggorod2(2)
            Case 3
              Torggorod2(3)
            Case 4
              Sell()
          End Select
      End Select
    End While
    torgtime = 0
  End Sub

  Public Sub Sell()
    Dim payitems As String
    payitems = 0
    If _bag(1) = "|Пусто|" And _bag(2) = "|Пусто|" And _bag(3) = "|Пусто|" And _bag(4) = "|Пусто|" And _bag(5) = "|Пусто|" And _bag(6) = "|Пусто|" And _bag(7) = "|Пусто|" And _bag(8) = "|Пусто|" And _bag(9) = "|Пусто|" And _bag(10) = "|Пусто|" Then
      Console.SetCursorPosition(0, 4)
      Console.WriteLine()
      Console.WriteLine()
      _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
      Console.WriteLine("     _______________                                                   ")
      Console.WriteLine("    ║ Прости, но тебе нечего мне продать           ")
      Console.WriteLine("    └                                     ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.ReadLine()
    Else
      Console.SetCursorPosition(0, 4)
      Console.WriteLine()
      Console.WriteLine()
      _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
      Console.WriteLine("     _______________Торговец          ")
      Console.Write("  1. ")
      Visbag(_bag(1))
      Console.Write(vbTab & vbTab & "2. ")
      Visbag(_bag(2))
      Console.WriteLine()
      Console.Write("  3. ")
      Visbag(_bag(3))
      Console.Write(vbTab & vbTab & "4. ")
      Visbag(_bag(4))
      Console.WriteLine()
      Console.Write("  5. ")
      Visbag(_bag(5))
      Console.Write(vbTab & vbTab & "6. ")
      Visbag(_bag(6))
      Console.WriteLine()
      Console.Write("  7. ")
      Visbag(_bag(7))
      Console.Write(vbTab & vbTab & "8. ")
      Visbag(_bag(8))
      Console.WriteLine()
      Console.Write("  9. ")
      Visbag(_bag(9))
      Console.Write(vbTab & vbTab & "0. ")
      Visbag(_bag(10))
      Console.WriteLine()
      Console.ReadLine()

    End If

  End Sub

  Public Sub Torggorod2(ByVal _punkt As Integer)
    Dim byitems As String
    byitems = 0
    If _bag(1) <> "|Пусто|" And _bag(2) <> "|Пусто|" And _bag(3) <> "|Пусто|" And _bag(4) <> "|Пусто|" And _bag(5) <> "|Пусто|" And _bag(6) <> "|Пусто|" And _bag(7) <> "|Пусто|" And _bag(8) <> "|Пусто|" And _bag(9) <> "|Пусто|" And _bag(10) <> "|Пусто|" Then
      Console.SetCursorPosition(0, 4)
      Console.WriteLine()
      Console.WriteLine()
      _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
      Console.WriteLine("     _______________Торговец          ")
      Console.WriteLine("    ║ Прости друг, но я тебе нечего не           ")
      Console.WriteLine("    │ продам, тебе некуда складывать вещи.         ")
      Console.WriteLine("    └                                    ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.WriteLine("                                        ")
      Console.ReadLine()
    Else
      Select Case _punkt
        Case 1
          While byitems <> 5
            Dim viRand = New Random(DateTime.Now.Millisecond)
            Console.SetCursorPosition(0, 4)
            Console.WriteLine()
            Console.WriteLine()
            _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
            Console.WriteLine("     _______________Торговец          ")
            viaponRand(1) = viRand.Next(1, 8)
            Console.WriteLine("    ║ 1. " & _items(2, viaponRand(1))._nameweapons & "  " & _items(2, viaponRand(1))._sellW & "          ")
            viaponRand(2) = viRand.Next(1, 8)
            Console.WriteLine("    │ 2. " & _items(2, viaponRand(2))._nameweapons & "  " & _items(2, viaponRand(2))._sellW & "          ")
            viaponRand(3) = viRand.Next(1, 8)
            Console.WriteLine("    │ 3. " & _items(2, viaponRand(3))._nameweapons & "  " & _items(2, viaponRand(3))._sellW & "          ")
            Console.WriteLine("    │ 4. Обновить                          ")
            Console.WriteLine("    │ 5. Уйти                             ")
            Console.WriteLine("    └                                     ")
            Dim infotorgviapon As ConsoleKeyInfo = Console.ReadKey()
            Try
              byitems = infotorgviapon.Key - 48
            Catch ex As Exception

            End Try
            Select Case byitems
              Case 1

                Try
                  For _bye = 1 To 10
                    If _bag(_bye) = "|Пусто|" Then
                      _bag(_bye) = _items(2, viaponRand(1))._nameweapons
                      Exit For
                    End If
                  Next
                  Console.SetCursorPosition(0, 4)
                  Console.WriteLine()
                  Console.WriteLine()
                  _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
                  Console.WriteLine("     _______________Торговец          ")
                  Console.WriteLine("    ║ Покупка совершена.                  ")
                  Console.WriteLine("    └                                     ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                  byitems = 5
                Catch ex As Exception

                End Try

              Case 2
                Try
                  For _bye = 1 To 10
                    If _bag(_bye) = "|Пусто|" Then
                      _bag(_bye) = _items(2, viaponRand(2))._nameweapons
                      Exit For
                    End If
                  Next
                  Console.SetCursorPosition(0, 4)
                  Console.WriteLine()
                  Console.WriteLine()
                  _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
                  Console.WriteLine("     _______________Торговец          ")
                  Console.WriteLine("    ║ Покупка совершена.")
                  Console.WriteLine("    └                                     ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                  byitems = 5
                Catch ex As Exception

                End Try

              Case 3
                Try
                  For _bye = 1 To 10
                    If _bag(_bye) = "|Пусто|" Then
                      _bag(_bye) = _items(2, viaponRand(3))._nameweapons
                      Exit For
                    End If
                  Next
                  Console.SetCursorPosition(0, 4)
                  Console.WriteLine()
                  Console.WriteLine()
                  _txtRGB.TxtRGB("White", "Black", "     | Город одичалых |                 ", True)
                  Console.WriteLine("     _______________Торговец          ")
                  Console.WriteLine("    ║ Покупка совершена.")
                  Console.WriteLine("    └                                     ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.WriteLine("                                        ")
                  Console.ReadLine()
                  byitems = 5
                Catch ex As Exception

                End Try

              Case 4

            End Select
          End While

        Case 2

        Case 3


      End Select
    End If
  End Sub

  Public Sub Liveflac(ByVal _local As Integer)
    If _local = 2 Then _money -= 15
    _botleLive += 1
    Console.SetCursorPosition(0, 4)
    Console.WriteLine()
    Console.WriteLine()
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

  Public Sub manaflac(ByVal _local As Integer)
    If _local = 2 Then _money -= 20
    _botleMana += 1
    Console.SetCursorPosition(0, 4)
    Console.WriteLine()
    Console.WriteLine()
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

  Public Sub StatsItems()
    'Предметы города в гнилистых лесах.
    'Оружие
    _items(2, 1)._nameweapons = "Ржавый кованый меч"
    _items(2, 2)._nameweapons = "Ржавый двуручный меч"
    _items(2, 3)._nameweapons = "Ржавый стальной кинжал"
    _items(2, 4)._nameweapons = "Ржавый короткий кинжал"
    _items(2, 5)._nameweapons = "Стальной меч"
    _items(2, 6)._nameweapons = "Гнутый двуручный меч"
    _items(2, 7)._nameweapons = "Заляпаный тесак"
    _items(2, 8)._nameweapons = "Нож для мяса"
    'Доспехи

    'Предметы

    'Цена
    _items(2, 1)._sellW = 100
    _items(2, 2)._sellW = 120
    _items(2, 3)._sellW = 90
    _items(2, 4)._sellW = 90
    _items(2, 5)._sellW = 250
    _items(2, 6)._sellW = 115
    _items(2, 7)._sellW = 150
    _items(2, 8)._sellW = 50



  End Sub
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

End Class
