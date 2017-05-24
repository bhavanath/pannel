using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRef : MonoBehaviour {

	public MainControl mc;
	public Button b;
	public float delay;

	private bool isclicked;

	void Start () 
	{
		
	}

	void Update()
	{
		
	}

	public void ButtonClk()
	{
		
		if ( gameObject.tag == "green")
			{
			b.image.color = Color.green;
			if (!isclicked) 
			{
				isclicked = true;
				StartCoroutine (Delay (delay));
			}

		}

		if (gameObject.tag == "red") 
		{
			b.image.color = Color.red;
		}

	}

	private IEnumerator Delay(float delay)
	{
		yield return new WaitForSeconds (delay);
		mc.sel = true;
		isclicked = false;
	}
}
