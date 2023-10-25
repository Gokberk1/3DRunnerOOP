// GENERATED AUTOMATICALLY FROM 'Assets/GameFolder/Scripts/Concrete/Inputs/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace _3DRunnerOOP.Inputs
{
    public class @GameInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMove"",
            ""id"": ""207bd6ba-d003-41a1-9545-07cee406c522"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""231a592a-29ff-477f-ad9d-306dad08247b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""f3efc485-769a-4bc7-a72e-1e37d82c5353"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7b6f3bdc-f4d3-416f-85e5-3c347e9c06be"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""328e644e-5b55-49ff-a71c-804d442aa89d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerMove
            m_PlayerMove = asset.FindActionMap("PlayerMove", throwIfNotFound: true);
            m_PlayerMove_HorizontalMove = m_PlayerMove.FindAction("HorizontalMove", throwIfNotFound: true);
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

        // PlayerMove
        private readonly InputActionMap m_PlayerMove;
        private IPlayerMoveActions m_PlayerMoveActionsCallbackInterface;
        private readonly InputAction m_PlayerMove_HorizontalMove;
        public struct PlayerMoveActions
        {
            private @GameInput m_Wrapper;
            public PlayerMoveActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @HorizontalMove => m_Wrapper.m_PlayerMove_HorizontalMove;
            public InputActionMap Get() { return m_Wrapper.m_PlayerMove; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerMoveActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerMoveActions instance)
            {
                if (m_Wrapper.m_PlayerMoveActionsCallbackInterface != null)
                {
                    @HorizontalMove.started -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.performed -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.canceled -= m_Wrapper.m_PlayerMoveActionsCallbackInterface.OnHorizontalMove;
                }
                m_Wrapper.m_PlayerMoveActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HorizontalMove.started += instance.OnHorizontalMove;
                    @HorizontalMove.performed += instance.OnHorizontalMove;
                    @HorizontalMove.canceled += instance.OnHorizontalMove;
                }
            }
        }
        public PlayerMoveActions @PlayerMove => new PlayerMoveActions(this);
        public interface IPlayerMoveActions
        {
            void OnHorizontalMove(InputAction.CallbackContext context);
        }
    }
}
