using Godot;
using System;

public partial class MainMenu : Control
{
    public void Btn_PlatformerLevel_Pressed()
    {
        GetTree().ChangeSceneToFile("res://Platformer/Level/StartScreen.tscn");
    }

    public void QuitButtonPressed()
    {
        GetTree().Quit();
    }
}
