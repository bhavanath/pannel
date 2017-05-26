using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRef : MonoBehaviour {

	public MainControl mc;
	public Button b;
	public float delay;


	void Start () 
	{
		
	}

	void Update()
	{
		
	}


	//Changes The Color Of The button Based On The Tag
	public void ButtonClk()
	{
		
		if ( gameObject.tag == "green")
		{
			b.image.color = Color.green;
		}

		if (gameObject.tag == "red") 
		{
			b.image.color = Color.red;
		}
		mc.sel = true;

	}

//	private IEnumerator Delay(float delay)
//	{
//		yield return new WaitForSeconds (delay);
//		//mc.sel = true;
//		isclicked = false;
//	}
//
////	void CorrectAnswers()
////	{
////		if (isclicked) 
////		{
////			isclicked = false;
////		}
////	}
}
