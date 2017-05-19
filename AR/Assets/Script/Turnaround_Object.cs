using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnaround_Object : MonoBehaviour {
	public GameObject target1; //the target game object that we will orbit around
	public GameObject model_target1;
	public GameObject target2;
	public GameObject model_target2;
	public GameObject target3;
	public GameObject model_target3;
	public GameObject target4;
	public GameObject model_target4;
	public float speed;//speed of the orbiting model Object
	int time_i = 0;
	// Use this for initialization
	void Start () {
			InvokeRepeating("countTime",1f,1f);
	}
	void countTime()
	{
			time_i += 1;
	}
	// Update is called once per frame
	void Update () {
			Debug.Log(time_i);
			if(time_i > 3 && time_i < 10)
			{
				turnaround_target1_Objecr();
			}
			else if(time_i > 10 && time_i <20)
			{
				turnaround_target2_Objecr();
			}
			else if(time_i > 20 && time_i < 30)
			{
				turnaround_target3_Objecr();
			}
			else if(time_i > 30 && time_i < 40)
			{
				turnaround_target4_Objecr();
			}
			else
			{
				turnaround_target1_Objecr();
			}

	}

	void turnaround_target1_Objecr()
	{
			transform.position = model_target1.transform.position;
		 	transform.RotateAround(target1.transform.position, Vector3.down , speed * Time.deltaTime);//Turn around Object
			//model around the target
	}
	void turnaround_target2_Objecr()
	{
			transform.position = model_target2.transform.position;
			transform.RotateAround(target2.transform.position, Vector3.down, speed * Time.deltaTime);
	}
	void turnaround_target3_Objecr()
	{
		transform.position = model_target3.transform.position;
		transform.RotateAround(target3.transform.position, Vector3.down, speed * Time.deltaTime);
	}
	void turnaround_target4_Objecr()
	{
		transform.position = model_target4.transform.position;
		transform.RotateAround(target4.transform.position, Vector3.down, speed * Time.deltaTime);
	}
}
