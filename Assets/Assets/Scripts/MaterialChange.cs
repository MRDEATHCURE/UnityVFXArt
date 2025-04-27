using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    [Header("Parts Renderers")]
    public Renderer mainBodyRenderer;
    public Renderer turretHeadRenderer;
    public Renderer turretHeadDetailsRenderer;
    public Renderer turretHeadEnergyRenderer;
    public Renderer barrelRenderer;
    public Renderer barrelEnergyRenderer;
    public Renderer barrelDetailsRenderer;
    public Renderer tracksRenderer;
    public Renderer trackSystemRenderer;

    public void ChangeMainBodyMaterial(Material newMaterial)
    {
        if (mainBodyRenderer != null && newMaterial != null)
            mainBodyRenderer.material = newMaterial;
    }

    public void ChangeTurretHeadMaterial(Material newMaterial)
    {
        if (turretHeadRenderer != null && newMaterial != null)
            turretHeadRenderer.material = newMaterial;
    }

    public void ChangeTurretHeadDetailsMaterial(Material newMaterial)
    {
        if (turretHeadDetailsRenderer != null && newMaterial != null)
            turretHeadDetailsRenderer.material = newMaterial;
    }

    public void ChangeTurretHeadEnergyMaterial(Material newMaterial)
    {
        if (turretHeadEnergyRenderer != null && newMaterial != null)
            turretHeadEnergyRenderer.material = newMaterial;
    }

    public void ChangeBarrelMaterial(Material newMaterial)
    {
        if (barrelRenderer != null && newMaterial != null)
            barrelRenderer.material = newMaterial;
    }

    public void ChangeBarrelEnergyMaterial(Material newMaterial)
    {
        if (barrelEnergyRenderer != null && newMaterial != null)
            barrelEnergyRenderer.material = newMaterial;
    }

    public void ChangeBarrelDetailsMaterial(Material newMaterial)
    {
        if (barrelDetailsRenderer != null && newMaterial != null)
            barrelDetailsRenderer.material = newMaterial;
    }

    public void ChangeTracksMaterial(Material newMaterial)
    {
        if (tracksRenderer != null && newMaterial != null)
            tracksRenderer.material = newMaterial;
    }

    public void ChangeTrackSystemMaterial(Material newMaterial)
    {
        if (trackSystemRenderer != null && newMaterial != null)
            trackSystemRenderer.material = newMaterial;
    }
}
