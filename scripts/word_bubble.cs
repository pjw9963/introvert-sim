using Godot;
using System;

public partial class word_bubble : Node2D
{
	public string LabelText
	{
		get => GetNode<RichTextLabel>("Sprite2D_word_bubble/RichTextLabel").Text;
		set => GetNode<RichTextLabel>("Sprite2D_word_bubble/RichTextLabel").Text = value;
	}
}
