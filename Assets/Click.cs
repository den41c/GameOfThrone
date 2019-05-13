using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;
using System.Linq;
using Assets.GameLogic.LandsProperties;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	void OnMouseDown()
	{
		
		

	}
	public void SetActivate1()
	{
		var objectToClone = GameParams.SavedObjects.FirstOrDefault();
		if (objectToClone != null)
		{
			Vector3 position = new Vector3(20, 0, 20);
			Quaternion rotation = new Quaternion(0, 0, 0, 0);
			//var land = ;
			GameObject obj = Instantiate(
				objectToClone, LandsProvider.Get(GameParams.SavedLand.GetComponent<TextMesh>().text).DefUnitPosition + position, rotation) as GameObject;
			//obj.veloc
		}
		
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
