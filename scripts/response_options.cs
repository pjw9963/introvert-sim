using Godot;
using System;

public partial class response_options : Node2D
{

	[Signal]
	public delegate void ButtonPressedEventHandler(string buttonText);

	public override void _Ready()
	{
		var button1 = GetNode<Button>("HBoxContainer/Button1");
		var button2 = GetNode<Button>("HBoxContainer/Button2");
		var button3 = GetNode<Button>("HBoxContainer/Button3");

		button1.Pressed += () => OnButtonPressed(button1.Text);
		button2.Pressed += () => OnButtonPressed(button1.Text);
		button3.Pressed += () => OnButtonPressed(button1.Text);
	}

	private void OnButtonPressed(string buttonText)
	{
		EmitSignal(nameof(ButtonPressed), buttonText);
	}

}
