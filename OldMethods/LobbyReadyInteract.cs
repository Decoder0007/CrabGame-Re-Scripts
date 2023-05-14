using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000090 RID: 144
[Token(Token = "0x2000090")]
public class LobbyReadyInteract : SharedObject, IInteract
{
	// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x324430", Offset = "0x322E30", VA = "0x180324430")]
	private void Awake()
	{
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x324580", Offset = "0x322F80", VA = "0x180324580", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x3244C0", Offset = "0x322EC0", VA = "0x1803244C0", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x324330", Offset = "0x322D30", VA = "0x180324330", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x324330", Offset = "0x322D30", VA = "0x180324330")]
	private void PressButton(ulong pId)
	{
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x324610", Offset = "0x323010", VA = "0x180324610")]
	private void Update()
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x3244B0", Offset = "0x322EB0", VA = "0x1803244B0")]
	private void ResetReady()
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1F8250", Offset = "0x1F6C50", VA = "0x1801F8250", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x3247B0", Offset = "0x3231B0", VA = "0x1803247B0")]
	public LobbyReadyInteract()
	{
	}

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x20")]
	public Transform button;

	// Token: 0x04000287 RID: 647
	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x28")]
	public RandomSfx readySfx;

	// Token: 0x04000288 RID: 648
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x30")]
	public RandomSfx unreadySfx;

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x38")]
	private bool ready;

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 defaultScale;

	// Token: 0x0400028B RID: 651
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 desiredScale;

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 currentScale;
}
