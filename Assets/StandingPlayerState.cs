﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPlayerState : IPlayerState
{
   public void Enter(Player player)
   {
   		Debug.Log("Entered Standing");
		player.mCurrentState = this;
   }
   public void Execute(Player player)
   {
   		if (Input.GetKeyDown(KeyCode.S))
		{
			DuckingPlayerState duckingState = new DuckingPlayerState();
			duckingState.Enter(player);
			
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			JumpingPlayerState jumpingState = new JumpingPlayerState();
			jumpingState.Enter(player);
			
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			RollingPlayerState rollingState = new RollingPlayerState();
			rollingState.Enter(player);
			
		}
		
   }
}
