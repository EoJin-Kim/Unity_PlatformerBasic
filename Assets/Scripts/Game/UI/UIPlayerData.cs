using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPlayerData : MonoBehaviour
{
	[Header("HP")]
	[SerializeField]
	private	Image[]			hpImages;

	[Header("COIN")]
	[SerializeField]
	private	TextMeshProUGUI	textCoin;

	[Header("PROJECTILE")]
	[SerializeField]
	private	TextMeshProUGUI	textProjectile;

	[Header("STAR")]
	[SerializeField]
	private	Image[]			starObjects;
	[SerializeField]
	private	Sprite			starFillImage;

	public void SetHP(int current)
	{
		for ( int i = 0; i < hpImages.Length; ++ i )
		{
			hpImages[i].color = i < current ? Color.white : Color.black;
		}
	}

	public void SetCoin(int coinCount)
	{
		textCoin.text = $"x {coinCount}";
	}

	public void SetProjectile(int current, int max)
	{
		textProjectile.text = $"{current}/{max}";

		if ( ((float)current / max) <= 0.3f )	textProjectile.color = Color.red;
		else									textProjectile.color = Color.white;
	}

	public void SetStar(int index)
	{
		starObjects[index].sprite = starFillImage;
	}
}

