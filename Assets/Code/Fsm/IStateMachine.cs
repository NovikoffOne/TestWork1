using System;

namespace Assets.Code
{
    public interface IStateMachine : IDisposable
    {
        IState CurrentState { get; }

        void ChangeState<T>(Action<T> action = null) where T : IState, new();

        void Update();
    }
}