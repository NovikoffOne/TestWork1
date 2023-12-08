namespace Assets.Code
{
    public class MainMenuState : BaseState<GameStateMachine>
    {
        public override void Enter()
        {
            Target.StartPanel.gameObject.SetActive(true);
            Target.StartPanel.StartGameButton.onClick.AddListener(StartGame);
        }

        public override void Exit()
        {
            Target.StartPanel.gameObject.SetActive(false);
            Target.StartPanel.StartGameButton.onClick.RemoveListener(StartGame);
        }

        public void StartGame()
        {
            Target.StateMachine.ChangeState<SetDataState>(state => state.Target = Target);
        }
    }
}
