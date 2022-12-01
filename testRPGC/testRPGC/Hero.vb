Public Class Hero

  ReadOnly _System As New SystemColorConsole
  Public _live_Equip, _manaMax_Equip, _mana_Equip, _ExMax_Equip, _Ex_Equip, _strength_Equip, _intelligece_Equip, _agility_Equip, _defense_Equip, _accuracy_Equip, _crit_Equip As Single
  Public _Equip(5), _Bagcheck(10) As String
  Public _cvest(3) As Integer 'Определение ориентации заданий
  Public _skils(4) As Integer 'Параметр определяющий уровень скилов.
  Public _PerksStatLvl(4) As Single 'Параметр изменяющийся по уровню скиллов


  Structure _skills 'Структура переменных для скилов
    Public _damage, _crit As Single
    Public _lvl As Integer
    Public _RPability As String
  End Structure

  Structure _hero 'Структурированная система переменных для всех параметров
    Public _live_Class, _strength_Class, _intelligece_Class, _agility_Class, _defense_Class, _accuracy_Class As Single 'параметры классов.
    Public _live_race, _strength_race, _intelligece_race, _agility_race, _defense_race, _accuracy_race As Single 'параметры рас.
    Public _lvl, _liveMax, _live, _manaMax, _mana, _ExMax, _Ex, _strength, _intelligece, _agility, _defense, _accuracy, _Damage As Single ' Базовые параметры соответственно: Сила, Интеллект, Ловкость, Защита, Точность, Критический удар.
    Public _name, _RPclass, _chekclass, _RPrace As String
    Enum _human As Long 'Люди
      _live = 20
      _strength = 20
      _intelligece = 10
      _agility = 10
      _defense = 10
      _accuracy = 5
    End Enum

    Enum _elf As Long 'Эльфы
      _live = 45
      _strength = 10
      _intelligece = 20
      _agility = 25
      _defense = 0
      _accuracy = 10
    End Enum

    Enum _dworf As Long 'Дворфы
      _live = 35
      _strength = 15
      _intelligece = 15
      _agility = 0
      _defense = 35
      _accuracy = 5
    End Enum
    '========================================
    Enum _warrior As Long
      _strength = 70
      _intelligece = 40
      _agility = 0
      _defense = 0
      _accuracy = 10
    End Enum

    Enum _mage As Long
      _strength = 40
      _intelligece = 70
      _agility = 10
      _defense = 0
      _accuracy = 0
    End Enum

    Enum _Archer As Long
      _strength = 65
      _intelligece = 45
      _agility = 0
      _defense = 0
      _accuracy = 10
    End Enum

    Enum _Rogue As Long
      _strength = 45
      _intelligece = 65
      _agility = 0
      _defense = 0
      _accuracy = 10
    End Enum
    '===================================================
    'Enum _equip As Long
    '    _strength = 0
    '    _intelligece = 0
    '    _agility = 0
    '    _defense = 0
    '    _accuracy = 0
    '    _crit = 0
    'End Enum

  End Structure

  Public _h As New _hero
  Public _skl(3) As _skills

  Public Sub None()
    _enemy._enemyStats()
    _h._lvl = 1
    _h._ExMax = 100
    _h._Ex = 0
    _h._RPclass = ""
    _h._RPrace = ""
    _money = 0
    'основные параметры
    _h._strength = 0
    _h._intelligece = 0
    _h._agility = 0
    _h._defense = 0
    _h._accuracy = 0
    _skl(0)._crit = 0
    _skl(1)._crit = 0
    _skl(2)._crit = 0
    _skl(3)._crit = 0
    _h._live = 0
    _h._mana = 0
    _h._liveMax = 0
    _h._manaMax = 0
    'Дополнительные параметры расы
    _h._strength_race = 0
    _h._intelligece_race = 0
    _h._agility_race = 0
    _h._defense_race = 0
    _h._accuracy_race = 0
    'Дополнительные параметры классов
    _h._strength_Class = 0
    _h._intelligece_Class = 0
    _h._agility_Class = 0
    _h._defense_Class = 0
    _h._accuracy_Class = 0
    'Дополнительные параметры экипировки
    _live_Equip = 0
    _strength_Equip = 0
    _intelligece_Equip = 0
    _agility_Equip = 0
    _defense_Equip = 0
    _accuracy_Equip = 0
    'Экипировка
    _Equip(1) = "|Пусто|"
    _Equip(2) = "|Пусто|"
    _Equip(3) = "|Пусто|"
    _Equip(4) = "|Пусто|"
    _Equip(5) = "|Пусто|"
    'Сумка
    _Bagcheck(1) = "|Пусто|"
    _Bagcheck(2) = "|Пусто|"
    _Bagcheck(3) = "|Пусто|"
    _Bagcheck(4) = "|Пусто|"
    _Bagcheck(5) = "|Пусто|"
    _Bagcheck(6) = "|Пусто|"
    _Bagcheck(7) = "|Пусто|"
    _Bagcheck(8) = "|Пусто|"
    _Bagcheck(9) = "|Пусто|"
    _Bagcheck(10) = "|Пусто|"
    'Способности
    _skl(0)._RPability = ""
    _skl(1)._RPability = ""
    _skl(2)._RPability = ""
    _skl(3)._RPability = ""
    _skl(0)._damage = 0
    _skl(1)._damage = 0
    _skl(2)._damage = 0
    _skl(3)._damage = 0
    _skl(0)._crit = 0
    _skl(1)._crit = 0
    _skl(2)._crit = 0
    _skl(3)._crit = 0
    _skils(1) = 0
    _skils(2) = 0
    _skils(3) = 0
    _skils(4) = 0
    _PerksStatLvl(0) = 0
    _PerksStatLvl(1) = 0
    _PerksStatLvl(2) = 0
    _PerksStatLvl(3) = 0
    'Квесты
    _cvest(1) = 0 'Основной
    _cvest(2) = 0 'Дополнительный
    _cvest(3) = 0 'Скрытый
  End Sub

  Public Sub Warrior() 'Начальные параметры воина
    _enemy._enemyStats()
    _h._RPclass = "Воин"
    _skl(0)._RPability = "Удар мечом"
    _skl(1)._RPability = "Усиленный выпад"
    _skl(2)._RPability = "Отбросить щитом"
    _skl(3)._RPability = "Карающий удар"
    _h._strength = _h._warrior._strength
    _h._intelligece = _h._warrior._intelligece
    _h._agility = _h._warrior._agility
    _h._defense = _h._warrior._defense
    _h._accuracy = _h._warrior._accuracy
    _Equip(1) = "Ржавый меч"
    _Equip(2) = "|Пусто|"
    _Equip(3) = "Потрёпанная стёганка"
    _Equip(4) = "|Пусто|"
    _Equip(5) = "Стёртые сапоги"
    _strength_Equip = 10
    _defense_Equip = 5
    _agility_Equip = 5
  End Sub

  Public Sub Magician() 'Начальные параметры мага
    _enemy._enemyStats()
    _h._RPclass = "Маг"
    _skl(0)._RPability = "Огненный шар"
    _skl(1)._RPability = "Электрический разряд"
    _skl(2)._RPability = "Метеоритный дождь"
    _skl(3)._RPability = "Плазменный разряд"
    _h._strength = _h._mage._strength
    _h._intelligece = _h._mage._intelligece
    _h._agility = _h._mage._agility
    _h._defense = _h._mage._defense
    _h._accuracy = _h._mage._accuracy
    _Equip(1) = "Старый посох"
    _Equip(2) = "|Пусто|"
    _Equip(3) = "Халат"
    _Equip(4) = "|Пусто|"
    _Equip(5) = "Стёртые сапоги"
    _intelligece_Equip = 10
    _defense_Equip = 5
    _agility_Equip = 5
  End Sub

  Public Sub Archer() 'Начальные параметры лучника
    _enemy._enemyStats()
    _h._RPclass = "Лучник"
    _skl(0)._RPability = "Выстрел одной стрелой"
    _skl(1)._RPability = "Град стрел"
    _skl(2)._RPability = "5 стрел подряд"
    _skl(3)._RPability = "Выстрел из арбалета"
    _h._strength = _h._Archer._strength
    _h._intelligece = _h._Archer._intelligece
    _h._agility = _h._Archer._agility
    _h._defense = _h._Archer._defense
    _h._accuracy = _h._Archer._accuracy
    _Equip(1) = "Лук лесника"
    _Equip(2) = "|Пусто|"
    _Equip(3) = "Желет"
    _Equip(4) = "|Пусто|"
    _Equip(5) = "Стёртые сапоги"
    _accuracy_Equip = 2
    _defense_Equip = 5
    _agility_Equip = 10
  End Sub

  Public Sub Rogue() 'Начальные параметры плута
    _enemy._enemyStats()
    _h._RPclass = "Плут"
    _skl(0)._RPability = "Удар кинжалами"
    _skl(1)._RPability = "Метательные ножи"
    _skl(2)._RPability = "Взрывная ловушка"
    _skl(3)._RPability = "Выстрел ядовитой стрелой"
    _h._strength = _h._Rogue._strength
    _h._intelligece = _h._Rogue._intelligece
    _h._agility = _h._Rogue._agility
    _h._defense = _h._Rogue._defense
    _h._accuracy = _h._Rogue._accuracy
    _Equip(1) = "Короткие кинжалы"
    _Equip(2) = "|Пусто|"
    _Equip(3) = "Грязный плащ"
    _Equip(4) = "|Пусто|"
    _Equip(5) = "Стёртые сапоги"
    _accuracy_Equip = 2
    _defense_Equip = 10
    _agility_Equip = 5
  End Sub

  Public Sub Parameters(ByVal _race As String, ByVal _class As String) 'Установка и обновление парамеров персонажа.

    Select Case _race
      Case "Человек"
        _h._RPrace = "Человек"
        _h._live += _h._human._live
        _h._strength += _h._human._strength
        _h._intelligece += _h._human._intelligece
        _h._agility += _h._human._agility
        _h._defense += _h._human._defense
        _h._accuracy += _h._human._accuracy
        '   - - - -
        _h._strength_race = _h._human._strength
        _h._intelligece_race = _h._human._intelligece
        _h._agility_race = _h._human._agility
        _h._defense_race = _h._human._defense
        _h._accuracy_race = _h._human._accuracy

      Case "Эльф"
        _h._RPrace = "Эльф"
        _h._live += _h._elf._live
        _h._strength += _h._elf._strength
        _h._intelligece += _h._elf._intelligece
        _h._agility += _h._elf._agility
        _h._defense += _h._elf._defense
        _h._accuracy += _h._elf._accuracy
        '   - - - -
        _h._strength_race = _h._elf._strength
        _h._intelligece_race = _h._elf._intelligece
        _h._agility_race = _h._elf._agility
        _h._defense_race = _h._elf._defense
        _h._accuracy_race = _h._elf._accuracy

      Case "Дворф"
        _h._RPrace = "Дворф"
        _h._live += _h._dworf._live
        _h._strength += _h._dworf._strength
        _h._intelligece += _h._dworf._intelligece
        _h._agility += _h._dworf._agility
        _h._defense += _h._dworf._defense
        _h._accuracy += _h._dworf._accuracy
        '   - - - -
        _h._strength_race = _h._dworf._strength
        _h._intelligece_race = _h._dworf._intelligece
        _h._agility_race = _h._dworf._agility
        _h._defense_race = _h._dworf._defense
        _h._accuracy_race = _h._dworf._accuracy

    End Select

    _h._strength += _strength_Equip
    _h._intelligece += _intelligece_Equip
    _h._defense += (_h._strength / 2) + _defense_Equip
    _h._agility += (_h._intelligece / 2) + _agility_Equip
    _h._accuracy += _accuracy_Equip
    _h._live += 100 + (_h._strength / 2) + _live_Equip
    _h._liveMax = _h._live

    Select Case _class
      Case "Воин"

        _skl(0)._damage = (_h._strength / 2) * (_h._accuracy * 0.35)
        _skl(1)._damage = (_h._strength / 1.8) * (_h._accuracy * 0.55)
        _skl(2)._damage = (_h._strength / 1.55) * (_h._accuracy * 0.78)
        _skl(3)._damage = (_h._strength / 1.2) * (_h._accuracy * 0.95)

        _skl(0)._crit = (_h._strength * 2.1 + _h._defense * 2.1) * 2
        _skl(1)._crit = (_h._strength * 3.25 + _h._defense * 3.25) * 2.2
        _skl(2)._crit = (_h._strength * 4.36 + _h._defense * 4.36) * 2.6
        _skl(3)._crit = (_h._strength * 5.45 + _h._defense * 5.45) * 2.8 + (_h._lvl * 10)

        _skils(1) = 1
        _h._strength_Class = _h._warrior._strength
        _h._intelligece_Class = _h._warrior._intelligece
        _h._accuracy_Class = _h._warrior._accuracy
        _h._defense_Class = _h._warrior._defense
        _h._agility_Class = _h._warrior._agility
      Case "Маг"

        _skl(0)._damage = (_h._intelligece / 2) * (_h._accuracy * 0.35)
        _skl(1)._damage = (_h._intelligece / 1.8) * (_h._accuracy * 0.55)
        _skl(2)._damage = (_h._intelligece / 1.55) * (_h._accuracy * 0.78)
        _skl(3)._damage = (_h._intelligece / 1.2) * (_h._accuracy * 0.95)

        _skl(0)._crit = (_h._intelligece * 2.1 + _h._agility * 2.1) * 2
        _skl(1)._crit = (_h._intelligece * 3.25 + _h._agility * 3.25) * 2.2
        _skl(2)._crit = (_h._intelligece * 4.36 + _h._agility * 4.36) * 2.6
        _skl(3)._crit = (_h._intelligece * 5.45 + _h._agility * 5.45) * 2.8 + (_h._lvl * 10)

        _skils(1) = 1
        _h._strength_Class = _h._mage._strength
        _h._intelligece_Class = _h._mage._intelligece
        _h._accuracy_Class = _h._mage._accuracy
        _h._defense_Class = _h._mage._defense
        _h._agility_Class = _h._mage._agility
      Case "Лучник"

        _skl(0)._damage = (_h._intelligece / 2) * (_h._accuracy * 0.23)
        _skl(1)._damage = (_h._intelligece / 1.8) * (_h._accuracy * 0.48)
        _skl(2)._damage = (_h._intelligece / 1.55) * (_h._accuracy * 0.69)
        _skl(3)._damage = (_h._intelligece / 1.2) * (_h._accuracy * 0.91)

        _skl(0)._crit = 1.8 * ((_h._strength + _h._intelligece) + (10 * (_h._agility / 5)))
        _skl(1)._crit = 2.5 * ((_h._strength + _h._intelligece) + (11 * (_h._agility / 4)))
        _skl(2)._crit = 4.1 * ((_h._strength + _h._intelligece) + (15 * (_h._agility / 2.5)))
        _skl(3)._crit = 6 * ((_h._strength + _h._intelligece) + (19.5 * (_h._agility / 1.5)) + (_h._lvl * 10))

        _skils(1) = 1
        _h._strength_Class = _h._Archer._strength
        _h._intelligece_Class = _h._Archer._intelligece
        _h._accuracy_Class = _h._Archer._accuracy
        _h._defense_Class = _h._Archer._defense
        _h._agility_Class = _h._Archer._agility
      Case "Плут"

        _skl(0)._damage = (_h._strength / 2) * (_h._accuracy * 0.23)
        _skl(1)._damage = (_h._strength / 1.8) * (_h._accuracy * 0.48)
        _skl(2)._damage = (_h._strength / 1.55) * (_h._accuracy * 0.69)
        _skl(3)._damage = (_h._strength / 1.2) * (_h._accuracy * 0.91)

        _skl(0)._crit = 1.8 * ((_h._strength + _h._intelligece) + (10 * (_h._defense / 5)))
        _skl(1)._crit = 2.5 * ((_h._strength + _h._intelligece) + (11 * (_h._defense / 4)))
        _skl(2)._crit = 4.1 * ((_h._strength + _h._intelligece) + (15 * (_h._defense / 2.5)))
        _skl(3)._crit = 6 * ((_h._strength + _h._intelligece) + (19.5 * (_h._defense / 1.5)) + (_h._lvl * 10))


        _skils(1) = 1
        _h._strength_Class = _h._Rogue._strength
        _h._intelligece_Class = _h._Rogue._intelligece
        _h._accuracy_Class = _h._Rogue._accuracy
        _h._defense_Class = _h._Rogue._defense
        _h._agility_Class = _h._Rogue._agility
    End Select
    _h._mana = (_h._intelligece / 10) + 10
    _h._manaMax = _h._mana
  End Sub

  Public Sub InfoBar(ByVal _moneyVis As Integer)
    Dim _color As String
    If _h._RPclass = "Воин" Then _color = "Red"
    If _h._RPclass = "Маг" Then _color = "Blue"
    If _h._RPclass = "Лучник" Then _color = "Green"
    If _h._RPclass = "Плут" Then _color = "Yellow"
    'Console.Clear()
    Console.SetCursorPosition(0, 0)
    Console.WriteLine(" ")
    _System.TxtRGB(_color, "Black", "   ╔═════════════════════════════════════════════════════════════════════╗", True)
    _System.TxtRGB("White", "Black", "     " & _h._name, False)
    _System.TxtRGB(_color, "Black", "  |  ", False)
    _System.TxtRGB("White", "Black", "Уровень: " & _h._lvl, False)
    _System.TxtRGB(_color, "Black", "  |  ", False)
    _System.TxtRGB("White", "Black", "Класс: " & _h._RPclass, False)
    _System.TxtRGB(_color, "Black", "  |  ", False)
    _System.TxtRGB("White", "Black", "Раса: " & _h._RPrace, False)
    If _moneyVis = 1 Then
      If _money > 0 Then
        _System.TxtRGB(_color, "Black", "  |  ", False)
        _System.TxtRGB("Yellow", "Black", "монет: " & _money, True)
      End If
    ElseIf _moneyVis = 0 Then
      Console.WriteLine(" ")
    End If
    _System.TxtRGB(_color, "Black", "   ╚═════════════════════════════════════════════════════════════════════╝", True)
    If _h._Ex = 0 And _h._lvl = 1 Then
      _System.TxtRGB("White", "Black", "            ╘══════════════════════════════╡", True)
      Console.WriteLine("                                                    ")
    Else
      Console.Write("             |Exp: " & _h._Ex)
      Exxeption(_h._Ex, _h._ExMax, "Yellow")
      Console.WriteLine("" & _h._ExMax)
      _System.Apostrof()
    End If

  End Sub

  Public Sub InfoHero()
    Console.Clear()
    Console.WriteLine(" ")
    _System.TxtRGB("White", "Black", "  Имя: " & _h._name, True)
    _System.TxtRGB("White", "Black", "  Уровень: " & _h._lvl, True)
    _System.TxtRGB("White", "Black", "  Раса: " & _h._RPrace, True)
    _System.TxtRGB("White", "Black", "  Класс: " & _h._RPclass, True)
    _System.TxtRGB("Red", "Black", "  _________________________________________________", True)
    _System.TxtRGB("White", "Black", " ║  Здоровье: " & _h._liveMax, False)
    _System.TxtRGB("White", "Black", "     Мана: " & _h._manaMax, True)
    _System.TxtRGB("Red", "Black", "  _________________________________________________", True)
    _System.TxtRGB("White", "Black", " ║  Параметры:  Общие|Классовые|Расовые|Экипировка", True)
    _System.TxtRGB("Red", "Black", "  _________________________________________________", True)
    _System.TxtRGB("White", "Black", " ║  Сила:      " & vbTab & _h._strength & vbTab & _h._strength_Class & vbTab & _h._strength_race & vbTab & _strength_Equip, True)
    _System.TxtRGB("White", "Black", " ║  Интеллект: " & vbTab & _h._intelligece & vbTab & _h._intelligece_Class & vbTab & _h._intelligece_race & vbTab & _intelligece_Equip, True)
    _System.TxtRGB("White", "Black", " ║  Защита:    " & vbTab & _h._defense & vbTab & _h._defense_Class & vbTab & _h._defense_race & vbTab & _defense_Equip, True)
    _System.TxtRGB("White", "Black", " ║  Ловкость:  " & vbTab & _h._agility & vbTab & _h._agility_Class & vbTab & _h._agility_race & vbTab & _agility_Equip, True)
    _System.TxtRGB("White", "Black", " ║  Точность:  " & vbTab & _h._accuracy & vbTab & _h._accuracy_Class & vbTab & _h._accuracy_race & vbTab & _accuracy_Equip, True)
    _System.TxtRGB("Red", "Black", "  _________________________________________________", True)
    _System.TxtRGB("White", "Black", " ║  " & _skl(0)._RPability & ": " & _skl(0)._damage & If(_PerksStatLvl(0) > 0, " +" & _PerksStatLvl(0), " "), True)
    _System.TxtRGB("White", "Black", " ║    └Критический удар: " & _skl(0)._crit & If(_PerksStatLvl(0) > 0, " +" & _PerksStatLvl(0) * 1.5 & "                         ", "                        "), True)
    If _skils(2) > 0 Then _System.TxtRGB("White", "Black", " ║  " & _skl(1)._RPability & ": " & _skl(1)._damage & If(_PerksStatLvl(1) > 0, " +" & _PerksStatLvl(1), " "), True)
    If _skils(2) > 0 Then _System.TxtRGB("White", "Black", " ║    └Критический удар: " & _skl(1)._crit & If(_PerksStatLvl(1) > 0, " +" & _PerksStatLvl(1) * 1.5 & "                         ", "                        "), True)
    If _skils(3) > 0 Then _System.TxtRGB("White", "Black", " ║  " & _skl(2)._RPability & ": " & _skl(2)._damage & If(_PerksStatLvl(2) > 0, " +" & _PerksStatLvl(2), " "), True)
    If _skils(3) > 0 Then _System.TxtRGB("White", "Black", " ║    └Критический удар: " & _skl(2)._crit & If(_PerksStatLvl(2) > 0, " +" & _PerksStatLvl(2) * 1.5 & "                         ", "                        "), True)
    If _skils(4) > 0 Then _System.TxtRGB("White", "Black", " ║  " & _skl(3)._RPability & ": " & _skl(3)._damage & If(_PerksStatLvl(3) > 0, " +" & _PerksStatLvl(3), " "), True)
    If _skils(4) > 0 Then _System.TxtRGB("White", "Black", " ║    └Критический удар: " & _skl(3)._crit & If(_PerksStatLvl(3) > 0, " +" & _PerksStatLvl(3) * 1.5 & "                         ", "                        "), True)

    Console.WriteLine(" ")
  End Sub

  Public Sub Vfight(ByVal _pos As Integer)
    Select Case _pos
      Case 1 'Обычный урон
        InfoBar(0)
        Console.WriteLine(" ")
        Console.Write("  " & _enemy._enemyName & "   [" & _enemy._enemyLiveMax & "]")
        Exxeption(_enemy._enemylive, _enemy._enemyLiveMax, "Green")
        Console.WriteLine("[" & _enemy._enemylive & "] -" & _skl(0)._damage & "                                    ")
        Console.WriteLine("  ========================")
        Console.Write("  " & _h._name & "   [" & _h._liveMax & "]")
        Exxeption(_h._live, _h._liveMax, "Red")
        Console.WriteLine("[" & _h._live & "] -" & _enemy._unDamage & "                                ")
        Console.WriteLine(" ")
      Case 2 'Критический урон
        InfoBar(0)
        Console.WriteLine(" ")
        Console.Write("  " & _enemy._enemyName & "   [" & _enemy._enemyLiveMax & "]")
        Exxeption(_enemy._enemylive, _enemy._enemyLiveMax, "Green")
        Console.WriteLine("[" & _enemy._enemylive & "]  Крит -" & _skl(0)._crit & "                                  ")
        Console.WriteLine("  ========================")
        Console.Write("  " & _h._name & "   [" & _h._liveMax & "]")
        Exxeption(_h._live, _h._liveMax, "Red")
        Console.WriteLine("[" & _h._live & "] -" & _enemy._unDamage & "                                   ")
        Console.WriteLine(" ")
      Case 3 'Полученный урон
        InfoBar(0)
        Console.WriteLine(" ")
        Console.Write("  " & _enemy._enemyName & "   [" & _enemy._enemyLiveMax & "]")
        Exxeption(_enemy._enemylive, _enemy._enemyLiveMax, "Green")
        Console.WriteLine("[" & _enemy._enemylive & "]" & "                                     ")
        Console.WriteLine("  ========================")
        Console.Write("  " & _h._name & "   [" & _h._liveMax & "]")
        Exxeption(_h._live, _h._liveMax, "Red")
        Console.WriteLine("[" & _h._live & "] -" & _enemy._unDamage & "                                             ")
        Console.WriteLine(" ")
      Case 4 'Вывод без урона
        InfoBar(0)
        Console.WriteLine(" ")
        Console.Write("  " & _enemy._enemyName & "   [" & _enemy._enemyLiveMax & "]")
        Exxeption(_enemy._enemylive, _enemy._enemyLiveMax, "Green")
        Console.WriteLine("[" & _enemy._enemylive & "]" & "                                             ")
        Console.WriteLine("  ========================")
        Console.Write("  " & _h._name & "   [" & _h._liveMax & "]")
        Exxeption(_h._live, _h._liveMax, "Red")
        Console.WriteLine("[" & _h._live & "]" & "                                              ")
        Console.WriteLine(" ")
    End Select

  End Sub


  Public Sub Exxeption(ByVal _par As Single, ByVal _parMax As Single, ByVal _color As String) 'Проблемное отображение...
    Dim _sr1, _srP As Single
    _sr1 = _parMax / 100
    _srP = _par / _sr1
    _System.TxtRGB(_color, "Black", " |", False)
    '_txtRGB._txtRGB("White", "Black", "Exp: " & _Ex, False)
    If _srP <= 9 Then
      _System.TxtRGB(_color, "Black", "▒░░░░░░░░░░░░░░░░░|", False)
    ElseIf _srP > 9 And _srP <= 19 Then
      _System.TxtRGB(_color, "Black", "▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░░░░░░░░░░░░░|", False)
    ElseIf _srP > 19 And _srP <= 29 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░░░░░░░░░░░|", False)
    ElseIf _srP > 29 And _srP <= 39 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░░░░░░░░░|", False)
    ElseIf _srP > 39 And _srP <= 49 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░░░░░░░|", False)
    ElseIf _srP > 49 And _srP <= 59 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░░░░░|", False)
    ElseIf _srP > 59 And _srP <= 69 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▓▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░░░|", False)
    ElseIf _srP > 69 And _srP <= 79 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▓▓▓▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░░░|", False)
    ElseIf _srP > 79 And _srP <= 89 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒", False)
      _System.TxtRGB(_color, "Black", "░░|", False)
    ElseIf _srP > 89 And _srP <= 99.99999 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒|", False)
    ElseIf _srP = 100 Then
      _System.TxtRGB(_color, "Black", "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓|", False)

    End If
  End Sub

  Public Sub Dmg() 'Урон по начальному врагу
    _enemy._enemylive -= _skl(0)._damage
  End Sub

  Public Sub Udmg() 'Урон начального моба по персонажу
    _enemy._unDamage = _enemy._enemyDamage - ((_h._defense + _h._agility) / 5)
    _h._live -= _enemy._unDamage
  End Sub


End Class
