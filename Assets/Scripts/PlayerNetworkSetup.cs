﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerNetworkSetup : NetworkBehaviour {
	[SerializeField] Camera FPSCharacterCam;
	[SerializeField] AudioListener AudioListener;

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GameObject.Find ("Main Camera").SetActive(false);
			GetComponent<CharacterController> ().enabled = true;
			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
			FPSCharacterCam.enabled = true;
			AudioListener.enabled = true;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
