using Godot;
using System;

public partial class PlatformerMainMenu : Node2D
{
    public void PlatformerStartGame()
    {
        GD.Print("Hello");
        GetTree().ChangeSceneToFile("res://Platformer/Level/GameDemo.tscn");
    }

    public void ExitPlatformerGame()
    {
        GetTree().ChangeSceneToFile("res://Menu/MainMenu.tscn");
    }
}
