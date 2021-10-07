using UnityEngine;

namespace WarmUp 
{
    public sealed class EnteryPoint : MonoBehaviour
    {
        [SerializeField] Data _data;
        private Controllers _controllers;

        void Start()
        {
            _controllers = new Controllers();
            new GameInitialization(_controllers, _data);
            _controllers.Initialize();
        }

        void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            _controllers.LateExecute(deltaTime);
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}
