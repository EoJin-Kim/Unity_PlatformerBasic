using UnityEngine;

public class MovementTransform2D : MonoBehaviour
{
	[SerializeField]
	private	float	moveSpeed = 0;
	[field:SerializeField]
	public	Vector3	MoveDirection { set; get; } = Vector3.zero;

	private void Update()
	{
		transform.position += MoveDirection * moveSpeed * Time.deltaTime;
	}
}

