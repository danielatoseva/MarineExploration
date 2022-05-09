using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolvedPuzzles : MonoBehaviour
{
    [HideInInspector]
    public static Dictionary<string, bool> solved = new Dictionary<string, bool>();
    // Use this for initialization
    void Start() {
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            solved.Add(transform.parent.GetChild(i).name, false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
