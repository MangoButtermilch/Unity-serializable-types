using UnityEngine;

[System.Serializable]
public struct Vector4Serializable {
    public float x, y, z, w;
    public Vector4Serializable(float x, float y, float z, float w) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public Vector4 ToVector4() {
        return new Vector4(this.x, this.y, this.z, this.w);
    }
}

[System.Serializable]
public struct Vector3Serializable {
    public float x, y, z;
    public Vector3Serializable(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3 ToVector3() {
        return new Vector3(this.x, this.y, this.z);
    }
}

[System.Serializable]
public struct Vector2Serializable {
    public float x, y;
    public Vector2Serializable(float x, float y) {
        this.x = x;
        this.y = y;
    }

    public Vector2 ToVector2() {
        return new Vector2(this.x, this.y);
    }
}

[System.Serializable]
public struct QuaternionSerializable {
    public float x, y, z, w;
    public QuaternionSerializable(float x, float y, float z, float w) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public Quaternion ToQuaternion() {
        return new Quaternion(this.x, this.y, this.z, this.w);
    }
}

[System.Serializable]
public struct ColorSerializable {
    public float r, g, b, a;
    public ColorSerializable(float r, float g, float b, float a) {
        this.r = r;
        this.g = g;
        this.b = g;
        this.a = a;
    }

    public Color ToColor() {
        return new Color(this.r, this.g, this.b, this.a);
    }
}

[System.Serializable]
public struct Matrix4x4Serializable {

    public Vector4Serializable row1, row2, row3, row4;

    public Matrix4x4Serializable(
        Vector4Serializable r1,
        Vector4Serializable r2,
        Vector4Serializable r3,
        Vector4Serializable r4) {
        this.row1 = r1;
        this.row2 = r2;
        this.row3 = r3;
        this.row4 = r4;
    }

    public Matrix4x4 ToMatrix4x4() {
        return new Matrix4x4(
            this.row1.ToVector4(),
            this.row2.ToVector4(),
            this.row3.ToVector4(),
            this.row4.ToVector4());
    }
}