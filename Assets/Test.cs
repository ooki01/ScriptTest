using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Start () {
			int[] array = { 10, 20, 30, 40, 50 };
			
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);	
			}
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
		}

	}
	// Update is called once per frame
	void Update () {

	}
}