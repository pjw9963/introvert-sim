using Godot;
using System;

public partial class take_damage : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		cringe_meter TestHp = new cringe_meter(2);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
