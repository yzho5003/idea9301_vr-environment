using UnityEngine;
using System.Collections;

public class skybox_changer : MonoBehaviour {

	// Skybox materials should be assigned here
	public Material sky1;
	public Material sky2;
	public Material sky3;

	public GameObject mainMenu;

	// Function to update the skybox material in render settings
	public void updateSkybox(int skyNum){

		// Check if input is an integer
		if (skyNum is int) {
			Debug.Log ("Updated skybox!");

			skyNum = 1;

			// Update skybox depending on number that was input
			switch (skyNum) {
			case 1:
				RenderSettings.skybox = sky1;
				mainMenu.SetActive (false);
				break;

				case 2:
				RenderSettings.skybox = sky2;
				mainMenu.SetActive (false);
				break;

				case 3:
				RenderSettings.skybox = sky3;
				mainMenu.SetActive (false);
				break;

				default:
				Debug.Log ("Number entered is invalid!");
				break;
			}
				
		} 
		else {
			Debug.Log ("Could not update the skybox because the input is not a number!");
		}
	}
}
