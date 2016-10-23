using UnityEngine;
using System.Collections;

public class skybox : MonoBehaviour {

	public Material sky1;

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = sky1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
