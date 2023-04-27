using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
[Attribute(Name = "RequireComponent", RVA = "0x101760", Offset = "0x100B60")]
public class LinkOpener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3215E0", Offset = "0x31FFE0", VA = "0x1803215E0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3217A0", Offset = "0x3201A0", VA = "0x1803217A0")]
	public LinkOpener()
	{
	}

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x18")]
	private string CCId;

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x20")]
	private string CC0;
}
