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
		public static GameObject SavedObject;
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

