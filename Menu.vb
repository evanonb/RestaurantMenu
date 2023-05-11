Public Class Menu

    Dim EntréePrice As Decimal
    Dim SidePrice As Decimal
    Dim DrinkPrice As Decimal

    ' Initializes first button of each column checked on load
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRatatouille.Checked = True
        btnFrenchFries.Checked = True
        btnSparklingWater.Checked = True
        Price1.Visible = True
        Price4.Visible = True
        Price7.Visible = True
        EntréePrice = 8.99D
        SidePrice = 3.99D
        DrinkPrice = 1D
    End Sub

    ' Changes image with each button click
    Private Sub btnRatatouille_CheckedChanged(sender As Object, e As EventArgs) Handles btnRatatouille.CheckedChanged
        PictureBoxEntrée.Image = My.Resources.ratatouille
        Price1.Visible = True
        Price2.Visible = False
        Price3.Visible = False
        EntréePrice = 8.99D
    End Sub
    Private Sub btnCrêpes_CheckedChanged(sender As Object, e As EventArgs) Handles btnCrêpes.CheckedChanged
        PictureBoxEntrée.Image = My.Resources.crepes
        Price1.Visible = False
        Price2.Visible = True
        Price3.Visible = False
        EntréePrice = 11.99D
    End Sub
    Private Sub btnBoeufBourguignon_CheckedChanged(sender As Object, e As EventArgs) Handles btnBoeufBourguignon.CheckedChanged
        PictureBoxEntrée.Image = My.Resources.boeuf_bourguignon
        Price1.Visible = False
        Price2.Visible = False
        Price3.Visible = True
        EntréePrice = 14.99D
    End Sub
    Private Sub btnFrenchFries_CheckedChanged(sender As Object, e As EventArgs) Handles btnFrenchFries.CheckedChanged
        PictureBoxSide.Image = My.Resources.french_fries
        Price4.Visible = True
        Price5.Visible = False
        Price6.Visible = False
        SidePrice = 3.99D
    End Sub
    Private Sub btnSpinachSouffle_CheckedChanged(sender As Object, e As EventArgs) Handles btnSpinachSouffle.CheckedChanged
        PictureBoxSide.Image = My.Resources.spinach_souffle
        Price4.Visible = False
        Price5.Visible = True
        Price6.Visible = False
        SidePrice = 4.99D
    End Sub
    Private Sub btnGratinDauphinois_CheckedChanged(sender As Object, e As EventArgs) Handles btnGratinDauphinois.CheckedChanged
        PictureBoxSide.Image = My.Resources.gratin_dauphinoi
        Price4.Visible = False
        Price5.Visible = False
        Price6.Visible = True
        SidePrice = 6.99D
    End Sub
    Private Sub btnSparklingWater_CheckedChanged(sender As Object, e As EventArgs) Handles btnSparklingWater.CheckedChanged
        PictureBoxDrink.Image = My.Resources.perrier
        Price7.Visible = True
        Price8.Visible = False
        Price9.Visible = False
        DrinkPrice = 1D
    End Sub
    Private Sub btnAppleJuice_CheckedChanged(sender As Object, e As EventArgs) Handles btnAppleJuice.CheckedChanged
        PictureBoxDrink.Image = My.Resources.apple_juice
        Price7.Visible = False
        Price8.Visible = True
        Price9.Visible = False
        DrinkPrice = 2D
    End Sub
    Private Sub btnSparklingLemonade_CheckedChanged(sender As Object, e As EventArgs) Handles btnSparklingLemonade.CheckedChanged
        PictureBoxDrink.Image = My.Resources.sparkling_lemonade
        Price7.Visible = False
        Price8.Visible = False
        Price9.Visible = True
        DrinkPrice = 3.5D
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If IsNumeric(TipInput.Text) Then
            lblCalc.Text = "$ " + Convert.ToString(Math.Round((EntréePrice + SidePrice + DrinkPrice) * (1 + (Convert.ToInt32(TipInput.Text) / 100)), 2))
            lblCalc.Visible = True
        Else
            MessageBox.Show("Please enter a tip")
        End If

    End Sub
End Class
