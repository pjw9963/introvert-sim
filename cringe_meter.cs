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
	
	public int Damage(int damageTaken){
		while(!cringed){
			currentCringePoints += damageTaken;
			GD.Print("You've taken " + damageTaken + " points of damage.");
			return currentCringePoints;
			
		}
		return 0;
	}
	
	public int CurHP(){
		return currentCringePoints;
	}
		
	public bool Loss() {
			if (maxCringePoints == currentCringePoints){
				cringed = true;
				GD.Print("Youve cringed!");
				return cringed;
			}
			return cringed;
		}
}
