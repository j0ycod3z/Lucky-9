Imports System.Net.Security
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
    Dim deck() As String = {"Ace of Diamond", "2 of Diamond", "3 of Diamond", "4 of Diamond", "5 of Diamond", "6 of Diamond", "7 of Diamond", "8 of Diamond", "9 of Diamond", "10 of Diamond", "Jack of Diamond", "Queen of Diamond", "King of Diamond",
                                 "Ace of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
                                 "Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades",
                                 "Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts"}

    Dim deck2() As String = {"Ace of Diamond", "2 of Diamond", "3 of Diamond", "4 of Diamond", "5 of Diamond", "6 of Diamond", "7 of Diamond", "8 of Diamond", "9 of Diamond", "10 of Diamond", "Jack of Diamond", "Queen of Diamond", "King of Diamond",
                                 "Ace of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
                                 "Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades",
                                 "Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts"}

    Dim cards() As Image = {My.Resources.diamonds_ACE, My.Resources.diamonds_2, My.Resources.diamonds_3, My.Resources.diamonds_4, My.Resources.diamonds_5, My.Resources.diamonds_6, My.Resources.diamonds_7, My.Resources.diamonds_8, My.Resources.diamonds_9, My.Resources.diamonds_10, My.Resources.diamonds_Jack, My.Resources.diamonds_Queen, My.Resources.diamonds_King,
                            My.Resources.clubs_ACE, My.Resources.clubs_2, My.Resources.clubs_3, My.Resources.clubs_4, My.Resources.clubs_5, My.Resources.clubs_6, My.Resources.clubs_7, My.Resources.clubs_8, My.Resources.clubs_9, My.Resources.clubs_10, My.Resources.clubs_Jack, My.Resources.clubs_Queen, My.Resources.clubs_King,
                            My.Resources.spades_ACE, My.Resources.spades_2, My.Resources.spades_3, My.Resources.spades_4, My.Resources.spades_5, My.Resources.spades_6, My.Resources.spades_7, My.Resources.spades_8, My.Resources.spades_9, My.Resources.spades_10, My.Resources.spades_Jack, My.Resources.spades_Queen, My.Resources.spades_King,
                            My.Resources.hearts_ACE, My.Resources.hearts_2, My.Resources.spades_3, My.Resources.hearts_4, My.Resources.hearts_5, My.Resources.hearts_6, My.Resources.hearts_7, My.Resources.hearts_8, My.Resources.hearts_9, My.Resources.hearts_10, My.Resources.hearts_Jack, My.Resources.hearts_Queem, My.Resources.hearts_King}

    Dim score() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0,
                              1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0,
                              1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0,
                              1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0}

    Dim no1 As Integer
    Dim no2 As Integer
    Dim no3 As Integer
    Dim no4 As Integer
    Dim no5 As Integer
    Dim no6 As Integer

    Dim counter As Integer = 0
    Dim counter1 As Integer = 0

    Dim no7 As Integer = 9
    Dim no8 As Integer = 9
    Dim no9 As Integer = 9

    Dim booool As Integer = 0
    Dim deal As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Visible = False
        Label6.Visible = False
        ListBox1.Visible = False
        ListBox2.Visible = False
    End Sub


    Private rand As New Random()
    Private usedNumbers As New HashSet(Of Integer)()

    Private Function GetUniqueRandomNumber() As Integer
        Dim num As Integer
        Do
            num = rand.Next(1, 52)
        Loop While usedNumbers.Contains(num)
        usedNumbers.Add(num)
        Return num
    End Function

    Dim arr() As String = {}
    Private Sub play()

        no1 = +GetUniqueRandomNumber()
        no2 = +GetUniqueRandomNumber()
        no3 = +GetUniqueRandomNumber()
        no4 = +GetUniqueRandomNumber()
        no5 = +GetUniqueRandomNumber()
        no6 = +GetUniqueRandomNumber()

        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no1))
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no2))
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no3))
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no4))
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no5))
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no6))


        PictureBox4.Image = cards(no3)
        PictureBox5.Image = cards(no4)


        Button1.Text = "DRAW"
        counter += 1
    End Sub

    Private Sub drawz()

        no7 = +GetUniqueRandomNumber()

        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = (deck(no7))
        PictureBox6.Image = cards(no7)
        Button1.Text = "PLAY"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If counter >= 6 Then
            reeseet()
        End If


        If booool = 1 Then
            drawz()
            booool = 0
        ElseIf booool = 0 Then

            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing


            PictureBox6.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox9.Image = Nothing
            play()
            booool = 1
            deal -= 1
        End If


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label4.Visible = True
        Label6.Visible = True
        ListBox1.Visible = True
        ListBox2.Visible = True

        decksfflr()
    End Sub


    Private Sub decksfflr()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim count As Integer = 0

        For a = 0 To arr.Length - 1
            ListBox1.Items.Add(arr(a))
        Next

        For Each card As String In arr
            ' Find the index of the card in the deck array
            Dim index As Integer = Array.IndexOf(deck2, card)

            ' If the card is found in the deck array, remove it
            If index >= 0 Then
                Dim tempDeck(deck2.Length - 2) As String
                Array.Copy(deck2, 0, tempDeck, 0, index)
                Array.Copy(deck2, index + 1, tempDeck, index, deck2.Length - index - 1)
                deck2 = tempDeck
            End If
        Next

        For a = 0 To deck2.Length - 1
            ListBox2.Items.Add(deck2(a))
        Next

    End Sub


    Dim Ai1 As Integer
    Dim Ai2 As Integer
    Dim Human As Integer

    Dim wi1 As Integer = 1
    Dim wi2 As Integer = 1
    Dim wi3 As Integer = 1

    Dim l1 As Integer = 1
    Dim l2 As Integer = 1
    Dim l3 As Integer = 1

    Private Sub skorz()

        Human = score(no3) + score(no4) + score(no7)
        Ai1 = score(no1) + score(no2) + score(no8)
        Ai2 = score(no5) + score(no6) + score(no9)

        If Human > 9 And Human < 20 Then
            Human = Human - 10
        End If
        If Ai1 > 9 And Ai1 < 20 Then
            Ai1 = Ai1 - 10
        End If
        If Ai2 > 9 And Ai2 < 20 Then
            Ai2 = Ai2 - 10
        End If

        If Human > 19 Then
            Human = Human - 20
        End If
        If Ai1 > 19 Then
            Ai1 = Ai1 - 20
        End If
        If Ai2 > 19 Then
            Ai2 = Ai2 - 20
        End If

    End Sub

    Private Sub Aidecide()

        PictureBox1.Image = cards(no1)
        PictureBox2.Image = cards(no2)
        PictureBox7.Image = cards(no5)
        PictureBox8.Image = cards(no6)

        If Ai1 <= 5 Then
            no8 = +GetUniqueRandomNumber()

            Array.Resize(arr, arr.Length + 1)
            arr(arr.Length - 1) = (deck(no8))
            PictureBox3.Image = cards(no8)


            Ai1 = score(no1) + score(no2) + score(no8)

            If Ai1 > 9 And Ai1 <= 19 Then
                Ai1 = Ai1 - 10
            End If
            If Ai1 > 19 Then
                Ai1 = Ai1 - 20
            End If


        End If
        If Ai2 <= 5 Then
            no9 = +GetUniqueRandomNumber()

            Array.Resize(arr, arr.Length + 1)
            arr(arr.Length - 1) = (deck(no9))
            PictureBox9.Image = cards(no9)
            Ai2 = score(no5) + score(no6) + score(no9)

            If Ai2 > 9 And Ai2 <= 19 Then
                Ai2 = Ai2 - 10
            End If
            If Ai2 > 19 Then
                Ai2 = Ai2 - 20
            End If

        End If

    End Sub


    Private Sub winzzz()

        score1.Text = "Score: " + Ai1.ToString
        score2.Text = "Score: " + Human.ToString
        score3.Text = "Score: " + Ai2.ToString

        ' Calculate the absolute difference between each number and 9
        Dim diff1 As Integer = Math.Abs(Human - 9)
        Dim diff2 As Integer = Math.Abs(Ai1 - 9)
        Dim diff3 As Integer = Math.Abs(Ai2 - 9)

        ' Find the minimum difference
        Dim minDiff As Integer = Math.Min(diff1, Math.Min(diff2, diff3))

        ' Determine which number has the minimum difference and assign it to closest
        If minDiff = diff1 Then
            win2.Text = "Win: " + wi2.ToString
            wi2 += 1
            Lose1.Text = "Lose: " + l1.ToString
            lose3.Text = "Lose: " + l3.ToString
            l1 += 1
            l3 += 1


        ElseIf minDiff = diff2 Then
            win1.Text = "Win: " + wi1.ToString
            wi1 += 1

            lose2.Text = "Lose: " + l2.ToString
            lose3.Text = "Lose: " + l3.ToString
            l2 += 1
            l3 += 1

        Else
            win3.Text = "Win: " + wi3.ToString
            wi3 += 1
            Lose1.Text = "Lose: " + l1.ToString
            lose2.Text = "Lose: " + l2.ToString
            l1 += 1
            l2 += 1

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        decksfflr()
        If counter1 >= 12 Then
            reeseet()
        End If
        booool = 0
        Button1.Text = "PLAY"

        If deal = 0 Then
            skorz()
            Aidecide()
            winzzz()
            deal += 1

            Human = 0
            Ai1 = 0
            Ai2 = 0
            no7 = 9
            no8 = 9
            no9 = 9
            counter1 += 1

        End If



    End Sub

    Private Sub reeseet()
        Application.Restart()
    End Sub

End Class
