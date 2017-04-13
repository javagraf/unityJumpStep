using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameArragement : MonoBehaviour {

    public GameObject[] threeCubesUp;
    public GameObject buttons, cubes, spawn_blocks;
    public Animation mCube, sCube;
    public Text txt, gameName;
    public Light dir_light;
    public Light dir_light_2;

    private bool clicked;

    private void Update() {
        if (clicked && dir_light.intensity != 0) {
            dir_light.intensity -= 0.25f;
        }
       
    }

    void OnMouseDown() {
        if (!clicked) {
            clicked = true; //work only ones
            StartCoroutine(deleteCubes());
            StartCoroutine(stickCube());

        txt.gameObject.SetActive(false);
        gameName.text = "0";

        buttons.GetComponent<ScrollObjects>().speed = -5f;
        buttons.GetComponent<ScrollObjects>().checkPos = -100;
        mCube.Play("startCube");
        cubes.GetComponent<Animation>().Play("rotationCubes");
       
        
        }
    }

    IEnumerator deleteCubes() {
        for (int i = 0; i < 3; i++) {
            Destroy(threeCubesUp[i]);
            yield return new WaitForSeconds(0.5f);
        }
        spawn_blocks.GetComponent<SpawnBlocks>().enabled = true;
    }

    IEnumerator stickCube() {
        
        yield return new WaitForSeconds(mCube.clip.length - 1f);
        sCube.Play();
    }
}
