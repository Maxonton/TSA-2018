using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour {

	private static string WordsEasy = { "fall", "arena", "coach", "goal", "puck", "score", "serve", 
		"strike", "tie", "track", "ball","catch","court", "pitch", "run", "throw", "golf", "base", 
		"bat", "bike", "bunt", "club", "cleat", "dart", "dive", "gear", "guard", "gym", "hoop", "jump", 
		"kick", "mat", "mit", "net", "out", "play", "polo", "pool", "race", "relay", "rink", "row", "skate", 
		"ski", "swim", "team", "tag", "tee", "tennis", "set", "rule", "field", "rugby", "surf", "rally", "dance", 
		"climb", "board", "shoot", "flip", "lift", "bar", "sail", "cricket", "box", "squash", "hit", "game", "spar", 
		"sled", "foul", "toss", "pass", "save", "hike", "curl", "event", "tour", "cars", "jock"};
	//I don't like making these pointless lists
	private static string WordsMedium = {"soccer", "gymnastics", "hockey", "referee", "athletic", "toboggan", "baseball", "basketball", 
		"archery", "bobsled", "speed skate", "dexterity", "possession", "snowboard", "slalom", "netball", "windsurf", "acrobatic", "quiver", 
		"badminton", "boomerang", "boxing", "bowling", "canoe", "competition", "cross country", "cycling", "dugout", "discus", "equestrian", 
		"fencing", "free throw", "frisbee", "handball", "home run", "kayaking", "kickball", "lacrosse", "outfield", "paintball", "pickleball", 
		"racquetball", "rollar skating", "soft ball", "water polo", "waterski", "wrestling", "football", "volleyball", "dribble", "goalkeeper", 
		"league", "offense", "defense", "opponent", "team mate", "quarterback", "player", "referee", "trainer", "barrel racing", "calisthenics", 
		"dodgeball"};
	//300 words is not happening. I hope the levels aren't to long.
	private static string WordsHard = { }; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
