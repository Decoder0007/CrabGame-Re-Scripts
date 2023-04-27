using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
public abstract class ItemPrefab : SharedObject, IInteract
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000325 RID: 805 RVA: 0x00002430 File Offset: 0x00000630
	// (set) Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000012")]
	public bool isPickedUp
	{
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2B3EC0", Offset = "0x2B28C0", VA = "0x1802B3EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2B43C0", Offset = "0x2B2DC0", VA = "0x1802B43C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
		set
		{
		}
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000327")]
	[Address(RVA = "0xE3F290", Offset = "0xE3DC90", VA = "0x180E3F290")]
	private new void Start()
	{
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "9")]
	protected virtual void OtherStart()
	{
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000329")]
	[Address(RVA = "0xE3F260", Offset = "0xE3DC60", VA = "0x180E3F260")]
	private void Reset()
	{
	}

	// Token: 0x0600032A RID: 810
	[Token(Token = "0x600032A")]
	public abstract void TryUse(Transform camForward);

	// Token: 0x0600032B RID: 811
	[Token(Token = "0x600032B")]
	public abstract void LocalUse(Transform cam);

	// Token: 0x0600032C RID: 812
	[Token(Token = "0x600032C")]
	public abstract void AllUse(Vector3 dir);

	// Token: 0x0600032D RID: 813
	[Token(Token = "0x600032D")]
	public abstract void OnlineUse(Vector3 dir, ulong fromClient);

	// Token: 0x0600032E RID: 814
	[Token(Token = "0x600032E")]
	public abstract void MouseUp();

	// Token: 0x0600032F RID: 815 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x236C20", Offset = "0x235620", VA = "0x180236C20", Slot = "15")]
	public virtual bool TryReload()
	{
		return default(bool);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x339F50", Offset = "0x338950", VA = "0x180339F50")]
	public void SetOwner(PlayerManager pm)
	{
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000331")]
	[Address(RVA = "0xE3F050", Offset = "0xE3DA50", VA = "0x180E3F050", Slot = "16")]
	public virtual void Equip()
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x46B0B0", Offset = "0x469AB0", VA = "0x18046B0B0")]
	private void FinishEquip()
	{
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000333")]
	[Address(RVA = "0xE3F380", Offset = "0xE3DD80", VA = "0x180E3F380", Slot = "4")]
	public void TryInteract()
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000334")]
	[Address(RVA = "0xE3F190", Offset = "0xE3DB90", VA = "0x180E3F190", Slot = "5")]
	public void LocalInteract()
	{
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x1FB790", Offset = "0x1FA190", VA = "0x1801FB790", Slot = "6")]
	public void ServerInteract(ulong playerId)
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000336")]
	[Address(RVA = "0xE3EAF0", Offset = "0xE3D4F0", VA = "0x180E3EAF0", Slot = "7")]
	public void AllInteract(ulong playerId)
	{
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x83C6D0", Offset = "0x83B0D0", VA = "0x18083C6D0", Slot = "8")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000338")]
	[Address(RVA = "0xE3EC10", Offset = "0xE3D610", VA = "0x180E3EC10")]
	private void CheckComponents()
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000339")]
	[Address(RVA = "0xE3F0D0", Offset = "0xE3DAD0", VA = "0x180E3F0D0")]
	public void InstanceData()
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033A")]
	[Address(RVA = "0xE39D20", Offset = "0xE38720", VA = "0x180E39D20")]
	protected ItemPrefab()
	{
	}

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x20")]
	public ItemData itemData;

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x28")]
	protected bool ready;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject pickupFx;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x38")]
	public Transform rightHandTarget;

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x40")]
	public Transform leftHandTarget;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDC390", Offset = "0xDB790")]
	private bool <isPickedUp>k__BackingField;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x50")]
	protected PlayerManager owner;
}
