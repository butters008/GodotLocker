using Godot;
using System;
using System.Diagnostics;

public partial class MainMenu : Control
{


	public void Btn_PlatformerLevel_Pressed()
	{
		GetTree().ChangeSceneToFile("res://Platformer/Level/StartScreen.tscn");
	}

	public void QuitButtonPressed()
	{
		Debug.WriteLine("This is a new test");
		GD.Print("This is so much better!");
		GD.Print("Quit Button pressed");
		GetTree().Quit();
	}
}
