using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurorialTo3DModels : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FromTutorialTo3DModels()
	{
		SceneManager.LoadScene("Flyer_3D_Models");
		//Goes from Tutorial scene to  3D flyer model scene

	}

}
