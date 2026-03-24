using UnityEngine;


[ExecuteAlways]
public class CrossSectionController : MonoBehaviour
{
    [Tooltip("切断の基準となる平面（Plane）のTransformをアサインします")]
    public Transform slicePlane;

    private Renderer _renderer;

    void Start()
    {
        // アタッチされたオブジェクトのRenderer（モデルの描画コンポーネント）を取得
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Planeが設定されていない、またはRendererがない場合は何もしない
        if (slicePlane == null || _renderer == null) return;

        // Planeの現在位置と、上方向（法線ベクトルの向き）を取得
        Vector3 planePosition = slicePlane.position;
        Vector3 planeNormal = slicePlane.up; // UnityのPlaneオブジェクトはY軸(up)が表面の向きになります

        // アタッチされている全てのマテリアル（外側と断面用の両方）に値を送る
        foreach (Material mat in _renderer.sharedMaterials)
        {
            if (mat != null)
            {
                // 先ほどShader Graphで設定したReference名と完全に一致させる必要があります
                mat.SetVector("_PlanePosition", planePosition);
                mat.SetVector("_PlaneNormal", planeNormal);
            }
        }
    }
}