using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score  
{

	public static Dictionary<int, int> DayScores { get; set; }

	private static int _playerScore;
	private static int _bonus;
	private static bool _getBonus = true;
	public static void Add(int score) {
		_playerScore += score;
		DayScores[score]++;
	}

	public static int Total()
	{
		return _playerScore + _bonus;
	}

	public static void CalculateBonus(){
		if(_getBonus){
			foreach(var day in DayScores) {
				if(day.Key == day.Value) {
					_bonus += (day.Key * 2);
				}
			};
			_getBonus = false;
		}
	}
	public static void Reset()
	{
		_playerScore = 0;
		_bonus = 0;
		DayScores = new Dictionary<int, int>();
		for (var i = 1; i < 13; i++) {
			DayScores.Add(i,0);
		}
	}
}
