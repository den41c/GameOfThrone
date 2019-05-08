using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;
using Assets.GameLogic.LandsProperties;

public class LandingScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
    }

	void OnMouseDown()
	{
		var land = LandsProvider.Get(GetComponent<TextMesh>().text);

		if (land != null)
		{
			GameParams.SavedObject.transform.position = land.UnitPosition;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
