using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-999)]
public class PlayerInput : Singleton<PlayerInput> {

	public bool JumpIsPressed => _PlayerControls.ActionMap.Jump.IsPressed();
	public Vector2 MoveVectorWithMouse => _PlayerControls.ActionMap.RightMouseButton.IsPressed() ?
		_PlayerControls.ActionMap.MoveWithMouse.ReadValue<Vector2>() :
		_PlayerControls.ActionMap.Move.ReadValue<Vector2>();

	public Vector2 MoveVector => _PlayerControls.ActionMap.Move.ReadValue<Vector2>();

	public bool IsRightMousePressed => _PlayerControls.ActionMap.RightMouseButton.IsPressed();
	public bool IsLeftMousePressed => _PlayerControls.ActionMap.LeftMouseButton.IsPressed();
	
	// public Vector2 TapOnScreen => _PlayerControls.ActionMap.Tap
	
	public bool IsRPressed => _PlayerControls.ActionMap.R.IsPressed();
	public bool IsRWasPressedLastFrame => _PlayerControls.ActionMap.R.WasPressedThisFrame();
	
	public bool IsAction0Pressed => _PlayerControls.ActionMap.Action0.WasPressedThisFrame();
	public bool IsAction1Pressed => _PlayerControls.ActionMap.Action1.WasPressedThisFrame();
	public bool IsAction2Pressed => _PlayerControls.ActionMap.Action2.WasPressedThisFrame();
	public bool IsAction3Pressed => _PlayerControls.ActionMap.Action3.WasPressedThisFrame();

	public bool IsModeButtonPressed => _PlayerControls.ActionMap.ModeButton.WasPressedThisFrame();
	
	public TouchInput Touch
	{
		get {
			var position = _PlayerControls.ActionMap.Touch.ReadValue<Vector2>();
			var isPressed = _PlayerControls.ActionMap.TouchPressed.IsPressed();
			return new TouchInput(isPressed, position);
		}
	}

	private PlayerControls _PlayerControls;
	[SerializeField]
	private Vector2 _MoveVector;
	void Awake() {
		_PlayerControls = new PlayerControls();
	}
	void OnEnable() {
		_PlayerControls.Enable();
	}
	void OnDisable() {
		_PlayerControls.Disable();
	}

	private void Update() {
		_MoveVector = MoveVector;
	}
}
