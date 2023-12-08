using System;

namespace Assets.Code
{
    public interface IStateFactory : IDisposable
    {
        T Create<T>(IStateMachine stateMachine) where T : IState;
    }
}