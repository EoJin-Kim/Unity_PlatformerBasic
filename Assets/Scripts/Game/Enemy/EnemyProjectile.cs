using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if ( collision.CompareTag("Player") )
		{
			collision.GetComponent<PlayerHP>().DecreaseHP();
		}

		Destroy(gameObject);
	}
}

