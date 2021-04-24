using System;
using System.Collections.Generic;
using System.Reflection;
using Godot;
using Newtonsoft.Json;

[Tool]
public partial class UMAOverlayGizmoPlugin : EditorNode3DGizmoPlugin
{
    public override string GetGizmoName()
    {
        return "UMAOverlayGizmoSpatial";
    }

    public override bool HasGizmo(Node3D spatial)
    {
        return (spatial is UMAOverlay);
    }

    public UMAOverlayGizmoPlugin() : base()
    {
        CreateMaterial("main", new Color(1, 0, 0));
        CreateHandleMaterial("handles");
    }

    public override void Redraw(EditorNode3DGizmo gizmo)
    {
        gizmo.Clear();
        var spatial = gizmo.GetSpatialNode();

        var lines = new List<Vector3>();

        lines.Add(new Vector3(0, 1, 0));
        // lines.Add(new Vector3(0, spatial.my_custom_value, 0));

        var handles = new List<Vector3>();

        handles.Add(new Vector3(0, 1, 0));
        //handles.Add(new Vector3(0, spatial.my_custom_value, 0));

        gizmo.AddLines(lines.ToArray(), GetMaterial("main", gizmo), false);
        gizmo.AddHandles(handles.ToArray(), GetMaterial("handles", gizmo));
    }
}