Imports System
Imports System.Text
Imports System.IO
Imports System.Drawing

Module Program
  Public _txtRGB As New SystemColorConsole
  Public _local0 As Integer(,) = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

  Public _mapTest As Integer(,) = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

  Public _save, _pointX, _pointY, _multitool As Integer
  Public _poiSet, _pointHero, fontprint, backprint, printset, menu1 As String
  Public _menuVibor(20) As String
  Sub Main()
    _pointHero = 0
    _multitool = 0
    fontprint = "DarkRed"
    backprint = "DarkGray"
    printset = "█"
    _pointX = 1
    _pointY = 1
    menu1 = 0

    While _poiSet <> "29"
      Console.SetCursorPosition(0, 1)
      _txtRGB.WhiteFonfSys()
      Console.WriteLine("          ║Для перемещения используйте клавиши w,a,s,d. Для изменения биома нажмите клавишу e.")
      CraftMap29(_pointX, _pointY)
      Multicase(_multitool)
      Click_Botton(49, 15)
      Console.SetCursorPosition(14, 23)
    End While
    Console.ReadLine()
  End Sub
  Public Sub Click_Botton(ByVal _Point_X As Int16, ByVal _point_Y As Integer)
    _txtRGB.BlackFonfSys()
    Dim info As ConsoleKeyInfo = Console.ReadKey()
    Try
      _pointHero = info.Key
      Select Case _pointHero
        'Клавиши передвижения
        Case 87
          If _pointY > 1 Then _pointY -= 1
        Case 65
          If _pointX > 1 Then _pointX -= 1
        Case 83
          If _pointY < _point_Y Then _pointY += 1
        Case 68
          If _pointX < _Point_X Then _pointX += 1
        Case 69
          _menuVibor(1) = 10
          TextunderMap(_pointY, _pointX)
        Case 81
          If _multitool <> 0 Then
            _mapTest(_pointY, _pointX) = _multitool
          End If
        Case 90
          If _multitool <> 0 Then
            _mapTest(_pointY, _pointX) = _multitool
            _mapTest(_pointY + 1, _pointX) = _multitool
            _mapTest(_pointY - 1, _pointX) = _multitool
            _mapTest(_pointY, _pointX + 1) = _multitool
            _mapTest(_pointY, _pointX - 1) = _multitool
            _mapTest(_pointY + 1, _pointX + 1) = _multitool
            _mapTest(_pointY + 1, _pointX - 1) = _multitool
            _mapTest(_pointY - 1, _pointX + 1) = _multitool
            _mapTest(_pointY - 1, _pointX - 1) = _multitool
          End If
        Case 70 'фон
          For i = 0 To 16
            For j = 0 To 50
              _mapTest(i, j) = _multitool
            Next
          Next

        Case 78 'Сохранение
          SaveData()
      End Select
    Catch ex As Exception

    End Try

  End Sub
  Public Sub CraftMap29(ByVal _x As Integer, ByVal _y As Integer)
    Console.Write("              ")
    For i = 0 To 16
      For j = 0 To 50
        If _x = j And _y = i Then
          _txtRGB.TxtRGB(fontprint, backprint, printset, False)
        Else

          If (i = 0 Or i = 16) Or (j = 0 Or j = 50) Then
            Console.CursorVisible = False
            _txtRGB.TxtRGB("Black", "Cyan", "▓", False)
            Console.BackgroundColor = ConsoleColor.Black
            'ElseIf (i > 0 And i < 16) Or (j > 0 Or j < 50) Then
            '  Console.BackgroundColor = ConsoleColor.Black
            '  Console.ForegroundColor = ConsoleColor.Black
          Else
            Try
              If _mapTest(i, j) = 0 Then Console.Write("░")
              ColorSquear(_mapTest(i, j))
            Catch ex As Exception
              Console.WriteLine("Ошибка построения карты.")
            End Try
          End If

        End If
      Next
      Console.WriteLine("  ")
      Console.Write("              ")
    Next
    Console.WriteLine("  ")
    Console.Write("              ")
  End Sub
  Public Sub TextunderMap(ByVal _x As Integer, ByVal _y As Integer)
    While _menuVibor(1) <> "5"
      Console.SetCursorPosition(14, 19)
      _txtRGB.WhiteFonfSys()
      Console.WriteLine(" Выберите биом:                                       ")
      Console.WriteLine("           ___________________________________________")
      Console.WriteLine("          ║ 1. Земля        5. Выход                                ")
      Console.WriteLine("          │ 2. Леса                                                 ")
      Console.WriteLine("          │ 3. Реки                                                 ")
      Console.WriteLine("          │ 4. Города                                               ")
      Console.WriteLine("          └                                                         ")
      _txtRGB.BlackFonfSys()
      Dim infom As ConsoleKeyInfo = Console.ReadKey()
      Try
        _menuVibor(1) = infom.Key - 48
        Console.SetCursorPosition(14, 19)
        _txtRGB.WhiteFonfSys()
      Catch ex As Exception
      End Try
      Select Case _menuVibor(1)
        Case 1
          While _menuVibor(2) <> "8"
            Console.WriteLine(" Вы выбрали 'Земля'                                   ")
            Console.WriteLine("           ___________________________________________")
            Console.Write("          ║ 1. Болотная Земля ")
            _txtRGB.TxtRGB("DarkGreen", "DarkGray", "░", False) 'Болотная Земля 1
            Console.Write("   5. Вырубленный лес ") '5
            _txtRGB.TxtRGB("DarkYellow", "Black", "▓", True)
            Console.Write("          │ 2. Камни и горы   ")
            _txtRGB.TxtRGB("DarkGray", "Black", "░", False) '2
            Console.WriteLine("   6. Дороги                              ")
            Console.Write("          │ 3. Низины         ")
            _txtRGB.TxtRGB("DarkGray", "DarkGreen", "▒", False) '3
            Console.WriteLine("   7. Другое                              ")
            Console.Write("          │ 4. Поля           ")
            _txtRGB.TxtRGB("DarkYellow", "DarkGreen", "▓", False) '4
            Console.WriteLine("   8. Выход                               ")
            Console.WriteLine("          └                                           ")
            Dim infom1 As ConsoleKeyInfo = Console.ReadKey()
            Try
              _menuVibor(2) = infom1.Key - 48
              Console.SetCursorPosition(14, 19)
              _txtRGB.WhiteFonfSys()

            Catch ex As Exception
            End Try
            Select Case _menuVibor(2)
              Case 1
                _mapTest(_x, _y) = 1
                _multitool = 1
                _menuVibor(2) = "8"
                _menuVibor(1) = "5"
              Case 2
                _mapTest(_x, _y) = 2
                _multitool = 2
                _menuVibor(2) = "8"
                _menuVibor(1) = "5"
              Case 3
                _mapTest(_x, _y) = 3
                _multitool = 3
                _menuVibor(2) = "8"
                _menuVibor(1) = "5"
              Case 4
                _mapTest(_x, _y) = 4
                _multitool = 4
                _menuVibor(2) = "8"
                _menuVibor(1) = "5"
              Case 5
                _mapTest(_x, _y) = 5
                _multitool = 5
                _menuVibor(2) = "8"
                _menuVibor(1) = "5"
              Case 6
                While _menuVibor(6) <> "6"
                  Console.WriteLine(" Вы выбрали 'Дороги'                                  ")
                  Console.WriteLine("           ___________________________________________")
                  Console.Write("          ║ 1. Обычная         ")
                  _txtRGB.TxtRGB("DarkYellow", "DarkGray", "▓", False) 'Дорога 6
                  Console.Write("    5. Дорожный камень     ")
                  _txtRGB.TxtRGB("DarkGreen", "Black", "▓", False) 'Дорога 10
                  Console.WriteLine("                                                                         ")
                  Console.Write("          │ 2. Каменная        ")
                  _txtRGB.TxtRGB("DarkYellow", "Black", "▓", False) 'Дорога 7
                  Console.WriteLine("    6. Выход                                                             ")
                  Console.Write("          │ 3. Затоптанная     ")
                  _txtRGB.TxtRGB("Yellow", "DarkGreen", "░", False) 'Дорога 8
                  Console.WriteLine("                                                                         ")
                  Console.Write("          │ 4. Край дороги     ")
                  _txtRGB.TxtRGB("DarkYellow", "DarkGray", "▒", False)  'Дорога 9
                  Console.WriteLine("                                                                         ")
                  Console.WriteLine("          └                                                              ")
                  Dim infom7 As ConsoleKeyInfo = Console.ReadKey()
                  Try
                    _menuVibor(6) = infom7.Key - 48
                    Console.SetCursorPosition(14, 19)
                    _txtRGB.WhiteFonfSys()

                  Catch ex As Exception
                  End Try
                  Select Case _menuVibor(6)
                    Case 1
                      _mapTest(_x, _y) = 6
                      _multitool = 6
                      _menuVibor(6) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 2
                      _mapTest(_x, _y) = 7
                      _multitool = 7
                      _menuVibor(6) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 3
                      _mapTest(_x, _y) = 8
                      _multitool = 8
                      _menuVibor(6) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 4
                      _mapTest(_x, _y) = 9
                      _multitool = 9
                      _menuVibor(6) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 5
                      _mapTest(_x, _y) = 10
                      _multitool = 10
                      _menuVibor(6) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                  End Select
                End While
                _menuVibor(6) = 0

              Case 7
                While _menuVibor(7) <> "6"
                  Console.WriteLine(" Вы выбрали 'Прочее'                                  ")
                  Console.WriteLine("           ___________________________________________")
                  Console.Write("          ║ 1. Снег         ")
                  _txtRGB.TxtRGB("White", "DarkGray", "░", False) 'Снег 11
                  Console.Write("   5. Затвердевшая лава  ")
                  _txtRGB.TxtRGB("Red", "Black", "░", False) 'Затвердевшая лава 15
                  Console.WriteLine("                                                                 ")
                  Console.Write("          │ 2. Лёд          ")
                  _txtRGB.TxtRGB("Cyan", "Blue", "▓", False) 'Тонкий лёд 12
                  Console.WriteLine("   6. Выход                      ")
                  Console.Write("          │ 3. Тонкий лёд   ")
                  _txtRGB.TxtRGB("Cyan", "DarkBlue", "▒", False) 'Тонкий лёд 13
                  Console.WriteLine("                                                                 ")
                  Console.Write("          │ 4. Лава         ")
                  _txtRGB.TxtRGB("DarkRed", "DarkYellow", "▓", False) 'Лава 14
                  Console.WriteLine("                                                                 ")
                  Console.WriteLine("          └                                           ")
                  Dim infom8 As ConsoleKeyInfo = Console.ReadKey()
                  Try
                    _menuVibor(7) = infom8.Key - 48
                    Console.SetCursorPosition(14, 19)
                    _txtRGB.WhiteFonfSys()

                  Catch ex As Exception
                  End Try
                  Select Case _menuVibor(7)
                    Case 1
                      _mapTest(_x, _y) = 11
                      _multitool = 11
                      _menuVibor(7) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 2
                      _mapTest(_x, _y) = 12
                      _multitool = 12
                      _menuVibor(7) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 3
                      _mapTest(_x, _y) = 13
                      _multitool = 13
                      _menuVibor(7) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 4
                      _mapTest(_x, _y) = 14
                      _multitool = 14
                      _menuVibor(7) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                    Case 5
                      _mapTest(_x, _y) = 15
                      _multitool = 15
                      _menuVibor(7) = "6"
                      _menuVibor(2) = "8"
                      _menuVibor(1) = "5"
                  End Select
                End While
                _menuVibor(7) = "0"
            End Select

          End While
          _menuVibor(2) = "0"
        Case 2
          While _menuVibor(3) <> "4"
            Console.WriteLine(" Вы выбрали 'Леса'                                    ")
            Console.WriteLine("           ___________________________________________")
            Console.Write("          ║ 1. Простые       ")
            _txtRGB.TxtRGB("Cyan", "DarkGreen", "░", False) 'Лес 16
            Console.WriteLine("                                                                 ")
            Console.Write("          │ 2. Эльфийские    ")
            _txtRGB.TxtRGB("Black", "DarkGreen", "░", False) 'Эльфийский Лес 17
            Console.WriteLine("                                                               ")
            Console.Write("          │ 3. Заражённые    ")
            _txtRGB.TxtRGB("DarkMagenta", "Black", "░", False) 'Заражённый лес 18
            Console.WriteLine("                                                                  ")
            Console.WriteLine("          │ 4. Выход                                  ")
            Console.WriteLine("          └                                           ")
            Dim infom2 As ConsoleKeyInfo = Console.ReadKey()
            Try
              _menuVibor(3) = infom2.Key - 48
              Console.SetCursorPosition(14, 19)
              _txtRGB.WhiteFonfSys()

            Catch ex As Exception
            End Try
            Select Case _menuVibor(3)
              Case 1
                _mapTest(_x, _y) = 16
                _multitool = 16
                _menuVibor(3) = "4"
                _menuVibor(1) = "5"
              Case 2
                _mapTest(_x, _y) = 17
                _multitool = 17
                _menuVibor(3) = "4"
                _menuVibor(1) = "5"
              Case 3
                _mapTest(_x, _y) = 18
                _multitool = 18
                _menuVibor(3) = "4"
                _menuVibor(1) = "5"
            End Select
          End While
          _menuVibor(3) = "0"
        Case 3
          While _menuVibor(4) <> "7"
            Console.WriteLine(" Вы выбрали 'Реки'                                   ")
            Console.WriteLine("           ___________________________________________")
            Console.Write("          ║ 1. Водная местность  ")
            _txtRGB.TxtRGB("Blue", "Black", "░", False) 'Водная местность 19
            Console.Write("     5. Край болота  ")
            _txtRGB.TxtRGB("Black", "DarkGray", "░", True) 'Водная местность 23
            Console.Write("          │ 2. Мелководье        ")
            _txtRGB.TxtRGB("White", "DarkBlue", "░", False) 'Водная местность 20
            Console.Write("     6. Дно болота   ")
            _txtRGB.TxtRGB("DarkGreen", "Black", "░", True) 'Водная местность 24
            Console.Write("          │ 3. Берег             ")
            _txtRGB.TxtRGB("White", "Cyan", "░", False)  'Речная местность 21
            Console.WriteLine("     7. Выход                                 ")
            Console.Write("          │ 4. Болото            ")
            _txtRGB.TxtRGB("DarkGreen", "Black", "▒", True)  'Речная местность 22
            Console.WriteLine("          └                                           ")
            Dim infom3 As ConsoleKeyInfo = Console.ReadKey()
            Try
              _menuVibor(4) = infom3.Key - 48
              Console.SetCursorPosition(14, 19)
              _txtRGB.WhiteFonfSys()

            Catch ex As Exception
            End Try
            Select Case _menuVibor(4)
              Case 1
                _mapTest(_x, _y) = 19
                _multitool = 19
                _menuVibor(4) = "7"
                _menuVibor(1) = "5"
              Case 2
                _mapTest(_x, _y) = 20
                _multitool = 20
                _menuVibor(4) = "7"
                _menuVibor(1) = "5"
              Case 3
                _mapTest(_x, _y) = 21
                _multitool = 21
                _menuVibor(4) = "7"
                _menuVibor(1) = "5"
              Case 4
                _mapTest(_x, _y) = 22
                _multitool = 22
                _menuVibor(4) = "7"
                _menuVibor(1) = "5"
              Case 5
                _mapTest(_x, _y) = 23
                _multitool = 23
                _menuVibor(4) = "7"
                _menuVibor(1) = "5"
              Case 6
                _mapTest(_x, _y) = 24
                _multitool = 24
                _menuVibor(4) = "7"
                _menuVibor(1) = "5"
            End Select

          End While
          _menuVibor(4) = "0"
        Case 4
          While _menuVibor(5) <> "7"
            Console.WriteLine(" Вы выбрали 'Города'                                  ")
            Console.WriteLine("           ___________________________________________")
            Console.Write("          ║ 1. Заброшенные  ")
            _txtRGB.TxtRGB("DarkMagenta", "Black", "░", False) '25
            Console.Write("   5. Заброшенные  деревни    ")
            _txtRGB.TxtRGB("DarkRed", "Black", "▓", True) '29
            Console.Write("          │ 2. Действующие  ")
            _txtRGB.TxtRGB("Black", "DarkBlue", "░", False) '26
            Console.Write("   6. Стены укреплений        ")
            _txtRGB.TxtRGB("Black", "DarkMagenta", "▓", True) '30
            Console.Write("          │ 3. Руины        ")
            _txtRGB.TxtRGB("Red", "Black", "░", False) '27
            Console.WriteLine("   7. Выход                                           ")
            Console.Write("          │ 4. Каменный пол ")
            _txtRGB.TxtRGB("Black", "DarkGray", "▒", True) '28
            Console.WriteLine("          └                                           ")
              Dim infom4 As ConsoleKeyInfo = Console.ReadKey()
            Try
              _menuVibor(5) = infom4.Key - 48
              Console.SetCursorPosition(14, 19)
              _txtRGB.WhiteFonfSys()

            Catch ex As Exception
            End Try
            Select Case _menuVibor(5)
              Case 1
                _mapTest(_x, _y) = 25
                _multitool = 25
                _menuVibor(5) = "7"
                _menuVibor(1) = "5"
              Case 2
                _mapTest(_x, _y) = 26
                _multitool = 26
                _menuVibor(5) = "7"
                _menuVibor(1) = "5"
              Case 3
                _mapTest(_x, _y) = 27
                _multitool = 27
                _menuVibor(5) = "7"
                _menuVibor(1) = "5"
              Case 4
                _mapTest(_x, _y) = 28
                _multitool = 28
                _menuVibor(5) = "7"
                _menuVibor(1) = "5"
              Case 5
                _mapTest(_x, _y) = 29
                _multitool = 29
                _menuVibor(5) = "7"
                _menuVibor(1) = "5"
              Case 6
                _mapTest(_x, _y) = 30
                _multitool = 30
                _menuVibor(5) = "7"
                _menuVibor(1) = "5"
            End Select

          End While
          _menuVibor(5) = "0"

      End Select
    End While
    Console.SetCursorPosition(14, 19)
    _txtRGB.WhiteFonfSys()
    Console.WriteLine("                                                      ")
    Console.WriteLine("                                                      ")
    Console.WriteLine("                                                      ")
    Console.WriteLine("                                                      ")
    Console.WriteLine("                                                      ")
    Console.WriteLine("                                                      ")
    Console.WriteLine("                                                      ")
    _txtRGB.BlackFonfSys()
  End Sub


  Public Sub Multicase(ByVal _tool As Integer)
    If _tool <> 0 Then
      Console.SetCursorPosition(67, 2)
      Console.Write("Избранное:")
      Console.SetCursorPosition(67, 3)
      Console.Write("q | ")
      ColorSquear(_tool)
      Console.SetCursorPosition(67, 5)
      Console.Write("Больше:")
      Console.SetCursorPosition(67, 6)
      Console.Write("z | ")
      ColorSquear(_tool)
      ColorSquear(_tool)
      ColorSquear(_tool)
      Console.SetCursorPosition(71, 7)
      ColorSquear(_tool)
      ColorSquear(_tool)
      ColorSquear(_tool)
      Console.SetCursorPosition(71, 8)
      ColorSquear(_tool)
      ColorSquear(_tool)
      ColorSquear(_tool)
      Console.SetCursorPosition(67, 10)
      Console.Write("Фон: f")
      Console.SetCursorPosition(67, 12)
      Console.Write("Сохранить: n")
    End If
  End Sub

  Public Sub ColorSquear(ByVal _toolQ As Integer) '░ ▒ ▓
    If _toolQ = 1 Then _txtRGB.TxtRGB("DarkGreen", "DarkGray", "░", False) 'Болотная Земля 1
    If _toolQ = 2 Then _txtRGB.TxtRGB("DarkGray", "Black", "░", False) 'Камни и горы 2
    If _toolQ = 3 Then _txtRGB.TxtRGB("DarkGray", "DarkGreen", "▓", False) ' Низины 3
    If _toolQ = 4 Then _txtRGB.TxtRGB("DarkYellow", "DarkGreen", "▓", False) ' Поля 4
    If _toolQ = 5 Then _txtRGB.TxtRGB("DarkYellow", "Black", "▓", False) ' Вырубленный лес 5
    '--------------------------------------------------------------------------------
    If _toolQ = 6 Then _txtRGB.TxtRGB("DarkYellow", "DarkGray", "▓", False) 'Дорога обычная 6
    If _toolQ = 7 Then _txtRGB.TxtRGB("DarkYellow", "DarkGray", "▒", False) 'Край дороги 7
    If _toolQ = 8 Then _txtRGB.TxtRGB("DarkGreen", "Black", "▓", False) 'Дорожный камень 8 
    If _toolQ = 9 Then _txtRGB.TxtRGB("DarkYellow", "Black", "▓", False) 'Дорога каменная 9
    If _toolQ = 10 Then _txtRGB.TxtRGB("Yellow", "DarkGreen", "░", False) 'Дорога затоптанная 10
    '--------------------------------------------------------------------------------
    If _toolQ = 11 Then _txtRGB.TxtRGB("White", "DarkGray", "░", False) 'Снег 11
    If _toolQ = 12 Then _txtRGB.TxtRGB("Cyan", "Blue", "▓", False) 'лёд 12
    If _toolQ = 13 Then _txtRGB.TxtRGB("Cyan", "DarkBlue", "▒", False) 'Тонкий лёд 13
    If _toolQ = 14 Then _txtRGB.TxtRGB("DarkRed", "DarkYellow", "▓", False) 'Лава 14
    If _toolQ = 15 Then _txtRGB.TxtRGB("Red", "Black", "░", False) 'Затвердевшая лава 15
    '--------------------------------------------------------------------------------
    If _toolQ = 16 Then _txtRGB.TxtRGB("Cyan", "DarkGreen", "░", False) 'Лес 16
    If _toolQ = 17 Then _txtRGB.TxtRGB("Black", "DarkGreen", "░", False) 'Эльфийский Лес 17
    If _toolQ = 18 Then _txtRGB.TxtRGB("DarkMagenta", "Black", "░", False) 'Заражённый лес 18
    '--------------------------------------------------------------------------------
    If _toolQ = 19 Then _txtRGB.TxtRGB("Blue", "Black", "░", False) 'Водная местность 19
    If _toolQ = 20 Then _txtRGB.TxtRGB("White", "DarkBlue", "▒", False) 'Мелководье 20
    If _toolQ = 21 Then _txtRGB.TxtRGB("White", "Cyan", "░", False)  'Берег 21
    If _toolQ = 22 Then _txtRGB.TxtRGB("DarkGreen", "Black", "▒", False)  'Болото 22
    If _toolQ = 23 Then _txtRGB.TxtRGB("Black", "DarkGray", "░", False) 'Край болота 23
    If _toolQ = 24 Then _txtRGB.TxtRGB("DarkGreen", "Black", "░", False) 'Дно болота 24
    '--------------------------------------------------------------------------------
    If _toolQ = 25 Then _txtRGB.TxtRGB("DarkMagenta", "Black", "░", False) 'Заброшенный город 25
    If _toolQ = 26 Then _txtRGB.TxtRGB("DarkRed", "Black", "▓", False) 'Заброшенная деревня 26
    If _toolQ = 27 Then _txtRGB.TxtRGB("Black", "DarkMagenta", "▓", False) 'Стена башни 27
    If _toolQ = 28 Then _txtRGB.TxtRGB("Black", "DarkBlue", "░", False) 'Действующий город 28
    If _toolQ = 29 Then _txtRGB.TxtRGB("Black", "DarkGray", "▒", False) 'Каменный пол 29
    If _toolQ = 30 Then _txtRGB.TxtRGB("Red", "Black", "░", False) 'Руины 30
  End Sub

  Public Sub SaveData() ' корректная запись массивов в файл
    Try
      Dim textFileStream As New IO.FileStream("Map.save", IO.FileMode.OpenOrCreate,
                                    IO.FileAccess.ReadWrite, IO.FileShare.None)
      Dim myFileWriter As New IO.StreamWriter(textFileStream)
      Try
        myFileWriter.Write("{")
        For i = 0 To 16
          myFileWriter.Write("{")
          For j = 0 To 50
            myFileWriter.Write(_mapTest(i, j))
            myFileWriter.Write(", ")
          Next
          myFileWriter.Write("},")
          myFileWriter.WriteLine()
        Next
        myFileWriter.WriteLine("}")
      Catch ex As Exception
        Console.WriteLine("Ошибка сохранения данных в блоке записи при сохранении.")
      End Try
      myFileWriter.Close()
      textFileStream.Close()
      Console.WriteLine("Данные сохранены.")
    Catch ex As Exception
      Console.WriteLine("Ошибка сохранения данных в блоке сохранения.")
    End Try

  End Sub

  Public Sub LoadData()

    Dim i, j As Integer

    Try
      Dim textFileStream As New IO.FileStream("Map.save", IO.FileMode.OpenOrCreate,
                           IO.FileAccess.ReadWrite, IO.FileShare.None)
      Dim myFileReader As New IO.StreamReader(textFileStream)

      Try
        For i = 0 To 16
          For j = 0 To 50
            _mapTest(i, j) = myFileReader.Read() - 48
            Console.Write(_mapTest(i, j))
          Next
          _mapTest(i, 127) = myFileReader.ReadLine() - 48
          Console.WriteLine("")
        Next
        myFileReader.ReadLine()
      Catch ex As Exception
        Console.WriteLine("Ошибка вывода данных в блоке чтения данных.")
      End Try

      _save = myFileReader.ReadLine()
      myFileReader.Close()
      textFileStream.Close()
      textFileStream.Close()
      Console.WriteLine("Данные выгружены.")
    Catch ex As Exception

    End Try
  End Sub
End Module
