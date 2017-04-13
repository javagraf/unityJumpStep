using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour {

    private SpriteRenderer star;
    public float speed;

	// Use this for initialization
	void Start () {

        star = GetComponent<SpriteRenderer>();
        Destroy(gameObject,5.0f);
        speed = 0.1f;

	}
	
	// Update is called once per frame
	void Update () {

        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));

        transform.position += transform.up * speed * Time.deltaTime;

	}
}
