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
		GameParams.SavedLand = GetComponent<TextMesh>().gameObject;
		if (land != null)
		{
			MoveToLand(GameParams.SavedObjects, land);
		}
		GameParams.SavedObjects.Clear();
	}
	Vector3? curentPosition;
	/// <summary>
	/// !!!!Todo!!!! 
	/// </summary>
	/// <param name="comingObjects"></param>
	/// <param name="land"></param>
	private void MoveToLand(List<GameObject> comingObjects, ILand land)
	{
		//var curentPosition = new Vector3(0, 0, 0);
		foreach (var comeobject in comingObjects)
		{
			curentPosition = 
				(curentPosition.HasValue ?
				(Vector3)curentPosition : land.DefUnitPosition) + land.VectorToStore;

			comeobject.transform.position = (Vector3)curentPosition;
		}
		curentPosition = null;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
