using UnityEngine;
using System.Collections;

public class show_menu : MonoBehaviour {

	public GameObject mainMenu;
	
	public void showMenu() {
		mainMenu.SetActive (true);
	}
}
