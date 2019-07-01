using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
[ExecuteInEditMode]
public class MPipelineAsset : RenderPipelineAsset
{

    private Color clearColor=Color.gray;

    [UnityEditor.MenuItem("SRP-Demo/Create Asset Pipeline")]
    static void CreateAssetPipeline()
    {
        var instance = ScriptableObject.CreateInstance<MPipelineAsset>();
        UnityEditor.AssetDatabase.CreateAsset(instance, "Assets/SRP-Demo/MPipelineAsset.asset");
    }


    protected override IRenderPipeline InternalCreatePipeline()
    {
        return new PipelineInstance(clearColor);
    }
}
