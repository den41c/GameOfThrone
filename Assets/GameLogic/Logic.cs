using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic
{
	public interface Unit
	{
		string Fraction { get; set; }

	}

	public static class GameParams
	{
		public static List<GameObject> SavedObjects;
		static GameParams()
		{
			SavedObjects = new List<GameObject>();
		}
	}

	public class Logic : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}

