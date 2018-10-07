using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laugh : MonoBehaviour {
	public AudioClip[] Laughs;

	// Use this for initialization
	void Start () {
		this.GetComponent<AudioSource>().clip = Laughs[Random.Range(0,8)];
		this.GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.GetComponent<AudioSource>().isPlaying) {
			Destroy(this.gameObject);
		}
	}
}
