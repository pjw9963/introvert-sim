using Godot;
using System;

public partial class root : Node2D
{
	private character extrovert;
	// Called when the node enters the scene tree for the first time.
	public async override void _Ready()
	{
		extrovert = GetNode<character>("extrovert");
		await ToSignal(GetTree().CreateTimer(5), "timeout");
		extrovert.ShowText("this is an example prompt");
		await ToSignal(GetTree().CreateTimer(5), "timeout");
		extrovert.RemoveText();
	}

}
