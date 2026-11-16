using UnityEngine;

public class ItemHPPotion : ItemBase
{
	[SerializeField]
	private	int	increaseHP = 1;

	public override void UpdateCollision(Transform target)
	{
		target.GetComponent<PlayerHP>().IncreaseHP(increaseHP);
	}
}

