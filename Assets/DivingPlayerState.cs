using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingPlayerState : IPlayerState
{
    // Start is called before the first frame update
      public void Enter(Player player)
   {
   		Debug.Log("Entered diving");
		player.mCurrentState = this;
		Rigidbody rb = player.GetComponent<Rigidbody>();
		rb.AddForce(0,-400*Time.deltaTime, 0, ForceMode.VelocityChange);
//		rbPlayer.transform.localScale *= 0.5f;
		
   }
   public void Execute(Player player)
   {
   			if(Physics.Raycast(player.transform.position, Vector3.down,0.55f))
			{
				StandingPlayerState standingState = new StandingPlayerState();
				standingState.Enter(player);
			}
//		if (!Input.GetKey(KeyCode.S))
//		{
//			//transition to standing
//			DuckingPlayerState duckingState = new DuckingPlayerState();
////			Rigidbody rbPlayer = player.GetComponent<Rigidbody>();
////			rbPlayer.transform.localScale *= 2.0f;
//			duckingState.Enter(player);
//		}
   }
}
