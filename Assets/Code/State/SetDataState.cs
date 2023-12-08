using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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

            var tempTexture = Resources.Load<Texture2D>("q2.png");

            Debug.Log(tempTexture);

            panel.Background.sprite = Sprite.Create(tempTexture, new Rect(), new Vector2(0.5f, 0.5f));

            Target.StateMachine.ChangeState<ShowQuestionState>(state => state.Target = Target);
        }
    }
}
