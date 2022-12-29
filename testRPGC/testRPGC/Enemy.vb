Public Class Enemy

  Public _enemyDamage, _enemyLiveMax, _enemylive, _unDamage As Single
  Public Property _enemyName As String
  Public _hero As New Hero

  Structure _enemy
    Public _nameEnemy As String
    Public _enemyDamage, _enemyLiveMax, _enemylive, _unDamage As Single
    Public _colorF, _colorB, _colorLive As String
    Public _ExpEnemy, _moneyEnemy As Integer
  End Structure

  Structure _boss
    Public _nameBoss As String
    Public _bossDamage, _BossLive, _bossLiveMax1, _bossLiveMax2, _bossLiveMax3, _bossCrit, _bossliveStat As Single
    Public _colorFB, _colorBB, _colorLiveBB As String
    Public _ExpBoss, _moneyBoss As Integer
  End Structure

  Public _enemyGame(10, 10) As _enemy
  Public _BossGame(20) As _boss

  Public Sub _enemyStats()
    _enemyName = "Грозный Огр"
    _enemyDamage = 30
    _enemylive = 1400
    _enemyLiveMax = _enemylive
  End Sub

  Public Sub _enemyStatsGame()
    'Босс первой локации
    _BossGame(1)._nameBoss = "Голодный большой тролль [14ур]"
    _BossGame(1)._colorFB = "DarkGreen"
    _BossGame(1)._colorBB = "Black"
    _BossGame(1)._colorLiveBB = "DarkGreen"
    _BossGame(1)._bossDamage = 120
    _BossGame(1)._bossCrit = 250
    _BossGame(1)._bossLiveMax1 = 4000
    _BossGame(1)._bossLiveMax2 = 5500
    _BossGame(1)._bossLiveMax3 = 8000
    _BossGame(1)._ExpBoss = 350
    _BossGame(1)._moneyBoss = 125


    'Враги первой локации
    _enemyGame(1, 1)._nameEnemy = " Молодой огр [2ур]"
    _enemyGame(1, 2)._nameEnemy = " Пробуждённый великан [3ур] "
    _enemyGame(1, 3)._nameEnemy = " Старый тролль [2ур] "
    _enemyGame(1, 4)._nameEnemy = " Гнилистыйй энт [5ур] "
    _enemyGame(1, 5)._nameEnemy = " Снотлинг [4ур] "
    'Количество единиц жизней
    _enemyGame(1, 1)._enemyLiveMax = 1100
    _enemyGame(1, 2)._enemyLiveMax = 1000
    _enemyGame(1, 3)._enemyLiveMax = 1500
    _enemyGame(1, 4)._enemyLiveMax = 2400
    _enemyGame(1, 5)._enemyLiveMax = 750

    _enemyGame(1, 1)._enemylive = 1100
    _enemyGame(1, 2)._enemylive = 1000
    _enemyGame(1, 3)._enemylive = 1500
    _enemyGame(1, 4)._enemylive = 2400
    _enemyGame(1, 5)._enemylive = 750
    'Наносимый урон
    _enemyGame(1, 1)._unDamage = 55
    _enemyGame(1, 2)._unDamage = 70
    _enemyGame(1, 3)._unDamage = 45
    _enemyGame(1, 4)._unDamage = 50
    _enemyGame(1, 5)._unDamage = 60
    'Цветовое отображение
    _enemyGame(1, 1)._colorF = "White"
    _enemyGame(1, 2)._colorF = "Black"
    _enemyGame(1, 3)._colorF = "White"
    _enemyGame(1, 4)._colorF = "White"
    _enemyGame(1, 5)._colorF = "Yellow"

    _enemyGame(1, 1)._colorB = "Black"
    _enemyGame(1, 2)._colorB = "DarkYellow"
    _enemyGame(1, 3)._colorB = "Black"
    _enemyGame(1, 4)._colorB = "Black"
    _enemyGame(1, 5)._colorB = "DarkMagenta"

    _enemyGame(1, 1)._colorLive = "Green"
    _enemyGame(1, 2)._colorLive = "DarkYellow"
    _enemyGame(1, 3)._colorLive = "DarkGreen"
    _enemyGame(1, 4)._colorLive = "DarkGreen"
    _enemyGame(1, 5)._colorLive = "DarkMagenta"
    'Опыт и деньги за врагов
    _enemyGame(1, 1)._ExpEnemy = 15
    _enemyGame(1, 2)._ExpEnemy = 50
    _enemyGame(1, 3)._ExpEnemy = 15
    _enemyGame(1, 4)._ExpEnemy = 15
    _enemyGame(1, 5)._ExpEnemy = 20

    _enemyGame(1, 1)._moneyEnemy = 1
    _enemyGame(1, 2)._moneyEnemy = 3
    _enemyGame(1, 3)._moneyEnemy = 1
    _enemyGame(1, 4)._moneyEnemy = 1
    _enemyGame(1, 5)._moneyEnemy = 25
    '==========================================================================
    'Враги второй локации
    _enemyGame(2, 1)._nameEnemy = " Огр [4ур] "
    _enemyGame(2, 2)._nameEnemy = " Безумный варвар [8ур] "
    _enemyGame(2, 3)._nameEnemy = " Тролль [4ур] "
    _enemyGame(2, 4)._nameEnemy = " Бронированный огр [9ур] "
    _enemyGame(2, 5)._nameEnemy = " Скольский вор [6ур] "
    'Количество единиц жизней
    _enemyGame(2, 1)._enemyLiveMax = 1500
    _enemyGame(2, 2)._enemyLiveMax = 1100
    _enemyGame(2, 3)._enemyLiveMax = 1700
    _enemyGame(2, 4)._enemyLiveMax = 2800
    _enemyGame(2, 5)._enemyLiveMax = 800

    _enemyGame(1, 1)._enemylive = 1500
    _enemyGame(1, 2)._enemylive = 1100
    _enemyGame(1, 3)._enemylive = 1700
    _enemyGame(1, 4)._enemylive = 2800
    _enemyGame(1, 5)._enemylive = 800
    'Наносимый урон
    _enemyGame(2, 1)._unDamage = 60
    _enemyGame(2, 2)._unDamage = 90
    _enemyGame(2, 3)._unDamage = 50
    _enemyGame(2, 4)._unDamage = 65
    _enemyGame(2, 5)._unDamage = 65
    'Цветовое отображение
    _enemyGame(2, 1)._colorF = "White"
    _enemyGame(2, 2)._colorF = "Black"
    _enemyGame(2, 3)._colorF = "White"
    _enemyGame(2, 4)._colorF = "Black"
    _enemyGame(2, 5)._colorF = "Yellow"

    _enemyGame(2, 1)._colorB = "Black"
    _enemyGame(2, 2)._colorB = "DarkYellow"
    _enemyGame(2, 3)._colorB = "Black"
    _enemyGame(2, 4)._colorB = "DarkYellow"
    _enemyGame(2, 5)._colorB = "DarkMagenta"

    _enemyGame(2, 1)._colorLive = "Green"
    _enemyGame(2, 2)._colorLive = "DarkYellow"
    _enemyGame(2, 3)._colorLive = "DarkGreen"
    _enemyGame(2, 4)._colorLive = "DarkYellow"
    _enemyGame(2, 5)._colorLive = "DarkMagenta"
    'Опыт и деньги за врагов
    _enemyGame(2, 1)._ExpEnemy = 17
    _enemyGame(2, 2)._ExpEnemy = 60
    _enemyGame(2, 3)._ExpEnemy = 17
    _enemyGame(2, 4)._ExpEnemy = 65
    _enemyGame(2, 5)._ExpEnemy = 40

    _enemyGame(2, 1)._moneyEnemy = 2
    _enemyGame(2, 2)._moneyEnemy = 5
    _enemyGame(2, 3)._moneyEnemy = 2
    _enemyGame(2, 4)._moneyEnemy = 6
    _enemyGame(2, 5)._moneyEnemy = 40
    '==========================================================================
    'Босс первой локации
    _BossGame(3)._nameBoss = "Болотный глава разбойников [22ур]"
    _BossGame(3)._colorFB = "Red"
    _BossGame(3)._colorBB = "Black"
    _BossGame(3)._colorLiveBB = "Red"
    _BossGame(3)._bossDamage = 165
    _BossGame(3)._bossCrit = 400
    _BossGame(3)._bossLiveMax1 = 6500
    _BossGame(3)._bossLiveMax2 = 9000
    _BossGame(3)._bossLiveMax3 = 13500
    _BossGame(3)._ExpBoss = 770
    _BossGame(3)._moneyBoss = 250

    'Враги третьей локации
    _enemyGame(3, 1)._nameEnemy = " Ехидный гоблин [7ур] "
    _enemyGame(3, 2)._nameEnemy = " Хромой громила [10ур]"
    _enemyGame(3, 3)._nameEnemy = " Заросший голем [7ур] "
    _enemyGame(3, 4)._nameEnemy = " Разбойник [12ур] "
    _enemyGame(3, 5)._nameEnemy = " Скиталец [8ур] "
    'Количество единиц жизней
    _enemyGame(3, 1)._enemyLiveMax = 1700
    _enemyGame(3, 2)._enemyLiveMax = 1400
    _enemyGame(3, 3)._enemyLiveMax = 2100
    _enemyGame(3, 4)._enemyLiveMax = 3400
    _enemyGame(3, 5)._enemyLiveMax = 900

    _enemyGame(3, 1)._enemylive = 1700
    _enemyGame(3, 2)._enemylive = 1400
    _enemyGame(3, 3)._enemylive = 2100
    _enemyGame(3, 4)._enemylive = 3400
    _enemyGame(3, 5)._enemylive = 900
    'Наносимый урон
    _enemyGame(3, 1)._unDamage = 75
    _enemyGame(3, 2)._unDamage = 105
    _enemyGame(3, 3)._unDamage = 64
    _enemyGame(3, 4)._unDamage = 70
    _enemyGame(3, 5)._unDamage = 72
    'Цветовое отображение
    _enemyGame(3, 1)._colorF = "White"
    _enemyGame(3, 2)._colorF = "Black"
    _enemyGame(3, 3)._colorF = "White"
    _enemyGame(3, 4)._colorF = "Black"
    _enemyGame(3, 5)._colorF = "Yellow"

    _enemyGame(3, 1)._colorB = "Black"
    _enemyGame(3, 2)._colorB = "DarkYellow"
    _enemyGame(3, 3)._colorB = "Black"
    _enemyGame(3, 4)._colorB = "DarkYellow"
    _enemyGame(3, 5)._colorB = "DarkMagenta"

    _enemyGame(3, 1)._colorLive = "Green"
    _enemyGame(3, 2)._colorLive = "DarkYellow"
    _enemyGame(3, 3)._colorLive = "DarkGreen"
    _enemyGame(3, 4)._colorLive = "DarkYellow"
    _enemyGame(3, 5)._colorLive = "DarkMagenta"
    'Опыт и деньги за врагов
    _enemyGame(3, 1)._ExpEnemy = 19
    _enemyGame(3, 2)._ExpEnemy = 85
    _enemyGame(3, 3)._ExpEnemy = 19
    _enemyGame(3, 4)._ExpEnemy = 80
    _enemyGame(3, 5)._ExpEnemy = 65

    _enemyGame(3, 1)._moneyEnemy = 3
    _enemyGame(3, 2)._moneyEnemy = 10
    _enemyGame(3, 3)._moneyEnemy = 3
    _enemyGame(3, 4)._moneyEnemy = 8
    _enemyGame(3, 5)._moneyEnemy = 80
    '==========================================================================
    'Враги четвёртой локации
    _enemyGame(4, 1)._nameEnemy = " Лесной дух [11ур]"
    _enemyGame(4, 2)._nameEnemy = " Агрессивная дриада [14ур] "
    _enemyGame(4, 3)._nameEnemy = " Древесный паук [12ур] "
    _enemyGame(4, 4)._nameEnemy = " Лесной кентавр [15ур] "
    _enemyGame(4, 5)._nameEnemy = " Змеевик [14ур] "
    'Количество единиц жизней
    _enemyGame(4, 1)._enemyLiveMax = 2100
    _enemyGame(4, 2)._enemyLiveMax = 1700
    _enemyGame(4, 3)._enemyLiveMax = 2600
    _enemyGame(4, 4)._enemyLiveMax = 4900
    _enemyGame(4, 5)._enemyLiveMax = 1200

    _enemyGame(4, 1)._enemylive = 2100
    _enemyGame(4, 2)._enemylive = 1700
    _enemyGame(4, 3)._enemylive = 2600
    _enemyGame(4, 4)._enemylive = 4900
    _enemyGame(4, 5)._enemylive = 1200
    'Наносимый урон
    _enemyGame(4, 1)._unDamage = 90
    _enemyGame(4, 2)._unDamage = 220
    _enemyGame(4, 3)._unDamage = 78
    _enemyGame(4, 4)._unDamage = 110
    _enemyGame(4, 5)._unDamage = 78
    'Цветовое отображение
    _enemyGame(4, 1)._colorF = "White"
    _enemyGame(4, 2)._colorF = "Black"
    _enemyGame(4, 3)._colorF = "White"
    _enemyGame(4, 4)._colorF = "Black"
    _enemyGame(4, 5)._colorF = "Yellow"

    _enemyGame(4, 1)._colorB = "Black"
    _enemyGame(4, 2)._colorB = "DarkYellow"
    _enemyGame(4, 3)._colorB = "Black"
    _enemyGame(4, 4)._colorB = "DarkYellow"
    _enemyGame(4, 5)._colorB = "DarkMagenta"

    _enemyGame(4, 1)._colorLive = "Green"
    _enemyGame(4, 2)._colorLive = "DarkYellow"
    _enemyGame(4, 3)._colorLive = "DarkGreen"
    _enemyGame(4, 4)._colorLive = "DarkYellow"
    _enemyGame(4, 5)._colorLive = "DarkMagenta"
    'Опыт и деньги за врагов
    _enemyGame(4, 1)._ExpEnemy = 45
    _enemyGame(4, 2)._ExpEnemy = 135
    _enemyGame(4, 3)._ExpEnemy = 40
    _enemyGame(4, 4)._ExpEnemy = 110
    _enemyGame(4, 5)._ExpEnemy = 30

    _enemyGame(4, 1)._moneyEnemy = 17
    _enemyGame(4, 2)._moneyEnemy = 30
    _enemyGame(4, 3)._moneyEnemy = 13
    _enemyGame(4, 4)._moneyEnemy = 21
    _enemyGame(4, 5)._moneyEnemy = 115
    '==========================================================================

  End Sub

End Class
