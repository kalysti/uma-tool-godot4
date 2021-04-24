using System;
using Godot;

[Tool]
public partial class UmaBonePose : Node3D
{
    [Export]
    public Vector3 position = new Vector3();
    [Export]
    public Vector3 scale = new Vector3();
    [Export]
    public Quat rotation = new Quat();

    [Export]
    public int hash;

    [Export]
    public int parent;

    [Export]
    public string bone;

}
