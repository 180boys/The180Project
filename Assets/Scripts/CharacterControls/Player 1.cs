// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputPlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Player1
{
    public class @InputPlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputPlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputPlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""bf6d0d31-db2b-401a-944e-38865b6c63fc"",
            ""actions"": [
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""757614ee-b999-4237-a24b-d22c191b3e0d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5ea1ab46-b6fc-49eb-ab7e-c4a14fabb201"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""adb02f63-aa96-42a7-90ac-a4f0d46a5718"",
                    ""path"": ""<XInputController>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fc0ca4c-3a10-4747-a1a5-f5f74c17d623"",
                    ""path"": ""<XInputController>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b081b644-9950-416f-bb10-4845eb16043e"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""415d35f3-182e-4628-99b7-1c6448fe1cb1"",
                    ""path"": ""<XInputController>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player Controls
            m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
            m_PlayerControls_LeftStick = m_PlayerControls.FindAction("LeftStick", throwIfNotFound: true);
            m_PlayerControls_RightStick = m_PlayerControls.FindAction("RightStick", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player Controls
        private readonly InputActionMap m_PlayerControls;
        private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
        private readonly InputAction m_PlayerControls_LeftStick;
        private readonly InputAction m_PlayerControls_RightStick;
        public struct PlayerControlsActions
        {
            private @InputPlayerControls m_Wrapper;
            public PlayerControlsActions(@InputPlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftStick => m_Wrapper.m_PlayerControls_LeftStick;
            public InputAction @RightStick => m_Wrapper.m_PlayerControls_RightStick;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlsActions instance)
            {
                if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
                {
                    @LeftStick.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftStick;
                    @LeftStick.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftStick;
                    @LeftStick.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftStick;
                    @RightStick.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightStick;
                    @RightStick.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightStick;
                    @RightStick.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRightStick;
                }
                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @LeftStick.started += instance.OnLeftStick;
                    @LeftStick.performed += instance.OnLeftStick;
                    @LeftStick.canceled += instance.OnLeftStick;
                    @RightStick.started += instance.OnRightStick;
                    @RightStick.performed += instance.OnRightStick;
                    @RightStick.canceled += instance.OnRightStick;
                }
            }
        }
        public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
        private int m_XboxSchemeIndex = -1;
        public InputControlScheme XboxScheme
        {
            get
            {
                if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
                return asset.controlSchemes[m_XboxSchemeIndex];
            }
        }
        public interface IPlayerControlsActions
        {
            void OnLeftStick(InputAction.CallbackContext context);
            void OnRightStick(InputAction.CallbackContext context);
        }
    }
}
