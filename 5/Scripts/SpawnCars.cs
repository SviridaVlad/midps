using UnityEngine;
using System.Collections;

public class SpawnCars : MonoBehaviour
{
	public GameObject car;
	public Transform Spawn;
	public GameObject[] Cars;


		// Use this for initialization
		void Awake()
		{
			car = Instantiate(Cars[PlayerPrefs.GetInt("c")], Spawn.position, Spawn.rotation) as GameObject;
			car.name = Cars[PlayerPrefs.GetInt("c")].name;
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
