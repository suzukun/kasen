namespace KasenCS
{
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    /// <summary>
    /// __
    /// </summary>
    public sealed class DraggableUI : MonoBehaviour, IDragHandler
    {
        private CanvasScaler canvasScaler;

        private float scale = 1f;

        public void OnDrag(PointerEventData e)
        {
            RectTransform parent = (RectTransform)this.transform.parent;
            Vector2 basePosition = parent.position;
            Vector2 worldPosition = e.position;
            Vector2 localPosition = worldPosition - basePosition;

            this.transform.localPosition = localPosition * this.scale;
        }

        public void Reset()
        {
            this.transform.localPosition = Vector3.zero;
        }

        private void Start()
        {
            this.canvasScaler = this.GetComponentInParent<CanvasScaler>();
        }

        private void Update()
        {
            if (this.canvasScaler)
            {
                this.scale = this.canvasScaler.referenceResolution.x / Screen.width;
            }
        }
    }
}
