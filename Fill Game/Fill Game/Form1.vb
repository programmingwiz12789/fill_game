Public Class FillGame
    Dim n As Integer = 4, cellsCnt As Integer = 14, startRow As Integer = 2, startCol As Integer = 2
    Dim cells(n, n) As Button
    Dim filledCells As New Stack(Of KeyValuePair(Of Integer, Integer))
    Dim vis(n, n), gameOver As Boolean

    Private Sub FillGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To n - 1
            For j = 0 To n - 1
                Dim controlsList As Control() = Controls.Find("cell" & i & "" & j, False)
                If controlsList.Count > 0 Then
                    cells(i, j) = DirectCast(controlsList.First, Button)
                    cells(i, j).BackColor = Color.Silver
                Else
                    cells(i, j) = Nothing
                End If
                vis(i, j) = False
            Next
        Next
        cells(startRow, startCol).BackColor = Color.Magenta
        vis(startRow, startCol) = True
        filledCells.Push(New KeyValuePair(Of Integer, Integer)(startRow, startCol))
        gameOver = False
        restartBtn.Enabled = False
    End Sub

    Private Function IsValidMove(row As Integer, col As Integer, filledCells As Stack(Of KeyValuePair(Of Integer, Integer)), vis(,) As Boolean)
        If vis(row, col) Then
            Return False
        End If
        Dim currCell As KeyValuePair(Of Integer, Integer) = filledCells.Peek()
        Return (Math.Abs(row - currCell.Key) = 1 And Math.Abs(col - currCell.Value) = 0) Or (Math.Abs(row - currCell.Key) = 0 And Math.Abs(col - currCell.Value) = 1)
    End Function

    Private Sub button_Click(sender As Object, e As EventArgs) Handles cell33.Click, cell32.Click, cell31.Click, cell30.Click, cell23.Click, cell22.Click, cell20.Click, cell12.Click, cell11.Click, cell10.Click, cell03.Click, cell02.Click, cell01.Click, cell00.Click
        If Not gameOver Then
            Dim cellName As String = CType(sender, Button).Name
            Dim cellNum As Integer = CType(cellName.Substring(4), Integer)
            Dim row As Integer = cellNum \ 10, col As Integer = cellNum Mod 10
            If IsValidMove(row, col, filledCells, vis) Then
                filledCells.Push(New KeyValuePair(Of Integer, Integer)(row, col))
                vis(row, col) = True
                cells(row, col).BackColor = Color.Magenta
            ElseIf row <> startRow Or col <> startCol Then
                Dim currCell As KeyValuePair(Of Integer, Integer) = filledCells.Peek()
                If row = currCell.Key And col = currCell.Value Then
                    filledCells.Pop()
                    vis(row, col) = False
                    cells(row, col).BackColor = Color.Silver
                End If
            End If
            If filledCells.Count = cellsCnt Then
                gameOver = True
                restartBtn.Enabled = True
                MessageBox.Show("Solved!")
            End If
        End If
    End Sub

    Private Sub restartBtn_Click(sender As Object, e As EventArgs) Handles restartBtn.Click
        For i = 0 To n - 1
            For j = 0 To n - 1
                If cells(i, j) IsNot Nothing Then
                    cells(i, j).BackColor = Color.Silver
                End If
                vis(i, j) = False
            Next
        Next
        cells(startRow, startCol).BackColor = Color.Magenta
        filledCells.Clear()
        filledCells.Push(New KeyValuePair(Of Integer, Integer)(startRow, startCol))
        vis(startRow, startCol) = True
        gameOver = False
        restartBtn.Enabled = False
    End Sub
End Class