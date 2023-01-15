using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

[System.Serializable]
public struct TransformSerializable {
    public Vector3Serializable position;
    public QuaternionSerializable rotation;
    public Vector3Serializable scale;

    public TransformSerializable(Transform tr) {
        this.position = tr.position.ToSerializable();
        this.rotation = tr.rotation.ToSerializable();
        this.scale = tr.localScale.ToSerializable();
    }

    public Transform ToTransform() {
        GameObject go = new GameObject();
        go.transform.position = this.position.ToVector3();
        go.transform.rotation = this.rotation.ToQuaternion();
        go.transform.localScale = this.scale.ToVector3();
        return go.transform;
    }
}

[System.Serializable]
public struct SliderSerializable {

    public float value;

    public SliderSerializable(Slider s) {
        this.value = s.value;
    }
}

[System.Serializable]
public struct ToggleSerializable {

    public bool value;

    public ToggleSerializable(Toggle t) {
        this.value = t.isOn;
    }
}

[System.Serializable]
public struct DropdownSerializable {

    public int value;

    public DropdownSerializable(Dropdown d) {
        this.value = d.value;
    }
}

[System.Serializable]
public struct TMPDropdownSerializable {

    public int value;

    public TMPDropdownSerializable(TMP_Dropdown d) {
        this.value = d.value;
    }
}

[System.Serializable]
public struct InputFieldSerializable {

    public string text;

    public InputFieldSerializable(InputField i) {
        this.text = i.text;
    }
}

[System.Serializable]
public struct TMPInputFieldSerializable {

    public string text;

    public TMPInputFieldSerializable(TMP_InputField i) {
        this.text = i.text;
    }
}