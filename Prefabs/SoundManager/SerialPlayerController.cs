﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialPlayerController : MonoBehaviour {

	private int n_audioSources = 10;
	private AudioSource[] audioSources;

	private int sfx_source_index = 0;

	// Use this for initialization
	void Start () {
		audioSources = new AudioSource[n_audioSources];

		for (int i = 0; i < n_audioSources; i++) {
			this.audioSources [i] = gameObject.AddComponent<AudioSource>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlaySFX(AudioClip sfx_clip) {
		AudioSource audioPlayer = this.audioSources [sfx_source_index++ % n_audioSources];
		audioPlayer.pitch = Random.value * 0.1f + 1f;
		audioPlayer.volume = 0.5f - Random.value * 0.1f;
		audioPlayer.clip = sfx_clip;
		audioPlayer.time = 0f;
		audioPlayer.Play ();
	}
}
