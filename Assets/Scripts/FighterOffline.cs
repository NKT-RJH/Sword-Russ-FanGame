using Photon.Pun;
using UnityEngine;

public class FighterOffline : Fighter
{
	//protected Direction direction = Direction.None;
	//protected Skill attackType = Skill.None;
	//public bool guard;

	//protected override void Update()
	//{
	//	base.Update();

	//	direction = Direction.None;
	//	attackType = Skill.None;

	//	//if (!Input.anyKeyDown) return;

	//	if (Input.GetKeyDown(playerKeyArray[1]))
	//	{// �̰� �����ϰ� ���Ƿ� ���� �ִϸ��̼� �Ź��� ����!
	//		direction = isPlayer1 ? Direction.Left : Direction.Right;
	//	}
	//	else if (Input.GetKey(playerKeyArray[2]))
	//	{
	//		direction = Direction.Guard;
	//		m_procession = false;
	//	}
	//	else if (Input.GetKeyDown(playerKeyArray[3]))
	//	{
	//		direction = PhotonNetwork.IsMasterClient ? Direction.Right : Direction.Left;
	//	}
	//	else if (Input.GetKeyDown(playerKeyArray[0]))
	//	{
	//		direction = Direction.Up;
	//	}

	//	if (Input.GetKeyDown(playerKeyArray[4]))
	//	{
	//		attackType = Skill.Attack;

	//		if (!isGround)
	//		{
	//			attackType = Skill.JumpAttack;
	//		}
	//	}
	//	else if (Input.GetKeyDown(playerKeyArray[5]))
	//	{
	//		attackType = Skill.ChargedAttack;

	//		if (!isGround)
	//		{
	//			attackType = Skill.JumpAttack;
	//		}
	//	}
	//	else if (Input.GetKeyDown(playerKeyArray[6]))
	//	{
	//		attackType = Skill.LethalMove;
	//	}
	//}

	//public void Attack()
	//{

	//}

	//public void ChargedAttack()
	//{

	//}

	//public void JumpAttack()
	//{

	//}

	//public void LethalMove()
	//{

	//}
}
