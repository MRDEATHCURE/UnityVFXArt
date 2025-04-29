using UnityEngine;

public class VFXMaterialChanger : MonoBehaviour
{
  
    public ParticleSystem[] particleSystems; 

    public void ChangeVFXMaterial(Material newMaterial)
    {
        if (newMaterial == null) return;

        foreach (ParticleSystem ps in particleSystems)
        {
            if (ps != null)
            {
                var renderer = ps.GetComponent<ParticleSystemRenderer>();
                if (renderer != null)
                {
                    renderer.material = newMaterial;
                }
            }
        }
    }
}

