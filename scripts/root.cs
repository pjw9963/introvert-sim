using Godot;
using System;

public partial class root : Node2D
{
	private character extrovert;
	private character introvert;
	private response_options options;
	
	// Called when the node enters the scene tree for the first time.
	public async override void _Ready()
	{
		extrovert = GetNode<character>("extrovert");
		introvert = GetNode<character>("introvert");
		options = GetNode<response_options>("response_options");
		
		await ToSignal(GetTree().CreateTimer(5), "timeout");
		extrovert.TakeDamage(5);
		extrovert.ShowText("this is an example prompt");
		await ToSignal(GetTree().CreateTimer(5), "timeout");
		extrovert.RemoveText();
	}

}
