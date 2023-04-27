using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
public class DetectItems : MonoBehaviour
{
	// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x314CF0", Offset = "0x3136F0", VA = "0x180314CF0")]
	private void Awake()
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x314D40", Offset = "0x313740", VA = "0x180314D40")]
	private void CheckForItems()
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x315200", Offset = "0x313C00", VA = "0x180315200")]
	private void CheckHighlight(GameObject item)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x315320", Offset = "0x313D20", VA = "0x180315320")]
	private void RemoveHighlight()
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x314C70", Offset = "0x313670", VA = "0x180314C70")]
	private void AddHighlight(GameObject item)
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x2AD190", Offset = "0x2ABB90", VA = "0x1802AD190")]
	public DetectItems()
	{
	}

	// Token: 0x04000492 RID: 1170
	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask whatIsItems;

	// Token: 0x04000493 RID: 1171
	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x20")]
	public Transform cam;

	// Token: 0x04000494 RID: 1172
	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x28")]
	public GameObject currentlyHighlighted;

	// Token: 0x04000495 RID: 1173
	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x30")]
	public Material outlineMat;
}
