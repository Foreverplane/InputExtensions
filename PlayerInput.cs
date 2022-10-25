using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-999)]
public class PlayerInput : Singleton<PlayerInput> {

	public bool JumpIsPressed => _PlayerControls.ActionMap.Jump.IsPressed();
	public Vector2 MoveVector => _PlayerControls.ActionMap.RightMouseButton.IsPressed() ?
		_PlayerControls.ActionMap.MoveWithMouse.ReadValue<Vector2>() :
		_PlayerControls.ActionMap.Move.ReadValue<Vector2>();

	public bool IsRightMousePressed => _PlayerControls.ActionMap.RightMouseButton.IsPressed();
	public bool IsLeftMousePressed => _PlayerControls.ActionMap.LeftMouseButton.IsPressed();
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
