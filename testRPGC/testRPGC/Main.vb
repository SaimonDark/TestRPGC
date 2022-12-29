Imports System
Imports System.Text
Imports System.Drawing.SystemColors
Imports System.IO
Imports System.Runtime.InteropServices



Module Main

  '<DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
  'Private Function GetConsoleWindow() As IntPtr
  'End Function
  'https://www.pinvoke.net/default.aspx/kernel32.getconsolewindow Изменить параметры консоли на vb
  'https://stackoverflow.com/questions/1937163/drawing-in-a-win32-console-on-c Пример работы с графикой 

  Dim iRand, fRand, mRand, exRand As Integer 'Переменные к шансам
  Public _vibor(17) As Integer 'Переменные к интерфейсам
  Public _pointHero, _pointSet As String 'Переменные к карте
  Dim _chekhero As String 'Пункт для раздела новой игры.
  Public _hero As New Hero
  Public _enemy As New Enemy
  Public _city As New Cityes
  ReadOnly _System As New SystemColorConsole

  Dim _AdventureSave, _save, _saveMap, _pointX, _pointY As Integer 'Временный показатель наличия сохранения, позиция персонажа на карте по X и Y
  Dim _figthTime As Integer 'Тригер активности боя
  Public _Perks, _PerksSkils, _statshero(5), _cvest(3) As Integer 'Доступные очки для характеристиков
  Public _botleLive, _botleMana, _money As Integer 'Бутылки жизни и маны и деньги.
  Public _equip(5), _bagitem(10) As String

  Sub Main()
    Console.CursorVisible = False
    _AdventureSave = 1
    _pointX = 16
    _pointY = 6
    _vibor(0) = 0 'Выбор пунктов главного меню.
    _vibor(1) = 0
    _vibor(2) = 0 ' Выбор действия начального боя
    _vibor(3) = 0 'Выбор класса
    _vibor(4) = 0 'Выбор пунктом меню персонажа.
    _vibor(5) = 0 'Выбор пунктов меню приключения.
    _vibor(6) = 0
    _vibor(7) = 0
    _vibor(8) = 0
    _vibor(9) = 0
    _hero._dopperks(1) = 0
    _hero._dopperks(2) = 0
    _hero._dopperks(3) = 0
    _hero._dopperks(4) = 0
    _hero._dopperks(5) = 0

    _pointHero = 0 'Перемещение по начальной карте
    _pointSet = 0 'Перемещение по начальной карте
    _save = 0
    _Perks = 0 'Количество очков для характеристик
    _PerksSkils = 0 'Количество очков для способностей
    _botleLive = 0
    _botleMana = 0
    _saveMap = 0 'Необходимо сделать сохранение!
    _figthTime = 1 'Задан активный бой
    _money = 0 'Костыль для монет
    Console.Title = "The Relight of Eternity"
    LoadData()
    _cvest(1) = 0
    _cvest(2) = 0
    _cvest(3) = 0
    If _hero._cvest(2) > 0 Then _cvest(2) = 2
    'Инициализация параметров героя и его экипировки для инвентаря
    _statshero(1) = _hero._strength_Equip
    _statshero(2) = _hero._intelligece_Equip
    _statshero(3) = _hero._defense_Equip
    _statshero(4) = _hero._agility_Equip
    _statshero(5) = _hero._accuracy_Equip
    _equip(1) = _hero._Equip(1)
    _equip(2) = _hero._Equip(2)
    _equip(3) = _hero._Equip(3)
    _equip(4) = _hero._Equip(4)
    _equip(5) = _hero._Equip(5)

    While _vibor(0) <> 5
      Console.Clear()
      Console.WriteLine("  ")
      _System.TxtRGB("Yellow", "Black", "                  _                         _", True)
      _System.TxtRGB("Yellow", "Black", "                 │╚═════════════════════════╝│", True)
      Console.WriteLine("                 │  The Relight of Eternity  │          ")
      _System.TxtRGB("Yellow", "Black", "                 │╔═════════════════════════╗│", True)
      _System.TxtRGB("White", "Black", "                     1. Новая игра", True)
      If _save = 0 Then _System.TxtRGB("DarkBlue", "Black", "                     2. Загрузка", True)
      If _save = 1 Then _System.TxtRGB("White", "Black", "                     2. Загрузка", True)
      _System.TxtRGB("White", "Black", "                     3. Настройка.", True)
      _System.TxtRGB("White", "Black", "                     4. Авторы.", True)
      _System.TxtRGB("White", "Black", "                     5. Выход.", True)
      Console.ForegroundColor = ConsoleColor.Black
      Console.CursorVisible = False
      Dim info As ConsoleKeyInfo = Console.ReadKey()
      Try
        _vibor(0) = info.Key - 48
        Select Case _vibor(0)
          Case 1 'сброс всех параметров и новая игра.
            _hero.None()
            _pointX = 2
            _pointY = 2
            _chekhero = ""
            _vibor(0) = 0
            _vibor(1) = 0
            _vibor(2) = 0
            _vibor(3) = 0
            _vibor(4) = 0
            _vibor(5) = 0
            _vibor(6) = 0
            _vibor(7) = 0
            _vibor(8) = 0
            _vibor(9) = 0
            _hero._dopperks(1) = 0
            _hero._dopperks(2) = 0
            _hero._dopperks(3) = 0
            _hero._dopperks(4) = 0
            _hero._dopperks(5) = 0
            _pointHero = "a"
            _pointSet = "v"
            _saveMap = 0
            _Perks = 0
            _botleLive = 0
            _botleMana = 0
            _AdventureSave = 1
            _enemy._enemylive = _enemy._enemyLiveMax
            Newgame()
            Game()
            _vibor(0) = 0
          Case 2 'загрузка данных и сохранений.
            If _save = 1 Then
              Game()
              _vibor(0) = 0
            End If
          Case 3 'Настройки
            Console.Clear()
            Console.SetCursorPosition(0, 0)
            _System.TxtRGB("Yellow", "Black", "▓▓", False)
            Console.SetCursorPosition(104, 0)
            _System.TxtRGB("Yellow", "Black", "▓▓", False)
            Console.SetCursorPosition(0, 30)
            _System.TxtRGB("Yellow", "Black", "▓▓", False)
            Console.SetCursorPosition(20, 12)
            _System.TxtRGB("White", "Black", "Зажмите Ctrl и передвигайте колёсико мыши до границ экрана.", False)
            Console.SetCursorPosition(40, 15)
            _System.TxtRGB("White", "Black", "Затем, нажмите Enter.", False)
            Console.ReadLine()
          Case 4 'авторы.

          Case Else

        End Select
      Catch ex As Exception

      End Try

    End While
  End Sub

  Public Sub Game()  'Дальнейший мир.
    While _vibor(4) <> 5
      Console.Clear()
      _hero.InfoBar(1)
      Console.WriteLine("     _______________")
      Console.WriteLine("    ║ 1. Продолжить путешествие")
      Console.WriteLine("    │ 2. Информация персонажа")
      Console.WriteLine("    │ 3. Инвентарь")
      Console.WriteLine("    │ 4. Книга талантов")
      Console.WriteLine("    │ 5. Выход")
      Console.WriteLine("    └ ")
      Console.ForegroundColor = ConsoleColor.Black
      Console.CursorVisible = False
      Dim info As ConsoleKeyInfo = Console.ReadKey()
      Try
        _vibor(4) = info.Key - 48
      Catch ex As Exception

      End Try

      Select Case _vibor(4)
        Case 1 'Компания
          Adventure()
        Case 2 'Информация о персонаже
          Console.Clear()
          _hero.InfoHero()
          If _Perks = 0 Then
            Console.ReadLine()
          ElseIf _Perks > 0 Then
            While _vibor(6) <> 2
              Console.WriteLine(" 1. Распределить очки")
              Console.WriteLine(" 2. Выйти в меню")
              Dim infoPerks As ConsoleKeyInfo = Console.ReadKey()
              Try
                _vibor(6) = infoPerks.Key - 48
              Catch ex As Exception

              End Try
              Select Case _vibor(6)
                Case 1
                  Perks_stats(_hero._h._RPclass)
              End Select
              SaveData()
            End While
          End If
          _vibor(6) = 0
        Case 3 'Инвентарь
          'Инициализация параметров героя и его экипировки для инвентаря и его методов
          UpdateStatsHero(1)
          For _bagitemset As Integer = 1 To 10
            _bagitem(_bagitemset) = _hero._Bagcheck(_bagitemset)
          Next
          Console.Clear()
          _hero.InfoBar(0)
          Dim _bag As New Bagpack
          _bag.Inventary(_money)
          'Перевод параметров и вещей из методов инвентаря в методы героя
          UpdateStatsHero(2)
          For _bagitemset As Integer = 1 To 10
            _hero._Bagcheck(_bagitemset) = _bagitem(_bagitemset)
          Next
          _bag = Nothing
        Case 4 'Книга талантов
          Console.Clear()
          _hero.InfoBar(1)
          Console.WriteLine("  ")
          Dim _book As New BookSkils
          _book.Skils(_hero._skl(0)._RPability, _hero._skl(0)._damage, _hero._skils(1), _hero._PerksStatLvl(0))
          _book.Skils(_hero._skl(1)._RPability, _hero._skl(1)._damage, _hero._skils(2), _hero._PerksStatLvl(1))
          _book.Skils(_hero._skl(2)._RPability, _hero._skl(2)._damage, _hero._skils(3), _hero._PerksStatLvl(2))
          _book.Skils(_hero._skl(3)._RPability, _hero._skl(3)._damage, _hero._skils(4), _hero._PerksStatLvl(3))
          If _PerksSkils = 0 Then
            Console.ReadLine()
          ElseIf _PerksSkils > 0 Then
            While _vibor(8) <> 2
              Console.WriteLine(" 1. Распределить очки")
              Console.WriteLine(" 2. Выйти в меню")
              Dim infoPerks As ConsoleKeyInfo = Console.ReadKey()
              Try
                _vibor(8) = infoPerks.Key - 48
              Catch ex As Exception

              End Try
              Select Case _vibor(8)
                Case 1
                  Perks_Skils()
              End Select
              SaveData()
            End While
          End If
          _vibor(8) = 0
          _book = Nothing
      End Select
    End While
    SaveData()
    Console.Clear()
    _vibor(4) = 0
  End Sub
  Public Sub Adventure() 'Раздел компании
    While _vibor(5) <> 4
      Console.Clear()
      _hero.InfoBar(1)
      Console.WriteLine("     _______________")
      Console.WriteLine("    ║ 1. Открыть карту")
      Console.WriteLine("    │ 2. Список поручений")
      Console.WriteLine("    │ 3. Фолиант событий")
      Console.WriteLine("    │ 4. Назад")
      Console.WriteLine("    └ ")
      Console.ForegroundColor = ConsoleColor.Black
      Console.CursorVisible = False
      Dim info As ConsoleKeyInfo = Console.ReadKey()
      Try
        Console.ForegroundColor = ConsoleColor.Black
        _vibor(5) = info.Key - 48
        Select Case _vibor(5)
          Case 1
            _AdventureSave = 1
            While _AdventureSave <> 0
              LoadFon(_saveMap)
            End While
          Case 2
            Console.Clear()
            _hero.InfoBar(1)
            Console.ReadLine()
          Case 3
            Console.Clear()
            _hero.InfoBar(1)
            Console.ReadLine()

        End Select
      Catch ex As Exception
      End Try
    End While
    _vibor(5) = 0

  End Sub

  Public Sub Fighting(ByVal _location As Integer) 'Универсальная боёвка
    _vibor(2) = 0
    Dim oRand = New Random(DateTime.Now.Millisecond)
    Dim skill3, skill4 As Integer
    skill3 = 0
    skill4 = 0
    fRand = oRand.Next(1, 7)
    If fRand = 7 Then fRand = 5
    If fRand = 6 Then fRand = 4
    _enemy._enemyGame(_location, fRand)._enemylive = _enemy._enemyGame(_location, fRand)._enemyLiveMax
    _hero._h._live = _hero._h._liveMax
    _hero.InfoBar(1)
    Console.WriteLine(" ")
    Console.WriteLine("    ┌────────────────")
    Console.Write("    │")
    _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
    Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
    _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
    Console.WriteLine("                        ")
    Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
    Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
    _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
    Console.WriteLine("")
    Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
    _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
    _System.Apostrof()
    Console.WriteLine("    └  Флаконов жизни: " & _botleLive & "  Флаконов маны: " & _botleMana)
    Console.WriteLine(" ")
    Console.WriteLine("    ┌──────────────────")
    Console.WriteLine("   ┌1. " & _hero._skl(0)._RPability)
    If _hero._skils(2) > 0 And _hero._h._mana >= 3 Then
      Console.WriteLine("   ├2. " & _hero._skl(1)._RPability)
    ElseIf _hero._skils(2) > 0 And _hero._h._mana < 3 Then
      _System.TxtRGB("DarkGray", "Black", "   ├2. " & _hero._skl(1)._RPability, True)
    End If
    If _hero._skils(3) > 0 Then _System.TxtRGB("DarkGray", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
    If _hero._skils(4) > 0 Then _System.TxtRGB("DarkGray", "Black", "   └4. " & _hero._skl(3)._RPability, True)
    Console.WriteLine("    ├───────────────────")
    Console.WriteLine("   ┌5. Использовать зелье здоровья")
    If _hero._skils(2) > 0 Then
      Console.WriteLine("   └6. Использовать зелье маны")
    ElseIf _hero._skils(2) = 0 Then
      _System.TxtRGB("DarkGray", "Black", "   └6. Использовать зелье маны", True)
    End If
    Console.Write("    └───────────────────┤ Действие:        ")

    While _figthTime <> 0
      Console.SetCursorPosition(36, 22)
      Try
        _vibor(2) = Console.ReadLine()
      Catch ex As Exception

      End Try
      Dim _vivodundmg As Single
      'Шанс уворота
      Dim uRand = New Random(DateTime.Now.Millisecond)
      Dim uvorotMax As Integer = 100 + _hero._h._agility
      Dim uvorot As Integer = uRand.Next(1, uvorotMax)
      _vivodundmg = (_enemy._enemyGame(_location, fRand)._unDamage - (_hero._h._defense * 0.8)) 'Вывод урона моба с учётом защиты 

      Select Case _vibor(2)
        Case 1
          'Шанс критического удара
          Dim сRand = New Random(DateTime.Now.Millisecond)
          Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
          If _vivodundmg <= 0 Then _vivodundmg = _enemy._enemyGame(_location, fRand)._unDamage * 0.1
          If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
            _vivodundmg = 0 '& " Уворот"
            _hero._h._live -= _vivodundmg
          Else
            _hero._h._live -= _vivodundmg
          End If
          If chance_crit <= _hero._h._accuracy Then 'критический удар
            _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(0)._crit + If(_hero._PerksStatLvl(0) > 0, _hero._PerksStatLvl(0) * 1.5, 0) 'Критический удар
            _hero.InfoBar(1)
            Console.WriteLine(" ")
            Console.WriteLine("    ┌────────────────")
            Console.Write("    │")
            _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
            Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
            _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
            Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] крит -" & _hero._skl(0)._crit & If(_hero._PerksStatLvl(0) > 0, " +" & _hero._PerksStatLvl(0) * 1.5 & " ", " "))
            Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
            Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
            _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
            Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
            Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
            _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
            _System.Apostrof()

          Else 'Обычная атака
            _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(0)._damage + _hero._PerksStatLvl(0)
            _hero.InfoBar(1)
            Console.WriteLine(" ")
            Console.WriteLine("    ┌────────────────")
            Console.Write("    │")
            _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
            Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
            _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
            Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] -" & _hero._skl(0)._damage & If(_hero._PerksStatLvl(0) > 0, " +" & _hero._PerksStatLvl(0) & "                         ", "                        "))
            Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
            Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
            _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
            Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
            Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
            _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
            _System.Apostrof()

          End If
        Case 2
          If _hero._skils(2) > 0 And _hero._h._mana >= 3 Then
            _hero._h._mana -= 3
            skill3 += 1
            'Шанс критического удара
            Dim сRand = New Random(DateTime.Now.Millisecond)
            Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
            If _vivodundmg <= 0 Then _vivodundmg = _enemy._enemyGame(_location, fRand)._unDamage * 0.1
            If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
              _vivodundmg = 0 '& " Уворот"
              _hero._h._live -= _vivodundmg
            Else
              _hero._h._live -= _vivodundmg
            End If
            If chance_crit <= _hero._h._accuracy Then 'критический удар
              _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(1)._crit + If(_hero._PerksStatLvl(1) > 0, _hero._PerksStatLvl(1) * 1.5, 0)
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
              Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
              _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
              Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] крит -" & _hero._skl(1)._crit & If(_hero._PerksStatLvl(1) > 0, " +" & _hero._PerksStatLvl(1) * 1.5 & " ", " "))
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()

            Else 'Обычная атака
              _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(1)._damage + _hero._PerksStatLvl(1)
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
              Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
              _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
              Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] -" & _hero._skl(1)._damage & If(_hero._PerksStatLvl(1) > 0, " +" & _hero._PerksStatLvl(1) & "                         ", "                        "))
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()

            End If
          End If
        Case 3
          If _hero._skils(3) > 0 And skill3 >= 3 And _hero._h._mana >= 5 Then
            skill3 = 0
            skill4 += 1
            _hero._h._mana -= 5
            'Шанс критического удара
            Dim сRand = New Random(DateTime.Now.Millisecond)
            Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
            If _vivodundmg <= 0 Then _vivodundmg = _enemy._enemyGame(_location, fRand)._unDamage * 0.1
            If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
              _vivodundmg = 0 '& " Уворот"
              _hero._h._live -= _vivodundmg
            Else
              _hero._h._live -= _vivodundmg
            End If
            If chance_crit <= _hero._h._accuracy Then 'критический удар
              _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(2)._crit + If(_hero._PerksStatLvl(2) > 0, _hero._PerksStatLvl(2) * 1.5, 0)
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
              Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
              _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
              Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] крит -" & _hero._skl(2)._crit & If(_hero._PerksStatLvl(2) > 0, " +" & _hero._PerksStatLvl(2) * 1.5 & " ", " "))
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()

            Else 'Обычная атака
              _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(2)._damage + _hero._PerksStatLvl(2)
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
              Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
              _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
              Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] -" & _hero._skl(2)._damage & If(_hero._PerksStatLvl(2) > 0, " +" & _hero._PerksStatLvl(2) & "                         ", "                        "))
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()

            End If
          End If
        Case 4
          If _hero._skils(4) > 0 And skill4 >= 2 And _hero._h._mana > _hero._h._manaMax * 0.6 Then
            _hero._h._mana -= _hero._h._manaMax * 0.6
            If _hero._h._mana < 0 Then _hero._h._mana = 0
            skill4 = 0
            'Шанс критического удара
            Dim сRand = New Random(DateTime.Now.Millisecond)
            Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
            If _vivodundmg <= 0 Then _vivodundmg = _enemy._enemyGame(_location, fRand)._unDamage * 0.1
            If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
              _vivodundmg = 0 '& " Уворот"
              _hero._h._live -= _vivodundmg
            Else
              _hero._h._live -= _vivodundmg
            End If
            If chance_crit <= _hero._h._accuracy Then 'критический удар
              _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(3)._crit + If(_hero._PerksStatLvl(3) > 0, _hero._PerksStatLvl(3) * 1.5, 0)
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
              Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
              _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
              Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] крит -" & _hero._skl(3)._crit & If(_hero._PerksStatLvl(3) > 0, " +" & _hero._PerksStatLvl(3) * 1.5 & " ", " "))
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()

            Else 'Обычная атака
              _enemy._enemyGame(_location, fRand)._enemylive -= _hero._skl(3)._damage + _hero._PerksStatLvl(3)
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
              Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
              _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
              Console.WriteLine("[" & _enemy._enemyGame(_location, fRand)._enemylive & "] -" & _hero._skl(3)._damage & If(_hero._PerksStatLvl(3) > 0, " +" & _hero._PerksStatLvl(3) & "                         ", "                        "))
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()

            End If
          End If
        Case 5
          If _botleLive > 0 Then
            _botleLive -= 1
            _hero._h._live += 500
            If _hero._h._live > _hero._h._liveMax Then _hero._h._live = _hero._h._liveMax
          End If
          _hero.InfoBar(1)
          Console.WriteLine(" ")
          Console.WriteLine("    ┌────────────────")
          Console.Write("    │")
          _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
          Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
          _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
          Console.WriteLine("                                                   ")
          Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
          Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
          _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
          Console.WriteLine("                         ")
          Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
          _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
          _System.Apostrof()

        Case 6
          If _hero._skils(2) > 0 Then
            If _botleMana > 0 Then
              _botleMana -= 1
              _hero._h._mana += 100
              If _hero._h._mana > _hero._h._manaMax Then _hero._h._mana = _hero._h._manaMax
            End If
            _hero.InfoBar(1)
            Console.WriteLine(" ")
            Console.WriteLine("    ┌────────────────")
            Console.Write("    │")
            _System.TxtRGB(_enemy._enemyGame(_location, fRand)._colorF, _enemy._enemyGame(_location, fRand)._colorB, _enemy._enemyGame(_location, fRand)._nameEnemy, False)
            Console.Write("   [" & _enemy._enemyGame(_location, fRand)._enemyLiveMax & "]")
            _hero.Exxeption(_enemy._enemyGame(_location, fRand)._enemylive, _enemy._enemyGame(_location, fRand)._enemyLiveMax, _enemy._enemyGame(_location, fRand)._colorLive)
            Console.WriteLine("                         ")
            Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
            Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
            _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
            Console.WriteLine("                        ")
            Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
            _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
            _System.Apostrof()
          End If
        Case 7

      End Select
      If _hero._h._mana < _hero._h._manaMax Then _hero._h._mana += 0.1
      Console.SetCursorPosition(0, 12)
      Console.WriteLine("    └  Флаконов жизни: " & _botleLive & "  Флаконов маны: " & _botleMana & "                               ")
      Console.WriteLine(" ")
      Console.WriteLine("    ┌──────────────────")
      Console.WriteLine("   ┌1. " & _hero._skl(0)._RPability)

      If _hero._skils(2) > 0 And _hero._h._mana >= 3 Then
        Console.WriteLine("   ├2. " & _hero._skl(1)._RPability)
      ElseIf _hero._skils(2) > 0 And _hero._h._mana < 3 Then
        _System.TxtRGB("DarkGray", "Black", "   ├2. " & _hero._skl(1)._RPability, True)
      End If

      If _hero._skils(3) > 0 And skill3 < 3 Then
        _System.TxtRGB("DarkGray", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
      ElseIf _hero._skils(3) > 0 And skill3 >= 3 And _hero._h._mana < 5 Then
        _System.TxtRGB("DarkGray", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
      ElseIf _hero._skils(3) > 0 And skill3 >= 3 And _hero._h._mana >= 5 Then
        _System.TxtRGB("White", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
      End If

      If _hero._skils(4) > 0 And skill4 < 2 Then
        _System.TxtRGB("DarkGray", "Black", "   └4. " & _hero._skl(3)._RPability, True)
      ElseIf _hero._skils(4) > 0 And skill4 >= 2 And _hero._h._mana < _hero._h._manaMax * 0.6 Then
        _System.TxtRGB("White", "Black", "   └4. " & _hero._skl(3)._RPability, True)
      ElseIf _hero._skils(4) > 0 And skill4 >= 2 And _hero._h._mana >= _hero._h._manaMax * 0.6 Then
        _System.TxtRGB("White", "Black", "   └4. " & _hero._skl(3)._RPability, True)
      End If

      Console.WriteLine("    ├───────────────────")
      Console.WriteLine("   ┌5. Использовать зелье здоровья")
      If _hero._skils(2) > 0 Then
        Console.WriteLine("   └6. Использовать зелье маны")
      ElseIf _hero._skils(2) = 0 Then
        _System.TxtRGB("DarkGray", "Black", "   └6. Использовать зелье маны", True)
      End If
      Console.Write("    └───────────────────┤ Действие:        ")
      'Console.WriteLine(" 7. Пропустить...")
      If _enemy._enemyGame(_location, fRand)._enemylive <= 0 Then 'Если враг умер
        exRand = oRand.Next(_location, 25)
        _figthTime = 0
        _money += _enemy._enemyGame(_location, fRand)._moneyEnemy
        _hero._h._Ex += _enemy._enemyGame(_location, fRand)._ExpEnemy + exRand
        If _hero._h._Ex >= _hero._h._ExMax Then 'Новый уровень
          _hero._h._Ex -= _hero._h._ExMax
          _hero._h._ExMax *= 1.32
          _hero._h._mana = _hero._h._manaMax
          _hero._h._lvl += 1
          _Perks += 4
          _PerksSkils += 1
        End If
      ElseIf _hero._h._live <= 0 Then 'Или если герой умер
        _figthTime = 0
        exRand = oRand.Next(_location, 25)
        _hero._h._Ex -= exRand
        If _hero._h._Ex <= 0 Then _hero._h._Ex = 0
      End If
    End While

    _figthTime = 1
    Console.Clear()
  End Sub

  Public Sub BossFiht(ByVal _locationBoss As Integer) 'При победе вылетаетиз игры.
    Console.Clear()
    Dim oRand = New Random(DateTime.Now.Millisecond)
    Dim skill3, skill4, _nomberBoss, _stateLiveBoss, _infoFitgh As Integer
    Dim _stateBosslive(5) As Integer
    skill3 = 0
    skill4 = 0
    _infoFitgh = 0
    fRand = oRand.Next(1, 4)

    Select Case _locationBoss 'Выборка босса в зависимости от локации
      Case 1
        _nomberBoss = 1
        _stateLiveBoss = 3
        _stateBosslive(3) = _enemy._BossGame(_nomberBoss)._bossLiveMax1
        _stateBosslive(2) = _enemy._BossGame(_nomberBoss)._bossLiveMax2
        _stateBosslive(1) = _enemy._BossGame(_nomberBoss)._bossLiveMax3
        _enemy._BossGame(_nomberBoss)._BossLive = _enemy._BossGame(_nomberBoss)._bossLiveMax1
        _enemy._BossGame(_nomberBoss)._bossliveStat = _enemy._BossGame(_nomberBoss)._bossLiveMax1
      Case 3
        _nomberBoss = 3
        _stateLiveBoss = 3
        _stateBosslive(3) = _enemy._BossGame(_nomberBoss)._bossLiveMax1
        _stateBosslive(2) = _enemy._BossGame(_nomberBoss)._bossLiveMax2
        _stateBosslive(1) = _enemy._BossGame(_nomberBoss)._bossLiveMax3
        _enemy._BossGame(_nomberBoss)._BossLive = _enemy._BossGame(_nomberBoss)._bossLiveMax1
        _enemy._BossGame(_nomberBoss)._bossliveStat = _enemy._BossGame(_nomberBoss)._bossLiveMax1
    End Select

    _enemy._BossGame(_nomberBoss)._BossLive = _enemy._BossGame(_nomberBoss)._bossLiveMax1
    _hero._h._live = _hero._h._liveMax
    _hero.InfoBar(1)
    Console.WriteLine(" ")
    Console.WriteLine("    ┌────────────────")
    Console.Write("    │")
    _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
    Console.Write("   [" & _enemy._BossGame(_nomberBoss)._BossLive & "]")
    _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _enemy._BossGame(_nomberBoss)._bossliveStat, _enemy._BossGame(_nomberBoss)._colorLiveBB)
    Console.WriteLine("                        ")
    Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
    Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
    _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
    Console.WriteLine("")
    Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
    _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
    _System.Apostrof()
    Console.WriteLine("    └  Флаконов жизни: " & _botleLive & "  Флаконов маны: " & _botleMana)
    Console.WriteLine(" ")
    Console.WriteLine("    ┌──────────────────")
    Console.WriteLine("   ┌1. " & _hero._skl(0)._RPability)
    If _hero._skils(2) > 0 And _hero._h._mana >= 3 Then
      Console.WriteLine("   ├2. " & _hero._skl(1)._RPability)
    ElseIf _hero._skils(2) > 0 And _hero._h._mana < 3 Then
      _System.TxtRGB("DarkGray", "Black", "   ├2. " & _hero._skl(1)._RPability, True)
    End If
    If _hero._skils(3) > 0 Then _System.TxtRGB("DarkGray", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
    If _hero._skils(4) > 0 Then _System.TxtRGB("DarkGray", "Black", "   └4. " & _hero._skl(3)._RPability, True)
    Console.WriteLine("    ├───────────────────")
    Console.WriteLine("   ┌5. Использовать зелье здоровья")
    If _hero._skils(2) > 0 Then
      Console.WriteLine("   └6. Использовать зелье маны")
    ElseIf _hero._skils(2) = 0 Then
      _System.TxtRGB("DarkGray", "Black", "   └6. Использовать зелье маны", True)
    End If
    Console.Write("    └───────────────────┤ Действие:        ")

    While _figthTime <> 0
      While _stateLiveBoss <> 0
        Console.SetCursorPosition(36, 22)
        Try
            _vibor(2) = Console.ReadLine()
          Catch ex As Exception

          End Try

        Dim _vivodundmg As Single
          'Шанс уворота
          Dim uRand = New Random(DateTime.Now.Millisecond)
          Dim uvorotMax As Integer = 100 + _hero._h._agility
        Dim uvorot As Integer = uRand.Next(1, uvorotMax)
        If _hero._h._live >= _vivodundmg Then
          _vivodundmg = (_enemy._BossGame(_nomberBoss)._bossDamage - (_hero._h._defense * 0.8)) 'Вывод урона моба с учётом защиты 
          Select Case _vibor(2)
            Case 1
              'Шанс критического удара
              Dim сRand = New Random(DateTime.Now.Millisecond)
              Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
              If _vivodundmg <= 0 Then _vivodundmg = _enemy._BossGame(_nomberBoss)._bossDamage * 0.1
              If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
                _vivodundmg = 0 '& " Уворот"
                _hero._h._live -= _vivodundmg
              Else
                _hero._h._live -= _vivodundmg
              End If
              If chance_crit <= _hero._h._accuracy Then 'критический удар
                _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(0)._crit + If(_hero._PerksStatLvl(0) > 0, _hero._PerksStatLvl(0) * 1.5, 0) 'Критический удар
                If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                  _stateLiveBoss -= 1
                  _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                  _stateLiveBoss = 0
                  _infoFitgh = 2
                End If

                _hero.InfoBar(1)
                Console.WriteLine(" ")
                Console.WriteLine("    ┌────────────────")
                Console.Write("    │")
                _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] крит -" & _hero._skl(0)._crit & If(_hero._PerksStatLvl(0) > 0, " +" & _hero._PerksStatLvl(0) * 1.5 & " ", " "))
                Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                Console.WriteLine(" ")
              Else 'Обычная атака
                _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(0)._damage + _hero._PerksStatLvl(0)
                If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                  _stateLiveBoss -= 1
                  _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                  _stateLiveBoss = 0
                  _infoFitgh = 2
                End If
                _hero.InfoBar(1)
                Console.WriteLine(" ")
                Console.WriteLine("    ┌────────────────")
                Console.Write("    │")
                _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] -" & _hero._skl(0)._damage & If(_hero._PerksStatLvl(0) > 0, " +" & _hero._PerksStatLvl(0) & "                         ", "                        "))
                Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                _System.Apostrof()
              End If
            Case 2
              If _hero._skils(2) > 0 And _hero._h._mana >= 3 Then
                _hero._h._mana -= 3
                skill3 += 1
                'Шанс критического удара
                Dim сRand = New Random(DateTime.Now.Millisecond)
                Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
                If _vivodundmg <= 0 Then _vivodundmg = _enemy._BossGame(_nomberBoss)._bossDamage * 0.1
                If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
                  _vivodundmg = 0 '& " Уворот"
                  _hero._h._live -= _vivodundmg
                Else
                  _hero._h._live -= _vivodundmg
                End If
                If chance_crit <= _hero._h._accuracy Then 'критический удар
                  _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(1)._crit + If(_hero._PerksStatLvl(1) > 0, _hero._PerksStatLvl(1) * 1.5, 0)
                  If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                    _stateLiveBoss -= 1
                    _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                  ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                    _stateLiveBoss = 0
                    _infoFitgh = 2
                  End If
                  _hero.InfoBar(1)
                  Console.WriteLine(" ")
                  Console.WriteLine("    ┌────────────────")
                  Console.Write("    │")
                  _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                  Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                  _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                  Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] критический удар -" & _hero._skl(1)._crit & If(_hero._PerksStatLvl(1) > 0, " +" & _hero._PerksStatLvl(1) * 1.5 & " ", " "))
                  Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                  Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                  _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                  Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                  Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                  _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                  _System.Apostrof()

                Else 'Обычная атака
                  _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(1)._damage + _hero._PerksStatLvl(1)
                  If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                    _stateLiveBoss -= 1
                    _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                  ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                    _stateLiveBoss = 0
                    _infoFitgh = 2
                  End If
                  _hero.InfoBar(1)
                  Console.WriteLine(" ")
                  Console.WriteLine("    ┌────────────────")
                  Console.Write("    │")
                  _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                  Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                  _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                  Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] -" & _hero._skl(1)._damage & If(_hero._PerksStatLvl(1) > 0, " +" & _hero._PerksStatLvl(1) & "                         ", "                        "))
                  Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                  Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                  _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                  Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                  Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                  _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                  _System.Apostrof()

                End If
              End If
            Case 3
              If _hero._skils(3) > 0 And skill3 >= 3 And _hero._h._mana >= 5 Then
                skill3 = 0
                skill4 += 1
                _hero._h._mana -= 5
                'Шанс критического удара
                Dim сRand = New Random(DateTime.Now.Millisecond)
                Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
                If _vivodundmg <= 0 Then _vivodundmg = _enemy._BossGame(_nomberBoss)._bossDamage * 0.1
                If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
                  _vivodundmg = 0 '& " Уворот"
                  _hero._h._live -= _vivodundmg
                Else
                  _hero._h._live -= _vivodundmg
                End If
                If chance_crit <= _hero._h._accuracy Then 'критический удар
                  _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(2)._crit + If(_hero._PerksStatLvl(2) > 0, _hero._PerksStatLvl(2) * 1.5, 0)
                  If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                    _stateLiveBoss -= 1
                    _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                  ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                    _stateLiveBoss = 0
                    _infoFitgh = 2
                  End If
                  _hero.InfoBar(1)
                  Console.WriteLine(" ")
                  Console.WriteLine("    ┌────────────────")
                  Console.Write("    │")
                  _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                  Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                  _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                  Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] критический удар -" & _hero._skl(2)._crit & If(_hero._PerksStatLvl(2) > 0, " +" & _hero._PerksStatLvl(2) * 1.5 & " ", " "))
                  Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                  Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                  _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                  Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                  Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                  _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                  _System.Apostrof()

                Else 'Обычная атака
                  _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(2)._damage + _hero._PerksStatLvl(2)
                  If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                    _stateLiveBoss -= 1
                    _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                  ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                    _stateLiveBoss = 0
                    _infoFitgh = 2
                  End If
                  _hero.InfoBar(1)
                  Console.WriteLine(" ")
                  Console.WriteLine("    ┌────────────────")
                  Console.Write("    │")
                  _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                  Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                  _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                  Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] -" & _hero._skl(2)._damage & If(_hero._PerksStatLvl(2) > 0, " +" & _hero._PerksStatLvl(2) & "                         ", "                        "))
                  Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                  Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                  _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                  Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                  Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                  _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                  _System.Apostrof()

                End If
              End If
            Case 4
              If _hero._skils(4) > 0 And skill4 >= 2 And _hero._h._mana > _hero._h._manaMax * 0.6 Then
                _hero._h._mana -= _hero._h._manaMax * 0.6
                If _hero._h._mana < 0 Then _hero._h._mana = 0
                skill4 = 0
                'Шанс критического удара
                Dim сRand = New Random(DateTime.Now.Millisecond)
                Dim chance_crit As Integer = oRand.Next(1, 100 - _hero._h._accuracy)
                If _vivodundmg <= 0 Then _vivodundmg = _enemy._BossGame(_nomberBoss)._bossDamage * 0.1
                If uvorot >= _hero._h._agility And uvorot <= uvorotMax - _hero._h._agility Then 'Шанс уворота
                  _vivodundmg = 0 '& " Уворот"
                  _hero._h._live -= _vivodundmg
                Else
                  _hero._h._live -= _vivodundmg
                End If
                If chance_crit <= _hero._h._accuracy Then 'критический удар
                  _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(3)._crit + If(_hero._PerksStatLvl(3) > 0, _hero._PerksStatLvl(3) * 1.5, 0)
                  If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                    _stateLiveBoss -= 1
                    _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                  ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                    _stateLiveBoss = 0
                    _infoFitgh = 2
                  End If
                  _hero.InfoBar(1)
                  Console.WriteLine(" ")
                  Console.WriteLine("    ┌────────────────")
                  Console.Write("    │")
                  _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                  Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                  _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                  Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] критический удар -" & _hero._skl(3)._crit & If(_hero._PerksStatLvl(3) > 0, " +" & _hero._PerksStatLvl(3) * 1.5 & " ", " "))
                  Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                  Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                  _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                  Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                  Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                  _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                  _System.Apostrof()

                Else 'Обычная атака
                  _enemy._BossGame(_nomberBoss)._BossLive -= _hero._skl(3)._damage + _hero._PerksStatLvl(3)
                  If _enemy._BossGame(_nomberBoss)._BossLive <= 0 And _stateLiveBoss > 1 Then 'Если враг умер
                    _stateLiveBoss -= 1
                    _enemy._BossGame(_nomberBoss)._BossLive = _stateBosslive(_stateLiveBoss)
                  ElseIf _stateLiveBoss = 1 And _enemy._BossGame(_nomberBoss)._BossLive < 0 Then
                    _stateLiveBoss = 0
                    _infoFitgh = 2
                  End If
                  _hero.InfoBar(1)
                  Console.WriteLine(" ")
                  Console.WriteLine("    ┌────────────────")
                  Console.Write("    │")
                  _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                  Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                  _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                  Console.WriteLine("[" & _enemy._BossGame(_nomberBoss)._BossLive & "] -" & _hero._skl(3)._damage & If(_hero._PerksStatLvl(3) > 0, " +" & _hero._PerksStatLvl(3) & "                         ", "                        "))
                  Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                  Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                  _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                  Console.WriteLine("[" & _hero._h._live & "] -" & _vivodundmg & "                        ")
                  Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                  _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                  _System.Apostrof()

                End If
              End If
            Case 5
              If _botleLive > 0 Then
                _botleLive -= 1
                _hero._h._live += 500
                If _hero._h._live > _hero._h._liveMax Then _hero._h._live = _hero._h._liveMax
              End If
              _hero.InfoBar(1)
              Console.WriteLine(" ")
              Console.WriteLine("    ┌────────────────")
              Console.Write("    │")
              _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
              Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
              _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
              Console.WriteLine("                                                   ")
              Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
              Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
              _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
              Console.WriteLine("                         ")
              Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
              _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
              _System.Apostrof()
            Case 6
              If _hero._skils(2) > 0 Then
                If _botleMana > 0 Then
                  _botleMana -= 1
                  _hero._h._mana += 100
                  If _hero._h._mana > _hero._h._manaMax Then _hero._h._mana = _hero._h._manaMax
                End If
                _hero.InfoBar(1)
                Console.WriteLine(" ")
                Console.WriteLine("    ┌────────────────")
                Console.Write("    │")
                _System.TxtRGB(_enemy._BossGame(_nomberBoss)._colorFB, _enemy._BossGame(_nomberBoss)._colorBB, _enemy._BossGame(_nomberBoss)._nameBoss, False)
                Console.Write("   [" & _stateBosslive(_stateLiveBoss) & "]")
                _hero.Exxeption(_enemy._BossGame(_nomberBoss)._BossLive, _stateBosslive(_stateLiveBoss), _enemy._BossGame(_nomberBoss)._colorLiveBB)
                Console.WriteLine("                         ")
                Console.WriteLine("    ╞════════════════▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                Console.Write("    │ " & _hero._h._name & vbTab & "   [" & _hero._h._liveMax & "]")
                _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
                Console.WriteLine("                        ")
                Console.Write("    │            " & vbTab & "   [" & _hero._h._mana & "]")
                _hero.Exxeption(_hero._h._mana, _hero._h._manaMax, "Blue")
                _System.Apostrof()
              End If
          End Select
          If _hero._h._mana < _hero._h._manaMax Then _hero._h._mana += 0.1
          Console.SetCursorPosition(0, 12)
          Console.WriteLine("    └  Флаконов жизни: " & _botleLive & "  Флаконов маны: " & _botleMana & "                               ")
          Console.WriteLine(" ")
          Console.WriteLine("    ┌──────────────────")
          Console.WriteLine("   ┌1. " & _hero._skl(0)._RPability)
          If _hero._skils(2) > 0 And _hero._h._mana >= 3 Then
            Console.WriteLine("   ├2. " & _hero._skl(1)._RPability)
          ElseIf _hero._skils(2) > 0 And _hero._h._mana < 3 Then
            _System.TxtRGB("DarkGray", "Black", "   ├2. " & _hero._skl(1)._RPability, True)
          End If
          If _hero._skils(3) > 0 And skill3 < 3 Then
            _System.TxtRGB("DarkGray", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
          ElseIf _hero._skils(3) > 0 And skill3 >= 3 And _hero._h._mana < 5 Then
            _System.TxtRGB("DarkGray", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
          ElseIf _hero._skils(3) > 0 And skill3 >= 3 And _hero._h._mana >= 5 Then
            _System.TxtRGB("White", "Black", "   ├3. " & _hero._skl(2)._RPability, True)
          End If
          If _hero._skils(4) > 0 And skill4 < 2 Then
            _System.TxtRGB("DarkGray", "Black", "   └4. " & _hero._skl(3)._RPability, True)
          ElseIf _hero._skils(4) > 0 And skill4 >= 2 And _hero._h._mana < _hero._h._manaMax * 0.6 Then
            _System.TxtRGB("White", "Black", "   └4. " & _hero._skl(3)._RPability, True)
          ElseIf _hero._skils(4) > 0 And skill4 >= 2 And _hero._h._mana >= _hero._h._manaMax * 0.6 Then
            _System.TxtRGB("Yellow", "Black", "   └4. " & _hero._skl(3)._RPability, True)
          End If
          Console.WriteLine("    ├───────────────────")
          Console.WriteLine("   ┌5. Использовать зелье здоровья")
          If _hero._skils(2) > 0 Then
            Console.WriteLine("   └6. Использовать зелье маны")
          ElseIf _hero._skils(2) = 0 Then
            _System.TxtRGB("DarkGray", "Black", "   └6. Использовать зелье маны", True)
          End If
          Console.Write("    └───────────────────┤ Действие:        ")

        ElseIf _hero._h._live < _vivodundmg Then 'Или если герой умер
          _stateLiveBoss = 0
          _figthTime = 0
          _infoFitgh = 1
        End If
      End While
      _figthTime = 0
    End While

    Select Case _infoFitgh
      Case 1
        Console.Clear()
        _hero.InfoBar(1)
        Console.WriteLine(" ")
        Console.WriteLine("   Вас победили...")
        Console.WriteLine("   Возвращайтесь с новыми силами.")
        Console.ReadLine()
        exRand = oRand.Next(10, 50)
        _hero._h._Ex -= exRand
        If _hero._h._Ex <= 0 Then _hero._h._Ex = 0
      Case 2
        Console.Clear()
        _hero.InfoBar(1)
        Console.WriteLine(" ")
        Console.WriteLine("   Враг побеждён!")
        Console.WriteLine("   Продолжайте своё путешествие, авантюрист.")
        Console.ReadLine()

        If _hero._cvest(2) = 0 Then
          _cvest(2) = 2
          _hero._cvest(2) = 4
          Console.WriteLine("   Вы получили свою награду.")
        End If
        If _hero._cvest(2) = 3 Then _hero._cvest(2) = 4

        _money += _enemy._BossGame(_nomberBoss)._moneyBoss
        _hero._h._Ex += _enemy._BossGame(_nomberBoss)._ExpBoss + exRand
        If _hero._h._Ex >= _hero._h._ExMax Then 'Новый уровень
          _hero._h._Ex -= _hero._h._ExMax
          _hero._h._ExMax *= 1.32
          _hero._h._mana = _hero._h._manaMax
          _hero._h._lvl += 1
          _Perks += 4
          _PerksSkils += 1
        End If
    End Select
    _figthTime = 1
    Console.Clear()
  End Sub

  Public Sub MapMove(ByVal _savePointSet As Integer) 'Туториальная и первая локация
    Dim _map As New Map
    _map.PersonPrint(_hero._h._RPclass, _hero._h._RPrace, _hero._h._lvl)
    Select Case _savePointSet
      Case 0 'Начальная карта
        While _pointSet <> "exit"
          _hero.InfoBar(1)
          'Console.WriteLine("  " & _pointX & "  " & _pointY & "  " & _pointSet)
          _map.BeginMap(_pointX, _pointY)
          Console.WriteLine(" |Используйте ввод клавиш w, a, s, d. Раскладка неважна.                                     ")
          Console.WriteLine("     |Используйте клавиши действий t, b, p.                                                                        ")
          Console.WriteLine("                                                                                         ")
          Click_Botton(30, 14)
          If _pointX = 29 And _pointY = 13 Then
            _pointSet = "exit"
          End If

        End While
      Case 1 'Первая локация
        While _pointSet <> "1"
          _hero.InfoBar(1)
          Dim oRand = New Random(DateTime.Now.Millisecond)
          'Console.WriteLine("  " & mRand & _saveMap)
          'Console.WriteLine("  " & _pointX & "  " & _pointY & "  " & _pointSet)
          _map.PersonPrint(_hero._h._RPclass, _hero._h._RPrace, _hero._h._lvl)
          _map.MapSet(_pointX, _pointY)
          Console.WriteLine("  ║Гнилистые леса:  " & _map._nameLocation & "                                                                        ")
          Console.WriteLine("                ╙" & _map._messegLocation & "                                                                                         ")
          Console.WriteLine()
          Console.SetCursorPosition(14, 23)
          'Console.ForegroundColor = ConsoleColor.Black
          Click_Botton(49, 15)
          mRand = oRand.Next(1, 130)

          If ((_pointX = 23 Or _pointX = 24 Or _pointX = 25) And _pointY = 15) Then 'Переход на вторую локацию
            _pointSet = "1"
            _pointX = 26
            _pointY = 1
            _saveMap = 2
            Dim i, j As Integer
            For i = 0 To 16
              For j = 0 To 50
                _map._hillStatic(i, j) = _map._hillConst(i, j)
              Next
            Next
          ElseIf (_pointX = 43 And _pointY = 7) And (_hero._cvest(2) = 0 Or _hero._cvest(2) = 3) Then 'Битва с боссом.
            BossFiht(1)

          ElseIf (_pointX = 1 Or _pointX = 2) And (_pointY = 1 Or _pointY = 2) Then 'Переход на третью локацию
            _pointSet = "1"
            _pointX = 49
            _pointY = 14
            _saveMap = 3
            Dim i, j As Integer
            For i = 0 To 16
              For j = 0 To 50
                _map._hillStatic(i, j) = _map._hillConst(i, j)
              Next
            Next
          End If

          If mRand >= 123 Then 'Блог появления моба
            Console.Clear()
            Fighting(1)
          End If
        End While

      Case 2
        While _pointSet <> "2"
          _hero.InfoBar(1)
          Dim oRand = New Random(DateTime.Now.Millisecond)
          'Console.WriteLine("  " & mRand & _saveMap)
          'Console.WriteLine("  " & _pointX & "  " & _pointY & "  " & _pointSet)
          _map.PersonPrint(_hero._h._RPclass, _hero._h._RPrace, _hero._h._lvl)
          _map.MapSet2(_pointX, _pointY)
          Console.WriteLine("  ║Гнилистые леса:  " & _map._nameLocation & "                                                                        ")
          Console.WriteLine("                ╙" & _map._messegLocation & "                                                                                         ")
          Console.WriteLine()
          Console.Write("              ")
          Click_Botton(49, 15)
          mRand = oRand.Next(1, 130)

          If (_pointX = 25 And _pointY = 1) Then 'Переход на первую локацию.
            _pointSet = "2"
            _pointX = 24
            _pointY = 14
            _saveMap = 1
            Dim i, j As Integer
            For i = 0 To 16
              For j = 0 To 50
                _map._hillStatic(i, j) = _map._hillConst(i, j)
              Next
            Next
          End If
          If mRand >= 123 Then
            Console.Clear()
            Fighting(_saveMap)
          End If

        End While
      Case 3
        While _pointSet <> "3"
          _hero.InfoBar(1)
          Dim oRand = New Random(DateTime.Now.Millisecond)
          'Console.WriteLine("  " & mRand & _saveMap)
          'Console.WriteLine("  " & _pointX & "  " & _pointY & "  " & _pointSet)
          _map.PersonPrint(_hero._h._RPclass, _hero._h._RPrace, _hero._h._lvl)
          _map.MapSet3(_pointX, _pointY)
          Console.WriteLine(_map._nameLocation & "                                                                        ")
          Console.WriteLine("                ╙" & _map._messegLocation & "                                                                                         ")
          Console.WriteLine()
          Console.Write("              ")
          Click_Botton(49, 15)
          mRand = oRand.Next(1, 130)

          If (_pointX = 49 And _pointY = 15) Then 'Переход на первую локацию.
            _pointSet = "3"
            _pointX = 3
            _pointY = 3
            _saveMap = 1
            Dim i, j As Integer
            For i = 0 To 16
              For j = 0 To 50
                _map._hillStatic(i, j) = _map._hillConst(i, j)
              Next
            Next
          ElseIf (_pointX = 27 And _pointY = 11) And (_hero._cvest(2) = 0 Or _hero._cvest(2) = 3) Then 'Битва с боссом.
            BossFiht(3)

          ElseIf ((_pointX = 2 Or _pointX = 3 Or _pointX = 4) And _pointY = 15) Then 'Переход на первую локацию.
            _pointSet = "3"
            _pointX = 48
            _pointY = 2
            _saveMap = 4
            Dim i, j As Integer
            For i = 0 To 16
              For j = 0 To 50
                _map._hillStatic(i, j) = _map._hillConst(i, j)
              Next
            Next
          End If

          If mRand >= 123 Then
            Console.Clear()
            Fighting(_saveMap)
          End If
        End While
      Case 4
        While _pointSet <> "4"
          _hero.InfoBar(1)
          Dim oRand = New Random(DateTime.Now.Millisecond)
          'Console.WriteLine("  " & mRand & _saveMap)
          'Console.WriteLine("  " & _pointX & "  " & _pointY & "  " & _pointSet)
          _map.PersonPrint(_hero._h._RPclass, _hero._h._RPrace, _hero._h._lvl)
          _map.MapSet4(_pointX, _pointY)
          Console.WriteLine(_map._nameLocation & "                                                                        ")
          Console.WriteLine("                ╙" & _map._messegLocation & "                                                                                         ")
          Console.WriteLine()
          Console.Write("              ")
          Click_Botton(49, 15)
          mRand = oRand.Next(1, 130)

          If ((_pointX = 46 Or _pointX = 47 Or _pointX = 48) And _pointY = 1) Then 'Переход на первую локацию.
            _pointSet = "4"
            _pointX = 3
            _pointY = 14
            _saveMap = 3
            Dim i, j As Integer
            For i = 0 To 16
              For j = 0 To 50
                _map._hillStatic(i, j) = _map._hillConst(i, j)
              Next
            Next
          End If

          If mRand >= 123 Then
            Console.Clear()
            Fighting(_saveMap)
          End If
        End While
    End Select
    _pointSet = "v"
    _map = Nothing
  End Sub


  Public Sub LoadFon(ByVal _MapPoint As Integer) 'Переход между локаицями, тут могут быть советы и разная другая полезная информация.
    Console.Clear()
    _hero._h._mana = _hero._h._manaMax
    _hero.InfoBar(1)
    Console.WriteLine("  Переход в другое место... ")

    Console.ReadLine()
    Console.Clear()
    Select Case _MapPoint
      Case 1
        MapMove(1)
      Case 2
        MapMove(2)
      Case 3
        MapMove(3)
      Case 4
        MapMove(4)
    End Select
    If _hero._cvest(2) = 4 Then _hero._cvest(2) = 3

  End Sub

  Public Sub Click_Botton(ByVal _Point_X As Int16, ByVal _point_Y As Integer) 'Основные клавиши перемещения и действий
    Console.ForegroundColor = ConsoleColor.Black
    Console.CursorVisible = False
    Dim info As ConsoleKeyInfo = Console.ReadKey()
    Try
      Console.SetCursorPosition(14, 23)
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
        Case 69 'Вход в город

          _city.Perechen(_hero._Bagcheck(1), _hero._Bagcheck(2), _hero._Bagcheck(3), _hero._Bagcheck(4), _hero._Bagcheck(5), _hero._Bagcheck(6), _hero._Bagcheck(7), _hero._Bagcheck(8), _hero._Bagcheck(9), _hero._Bagcheck(10))
          Console.Clear()
          _hero.InfoBar(0) 'Надо сделать обновление вывода информации персонажа с деньгами.
          If _saveMap = 2 And _pointX = 38 And _pointY = 8 Then
            _city.VivodCity2()
            Console.Clear()

          End If
          For _bagset = 1 To 10
            _hero._Bagcheck(_bagset) = _city._bag(_bagset)
            _bagitem(_bagset) = _hero._Bagcheck(_bagset)
          Next
        Case 27 'Выход.
          Select Case _saveMap
            Case 1
              _pointSet = "1"
            Case 2
              _pointSet = "2"
            Case 3
              _pointSet = "3"
            Case 4
              _pointSet = "4"
          End Select
          _AdventureSave = 0

        Case 80 'Информация о персонаже
          Console.Clear()
          _hero.InfoHero()
          If _Perks = 0 Then
            Console.ReadLine()
            Console.Clear()
          ElseIf _Perks > 0 Then
            While _vibor(6) <> 2
              Console.WriteLine(" 1. Распределить очки")
              Console.WriteLine(" 2. Выйти в меню")
              Dim infoPerks As ConsoleKeyInfo = Console.ReadKey()
              Try
                _vibor(6) = infoPerks.Key - 48
              Catch ex As Exception

              End Try
              Select Case _vibor(6)
                Case 1
                  Perks_stats(_hero._h._RPclass)
              End Select
              SaveData()
            End While
            Console.Clear()
          End If
          _vibor(6) = 0

        Case 84 'Таланты
          Console.Clear()
          _hero.InfoBar(1)
          Console.WriteLine("  ")
          Dim _book As New BookSkils
          _book.Skils(_hero._skl(0)._RPability, _hero._skl(0)._damage, _hero._skils(1), _hero._PerksStatLvl(0))
          _book.Skils(_hero._skl(1)._RPability, _hero._skl(1)._damage, _hero._skils(2), _hero._PerksStatLvl(1))
          _book.Skils(_hero._skl(2)._RPability, _hero._skl(2)._damage, _hero._skils(3), _hero._PerksStatLvl(2))
          _book.Skils(_hero._skl(3)._RPability, _hero._skl(3)._damage, _hero._skils(4), _hero._PerksStatLvl(3))
          If _PerksSkils = 0 Then
            Console.ReadLine()
            Console.Clear()
          ElseIf _PerksSkils > 0 Then
            While _vibor(8) <> 2
              Console.WriteLine(" 1. Распределить очки")
              Console.WriteLine(" 2. Выйти в меню")
              Dim infoPerksis As ConsoleKeyInfo = Console.ReadKey()
              Try
                _vibor(8) = infoPerksis.Key - 48
              Catch ex As Exception
                Select Case _vibor(8)
                  Case 1
                    Perks_Skils()
                End Select
                SaveData()
              End Try
              Select Case _vibor(8)
                Case 1
                  Perks_Skils()
              End Select
              SaveData()
            End While
            Console.Clear()
          End If
          _vibor(8) = 0
          _book = Nothing

        Case 66 'Инвентарь
          'Инициализация параметров героя и его экипировки для инвентаря и его методов
          UpdateStatsHero(1)
          For _bagitemset As Integer = 1 To 10
            _bagitem(_bagitemset) = _hero._Bagcheck(_bagitemset)
          Next
          Console.Clear()
          _hero.InfoBar(0)
          Dim _bag As New Bagpack
          _bag.Inventary(_money)
          'Перевод параметров и вещей из методов инвентаря в методы героя
          UpdateStatsHero(2)
          For _bagitemset As Integer = 1 To 10
            _hero._Bagcheck(_bagitemset) = _bagitem(_bagitemset)
          Next
          Console.Clear()
          _bag = Nothing

        Case 77 'Карта
          Dim _mapM As New Map
          _hero.InfoBar(1)
          Console.WriteLine("  ")
          _mapM.PersonPrint(_hero._h._RPclass, _hero._h._RPrace, _hero._h._lvl)
          _mapM.Minimap(_saveMap)
          Console.ReadLine()
          Console.SetCursorPosition(0, 6)
          For clearScreen = 1 To 22
            Console.WriteLine("                                                                                                                             ")
          Next

      End Select


    Catch ex As Exception


    End Try
  End Sub

  Public Sub UpdateStatsHero(ByVal _setpos As Integer)
    Select Case _setpos
      Case 1
        _hero._h._strength -= _hero._strength_Equip
        _hero._h._intelligece -= _hero._intelligece_Equip
        _hero._h._agility -= _hero._agility_Equip
        _hero._h._defense -= _hero._defense_Equip
        _hero._h._accuracy -= _hero._accuracy_Equip
        _statshero(1) = _hero._strength_Equip
        _statshero(2) = _hero._intelligece_Equip
        _statshero(3) = _hero._defense_Equip
        _statshero(4) = _hero._agility_Equip
        _statshero(5) = _hero._accuracy_Equip
        _equip(1) = _hero._Equip(1)
        _equip(2) = _hero._Equip(2)
        _equip(3) = _hero._Equip(3)
        _equip(4) = _hero._Equip(4)
        _equip(5) = _hero._Equip(5)

      Case 2
        _hero._strength_Equip = _statshero(1)
        _hero._intelligece_Equip = _statshero(2)
        _hero._defense_Equip = _statshero(3)
        _hero._agility_Equip = _statshero(4)
        _hero._accuracy_Equip = _statshero(5)
        _hero._Equip(1) = _equip(1)
        _hero._Equip(2) = _equip(2)
        _hero._Equip(3) = _equip(3)
        _hero._Equip(4) = _equip(4)
        _hero._Equip(5) = _equip(5)
        _hero._h._strength += _hero._strength_Equip
        _hero._h._intelligece += _hero._intelligece_Equip
        _hero._h._agility += _hero._agility_Equip
        _hero._h._defense += _hero._defense_Equip
        _hero._h._accuracy += _hero._accuracy_Equip
        Perks_stats(_hero._h._RPclass)
    End Select
  End Sub

  Public Sub Perks_stats(ByVal _classes As String)
    While _Perks <> 0
      Console.Clear()
      Console.WriteLine("  ")
      Console.WriteLine("     Распределите очки: " & _Perks)
      Console.WriteLine("     _______________")
      Console.WriteLine("    ║ 1. Сила " & _hero._h._strength)
      Console.WriteLine("    │ 2. Интеллект " & _hero._h._intelligece)
      Console.WriteLine("    │ 3. Защита " & _hero._h._defense)
      Console.WriteLine("    │ 4. Ловкость " & _hero._h._agility)
      Console.WriteLine("    │ 5. Точность " & _hero._h._accuracy)
      Console.WriteLine("    │ Здоровье: " & _hero._h._liveMax)
      Console.WriteLine("    │ Мана: " & _hero._h._manaMax)
      Console.WriteLine("    └ ")
      Console.Write("     Ваш выбор:")
      Dim info As ConsoleKeyInfo = Console.ReadKey()
      Try
        _vibor(7) = info.Key - 48
        _Perks -= 1
      Catch ex As Exception

      End Try
      Select Case _vibor(7)
        Case 1 'Изменить параметр силы
          _hero._dopperks(1) += 1

        Case 2 'Изменить параметр интеллекта
          _hero._dopperks(2) += 1

        Case 3 'Изменить параметр Защиты
          _hero._dopperks(3) += 1
          _hero._dopperks(1) += 1

        Case 4 'Изменить параметр Ловкости
          _hero._dopperks(4) += 1
          _hero._dopperks(2) += 1
        Case 5 'Изменить параметр Точности
          If _hero._h._accuracy < 50 Then
            _hero._dopperks(5) += 1

          End If
      End Select
      _hero.Uploadstats()
    End While


    'Без очков добавления, для обновления экипировки
    _hero.Uploadstats()

    Select Case _classes
      Case "Воин"
        _hero._skl(0)._damage = (_hero._h._strength / 2) * (_hero._h._accuracy * 0.35)
        _hero._skl(1)._damage = (_hero._h._strength / 1.8) * (_hero._h._accuracy * 0.55)
        _hero._skl(2)._damage = (_hero._h._strength / 1.55) * (_hero._h._accuracy * 0.78)
        _hero._skl(3)._damage = (_hero._h._strength / 1.2) * (_hero._h._accuracy * 0.95)

        _hero._skl(0)._crit = (_hero._h._strength * 2.1 + _hero._h._defense * 2.1) * 2
        _hero._skl(1)._crit = (_hero._h._strength * 3.25 + _hero._h._defense * 3.25) * 2.2
        _hero._skl(2)._crit = (_hero._h._strength * 4.36 + _hero._h._defense * 4.36) * 2.6
        _hero._skl(3)._crit = (_hero._h._strength * 5.45 + _hero._h._defense * 5.45) * 2.8 + (_hero._h._lvl * 10)

      Case "Маг"
        _hero._skl(0)._damage = (_hero._h._intelligece / 2) * (_hero._h._accuracy * 0.35)
        _hero._skl(1)._damage = (_hero._h._intelligece / 1.8) * (_hero._h._accuracy * 0.55)
        _hero._skl(2)._damage = (_hero._h._intelligece / 1.55) * (_hero._h._accuracy * 0.78)
        _hero._skl(3)._damage = (_hero._h._intelligece / 1.2) * (_hero._h._accuracy * 0.95)

        _hero._skl(0)._crit = (_hero._h._intelligece * 2.1 + _hero._h._agility * 2.1) * 2
        _hero._skl(1)._crit = (_hero._h._intelligece * 3.25 + _hero._h._agility * 3.25) * 2.2
        _hero._skl(2)._crit = (_hero._h._intelligece * 4.36 + _hero._h._agility * 4.36) * 2.6
        _hero._skl(3)._crit = (_hero._h._intelligece * 5.45 + _hero._h._agility * 5.45) * 2.8 + (_hero._h._lvl * 10)


      Case "Лучник"
        _hero._skl(0)._damage = (_hero._h._intelligece / 2) * (_hero._h._accuracy * 0.23)
        _hero._skl(1)._damage = (_hero._h._intelligece / 1.8) * (_hero._h._accuracy * 0.48)
        _hero._skl(2)._damage = (_hero._h._intelligece / 1.55) * (_hero._h._accuracy * 0.69)
        _hero._skl(3)._damage = (_hero._h._intelligece / 1.2) * (_hero._h._accuracy * 0.91)

        _hero._skl(0)._crit = 1.8 * ((_hero._h._strength + _hero._h._intelligece) + (10 * (_hero._h._agility / 5)))
        _hero._skl(1)._crit = 2.5 * ((_hero._h._strength + _hero._h._intelligece) + (11 * (_hero._h._agility / 4)))
        _hero._skl(2)._crit = 4.1 * ((_hero._h._strength + _hero._h._intelligece) + (15 * (_hero._h._agility / 2.5)))
        _hero._skl(3)._crit = 6 * ((_hero._h._strength + _hero._h._intelligece) + (19.5 * (_hero._h._agility / 1.5)) + (_hero._h._lvl * 10))

      Case "Плут"
        _hero._skl(0)._damage = (_hero._h._strength / 2) * (_hero._h._accuracy * 0.23)
        _hero._skl(1)._damage = (_hero._h._strength / 1.8) * (_hero._h._accuracy * 0.48)
        _hero._skl(2)._damage = (_hero._h._strength / 1.55) * (_hero._h._accuracy * 0.69)
        _hero._skl(3)._damage = (_hero._h._strength / 1.2) * (_hero._h._accuracy * 0.91)

        _hero._skl(0)._crit = 1.8 * ((_hero._h._strength + _hero._h._intelligece) + (10 * (_hero._h._defense / 5)))
        _hero._skl(1)._crit = 2.5 * ((_hero._h._strength + _hero._h._intelligece) + (11 * (_hero._h._defense / 4)))
        _hero._skl(2)._crit = 4.1 * ((_hero._h._strength + _hero._h._intelligece) + (15 * (_hero._h._defense / 2.5)))
        _hero._skl(3)._crit = 6 * ((_hero._h._strength + _hero._h._intelligece) + (19.5 * (_hero._h._defense / 1.5)) + (_hero._h._lvl * 10))

    End Select

  End Sub

  Public Sub Perks_Skils()

    While _PerksSkils <> 0
      Console.Clear()
      Console.WriteLine("  ")
      Console.WriteLine("     Распределите очки: " & _PerksSkils)
      Console.WriteLine("     _______________")
      Console.WriteLine("    ║ 1. " & _hero._skl(0)._RPability & ": " & _hero._skils(1) & " ур. " & _hero._skl(0)._damage & " +" & _hero._PerksStatLvl(0))
      If _hero._skils(1) > 3 Then Console.WriteLine("    │ 2. " & _hero._skl(1)._RPability & ": " & _hero._skils(2) & " ур.  " & _hero._skl(1)._damage & " +" & _hero._PerksStatLvl(1))
      If _hero._skils(2) > 3 Then Console.WriteLine("    │ 3. " & _hero._skl(2)._RPability & ": " & _hero._skils(3) & " ур.  " & _hero._skl(2)._damage & " +" & _hero._PerksStatLvl(2))
      If _hero._skils(3) > 3 Then Console.WriteLine("    │ 4. " & _hero._skl(3)._RPability & ": " & _hero._skils(4) & " ур.  " & _hero._skl(3)._damage & " +" & _hero._PerksStatLvl(3))
      Console.WriteLine("    └                                                         ")
      Console.Write("     Ваш выбор:")
      Dim infot As ConsoleKeyInfo = Console.ReadKey()

      Try
        _vibor(9) = infot.Key - 48
        _PerksSkils -= 1
      Catch ex As Exception

      End Try
      Select Case _vibor(9)
        Case 1
          _hero._skils(1) += 1
          _hero._PerksStatLvl(0) = _hero._skils(1) * 10
          If _hero._skils(1) = 4 Then _hero._skils(2) = 1
        Case 2
          If _hero._skils(1) > 3 Then
            _hero._skils(2) += 1
            _hero._PerksStatLvl(1) = _hero._skils(2) * 12.5
            If _hero._skils(2) = 4 Then _hero._skils(3) = 1
          End If
        Case 3
          If _hero._skils(2) > 3 Then
            _hero._skils(3) += 1
            _hero._PerksStatLvl(2) = _hero._skils(3) * 17
            If _hero._skils(3) = 4 Then _hero._skils(4) = 1
          End If
        Case 4
          If _hero._skils(3) > 3 Then
            _hero._skils(4) += 1
            _hero._PerksStatLvl(3) = _hero._skils(4) * 25
          End If
        Case 0
          If _hero._skils(4) > 31 Then

          End If
      End Select
    End While
  End Sub


  Public Sub Newgame() 'Новая игра
    Console.Clear()
    Console.WriteLine("  ")
    _System.TxtRGB("Yellow", "Black", "                 ╚═════════════════════════╝", True)
    Console.WriteLine("                    Приветствую, путник!          ")
    Console.Write("                   Введите имя персонажа: ")
    _hero._h._name = Console.ReadLine()
    _System.TxtRGB("Yellow", "Black", "                 ╔═════════════════════════╗", True)
    Console.WriteLine("                   Добро пожаловать, " & _hero._h._name & "!")
    Console.ReadLine()
    Console.Clear()

    While _chekhero <> "Да"
      _hero.None()
      'Выбор класса
      Console.WriteLine("  ")
      Console.WriteLine("     Выберите класс персонажа:")
      Console.WriteLine("     _______________")
      Console.WriteLine("    ║ 1. Воин - мечник")
      Console.WriteLine("    │ 2. Маг - колдун")
      Console.WriteLine("    │ 3. Лучник - охотник")
      Console.WriteLine("    │ 4. Плут - вор")
      Console.WriteLine("    └ ")
      Console.Write("     Ваш выбор:")
      Dim info0 As ConsoleKeyInfo = Console.ReadKey()
      Try
        _vibor(1) = info0.Key - 48
        Select Case _vibor(1)
          Case 1
            _hero.Warrior()
          Case 2
            _hero.Magician()
          Case 3
            _hero.Archer()
          Case 4
            _hero.Rogue()
        End Select
      Catch ex As Exception
        _hero.Warrior()
      End Try
      Console.WriteLine(" ")
      'Выбор расы
      Console.WriteLine("  ")
      Console.WriteLine("     Выберите расу персонажа:")
      Console.WriteLine("     _______________")
      Console.WriteLine("    ║ 1. Человек")
      Console.WriteLine("    │ 2. Эльф")
      Console.WriteLine("    │ 3. Дворф")
      Console.WriteLine("    └ ")
      Console.Write("   Ваш выбор:")
      Dim info1 As ConsoleKeyInfo = Console.ReadKey()
      Try
        _vibor(3) = info1.Key - 48
        Select Case _vibor(3)
          Case 1
            _hero.Parameters("Человек", _hero._h._RPclass)
          Case 2
            _hero.Parameters("Эльф", _hero._h._RPclass)
          Case 3
            _hero.Parameters("Дворф", _hero._h._RPclass)
        End Select
      Catch ex As Exception
        _hero.Parameters("Человек", _hero._h._RPclass)
      End Try
      Console.Clear()
      _hero.InfoHero()
      Console.WriteLine(" Продолжить? (Y\N) ") '89
      Dim infocheckplay As ConsoleKeyInfo = Console.ReadKey()
      Dim chekpoint As Integer
      Try
        chekpoint = infocheckplay.Key - 48
        If chekpoint = 41 Then _chekhero = "Да"
      Catch ex As Exception

      End Try
      Console.Clear()
    End While
    'Карта и передвижение
    MapMove(_saveMap)
    _enemy._enemylive = 1400
    _hero._h._live = _hero._h._liveMax
    'Позиция на первой локации после перемещения по начальной карте
    _pointX = 16
    _pointY = 6
    _pointSet = "v"
    Console.Clear()
    Console.WriteLine(" ")
    Console.Clear()
    _hero.InfoBar(0)
    Console.WriteLine("    Определившись с делом всей своей жизни, юный авантюрист ")
    Console.WriteLine("   отправился на встречу приключениям.")
    Console.WriteLine("   Но не пройдя и некоторого расстояния от точки старта, ")
    Console.WriteLine("   на пути появился огромный Огр!")
    Console.WriteLine(" ")
    Console.WriteLine("   И герой вступил в бой!")
    Console.ReadLine()
    Console.Clear()
    'Первый бой
    Console.Clear()
    _hero.InfoBar(0)
    Console.WriteLine(" ")
    Console.Write("  " & _enemy._enemyName & "   [" & _enemy._enemyLiveMax & "]")
    _hero.Exxeption(_enemy._enemylive, _enemy._enemyLiveMax, "Green")
    Console.WriteLine("  - Тут и далее отображается ваш враг.")
    Console.WriteLine("  ========================")
    Console.Write("  " & _hero._h._name & "   [" & _hero._h._liveMax & "]")
    _hero.Exxeption(_hero._h._live, _hero._h._liveMax, "Red")
    Console.WriteLine(" - Тут и далее отображается ваша жизнь.")
    Console.WriteLine(" ")
    Console.WriteLine(" 1. " & _hero._skl(0)._RPability)
    _System.TxtRGB("DarkGray", "Black", " 2. Использовать зелье здоровья", True)
    Console.WriteLine(" | Наживайте на доступные клавиши действий и победите врага!")

    Try
      _vibor(2) = Console.ReadLine()
    Catch ex As Exception
      _hero.Dmg()
      _hero.Vfight(3)
    End Try

    'Механика боя
    While _enemy._enemylive > 0
      Select Case _vibor(2)
        Case 1
          _hero.Udmg()
          'Шанс критического удара
          Dim oRand = New Random(DateTime.Now.Millisecond)
          iRand = oRand.Next(1, 100 - _hero._h._accuracy)
          If iRand <= _hero._h._accuracy Then
            _enemy._enemylive -= _hero._skl(0)._crit
            _hero.Vfight(2)
          Else 'Обычная атака
            _hero.Dmg()
            _hero.Vfight(1)
          End If
        Case 2
          _hero.Vfight(3)
        Case 3
          _hero.Udmg()
          _hero.Vfight(3)
      End Select
      If _enemy._enemylive > 0 Then
        Console.WriteLine(" 1. " & _hero._skl(0)._RPability)
        _System.TxtRGB("DarkGray", "Black", " 2. Использовать зелье здоровья", True)
        Console.WriteLine("                                                                                ")
        Try
          _vibor(2) = Console.ReadLine()
        Catch ex As Exception
          _hero.Udmg()
          _hero.Vfight(3)
        End Try
      End If

    End While
    Console.Clear()
    _hero.InfoBar(0)
    Console.WriteLine(" ")
    Console.WriteLine(" Поздравляем с победой!")
    Console.WriteLine(" " & _hero._h._name & ", перед тобой открылись дороги к незабываемым и опасным испытаниям!")
    Console.WriteLine(" Удачи и пусть путиводная звезда осветит твой путь героя!")

    _hero._h._Ex += 15
    _save = 1
    _saveMap = 1
    _botleLive = 10
    _botleMana = 10
    'запись в файл
    SaveData()
    Console.ReadLine()
  End Sub

  Public Sub SaveData() 'запись в файл

    Try
      Dim textFileStream As New IO.FileStream("Parametrs.save", IO.FileMode.OpenOrCreate,
                            IO.FileAccess.ReadWrite, IO.FileShare.None)
      Dim myFileWriter As New IO.StreamWriter(textFileStream)
      myFileWriter.WriteLine(_hero._h._name)
      myFileWriter.WriteLine(_hero._h._lvl)
      myFileWriter.WriteLine(_hero._h._ExMax)
      myFileWriter.WriteLine(_hero._h._Ex)
      myFileWriter.WriteLine(_hero._h._RPclass)
      myFileWriter.WriteLine(_hero._h._RPrace)
      myFileWriter.WriteLine(_money)
      'основные параметры
      myFileWriter.WriteLine(_hero._h._strength)
      myFileWriter.WriteLine(_hero._h._intelligece)
      myFileWriter.WriteLine(_hero._h._agility)
      myFileWriter.WriteLine(_hero._h._defense)
      myFileWriter.WriteLine(_hero._h._accuracy)
      myFileWriter.WriteLine(_Perks)
      myFileWriter.WriteLine(_hero._skl(0)._crit)
      myFileWriter.WriteLine(_hero._skl(1)._crit)
      myFileWriter.WriteLine(_hero._skl(2)._crit)
      myFileWriter.WriteLine(_hero._skl(3)._crit)
      myFileWriter.WriteLine(_hero._h._live)
      myFileWriter.WriteLine(_hero._h._mana)
      myFileWriter.WriteLine(_hero._h._liveMax)
      myFileWriter.WriteLine(_hero._h._manaMax)
      'Дополнительные параметры
      myFileWriter.WriteLine(_hero._dopperks(1))
      myFileWriter.WriteLine(_hero._dopperks(2))
      myFileWriter.WriteLine(_hero._dopperks(3))
      myFileWriter.WriteLine(_hero._dopperks(4))
      myFileWriter.WriteLine(_hero._dopperks(5))
      'Дополнительные параметры расы
      myFileWriter.WriteLine(_hero._h._strength_race)
      myFileWriter.WriteLine(_hero._h._intelligece_race)
      myFileWriter.WriteLine(_hero._h._agility_race)
      myFileWriter.WriteLine(_hero._h._defense_race)
      myFileWriter.WriteLine(_hero._h._accuracy_race)
      'Дополнительные параметры классов
      myFileWriter.WriteLine(_hero._h._strength_Class)
      myFileWriter.WriteLine(_hero._h._intelligece_Class)
      myFileWriter.WriteLine(_hero._h._agility_Class)
      myFileWriter.WriteLine(_hero._h._defense_Class)
      myFileWriter.WriteLine(_hero._h._accuracy_Class)
      'Дополнительные параметры экипировки
      myFileWriter.WriteLine(_hero._live_Equip)
      myFileWriter.WriteLine(_hero._strength_Equip)
      myFileWriter.WriteLine(_hero._intelligece_Equip)
      myFileWriter.WriteLine(_hero._agility_Equip)
      myFileWriter.WriteLine(_hero._defense_Equip)
      myFileWriter.WriteLine(_hero._accuracy_Equip)
      'Экипировка
      myFileWriter.WriteLine(_hero._Equip(1))
      myFileWriter.WriteLine(_hero._Equip(2))
      myFileWriter.WriteLine(_hero._Equip(3))
      myFileWriter.WriteLine(_hero._Equip(4))
      myFileWriter.WriteLine(_hero._Equip(5))
      'Сумка
      myFileWriter.WriteLine(_hero._Bagcheck(1))
      myFileWriter.WriteLine(_hero._Bagcheck(2))
      myFileWriter.WriteLine(_hero._Bagcheck(3))
      myFileWriter.WriteLine(_hero._Bagcheck(4))
      myFileWriter.WriteLine(_hero._Bagcheck(5))
      myFileWriter.WriteLine(_hero._Bagcheck(6))
      myFileWriter.WriteLine(_hero._Bagcheck(7))
      myFileWriter.WriteLine(_hero._Bagcheck(8))
      myFileWriter.WriteLine(_hero._Bagcheck(9))
      myFileWriter.WriteLine(_hero._Bagcheck(10))
      'Бутылки 
      myFileWriter.WriteLine(_botleMana)
      myFileWriter.WriteLine(_botleLive)
      'Способности
      myFileWriter.WriteLine(_PerksSkils)
      myFileWriter.WriteLine(_hero._skl(0)._RPability)
      myFileWriter.WriteLine(_hero._skl(1)._RPability)
      myFileWriter.WriteLine(_hero._skl(2)._RPability)
      myFileWriter.WriteLine(_hero._skl(3)._RPability)
      myFileWriter.WriteLine(_hero._skl(0)._damage)
      myFileWriter.WriteLine(_hero._skl(1)._damage)
      myFileWriter.WriteLine(_hero._skl(2)._damage)
      myFileWriter.WriteLine(_hero._skl(3)._damage)
      myFileWriter.WriteLine(_hero._skils(1))
      myFileWriter.WriteLine(_hero._skils(2))
      myFileWriter.WriteLine(_hero._skils(3))
      myFileWriter.WriteLine(_hero._skils(4))
      myFileWriter.WriteLine(_hero._PerksStatLvl(0))
      myFileWriter.WriteLine(_hero._PerksStatLvl(1))
      myFileWriter.WriteLine(_hero._PerksStatLvl(2))
      myFileWriter.WriteLine(_hero._PerksStatLvl(3))
      'Квесты
      myFileWriter.WriteLine(_hero._cvest(1))
      myFileWriter.WriteLine(_hero._cvest(2))
      myFileWriter.WriteLine(_hero._cvest(3))
      myFileWriter.WriteLine(_saveMap)
      myFileWriter.WriteLine(_save)
      myFileWriter.Close()
      textFileStream.Close()
      Console.WriteLine(" ")
      Console.WriteLine("_________________")
      Console.WriteLine("Данные сохранены.")
    Catch ex As Exception
      Console.WriteLine(" ")
      Console.WriteLine("_________________")
      Console.WriteLine("Ошибка сохранения данных.")
    End Try

  End Sub

  Public Sub LoadData() 'Чтение данных из файла

    Try
      Dim textFileStream As New IO.FileStream("Parametrs.save", IO.FileMode.OpenOrCreate,
                           IO.FileAccess.ReadWrite, IO.FileShare.None)
      Dim myFileReader As New IO.StreamReader(textFileStream)
      _hero._h._name = myFileReader.ReadLine()
      _hero._h._lvl = myFileReader.ReadLine()
      _hero._h._ExMax = myFileReader.ReadLine()
      _hero._h._Ex = myFileReader.ReadLine()
      _hero._h._RPclass = myFileReader.ReadLine()
      _hero._h._RPrace = myFileReader.ReadLine()
      _money = myFileReader.ReadLine()
      'основные параметры
      _hero._h._strength = myFileReader.ReadLine()
      _hero._h._intelligece = myFileReader.ReadLine()
      _hero._h._agility = myFileReader.ReadLine()
      _hero._h._defense = myFileReader.ReadLine()
      _hero._h._accuracy = myFileReader.ReadLine()
      _PerksSkils = myFileReader.ReadLine()
      _hero._skl(0)._crit = myFileReader.ReadLine()
      _hero._skl(1)._crit = myFileReader.ReadLine()
      _hero._skl(2)._crit = myFileReader.ReadLine()
      _hero._skl(3)._crit = myFileReader.ReadLine()
      _hero._h._live = myFileReader.ReadLine()
      _hero._h._mana = myFileReader.ReadLine()
      _hero._h._liveMax = myFileReader.ReadLine()
      _hero._h._manaMax = myFileReader.ReadLine()
      'Дополнительные параметры
      _hero._dopperks(1) = myFileReader.ReadLine()
      _hero._dopperks(2) = myFileReader.ReadLine()
      _hero._dopperks(3) = myFileReader.ReadLine()
      _hero._dopperks(4) = myFileReader.ReadLine()
      _hero._dopperks(5) = myFileReader.ReadLine()
      'Дополнительные параметры расы
      _hero._h._strength_race = myFileReader.ReadLine()
      _hero._h._intelligece_race = myFileReader.ReadLine()
      _hero._h._agility_race = myFileReader.ReadLine()
      _hero._h._defense_race = myFileReader.ReadLine()
      _hero._h._accuracy_race = myFileReader.ReadLine()
      'Дополнительные параметры классов
      _hero._h._strength_Class = myFileReader.ReadLine()
      _hero._h._intelligece_Class = myFileReader.ReadLine()
      _hero._h._agility_Class = myFileReader.ReadLine()
      _hero._h._defense_Class = myFileReader.ReadLine()
      _hero._h._accuracy_Class = myFileReader.ReadLine()
      'Дополнительные параметры экипировки
      _hero._live_Equip = myFileReader.ReadLine()
      _hero._strength_Equip = myFileReader.ReadLine()
      _hero._intelligece_Equip = myFileReader.ReadLine()
      _hero._agility_Equip = myFileReader.ReadLine()
      _hero._defense_Equip = myFileReader.ReadLine()
      _hero._accuracy_Equip = myFileReader.ReadLine()
      'Экипировка
      _hero._Equip(1) = myFileReader.ReadLine()
      _hero._Equip(2) = myFileReader.ReadLine()
      _hero._Equip(3) = myFileReader.ReadLine()
      _hero._Equip(4) = myFileReader.ReadLine()
      _hero._Equip(5) = myFileReader.ReadLine()
      'Сумка
      _hero._Bagcheck(1) = myFileReader.ReadLine()
      _hero._Bagcheck(2) = myFileReader.ReadLine()
      _hero._Bagcheck(3) = myFileReader.ReadLine()
      _hero._Bagcheck(4) = myFileReader.ReadLine()
      _hero._Bagcheck(5) = myFileReader.ReadLine()
      _hero._Bagcheck(6) = myFileReader.ReadLine()
      _hero._Bagcheck(7) = myFileReader.ReadLine()
      _hero._Bagcheck(8) = myFileReader.ReadLine()
      _hero._Bagcheck(9) = myFileReader.ReadLine()
      _hero._Bagcheck(10) = myFileReader.ReadLine()
      'Бутылки
      _botleMana = myFileReader.ReadLine()
      _botleLive = myFileReader.ReadLine()
      'Способности
      _PerksSkils = myFileReader.ReadLine()
      _hero._skl(0)._RPability = myFileReader.ReadLine()
      _hero._skl(1)._RPability = myFileReader.ReadLine()
      _hero._skl(2)._RPability = myFileReader.ReadLine()
      _hero._skl(3)._RPability = myFileReader.ReadLine()
      _hero._skl(0)._damage = myFileReader.ReadLine()
      _hero._skl(1)._damage = myFileReader.ReadLine()
      _hero._skl(2)._damage = myFileReader.ReadLine()
      _hero._skl(3)._damage = myFileReader.ReadLine()
      _hero._skils(1) = myFileReader.ReadLine()
      _hero._skils(2) = myFileReader.ReadLine()
      _hero._skils(3) = myFileReader.ReadLine()
      _hero._skils(4) = myFileReader.ReadLine()
      _hero._PerksStatLvl(0) = myFileReader.ReadLine()
      _hero._PerksStatLvl(1) = myFileReader.ReadLine()
      _hero._PerksStatLvl(2) = myFileReader.ReadLine()
      _hero._PerksStatLvl(3) = myFileReader.ReadLine()
      'Квесты
      _hero._cvest(1) = myFileReader.ReadLine()
      _hero._cvest(2) = myFileReader.ReadLine()
      _hero._cvest(3) = myFileReader.ReadLine()
      _saveMap = myFileReader.ReadLine()
      _save = myFileReader.ReadLine()
      _hero._h._live = _hero._h._liveMax 'Предустановка полных единиц здоровья при загрузке
      myFileReader.Close()
      textFileStream.Close()
      Select Case _hero._h._RPrace
        Case 1
          _hero.Parameters("Человек", _hero._h._RPclass)
        Case 2
          _hero.Parameters("Эльф", _hero._h._RPclass)
        Case 3
          _hero.Parameters("Дворф", _hero._h._RPclass)
      End Select
    Catch ex As Exception

    End Try
    _enemy._enemyStatsGame()
  End Sub

End Module
