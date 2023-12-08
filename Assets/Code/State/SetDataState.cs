using UnityEngine;

namespace Assets.Code
{
    public class SetDataState : BaseState<GameStateMachine>
    {
        public override void Enter()
        {
            var panel = Target.QuestionPanel;

            panel.Question.text = Target.Data[Target.QuestionIndex].question;

            for (int i = 0; i < Target.Data[Target.QuestionIndex].answers.Length; i++)
            {
                panel.AnswersTexts[i].text = Target.Data[Target.QuestionIndex].answers[i].text;
            }

            for (int i = 0; i < Target.Data[Target.QuestionIndex].answers.Length; i++)
            {
                if (Target.Data[Target.QuestionIndex].answers[i].correct)
                {
                    Target.IndexRightAnswer = i;
                }
            }

            panel.Background.sprite = AssetBundle.LoadAsset<Sprite>(Target.Data[Target.QuestionIndex].background);

            Target.StateMachine.ChangeState<ShowQuestionState>(state => state.Target = Target);
        }
    }
}
