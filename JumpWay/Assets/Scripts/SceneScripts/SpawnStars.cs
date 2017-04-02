using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour {

    public GameObject star;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
	}
	
    IEnumerator Spawn() {
        while (true) {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(
                Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
            Instantiate(star, pos, Quaternion.Euler(new Vector3(0, 0, Random.Range(0,180))));
            yield return new WaitForSeconds(5.1f);
        }
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
