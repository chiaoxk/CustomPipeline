using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
[ExecuteInEditMode]
public class PipelineInstance : RenderPipeline
{

    CommandBuffer cmd = null;
    private Color clearColor = Color.black;

    public PipelineInstance(Color clearColor)
    {
        Debug.Log(clearColor);
        this.clearColor = clearColor;
    }
    public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
    {
        base.Render(renderContext, cameras);
        cmd = new CommandBuffer();
        cmd.ClearRenderTarget(true, true, clearColor);

        renderContext.ExecuteCommandBuffer(cmd);
        cmd.Release();
        renderContext.Submit();
    }
}
