using UnityEngine;

public class PlatformJumpAnimator : MonoBehaviour
{
	private	GameObject	target;
	private	float		jumpForce;

	public void Setup(GameObject target, float jumpForce)
	{
		this.target		= target;
		this.jumpForce	= jumpForce;
	}

	public void JumpAction()
	{
		target.GetComponent<MovementRigidbody2D>().JumpTo(jumpForce);
		target = null;
	}
}

