using UnityEngine;

public class ItemCoin : ItemBase
{
	[SerializeField]
	private	GameObject	coinEffect;

	public override void UpdateCollision(Transform target)
	{
		Instantiate(coinEffect, transform.position, Quaternion.identity);

		target.GetComponent<PlayerData>().Coin ++;
	}
}

