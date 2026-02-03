Imports System.Collections.Generic
Public Class frmBlackJack
    Private deck As New List(Of String)
    Private playerHand As New List(Of String)
    Private dealerHand As New List(Of String)
    Private rng As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Imposta il bordo fisso
        InitializeDeck()
        ShuffleDeck()
        DealInitialCards()
        lblMessage.Visible = False
    End Sub

    Private Sub InitializeDeck()
        Dim suits() As String = {"H", "D", "C", "S"}
        Dim values() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"}

        deck.Clear()
        For Each suit In suits
            For Each value In values
                deck.Add(value & suit)
            Next
        Next
    End Sub

    Private Sub ShuffleDeck()
        'versione vecchia
        'Dim rnd As New Random()
        'deck = deck.OrderBy(Function(card) rnd.Next()).ToList()
        '''''''''''''''''''''''23012025
        For i As Integer = deck.Count - 1 To 1 Step -1
            Dim j As Integer = rng.Next(i + 1)
            Dim temp = deck(i)
            deck(i) = deck(j)
            deck(j) = temp

        Next
    End Sub

    Private Sub DealInitialCards()
        '' Deal two cards to player and dealer
        'playerHand.Add(DrawCard())
        'playerHand.Add(DrawCard())
        'dealerHand.Add(DrawCard())
        'dealerHand.Add(DrawCard())

        'UpdateUI()
        'versione aggiornata 23012025
        playerHand.Add(DrawCard)
        playerHand.Add(DrawCard)
        dealerHand.Add(DrawCard)
        dealerHand.Add(DrawCard)

        UpdateUI()

        Dim p = CalculateScore(playerHand)
        Dim d = CalculateScore(dealerHand)

        If p = 21 Or d = 21 Then
            btnHit.Enabled = False
            btnStand.Enabled = False
            If p = 21 And d = 21 Then
                ShowMessage("Blackjack per entrambi! Pareggio!", Color.Black)
            ElseIf p = 21 Then
                ShowMessage("Blackjack! Il giocatore vince!", Color.White)
            Else
                ShowMessage("Blackjack del dealer! Vince il banco!", Color.Red)
            End If
        End If

    End Sub

    Private Function DrawCard() As String
        'controllo se il mazzo è vuoto
        If deck.Count = 0 Then
            InitializeDeck()
            ShuffleDeck()
        End If


        Dim card As String = deck(0)
        deck.RemoveAt(0)
        Return card
    End Function

    Public Sub UpdateUI()
        lstPlayerHand.Items.Clear()
        lstDealerHand.Items.Clear()

        For Each card In playerHand
            lstPlayerHand.Items.Add(card)
        Next

        For Each card In dealerHand
            lstDealerHand.Items.Add(card)
        Next

        lblPlayerScore.Text = "Player Score: " & CalculateScore(playerHand)
        lblDealerScore.Text = "Dealer Score: " & CalculateScore(dealerHand)
    End Sub

    Private Function CalculateScore(hand As List(Of String)) As Integer
        Dim score As Integer = 0
        Dim aceCount As Integer = 0

        For Each card In hand
            Dim value As String = card.Substring(0, card.Length - 1)
            Select Case value
                Case "J", "Q", "K"
                    score += 10
                Case "A"
                    aceCount += 1
                    score += 11
                Case Else
                    score += Convert.ToInt32(value)
            End Select
        Next

        While score > 21 And aceCount > 0
            score -= 10
            aceCount -= 1
        End While

        Return score
    End Function


    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        playerHand.Add(DrawCard())

        Dim score = CalculateScore(playerHand)
        Select Case score
            Case = 21
                ShowMessage("Player WIns!", Color.Black)
                btnHit.Enabled = False
                btnStand.PerformClick()
            Case > 21
                ShowMessage("Player Busts! Dealer WIns!", Color.Black)
                btnHit.Enabled = False
                btnStand.Enabled = False
        End Select


        UpdateUI()
    End Sub
    Private Async Sub btnStand_Click(sender As Object, e As EventArgs) Handles btnStand.Click
        btnHit.Enabled = False
        btnStand.Enabled = False

        While CalculateScore(dealerHand) < 17
            dealerHand.Add(DrawCard())
            UpdateUI()
            Await Task.Delay(1000) 'un secondo tra una carta e l'altra
        End While

        Dim playerScore As Integer = CalculateScore(playerHand)
        Dim dealerScore As Integer = CalculateScore(dealerHand)


        If dealerScore > 21 OrElse playerScore > dealerScore Then
            ShowMessage("Player Wins!", Color.White)
        ElseIf dealerScore > playerScore Then
            ShowMessage("Dealer Wins!", Color.Red)
        Else
            ShowMessage("It's a Tie!", Color.Black)

        End If

    End Sub
    Private Sub ResetGame()
        'reset del gioco

        playerHand.Clear()
        dealerHand.Clear()
        lblMessage.Visible = False
        lblMessage.Text = ""

        InitializeDeck()
        ShuffleDeck()
        DealInitialCards()

        btnHit.Enabled = True
        btnStand.Enabled = True
        UpdateUI()
    End Sub
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        resetGame()
    End Sub
    Private Sub ShowMessage(text As String, color As Color)
        lblMessage.Visible = True
        lblMessage.ForeColor = color
        lblMessage.Text = text
    End Sub

End Class

