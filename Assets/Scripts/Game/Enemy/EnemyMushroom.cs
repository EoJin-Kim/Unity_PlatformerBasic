using UnityEngine;

public class EnemyMushroom : EnemyBase
{
	private	FollowPath		followPath;
	private	SpriteRenderer	spriteRenderer;
	private	Animator		animator;

	private void Awake()
	{
		followPath		= GetComponent<FollowPath>();
		spriteRenderer	= GetComponentInChildren<SpriteRenderer>();
		animator		= GetComponentInChildren<Animator>();
	}

	private void Update()
	{
		spriteRenderer.flipX = followPath.Direction == 1 ? false : true;
		animator.SetFloat("moveSpeed", (int)followPath.State);
	}

	public override void OnDie()
	{
		if ( IsDie == true ) return;

		IsDie = true;

		followPath.Stop();

		float destroyTime = 2;
		StartCoroutine(FadeEffect.Fade(spriteRenderer, 1, 0, destroyTime));
		Destroy(gameObject, destroyTime);
	}
}

