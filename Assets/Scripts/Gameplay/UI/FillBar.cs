using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    [SerializeField] GameObject _object;
    [SerializeField] float fillMultiplier;
    [SerializeField] Slider slider;

    void Update(){
        if (_object.TryGetComponent<ISliderValue>(out ISliderValue ISliderValue)){
            slider.value = ISliderValue.SliderValue() * fillMultiplier;
        }
    }
}
