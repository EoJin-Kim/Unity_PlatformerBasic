using UnityEngine;

public class ItemCoinEffect : MonoBehaviour
{
	public void OnDisappear()
	{
		Destroy(gameObject);
	}
}

