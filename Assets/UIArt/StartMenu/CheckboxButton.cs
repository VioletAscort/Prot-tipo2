using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckboxButton : MonoBehaviour
{
    public Sprite checkboxEmpty;
    public Sprite checkboxMarked;
    public Image checkboxImage;

    public string sceneToLoad;

    private bool isChecked = false;

    public void ToggleCheckbox()
    {
        if (isChecked) return; // Impede clicar duas vezes

        isChecked = true;
        checkboxImage.sprite = checkboxMarked;

        // Espera 0.5s e vai para a cena
        Invoke(nameof(GoToScene), 0.5f);
    }

    void GoToScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
