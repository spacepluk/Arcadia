using UnityEngine;
using UnityEngine.EventSystems;
using clojure.lang;

public class OnDragHook : ArcadiaBehaviour, IDragHandler   
{
  public void OnDrag(PointerEventData a)
  {
      var _go = gameObject;
      foreach (var fn in fns)
        fn.invoke(_go, a);
  }
}