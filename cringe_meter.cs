using Godot;
using System;

public partial class cringe_meter : Node2D
{
	[Export]
	public int currentCringePoints = 0;
	protected bool cringed = false;
	
	[Export]
	int maxCringePoints = 5;
		
	public cringe_meter(int maxCringePoints)
	{
		this.maxCringePoints = maxCringePoints;
	}
	protected int damage(int damageTaken){
			currentCringePoints += damageTaken;
			Console.WriteLine("You've taken " + damageTaken + " points of damage.");
			return currentCringePoints;
		}
		
	protected bool loss() {
			if (maxCringePoints == currentCringePoints){
				cringed = true;
				Console.WriteLine("Youve cringed!");
				return cringed;
			}
			return cringed;
		}
}
