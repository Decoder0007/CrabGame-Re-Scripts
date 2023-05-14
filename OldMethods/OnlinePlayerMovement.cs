using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
public class OnlinePlayerMovement : MonoBehaviour
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000476 RID: 1142 RVA: 0x00002082 File Offset: 0x00000282
	// (set) Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001B")]
	public PlayerManager playerManager
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2B0E10", Offset = "0x2AF810", VA = "0x1802B0E10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2B43B0", Offset = "0x2B2DB0", VA = "0x1802B43B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x32D960", Offset = "0x32C360", VA = "0x18032D960")]
	private void Start()
	{
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x32D930", Offset = "0x32C330", VA = "0x18032D930")]
	public void SetPosition(Vector3 pos)
	{
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x32D3A0", Offset = "0x32BDA0", VA = "0x18032D3A0")]
	private void IdlePosition()
	{
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x32D940", Offset = "0x32C340", VA = "0x18032D940")]
	public void SetRotation(float y, float x)
	{
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790")]
	private void Test()
	{
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x32D5B0", Offset = "0x32BFB0", VA = "0x18032D5B0")]
	public void SetAnimation(OnlinePlayerMovement.PlayerAnimation animation, bool state, float animationSpeed = 1f)
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x32D7C0", Offset = "0x32C1C0", VA = "0x18032D7C0")]
	public void SetCrouching(bool crouching)
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x32D180", Offset = "0x32BB80", VA = "0x18032D180")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x32D480", Offset = "0x32BE80", VA = "0x18032D480")]
	public bool IsGrounded()
	{
		return default(bool);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x32CF60", Offset = "0x32B960", VA = "0x18032CF60")]
	private void AnimationStateChecks()
	{
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x32D490", Offset = "0x32BE90", VA = "0x18032D490")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x32DB20", Offset = "0x32C520", VA = "0x18032DB20")]
	private void Update()
	{
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x32CCD0", Offset = "0x32B6D0", VA = "0x18032CCD0")]
	private void Animate()
	{
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000485")]
	[Address(RVA = "0x32DC10", Offset = "0x32C610", VA = "0x18032DC10")]
	public OnlinePlayerMovement()
	{
	}

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private PlayerManager <playerManager>k__BackingField;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 desiredPosition;

	// Token: 0x040003A0 RID: 928
	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 velocity;

	// Token: 0x040003A1 RID: 929
	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastPosition;

	// Token: 0x040003A2 RID: 930
	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x44")]
	private float fallSpeed;

	// Token: 0x040003A3 RID: 931
	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x48")]
	private float playerSpeed;

	// Token: 0x040003A4 RID: 932
	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rb;

	// Token: 0x040003A5 RID: 933
	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x58")]
	private float moveSpeed;

	// Token: 0x040003A6 RID: 934
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x5C")]
	private float rotationSpeed;

	// Token: 0x040003A7 RID: 935
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x60")]
	private float animationBlendSpeed;

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x68")]
	public Animator animator;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x70")]
	public Transform colliders;

	// Token: 0x040003AA RID: 938
	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x78")]
	public Transform upperBodyRotation;

	// Token: 0x040003AB RID: 939
	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 crouchScale;

	// Token: 0x040003AC RID: 940
	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 lastReceivedPosition;

	// Token: 0x040003AD RID: 941
	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 newPosition;

	// Token: 0x040003AE RID: 942
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 deltaVelocity;

	// Token: 0x040003AF RID: 943
	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 correctionDir;

	// Token: 0x040003B0 RID: 944
	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0xBC")]
	private float correctionSpeed;

	// Token: 0x040003B1 RID: 945
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0xC0")]
	private float correctionJuice;

	// Token: 0x040003B2 RID: 946
	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "HideInInspector", RVA = "0xDC390", Offset = "0xDB790")]
	public float xRot;

	// Token: 0x040003B3 RID: 947
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "HideInInspector", RVA = "0xDC390", Offset = "0xDB790")]
	public float yRot;

	// Token: 0x040003B4 RID: 948
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 playerScale;

	// Token: 0x040003B5 RID: 949
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0xD8")]
	private bool crouching;

	// Token: 0x040003B6 RID: 950
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0xE0")]
	public Transform isGroundedTransform;

	// Token: 0x040003B7 RID: 951
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0xE8")]
	public LayerMask whatIsGround;

	// Token: 0x040003B8 RID: 952
	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0xEC")]
	private bool grounded;

	// Token: 0x040003B9 RID: 953
	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0xED")]
	private bool jumping;

	// Token: 0x040003BA RID: 954
	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0xF0")]
	private float currentUpperBodyRotation;

	// Token: 0x040003BB RID: 955
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0xF8")]
	public Transform itemOrbit;

	// Token: 0x040003BC RID: 956
	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x100")]
	private float xDir;

	// Token: 0x040003BD RID: 957
	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x104")]
	private float yDir;

	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public enum PlayerAnimation
	{
		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		Crouch,
		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		Melee
	}
}
