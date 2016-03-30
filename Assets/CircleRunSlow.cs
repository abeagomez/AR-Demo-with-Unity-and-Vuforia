using UnityEngine;
using System.Collections;

public class CircleRunSlow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 1.5f, 0));
    }
}
