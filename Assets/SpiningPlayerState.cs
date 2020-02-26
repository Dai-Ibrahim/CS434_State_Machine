using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningPlayerState : IPlayerState
{
    // Start is called before the first frame update
      public void Enter(Player player)
   {
   		Debug.Log("Entered spining ");
		player.mCurrentState = this;
		Rigidbody rb = player.GetComponent<Rigidbody>();

		float turn = Input.GetAxis("Vertical");
        rb.AddTorque(0,120,0);
//		rbPlayer.transform.localScale *= 0.5f;
		
   }
   public void Execute(Player player)
   {
		
		if (!Input.GetKey(KeyCode.F))
		{
			//transition to standing
			StandingPlayerState standingState = new StandingPlayerState();
			standingState.Enter(player);
			Rigidbody rb = player.GetComponent<Rigidbody>();

			//float turn = Input.GetAxis("Horizontal");
			rb.AddTorque(0,0,0);
			
		}
   }
}
