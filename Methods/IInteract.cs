using System;
using Il2CppDummyDll;

// Token: 0x0200008D RID: 141
[Token(Token = "0x200008D")]
public interface IInteract
{
	// Token: 0x060002D0 RID: 720
	[Token(Token = "0x60002D0")]
	void TryInteract();

	// Token: 0x060002D1 RID: 721
	[Token(Token = "0x60002D1")]
	void LocalInteract();

	// Token: 0x060002D2 RID: 722
	[Token(Token = "0x60002D2")]
	void ServerInteract(ulong playerId);

	// Token: 0x060002D3 RID: 723
	[Token(Token = "0x60002D3")]
	void AllInteract(ulong playerId);

	// Token: 0x060002D4 RID: 724
	[Token(Token = "0x60002D4")]
	bool CanInteract();
}
