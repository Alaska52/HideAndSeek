using UnityEngine;

public class InfluenceMap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    float[,] influences;
    public void SetLayerDimensions(int width, int height)
    {
        influences = new float[width,height];
    }

    public void OnUpdate()
    {

    }

    public void OnDrawGizmos()
    {
        
    }
}
