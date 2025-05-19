using UnityEngine;
using UnityEngine.UI;

public class CheckboxToggle : MonoBehaviour
{
    public Sprite checkboxEmpty;
    public Sprite checkboxMarked;
    public Image checkboxImage;

    private bool isChecked = false;

    public void ToggleCheckbox()
    {
        isChecked = !isChecked;

        checkboxImage.sprite = isChecked ? checkboxMarked : checkboxEmpty;
    }
}
