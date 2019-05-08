using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;

public class UnitScript : MonoBehaviour
{
	
	// Start is called before the first frame update
	void Start()
    {
        
    }

	void OnMouseDown()
	{
		GameParams.SavedObject = GetComponent<MeshFilter>().gameObject;
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
