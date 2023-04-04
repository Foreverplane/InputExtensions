using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-999)]
[Obsolete("For ecs systems please use in a way similar to PlayerAttackInputSystem")]
public class PlayerInput : Singleton<PlayerInput> {
	

	public Vector2 StickLeft => _PlayerControls.ActionMap.StickLeft.ReadValue<Vector2>();
	public Vector2 StickRight => _PlayerControls.ActionMap.StickRight.ReadValue<Vector2>();
	
	public bool IsTriggerLeftPressed => _PlayerControls.ActionMap.TriggerLeft.WasPressedThisFrame();
	public bool IsTriggerRightPressed => _PlayerControls.ActionMap.TriggerRight.WasPressedThisFrame();
	
	public bool IsButtonNorthPressed => _PlayerControls.ActionMap.ButtonNorth.WasPressedThisFrame();
	public bool IsButtonSouthPressed => _PlayerControls.ActionMap.ButtonSouth.WasPressedThisFrame();
	public bool IsButtonWestPressed => _PlayerControls.ActionMap.ButtonWest.WasPressedThisFrame();
	public bool IsButtonEastPressed => _PlayerControls.ActionMap.ButtonEast.WasPressedThisFrame();
	
	public bool IsDPadUpPressed => _PlayerControls.ActionMap.DPadUp.WasPressedThisFrame();
	public bool IsDPadDownPressed => _PlayerControls.ActionMap.DPadDown.WasPressedThisFrame();
	public bool IsDPadLeftPressed => _PlayerControls.ActionMap.DPadLeft.WasPressedThisFrame();
	public bool IsDPadRightPressed => _PlayerControls.ActionMap.DPadRight.WasPressedThisFrame();

	public bool IsSelectPressed => _PlayerControls.ActionMap.Select.WasPressedThisFrame();

	public InputAction ShoulderRightAction => _PlayerControls.ActionMap.ShoulderRight;


    public TouchInput Touch
	{
		get {
			var position = _PlayerControls.ActionMap.Touch.ReadValue<Vector2>();
			var isPressed = _PlayerControls.ActionMap.TouchPressed.IsPressed();
			return new TouchInput(isPressed, position);
		}
	}

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
