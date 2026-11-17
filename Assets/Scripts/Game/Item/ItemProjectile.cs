using UnityEngine;

public class ItemProjectile : ItemBase
{
	[SerializeField]
	private	int	count = 1;

	public override void UpdateCollision(Transform target)
	{
		target.GetComponent<PlayerData>().CurrentProjectile += count;
	}
}

