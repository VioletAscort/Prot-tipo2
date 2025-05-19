using UnityEngine;

public class PauseController : MonoBehaviour
{
    //serve pra saber se o jogo já está pausado ou não quando o jogador aperta ESC
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // vai alternar o estado do jogo entre pausado e rodando
            TogglePause();
        }
    }

    void TogglePause()
    {
        //inverte o valor atual de isPaused, pausa ou despausa o jogo
        isPaused = !isPaused;

        // 1f = tempo normal  0f = tempo parado 
        /*O ? significa que se isPaused for true, o valor será 0f (pausa) e se isPaused for false, o valor será 1f (retoma)*/
        Time.timeScale = isPaused ? 0f : 1f;

        // Debug só pra testar
        Debug.Log(isPaused ? "Jogo pausado" : "Jogo retomado");
    }
}
