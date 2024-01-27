using Godot;
using System;

public partial class cringe_meter : Node2D
{
	
	public class cringeMeter(int maxCringePoints = 5){
		this.maxCringePoints = maxCringePoints;
		
		[Export]
		public int currentCringePoints = 0;
		protected bool cringed = false;
		
		private int damage(int damageTaken){
			currentCringePoints += damageTaken;
			Console.WriteLine("You've taken " + damageTaken + " points of damage.");
		}
		
		private int loss() {
			if (maxCringePoints == currentCringePoints){
				cringed = true;
				Console.WriteLien("Youve cringed!");
			}
		}
	}
}
