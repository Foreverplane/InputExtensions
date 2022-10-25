using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-999)]
public class PlayerInputSingleton : Singleton<PlayerInputSingleton> {

	public bool JumpIsPressed => _PlayerControls.ActionMap.Jump.IsPressed();
	public Vector2 MoveVector => _PlayerControls.ActionMap.RightMouseButton.IsPressed() ? 
		_PlayerControls.ActionMap.MoveWithMouse.ReadValue<Vector2>() : 
		_PlayerControls.ActionMap.Move.ReadValue<Vector2>();

	private PlayerControls _PlayerControls;
	void Awake() {
		_PlayerControls = new PlayerControls();
	}
	void OnEnable() {
		_PlayerControls.Enable();
	}
	void OnDisable() {
		_PlayerControls.Disable();
	}
}
