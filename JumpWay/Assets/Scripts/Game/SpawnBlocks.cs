using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

    public GameObject block;
    private GameObject blockInst;
    private Vector3 blockPos;
    private float speed = 9f;

	private void Start () {

        blockPos = new Vector3(Random.Range(0.7f, 1.7f), -Random.Range(0.6f, 3.2f), -1.5f);
        blockInst = Instantiate(block, new Vector3(5f, -6f, 0), Quaternion.identity) as GameObject;
        blockInst.transform.localScale = new Vector3 (Random.Range(1.2f, 2f), block.transform.localScale.y, block.transform.localScale.z);
	}

    private void Update() {
        if (blockInst.transform.position != blockPos) {
            blockInst.transform.position = Vector3.MoveTowards(blockInst.transform.position, blockPos, Time.deltaTime * speed);
        }
    }

}
