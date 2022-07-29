using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PartAnim : MonoBehaviour
{
    [SerializeField] private float step;
    
    private Sequence mySequence;
    
    public void Teleport(BoxCom newBox, int id)
    {
        mySequence.Kill();
        mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOMoveX( newBox.transform.position.x, 0));
        mySequence.Append(transform.DOMoveY( newBox.transform.position.y + step * 4, 0));
        mySequence.AppendInterval(0.1f);
        mySequence.Append(transform.DOMove(newBox.transform.position + new Vector3(0, step * id, 0), 0.35f));

    }

    public void MoveToCurrentSlot(BoxCom newBox, int id)
    {
        mySequence.Kill();
        mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOMove(newBox.transform.position + new Vector3(0, step * id, 0), 0.35f));
    }

    public void RestartLevel(BoxCom newBox)
    {
        mySequence.Kill();
        mySequence = DOTween.Sequence();
        mySequence.AppendInterval(0.1f);
        mySequence.Append(transform.DOMoveY( newBox.transform.position.y + step * 4, 0.35f));
    }
}
