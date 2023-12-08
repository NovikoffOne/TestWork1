using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code
{
    public class StartPanel : MonoBehaviour
    {
        [SerializeField] private Button _startGameButton;

        public Button StartGameButton => _startGameButton;
    }
}
