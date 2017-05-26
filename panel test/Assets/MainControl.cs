using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControl : MonoBehaviour {

	//Each Questions Gameobjects inside QuesPannel
	public GameObject[] pannelText;

	public GameObject MainScene;
	public GameObject QuesPannel;

	//Final Score Pannel
	public GameObject ScorePannel;

	private int i = 0;
	private int counter;

	//The Four Buttons
	public Button[] but;

	//This Is To Enable And Disable The Remaining buttons If One Is Selected
	public bool sel;

	public int Counter
	{
		get
		{
			return counter;
		}
		set
		{
			counter = value;
			//Disables All Other Questions And Enables ScorePannel
			if (counter == 10) 
			{
				ScorePannel.SetActive (true);
				QuesPannel.SetActive (false);
			}
			//This Will Make All The Buttons Selectable After Next Or Back Is Pressed
			sel = false;

			ButtonA();
		}
	}


	void Start () 
	{
		sel = false;
		ScorePannel.SetActive(false);
		ButtonA();
	}

	
	void Update () 
	{
		Selection ();

		//Upto The Tenth Question The Buttons And Questions Will Be Active And Buttons Will Get Its Text From Constants Script
		if (counter < 10) 
		{
			var temp = Constants.questions [Counter].Split (Constants.sepperator);
			but [0].GetComponentInChildren<Text> ().text = temp [0];
			but [1].GetComponentInChildren<Text> ().text = temp [1];
			but [2].GetComponentInChildren<Text> ().text = temp [2];
			but [3].GetComponentInChildren<Text> ().text = temp [3];

			but [0].gameObject.SetActive (true);
			but [1].gameObject.SetActive (true);
			but [2].gameObject.SetActive (true);
			but [3].gameObject.SetActive (true);
			QuesPannel.SetActive (true);
			ScorePannel.SetActive (false);
		}
			

		//Changes The Questions Based On Back() or Next()
		for (int j = 0; j <= 9; j++) 
		{
				pannelText [j].SetActive (false);
				if (j != counter) 
				{
					MainScene = pannelText [counter];
					MainScene.SetActive (true);

				}
		}


		//Dont Care About This
		if (counter == 9) 
		{
			pannelText [9].SetActive (true);
			pannelText [9].GetComponent<Text> ().text = "Tenth Question";
		}
		else if (counter < 9)
			pannelText [9].SetActive (false);

					

	}

	public void Back()
	{
		if(i>=1)
		{
			i = i - 1;
			counter = i;
			Counter = i;

			//Make The Buttons Color To Default Upon Back Or Next
			but [0].image.color = Color.white;
			but [1].image.color = Color.white;
			but [2].image.color = Color.white;
			but [3].image.color = Color.white;
		}
	}

	public void Next()
	{
		if(i<=9)
		{
			i = i + 1;
			counter = i;
			Counter = i;

			//Make The Buttons Color To Default Upon Back Or Next
			but [0].image.color = Color.white;
			but [1].image.color = Color.white;
			but [2].image.color = Color.white;
			but [3].image.color = Color.white;

		}
	
			Src ();
}

	 
	//To Set The Tag For Buttons For Each Questions To Differentiate Correct Ans From Wrong Ans
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

	//This Will Set The Remaining Buttons Uninteractable If One Is Pressed
	//Will Set All Buttons Back To interactable If Next Or Back Is Pressed
	void Selection()
	{
		if (sel == true) 
		{
			but [0].GetComponent<Button> ().enabled = false;
			but [1].GetComponent<Button> ().enabled = false;
			but [2].GetComponent<Button> ().enabled = false;
			but [3].GetComponent<Button> ().enabled = false;
		}

		if (sel == false) 
		{
			but [0].GetComponent<Button> ().enabled = true;
			but [1].GetComponent<Button> ().enabled = true;
			but [2].GetComponent<Button> ().enabled = true;
			but [3].GetComponent<Button> ().enabled = true;
		}
	}


	//Will Disable All Buttons If ScorePannel Is Active
	void Src()
	{
		if (counter == 10) 
		{
			but [0].gameObject.SetActive (false);
			but [1].gameObject.SetActive (false);
			but [2].gameObject.SetActive (false);
			but [3].gameObject.SetActive (false);
		}

	}


}
