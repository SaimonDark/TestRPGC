Imports System.Drawing

Public Class SystemColorConsole

  Public Shared Sub Apostrof()
    Console.Write("                                ")
    Console.WriteLine("                                ")
  End Sub
  Public Shared Sub WhiteFonfSys()
    Console.ForegroundColor = ConsoleColor.White
    Console.CursorVisible = False
  End Sub

  Public Shared Sub BlackFonfSys()
    Console.ForegroundColor = ConsoleColor.Black
    Console.CursorVisible = False
  End Sub

  Public Shared Sub TxtRGB(ByVal _font As String, ByVal _back As String, ByVal _txt As String, ByVal _line As Boolean)
    Select Case _font
      Case "Black"
        Console.ForegroundColor = ConsoleColor.Black
      Case "DarkBlue"
        Console.ForegroundColor = ConsoleColor.DarkBlue
      Case "DarkGreen"
        Console.ForegroundColor = ConsoleColor.DarkGreen
      Case "DarkRed"
        Console.ForegroundColor = ConsoleColor.DarkRed
      Case "DarkMagenta"
        Console.ForegroundColor = ConsoleColor.DarkMagenta 'Тёмно-фиолетовый
      Case "DarkYellow"
        Console.ForegroundColor = ConsoleColor.DarkYellow
      Case "Gray"
        Console.ForegroundColor = ConsoleColor.Gray
      Case "DarkGray"
        Console.ForegroundColor = ConsoleColor.DarkGray
      Case "Blue"
        Console.ForegroundColor = ConsoleColor.Blue
      Case "Green"
        Console.ForegroundColor = ConsoleColor.Green
      Case "Cyan"
        Console.ForegroundColor = ConsoleColor.Cyan 'Светло-голубой
      Case "Red"
        Console.ForegroundColor = ConsoleColor.Red
      Case "Magenta"
        Console.ForegroundColor = ConsoleColor.Magenta 'Фиолетовый
      Case "Yellow"
        Console.ForegroundColor = ConsoleColor.Yellow
      Case "White"
        Console.ForegroundColor = ConsoleColor.White

    End Select

    Select Case _back
      Case "Black"
        Console.BackgroundColor = ConsoleColor.Black
      Case "DarkBlue"
        Console.BackgroundColor = ConsoleColor.DarkBlue
      Case "DarkGreen"
        Console.BackgroundColor = ConsoleColor.DarkGreen
      Case "DarkRed"
        Console.BackgroundColor = ConsoleColor.DarkRed
      Case "DarkMagenta"
        Console.BackgroundColor = ConsoleColor.DarkMagenta
      Case "DarkYellow"
        Console.BackgroundColor = ConsoleColor.DarkYellow
      Case "Gray"
        Console.BackgroundColor = ConsoleColor.Gray
      Case "DarkGray"
        Console.BackgroundColor = ConsoleColor.DarkGray
      Case "Blue"
        Console.BackgroundColor = ConsoleColor.Blue
      Case "Green"
        Console.BackgroundColor = ConsoleColor.Green
      Case "Cyan"
        Console.BackgroundColor = ConsoleColor.Cyan
      Case "Red"
        Console.BackgroundColor = ConsoleColor.Red
      Case "Magenta"
        Console.BackgroundColor = ConsoleColor.Magenta
      Case "Yellow"
        Console.BackgroundColor = ConsoleColor.Yellow
      Case "White"
        Console.BackgroundColor = ConsoleColor.White

    End Select

    Select Case _line
      Case True
        Console.WriteLine(_txt)
      Case False
        Console.Write(_txt)
    End Select
    Console.ForegroundColor = ConsoleColor.White
    Console.BackgroundColor = ConsoleColor.Black
  End Sub

End Class


Public Class Interfuce
  Private ReadOnly _head As String
  Private ReadOnly _bar(5) As String
  Private ReadOnly _pole As String
  Sub New(ByVal ParamArray _b() As String)
    _pole = 5
    _head = _b(1)
    _bar(1) = _b(2)
    _bar(2) = _b(3)
    _bar(3) = _b(4)
    _bar(4) = _b(5)
    _bar(5) = _b(6)
  End Sub

  Private Sub List()
    Console.WriteLine("   _______________" & _head & "                            ")
    Console.WriteLine("  ║ 1. " & _bar(1) & "                            ")
    Dim i As Integer
    For i = 1 To _pole
      Try
        Console.WriteLine("  │ " & i & ". " & _bar(i) & "                            ")
      Catch ex As Exception

      End Try

    Next
    Console.WriteLine("  └ ")
  End Sub

  Public Sub Interf()
    List()
  End Sub
End Class