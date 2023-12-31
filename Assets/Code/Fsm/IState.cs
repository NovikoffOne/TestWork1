﻿using System;

namespace Assets.Code
{
    public interface IState : IDisposable
    {
        public IStateMachine StateMachine { get; set; }

        void Enter();
        void Update();
        void Exit();
    }
}