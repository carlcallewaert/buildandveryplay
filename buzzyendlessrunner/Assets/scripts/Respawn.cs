using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
	

	void Restart()
	{

		Application.LoadLevel(Application.loadedLevel);

	
	}
}