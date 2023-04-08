using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-999)]
[Obsolete("For ecs systems please use in a way similar to PlayerAttackInputSystem")]
public class PlayerInput : Singleton<PlayerInput> {
	

	public Vector2 StickLeft => _playerControls.ActionMap.StickLeft.ReadValue<Vector2>();
	public Vector2 StickRight => _playerControls.ActionMap.StickRight.ReadValue<Vector2>();
	
	public bool IsTriggerLeftPressed => _playerControls.ActionMap.TriggerLeft.WasPressedThisFrame();
	public bool IsTriggerRightPressed => _playerControls.ActionMap.TriggerRight.WasPressedThisFrame();
	
	public bool IsButtonNorthPressed => _playerControls.ActionMap.ButtonNorth.WasPressedThisFrame();
	public bool IsButtonSouthPressed => _playerControls.ActionMap.ButtonSouth.WasPressedThisFrame();
	public bool IsButtonWestPressed => _playerControls.ActionMap.ButtonWest.WasPressedThisFrame();
	public bool IsButtonEastPressed => _playerControls.ActionMap.ButtonEast.WasPressedThisFrame();
	
	public bool IsDPadUpPressed => _playerControls.ActionMap.DPadUp.WasPressedThisFrame();
	public bool IsDPadDownPressed => _playerControls.ActionMap.DPadDown.WasPressedThisFrame();
	public bool IsDPadLeftPressed => _playerControls.ActionMap.DPadLeft.WasPressedThisFrame();
	public bool IsDPadRightPressed => _playerControls.ActionMap.DPadRight.WasPressedThisFrame();

	public bool IsSelectPressed => _playerControls.ActionMap.Select.WasPressedThisFrame();

	public InputAction ShoulderRightAction => _playerControls.ActionMap.ShoulderRight;

	public InputAction ShoulderLeftAction => _playerControls.ActionMap.ShoulderLeft;
	
	public InputAction StickRightPress => _playerControls.ActionMap.StickRightPress;

    public TouchInput Touch
	{
		get {
			var position = _playerControls.ActionMap.Touch.ReadValue<Vector2>();
			var isPressed = _playerControls.ActionMap.TouchPressed.IsPressed();
			return new TouchInput(isPressed, position);
		}
	}

	private PlayerControls _playerControls;


	void Awake() {
		_playerControls = new PlayerControls();
	}
	void OnEnable() {
		_playerControls.Enable();
	}
	void OnDisable() {
		_playerControls.Disable();
	}
	
}
