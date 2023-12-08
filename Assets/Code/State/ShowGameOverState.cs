namespace Assets.Code
{
    public class ShowGameOverState : BaseState<GameStateMachine>
    {
        public override void Enter()
        {
            Target.GameOverPanel.gameObject.SetActive(true);
            Target.GameOverPanel.NextButton.onClick.AddListener(NextGame);
            Target.GameOverPanel.Result.text = $"Вы ответили правильно на {Target.RightAnswers} вопросов!";
        }

        public override void Exit()
        {
            Target.GameOverPanel.NextButton.onClick.RemoveListener(NextGame);

            Target.GameOverPanel.gameObject.SetActive(false);
        }

        public void NextGame()
        {
            Target.ResetStats();
            Target.StateMachine.ChangeState<MainMenuState>(state => state.Target = Target);
        }
    }
}
