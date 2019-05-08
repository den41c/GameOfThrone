using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.GameLogic.LandsProperties
{
	public interface ILand
	{
		string Name { get; }

		Vector3 DefUnitPosition { get; }

		Vector3 VectorToStore { get; }

		//List<Vector3> AttackUnitPositions { get; }
	}

	public static class LandsProvider
	{
		public static ILand Get(string name)
		{
			return kingdomsList.FirstOrDefault(w => w.Name == name);
		}

		private static List<ILand> kingdomsList = new List<ILand>()
		{
			//new KingsForest(),
			new StormsEnd(),
			new KingsLanding()
		};
	}

	//public class KingsForest : ILand
	//{
	//	public string Name { get { return "King's Forest"; } }

	//	public List<Vector3> DefUnitPositions
	//	{
	//		get
	//		{
	//			return new List<Vector3>()
	//			{
	//				new Vector3(1492.4f, 9f, 696.8f),
	//			};
	//		}
	//	}
	//}

	public class KingsLanding : ILand
	{
		public string Name { get { return "King's Landing"; } }
		public Vector3 DefUnitPosition
		{
			get
			{
				return new Vector3(1404.9f, 9f, 639.4f);
			}
		}

		public Vector3 VectorToStore { get { return new Vector3(10f, 0f, 30f); } }
	}

	public class StormsEnd : ILand
	{
		public string Name { get { return "Storm'sEnd"; } }
		public Vector3 DefUnitPosition
		{
			get
			{
				return new Vector3(1557.8f, 9f, 739.9f);
			}
		}
		public Vector3 VectorToStore { get { return new Vector3(10f, 0f, 30f); } }

	}
}
