# Rock-Paper-Scissors

## Description:

This game is made on C# with Windows Forms on .Net Framework.

## Game:

![image](https://github.com/user-attachments/assets/b7f8736d-8653-4805-bc1d-fbf4412413c1)

## Game Functions:

### Make Choice (buttonEvent):

```
Button tempButton = sender as Button;
playerChoice = (string)tempButton.Tag;
int i = random.Next(0, Options.Length);
computerChoice = Options[i];
lblPlayerchoice.Text = "Player is: " + UpdateTextandImage(playerChoice, PLAYER_PIC);
lblCPUchoice.Text = "Computer is: " + UpdateTextandImage(computerChoice, CPU_PIC);
CheckGame();
```

Button saves player's choice and gives a random choice to CPU. 

### Update Text and Image:

```
string word = null;
switch (text)
{
    case "R":
        word = "Rock";
        pic.Image = Properties.Resources.ROCK;
        break;
    case "P":
        word = "Paper";
        pic.Image = Properties.Resources.PAPER;
        break;
    case "S":
        word = "Scissors";
        pic.Image = Properties.Resources.SCISSORS;
        break;
}
return word;
```

Based on the made choices, game updates pictureBox and Result labels.

### Check Game:

```
if (computerChoice == playerChoice)
{
    draw = " Draw!";
}
else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
{
    computerScore++;
    draw = null;
}
else
{
    playerScore++;
    draw = null;
}
lblCPUresult.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
lblPlayerresult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
```

Game function checks who's won - CPU or Player.
