'Scan all primitive data types
Imports System

Public Class FootBoardDim
  
End Sub


Private Sub btnOperate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperate.Click

        'Declare all public variables
        Dim length As Double
        Dim width As Double
        Dim height As Double

        length = InputBox("Enter the length of the board foot (inches):")

        width = InputBox("Enter the width of the board foot (inches):")

        height = 144 / (width * length)

        'This insures that the length and width are not negative
        If length <= 0.0 OrElse width <= 0 Then


            'If the if statement is true then exit the program
            MsgBox("Invalid input! ")
            Me.Close()
        End If

        MsgBox("The final dimension is " & height & " inches.")

End Sub
End Class
