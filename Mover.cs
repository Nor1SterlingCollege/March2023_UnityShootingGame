using UnityEngine;

public class Mover : MonoBehaviour
{
	public float MaxSpeed = 5f;

	void Update () 
	{
		transform.position += transform.forward * MaxSpeed * Time.deltaTime;
	}
}