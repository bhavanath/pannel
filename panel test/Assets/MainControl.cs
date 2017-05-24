using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControl : MonoBehaviour {

	public GameObject[] pannelText;
	private GameObject MainScene;
	public GameObject quesLabel;
	private int i = 0;
	private int counter;

	public int Counter
	{
		get
		{
			return counter;
		}
		set
		{
			counter = value;
			sel = false;
			quesLabel.GetComponent<Text> ().text = Constants.questions [counter];
			ButtonA();
		}
	}

	private GameObject[] Answers = new GameObject[4];

	public Button[] but;
	public string[] ButtonText;

	public bool sel;
	public ButtonRef bref;

	public List<string> list;


	void Start () 
	{
		var temp = Constants.questions [0].Split (Constants.sepperator);
		Debug.Log (temp[0]);
		Debug.Log (temp[1]);
		sel = false;
	}

	
	void Update () 
	{
		Correct ();

//		for (int j = 0; j <= 9; j++) 
//		{
//				pannelText [j].SetActive (false);
//				if (j != counter) 
//				{
//					MainScene = pannelText [counter];
//					MainScene.SetActive (true);
//
//				sel = false;
//				}
//		}

//		for (int k = 0; k <= 9; k++) 
//		{
//			
//		}
//
//		if (counter == 9)
//			pannelText [9].SetActive (true);
//		else if (counter < 9)
//			pannelText [9].SetActive (false);



	}

	public void Back()
	{
		if(i>=1)
		{
			i = i - 1;
			Counter = i;
			Debug.Log (counter);
		}
	}

	public void Next()
	{
		if(i<=8 )
		{
			i = i + 1;
			Counter = i;
			but [0].image.color = Color.white;
			but [1].image.color = Color.white;
			but [2].image.color = Color.white;
			but [3].image.color = Color.white;
		Debug.Log (counter);

		}
	}

	 

	public void ButtonA()
	{


		switch (counter) 
		{
		case 0:
			but [0].tag = "red";
			but [1].tag = "red";
			but [2].tag = "green";
			but [3].tag = "red";
			break;

		case 1:
			but [0].tag = "red";
			but [1].tag = "green";
			but [2].tag = "red";
			but [3].tag = "red";
			break;
		
		case 2:
			but [0].tag = "red";
			but [1].tag = "red";
			but [2].tag = "red";
			but [3].tag = "green";

			break;
		case 3:
			but [0].tag = "green";
			but [0].GetComponentInChildren<Text> ().text = "gfjkf";
			but [1].tag = "red";
			but [2].tag = "red";
			but [3].tag = "red";
			break;
		case 4:
			but [0].tag = "red";
			but [1].tag = "red";
			but [2].tag = "green";
			but [3].tag = "red";
			break;
		case 5:
			but [0].tag = "red";
			but [1].tag = "green";
			but [2].tag = "red";
			but [3].tag = "red";
			break;
		case 6:
			but [0].tag = "green";
			but [1].tag = "red";
			but [2].tag = "red";
			but [3].tag = "red";
			break;
		case 7:
			but [0].tag = "red";
			but [1].tag = "red";
			but [2].tag = "red";
			but [3].tag = "green";
			break;
		case 8:
			but [0].tag = "red";
			but [1].tag = "green";
			but [2].tag = "red";
			but [3].tag = "red";
			break;
		case 9:
			but [0].tag = "red";
			but [1].tag = "red";
			but [2].tag = "green";
			but [3].tag = "red";
			break;
		}

	}

	void Correct()
	{
		if (sel == true) 
		{
			Next ();
		}
	}

	void TextScr()
	{
		but [0].GetComponentInChildren<Text> ().text=ButtonText[0];
		but [1].GetComponentInChildren<Text> ().text=ButtonText[1];
		but [2].GetComponentInChildren<Text> ().text=ButtonText[2];
		but [3].GetComponentInChildren<Text> ().text=ButtonText[3];
	}


}
