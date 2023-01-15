using UnityEngine;
using UnityEngine.UI;
using TMPro;

public static class UnityTypesExtensions {

    public static Vector4Serializable ToSerializable(this Vector4 vector) {
        return new Vector4Serializable(vector.x, vector.y, vector.z, vector.w);
    }

    public static Vector3Serializable ToSerializable(this Vector3 vector) {
        return new Vector3Serializable(vector.x, vector.y, vector.z);
    }

    public static Vector2Serializable ToSerializable(this Vector2 vector) {
        return new Vector2Serializable(vector.x, vector.y);
    }

    public static QuaternionSerializable ToSerializable(this Quaternion quat) {
        return new QuaternionSerializable(quat.x, quat.y, quat.z, quat.w);
    }

    public static ColorSerializable ToSerializable(this Color col) {
        return new ColorSerializable(col.r, col.g, col.b, col.a);
    }

    public static Matrix4x4Serializable ToSerializable(this Matrix4x4 matrix) {
        return new Matrix4x4Serializable(
            matrix.GetRow(0).ToSerializable(),
            matrix.GetRow(1).ToSerializable(),
            matrix.GetRow(2).ToSerializable(),
            matrix.GetRow(3).ToSerializable()
        );
    }

    public static TransformSerializable ToSerializable(this Transform tr) {
        return new TransformSerializable(tr);
    }

    public static SliderSerializable ToSerializable(this Slider slider) {
        return new SliderSerializable(slider);
    }

    public static ToggleSerializable ToSerializable(this Toggle toggle) {
        return new ToggleSerializable(toggle);
    }

    public static DropdownSerializable ToSerializable(this Dropdown dropdown) {
        return new DropdownSerializable(dropdown);
    }

    public static TMPDropdownSerializable ToSerializable(this TMP_Dropdown dropdown) {
        return new TMPDropdownSerializable(dropdown);
    }

    public static InputFieldSerializable ToSerializable(this InputField input) {
        return new InputFieldSerializable(input);
    }

    public static TMPInputFieldSerializable ToSerializable(this TMP_InputField input) {
        return new TMPInputFieldSerializable(input);
    }
   

}