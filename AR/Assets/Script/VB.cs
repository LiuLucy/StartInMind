using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject VButton;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		VButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		}



	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ){
		score++;
		Debug.Log(score);
	}
	public void OnButtonReleased( VirtualButtonAbstractBehaviour vb )
	{
		Debug.Log("Release");
	}
}
