using Godot;
using System;

public partial class Node2D_extrovert : Node2D
{
	private PackedScene wordBubble = ResourceLoader.Load<PackedScene>("res://scenes/word_bubble.tscn");
	public override void _Ready()
	{
		SpawnEnemy();
	}

	private void SpawnEnemy()
	{
		if (wordBubble.Instantiate() is word_bubble wordBubbleInstance)
		{
			wordBubbleInstance.Position = new Vector2(100, 100); // Set position using the defined property
			wordBubbleInstance.LabelText = "I'm an Enemy"; // Set label text using the defined property
			AddChild(wordBubbleInstance);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
