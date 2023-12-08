using UnityEngine;

namespace Assets.Code
{
    public class ShowQuestionState : BaseState<GameStateMachine>
    {
        public override void Enter()
        {
            ShowPanel(Target.QuestionPanel.gameObject);

            for (int i = 0; i < Target.QuestionPanel.AnswersButtons.Count; i++)
            {
                var index = i;
                Target.QuestionPanel.AnswersButtons[index].onClick.AddListener(() => CheckAnswer(index));
            }

            Target.TruePanel.NextButton.onClick.AddListener(NextQuestion);
            Target.FalsePanel.NextButton.onClick.AddListener(NextQuestion);
        }

        public override void Exit()
        {
            HidePanel(Target.TruePanel.gameObject);
            HidePanel(Target.FalsePanel.gameObject);
            HidePanel(Target.QuestionPanel.gameObject);

            for (int i = 0; i < Target.QuestionPanel.AnswersButtons.Count; i++)
            {
                var index = i;
                Target.QuestionPanel.AnswersButtons[index].onClick.RemoveAllListeners();
            }

            Target.TruePanel.NextButton.onClick.RemoveListener(NextQuestion);
            Target.FalsePanel.NextButton.onClick.RemoveListener(NextQuestion);
        }
        
        private void CheckAnswer(int index)
        {
            if (index == Target.IndexRightAnswer)
            {
                Target.RightAnswers += 1;

                ShowPanel(Target.TruePanel.gameObject);
            }
            else
            {
                ShowPanel(Target.FalsePanel.gameObject);
            }
        }

        private void NextQuestion()
        {
            Target.QuestionIndex += 1;

            if (Target.Data.Length > Target.QuestionIndex)
            {
                Target.StateMachine.ChangeState<SetDataState>(state => state.Target = Target);
            }
            else
            {
                Target.StateMachine.ChangeState<ShowGameOverState>(state => state.Target = Target);
            }

            HidePanel(Target.TruePanel.gameObject);
            HidePanel(Target.FalsePanel.gameObject);
        }

        private void ShowPanel(GameObject panel)
        {
            panel.gameObject.SetActive(true);
        }

        private void HidePanel(GameObject panel)
        {
            panel.gameObject.SetActive(false);
        }
    }
}
