using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scores : MonoBehaviour {

	public MainControl Mc;
	public GameObject[] bt;

	public Text Questext;
	public Text Correcttext;

	public static int QuestionsAnswered = 0;
	public static int TotalScores = 0;

	void Start () 
	{
		Questext.text="Questions Answered : "+QuestionsAnswered;
		Correcttext.text="Answered Correct : " + TotalScores;
	}

	void Update () 
	{
		quesans ();
	}
		
	void quesans()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if ((EventSystem.current.currentSelectedGameObject == bt [0] || EventSystem.current.currentSelectedGameObject == bt [1]
				|| EventSystem.current.currentSelectedGameObject == bt [2] || EventSystem.current.currentSelectedGameObject == bt [3]) && Mc.MainScene.tag=="notclicked") 
			{
				Mc.MainScene.tag = "clicked";
				QuestionsAnswered = QuestionsAnswered + 1;
				Questext.text ="Questions Answered : "+QuestionsAnswered;
				if (EventSystem.current.currentSelectedGameObject.tag == "green") 
				{
					TotalScores += 1;
					Correcttext.text = "Answered Correct : " + TotalScores;
				}
			}
		}
	}
}

