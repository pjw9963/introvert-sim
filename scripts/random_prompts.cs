using Godot;
using System;

public class random_prompts
{
	private static string[] statements = new string[]
	{
		"Hey, how's it going?",
		"Did you catch the latest weather forecast?",
		"What's new in your world?",
		"How was your weekend?",
		"Any exciting plans for the day?",
		"Have you tried any interesting food lately?",
		"Seen any good movies or shows recently?",
		"What's your favorite way to unwind after a long day?",
		"Any fun weekend activities on the horizon?",
		"How's work treating you?"
	};

	private static Random rng = new Random();

	// Generate a random prompt
	public static string RandomStarter()
	{
		int randomNum = rng.Next(0, 10);
		string randomPrompt = statements[randomNum];

		return randomPrompt;
	}
}
