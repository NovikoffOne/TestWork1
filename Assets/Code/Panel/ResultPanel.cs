using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code
{
    public class ResultPanel : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public Button NextButton => _button;
    }
}
