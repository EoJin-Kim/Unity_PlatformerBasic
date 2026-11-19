using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class UILevel : MonoBehaviour, IPointerClickHandler
{
	[SerializeField]
	private	Sprite			spriteLevelLock;			// 레벨이 잠겨있을 때 이미지
	[SerializeField]
	private	Sprite			spriteStarFill;				// 별이 채워져있을 때 이미지
	[SerializeField]
	private	Image			imageLevelIcon;				// 레벨 이미지 설정
	[SerializeField]
	private	TextMeshProUGUI	textLevel;					// 레벨 숫자 설정 (1, 2, 3, ...)
	[SerializeField]
	private	GameObject		starBackgroundObject;
	[SerializeField]
	private	Image[]			imageStars;					// 별 이미지 설정

	private	int				level;
	private	bool			isUnlock;
	private	Image			imageFadeScreen;

	public void SetLevel(int level, bool isUnlock, bool[] stars, Image imageFadeScreen)
	{
		this.level				= level;
		this.isUnlock			= isUnlock;
		this.imageFadeScreen	= imageFadeScreen;

		if ( isUnlock == true )
		{
			textLevel.enabled	= true;
			textLevel.text		= level.ToString();

			for ( int i = 0; i < imageStars.Length; ++ i )
			{
				if ( stars[i] == true ) imageStars[i].sprite = spriteStarFill;
			}
		}
		else
		{
			textLevel.enabled		= false;
			imageLevelIcon.sprite	= spriteLevelLock;

			starBackgroundObject.SetActive(false);
		}
	}

	public void OnPointerClick(PointerEventData data)
	{
		if ( isUnlock == true )
		{
			imageFadeScreen.gameObject.SetActive(true);
			StartCoroutine(FadeEffect.Fade(imageFadeScreen, 0, 1, 1, AfterFadeEffect));
		}
	}

	private void AfterFadeEffect()
	{
		PlayerPrefs.SetInt(Constants.CurrentLevel, level);
		Utils.LoadScene(SceneNames.Game);
	}
}

