using UnityEngine;


namespace Assets.Code
{
    public class GameStateMachine : MonoBehaviour
    {
        [SerializeField] private ResultPanel _truePanel;
        [SerializeField] private ResultPanel _falsePanel;
        [SerializeField] private GameOverPanel _gameOverPanel;
        [SerializeField] private StartPanel _startPanel;
        [SerializeField] private QuestionPanel _qustionPanel;

        private StateMachine _stateMachine;
        private Data[] _data;

        private int _questionIndex;
        private int _rightAnswers;
        private int _indexRightAnswers;

        public ResultPanel TruePanel => _truePanel;
        public ResultPanel FalsePanel => _falsePanel;
        public GameOverPanel GameOverPanel => _gameOverPanel;
        public StartPanel StartPanel => _startPanel;
        public QuestionPanel QuestionPanel => _qustionPanel;

        public Data[] Data => _data;

        public StateMachine StateMachine => _stateMachine;

        public int QuestionIndex
        {
            get
            {
                return _questionIndex;
            }
            set
            {
                if (value >= 0)
                    _questionIndex = value;
            }
        }

        public int RightAnswers
        {
            get
            {
                return _rightAnswers;
            }
            set
            {
                if (value >= 0)
                    _rightAnswers++;
            }
        }

        public int IndexRightAnswer
        {
            get
            {
                return _indexRightAnswers;
            }
            set
            {
                if (value >= 0)
                    _indexRightAnswers = value;
            }
        }

        private void Start()
        {
            _stateMachine = new StateMachine();

            _data = new JsonFormatter().GetFormatData();

            _stateMachine.ChangeState<MainMenuState>(state => state.Target = this);
        }

        public void ResetStats()
        {
            _rightAnswers = 0;
            _questionIndex = 0;
        }
    }
}
