// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputPlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputPlayerControls
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
            ""name"": ""PlayerControler"",
            ""id"": ""bf6d0d31-db2b-401a-944e-38865b6c63fc"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""538c2672-da81-4aed-92f4-82ba3cc58d0e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""Value"",
                    ""id"": ""94a3e174-18fc-4823-9172-0205edd66ca0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""accept"",
                    ""type"": ""Button"",
                    ""id"": ""ed49def6-838a-4526-b13b-39e77113e3fa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""back"",
                    ""type"": ""Button"",
                    ""id"": ""6f2c9285-d601-4a04-9131-1fca8b6cfb0f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""d189e3ed-ca5c-4085-9ba8-6ea99447d120"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a3ec5a5f-bf34-475b-90d6-ff244e99b765"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""bash"",
                    ""type"": ""Button"",
                    ""id"": ""78c0316e-7632-4c4a-af49-53a81b36363b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""teleport"",
                    ""type"": ""Button"",
                    ""id"": ""7049588a-ed2c-431d-85bf-33a26da656a6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rocket"",
                    ""type"": ""Button"",
                    ""id"": ""e377c76c-685c-4540-a8e0-fac1fcb4fe4e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a3aa861d-b3db-4413-923e-b05c4ac21727"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""e9aa6843-3268-4c9a-8e4e-33154a04dc4a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""95858723-fbd9-41b7-892a-013388313cc9"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bb0a3708-abef-499d-bf14-c9c9a4f83f23"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4921e28b-b45c-468a-b02b-af1847e09ed6"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2e6b5668-d9d8-49bd-90ed-a42669b251c6"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b47d9e85-e67f-4ee0-8cae-57361cf60628"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bf37f87-efab-4f98-af28-54f91f0ad762"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2e05468-b81e-4c41-b8c7-9af4a5e726ef"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6195af2-3a7e-42b4-8b49-160af4ca2c62"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6df636c3-1d06-468c-a5da-7633624c5634"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c7c1593-ba29-4f0c-a3e9-f5403618c24b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e0ef728-c4cb-4c79-b066-a0cdc42478e6"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af5b3472-aa65-423e-bd12-2af0d64ecf49"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06254150-fe5c-4ac6-999d-c5e480f28173"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2334e8aa-a1f2-4545-854f-7d30d920f401"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8420bc9e-5abd-4ef1-8695-8a53f9abe9ca"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed55bbc8-7b53-4fa8-85d9-56ac90f6ba0e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""bash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4799be5-5ada-4da1-8996-e116031e202f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""bash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c267f268-2a93-4c52-9167-aaa1a276a368"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""242aa77c-fea3-4e99-aeab-97354aa92a0b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0a523ba-9f3b-4b8c-917c-60cf98b30282"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""rocket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b63ca2f-c655-4dcf-99a0-1afaabe3a279"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""rocket"",
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
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // PlayerControler
            m_PlayerControler = asset.FindActionMap("PlayerControler", throwIfNotFound: true);
            m_PlayerControler_move = m_PlayerControler.FindAction("move", throwIfNotFound: true);
            m_PlayerControler_look = m_PlayerControler.FindAction("look", throwIfNotFound: true);
            m_PlayerControler_accept = m_PlayerControler.FindAction("accept", throwIfNotFound: true);
            m_PlayerControler_back = m_PlayerControler.FindAction("back", throwIfNotFound: true);
            m_PlayerControler_pause = m_PlayerControler.FindAction("pause", throwIfNotFound: true);
            m_PlayerControler_shoot = m_PlayerControler.FindAction("shoot", throwIfNotFound: true);
            m_PlayerControler_bash = m_PlayerControler.FindAction("bash", throwIfNotFound: true);
            m_PlayerControler_teleport = m_PlayerControler.FindAction("teleport", throwIfNotFound: true);
            m_PlayerControler_rocket = m_PlayerControler.FindAction("rocket", throwIfNotFound: true);
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

        // PlayerControler
        private readonly InputActionMap m_PlayerControler;
        private IPlayerControlerActions m_PlayerControlerActionsCallbackInterface;
        private readonly InputAction m_PlayerControler_move;
        private readonly InputAction m_PlayerControler_look;
        private readonly InputAction m_PlayerControler_accept;
        private readonly InputAction m_PlayerControler_back;
        private readonly InputAction m_PlayerControler_pause;
        private readonly InputAction m_PlayerControler_shoot;
        private readonly InputAction m_PlayerControler_bash;
        private readonly InputAction m_PlayerControler_teleport;
        private readonly InputAction m_PlayerControler_rocket;
        public struct PlayerControlerActions
        {
            private @InputPlayerControls m_Wrapper;
            public PlayerControlerActions(@InputPlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @move => m_Wrapper.m_PlayerControler_move;
            public InputAction @look => m_Wrapper.m_PlayerControler_look;
            public InputAction @accept => m_Wrapper.m_PlayerControler_accept;
            public InputAction @back => m_Wrapper.m_PlayerControler_back;
            public InputAction @pause => m_Wrapper.m_PlayerControler_pause;
            public InputAction @shoot => m_Wrapper.m_PlayerControler_shoot;
            public InputAction @bash => m_Wrapper.m_PlayerControler_bash;
            public InputAction @teleport => m_Wrapper.m_PlayerControler_teleport;
            public InputAction @rocket => m_Wrapper.m_PlayerControler_rocket;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControler; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlerActions instance)
            {
                if (m_Wrapper.m_PlayerControlerActionsCallbackInterface != null)
                {
                    @move.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnMove;
                    @move.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnMove;
                    @move.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnMove;
                    @look.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnLook;
                    @look.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnLook;
                    @look.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnLook;
                    @accept.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnAccept;
                    @accept.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnAccept;
                    @accept.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnAccept;
                    @back.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnBack;
                    @back.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnBack;
                    @back.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnBack;
                    @pause.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnPause;
                    @pause.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnPause;
                    @pause.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnPause;
                    @shoot.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnShoot;
                    @shoot.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnShoot;
                    @shoot.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnShoot;
                    @bash.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnBash;
                    @bash.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnBash;
                    @bash.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnBash;
                    @teleport.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnTeleport;
                    @teleport.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnTeleport;
                    @teleport.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnTeleport;
                    @rocket.started -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnRocket;
                    @rocket.performed -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnRocket;
                    @rocket.canceled -= m_Wrapper.m_PlayerControlerActionsCallbackInterface.OnRocket;
                }
                m_Wrapper.m_PlayerControlerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @move.started += instance.OnMove;
                    @move.performed += instance.OnMove;
                    @move.canceled += instance.OnMove;
                    @look.started += instance.OnLook;
                    @look.performed += instance.OnLook;
                    @look.canceled += instance.OnLook;
                    @accept.started += instance.OnAccept;
                    @accept.performed += instance.OnAccept;
                    @accept.canceled += instance.OnAccept;
                    @back.started += instance.OnBack;
                    @back.performed += instance.OnBack;
                    @back.canceled += instance.OnBack;
                    @pause.started += instance.OnPause;
                    @pause.performed += instance.OnPause;
                    @pause.canceled += instance.OnPause;
                    @shoot.started += instance.OnShoot;
                    @shoot.performed += instance.OnShoot;
                    @shoot.canceled += instance.OnShoot;
                    @bash.started += instance.OnBash;
                    @bash.performed += instance.OnBash;
                    @bash.canceled += instance.OnBash;
                    @teleport.started += instance.OnTeleport;
                    @teleport.performed += instance.OnTeleport;
                    @teleport.canceled += instance.OnTeleport;
                    @rocket.started += instance.OnRocket;
                    @rocket.performed += instance.OnRocket;
                    @rocket.canceled += instance.OnRocket;
                }
            }
        }
        public PlayerControlerActions @PlayerControler => new PlayerControlerActions(this);
        private int m_XboxSchemeIndex = -1;
        public InputControlScheme XboxScheme
        {
            get
            {
                if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
                return asset.controlSchemes[m_XboxSchemeIndex];
            }
        }
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        public interface IPlayerControlerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnAccept(InputAction.CallbackContext context);
            void OnBack(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnBash(InputAction.CallbackContext context);
            void OnTeleport(InputAction.CallbackContext context);
            void OnRocket(InputAction.CallbackContext context);
        }
    }
}
