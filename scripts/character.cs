using Godot;
using System;

public partial class character : Node2D
{
	private word_bubble _currentWords;
	private ProgressBar healthBar;
	private PackedScene wordBubble = ResourceLoader.Load<PackedScene>("res://scenes/word_bubble.tscn");

	public override void _Ready()
	{
		healthBar = GetNode<ProgressBar>("ProgressBar_social_battery");
	}

	public void ShowText(string text)
	{
		if (wordBubble.Instantiate() is word_bubble wordBubbleInstance)
		{
			_currentWords = wordBubbleInstance;
			_currentWords.Position = new Vector2(100, 100); // Set position using the defined property
			_currentWords.LabelText = text; // Set label text using the defined property
			AddChild(_currentWords);
		}
	}

	public void RemoveText()
	{
		_currentWords?.QueueFree();
	}
	
	public void TakeDamage(int damage)
	{
		healthBar.Value -= damage;
	}

}
