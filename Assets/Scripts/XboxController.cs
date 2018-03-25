using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class XboxController : MonoBehaviour {
	public static bool zgoda = false;
	public Rigidbody rb;
	public Animator anim;
    public static bool permission = false;
	// ______ZMIENNE__________


	//Zmienna mowiaca z jaką predkoscia chcemy poruszac sie graczem
	public    int speed = 20;

	//Zmienna w ktorej przechowujemy nasz komponent Rigidbody
	Rigidbody rigidBody;




	void Start(){
		
		rigidBody = GetComponent<Rigidbody>();
	}

	//Funkcja Update() uruchamiana jest co klatke gry
	void Update ()
	{

		Vector3 inputDirection = Vector3.zero;
		
			float moveHorizontal = Input.GetAxis ("XboxHorizontal");
			
			float moveVertical = Input.GetAxis ("XboxVertical");


			
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


			rb.AddForce (movement * speed);
		if (Input.GetButton ("Abutton")) {
			Scroll.scroll = true;
			Scroll.x = 0;
			ScrollPoczatkowy.destructor = true;
			PlayerController.zgoda = true;
			Czaswgrze.STOP = false;
			MusicChange.pozwolenie = true;
			anim.Play ("MoveCameraToStart");


		}
		if (Input.GetButton ("Xbutton")){
            Scroll.x = 0;
            Scroll.scroll = true;
            Czaswgrze.STOP = true;

         
            Czaswgrze.czas = 0;
            ScoreController.count = 0;
            SceneManager.LoadScene("scena");
        }
	if(Input.GetButton ("Ybutton"))
	{
		Application.OpenURL ("http://mazeball.azurewebsites.net/ ");	
	}
        if (Input.GetButton("Bbutton")&&permission==true)
        {
            Scroll.scroll = true;

            Czaswgrze.czas = 0;
            Scroll.x = 0;
            ScrollPoczatkowy.destructor = true;
            PlayerController.zgoda = true;

            MusicChange.pozwolenie = true;
            
            
            
            
            ScrollPoczatkowy.destructor = true;
            PlayerController.zgoda = true;
            
            
            anim.Play("PlayAgain");
            permission = false;
        }

}
}
