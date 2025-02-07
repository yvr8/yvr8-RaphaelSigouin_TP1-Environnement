using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float duree = 45f;
    float distance = 20f;

    // Start is called before the first frame update
    void Start()
    {
        // D�marre la coroutine
        StartCoroutine(Translation(new Vector3(-distance, 0f, -10f), new Vector3(distance, 0f, -10f), duree));
    }

    IEnumerator Translation(Vector3 _posDebut, Vector3 _posFin, float _duree)
    {
        float dureeParcourue = 0f;

        // Tant qu'on a pas fait toute la dur�e
        while (dureeParcourue < _duree)
        {
            // Calculer et appliquer la nouvelle position
            transform.position = Vector3.Lerp(_posDebut, _posFin, dureeParcourue / _duree);

            // Augmenter la dur�e parcourue
            dureeParcourue += Time.deltaTime;

            // Attendre la fin du frame
            yield return null;
        }

        // S'assurer que la position finale est parfaite
        transform.position = _posFin;

        // L�g�re pause
        yield return new WaitForSeconds(1f);

        // D�marrer la coroutine � l'envers
        StartCoroutine(Translation(_posFin, _posDebut, duree));
    }
}
