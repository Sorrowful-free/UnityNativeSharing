using UnityEngine;
using UnityEngine.UI;

namespace Assets.NativeSharing
{
    public class TestSharing : MonoBehaviour
    {
        public InputField Input;
        public void ShareText()
        {
            NativeSharing.Share(Input.text);
        }
    }
}
