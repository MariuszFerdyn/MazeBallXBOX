using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetOnEsc : MonoBehaviour {
	public static string email;
	public static string name;
	int firstrun;
	// Use this for initialization
	void Start ()
	{
		
		

		

	}
	
	// Update is called once per frame
	void Update() {
		
		if (Input.GetKeyDown ("escape")) {
            Scroll.x = 0;
            Scroll.scroll = true;
			Czaswgrze.STOP = true;
			email = Ustawieniemaila.email;
			name = Ustawianieimienia.imie;
			PlayerPrefs.SetString ("email", email);
			PlayerPrefs.SetString ("name", name);
			Czaswgrze.czas = 0;
			ScoreController.count = 0;
			SceneManager.LoadScene ("scena");
		

		}
		
		
}
}
