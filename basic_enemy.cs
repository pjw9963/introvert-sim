using Godot;
using System;

public partial class basic_enemy : Node2D
{
	private cringe_meter healthbar = new cringe_meter(5);

	[Export]
	public int MaxHealth = 5;

	private int currentHealth;
	private bool isDefeated = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Initialize the healthbar
		healthbar = new cringe_meter(MaxHealth);
		currentHealth = MaxHealth;

		// Add the healthbar as a child node
		AddChild(healthbar);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (isDefeated)
			return;
			
		// Update the current health based on the cringe_meter's value
		currentHealth = healthbar.currentCringePoints;

		// Simulate taking 1 point of damage per frame
		healthbar.Damage(1);

		// Check if the enemy is defeated
		if (healthbar.Loss())
		{
			// Do something when the enemy is defeated
			GD.Print("Enemy defeated!");
			
			// Set the flag to true to indicate that the unit is defeated
			isDefeated = true;
		}
	}
}
